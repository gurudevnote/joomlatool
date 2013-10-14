using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public partial class JoomlaTemplate
{

    public string CurrentTemplatePath
    {
        get
        {
            return context.ExecutingTemplate.FilePath;
        }
    }

    public string CurrentTemplateRoot
    {
        get
        {
            return CurrentTemplatePath + "\\JoomlaGUITemplate\\JoomlaGUITemplate\\template\\";
        }
    }

    public string CurrentTemplateImagePath
    {
        get
        {
            return CurrentTemplatePath + "\\JoomlaGUITemplate\\JoomlaGUITemplate\\template\\images\\";
        }
    }

    public string CurrentTemplateCssPath
    {
        get
        {
            return CurrentTemplatePath + "\\JoomlaGUITemplate\\JoomlaGUITemplate\\template\\css\\";
        }
    }

    public string CurrentTemplateJavaScriptPath
    {
        get
        {
            return CurrentTemplatePath + "\\JoomlaGUITemplate\\JoomlaGUITemplate\\template\\javascript\\";
        }
    }

    public string CurrentTemplateFontsPath
    {
        get
        {
            return CurrentTemplatePath + "\\JoomlaGUITemplate\\JoomlaGUITemplate\\template\\fonts\\";
        }
    }    

    public string CurrentDirectory
    {
        get
        {
            DirectoryInfo dirInfor = new DirectoryInfo(".");
            return dirInfor.FullName;
        }
    }
    public List<string> Positions
    {
        get 
        {
            List<string> pos = ((List<string>)input["positions"]);
            List<string> returnList = new List<string>();
            foreach(string position in pos)
            {
                returnList.Add(TemplateName + "_" + position);
            }
            return returnList;
        }  
    }
    public string OutputPath
    {
        get
        {
            return input["outputpath"].ToString() + "\\" + TemplateName;
        }
    }

    public string StartCopyrightYear
    {
        get
        {
            return "2011";
        }
    }

    public string CurrentCopyrightYear
    {
        get
        {
            return DateTime.Now.Year.ToString();
        }
    }

    public string CopyrightYear
    {
        get 
        {
            return string.Format("{0} - {1}", StartCopyrightYear, CurrentCopyrightYear);
        }
    }

    public string TemplateName
    {
        get
        {
            return input["templatename"].ToString();
        }
    }

    public override void Render()
    {
        CreatetemplateDetailsXML(OutputPath + "\\templateDetails.xml");
        DirectoryUtils dUtils = new DirectoryUtils();
        dUtils.CreateFolder(OutputPath + "\\css");
        dUtils.CreateFolder(OutputPath + "\\html");
        dUtils.CreateFolder(OutputPath + "\\images");
        dUtils.CreateFolder(OutputPath + "\\javascript");
        dUtils.CreateFolder(OutputPath + "\\fonts");
        dUtils.CreateFolder(OutputPath + "\\language");
        //output.writeln(CurrentDirectory);
        //output.writeln(CurrentTemplatePath);

        //copy favicon.ico, template_preview.png, template_thumbnail.png
        CopyFilesToFolder(CurrentTemplateRoot, OutputPath);


        CopyFilesToFolder(CurrentTemplateImagePath, OutputPath + "\\images");
        CopyFilesToFolder(CurrentTemplateCssPath, OutputPath + "\\css");
        CopyFilesToFolder(CurrentTemplateFontsPath, OutputPath + "\\fonts");
        CopyFilesToFolder(CurrentTemplateJavaScriptPath, OutputPath + "\\javascript");

        //Create index.php
        CreateIndexPhp(OutputPath + "\\index.php");
        CreateComponentPhp(OutputPath + "\\component.php");
        CreateErrorPhp(OutputPath + "\\error.php");

        //create vietnam language
        CreateVietNameLanuage(OutputPath + "\\language\\vi-VN\\vi-VN.tpl_" + TemplateName + ".ini");
        CreateVietNameLanuage(OutputPath + "\\language\\vi-VN\\vi-VN.tpl_" + TemplateName + ".sys.ini");

        //create english language
        CreateEnglishLanuage(OutputPath + "\\language\\en-GB\\en-GB.tpl_" + TemplateName + ".ini");
        CreateEnglishLanuage(OutputPath + "\\language\\en-GB\\en-GB.tpl_" + TemplateName + ".sys.ini");

        //create componenet.php

        //create error.php

        //create html module
    }

    private void CopyFilesToFolder(string sourcepath, string despath)
    {
        DirectoryInfo infor = new DirectoryInfo(sourcepath);
        foreach (FileInfo file in infor.GetFiles())
        {
            string destiFile = despath + "\\" + file.Name;
            if (!File.Exists(destiFile))
            {
                File.Copy(file.FullName, destiFile);
            }
        }

        /*
        foreach(DirectoryInfo dic in infor.GetDirectories())
        {
            DirectoryUtils.CopyDirectory(dic.FullName, despath);
        }
         * */
    }
}
