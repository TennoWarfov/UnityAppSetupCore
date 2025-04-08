using System;
using System.IO;
using UnityEngine;

namespace Core.Common
{
    public static class DirectoryPath
    {
        public static void CheckDirectories()
        {
            var root = Application.persistentDataPath;

            var language = Language.Code;
            
            var jsons = root + "/Jsons/" + language;
            
            CheckDirectory(jsons);
        }

        private static void CheckDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to create directory: {path}. Error: {e.Message}");
            }
        }
    }
}
