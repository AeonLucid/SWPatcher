﻿using SWPatcher.Properties;
using System;
using System.IO;
using System.Reflection;

namespace SWPatcher.Helpers.GlobalVar
{
    public static class UserSettings
    {
        public static string PatcherPath
        {
            get
            {
                return String.IsNullOrEmpty(Settings.Default.PatcherWorkingDirectory) ? PatcherPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Assembly.GetExecutingAssembly().GetName().Name) : Settings.Default.PatcherWorkingDirectory;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    Directory.CreateDirectory(value);
                    Directory.SetCurrentDirectory(value);
                }

                Settings.Default.PatcherWorkingDirectory = value;
                Settings.Default.Save();
            }
        }

        public static string GamePath
        {
            get
            {
                return Settings.Default.GameDirectory;
            }
            set
            {
                Settings.Default.GameDirectory = value;
                Settings.Default.Save();
            }
        }

        public static bool WantToPatchExe
        {
            get
            {
                return Settings.Default.WantToPatchSoulworkerExe;
            }
            set
            {
                string gameExePatchedPath = Path.Combine(PatcherPath, Strings.FileName.GameExe);
                if (File.Exists(gameExePatchedPath))
                    File.Delete(gameExePatchedPath);

                Settings.Default.WantToPatchSoulworkerExe = value;
                Settings.Default.Save();
            }
        }

        public static string GameId
        {
            get
            {
                return Settings.Default.GameUserId;
            }
            set
            {
                Settings.Default.GameUserId = value;
                Settings.Default.Save();
            }
        }

        public static string GamePw
        {
            get
            {
                return Settings.Default.GameUserPassword;
            }
            set
            {
                Settings.Default.GameUserPassword = value;
                Settings.Default.Save();
            }
        }

        public static bool WantToLogin
        {
            get
            {
                return Settings.Default.WantToLoginWithPatcher;
            }
            set
            {
                Settings.Default.WantToLoginWithPatcher = value;
                Settings.Default.Save();
            }
        }

        public static string LanguageName
        {
            get
            {
                return Settings.Default.LanguageName;
            }
            set
            {
                Settings.Default.LanguageName = value;
                Settings.Default.Save();
            }
        }

        public static byte InterfaceMode
        {
            get
            {
                return Settings.Default.UIMode;
            }
            set
            {
                Settings.Default.UIMode = value;
                Settings.Default.Save();
            }
        }

        public static string UILanguageCode
        {
            get
            {
                return Settings.Default.UILanguage;
            }
            set
            {
                Settings.Default.UILanguage = value;
                Settings.Default.Save();
            }
        }
    }
}
