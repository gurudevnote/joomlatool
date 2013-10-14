using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeus.DotNetScript;
using Zeus;
public partial class JoomlaTemplate: _DotNetScriptTemplate
{
    public string TemplateNameDescription
    {
        get { return "Joomla Template Create"; }
    }

	protected Zeus.UserInterface.GuiController ui;
	protected MyMeta.dbRoot MyMeta;
	protected Dnp.Utils.Utils DnpUtils;
    public JoomlaTemplate(IZeusContext context)
        : base(context)
	{
		this.ui = context.Objects["ui"] as Zeus.UserInterface.GuiController;
        this.MyMeta = context.Objects["MyMeta"] as MyMeta.dbRoot;
        this.DnpUtils = context.Objects["DnpUtils"] as Dnp.Utils.Utils;
	}

    private void CreatetemplateDetailsXML(string path)
    {

    }

    private void CreateErrorPhp(string path)
    {
        throw new NotImplementedException();
    }

    private void CreateComponentPhp(string path)
    {
        throw new NotImplementedException();
    }

    private void CreateIndexPhp(string path)
    {
        throw new NotImplementedException();
    }

    private void CreateIndexphp(string path)
    {
        throw new NotImplementedException();
    }

    private void CreateEnglishLanuage(string path)
    {
        throw new NotImplementedException();
    }

    private void CreateVietNameLanuage(string path)
    {
        DirectoryUtils utils = new DirectoryUtils();
    }
}
