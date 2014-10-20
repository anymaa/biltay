
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowSysdiagramsTablePage.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;




        
using KumePortali.Business;
using KumePortali.Data;
        

#endregion

  
namespace KumePortali.UI.Controls.ShowSysdiagramsTablePage
{
  

#region "Section 1: Place your customizations here."

    
public class SysdiagramsTableControlRow : BaseSysdiagramsTableControlRow
{
      
        // The BaseSysdiagramsTableControlRow implements code for a ROW within the
        // the SysdiagramsTableControl table.  The BaseSysdiagramsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of SysdiagramsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class SysdiagramsTableControl : BaseSysdiagramsTableControl
{
        // The BaseSysdiagramsTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The SysdiagramsTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the SysdiagramsTableControlRow control on the ShowSysdiagramsTablePage page.
// Do not modify this class. Instead override any method in SysdiagramsTableControlRow.
public class BaseSysdiagramsTableControlRow : KumePortali.UI.BaseApplicationRecordControl
{
        public BaseSysdiagramsTableControlRow()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in SysdiagramsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            
      
      
            // Register the event handlers.
        
              this.SysdiagramsRowViewButton.Click += new ImageClickEventHandler(SysdiagramsRowViewButton_Click);
              this.SysdiagramsRowEditButton.Click += new ImageClickEventHandler(SysdiagramsRowEditButton_Click);
              this.SysdiagramsRowDeleteButton.Click += new ImageClickEventHandler(SysdiagramsRowDeleteButton_Click);
        }

        // To customize, override this method in SysdiagramsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.SysdiagramsRowDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "KumePortali") + "'));");
        }

