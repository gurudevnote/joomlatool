using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeus;
using MyMeta;
using Dnp.Utils;
using Zeus.DotNetScript;
using Zeus.Data;
using Zeus.UserInterface;

class CommonFunction
{

}

public partial class GeneratedTemplate : _DotNetScriptTemplate
{
    public string TemplateName
    {
        get { return "Joomla Component Create"; }
    }

	protected Zeus.UserInterface.GuiController ui;
	protected MyMeta.dbRoot MyMeta;
	protected Dnp.Utils.Utils DnpUtils;
    public GeneratedTemplate(IZeusContext context)
        : base(context)
	{
		this.ui = context.Objects["ui"] as Zeus.UserInterface.GuiController;
        this.MyMeta = context.Objects["MyMeta"] as MyMeta.dbRoot;
        this.DnpUtils = context.Objects["DnpUtils"] as Dnp.Utils.Utils;
	}

    private void GetComponentXmlContentFile(string ComponentName, string p, string p_3, List<string> siteFiles, List<string> adminFiles)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAccessXmlFile(string p, List<string> SelectedTables)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminComponentConfigXml(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateSqlUnInstallFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateSqlInstallFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateForm(string p, string view)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminModelEdit(string p, string view)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminViewEdit(string p, string view)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminViewTemplateList(string p, string view)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminViewList(string p, string view)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminModelList(string p, string view)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminHelperFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminControllerFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminComponentFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreatSiteControllerFile(string p)
    {
        throw new System.NotImplementedException();
    }

    private void CreateIndexHtmlFile(string currentPath)
    {
        throw new System.NotImplementedException();
    }

    private void CreateAdminControllerEdit(string path, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminControllerList(string path, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminViewTemplateEditMeta(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminViewTemplateEdit(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminTable(string path, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateVNResourceFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateEnglishResourceFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteMetaDataFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteIconFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteHelperCategory(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteQueryFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteHelperFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteRouteFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteComponentFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSysVNResourceFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateSysEnglishResourceFile(string p)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminModelFieldsEdit(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminModelFieldsModal(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateAdminViewTemplateListModal(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteControllerEdit(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteForm(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewTemplateViewOne(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewTemplateViewOneDefaultLink(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewTemplateViewOneDefaultXml(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteModelEditFile(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewOne(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewTemplateList(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewTemplateDefaultXml(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteMetaDataFileForView(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewList(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteModelListFile(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewForm(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewFormMetaData(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewFormEditModel(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewFormEditTemplateXml(string p, string view)
    {
        throw new NotImplementedException();
    }

    private void CreateSiteViewFormEditTemplate(string p, string view)
    {
        throw new NotImplementedException();
    }
}