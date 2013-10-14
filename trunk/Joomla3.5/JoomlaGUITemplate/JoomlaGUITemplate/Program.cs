using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace JoomlaGUITemplate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConfigForm());
        }

        //void CreateFolder(string path)
        //{
        //    if (string.IsNullOrEmpty(path))
        //    { 
        //        return;
        //    }
        //    string[] folders = path.Split("/\\".ToCharArray());
        //    string currentPath = string.Empty;
        //    foreach (string folder in folders)
        //    {
        //        if (string.IsNullOrEmpty(folder))
        //        {
        //            continue;
        //        }
        //        currentPath += "\\" + folder;
        //        if (!Directory.Exists(currentPath))
        //        {
        //            Directory.CreateDirectory(currentPath);
        //        }
        //    }
        //}        
    }
}