        // Read data from database. To customize, override this method in SysdiagramsTableControlRow.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = SysdiagramsTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseSysdiagramsTableControl when the data for the entire
            // table is loaded.
            this.DataSource = new SysdiagramsRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in SysdiagramsTableControlRow.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.nameSpecified) {
                      
                string formattedValue = this.DataSource.Format(SysdiagramsTable.name);
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(100);
                              
                    int maxLength = formattedValue.Length;
                    if (maxLength > (int)(100)){
                        maxLength = (int)(100);
                        
                    }
                                
                    if (formattedValue.Length >= popupThreshold) {
                         formattedValue = "<a OnClick=\'gPersist=true;\' OnMouseOut=\'detailRolloverPopupClose();\'" +
                            "OnMouseOver=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"KumePortali.Business.SysdiagramsTable, App_Code\\\",\\\"" +
                              (this.DataSource.GetID().ToString()).Replace("\\","\\\\\\\\") + "\\\", \\\"name\\\", \\\"Name\\\"," +
                            " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength));
                        if (maxLength == (int)(100))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(100)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,maxLength));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.name.Text = formattedValue;
              
               
            } else {  
                this.name.Text = SysdiagramsTable.name.Format(SysdiagramsTable.name.DefaultValue);
                            
            }
                    
            if (this.name.Text == null ||
                this.name.Text.Trim().Length == 0) {
                this.name.Text = "&nbsp;";
            }
                  
            if (this.DataSource.principal_idSpecified) {
                      
                string formattedValue = this.DataSource.Format(SysdiagramsTable.principal_id);
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    
                    int maxLength = formattedValue.Length;
                    if (maxLength > (int)(100)){
                        maxLength = (int)(100);
                        
                    }
                    if (maxLength == (int)(100)) {
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,maxLength));
                        formattedValue = formattedValue + "...";
                    }
                                       
                }                              
                    
                this.principal_id.Text = formattedValue;
              
               
            } else {  
                this.principal_id.Text = SysdiagramsTable.principal_id.Format(SysdiagramsTable.principal_id.DefaultValue);
                            
            }
                    
            if (this.principal_id.Text == null ||
                this.principal_id.Text.Trim().Length == 0) {
                this.principal_id.Text = "&nbsp;";
            }
                  
            if (this.DataSource.versionSpecified) {
                      
                string formattedValue = this.DataSource.Format(SysdiagramsTable.version);
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    
                    int maxLength = formattedValue.Length;
                    if (maxLength > (int)(100)){
                        maxLength = (int)(100);
                        
                    }
                    if (maxLength == (int)(100)) {
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,maxLength));
                        formattedValue = formattedValue + "...";
                    }
                                       
                }                              
                    
                this.version.Text = formattedValue;
              
               
            } else {  
                this.version.Text = SysdiagramsTable.version.Format(SysdiagramsTable.version.DefaultValue);
                            
            }
                    
            if (this.version.Text == null ||
                this.version.Text.Trim().Length == 0) {
                this.version.Text = "&nbsp;";
            }
                  
            this.IsNewRecord = true;
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
        
                this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
            }

            

            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            
        }
        
        

        //  To customize, override this method in SysdiagramsTableControlRow.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in SysdiagramsTableControlRow to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in SysdiagramsTableControlRow to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((SysdiagramsTableControl)MiscUtils.GetParentControlObject(this, "SysdiagramsTableControl")).DataChanged = true;
                ((SysdiagramsTableControl)MiscUtils.GetParentControlObject(this, "SysdiagramsTableControl")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in SysdiagramsTableControlRow.
        public virtual void GetUIData()
        {
        
      }

      

        //  To customize, override this method in SysdiagramsTableControlRow.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        
        

        //  To customize, override this method in SysdiagramsTableControlRow.
        public virtual void Validate()
        {
            // Initially empty.  Override to add custom validation.
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pk = KeyValue.XmlToKey(this.RecordUniqueId);
            SysdiagramsTable.DeleteRecord(pk);

          
            ((SysdiagramsTableControl)MiscUtils.GetParentControlObject(this, "SysdiagramsTableControl")).DataChanged = true;
            ((SysdiagramsTableControl)MiscUtils.GetParentControlObject(this, "SysdiagramsTableControl")).ResetData = true;
        }

        private void Control_PreRender(object sender, System.EventArgs e)
        {
            try {
                DbUtils.StartTransaction();

                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                    this.LoadData();
                    this.DataBind();
                }

            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
                
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        
            return base.SaveViewState();
        }

        
        // event handler for ImageButton
        public virtual void SysdiagramsRowViewButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../sysdiagrams/ShowSysdiagramsPage.aspx?Sysdiagrams={PK}";
            bool shouldRedirect = true;
            string TargetKey;
			string tk = null;
			TargetKey = tk;
            
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsRowEditButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../sysdiagrams/EditSysdiagramsPage.aspx?Sysdiagrams={PK}";
            bool shouldRedirect = true;
            string TargetKey;
			string tk = null;
			TargetKey = tk;
            
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
                this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
        private bool _IsNewRecord = true;
        public virtual bool IsNewRecord {
            get {
                return this._IsNewRecord;
            }
            set {
                this._IsNewRecord = value;
            }
        }

        private bool _DataChanged = false;
        public virtual bool DataChanged {
            get {
                return this._DataChanged;
            }
            set {
                this._DataChanged = value;
            }
        }

        private bool _ResetData = false;
        public virtual bool ResetData {
            get {
                return (this._ResetData);
            }
            set {
                this._ResetData = value;
            }
        }
        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseSysdiagramsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseSysdiagramsTableControlRow_Rec"] = value;
            }
        }
        
        private SysdiagramsRecord _DataSource;
        public SysdiagramsRecord DataSource {
            get {
                return (this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsRowViewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsRowViewButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsRowEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsRowEditButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SysdiagramsRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsRecordRowSelection");
            }
        }
        
        public System.Web.UI.WebControls.Literal name {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "name");
            }
        }
            
        public System.Web.UI.WebControls.Literal principal_id {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "principal_id");
            }
        }
            
        public System.Web.UI.WebControls.Literal version {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "version");
            }
        }
            
#endregion

