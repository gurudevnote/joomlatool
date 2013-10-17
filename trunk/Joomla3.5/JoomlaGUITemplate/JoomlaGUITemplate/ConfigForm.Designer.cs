namespace JoomlaGUITemplate
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxTables = new System.Windows.Forms.ListBox();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrefixTable = new System.Windows.Forms.TextBox();
            this.cmdSelectAll = new System.Windows.Forms.Button();
            this.cmdUnSelectAll = new System.Windows.Forms.Button();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.txtPrefixSelect = new System.Windows.Forms.TextBox();
            this.cmdSelectBytablePrefix = new System.Windows.Forms.Button();
            this.cbAutoGenerate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Out put";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(150, 13);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(219, 20);
            this.txtOutputFolder.TabIndex = 1;
            this.txtOutputFolder.Text = "C:\\Documents and Settings\\Administrator\\Desktop\\Component";
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.Location = new System.Drawing.Point(385, 10);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(38, 23);
            this.cmdSelectFolder.TabIndex = 2;
            this.cmdSelectFolder.Text = "...";
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select tables";
            // 
            // lboxTables
            // 
            this.lboxTables.FormattingEnabled = true;
            this.lboxTables.Location = new System.Drawing.Point(150, 153);
            this.lboxTables.Name = "lboxTables";
            this.lboxTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxTables.Size = new System.Drawing.Size(219, 212);
            this.lboxTables.TabIndex = 4;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(150, 371);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(75, 23);
            this.cmdGenerate.TabIndex = 5;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "database";
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(150, 54);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(219, 21);
            this.cbDatabase.TabIndex = 7;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Component name";
            // 
            // txtComponentName
            // 
            this.txtComponentName.Location = new System.Drawing.Point(150, 95);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(219, 20);
            this.txtComponentName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prefix table";
            // 
            // txtPrefixTable
            // 
            this.txtPrefixTable.Location = new System.Drawing.Point(150, 121);
            this.txtPrefixTable.Name = "txtPrefixTable";
            this.txtPrefixTable.Size = new System.Drawing.Size(219, 20);
            this.txtPrefixTable.TabIndex = 9;
            this.txtPrefixTable.Text = "kdro5_";
            // 
            // cmdSelectAll
            // 
            this.cmdSelectAll.Location = new System.Drawing.Point(385, 153);
            this.cmdSelectAll.Name = "cmdSelectAll";
            this.cmdSelectAll.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectAll.TabIndex = 5;
            this.cmdSelectAll.Text = "Select all";
            this.cmdSelectAll.UseVisualStyleBackColor = true;
            this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // cmdUnSelectAll
            // 
            this.cmdUnSelectAll.Location = new System.Drawing.Point(385, 205);
            this.cmdUnSelectAll.Name = "cmdUnSelectAll";
            this.cmdUnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.cmdUnSelectAll.TabIndex = 5;
            this.cmdUnSelectAll.Text = "Un Select all";
            this.cmdUnSelectAll.UseVisualStyleBackColor = true;
            this.cmdUnSelectAll.Click += new System.EventHandler(this.cmdUnSelectAll_Click);
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.Location = new System.Drawing.Point(231, 371);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(129, 24);
            this.cmdSaveConfig.TabIndex = 10;
            this.cmdSaveConfig.Text = "Save Config";
            this.cmdSaveConfig.UseVisualStyleBackColor = true;
            this.cmdSaveConfig.Click += new System.EventHandler(this.cmdSaveConfig_Click);
            // 
            // txtPrefixSelect
            // 
            this.txtPrefixSelect.Location = new System.Drawing.Point(385, 243);
            this.txtPrefixSelect.Name = "txtPrefixSelect";
            this.txtPrefixSelect.Size = new System.Drawing.Size(100, 20);
            this.txtPrefixSelect.TabIndex = 11;
            // 
            // cmdSelectBytablePrefix
            // 
            this.cmdSelectBytablePrefix.Location = new System.Drawing.Point(385, 269);
            this.cmdSelectBytablePrefix.Name = "cmdSelectBytablePrefix";
            this.cmdSelectBytablePrefix.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectBytablePrefix.TabIndex = 12;
            this.cmdSelectBytablePrefix.Text = "Select table";
            this.cmdSelectBytablePrefix.UseVisualStyleBackColor = true;
            this.cmdSelectBytablePrefix.Click += new System.EventHandler(this.cmdSelectBytablePrefix_Click);
            // 
            // cbAutoGenerate
            // 
            this.cbAutoGenerate.AutoSize = true;
            this.cbAutoGenerate.Location = new System.Drawing.Point(386, 310);
            this.cbAutoGenerate.Name = "cbAutoGenerate";
            this.cbAutoGenerate.Size = new System.Drawing.Size(135, 17);
            this.cbAutoGenerate.TabIndex = 14;
            this.cbAutoGenerate.Text = "Auto Generate Source ";
            this.cbAutoGenerate.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 424);
            this.Controls.Add(this.cbAutoGenerate);
            this.Controls.Add(this.cmdSelectBytablePrefix);
            this.Controls.Add(this.txtPrefixSelect);
            this.Controls.Add(this.cmdSaveConfig);
            this.Controls.Add(this.txtPrefixTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComponentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdUnSelectAll);
            this.Controls.Add(this.cmdSelectAll);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.lboxTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSelectFolder);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.label1);
            this.Name = "ConfigForm";
            this.Text = "Configuaration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button cmdSelectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxTables;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrefixTable;
        private System.Windows.Forms.Button cmdSelectAll;
        private System.Windows.Forms.Button cmdUnSelectAll;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.Windows.Forms.TextBox txtPrefixSelect;
        private System.Windows.Forms.Button cmdSelectBytablePrefix;
        private System.Windows.Forms.CheckBox cbAutoGenerate;
    }
}

