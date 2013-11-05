using System.Collections.Generic;
using System.Collections;
using System.IO;
using ITable = MyMeta.ITable;
using IColumn = MyMeta.IColumn;
using IForeignKey = MyMeta.IForeignKey;
using Regex = System.Text.RegularExpressions.Regex;
using ZeusContext = Zeus.ZeusContext;
using System;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;
public partial class GeneratedTemplate
{
    public string ExtendsFileName 
    {
        get { return "JoomlaGUITemplate/JoomlaGUITemplate/CommonFunction.cs"; }
    }
	
	public IList<string> DefaultTitleFields
    {
        get 
        {
            IList<string> returnList = new List<string>();
            returnList.Add("title");
            returnList.Add("name");
            returnList.Add("alias");
            return returnList;
        }
    }

    public IList<string> DefaultColumnJointWithOtherTable
    {
        get
        {
            IList<string> returnList = new List<string>();
            returnList.Add("language");
            returnList.Add("checked_out");
            returnList.Add("access");
            returnList.Add("catid");
            returnList.Add("created_by");
            return returnList;
        }
    }
	
	public IList<string> OnContentPrepareFields
    {
        get 
        {
            IList<string> returnList = new List<string>();
            returnList.Add("introtext");
            returnList.Add("fulltext");
            returnList.Add("description");
			returnList.Add("message");
			returnList.Add("message");
            return returnList;
        }
    }	
	
	public IList<string> FieldsDisplayAtModalListView
    {
        get 
        {
            IList<string> returnList = new List<string>();
            returnList.Add("title");
            returnList.Add("name");
            //returnList.Add("alias");
			returnList.Add("id");
			returnList.Add("catid");
			returnList.Add("language");
			returnList.Add("created");
			returnList.Add("access_level");
            return returnList;
        }
    }
	
	public IList<string> FieldsDisplayAtListView
    {
        get 
        {
            IList<string> returnList = new List<string>();
            returnList.Add("title");
            returnList.Add("name");
            //returnList.Add("alias");
			returnList.Add("id");
			returnList.Add("catid");
			returnList.Add("language");
			returnList.Add("created");
			returnList.Add("access_level");
			returnList.Add("ordering");
			returnList.Add("state");
			returnList.Add("access");
			returnList.Add("created");
			returnList.Add("hits");
            return returnList;
        }
    }	

    public IList<string> FieldsDonotDisplayAtModalListView
    {
        get
        {
            IList<string> returnList = new List<string>();
            returnList.Add("created_by_alias");
            returnList.Add("publish_up");
            returnList.Add("publish_down");
            returnList.Add("modified_by");
            returnList.Add("modified");
            returnList.Add("checked_out");
            returnList.Add("checked_out_time");
            returnList.Add("metakey");
            returnList.Add("metadesc");
            returnList.Add("description");
            returnList.Add("alias");
            return returnList;
        }
    }

    public IColumn GetColumnByColumnName(ITable table, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        if (table == null)
        {
            return null;
        }


        foreach (IColumn cl in table.Columns)
        {
            if (cl.Name.ToLower().Equals(name.ToLower()))
            {
                return cl;
            }
        }

        return null;
    }

    public IList<IColumn> GetListColumnOrder(ITable table)
    {
        //Status	 Title		 Access	 Association	 Author	 Language	 Date	 Hits	 ID
		IList<IColumn> list = new List<IColumn>();
        if(table == null)
        {
            return list;
        }
		
        foreach(IColumn cl in table.Columns)
        {
            if(cl.Name.ToLower().Equals("title")
                || cl.Name.ToLower().Equals("name")
                   || cl.Name.ToLower().Equals("alias")
				   || cl.Name.ToLower().Equals("id")
                )
            {
                continue;
            }
            else
            {
                list.Add(cl);
            }
        }

		if (IsContainColumn(table, "id"))
        {
            IColumn aliasCl = GetColumnByColumnName(table, "id");
            if (aliasCl != null)
            {
                list.Insert(0, aliasCl);
            }
        }		
		
        if (IsContainColumn(table, "alias"))
        {
            IColumn aliasCl = GetColumnByColumnName(table, "alias");
            if (aliasCl != null)
            {
                list.Insert(0, aliasCl);
            }
        }

        if (IsContainColumn(table, "name"))
        {
            IColumn aliasCl = GetColumnByColumnName(table, "name");
            if (aliasCl != null)
            {
                list.Insert(0, aliasCl);
            }
        }

        if (IsContainColumn(table, "title"))
        {
            IColumn aliasCl = GetColumnByColumnName(table, "title");
            if (aliasCl != null)
            {
                list.Insert(0, aliasCl);
            }
        }

        return list;
    }
	
	public IList<string> GetFieldsDisplayAtModalListView(ITable table)
	{
		IList<string> returnList = new List<string>();
		foreach (IColumn col in table.Columns)
        {
			string colName = col.Name.ToLower();
			if (FieldsDisplayAtModalListView.Contains(colName))
			{
				returnList.Add(colName);				
			}
        }

        if (returnList.Contains("alias"))
        {
            returnList.Remove("alias");
            returnList.Insert(0, "alias");
        }

        if (returnList.Contains("name"))
        {
            returnList.Remove("name");
            returnList.Insert(0, "name");
        }

        if (returnList.Contains("title"))
        {
            returnList.Remove("title");
            returnList.Insert(0, "title");
        }

		return returnList;
	}
	