#region "Helper Functions"
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            SysdiagramsRecord rec = null;
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
      if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
            throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "KumePortali"));
                    
            }
        return ModifyRedirectUrl(url, arg, rec, bEncrypt);
        }

        public SysdiagramsRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return SysdiagramsTable.GetRecord(this.RecordUniqueId, true);
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "KumePortali"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the SysdiagramsTableControl control on the ShowSysdiagramsTablePage page.
// Do not modify this class. Instead override any method in SysdiagramsTableControl.
public class BaseSysdiagramsTableControl : KumePortali.UI.BaseApplicationTableControl
{
        public BaseSysdiagramsTableControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.SysdiagramsPagination.FirstPage.Click += new ImageClickEventHandler(SysdiagramsPagination_FirstPage_Click);
              this.SysdiagramsPagination.LastPage.Click += new ImageClickEventHandler(SysdiagramsPagination_LastPage_Click);
              this.SysdiagramsPagination.NextPage.Click += new ImageClickEventHandler(SysdiagramsPagination_NextPage_Click);
              this.SysdiagramsPagination.PageSizeButton.Click += new EventHandler(SysdiagramsPagination_PageSizeButton_Click);
            
              this.SysdiagramsPagination.PreviousPage.Click += new ImageClickEventHandler(SysdiagramsPagination_PreviousPage_Click);

            // Setup the sorting events.
        
              this.nameLabel1.Click += new EventHandler(nameLabel1_Click);
            
              this.principal_idLabel1.Click += new EventHandler(principal_idLabel1_Click);
            
              this.versionLabel.Click += new EventHandler(versionLabel_Click);
            

            // Setup the button events.
        
              this.SysdiagramsNewButton.Click += new ImageClickEventHandler(SysdiagramsNewButton_Click);
              this.SysdiagramsDeleteButton.Click += new ImageClickEventHandler(SysdiagramsDeleteButton_Click);
              this.SysdiagramsExportExcelButton.Click += new ImageClickEventHandler(SysdiagramsExportExcelButton_Click);
                      this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SysdiagramsExportExcelButton"), MiscUtils.GetParentControlObject(this,"SysdiagramsTableControlUpdatePanel"));
                    
              this.SysdiagramsRefreshButton.Click += new ImageClickEventHandler(SysdiagramsRefreshButton_Click);
              this.SysdiagramsResetButton.Click += new ImageClickEventHandler(SysdiagramsResetButton_Click);
              this.SysdiagramsSearchButton.Button.Click += new EventHandler(SysdiagramsSearchButton_Click);
              this.SysdiagramsFilterButton.Button.Click += new EventHandler(SysdiagramsFilterButton_Click);

            // Setup the filter and search events.
        
            this.nameFilter.SelectedIndexChanged += new EventHandler(nameFilter_SelectedIndexChanged);
            if (!this.Page.IsPostBack && this.InSession(this.SysdiagramsSearchArea)) {
                
                this.SysdiagramsSearchArea.Text = this.GetFromSession(this.SysdiagramsSearchArea);
                
            }
            if (!this.Page.IsPostBack && this.InSession(this.nameFilter)) {
                this.nameFilter.Items.Add(new ListItem(this.GetFromSession(this.nameFilter), this.GetFromSession(this.nameFilter)));
                this.nameFilter.SelectedValue = this.GetFromSession(this.nameFilter);
                
            }
            if (!this.Page.IsPostBack && this.InSession(this.principal_idFromFilter)) {
                
                this.principal_idFromFilter.Text = this.GetFromSession(this.principal_idFromFilter);
                
            }
            if (!this.Page.IsPostBack && this.InSession(this.principal_idToFilter)) {
                
                this.principal_idToFilter.Text = this.GetFromSession(this.principal_idToFilter);
                
            }

