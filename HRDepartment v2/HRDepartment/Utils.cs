using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace HRDepartment
{
    /// <summary>
    /// Класс для хранения общих настроек и методов
    /// </summary>
    static class Utils
    {
        public static bool IsAdmin;
        public static bool IsHR;
        public static bool IsDirector;

        public static void OpenInAnotherApp(byte[] data, string filename)
        {
            var tempFolder = System.IO.Path.GetTempPath();
            filename = System.IO.Path.Combine(tempFolder, filename);
            System.IO.File.WriteAllBytes(filename, data);
            System.Diagnostics.Process.Start(filename);
        }
    }
}