	public IList<string> GetFieldsDisplayAtListView(ITable table)
	{
		IList<string> returnList = new List<string>();
		foreach (IColumn col in table.Columns)
        {
			string colName = col.Name.ToLower();
			if (FieldsDisplayAtListView.Contains(colName))
			{
				returnList.Add(colName);				
			}
        }
		
		if (returnList.Contains("id"))
        {
            returnList.Remove("id");
            returnList.Insert(0, "id");
        }		

		if (returnList.Contains("hits"))
        {
            returnList.Remove("hits");
            returnList.Insert(0, "hits");
        }
		
		if (returnList.Contains("created"))
        {
            returnList.Remove("created");
            returnList.Insert(0, "created");
        }

		if (returnList.Contains("created_by"))
        {
            returnList.Remove("created_by");
            returnList.Insert(0, "created_by");
        }

		if (returnList.Contains("language"))
        {
            returnList.Remove("language");
            returnList.Insert(0, "language");
        }				
		
        if (returnList.Contains("access"))
        {
            returnList.Remove("access");
            returnList.Insert(0, "access");
        }		

        if (returnList.Contains("alias"))
        {
            returnList.Remove("alias");
            returnList.Insert(0, "alias");
        }

        if (returnList.Contains("name"))
        {
            returnList.Remove("name");
            returnList.Insert(0, "name");
        }		
		
        if (returnList.Contains("title"))
        {
            returnList.Remove("title");
            returnList.Insert(0, "title");
        }		
		
        if (returnList.Contains("state"))
        {
            returnList.Remove("state");
            returnList.Insert(0, "state");
        }		
		
        if (returnList.Contains("ordering"))
        {
            returnList.Remove("ordering");
            returnList.Insert(0, "ordering");
        }

		return returnList;
	}	
	
	public string GetTitleFieldName(ITable table)
	{
		foreach(string title in DefaultTitleFields)
		{
			if(IsContainColumn(table,title))
			{
				return title;
			}
		}
		
		return GetFirstColumn(table).Name;
	}

    public IList<string> NotCreateTables
    {
        get 
        {
            IList<string> returnList = new List<string>();
            returnList.Add("asset");
            returnList.Add("category");
            returnList.Add("content");
            returnList.Add("extension");
            returnList.Add("language");
            returnList.Add("menu");
            returnList.Add("menutype");
            returnList.Add("module");
            returnList.Add("session");
            returnList.Add("update");
            returnList.Add("user");
            returnList.Add("usergroup");
            returnList.Add("viewlevel");
            return returnList;
        }
    }
	
	public string GetInputTypeByColumn(IColumn col)
	{
		if(col==null)
		{
			return "";
		}

        if (!col.IsInForeignKey)
        {
            return "";
        }

        foreach (IForeignKey obj in col.ForeignKeys)
        {
            foreach (IColumn frCol in obj.PrimaryColumns)
            {
                //System.Diagnostics.Debugger.Break();                
                if (col.Table.Name.Equals(frCol.Table.Name) && col.Name.Equals(frCol.Name))
                {
                    //TODO: set input type                    
                    //return GetEditView(GetViewNameFromTable(frCol.Table)) + "Edit";
                    //or 
                    continue;
                }
                return "Modal_" + GetEditView(GetViewNameFromTable(frCol.Table));
            }
        }
		
		return "";
	}

    public bool IsPublishOptionFields(string field)
    {
        return IsContainItem(field, PublishOptionFields);
    }

