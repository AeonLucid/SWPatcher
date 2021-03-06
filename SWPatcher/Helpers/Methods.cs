﻿using Ionic.Zip;
using MadMilkman.Ini;
using SWPatcher.General;
using SWPatcher.Helpers.GlobalVar;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SWPatcher.Helpers
{
    internal static class Methods
    {
        private static string DateFormat = "dd/MMM/yyyy h:mm tt";

        internal static DateTime ParseDate(string date)
        {
            return DateTime.ParseExact(date, DateFormat, CultureInfo.InvariantCulture);
        }

        internal static string DateToString(DateTime date)
        {
            return date.ToString(DateFormat, CultureInfo.InvariantCulture);
        }

        internal static bool HasNewTranslations(Language language)
        {
            string directory = language.Lang;

            if (!Directory.Exists(directory))
                return true;

            string filePath = Path.Combine(directory, Strings.IniName.Translation);
            if (!File.Exists(filePath))
                return true;

            IniFile ini = new IniFile();
            ini.Load(filePath);

            if (!ini.Sections.Contains(Strings.IniName.Patcher.Section))
                return true;

            var section = ini.Sections[Strings.IniName.Patcher.Section];
            if (!section.Keys.Contains(Strings.IniName.Pack.KeyDate))
                return true;

            string date = section.Keys[Strings.IniName.Pack.KeyDate].Value;

            return language.LastUpdate > ParseDate(date);
        }

        internal static bool IsSwPath(string path)
        {
            return Directory.Exists(path) && Directory.Exists(Path.Combine(path, Strings.FolderName.Data)) && File.Exists(Path.Combine(path, Strings.FileName.GameExe)) && File.Exists(Path.Combine(path, Strings.IniName.ClientVer));
        }

        internal static bool IsValidSwPatcherPath(string path)
        {
            return String.IsNullOrEmpty(path) || !IsSwPath(path) && IsValidSwPatcherPath(Path.GetDirectoryName(path));
        }

        internal static bool IsNewerGameClientVersion()
        {
            IniFile ini = new IniFile();
            ini.Load(Path.Combine(UserSettings.GamePath, Strings.IniName.ClientVer));

            return VersionCompare(GetServerVersion(), ini.Sections[Strings.IniName.Ver.Section].Keys[Strings.IniName.Ver.Key].Value);
        }

        internal static bool VersionCompare(string ver1, string ver2)
        {
            Version v1 = new Version(ver1);
            Version v2 = new Version(ver2);

            return v1 > v2;
        }

        private static string GetServerVersion()
        {
            return GetServerIni().Sections[Strings.IniName.Ver.Section].Keys[Strings.IniName.Ver.Key].Value;
        }

        internal static IniFile GetServerIni()
        {
            using (var client = new WebClient())
            using (var zippedFile = new TempFile())
            {
                client.DownloadFile(Urls.SoulworkerSettingsHome + Strings.IniName.ServerVer + ".zip", zippedFile.Path);

                using (var file = new TempFile())
                {
                    using (ZipFile zip = ZipFile.Read(zippedFile.Path))
                    {
                        ZipEntry entry = zip[0];
                        entry.FileName = Path.GetFileName(file.Path);
                        entry.Extract(Path.GetDirectoryName(file.Path), ExtractExistingFileAction.OverwriteSilently);
                    }

                    IniFile ini = new IniFile(new IniOptions
                    {
                        Encoding = Encoding.Unicode
                    });
                    ini.Load(file.Path);

                    return ini;
                }
            }
        }

        internal static void PatchExeFile(string gameExePath)
        {
            using (var client = new WebClient())
            using (var file = new TempFile())
            {
                var exeBytes = File.ReadAllBytes(gameExePath);
                string hexResult = BitConverter.ToString(exeBytes).Replace("-", "");

                client.DownloadFile(Urls.PatcherGitHubHome + Strings.IniName.BytesToPatch, file.Path);
                IniFile ini = new IniFile();
                ini.Load(file.Path);

                foreach (var section in ini.Sections)
                {
                    string original = section.Keys[Strings.IniName.PatchBytes.KeyOriginal].Value;
                    string patch = section.Keys[Strings.IniName.PatchBytes.KeyPatch].Value;

                    hexResult = hexResult.Replace(original, patch);
                }

                int charCount = hexResult.Length;
                byte[] resultBytes = new byte[charCount / 2];

                for (int i = 0; i < charCount; i += 2)
                    resultBytes[i / 2] = Convert.ToByte(hexResult.Substring(i, 2), 16);

                File.WriteAllBytes(gameExePath, resultBytes);
            }
        }

        internal static void SetSWFiles(List<SWFile> swfiles)
        {
            if (swfiles.Count > 0)
                return;

            using (var client = new WebClient())
            using (var file = new TempFile())
            {
                client.DownloadFile(Urls.PatcherGitHubHome + Strings.IniName.TranslationPackData, file.Path);
                IniFile ini = new IniFile();
                ini.Load(file.Path);

                foreach (var section in ini.Sections)
                {
                    string name = section.Name;
                    string path = section.Keys[Strings.IniName.Pack.KeyPath].Value;
                    string pathA = section.Keys[Strings.IniName.Pack.KeyPathInArchive].Value;
                    string pathD = section.Keys[Strings.IniName.Pack.KeyPathOfDownload].Value;
                    string format = section.Keys[Strings.IniName.Pack.KeyFormat].Value;
                    swfiles.Add(new SWFile(name, path, pathA, pathD, format));
                }
            }
        }

        internal static string VersionToRTP(Version version)
        {
            return $"{version.Major}_{version.Minor}_{version.Build}_{version.Revision}.RTP";
        }

        internal static void RTPatchCleanup()
        {
            string[] filters = { "RT*", "*.RTP" };
            foreach (var filter in filters)
                foreach (var file in Directory.GetFiles(UserSettings.GamePath, filter, SearchOption.AllDirectories))
                    File.Delete(file);
        }

        internal static void DoUnzipFile(string zipPath, string fileName, string extractDestination, string password)
        {
            using (var zip = ZipFile.Read(zipPath))
            {
                zip.Password = password;
                zip.FlattenFoldersOnExtract = true;
                zip[fileName].Extract(extractDestination, ExtractExistingFileAction.OverwriteSilently);
            }
        }

        internal static void DoZipFile(string zipPath, string fileName, string filePath, string password)
        {
            using (var zip = ZipFile.Read(zipPath))
            {
                zip.Password = password;
                zip.RemoveEntry(fileName);
                zip.AddFile(filePath, Path.GetDirectoryName(fileName));
                zip.Save();
            }
        }

        internal static void AddZipToZip(string zipPath, string destinationZipPath, string directoryInDestination, string password)
        {
            using (var zip = ZipFile.Read(zipPath))
            using (var destinationZip = ZipFile.Read(destinationZipPath))
            {
                zip.Password = password;
                var tempFileList = zip.Entries.Select(entry => new TempFile(Path.Combine(Path.GetTempPath(), Path.GetFileName(entry.FileName)))).ToList();
                zip.FlattenFoldersOnExtract = true;

                zip.ExtractAll(Path.GetTempPath(), ExtractExistingFileAction.OverwriteSilently);

                destinationZip.RemoveEntries(zip.Entries.Select(e => Path.Combine(directoryInDestination, e.FileName)).ToList());
                destinationZip.AddFiles(tempFileList.Select(tf => tf.Path), directoryInDestination);
                destinationZip.Save();

                tempFileList.ForEach(tf => tf.Dispose());
            }
        }

        internal static bool IsTranslationOutdated(Language language)
        {
            string selectedTranslationPath = Path.Combine(language.Lang, Strings.IniName.Translation);
            if (!File.Exists(selectedTranslationPath))
                return true;

            IniFile ini = new IniFile();
            ini.Load(selectedTranslationPath);

            if (!ini.Sections[Strings.IniName.Patcher.Section].Keys.Contains(Strings.IniName.Patcher.KeyVer))
                throw new Exception(StringLoader.GetText("exception_read_translation_ini"));

            Version translationVer = new Version(ini.Sections[Strings.IniName.Patcher.Section].Keys[Strings.IniName.Patcher.KeyVer].Value);
            ini.Sections.Clear();
            ini.Load(Path.Combine(UserSettings.GamePath, Strings.IniName.ClientVer));

            Version clientVer = new Version(ini.Sections[Strings.IniName.Ver.Section].Keys[Strings.IniName.Ver.Key].Value);
            if (clientVer > translationVer)
                return true;

            return false;
        }
    }
}
