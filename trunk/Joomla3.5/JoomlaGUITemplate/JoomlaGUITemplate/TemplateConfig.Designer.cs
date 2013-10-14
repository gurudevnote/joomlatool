partial class TemplateConfig
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
        this.folderOutput = new System.Windows.Forms.FolderBrowserDialog();
        this.label1 = new System.Windows.Forms.Label();
        this.txtOutputPath = new System.Windows.Forms.TextBox();
        this.cmdSelectPath = new System.Windows.Forms.Button();
        this.txtTemplateName = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.checkedListBoxPositions = new System.Windows.Forms.CheckedListBox();
        this.cmdGenerate = new System.Windows.Forms.Button();
        this.cmdSelectAll = new System.Windows.Forms.Button();
        this.cmdUnSelect = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(33, 29);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(39, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Output";
        // 
        // txtOutputPath
        // 
        this.txtOutputPath.Location = new System.Drawing.Point(135, 29);
        this.txtOutputPath.Name = "txtOutputPath";
        this.txtOutputPath.Size = new System.Drawing.Size(247, 20);
        this.txtOutputPath.TabIndex = 1;
        this.txtOutputPath.Text = "C:\\Documents and Settings\\Administrator\\Desktop";
        this.txtOutputPath.TextChanged += new System.EventHandler(this.txtOutputPath_TextChanged);
        // 
        // cmdSelectPath
        // 
        this.cmdSelectPath.Location = new System.Drawing.Point(405, 29);
        this.cmdSelectPath.Name = "cmdSelectPath";
        this.cmdSelectPath.Size = new System.Drawing.Size(29, 23);
        this.cmdSelectPath.TabIndex = 2;
        this.cmdSelectPath.Text = "...";
        this.cmdSelectPath.UseVisualStyleBackColor = true;
        this.cmdSelectPath.Click += new System.EventHandler(this.cmdSelectPath_Click);
        // 
        // txtTemplateName
        // 
        this.txtTemplateName.Location = new System.Drawing.Point(135, 65);
        this.txtTemplateName.Name = "txtTemplateName";
        this.txtTemplateName.Size = new System.Drawing.Size(247, 20);
        this.txtTemplateName.TabIndex = 1;
        this.txtTemplateName.Text = "general";
        this.txtTemplateName.TextChanged += new System.EventHandler(this.txtOutputPath_TextChanged);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(33, 72);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(82, 13);
        this.label2.TabIndex = 0;
        this.label2.Text = "Template Name";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(33, 110);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(49, 13);
        this.label3.TabIndex = 0;
        this.label3.Text = "Positions";
        // 
        // checkedListBoxPositions
        // 
        this.checkedListBoxPositions.FormattingEnabled = true;
        this.checkedListBoxPositions.Items.AddRange(new object[] {
            "head",
            "footer",
            "menu",
            "left",
            "right",
            "middle",
            "spotlight"});
        this.checkedListBoxPositions.Location = new System.Drawing.Point(135, 110);
        this.checkedListBoxPositions.Name = "checkedListBoxPositions";
        this.checkedListBoxPositions.Size = new System.Drawing.Size(247, 244);
        this.checkedListBoxPositions.TabIndex = 3;
        // 
        // cmdGenerate
        // 
        this.cmdGenerate.Location = new System.Drawing.Point(135, 383);
        this.cmdGenerate.Name = "cmdGenerate";
        this.cmdGenerate.Size = new System.Drawing.Size(108, 23);
        this.cmdGenerate.TabIndex = 2;
        this.cmdGenerate.Text = "Generate";
        this.cmdGenerate.UseVisualStyleBackColor = true;
        this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
        // 
        // cmdSelectAll
        // 
        this.cmdSelectAll.Location = new System.Drawing.Point(405, 110);
        this.cmdSelectAll.Name = "cmdSelectAll";
        this.cmdSelectAll.Size = new System.Drawing.Size(90, 23);
        this.cmdSelectAll.TabIndex = 2;
        this.cmdSelectAll.Text = "Select all";
        this.cmdSelectAll.UseVisualStyleBackColor = true;
        this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
        // 
        // cmdUnSelect
        // 
        this.cmdUnSelect.Location = new System.Drawing.Point(405, 151);
        this.cmdUnSelect.Name = "cmdUnSelect";
        this.cmdUnSelect.Size = new System.Drawing.Size(90, 23);
        this.cmdUnSelect.TabIndex = 2;
        this.cmdUnSelect.Text = "Un select";
        this.cmdUnSelect.UseVisualStyleBackColor = true;
        this.cmdUnSelect.Click += new System.EventHandler(this.cmdUnSelect_Click);
        // 
        // TemplateConfig
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(521, 489);
        this.Controls.Add(this.checkedListBoxPositions);
        this.Controls.Add(this.cmdGenerate);
        this.Controls.Add(this.cmdUnSelect);
        this.Controls.Add(this.cmdSelectAll);
        this.Controls.Add(this.cmdSelectPath);
        this.Controls.Add(this.txtTemplateName);
        this.Controls.Add(this.txtOutputPath);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "TemplateConfig";
        this.Text = "TemplateConfig";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderOutput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtOutputPath;
    private System.Windows.Forms.Button cmdSelectPath;
    private System.Windows.Forms.TextBox txtTemplateName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckedListBox checkedListBoxPositions;
    private System.Windows.Forms.Button cmdGenerate;
    private System.Windows.Forms.Button cmdSelectAll;
    private System.Windows.Forms.Button cmdUnSelect;
}