            // Control Initializations.
            // Initialize the table's current sort order.
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            } else {
                this.CurrentSortOrder = new OrderBy(true, true);
        
            }

    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
            this.ClearControlsFromSession();
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
                // Show confirmation message on Click
                this.SysdiagramsDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "KumePortali") + "'));");
        }

        // Read data from database. Returns an array of records that can be assigned
        // to the DataSource table control property.
        public virtual void LoadData()
        {
            try {
            
                // The WHERE clause will be empty when displaying all records in table.
                WhereClause wc = CreateWhereClause();
                if (wc != null && !wc.RunQuery) {
                    // Initialize an empty array of records
                    ArrayList alist = new ArrayList(0);
                    this.DataSource = (SysdiagramsRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.SysdiagramsRecord")));
                    // Add records to the list if needed.
                    this.AddNewRecords();
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = SysdiagramsTable.GetRecordCount(wc);

                // Go to the last page.
                if (this.TotalPages <= 0 || this.PageIndex < 0) {
                    this.PageIndex = 0;
                } else if (this.DisplayLastPage || this.PageIndex >= this.TotalPages) {
                    this.PageIndex = this.TotalPages - 1;
                }

                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.TotalRecords <= 0) {
                    // Initialize an empty array of records
                    ArrayList alist = new ArrayList(0);
                    this.DataSource = (SysdiagramsRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.SysdiagramsRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (SysdiagramsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (SysdiagramsRecord[])(postdata.ToArray(Type.GetType("KumePortali.Business.SysdiagramsRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = SysdiagramsTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
                }
                // Add records to the list.
                this.AddNewRecords();

                // Initialize the page and grand totals. now
            
            } catch (Exception ex) {
                throw ex;
            }
        }

        // Populate the UI controls.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // Setup the pagination controls.
            BindPaginationControls();

            // Populate all filters data.
        
            this.PopulatenameFilter(MiscUtils.GetSelectedValue(this.nameFilter, this.GetFromSession(this.nameFilter)), 500);
                    

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("SysdiagramsTableControlRepeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                SysdiagramsTableControlRow recControl = (SysdiagramsTableControlRow)(repItem.FindControl("SysdiagramsTableControlRow"));
                recControl.DataSource = this.DataSource[index];
                recControl.DataBind();
                recControl.Visible = !this.InDeletedRecordIds(recControl);
                index += 1;
            }
        }

         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for SysdiagramsTableControl pagination.
        
            this.SysdiagramsPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            this.SysdiagramsPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.SysdiagramsPagination.LastPage.Enabled = false;
            }
          
            this.SysdiagramsPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.SysdiagramsPagination.NextPage.Enabled = false;
            }
          
            this.SysdiagramsPagination.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.SysdiagramsPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.SysdiagramsPagination.CurrentPage.Text = "0";
            }
            this.SysdiagramsPagination.PageSize.Text = this.PageSize.ToString();
            this.SysdiagramsTotalItems.Text = this.TotalRecords.ToString();
            this.SysdiagramsPagination.TotalItems.Text = this.TotalRecords.ToString();
            this.SysdiagramsPagination.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (SysdiagramsTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    recCtl.Delete();
                } else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }
            
            this.DataChanged = true;
            this.ResetData = true;
        }

        public virtual OrderBy CreateOrderBy()
        {
            return this.CurrentSortOrder;
        }

        // This CreateWhereClause is used for loading the data.
        public virtual WhereClause CreateWhereClause()
        {
            SysdiagramsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        
            if (MiscUtils.IsValueSelected(this.SysdiagramsSearchArea)) {
                // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (this.SysdiagramsSearchArea.Text.StartsWith("...")) {
                    this.SysdiagramsSearchArea.Text = this.SysdiagramsSearchArea.Text.Substring(3,this.SysdiagramsSearchArea.Text.Length-3);
                }
                if (this.SysdiagramsSearchArea.Text.EndsWith("...")) {
                    this.SysdiagramsSearchArea.Text = this.SysdiagramsSearchArea.Text.Substring(0,this.SysdiagramsSearchArea.Text.Length-3);
                }
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SysdiagramsSearchArea)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    WhereClause search = new WhereClause();
                    
                    search.iOR(SysdiagramsTable.name, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SysdiagramsSearchArea, this.GetFromSession(this.SysdiagramsSearchArea)), true, false);
        
                    wc.iAND(search);
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.nameFilter)) {
                        
                wc.iAND(SysdiagramsTable.name, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.nameFilter, this.GetFromSession(this.nameFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.principal_idFromFilter)) {
                        
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.principal_idFromFilter, this.GetFromSession(this.principal_idFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.principal_idToFilter)) {
                        
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.principal_idToFilter, this.GetFromSession(this.principal_idToFilter)), false, false);
                    
            }
                      
            return (wc);
        }
        
         
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            SysdiagramsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelatvieVirtualPath"];
          
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "SysdiagramsSearchArea") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
                        search.iOR(SysdiagramsTable.name, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                        search.iOR(SysdiagramsTable.name, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                  
                
                    } else {
                        
                        search.iOR(SysdiagramsTable.name, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
                    } 
                    wc.iAND(search);
                }
            }
                  
            String nameFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "nameFilter_Ajax"];
            if (MiscUtils.IsValueSelected(nameFilterSelectedValue)) {
                wc.iAND(SysdiagramsTable.name, BaseFilter.ComparisonOperator.EqualsTo, nameFilterSelectedValue, false, false);
            }
                      
            String principal_idFromFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "principal_idFromFilter_Ajax"];
            if (MiscUtils.IsValueSelected(principal_idFromFilterSelectedValue)) {
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, principal_idFromFilterSelectedValue, false, false);
            }
                      
            String principal_idToFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "principal_idToFilter_Ajax"];
            if (MiscUtils.IsValueSelected(principal_idToFilterSelectedValue)) {
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, principal_idToFilterSelectedValue, false, false);
            }
                      
            return wc;
        }
          
         public virtual string[] GetAutoCompletionList_SysdiagramsSearchArea(String prefixText,int count)
         {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            int iteration = 0;
            
            WhereClause wc= CreateWhereClause(prefixText,"SysdiagramsSearchArea", "AnyWhereInString", "[^a-zA-Z0-9]");
            while (resultList.Count < count && iteration < 5){
                // Fetch 100 records in each iteration
                KumePortali.Business.SysdiagramsRecord[] records = SysdiagramsTable.GetRecords(wc, null, iteration, 100);
                String resultItem = "";
                foreach (SysdiagramsRecord rec in records){
                    // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                    if (resultList.Count >= count) {
                        break;
                    }
                    // If the field is configured to Display as Foreign key, Format() method returns the 
                    // Display as Forien Key value instead of original field value.
                    // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                    // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
            
                    resultItem = rec.Format(SysdiagramsTable.name);
                    if (StringUtils.InvariantUCase(resultItem).Contains(StringUtils.InvariantUCase(prefixText))) {
                        bool isAdded = FormatSuggestions(prefixText, resultItem, 50, "InMiddleOfMatchedString", "AnyWhereInString", "[^a-zA-Z0-9]", resultList);
                        if (isAdded) {
                            continue;
                        }
                    }
      
                }
                // Exit the loop if number of records found is less as further iteration will not return any more records
                if (records.Length < 100 ) {
                    break;
                }
                iteration++;
            }
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
        }
          
        // Formats the result Item and adds it to the list of suggestions.
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
              int index  = StringUtils.InvariantLCase(resultItem).IndexOf(StringUtils.InvariantLCase(prefixText));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                 // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = "..." + resultItem.Substring(index, resultItem.Length - index);
                        }
                    } else {
                        if (index == 0) {
                          itemToAdd = resultItem.Substring(index, (columnLength - 3)) + "...";
                        } else {
                            // Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." + resultItem.Substring(index, (columnLength - 6)) + "...";
                        }
                    }
                } else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    } else {
                        // Sanity check at end of the string
                        if ((index + prefixText.Length) == columnLength) {
                            itemToAdd = "..." + resultItem.Substring((index - columnLength), index);
                        } else if ((resultItem.Length - index) < subStringBeginIndex) {
                            //  Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd = "..." + resultItem.Substring(resultItem.Length - columnLength, resultItem.Length);
                        } else if (index <= subStringBeginIndex) {
                            // Sanity chet at beginning of the string
                            itemToAdd = resultItem.Substring(0, columnLength) + "...";
                        } else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = "..." + resultItem.Substring(index - subStringBeginIndex, columnLength) + "...";
                        }
                    }
                } else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        if (index == resultItem.Length) {   //Make decision to append "..."
                            itemToAdd = resultItem.Substring(0, index);
                        } else {
                            itemToAdd = resultItem.Substring(0, index) + "...";
                        }
                    } else if (index == resultItem.Length) {
                        itemToAdd = "..." + resultItem.Substring(index - (columnLength - 3), columnLength - 3);
                    } else {
                        // Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                        itemToAdd = "..." + resultItem.Substring(index - (columnLength - 6), (columnLength - 6)) + "...";
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.InvariantCultureIgnoreCase);
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {
                    if (itemToAdd.EndsWith("...")) {
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...";
                    }
                    else {
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);
                    }
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    if (itemToAdd.StartsWith("...")) {
                        itemToAdd = "..." + itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                    }
                    else {
                        itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                    }
                }

                if (itemToAdd!= null && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.SysdiagramsPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.SysdiagramsPagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
            ArrayList newRecordList = new ArrayList();

            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("SysdiagramsTableControlRepeater"));

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    SysdiagramsTableControlRow recControl = (SysdiagramsTableControlRow)(repItem.FindControl("SysdiagramsTableControlRow"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        SysdiagramsRecord rec = new SysdiagramsRecord();
        
                        if (recControl.name.Text != "") {
                            rec.Parse(recControl.name.Text, SysdiagramsTable.name);
                  }
                
                        if (recControl.principal_id.Text != "") {
                            rec.Parse(recControl.principal_id.Text, SysdiagramsTable.principal_id);
                  }
                
                        if (recControl.version.Text != "") {
                            rec.Parse(recControl.version.Text, SysdiagramsTable.version);
                  }
                
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new SysdiagramsRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (SysdiagramsRecord[])(finalList.ToArray(Type.GetType("KumePortali.Business.SysdiagramsRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(SysdiagramsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(SysdiagramsTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
        // Get the filters' data for nameFilter.
                
        protected virtual void PopulatenameFilter(string selectedValue, int maxItems)
                    
        {
              
            // Setup the WHERE clause, including the base table if needed.
                
            WhereClause wc = new WhereClause();
                  
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(SysdiagramsTable.name, OrderByItem.OrderDir.Asc);

            string[] list = SysdiagramsTable.GetValues(SysdiagramsTable.name, wc, orderBy, maxItems);
            
            this.nameFilter.Items.Clear();
            
            foreach (string itemValue in list)
            {
                // Create the item and add to the list.
                string fvalue;
                if ( SysdiagramsTable.name.IsColumnValueTypeBoolean()) {
                    fvalue = itemValue;
                }else {
                    fvalue = SysdiagramsTable.name.Format(itemValue);
                }
                ListItem item = new ListItem(fvalue, itemValue);
                this.nameFilter.Items.Add(item);
            }
                    
            // Set the selected value.
            MiscUtils.SetSelectedValue(this.nameFilter, selectedValue);

            // Add the All item.
            this.nameFilter.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:All", "KumePortali"), "--ANY--"));
                
        }
                          
        // Create a where clause for the filter SysdiagramsSearchArea.
        public virtual WhereClause CreateWhereClause_SysdiagramsSearchArea()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.nameFilter)) {
                        
                wc.iAND(SysdiagramsTable.name, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.nameFilter, this.GetFromSession(this.nameFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.principal_idFromFilter)) {
                        
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.principal_idFromFilter, this.GetFromSession(this.principal_idFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.principal_idToFilter)) {
                        
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.principal_idToFilter, this.GetFromSession(this.principal_idToFilter)), false, false);
                    
            }
                      
            return wc;
        }
                          
        // Create a where clause for the filter nameFilter.
        public virtual WhereClause CreateWhereClause_nameFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.SysdiagramsSearchArea)) {
                // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (this.SysdiagramsSearchArea.Text.StartsWith("...")) {
                    this.SysdiagramsSearchArea.Text = this.SysdiagramsSearchArea.Text.Substring(3,this.SysdiagramsSearchArea.Text.Length-3);
                }
                if (this.SysdiagramsSearchArea.Text.EndsWith("...")) {
                    this.SysdiagramsSearchArea.Text = this.SysdiagramsSearchArea.Text.Substring(0,this.SysdiagramsSearchArea.Text.Length-3);
                }
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.SysdiagramsSearchArea)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    WhereClause search = new WhereClause();
                    
                    search.iOR(SysdiagramsTable.name, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.SysdiagramsSearchArea, this.GetFromSession(this.SysdiagramsSearchArea)), true, false);
        
                    wc.iAND(search);
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.principal_idFromFilter)) {
                        
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(this.principal_idFromFilter, this.GetFromSession(this.principal_idFromFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.principal_idToFilter)) {
                        
                wc.iAND(SysdiagramsTable.principal_id, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(this.principal_idToFilter, this.GetFromSession(this.principal_idToFilter)), false, false);
                    
            }
                      
            return wc;
        }
            
        private void Control_PreRender(object sender, System.EventArgs e)
        {
            try {
                DbUtils.StartTransaction();
                
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                    this.LoadData();
                    this.DataBind();
                }
                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();

            // Save filter controls to values to session.
        
            this.SaveToSession(this.SysdiagramsSearchArea, this.SysdiagramsSearchArea.Text);
                  
            this.SaveToSession(this.nameFilter, this.nameFilter.SelectedValue);
                  
            this.SaveToSession(this.principal_idFromFilter, this.principal_idFromFilter.Text);
                  
            this.SaveToSession(this.principal_idToFilter, this.principal_idToFilter.Text);
                  
            
            // Save table control properties to the session.
            if (this.CurrentSortOrder != null) {
                this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
            }
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
        
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession("SysdiagramsSearchArea_Ajax", this.SysdiagramsSearchArea.Text);
            this.SaveToSession("nameFilter_Ajax", this.nameFilter.SelectedValue);
            this.SaveToSession("principal_idFromFilter_Ajax", this.principal_idFromFilter.Text);
            this.SaveToSession("principal_idToFilter_Ajax", this.principal_idToFilter.Text);
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.SysdiagramsSearchArea);
            this.RemoveFromSession(this.nameFilter);
            this.RemoveFromSession(this.principal_idFromFilter);
            this.RemoveFromSession(this.principal_idToFilter);
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["SysdiagramsTableControl_OrderBy"];
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            } else {
                this.CurrentSortOrder = new OrderBy(true, true);
            }

            if (ViewState["Page_Index"] != null) {
                this.PageIndex = (int)ViewState["Page_Index"];
            }

            if (ViewState["Page_Size"] != null) {
                this.PageSize = (int)ViewState["Page_Size"];
            }
        
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
            if (this.CurrentSortOrder != null) {
                this.ViewState["SysdiagramsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void SysdiagramsPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsPagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsPagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for LinkButton
        public virtual void SysdiagramsPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
        
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.SysdiagramsPagination.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.SysdiagramsPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            

        // Generate the event handling functions for sorting events.
        
        // event handler for FieldSort
        public virtual void nameLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(SysdiagramsTable.name);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(SysdiagramsTable.name, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void principal_idLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(SysdiagramsTable.principal_id);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(SysdiagramsTable.principal_id, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void versionLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(SysdiagramsTable.version);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(SysdiagramsTable.version, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void SysdiagramsNewButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../sysdiagrams/AddSysdiagramsPage.aspx";
            bool shouldRedirect = true;
            string TargetKey;
			string tk = null;
			TargetKey = tk;
            
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(false);
          
            }
                this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsExportExcelButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = CreateWhereClause();
                OrderBy orderBy = null;
                
                orderBy = CreateOrderBy();
                
            // Create an instance of the Excel report class with the table class, where clause and order by.
            ExportData excelReport = new ExportData(SysdiagramsTable.Instance, wc, orderBy);
            // Add each of the columns in order of export.
            // To customize the data type, change the second parameter of the new ExcelColumn to be
            // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(new ExcelColumn(SysdiagramsTable.name, @"Default"));
             excelReport.AddColumn(new ExcelColumn(SysdiagramsTable.principal_id, @"0"));
             excelReport.AddColumn(new ExcelColumn(SysdiagramsTable.version, @"0"));

            excelReport.ExportToExcel(this.Page.Response);
                    this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsRefreshButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            ((SysdiagramsTableControl)(this.Page.FindControlRecursively("SysdiagramsTableControl"))).ResetData = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void SysdiagramsResetButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
              this.nameFilter.ClearSelection();
            
              this.SysdiagramsSearchArea.Text = "";
            
              this.principal_idFromFilter.Text = "";
            
              this.principal_idToFilter.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By")) {
              this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              } else {
              this.CurrentSortOrder = new OrderBy(true, true);
            
            }
                

            this.DataChanged = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            
        // event handler for Button with Layout
        public virtual void SysdiagramsSearchButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            
        // event handler for Button with Layout
        public virtual void SysdiagramsFilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            

        // Generate the event handling functions for filter and search events.
        
        // event handler for FieldFilter
        protected virtual void nameFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            this.DataChanged = true;
        }
            

        // verify the processing details for these properties
        private int _PageSize;
        public int PageSize {
            get {
                return this._PageSize;
            }
            set {
                this._PageSize = value;
            }
        }

        private int _PageIndex;
        public int PageIndex {
            get {
                // _PageSize return (the PageIndex);
                return this._PageIndex;
            }
            set {
                this._PageIndex = value;
            }
        }

        private int _TotalRecords;
        public int TotalRecords {
            get {
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                }
                this._TotalRecords = value;
            }
        }

        private int _TotalPages;
        public int TotalPages {
            get {
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        private bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }

        private bool _DataChanged = false;
        public bool DataChanged {
            get {
                return this._DataChanged;
            }
            set {
                this._DataChanged = value;
            }
        }

        private bool _ResetData = false;
        public bool ResetData {
            get {
                return this._ResetData;
            }
            set {
                this._ResetData = value;
            }
        }

        private int _AddNewRecord = 0;
        public int AddNewRecord {
            get {
                return this._AddNewRecord;
            }
            set {
                this._AddNewRecord = value;
            }
        }

        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }

        private SysdiagramsRecord[] _DataSource = null;
        public  SysdiagramsRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal SysdiagramsTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsTitle");
            }
        }
        
        public System.Web.UI.WebControls.Label SysdiagramsTotalItems {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsTotalItems");
            }
        }
        
        public System.Web.UI.WebControls.TextBox SysdiagramsSearchArea {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsSearchArea");
            }
        }
        
        public KumePortali.UI.IThemeButton SysdiagramsSearchButton {
            get {
                return (KumePortali.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsSearchButton");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList nameFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "nameFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal nameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "nameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox principal_idFromFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "principal_idFromFilter");
            }
        }
        
        public System.Web.UI.WebControls.TextBox principal_idToFilter {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "principal_idToFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal principal_idLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "principal_idLabel");
            }
        }
        
        public KumePortali.UI.IThemeButton SysdiagramsFilterButton {
            get {
                return (KumePortali.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsFilterButton");
            }
        }
        
        public KumePortali.UI.IPagination SysdiagramsPagination {
            get {
                return (KumePortali.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsNewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsNewButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsExportExcelButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsRefreshButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsRefreshButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SysdiagramsResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsResetButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SysdiagramsToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SysdiagramsToggleAll");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton nameLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "nameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton principal_idLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "principal_idLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton versionLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "versionLabel");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                SysdiagramsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
                }

                SysdiagramsRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return ModifyRedirectUrl(url, arg, rec, bEncrypt);
            }
            return url;
        }
          
        public int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (SysdiagramsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SysdiagramsRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public SysdiagramsTableControlRow GetSelectedRecordControl()
        {
        SysdiagramsTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public SysdiagramsTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (SysdiagramsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SysdiagramsRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (SysdiagramsTableControlRow[])(selectedList.ToArray(Type.GetType("KumePortali.UI.Controls.ShowSysdiagramsTablePage.SysdiagramsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            SysdiagramsTableControlRow[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
            }
            
            foreach (SysdiagramsTableControlRow recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.SysdiagramsRecordRowSelection.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public SysdiagramsTableControlRow[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("SysdiagramsTableControlRepeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                SysdiagramsTableControlRow recControl = (SysdiagramsTableControlRow)repItem.FindControl("SysdiagramsTableControlRow");
                recList.Add(recControl);
            }

            return (SysdiagramsTableControlRow[])recList.ToArray(Type.GetType("KumePortali.UI.Controls.ShowSysdiagramsTablePage.SysdiagramsTableControlRow"));
        }

        public new BaseApplicationPage Page {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

    #endregion

    

    }
  

#endregion
    
  
}

  