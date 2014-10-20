using Microsoft.VisualBasic;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using BaseClasses.Web.UI.WebControls;

namespace KumePortali.UI.Controls.LargeListSelector
{
    public class ItemsTableRecordControl : BaseItemsTableRecordControl
    {
    }
    public class ItemsTable : BaseItemsTable
    {
    }
    public class BaseItemsTableRecordControl : KumePortali.UI.BaseApplicationRecordControl
    {
        public BaseItemsTableRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            this.SelectButton.Click += new EventHandler(SelectButton_Click);
            
            this.Page.RegisterPostBackTrigger(this.SelectButton, MiscUtils.GetParentControlObject(this, "ItemsTableControlUpdatePanel"));
        }

        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        }

        public override void DataBind()
        {
            if (this.DataSource == null)
            {
                return;
            }
            ItemsTable table = ((ItemsTable)(this.Page.FindControlRecursively("ItemsTable")));
            BaseClasses.Data.TableDefinition td = table.GetTable().TableDefinition;
            BaseClasses.Data.BaseColumn col = td.ColumnList.GetByAnyName(table.Field);
            BaseClasses.Data.BaseColumn displayCol = td.ColumnList.GetByAnyName(table.DisplayField);
            this.ValueText.Text = this.DataSource.GetValue(col).ToString();
            this.ItemText.Text = this.DataSource.Format(displayCol);
        }

        public virtual void LoadData()
        {
        }

        protected virtual void SelectButton_Click(object sender, EventArgs args)
        {
            ItemsTable table = ((ItemsTable)(this.Page.FindControlRecursively("ItemsTable")));
            BaseClasses.Data.TableDefinition td = table.GetTable().TableDefinition;
            BaseClasses.Data.BaseColumn col = td.ColumnList.GetByAnyName(table.Field);
            BaseClasses.Data.BaseColumn displayCol = td.ColumnList.GetByAnyName(table.DisplayField);
            this.RegisterSelectValueScript(table.Target, this.ValueText.Text, this.ItemText.Text);
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
        }

        protected override object SaveViewState()
        {
            return base.SaveViewState();
        }

        private BaseRecord _DataSource;
        public BaseRecord DataSource
        {
            get
            {
                return this._DataSource;
            }
            set
            {
                this._DataSource = value;
            }
        }

        public System.Web.UI.WebControls.Label ValueText
        {
            get
            {
                return ((System.Web.UI.WebControls.Label)(MiscUtils.FindControlRecursively(this, "ValueText")));
            }
        }

        public System.Web.UI.WebControls.LinkButton SelectButton
        {
            get
            {
                return ((System.Web.UI.WebControls.LinkButton)(MiscUtils.FindControlRecursively(this, "SelectButton")));
            }
        }

        public System.Web.UI.WebControls.Label ItemText
        {
            get
            {
                return ((System.Web.UI.WebControls.Label)(MiscUtils.FindControlRecursively(this, "ItemText")));
            }
        }

        public new BaseApplicationPage Page
        {
            get
            {
                return ((BaseApplicationPage)(base.Page));
            }
        }

        private void RegisterSelectValueScript(string target, string value, string text)
        {
            string scriptContent = string.Format("updateTarget({0}, {1}, {2});", BaseClasses.Web.AspxTextWriter.CreateJScriptStringLiteral(target), BaseClasses.Web.AspxTextWriter.CreateJScriptStringLiteral(value), BaseClasses.Web.AspxTextWriter.CreateJScriptStringLiteral(text));
            string script = BaseClasses.Web.AspxTextWriter.CreateJScriptBlock(scriptContent);
            this.Page.ClientScript.RegisterStartupScript(typeof(string), "SelectValueScript", script);
        }
    }
    public class BaseItemsTable : KumePortali.UI.BaseApplicationTableControl
    {
		public BaseItemsTable()
		{
			this.Load += new EventHandler(Control_Load);
			this.Init += new EventHandler(Control_Init);
			this.PreRender += new EventHandler(Control_PreRender);
		}

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            this.Pagination.FirstPage.Click += new ImageClickEventHandler(Pagination_FirstPage_Click);
            this.Pagination.LastPage.Click += new ImageClickEventHandler(Pagination_LastPage_Click);
            this.Pagination.NextPage.Click += new ImageClickEventHandler(Pagination_NextPage_Click);
            this.Pagination.PageSizeButton.Click += new EventHandler(Pagination_PageSizeButton_Click);
            this.Pagination.PreviousPage.Click += new ImageClickEventHandler(Pagination_PreviousPage_Click);
            this.SearchButton.Button.Click += new EventHandler(SearchButton_Click);
            if (!(this.Page.IsPostBack))
            {
                this.CurrentSortOrder = new OrderBy(true, true);
                this.PageSize = 10;
                this.PageIndex = 0;
            }
        }

        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
            this.RegisterAutoCloseScript();
            try
            {
                if ((!(this.Page.IsPostBack)))
                {
                    DbUtils.StartTransaction();
                    this.LoadData();
                    this.DataBind();
                }
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "Load_Error_Message", ex.Message);
            }
            finally
            {
                if (!(this.Page.IsPostBack))
                {
                    DbUtils.EndTransaction();
                }
            }
        }

        public virtual void LoadData()
        {
            string tableStr = NetUtils.GetUrlParam(this, "Table", true);
            string fieldStr = NetUtils.GetUrlParam(this, "Field", true);
            string targetStr = NetUtils.GetUrlParam(this, "Target", true);
            string displayFieldStr = NetUtils.GetUrlParam(this, "DisplayField", true);

            if ((tableStr == null || tableStr.Length == 0) || 
                (fieldStr == null || fieldStr.Length == 0) || 
                (targetStr == null || targetStr.Length == 0) || 
                (displayFieldStr == null || displayFieldStr.Length == 0))
            {
                this.DataSource = ((BaseRecord[])((new ArrayList()).ToArray(Type.GetType(System.Reflection.Assembly.CreateQualifiedName("BaseClasses","BaseClasses.Data.BaseRecord")))));
                return;
            }


	    // Save all of the URL parameters in the session for use by Ajax type-ahead control 
	    HttpContext.Current.Session.Add("LLSAjaxTable", this.Table); 
	    HttpContext.Current.Session.Add("LLSAjaxField", this.Field); 
	    HttpContext.Current.Session.Add("LLSAjaxDisplayField", this.DisplayField); 

            WhereClause whereClause = CreateWhereClause();
            OrderBy orderBy = CreateOrderBy();
            
            this.SetPagintionPageSize();
            
            this.TotalRecords = System.Convert.ToInt32(this.GetTable().GetRecordListCount(whereClause.GetFilter(), null));
            if (this.TotalPages <= 0)
            {
                this.PageIndex = 0;
            }
            else if (this.DisplayLastPage || this.PageIndex >= this.TotalPages)
            {
                this.PageIndex = this.TotalPages - 1;
            }
            
            this.DataSource = ((BaseRecord[])(this.GetTable().GetRecordList(whereClause.GetFilter(), orderBy, this.PageIndex, this.PageSize).ToArray(Type.GetType(System.Reflection.Assembly.CreateQualifiedName("BaseClasses","BaseClasses.Data.BaseRecord")))));
        }

        public override void DataBind()
        {
            base.DataBind();
            if (this.DataSource == null)
            {
                return;
            }
            BindPaginationControls();
            System.Web.UI.WebControls.Repeater rep = ((System.Web.UI.WebControls.Repeater)(this.FindControl("row1")));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                ItemsTableRecordControl recControl = ((ItemsTableRecordControl)(repItem.FindControl("ItemsTableRecordControl")));
                recControl.DataSource = this.DataSource[index];
                recControl.DataBind();
                index += 1;
            }
        }

        protected virtual void BindPaginationControls()
        {
            this.Pagination.FirstPage.Enabled = !((this.PageIndex == 0));
            this.Pagination.LastPage.Enabled = !((this.PageIndex == this.TotalPages - 1));
            this.Pagination.NextPage.Enabled = !((this.PageIndex == this.TotalPages - 1));
            this.Pagination.PreviousPage.Enabled = !((this.PageIndex == 0));
            this.Pagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            this.Pagination.PageSize.Text = this.PageSize.ToString();
            this.Pagination.TotalItems.Text = this.TotalRecords.ToString();
            this.Pagination.TotalPages.Text = this.TotalPages.ToString();
        }

        protected virtual void SetPagintionPageSize()
        {
            try
            {
                if (this.Pagination.PageSize != null &&
                    this.Pagination.PageSize.Text != null &&
                    this.Pagination.PageSize.Text.Length > 0)
                {
                    this.PageSize = int.Parse(this.Pagination.PageSize.Text);
                }
            }
            catch (Exception )
            {
            }
        }

        protected virtual OrderBy CreateOrderBy()
        {
            BaseColumn col = this.GetTable().TableDefinition.ColumnList.GetByAnyName(this.DisplayField);
            if (col != null && this.CurrentSortOrder.Find(col) == null)
            {
                this.CurrentSortOrder.Add(col, OrderByItem.OrderDir.Asc);
            }
            return this.CurrentSortOrder;
        }

        protected virtual WhereClause CreateWhereClause()
        {
            WhereClause whereClause = new WhereClause();
            BaseClasses.Data.BaseColumn displayCol = this.GetTable().TableDefinition.ColumnList.GetByAnyName(this.DisplayField);
            if (MiscUtils.IsValueSelected(this.StartsWith))
            {
		    // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored. 
		    if (this.StartsWith.Text.StartsWith("...")) { 
			this.StartsWith.Text = this.StartsWith.Text.Substring(3, this.StartsWith.Text.Length - 3); 
		    } 
		    if (this.StartsWith.Text.EndsWith("...")) { 
			this.StartsWith.Text = this.StartsWith.Text.Substring(0, this.StartsWith.Text.Length - 3); 
		    } 
		    this.StartsWith.Text = this.StartsWith.Text.Trim(); 
    
		    whereClause.iAND(displayCol, BaseFilter.ComparisonOperator.Starts_With, this.StartsWith.Text, true, true);
            }
            
            if (MiscUtils.IsValueSelected(this.Contains))
            {
                
		    // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored. 
		    if (this.Contains.Text.StartsWith("...")) { 
			this.Contains.Text = this.Contains.Text.Substring(3, this.Contains.Text.Length - 3); 
		    } 
		    if (this.StartsWith.Text.EndsWith("...")) { 
			this.Contains.Text = this.Contains.Text.Substring(0, this.Contains.Text.Length - 3); 
		    } 
		    this.Contains.Text = this.Contains.Text.Trim(); 
    
		    whereClause.iAND(displayCol, BaseFilter.ComparisonOperator.Contains, this.Contains.Text, true, true);
            }
            return whereClause;
        }


	// This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature. 
	public virtual WhereClause CreateWhereClause(string searchText, bool bStartsWith, string AutoTypeAheadWordSeparators) 
	{ 
	    WhereClause wc = new WhereClause(); 
	    // Compose the WHERE clause consiting of: 
	    // 1. Static clause defined at design time. 
	    // 2. User selected filter criteria. 
	    // 3. User selected search criteria. 
        string appRelativeVirtualPath = (string)HttpContext.Current.Session["AppRelatvieVirtualPath"];

	    BaseClasses.Data.BaseColumn displayCol = this.GetTable().TableDefinition.ColumnList.GetByAnyName(this.DisplayField); 

	    // Adds clauses if values are selected in Filter controls which are configured in the page. 

        if (MiscUtils.IsValueSelected(searchText)) {
		string formatedSearchText = searchText; 
		// strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored. 
		if (searchText.StartsWith("...")) { 
		    formatedSearchText = searchText.Substring(3, searchText.Length - 3); 
		} 
		if (searchText.EndsWith("...")) { 
		    formatedSearchText = searchText.Substring(0, searchText.Length - 3); 
		} 
		//After stripping "...", trim any leading and trailing whitespaces 
		formatedSearchText = formatedSearchText.Trim(); 

		// These clauses are added depending on operator and fields selected in Control's property page, bindings tab. 
		WhereClause search = new WhereClause(); 

		if (bStartsWith) { 
		    // Search Text specified in Starts With textbox 
		    search.iOR(displayCol, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false); 
		} 
		else { 
		    // Search Text specified in Contains textbox 
		    search.iOR(displayCol, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false); 
		    search.iOR(displayCol, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false); 
		} 
		wc.iAND(search); 
	    } 

	    // The Ajax call may come from one of the fields (e.g., StartsWith). But the user may have some text in the other field. 
	    // So we need to add the clause for the other field. 

	    if (!(bStartsWith)) { 
		// This was the Contains textbox that was used in Ajax, so add the StartsWith clause. 
		string StartsWithSearchSelectedValue = (string)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "StartsWithSearch_Ajax"];
		if (MiscUtils.IsValueSelected(StartsWithSearchSelectedValue))
		{ 
		    wc.iAND(displayCol, BaseFilter.ComparisonOperator.Starts_With, StartsWithSearchSelectedValue, false, false); 
		} 
	    } 
	    else { 
		// This was the StartsWith textbox that was used in Ajax, so add the Contains clause. 
		string ContainsSelectedValue = (string)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ContainsSearch_Ajax"];
		if (MiscUtils.IsValueSelected(ContainsSelectedValue))
		{ 
		    wc.iAND(displayCol, BaseFilter.ComparisonOperator.Contains, ContainsSelectedValue, false, false); 
		} 
	    } 

	    return wc; 
	} 


	public virtual string[] GetAutoCompletionList(string startsWithText, string containsText, int count) 
	{ 
	    ArrayList resultList = new ArrayList(); 
	    ArrayList wordList = new ArrayList(); 
	    int iteration = 0; 
	    string prefixText = ""; 
	    BaseClasses.Data.BaseColumn displayCol = this.GetTable().TableDefinition.ColumnList.GetByAnyName(this.DisplayField); 

	    WhereClause wc; 

	    if (!((startsWithText == null)) && startsWithText.Trim().Length > 0) { 
		prefixText = startsWithText; 
		wc = CreateWhereClause(startsWithText, true, "[!a-zA-Z0-9]"); 
	    } 
	    else { 
		prefixText = containsText; 
		wc = CreateWhereClause(containsText, false, "[!a-zA-Z0-9]"); 
	    } 

	    while ((resultList.Count < count && iteration < 5)) { 
		// Fetch 100 records in each iteration 
		// Dim records() As BaseRecord = Me.GetTable().G.GetRecords(wc, Nothing, iteration, 100) 
		BaseRecord[] records = (BaseRecord[])this.GetTable().GetRecordList(wc.GetFilter(), null, iteration, 100).ToArray(typeof(BaseRecord)); 
		string resultItem = ""; 
        foreach (BaseRecord rec in records) {
		    // Exit the loop if recordList count has reached AutoTypeAheadListSize. 
		    if (resultList.Count >= count) { 
			break; // TODO: might not be correct. Was : Exit For 
		    } 
		    // If the field is configured to Display as Foreign key, Format() method returns the 
		    // Display as Forien Key value instead of original field value. 
		    // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record, 
		    // We need to find relevent field to display which matches the prefixText and is not already present in the result list. 

		    resultItem = rec.Format(displayCol); 

            if (StringUtils.InvariantUCase(resultItem).Contains(StringUtils.InvariantUCase(prefixText)))
            { 
			bool isAdded = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList); 
			if (isAdded) { 
			    continue; 
			} 
		    } 
		} 

		// Exit the loop if number of records found is less as further iteration will not return any more records 
		if (records.Length < 100) { 
		    break; // TODO: might not be correct. Was : Exit While 
		} 
		iteration += 1; 
	    } 

	    resultList.Sort(); 
	    string[] result = new string[resultList.Count]; 
	    Array.Copy(resultList.ToArray(), result, resultList.Count); 
	    return result; 
	} 


	//Formats the resultItem and adds it to the list of suggestions. 
	public virtual bool FormatSuggestions(string prefixText, string resultItem, int columnLength, string AutoTypeAheadDisplayFoundText, string autoTypeAheadSearch, string AutoTypeAheadWordSeparators, ArrayList resultList) 
	{
        int index = StringUtils.InvariantLCase(resultItem).IndexOf(StringUtils.InvariantLCase(prefixText)); 
	    string itemToAdd = ""; 
	    bool isFound = false; 
	    bool isAdded = false; 
	    // Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText. 
        if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") & !(index == 0))
        { 
		// Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText 
		System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
		if (regex1.IsMatch(resultItem)) { 
		    index = regex1.Match(resultItem).Index; 
		    isFound = true; 
		} 
		// If the prefixText is found immediatly after white space then starting of the word is found so don not search any further 
		if (!(resultItem[index].ToString() == " ")) { 
		    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText 
		    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
		    if (regex.IsMatch(resultItem)) { 
			index = regex.Match(resultItem).Index; 
			isFound = true; 
		    } 
		} 
	    } 
	    // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
	    // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
        if (index == 0 | isFound | StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring"))
        {
            if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring"))
            { 
		    // Expression to find beginning of the word which contains prefixText 
		    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
		    // Find the beginning of the word which contains prefexText 
		    if ((StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem))) { 
			index = regex1.Match(resultItem).Index; 
			isFound = true; 
		    } 
		    // Display string from the index till end of the string if sub string from index till end is less than columnLength value. 
		    if (resultItem.Length - index <= columnLength) { 
			if (index == 0) { 
			    itemToAdd = resultItem; 
			} 
			else {
                itemToAdd = "..." + resultItem.Substring(index, resultItem.Length - index); 
			} 
		    } 
		    else { 
			if (index == 0) { 
			    itemToAdd = resultItem.Substring(index, (columnLength - 3)) + "..."; 
			} 
			else { 
			    //Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended. 
			    itemToAdd = "..." + resultItem.Substring(index, columnLength - 6) + "..."; 
			} 
		    } 
		} 
		else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) { 
		    int subStringBeginIndex = (int)columnLength / 2; 
		    if (resultItem.Length <= columnLength) { 
			itemToAdd = resultItem; 
		    } 
		    else { 
			// Sanity check at end of the string 
			if (index + prefixText.Length == columnLength) { 
			    itemToAdd = "..." + resultItem.Substring(index - columnLength, index); 
			} 
			else if (resultItem.Length - index < subStringBeginIndex) { 
			    // Display string from the end till columnLength value if, index is closer to the end of the string. 
                itemToAdd = "..." + resultItem.Substring(resultItem.Length - columnLength, resultItem.Length); 
			} 
			else if (index <= subStringBeginIndex) { 
			    // Sanity chet at beginning of the string 
			    itemToAdd = resultItem.Substring(0, columnLength) + "..."; 
			} 
			else { 
			    // Display string containing text before the prefixText occures and text after the prefixText 
			    itemToAdd = "..." + resultItem.Substring(index - subStringBeginIndex, columnLength) + "..."; 
			} 
		    } 
		} 
		else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) { 
		    // Expression to find ending of the word which contains prefexText 
		    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
		    // Find the ending of the word which contains prefexText 
		    if (regex1.IsMatch(resultItem, index + 1)) { 
			index = regex1.Match(resultItem, index + 1).Index; 
		    } 
		    else { 
			// If the word which contains prefexText is the last word in string, regex1.IsMatch returns false. 
			index = resultItem.Length; 
		    }
            if (index > resultItem.Length)
            {
                index = resultItem.Length; 
		    } 
		    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index. 
		    if (index <= columnLength) {
                if (index == resultItem.Length)
                { 
			    //Make decision to append "..." 
			    itemToAdd = resultItem.Substring(0, index); 
			} 
			else { 
			    itemToAdd = resultItem.Substring(0, index) + "..."; 
			} 
		    } 
		    else {
                if (index == resultItem.Length)
                { 
			    itemToAdd = "..." + resultItem.Substring(index - (columnLength - 3), (columnLength - 3)); 
			} 
			else { 
			    //Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended. 
			    itemToAdd = "..." + resultItem.Substring(index - (columnLength - 6), columnLength - 6) + "..."; 
			} 
		    } 
		} 
		if ((itemToAdd != null) && !resultList.Contains(itemToAdd)) { 
		    resultList.Add(itemToAdd); 
		    isAdded = true; 
		} 
	    } 
	    return isAdded; 
	} 


        private void Control_PreRender(object sender, System.EventArgs e)
        {
            if (this.DataChanged)
            {
                try
                {
                    DbUtils.StartTransaction();
                    this.LoadData();
                    this.DataBind();
                }
                catch (Exception ex)
                {
                    MiscUtils.RegisterJScriptAlert(this, "Load_Error_Message", ex.Message);
                }
                finally
                {
                    DbUtils.EndTransaction();
                }
            }
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string orderByStr = ((string)(ViewState["ItemsTable_OrderBy"]));
            if (!(orderByStr == null || orderByStr.Length > 0))
            {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
            else
            {
                this.CurrentSortOrder = new OrderBy(true, true);
            }

            if (ViewState["Page_Index"] != null)
            {
                this.PageIndex = (int)ViewState["Page_Index"];
            }

            if (ViewState["Page_Size"] != null)
            {
                this.PageSize = (int)ViewState["Page_Size"];
            }
        }

        protected override object SaveViewState()
        {
            if (this.CurrentSortOrder != null)
            {
                this.ViewState["ItemsTable_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
            return base.SaveViewState();
        }

        public virtual void Pagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
            try
            {
                this.PageIndex = 0;
                this.DataChanged = true;
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
            }
        }

        public virtual void Pagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
            try
            {
                this.DisplayLastPage = true;
                this.DataChanged = true;
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
            }
        }

        public virtual void Pagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
            try
            {
                this.PageIndex += 1;
                this.DataChanged = true;
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
            }
        }

        public virtual void Pagination_PageSizeButton_Click(object sender, EventArgs args)
        {
            try
            {
                this.DataChanged = true;
                this.PageSize = Convert.ToInt32(this.Pagination.PageSize.Text);
                this.PageIndex = Convert.ToInt32(this.Pagination.CurrentPage.Text) - 1;
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
            }
        }

        public virtual void Pagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
            try
            {
                if (this.PageIndex > 0)
                {
                    this.PageIndex -= 1;
                    this.DataChanged = true;
                }
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
            }
        }

        public virtual void SearchButton_Click(object sender, EventArgs args)
        {
            try
            {
                this.DataChanged = true;
            }
            catch (Exception ex)
            {
                MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
            }
        }

        private int _PageSize;
        public int PageSize
        {
            get
            {
                return this._PageSize;
            }
            set
            {
                this._PageSize = value;
            }
        }

        private int _PageIndex;
        public int PageIndex
        {
            get
            {
                return this._PageIndex;
            }
            set
            {
                this._PageIndex = value;
            }
        }

        private int _TotalRecords;
        public int TotalRecords
        {
            get
            {
                return this._TotalRecords;
            }
            set
            {
                if (this.PageSize > 0)
                {
					double num = this.PageSize;
					this.TotalPages = System.Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value / num)));
				}
                this._TotalRecords = value;
            }
        }

        private int _TotalPages;
        public int TotalPages
        {
            get
            {
                return this._TotalPages;
            }
            set
            {
                this._TotalPages = value;
            }
        }


        private bool _DisplayLastPage;
        public bool DisplayLastPage
        {
            get
            {
                return this._DisplayLastPage;
            }
            set
            {
                this._DisplayLastPage = value;
            }
        }

        private bool _DataChanged = false;
        public bool DataChanged
        {
            get
            {
                return this._DataChanged;
            }
            set
            {
                this._DataChanged = value;
            }
        }

        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder
        {
            get
            {
                return this._CurrentSortOrder;
            }
            set
            {
                this._CurrentSortOrder = value;
            }
        }

        private BaseRecord[] _DataSource = null;
        public BaseRecord[] DataSource
        {
            get
            {
                return this._DataSource;
            }
            set
            {
                this._DataSource = value;
            }
        }

        public string Table
        {
            get
            {
                string errMsg;
                string TYPE_FORMAT = "{0}.{1}{2},{3}";

		        string tableName = ""; 
		        try { 
			        // Try getting from the URL. If not, get it from the session. 
			        tableName = BaseClasses.Utils.NetUtils.GetUrlParam(this, "Table", true); 
		        } 
		        catch (Exception ) { 
			        // Get from the session. This table name already contains the prefix required, so we return directly. 
			        tableName = (string) HttpContext.Current.Session["LLSAjaxTable"]; 
			        return tableName; 
		        } 
                tableName = ((BaseApplicationPage)this.Page).Decrypt(tableName);

                tableName = tableName.Replace(" ", "_");

                try
                {
                    string tableType = string.Format(TYPE_FORMAT, "KumePortali.Business", tableName, "Table", "App_Code");
                    Type.GetType(tableType, true, true);
                    return tableType;
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                }
                try
                {
                    string viewType = string.Format(TYPE_FORMAT, "KumePortali.Business", tableName, "View", "App_Code");
                    Type.GetType(viewType, true, true);
                    return viewType;
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                }
                try
                {
                    string queryType = string.Format(TYPE_FORMAT, "KumePortali.Business", tableName, "Query", "App_Code");
                    Type.GetType(queryType, true, true);
                    return queryType;
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                }
                return "";
            }
        }

        public string Field
        {
            get
            {
		    string fld = ""; 
		    try { 
			// Try getting from the URL. If not, get it from the session. 
			fld = BaseClasses.Utils.NetUtils.GetUrlParam(this, "Field", true); 
		    } 
		    catch (Exception ) { 
			// Get from the session 
                fld = (string) HttpContext.Current.Session["LLSAjaxField"];
		    } 

           fld = ((BaseApplicationPage)this.Page).Decrypt(fld);
		    return fld; 
            }
        }

        public string DisplayField
        {
            get
            {
		    string fld = ""; 
		    try { 
			// Try getting from the URL. If not, get it from the session. 
			fld = BaseClasses.Utils.NetUtils.GetUrlParam(this, "DisplayField", true); 
		    } 
		    catch (Exception ) { 
			// Get from the session 
			fld = (string) HttpContext.Current.Session["LLSAjaxDisplayField"]; 
		    } 
            fld = ((BaseApplicationPage)this.Page).Decrypt(fld);

		    return fld; 
            }
        }

        public string Target
        {
            get
            {
                return NetUtils.GetUrlParam(this, "Target", true);
            }
        }

        public System.Web.UI.WebControls.TextBox StartsWith
        {
            get
            {
                return ((System.Web.UI.WebControls.TextBox)(MiscUtils.FindControlRecursively(this, "StartsWith")));
            }
        }

        public System.Web.UI.WebControls.TextBox Contains
        {
            get
            {
                return ((System.Web.UI.WebControls.TextBox)(MiscUtils.FindControlRecursively(this, "Contains")));
            }
        }

        public KumePortali.UI.IThemeButton SearchButton
        {
            get
            {
                return ((KumePortali.UI.IThemeButton)(MiscUtils.FindControlRecursively(this, "SearchButton")));
            }
        }

        public KumePortali.UI.IPagination Pagination
        {
            get
            {
                return ((KumePortali.UI.IPagination)(MiscUtils.FindControlRecursively(this, "Pagination")));
            }
        }

        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return ModifyRedirectUrl(url, arg, null, false);
        }

        public ItemsTableRecordControl[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = ((System.Web.UI.WebControls.Repeater)(this.FindControl("row1")));

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                ItemsTableRecordControl recControl = ((ItemsTableRecordControl)(repItem.FindControl("ItemsTableRecordControl")));
                recList.Add(recControl);
            }
            return ((ItemsTableRecordControl[])(recList.ToArray(Type.GetType("KumePortali.UI.Controls.LargeListSelector.ItemsTableRecordControl"))));
        }

        public new BaseApplicationPage Page
        {
            get
            {
                return ((BaseApplicationPage)(base.Page));
            }
        }

        private void RegisterAutoCloseScript()
        {
            if ((StringUtils.InvariantUCase(this.Page.Request.Browser.Browser).IndexOf("IE") < 0))
            {
                return;
            }
            if ((this.Page.Request.Browser.MajorVersion < 5))
            {
                return;
            }
            string script = BaseClasses.Web.AspxTextWriter.CreateJScriptBlock("function onParentUnload() { window.close(); }" + "\r\n" + "if (window.opener && !window.opener.closed) { window.opener.attachEvent('onunload', onParentUnload);}");
            this.Page.ClientScript.RegisterClientScriptBlock(typeof(string), "AutoCloseScript", script);
        }

        public BaseClasses.Data.BaseTable GetTable()
        {
            string tn = this.Table;
            try
            {
                return BaseClasses.Data.BaseTable.CreateInstance(tn);
            }
            catch (System.Exception )
            {
                tn = string.Format("{0}.{1}Access,{2}", "KumePortali", tn.Replace(" ", "_"), "KumePortali");
                return BaseClasses.Data.BaseTable.CreateInstance(tn);
            }
        }
    }
}