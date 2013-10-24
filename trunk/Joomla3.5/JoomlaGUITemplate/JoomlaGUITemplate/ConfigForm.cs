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
using dbRoot = MyMeta.dbRoot;
using ZeusContext = Zeus.ZeusContext;
using IZeusInput = Zeus.IZeusInput;
using MyMeta;
using System.Xml.Serialization;
namespace JoomlaGUITemplate
{
    public partial class ConfigForm : Form
    {
        private dbRoot myMeta;
        private IZeusInput zeusInput;
        private string _configFileName = "XmlConfig.xml";

        public ConfigForm(dbRoot myMeta, IZeusInput zeusInput)
        {
            this.myMeta = myMeta;
            this.zeusInput = zeusInput;

            InitializeComponent();
            cbDatabase.DataSource = myMeta.Databases;
            cbDatabase.DisplayMember = "Name";
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XmlConfig));
            XmlConfig config = new XmlConfig();
            if (File.Exists(_configFileName))
            {
                using (StreamReader reader = new StreamReader(_configFileName))
                {
                    config = serializer.Deserialize(reader) as XmlConfig;
                }
            }

            if (config != null)
            {
                txtOutputFolder.Text = config.OutPutPath;
                txtComponentName.Text = config.ComponentName;
                txtPrefixTable.Text = config.PrefixTable;
                txtPrefixSelect.Text = config.PrefixTableForSelect;
                cbAutoGenerate.Checked = config.IsAutoGeneration;
            }
            
            if (this.myMeta.Databases[0] != null)
            {
                this.lboxTables.DataSource = this.myMeta.Databases[0].Tables;
                this.lboxTables.DisplayMember = "Name";
                this.lboxTables.Refresh();
                lboxTables.ClearSelected();
                int size = this.lboxTables.Items.Count;
                for (int i = 0; i < size; i++)
                {
                    ITable tb = this.lboxTables.Items[i] as ITable;
                    if (tb != null
                        && !string.IsNullOrEmpty(txtPrefixSelect.Text)
                        && (tb.Name.ToLower().StartsWith(txtPrefixSelect.Text.ToLower()))
                    )
                    {
                        lboxTables.SetSelected(i, true);
                    }
                    if (config != null && config.SelectedTables != null)
                    {
                        if (config.SelectedTables.Contains(tb.Name))
                        {
                            lboxTables.SetSelected(i, true);
                        }
                    }
                }

            }
            this.zeusInput["path"] = txtOutputFolder.Text;

            if (config.IsAutoGeneration)
            {
                Generate();
            }
        }

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void cmdSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtOutputFolder.Text = folderBrowserDialog.SelectedPath;
            this.zeusInput["path"] = folderBrowserDialog.SelectedPath;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            Generate();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Generate()
        {
            if ((lboxTables.SelectedIndex >= 0) && txtOutputFolder.Text != "" && txtComponentName.Text != "")
            {
                SaveConfigToXmlFile();

                this.zeusInput["tableName"] = lboxTables.SelectedItems;
                this.zeusInput["Prefix"] = txtPrefixTable.Text;
                this.zeusInput["ComponentName"] = txtComponentName.Text;
                string zipFile = txtOutputFolder.Text + "\\" + "com_" + txtComponentName.Text.ToLower() + ".zip";
                string componentDirectory = txtOutputFolder.Text + "\\" + "com_" + txtComponentName.Text.ToLower();
                if (File.Exists(zipFile))
                {
                    File.Delete(zipFile);
                }

                if (Directory.Exists(componentDirectory))
                {
                    Directory.Delete(componentDirectory, true);
                }
            }
            else
            {
                MessageBox.Show("Please choose a Table or select a path");
            }
        }

        private void SaveConfigToXmlFile()
        {
            XmlConfig config = new XmlConfig();
            config.ComponentName = txtComponentName.Text;
            config.OutPutPath = txtOutputFolder.Text;
            config.PrefixTable = txtPrefixTable.Text;
            config.PrefixTableForSelect = txtPrefixSelect.Text;
            config.SelectedTables = new List<string>();
            config.IsAutoGeneration = cbAutoGenerate.Checked;
            foreach (ITable it in lboxTables.SelectedItems)
            {
                config.SelectedTables.Add(it.Name);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(XmlConfig));
            using (TextWriter writer = new StreamWriter(_configFileName))
            {
                serializer.Serialize(writer, config);
            }
        }

        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            int sizeItem = lboxTables.Items.Count;
            for (int i = 0; i < sizeItem; i++)
            {
                lboxTables.SetSelected(i, true);
            }
        }

        private void cmdUnSelectAll_Click(object sender, EventArgs e)
        {
            lboxTables.ClearSelected();
        }

        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdSaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfigToXmlFile();
        }

        private void cmdSelectBytablePrefix_Click(object sender, EventArgs e)
        {
            int size = this.lboxTables.Items.Count;
            for (int i = 0; i < size; i++)
            {
                ITable tb = this.lboxTables.Items[i] as ITable;
                if (tb != null
                    && (tb.Name.ToLower().StartsWith(txtPrefixSelect.Text.ToLower()))
                )
                {
                    lboxTables.SetSelected(i, true);
                }                
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            base.OnClosed(e);
        }
    }

    public class XmlConfig
    {
        public string OutPutPath { set; get; }
        public bool IsAutoGeneration { set; get; }
        public string ComponentName { set; get; }
        public string PrefixTable { set; get; }
        public string PrefixTableForSelect { set; get; }
        public List<string> SelectedTables { set; get; }
    }
}
