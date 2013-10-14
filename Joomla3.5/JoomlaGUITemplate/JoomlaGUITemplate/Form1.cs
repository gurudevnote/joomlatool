using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace JoomlaGUITemplate
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void cmdSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtOutputFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
           
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            int sizeItem = lboxTables.Items.Count;
            for (int i = 0; i < sizeItem; i++)
            {
                lboxTables.SetSelected(i,true);
            }
        }

        private void cmdUnSelectAll_Click(object sender, EventArgs e)
        {
            lboxTables.ClearSelected();
        }


        void GetAllFileInDirectory(string path, string prefixPath, ref List<string> files)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            if (files == null)
            {
                files = new List<string>();
            }

            if (string.IsNullOrEmpty(prefixPath))
            {
                prefixPath = string.Empty;
            }

            prefixPath = Regex.Replace(prefixPath, "\\+", "\\");
            prefixPath = Regex.Replace(prefixPath, "/+", "\\");

            DirectoryInfo directory = new DirectoryInfo(path);
            foreach (FileInfo file in directory.GetFiles())
            {
                files.Add(file.FullName.Replace(prefixPath, string.Empty));
            }

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                GetAllFileInDirectory(dir.FullName, prefixPath, ref files);
            }
        }

        public string GetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;
            return name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);
        }

        public string CorrectViewName(string view)
        {
            if (string.IsNullOrEmpty(view))
            {
                return string.Empty;
            }

            string[] arr = Regex.Split(view, "_+");
            string value = string.Empty;
            foreach (string str in arr)
            {
                value += UpperFirstChar(str);
            }
            return value;
        }
        public string UpperFirstChar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            int length = str.Length;

            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }
    }
}
