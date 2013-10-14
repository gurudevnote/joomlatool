using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dbRoot = MyMeta.dbRoot;
using ZeusContext = Zeus.ZeusContext;
using IZeusInput = Zeus.IZeusInput;
public partial class TemplateConfig : Form
{        
	private dbRoot myMeta;
	private IZeusInput zeusInput;

    public TemplateConfig(dbRoot myMeta, IZeusInput zeusInput)
	{
		this.myMeta    = myMeta;
		this.zeusInput = zeusInput;
		InitializeComponent();
        zeusInput["outputpath"] = txtOutputPath.Text;
	}

    public TemplateConfig()
    {
        InitializeComponent();
    }

    private void txtOutputPath_TextChanged(object sender, EventArgs e)
    {

    }

    private void cmdSelectPath_Click(object sender, EventArgs e)
    {
        folderOutput.ShowDialog();
        txtOutputPath.Text = folderOutput.SelectedPath;
        zeusInput["outputpath"] = txtOutputPath.Text;
        
    }

    private void cmdGenerate_Click(object sender, EventArgs e)
    {
        List<string> positions = new List<string>();
        foreach (object obj in checkedListBoxPositions.CheckedItems)
        {
            positions.Add(obj.ToString());
        }
        zeusInput["positions"] = positions;
        zeusInput["templatename"] = txtTemplateName.Text;
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void cmdSelectAll_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < checkedListBoxPositions.Items.Count; i++)
        {
            //checkedListBoxPositions.SetSelected(i, true);
            checkedListBoxPositions.SetItemChecked(i, true);
        }
    }

    private void cmdUnSelect_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < checkedListBoxPositions.Items.Count; i++)
        {
            //checkedListBoxPositions.SetSelected(i, true);
            checkedListBoxPositions.SetItemChecked(i, false);
        }
    }
}