    private static bool IsContainItem( string field, IList<string> publishFields)
    {
        if (string.IsNullOrEmpty(field) || publishFields == null)
        {
            return false;
        }

        field = field.ToLower();

        foreach (string str in publishFields)
        {
            if (str.ToLower().Equals(field))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// file in publish option
    /// </summary>
    public IList<string> PublishOptionFields
    {
        get 
        {
            IList<string> publishFields = new List<string>();

            publishFields.Add("created_by");
            publishFields.Add("created_by_alias");
            publishFields.Add("created");
            publishFields.Add("publish_up");
            publishFields.Add("publish_down");
            publishFields.Add("modified_by");
            publishFields.Add("modified");
            publishFields.Add("version");
            publishFields.Add("hits");
            return publishFields;
        }
    }

    /// <summary>
    /// file in publish option
    /// </summary>
    public IList<string> MetadataOptionFields
    {
        get
        {
            IList<string> metadataFields = new List<string>();

            metadataFields.Add("metakey");
            metadataFields.Add("metadesc");
            metadataFields.Add("xreference");
            return metadataFields;
        }
    }

    public bool IsMetadataFields(string field)
    {
        return IsContainItem(field, MetadataOptionFields);
    }

    string componentPrefix = "com_";
    public GeneratedTemplate(ZeusContext context) : base(context) { }

    public string ComponentPrefix
    {
        get { return componentPrefix; }
    }

    public string OutPutPath
    {
        get { return input["path"].ToString(); }
    }

    public string ComponentNameNoPrefix
    {
        get { return input["ComponentName"].ToString().ToLower(); }
    }

    public string ComponentClassName
    {
        get
        {
            if (string.IsNullOrEmpty(ComponentNameNoPrefix))
                return string.Empty;
            return ComponentNameNoPrefix.Substring(0, 1).ToUpper() + ComponentNameNoPrefix.Substring(1, ComponentNameNoPrefix.Length - 1);
        }
    }

    public string ComponentControllerClassName
    {
        get { return ComponentClassName + "Controller"; }
    }

    public string ComponentName
    {
        get { return ComponentPrefix + ComponentNameNoPrefix; }
    }

    public string PrefixTable
    {
        get { return input["Prefix"].ToString(); }
    }

    public string SiteFolder
    {
        get { return "site"; }
    }

    public string AdminFolder
    {
        get { return "admin"; }
    }

    public string OutPutSiteFolder
    {
        get { return OutPutPath + "/" + ComponentName + "/" + SiteFolder; }
    }

    public string OutPutAdminFolder
    {
        get { return OutPutPath + "/" + ComponentName + "/" + AdminFolder; }
    }

    public List<string> SiteFolderSubDirs
    {
        get { return GetAllSubDirectory(OutPutSiteFolder, OutPutSiteFolder); }
    }
    public List<string> AdminFolderSubDirs
    {
        get { return GetAllSubDirectory(OutPutAdminFolder, OutPutAdminFolder); }
    }

    public List<string> GroupColumnList
    {
        get
        {
            List<string> list = new List<string>();
            list.Add("catid");
            list.Add("categoryid");
            list.Add("cat_id");
            list.Add("category_id");
            list.Add("parent");
            list.Add("parentid");
            list.Add("parent_id");
            list.Add("group");
            list.Add("groupid");
            list.Add("group_id");
            list.Add("sectionid");
            list.Add("section_id");
            list.Add("asset_id");
            list.Add("clientid");
            list.Add("client_id");
            list.Add("posid");
            list.Add("pos");
            list.Add("position");
            list.Add("positionid");
            list.Add("position_id");
            return list;
        }
    }

    public List<string> SearchField
    {
        get
        {
            List<string> list = new List<string>();
            list.Add("alias");
            list.Add("name");
            list.Add("title");
            list.Add("email");
            list.Add("contact");
            list.Add("phone");
            list.Add("firstname");
            list.Add("lastname");
            list.Add("url");
            list.Add("path");
            list.Add("description");
            list.Add("introtext");
            list.Add("fulltext");
            list.Add("extendtion");
            list.Add("extendtions");
            list.Add("element");
            list.Add("elements");
            return list;
        }        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="table"></param>
    /// <returns>return value like: '(a.title LIKE '.$search.' OR a.alias LIKE '.$search.')'</returns>
    public string BuilQuerySearch(ITable table)
    {
        List<string> searchFields = new List<string>();
        foreach (IColumn col in table.Columns)
        {
            if (ColumnDataTypeIsText(col) || ColumnDataTypeIsMediumText(col) || ColumnDataTypeIsVarchar(col))
            {
                string colName = col.Name.ToLower();
                foreach (string str in SearchField)
                {
                    if (colName.Contains(str))
                    {
                        searchFields.Add(colName);
                        break;
                    }
                }
            }
        }


        if (searchFields.Count == 0)
        {
            return string.Empty;
        }

        string returnValue = string.Empty;
        foreach (string sarchField in searchFields)
        {
            returnValue += string.Format(" OR a.{0} LIKE '.$search.' ", sarchField);
        }

        returnValue = returnValue.Substring(3);
        returnValue = "'(" + returnValue + ")'";
        return returnValue;
    }

    public string GetGroupColumnNameFromTable(ITable table)
    {
        if (table == null)
        {
            return string.Empty;
        }

        foreach (string groupName in GroupColumnList)
        {
            foreach (IColumn col in table.Columns)
            {
                if (col.Name.ToLower().Equals(groupName.ToLower()))
                {
                    return groupName;
                }
            }
        }

        foreach (IColumn col in table.Columns)
        {
            string returnColumnName = col.Name.ToLower();
            if (returnColumnName.EndsWith("id"))
            {
                return returnColumnName;
            }
        }

        return string.Empty;
    }

    public List<string> SelectedTables
    {
        get
        {
            List<string> list = new List<string>();
            /**/
            foreach (ITable obj in (IEnumerable)input["tableName"])
            {
                list.Add(GetViewNameFromTable(obj));
            }
            return list;
            /**/
        }
    }

    public string GetViewNameFromTable(ITable obj)
    {
        return obj.Name.Replace(PrefixTable, "");
    }

    public List<ITable> SelectedObjectTables
    {
        get
        {
            List<ITable> list = new List<ITable>();
            /**/
            foreach (ITable obj in (IEnumerable)input["tableName"])
            {
                list.Add(obj);
            }
            return list;
            /**/
        }
    }

    public List<string> Views
    {
        get
        {
            List<string> list = new List<string>();
            foreach (string table in SelectedTables)
            {
                list.Add(GetEditView(table));
                list.Add(GetListView(table));
            }
            return list;
        }
    }

    public List<string> EditViews
    {
        get
        {
            List<string> list = new List<string>();
            foreach (string table in SelectedTables)
            {
                list.Add(GetEditView(table));
                //list.Add(GetListView(table));
            }
            return list;
        }
    }

    public List<string> ListViews
    {
        get
        {
            List<string> list = new List<string>();
            foreach (string table in SelectedTables)
            {
                //list.Add(GetEditView(table));
                list.Add(GetListView(table));
            }
            return list;
        }
    }


    public ITable GetTableFromView(string viewName)
    {
        foreach (ITable obj in (IEnumerable)input["tableName"])
        {
            //search list view
            string tableName = obj.Name.Replace(PrefixTable, "");
            tableName = CorrectViewName(tableName);
            if (viewName.ToLower().Equals(tableName.ToLower()))
            {
                return obj;
            }

            //search edit view
            string editViewName = GetEditView(viewName);
            if (editViewName.ToLower().Equals(tableName.ToLower()))
            {
                return obj;
            }

            //search list view
            string listViewName = GetListView(viewName);
            if (listViewName.ToLower().Equals(tableName.ToLower()))
            {
                return obj;
            }
        }
        return null;
    }

    public string GetTableName(ITable table)
    {
        string tableName = table.Name.Replace(PrefixTable, "");
        return tableName;
    }

    public string GetTableNameWithMeaning(ITable table)
    {
        string tableName = GetTableName(table);
        return Regex.Replace(tableName, "[_-]+", " ");
    }

    public string GetTableNameForMultipleLanguage(ITable table)
    {
        string tableName = GetTableName(table);
        return Regex.Replace(tableName, "[_-]+", "_");
    }

    public string GetTableName(string view)
    {
        ITable table = GetTableFromView(view);
        if (table != null)
        {
            return GetTableName(table);
        }
        return view;
    }

    public bool IsContainColumn(ITable table, string columnName)
    {
        if (string.IsNullOrEmpty(columnName) || table == null)
        {
            return false;
        }

        columnName = columnName.ToLower();
        foreach (IColumn column in table.Columns)
        {
            if (column.Name.ToLower().Equals(columnName))
            {
                return true;
            }
        }
        return false;
    }
	
	public bool IsContainImageColumn(ITable table)
    {
        if (table == null)
        {
            return false;
        }

        string columnName = "image";
        foreach (IColumn column in table.Columns)
        {
            if (column.Name.ToLower().Contains(columnName)
				|| column.Name.ToLower().Contains("url")
				|| column.Name.ToLower().Contains("path")
				|| column.Name.ToLower().Contains("file")
				|| column.Name.ToLower().Contains("picture")
			)
            {
                return true;
            }
        }
        return false;
    }	

    public IColumn GetFirstColumn(ITable table)
    {
        if (table == null)
        {
            return null;
        }

        string defualtFirst = "title";

        foreach (IColumn column in table.Columns)
        {
            if (column.Name.ToLower().Equals(defualtFirst))
            {
                return column;
            }
        }

        defualtFirst = "id";

        foreach (IColumn column in table.Columns)
        {
            if (column.Name.ToLower().Equals(defualtFirst))
            {
                return column;
            }
        }

        return table.Columns[0];
    }

    public bool HaveTableContaiCategoryColumn()
    {
        List<ITable> listSlectedObjectTables = SelectedObjectTables;
        foreach (ITable tb in listSlectedObjectTables)
        {
            foreach (IColumn cl in tb.Columns)
            {
                if (cl.Name.ToLower().Equals("catid"))
                {
                    return true;
                }
            }
        }

        return false;
    }
    public string GetPrimaryColumnName(ITable table)
    {
        if (table == null)
        {
            return string.Empty;
        }
		
		string primryColName = "";
        foreach (IColumn column in table.Columns)
        {            
			if (column.IsInPrimaryKey)
            {
                if(column.Name.ToLower().Equals("id"))
				{
					return column.Name;
				}
				
				if(String.IsNullOrEmpty(primryColName))
				{
					primryColName = column.Name;
				}
            }
        }
        return primryColName;
    }

    public string GetViewNameFromView(string viewName)
    {

        //search list view
        foreach (ITable obj in (IEnumerable)input["tableName"])
        {
            string tableName = obj.Name.Replace(PrefixTable, "");
            tableName = CorrectViewName(tableName);
            if (viewName.ToLower().Equals(tableName.ToLower()))
            {
                string viewNameReturn = obj.Name.Replace(PrefixTable, "");
                string[] arr = Regex.Split(viewNameReturn, "_+");
                string value = string.Empty;
                foreach (string str in arr)
                {
                    value += UpperFirstChar(str) + " ";
                }
                return value;
            }
        }

        //search edit view
        string editViewName = GetEditView(viewName);
        foreach (ITable obj in (IEnumerable)input["tableName"])
        {
            string tableName = obj.Name.Replace(PrefixTable, "");
            tableName = CorrectViewName(tableName);
            if (editViewName.ToLower().Equals(tableName.ToLower()))
            {
                string viewNameReturn = obj.Name.Replace(PrefixTable, "");
                string[] arr = Regex.Split(viewNameReturn, "_+");
                string value = string.Empty;
                foreach (string str in arr)
                {
                    value += UpperFirstChar(str) + " ";
                }
                return value;
            }
        }

        return UpperFirstChar(viewName);
    }
    public int GetColumnDataLengh(IColumn col)
    {
        string dataTypeNameComplete = col.DataTypeNameComplete;
        string resultString = null;
        try
        {
            resultString = Regex.Match(dataTypeNameComplete, @"\( *(\d+) *\)").Groups[1].Value;
            return int.Parse(resultString);
        }
        catch (Exception ex)
        {
            if (ColumnDataTypeIsDateTime(col))
            {
                return 12;            
            }
            else if (ColumnDataTypeIsText(col)||ColumnDataTypeIsMediumText(col))
            {
                return int.MaxValue;
            }
            else
            {
                return -1;
            }
        }

    }

    public string GetColumnDataType(IColumn column)
    {
        return column.DataTypeName;
    }
    public bool ColumnDataTypeIsDateTime(IColumn col)
    {
        string dataType = GetColumnDataType(col);
        return dataType.Equals("DATETIME") || dataType.Equals("TIMESTAMP");
    }

    public bool ColumnDataTypeIsText(IColumn col)
    {
        return GetColumnDataType(col).Equals("TEXT");
    }

    public bool ColumnDataTypeIsVarchar(IColumn col)
    {
        return GetColumnDataType(col).Equals("VARCHAR");
    }
    public bool ColumnDataTypeIsMediumText(IColumn col)
    {
        return GetColumnDataType(col).Equals("MEDIUMTEXT");
    }
    public bool ColumnDataTypeIsInt(IColumn col)
    {
        string dataType = GetColumnDataType(col);
        return (dataType.Equals("INT") || dataType.Equals("INT UNSIGNED"));
    }

    public bool IsContainPublishOptionField(ITable table)
    {
        foreach (IColumn col in table.Columns)
        { 
            if(PublishOptionFields.Contains(col.Name.ToLower()))
            {
                return true;
            }
        }

        return false;
    }

    public bool IsContainMetaOptionField(ITable table)
    {
        foreach (IColumn col in table.Columns)
        {
            if (MetadataOptionFields.Contains(col.Name.ToLower()))
            {
                return true;
            }
        }

        return false;
    }

    public string DefaultView
    {
        get
        {
            return GetListView(CorrectViewName(SelectedTables[0]));
        }
    }

    public List<string> ExcludeFolders
    {
        get
        {
            List<string> folders = new List<string>();
            folders.Add("controllers\\");
            folders.Add("helpers\\");
            folders.Add("models\\");
            folders.Add("tables\\");
            folders.Add("elements\\");
            folders.Add("views\\");
            folders.Add("language\\");
            folders.Add("sql\\");
            return folders;
        }
    }

    private string GetEditView(string view)
    {
        string viewCorrect = CorrectViewName(view);
        if (viewCorrect.EndsWith("s"))
        {
            return viewCorrect.Substring(0, viewCorrect.Length - 1);
        }
        else
        {
            return viewCorrect;
        }
    }

    private string GetListView(string view)
    {
        string viewCorrect = CorrectViewName(view);
        string viewCorrectUpper = viewCorrect.ToUpper();
        //if (viewCorrectUpper.EndsWith("ZES"))
        //{
        //    return viewCorrect + "z"; 
        //}
        //else if (viewCorrectUpper.EndsWith("CH") || viewCorrectUpper.EndsWith("SH"))
        //{
        //    return viewCorrect + "es";
        //}
        //else 

        if (viewCorrectUpper.EndsWith("S"))
        {
            return viewCorrect;
        }
        else
        {
            return viewCorrect + "s";
        }
    }

    private string CorrectViewName(string view)
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

    private bool IsExcludeFolder(string folder)
    {
        if (string.IsNullOrEmpty(folder))
        {
            return false;
        }

        foreach (string exclude in ExcludeFolders)
        {
            if (folder.StartsWith(exclude))
            {
                return true;
            }
        }

        return false;
    }

    public string UpperFirstCharInWord(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        string [] array = Regex.Split(str,"[ +-_]+");
        string returnValue = string.Empty;
        foreach (string item in array)
        {
            returnValue += UpperFirstChar(item) + " ";
        }
        return returnValue.Trim();
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

    //---------------------------------------------------
    // Render() is where you want to write your logic    
    //---------------------------------------------------
    public override void Render()
    {        
        //******************* Config Debug mode ******************
        //Comment bellow line of code to disable Debug mode
        //System.Diagnostics.Debugger.Launch();
        //****************** End Config Debug mode ***************
        DateTime start = DateTime.Now;

        string path = input["path"].ToString();
        string componentNameNoPrefix = input["ComponentName"].ToString().ToLower();
        string componentName = componentPrefix + componentNameNoPrefix;
        string prefixTable = input["Prefix"].ToString();
        string ADMIN_FOLDER = "admin";
        string SITE_FOLDER = "site";

        //************************* Site ***********************************
        string siteFolder = path + "/" + componentName + "/" + SITE_FOLDER;
        string adminFolder = path + "/" + componentName + "/" + ADMIN_FOLDER;
        //Create site folder
        CreateComponentFolder(siteFolder);
        //Crate contronller file
        CreatSiteControllerFile(siteFolder + "/controller.php");
		//Create 
		CreateSiteComponentFile(siteFolder + "/" + componentNameNoPrefix + ".php");
		CreateSiteRouteFile(siteFolder + "/router.php");
		CreateSiteHelperFile(siteFolder + "/helpers/route.php");
		CreateSiteQueryFile(siteFolder + "/helpers/query.php");
		CreateSiteHelperCategory(siteFolder + "/helpers/category.php");
		CreateSiteIconFile(siteFolder + "/helpers/icon.php");
		CreateSiteMetaDataFile(siteFolder + "/metadata.xml");
		//Create view/ model, form
		
		//Create view
        foreach (string view in Views)
        {
            string viewLower = view.ToLower();
            CreateFolder(siteFolder + "\\" + "views\\" + viewLower);
            CreateFolder(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl");
        }

        //Create model

        //Create model list
        foreach (string view in ListViews)
        {
            string viewLower = view.ToLower();
            //CreateAdminModelList(siteFolder + "\\" + "models\\" + viewLower + ".php", view);
			CreateSiteModelListFile(siteFolder + "\\" + "models\\" + viewLower + ".php", view);
            CreateSiteViewList(siteFolder + "\\" + "views\\" + viewLower + "\\view.html.php", view);
			
			CreateSiteMetaDataFileForView(siteFolder + "\\" + "views\\" + viewLower + "\\metadata.xml",view);
			CreateSiteViewTemplateDefaultXml(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl\\default.xml", view);
			
            CreateSiteViewTemplateList(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl\\default.php", view);			
            //CreateAdminControllerList(siteFolder + "\\" + "controllers\\" + viewLower + ".php", view);
        }

        //Create model single
        foreach (string view in EditViews)
        {
            string viewLower = view.ToLower();
            CreateSiteViewOne(siteFolder + "\\" + "views\\" + viewLower + "\\view.html.php", view);
            //CreateAdminModelEdit(siteFolder + "\\" + "models\\" + viewLower + ".php", view);			
			CreateSiteModelEditFile(siteFolder + "\\" + "models\\" + viewLower + ".php", view);
			CreateSiteViewTemplateViewOneDefaultXml(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl\\default.xml", view);
			CreateSiteViewTemplateViewOneDefaultLink(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl\\default_links.php", view);
            CreateSiteViewTemplateViewOne(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl\\default.php", view);
            //CreateAdminViewTemplateEditMeta(siteFolder + "\\" + "views\\" + viewLower + "\\tmpl\\edit_metadata.php", view);
			
			CreateFolder(siteFolder + "\\" + "views\\form" + viewLower+"\\tmpl");
			CreateSiteViewForm(siteFolder + "\\" + "views\\form" + viewLower + "\\view.html.php", view);
			CreateSiteViewFormMetaData(siteFolder + "\\" + "views\\form" + viewLower + "\\metadata.xml", view);
			CreateSiteViewFormEditTemplate(siteFolder + "\\" + "views\\form" + viewLower + "\\tmpl\\edit.php", view);
			CreateSiteViewFormEditTemplateXml(siteFolder + "\\" + "views\\form" + viewLower + "\\tmpl\\edit.xml", view);
			CreateSiteViewFormEditModel(siteFolder + "\\" + "models\\form" + viewLower + ".php", view);
        }

        //Create form
        foreach (string view in EditViews)
        {
            string viewLower = view.ToLower();
            CreateFolder(siteFolder + "\\" + "models\\forms");
            //CreateSiteForm(siteFolder + "\\" + "models\\forms\\" + viewLower + ".xml", view);
			CreateForm(siteFolder + "\\" + "models\\forms\\" + viewLower + ".xml", view);
			
            CreateSiteControllerEdit(siteFolder + "\\" + "controllers\\" + viewLower + ".php", view);
			/*
            if (!NotCreateTables.Contains(view.ToLower()))
            {
                CreateAdminTable(siteFolder + "\\" + "tables\\" + viewLower + ".php", view);
            }
			*/			
        }		
		
		//end create view 
		

        //Create site language
        CreateFile(siteFolder + "/language/" + "en-GB." + ComponentName + ".ini");
        CreateFile(siteFolder + "/language/" + "vi-VN." + ComponentName + ".ini");
		
        //CreateSysEnglishResourceFile(siteFolder + "/language/" + "en-GB." + ComponentName + ".sys.ini");
        //CreateSysVNResourceFile(siteFolder + "/language/" + "vi-VN." + ComponentName + ".sys.ini");		


        ////////////////////////// End Site /////////////////////////////////


        //************************ Admin ************************************
        //Create admin folder
        CreateComponentFolder(adminFolder);
        //create elements and tables forder for admin function
        CreateFolder(adminFolder + "/" + "elements");
        CreateFolder(adminFolder + "/" + "tables");
        CreateAdminComponentFile(adminFolder + "/" + componentNameNoPrefix + ".php");
        CreateAdminControllerFile(adminFolder + "/controller.php");
        CreateAdminHelperFile(adminFolder + "/helpers/" + componentNameNoPrefix + ".php");
		CreateHelperAdministrator(adminFolder + "/helpers/html/" + componentNameNoPrefix + "administrator.php");

        //Create view
        foreach (string view in Views)
        {
            string viewLower = view.ToLower();
            CreateFolder(adminFolder + "\\" + "views\\" + viewLower);
            CreateFolder(adminFolder + "\\" + "views\\" + viewLower + "\\tmpl");
        }

        //Create model

        //Create model list
        foreach (string view in ListViews)
        {
            string viewLower = view.ToLower();
            CreateAdminModelList(adminFolder + "\\" + "models\\" + viewLower + ".php", view);
            CreateAdminViewList(adminFolder + "\\" + "views\\" + viewLower + "\\view.html.php", view);
            CreateAdminViewTemplateList(adminFolder + "\\" + "views\\" + viewLower + "\\tmpl\\default.php", view);
			CreateAdminViewTemplateListModal(adminFolder + "\\" + "views\\" + viewLower + "\\tmpl\\modal.php", view);
            CreateAdminControllerList(adminFolder + "\\" + "controllers\\" + viewLower + ".php", view);

            CreateFormListFilter(adminFolder + "\\" + "models\\forms\\filter_" + viewLower + ".xml", view);
        }

        //Create model single
        foreach (string view in EditViews)
        {
            string viewLower = view.ToLower();
            CreateAdminViewEdit(adminFolder + "\\" + "views\\" + viewLower + "\\view.html.php", view);
            CreateAdminModelEdit(adminFolder + "\\" + "models\\" + viewLower + ".php", view);
			CreateAdminModelFieldsModal(adminFolder + "\\" + "models\\fields\\modal\\" + viewLower + ".php", view);
            CreateAdminViewTemplateEdit(adminFolder + "\\" + "views\\" + viewLower + "\\tmpl\\edit.php", view);
            CreateAdminViewTemplateEditMeta(adminFolder + "\\" + "views\\" + viewLower + "\\tmpl\\edit_metadata.php", view);
			CreateAdminModelFieldsEdit(adminFolder + "\\" + "models\\fields\\" + viewLower + "edit.php", view);
        }

        //Create form
        foreach (string view in EditViews)
        {
            string viewLower = view.ToLower();
            CreateFolder(adminFolder + "\\" + "models\\forms");
            CreateForm(adminFolder + "\\" + "models\\forms\\" + viewLower + ".xml", view);            
            CreateAdminControllerEdit(adminFolder + "\\" + "controllers\\" + viewLower + ".php", view);
            if (!NotCreateTables.Contains(view.ToLower()))
            {
                CreateAdminTable(adminFolder + "\\" + "tables\\" + viewLower + ".php", view);
            }            
        }


        //Create sql folder
        CreateFolder(adminFolder + "/sql/");
        CreateSqlInstallFile(adminFolder + "/sql/" + "install.mysql.utf8.sql");
        CreateSqlUnInstallFile(adminFolder + "/sql/" + "uninstall.mysql.utf8.sql");
        //Create sql update folder
        CreateFolder(adminFolder + "/sql/updates/mysql/");
        CreateFile(adminFolder + "/sql/updates/mysql/0.0.1.sql");


        //Create admin language
        //CreateFile(adminFolder + "/language/" + "en-GB." + ComponentName + ".ini");
        //CreateFile(adminFolder + "/language/" + "vi-VN." + ComponentName + ".ini");
        CreateEnglishResourceFile(adminFolder + "/language/" + "en-GB." + ComponentName + ".ini");
        CreateVNResourceFile(adminFolder + "/language/" + "vi-VN." + ComponentName + ".ini");
        CreateSysEnglishResourceFile(adminFolder + "/language/" + "en-GB." + ComponentName + ".sys.ini");
        CreateSysVNResourceFile(adminFolder + "/language/" + "vi-VN." + ComponentName + ".sys.ini");		

        //create config file
        CreateAdminComponentConfigXml(adminFolder + "/config.xml");

        //create accessfile
        CreateAccessXmlFile(adminFolder + "/access.xml", SelectedTables);

        /////////////////////////////////////////////////////////////////////



        //create component file
        //output.clear();
        List<string> adminFiles = null;
        List<string> siteFiles = null;
        GetAllFileInDirectory(siteFolder, siteFolder, ref siteFiles);
        GetAllFileInDirectory(adminFolder, adminFolder, ref adminFiles);
        //output.writeln(siteFiles.Count + "");
        GetComponentXmlContentFile(ComponentName, "Nguyen Huu Huy", "huuhuy@gmail.com", siteFiles, adminFiles);
        output.save(path + "/" + componentName + "/" + ComponentNameNoPrefix + ".xml", "o");
        output.clear();

        DateTime end = DateTime.Now;

        output.writeln("Start Time: " + start.ToString());
        output.writeln("End Time  : " + end.ToString());
        //output.writeln(path);

        //Zip folder
        FastZip fastZip = new FastZip();
        string zipFileSource = path + "\\" + componentName;
        string zipFilePath = path + "\\" + componentName.ToLower()+".zip";

        //System.Diagnostics.Debugger.Break();
        try
        {
            fastZip.CreateZip(zipFilePath, zipFileSource, true, "");
        }
        catch (Exception ex)
        {
            output.writeln(ex.Message + "\n" + ex.StackTrace);
        }
        output.writeln("Componnent Directory: " + zipFilePath);
        output.writeln("Zip file path: " + zipFileSource);
    }

    void CreateFolder(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return;
        }
        string[] folders = path.Split("/\\".ToCharArray());
        string currentPath = string.Empty;
        foreach (string folder in folders)
        {
            if (string.IsNullOrEmpty(folder))
            {
                continue;
            }
            if (!string.IsNullOrEmpty(currentPath))
            {
                currentPath += "\\" + folder;
            }
            else
            {
                currentPath += folder;
            }

            if (!Directory.Exists(currentPath))
            {
                //output.writeln(currentPath);
                Directory.CreateDirectory(currentPath);
                CreateIndexHtmlFile(currentPath);
            }
			else
			{
				CreateIndexHtmlFile(currentPath);
			}
        }
    }

    void GetAllFileInDirectory(string path, string prefixPath, ref List<string> files)
    {
        //output.writeln(path);
        if (files == null)
        {
            files = new List<string>();
        }

        if (!Directory.Exists(path))
        {
            //output.writeln(path + ", is not exited");
            return;
        }

        if (string.IsNullOrEmpty(prefixPath))
        {
            prefixPath = string.Empty;
        }
        //correct prefixPath
        prefixPath = Regex.Replace(prefixPath, "\\+", "\\");
        prefixPath = Regex.Replace(prefixPath, "/+", "\\");
        if (!prefixPath.EndsWith("\\"))
        {
            prefixPath = prefixPath + "\\";
        }

        DirectoryInfo directory = new DirectoryInfo(path);
        foreach (FileInfo file in directory.GetFiles())
        {
            string fileName = file.FullName.Replace(prefixPath, string.Empty);
            fileName = Regex.Replace(fileName, "\\+", "/");
            //output.writeln(fileName);
            files.Add(fileName);
        }

        foreach (DirectoryInfo dir in directory.GetDirectories())
        {
            GetAllFileInDirectory(dir.FullName, prefixPath, ref files);
        }
    }

    private List<string> GetAllSubDirectory(string path, string prefixPath)
    {
        //output.writeln(path);
        List<string> directories = new List<string>();

        if (!Directory.Exists(path))
        {
            //output.writeln(path + ", is not exited");
            return directories;
        }

        if (string.IsNullOrEmpty(prefixPath))
        {
            prefixPath = string.Empty;
        }
        //correct prefixPath
        prefixPath = Regex.Replace(prefixPath, "\\+", "\\");
        prefixPath = Regex.Replace(prefixPath, "/+", "\\");
        if (!prefixPath.EndsWith("\\"))
        {
            prefixPath = prefixPath + "\\";
        }

        DirectoryInfo directory = new DirectoryInfo(path);
        foreach (DirectoryInfo dir in directory.GetDirectories())
        {
            //GetAllFileInDirectory(dir.FullName, prefixPath, ref files);
            string dirName = dir.FullName.Replace(prefixPath, string.Empty);
            directories.Add(dirName);
        }

        return directories;
    }

    public void CreateComponentFolder(string outputPath)
    {

        //************* Create front end **************************//
        //controller folder
        CreateFolder(outputPath + "\\" + "controllers");

        //helpers foldeer
        CreateFolder(outputPath + "\\" + "helpers");

        //models folder
        CreateFolder(outputPath + "\\" + "models");

        //views folder
        CreateFolder(outputPath + "\\" + "views");

        //languages folder
        CreateFolder(outputPath + "\\" + "language");

        //controller.php file
        //CreatControllerFile();

        //index.hmtl file


        //component file (component name .php)


        //metadata.xml file


        //router.php file

        //************* End create front end **************************//


        //************* Create back end *******************************//

        //************* End Create back end ***************************//
    }

    public TableJoinItem GetTableJoinItemByColumn(IColumn column)
    {
        if (column == null)
        {
            return null;
        }
        IList<string> columnforJoinList = DefaultColumnJointWithOtherTable;
        if(columnforJoinList.Contains(column.Name.ToLower()))
		{
            return null;
		}

        TableJoinItem item = new TableJoinItem { TableAliasName = "", TableName = "", TitleName = "" , TableNameNoPrefix="", TitleAliasName=""};

		if(column.IsInForeignKey)
		{				
			foreach(IForeignKey foreColumn in column.ForeignKeys)
			{					
				if(foreColumn.PrimaryColumns.Count>1)
				{
					continue;
				}
				foreach(IColumn frCol in foreColumn.PrimaryColumns)
				{
					if (column.Table.Name.Equals(frCol.Table.Name) && column.Name.Equals(frCol.Name))
					{
						continue;
					}
					string title = GetTitleFieldName(frCol.Table);                    
					string tablealias = GetViewNameFromTable(frCol.Table)+"_al";
                    item.TitleAliasName = tablealias + "_" + title;
                    item.TitleName = title;
                    item.TableAliasName = tablealias;
                    item.TableName = frCol.Table.Name;
                    item.TableNameNoPrefix = "#__"+GetTableName(frCol.Table).ToLower();
                    item.PrimaryKey = frCol.Name;
    //%>				
    //// Join over the <%=frCol.Table.Name%>
    //$query->select('<%=tablealias%>.<%=titlealias%> AS <%=tablealias%>_<%=titlealias%>');
    //$query->join('LEFT', '`#__<%=GetTableName(frCol.Table).ToLower()%>` AS <%=tablealias%> ON <%=tablealias%>.<%=frCol.Name%> = a.<%=column.Name%>');
    //<%
					return item;
				}
			}
		}

        return null;
    }
}

public class TableJoinItem
{
    public string TableAliasName { set; get; }
    public string TitleName { set; get; }
    public string TitleAliasName { set; get; }
    public string TableNameNoPrefix { set; get; }
    public string TableName { set; get; }
    public string PrimaryKey { set; get; }
}