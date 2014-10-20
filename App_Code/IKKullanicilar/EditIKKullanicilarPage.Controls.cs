
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// EditIKKullanicilarPage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace KumePortali.UI.Controls.EditIKKullanicilarPage
{
  

#region "Section 1: Place your customizations here."

    
public class HaberlerTableControlRow : BaseHaberlerTableControlRow
{
      
        // The BaseHaberlerTableControlRow implements code for a ROW within the
        // the HaberlerTableControl table.  The BaseHaberlerTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of HaberlerTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class HaberlerTableControl : BaseHaberlerTableControl
{
        // The BaseHaberlerTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The HaberlerTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class HaberlerTableControl1Row : BaseHaberlerTableControl1Row
{
      
        // The BaseHaberlerTableControl1Row implements code for a ROW within the
        // the HaberlerTableControl1 table.  The BaseHaberlerTableControl1Row implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of HaberlerTableControl1.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class HaberlerTableControl1 : BaseHaberlerTableControl1
{
        // The BaseHaberlerTableControl1 class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The HaberlerTableControl1Row class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class IKKullanicilarRecordControl : BaseIKKullanicilarRecordControl
{
      
        // The BaseIKKullanicilarRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the HaberlerTableControlRow control on the EditIKKullanicilarPage page.
// Do not modify this class. Instead override any method in HaberlerTableControlRow.
public class BaseHaberlerTableControlRow : KumePortali.UI.BaseApplicationRecordControl
{
        public BaseHaberlerTableControlRow()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in HaberlerTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            
      
      
            // Register the event handlers.
        
              this.HaberlerRowViewButton.Click += new ImageClickEventHandler(HaberlerRowViewButton_Click);
              this.HaberlerRowEditButton.Click += new ImageClickEventHandler(HaberlerRowEditButton_Click);
              this.HaberlerRowDeleteButton.Click += new ImageClickEventHandler(HaberlerRowDeleteButton_Click);
                this.DuzenleyenID1AddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.DuzenleyenID1.UniqueID + "&DFKA=Adi";
                this.DuzenleyenID1AddRecordLink.Attributes["onClick"] = "window.open('" + this.DuzenleyenID1AddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.DuzenleyenID1AddRecordLink.Click += new ImageClickEventHandler(DuzenleyenID1AddRecordLink_Click);
              this.DuzenleyenID1.SelectedIndexChanged += new EventHandler(DuzenleyenID1_SelectedIndexChanged);
            
        }

        // To customize, override this method in HaberlerTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.HaberlerRowDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "KumePortali") + "'));");
        }

        // Read data from database. To customize, override this method in HaberlerTableControlRow.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = HaberlerTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseHaberlerTableControl when the data for the entire
            // table is loaded.
            this.DataSource = new HaberlerRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in HaberlerTableControlRow.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.HaberBaslikSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberBaslik);
                this.HaberBaslik.Text = formattedValue;
              
               
            } else {  
                this.HaberBaslik.Text = HaberlerTable.HaberBaslik.Format(HaberlerTable.HaberBaslik.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberBaslikENSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberBaslikEN);
                this.HaberBaslikEN.Text = formattedValue;
              
               
            } else {  
                this.HaberBaslikEN.Text = HaberlerTable.HaberBaslikEN.Format(HaberlerTable.HaberBaslikEN.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberOnYaziSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberOnYazi);
                this.HaberOnYazi.Text = formattedValue;
              
               
            } else {  
                this.HaberOnYazi.Text = HaberlerTable.HaberOnYazi.Format(HaberlerTable.HaberOnYazi.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberOnYaziENSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberOnYaziEN);
                this.HaberOnYaziEN.Text = formattedValue;
              
               
            } else {  
                this.HaberOnYaziEN.Text = HaberlerTable.HaberOnYaziEN.Format(HaberlerTable.HaberOnYaziEN.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberIcerikSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberIcerik);
                this.HaberIcerik.Value = formattedValue;
                this.HaberIcerik.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
              
               
            } else {  
                this.HaberIcerik.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
                this.HaberIcerik.Value = HaberlerTable.HaberIcerik.Format(HaberlerTable.HaberIcerik.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberIcerikENSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberIcerikEN);
                this.HaberIcerikEN.Value = formattedValue;
                this.HaberIcerikEN.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
              
               
            } else {  
                this.HaberIcerikEN.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
                this.HaberIcerikEN.Value = HaberlerTable.HaberIcerikEN.Format(HaberlerTable.HaberIcerikEN.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberAktifSpecified) {
                this.HaberAktif.Checked = this.DataSource.HaberAktif;
            } else {
                if (!this.DataSource.IsCreated) {
                    this.HaberAktif.Checked = HaberlerTable.HaberAktif.ParseValue(HaberlerTable.HaberAktif.DefaultValue).ToBoolean();
                }
            }
                    
            if (this.DataSource.YetkiIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.YetkiID);
                this.YetkiID.Text = formattedValue;
              
               
            } else {  
                this.YetkiID.Text = HaberlerTable.YetkiID.Format(HaberlerTable.YetkiID.DefaultValue);
                            
            }
                    
            this.OlusturmaTarihi1.Attributes.Add("onfocus", "toggleEnableDisableDateFormatter(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
            this.OlusturmaTarihi1.Attributes.Add("onblur", "presubmitDateValidation(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
                    
            if (this.DataSource.OlusturmaTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.OlusturmaTarihi);
                this.OlusturmaTarihi1.Text = formattedValue;
              
               
            } else {  
                this.OlusturmaTarihi1.Text = HaberlerTable.OlusturmaTarihi.Format(HaberlerTable.OlusturmaTarihi.DefaultValue);
                            
            }
                    
            this.DuzenlenmeTarihi1.Attributes.Add("onfocus", "toggleEnableDisableDateFormatter(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
            this.DuzenlenmeTarihi1.Attributes.Add("onblur", "presubmitDateValidation(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
                    
            if (this.DataSource.DuzenlenmeTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.DuzenlenmeTarihi);
                this.DuzenlenmeTarihi1.Text = formattedValue;
              
               
            } else {  
                this.DuzenlenmeTarihi1.Text = HaberlerTable.DuzenlenmeTarihi.Format(HaberlerTable.DuzenlenmeTarihi.DefaultValue);
                            
            }
                    
            if (this.DataSource.DuzenleyenIDSpecified) {
                this.PopulateDuzenleyenID1DropDownList(this.DataSource.DuzenleyenID.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateDuzenleyenID1DropDownList(HaberlerTable.DuzenleyenID.DefaultValue, 100);
                } else {
                this.PopulateDuzenleyenID1DropDownList(null, 100);
                }
            }
                
            if (this.DataSource.AktifPasifSpecified) {
                this.AktifPasif1.Checked = this.DataSource.AktifPasif;
            } else {
                if (!this.DataSource.IsCreated) {
                    this.AktifPasif1.Checked = HaberlerTable.AktifPasif.ParseValue(HaberlerTable.AktifPasif.DefaultValue).ToBoolean();
                }
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
        
        

        //  To customize, override this method in HaberlerTableControlRow.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // IKKullanicilar in IKKullanicilarRecordControl is One To Many to HaberlerTableControl.
                    
            // Setup the parent id in the record.
            IKKullanicilarRecordControl recIKKullanicilarRecordControl = (IKKullanicilarRecordControl)this.Page.FindControlRecursively("IKKullanicilarRecordControl");
            if (recIKKullanicilarRecordControl != null && recIKKullanicilarRecordControl.DataSource == null) {
                // Load the record if it is not loaded yet.
                recIKKullanicilarRecordControl.LoadData();
            }
            if (recIKKullanicilarRecordControl == null || recIKKullanicilarRecordControl.DataSource == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "KumePortali"));
            }
                    
            this.DataSource.OlusturanID = recIKKullanicilarRecordControl.DataSource.KullaniciID;
            
            // 2. Validate the data.  Override in HaberlerTableControlRow to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in HaberlerTableControlRow to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((HaberlerTableControl)MiscUtils.GetParentControlObject(this, "HaberlerTableControl")).DataChanged = true;
                ((HaberlerTableControl)MiscUtils.GetParentControlObject(this, "HaberlerTableControl")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in HaberlerTableControlRow.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(this.HaberBaslik.Text, HaberlerTable.HaberBaslik);
              
            this.DataSource.Parse(this.HaberBaslikEN.Text, HaberlerTable.HaberBaslikEN);
              
            this.DataSource.Parse(this.HaberOnYazi.Text, HaberlerTable.HaberOnYazi);
              
            this.DataSource.Parse(this.HaberOnYaziEN.Text, HaberlerTable.HaberOnYaziEN);
              
                this.DataSource.Parse(this.HaberIcerik.Value, HaberlerTable.HaberIcerik);
              
                this.DataSource.Parse(this.HaberIcerikEN.Value, HaberlerTable.HaberIcerikEN);
              
            this.DataSource.HaberAktif = this.HaberAktif.Checked;
                    
            this.DataSource.Parse(this.YetkiID.Text, HaberlerTable.YetkiID);
              
            this.DataSource.Parse(this.OlusturmaTarihi1.Text, HaberlerTable.OlusturmaTarihi);
              
            this.DataSource.Parse(this.DuzenlenmeTarihi1.Text, HaberlerTable.DuzenlenmeTarihi);
              
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.DuzenleyenID1), HaberlerTable.DuzenleyenID);
                  
            this.DataSource.AktifPasif = this.AktifPasif1.Checked;
                    
      }

      

        //  To customize, override this method in HaberlerTableControlRow.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        
        

        //  To customize, override this method in HaberlerTableControlRow.
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
            HaberlerTable.DeleteRecord(pk);

          
            ((HaberlerTableControl)MiscUtils.GetParentControlObject(this, "HaberlerTableControl")).DataChanged = true;
            ((HaberlerTableControl)MiscUtils.GetParentControlObject(this, "HaberlerTableControl")).ResetData = true;
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

        
        public virtual WhereClause CreateWhereClause_DuzenleyenID1DropDownList() {
            return new WhereClause();
        }
                
        // Fill the DuzenleyenID1 list.
        protected virtual void PopulateDuzenleyenID1DropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_DuzenleyenID1DropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(IKKullanicilarTable.Adi, OrderByItem.OrderDir.Asc);

                      this.DuzenleyenID1.Items.Clear();
            foreach (IKKullanicilarRecord itemValue in IKKullanicilarTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.KullaniciIDSpecified) {
                    cvalue = itemValue.KullaniciID.ToString();
                    fvalue = itemValue.Format(IKKullanicilarTable.Adi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.DuzenleyenID1.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.DuzenleyenID1, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.DuzenleyenID1, HaberlerTable.DuzenleyenID.Format(selectedValue))) {
                string fvalue = HaberlerTable.DuzenleyenID.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.DuzenleyenID1.Items.Insert(0, item);
            }

                  
            this.DuzenleyenID1.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "KumePortali"), "--PLEASE_SELECT--"));
                  
        }
                
        // event handler for ImageButton
        public virtual void HaberlerRowViewButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../Haberler/ShowHaberlerPage.aspx?Haberler={PK}";
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
        public virtual void HaberlerRowEditButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../Haberler/EditHaberlerPage.aspx?Haberler={PK}";
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
        public virtual void HaberlerRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        HaberlerTableControl tc= ((HaberlerTableControl)MiscUtils.GetParentControlObject(this, "HaberlerTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((HaberlerTableControlRow)this);
                    }
					this.Visible = false;
                }
              
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
        public virtual void DuzenleyenID1AddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKKullanicilar/AddIKKullanicilarPage.aspx";
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
            
              protected virtual void DuzenleyenID1_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.DuzenleyenID1);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.DuzenleyenID1, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.DuzenleyenID1, HaberlerTable.DuzenleyenID.Format(selectedValue))) {
              string fvalue = HaberlerTable.DuzenleyenID.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.DuzenleyenID1.Items.Insert(0, item);
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
                return (string)this.ViewState["BaseHaberlerTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseHaberlerTableControlRow_Rec"] = value;
            }
        }
        
        private HaberlerRecord _DataSource;
        public HaberlerRecord DataSource {
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
        
        public System.Web.UI.WebControls.ImageButton HaberlerRowViewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRowViewButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerRowEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRowEditButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox HaberlerRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRecordRowSelection");
            }
        }
        
        public System.Web.UI.WebControls.TextBox HaberBaslik {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslik");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HaberBaslikEN {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslikEN");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HaberOnYazi {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYazi");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HaberOnYaziEN {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYaziEN");
            }
        }
            
           public FredCK.FCKeditorV2.FCKeditor HaberIcerik {
              get {
                 return (FredCK.FCKeditorV2.FCKeditor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerik");
              }
           }
            
           public FredCK.FCKeditorV2.FCKeditor HaberIcerikEN {
              get {
                 return (FredCK.FCKeditorV2.FCKeditor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerikEN");
              }
           }
            
        public System.Web.UI.WebControls.CheckBox HaberAktif {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberAktif");
            }
        }
            
        public System.Web.UI.WebControls.TextBox YetkiID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiID");
            }
        }
            
        public System.Web.UI.WebControls.TextBox OlusturmaTarihi1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihi1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox DuzenlenmeTarihi1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihi1");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList DuzenleyenID1 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenID1");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton DuzenleyenID1AddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenID1AddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox AktifPasif1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasif1");
            }
        }
            
#endregion

#region "Helper Functions"
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            HaberlerRecord rec = null;
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

        public HaberlerRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return HaberlerTable.GetRecord(this.RecordUniqueId, true);
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

  
// Base class for the HaberlerTableControl control on the EditIKKullanicilarPage page.
// Do not modify this class. Instead override any method in HaberlerTableControl.
public class BaseHaberlerTableControl : KumePortali.UI.BaseApplicationTableControl
{
        public BaseHaberlerTableControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.HaberlerPagination.FirstPage.Click += new ImageClickEventHandler(HaberlerPagination_FirstPage_Click);
              this.HaberlerPagination.LastPage.Click += new ImageClickEventHandler(HaberlerPagination_LastPage_Click);
              this.HaberlerPagination.NextPage.Click += new ImageClickEventHandler(HaberlerPagination_NextPage_Click);
              this.HaberlerPagination.PageSizeButton.Click += new EventHandler(HaberlerPagination_PageSizeButton_Click);
            
              this.HaberlerPagination.PreviousPage.Click += new ImageClickEventHandler(HaberlerPagination_PreviousPage_Click);

            // Setup the sorting events.
        
              this.HaberBaslikLabel1.Click += new EventHandler(HaberBaslikLabel1_Click);
            
              this.HaberBaslikENLabel.Click += new EventHandler(HaberBaslikENLabel_Click);
            
              this.HaberOnYaziLabel.Click += new EventHandler(HaberOnYaziLabel_Click);
            
              this.HaberOnYaziENLabel.Click += new EventHandler(HaberOnYaziENLabel_Click);
            
              this.HaberAktifLabel.Click += new EventHandler(HaberAktifLabel_Click);
            
              this.YetkiIDLabel.Click += new EventHandler(YetkiIDLabel_Click);
            
              this.OlusturmaTarihiLabel1.Click += new EventHandler(OlusturmaTarihiLabel1_Click);
            
              this.DuzenlenmeTarihiLabel1.Click += new EventHandler(DuzenlenmeTarihiLabel1_Click);
            
              this.DuzenleyenIDLabel2.Click += new EventHandler(DuzenleyenIDLabel2_Click);
            
              this.AktifPasifLabel1.Click += new EventHandler(AktifPasifLabel1_Click);
            

            // Setup the button events.
        
              this.HaberlerAddButton.Click += new ImageClickEventHandler(HaberlerAddButton_Click);
              this.HaberlerDeleteButton.Click += new ImageClickEventHandler(HaberlerDeleteButton_Click);
              this.HaberlerRefreshButton.Click += new ImageClickEventHandler(HaberlerRefreshButton_Click);
              this.HaberlerResetButton.Click += new ImageClickEventHandler(HaberlerResetButton_Click);

            // Setup the filter and search events.
        

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
                this.HaberlerDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "KumePortali") + "'));");
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
                    this.DataSource = (HaberlerRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
                    // Add records to the list if needed.
                    this.AddNewRecords();
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = HaberlerTable.GetRecordCount(wc);

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
                    this.DataSource = (HaberlerRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (HaberlerTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (HaberlerRecord[])(postdata.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = HaberlerTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
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
        
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();

            // Setup the pagination controls.
            BindPaginationControls();

            // Populate all filters data.
        

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("HaberlerTableControlRepeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                HaberlerTableControlRow recControl = (HaberlerTableControlRow)(repItem.FindControl("HaberlerTableControlRow"));
                recControl.DataSource = this.DataSource[index];
                recControl.DataBind();
                recControl.Visible = !this.InDeletedRecordIds(recControl);
                index += 1;
            }
        }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(HaberlerTable.DuzenleyenID, this.DataSource);
        }
         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for HaberlerTableControl pagination.
        
            this.HaberlerPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            this.HaberlerPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.HaberlerPagination.LastPage.Enabled = false;
            }
          
            this.HaberlerPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.HaberlerPagination.NextPage.Enabled = false;
            }
          
            this.HaberlerPagination.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.HaberlerPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.HaberlerPagination.CurrentPage.Text = "0";
            }
            this.HaberlerPagination.PageSize.Text = this.PageSize.ToString();
            this.HaberlerTotalItems.Text = this.TotalRecords.ToString();
            this.HaberlerPagination.TotalItems.Text = this.TotalRecords.ToString();
            this.HaberlerPagination.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (HaberlerTableControlRow recCtl in this.GetRecordControls())
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
            HaberlerTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        IKKullanicilarRecordControl parentRecordControl = (IKKullanicilarRecordControl)(this.Page.FindControlRecursively("IKKullanicilarRecordControl"));
            IKKullanicilarRecord parentRec = parentRecordControl.GetRecord();
            if (parentRec == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:ParentNotInitialized", "KumePortali"));
            }
           
            if (parentRec.KullaniciIDSpecified) {
                wc.iAND(HaberlerTable.OlusturanID, BaseFilter.ComparisonOperator.EqualsTo, parentRec.KullaniciID.ToString());
            } else {
                wc.RunQuery = false;
                return wc;
            }
            
            return (wc);
        }
        
         
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            HaberlerTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelatvieVirtualPath"];
          
            String recId  = (String)HttpContext.Current.Session["SelectedID"];
            if (recId != null) {
                if (KeyValue.IsXmlKey(recId)) {
                    KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                    wc.iAND(HaberlerTable.OlusturanID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(IKKullanicilarTable.KullaniciID).ToString());
                
                } else {
                
                    wc.iAND(HaberlerTable.OlusturanID, BaseFilter.ComparisonOperator.EqualsTo, recId);
              
                }
            }
              
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            return wc;
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
        
            if (this.HaberlerPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.HaberlerPagination.PageSize.Text);
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
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("HaberlerTableControlRepeater"));

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    HaberlerTableControlRow recControl = (HaberlerTableControlRow)(repItem.FindControl("HaberlerTableControlRow"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        HaberlerRecord rec = new HaberlerRecord();
        
                        if (recControl.HaberBaslik.Text != "") {
                            rec.Parse(recControl.HaberBaslik.Text, HaberlerTable.HaberBaslik);
                  }
                
                        if (recControl.HaberBaslikEN.Text != "") {
                            rec.Parse(recControl.HaberBaslikEN.Text, HaberlerTable.HaberBaslikEN);
                  }
                
                        if (recControl.HaberOnYazi.Text != "") {
                            rec.Parse(recControl.HaberOnYazi.Text, HaberlerTable.HaberOnYazi);
                  }
                
                        if (recControl.HaberOnYaziEN.Text != "") {
                            rec.Parse(recControl.HaberOnYaziEN.Text, HaberlerTable.HaberOnYaziEN);
                  }
                
                  if (recControl.HaberIcerik.Value != "") {
                  rec.Parse(recControl.HaberIcerik.Value, HaberlerTable.HaberIcerik);
                  }
                
                  if (recControl.HaberIcerikEN.Value != "") {
                  rec.Parse(recControl.HaberIcerikEN.Value, HaberlerTable.HaberIcerikEN);
                  }
                
                        rec.HaberAktif = recControl.HaberAktif.Checked;
                
                        if (recControl.YetkiID.Text != "") {
                            rec.Parse(recControl.YetkiID.Text, HaberlerTable.YetkiID);
                  }
                
                        if (recControl.OlusturmaTarihi1.Text != "") {
                            rec.Parse(recControl.OlusturmaTarihi1.Text, HaberlerTable.OlusturmaTarihi);
                  }
                
                        if (recControl.DuzenlenmeTarihi1.Text != "") {
                            rec.Parse(recControl.DuzenlenmeTarihi1.Text, HaberlerTable.DuzenlenmeTarihi);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.DuzenleyenID1)) {
                            rec.Parse(recControl.DuzenleyenID1.SelectedItem.Value, HaberlerTable.DuzenleyenID);
                        }
                        rec.AktifPasif = recControl.AktifPasif1.Checked;
                
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new HaberlerRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (HaberlerRecord[])(finalList.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(HaberlerTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(HaberlerTableControlRow rec)            
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
          
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["HaberlerTableControl_OrderBy"];
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
                this.ViewState["HaberlerTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void HaberlerPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberlerPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberlerPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberlerPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
        
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.HaberlerPagination.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.HaberlerPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void HaberlerPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberBaslikLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberBaslik);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberBaslik, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberBaslikENLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberBaslikEN);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberBaslikEN, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberOnYaziLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberOnYazi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberOnYazi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberOnYaziENLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberOnYaziEN);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberOnYaziEN, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberAktifLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberAktif);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberAktif, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void YetkiIDLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.YetkiID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.YetkiID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void OlusturmaTarihiLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.OlusturmaTarihi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.OlusturmaTarihi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void DuzenlenmeTarihiLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.DuzenlenmeTarihi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.DuzenlenmeTarihi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void DuzenleyenIDLabel2_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.DuzenleyenID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.DuzenleyenID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void AktifPasifLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.AktifPasif);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.AktifPasif, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void HaberlerAddButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
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
        public virtual void HaberlerDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
          
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
        public virtual void HaberlerRefreshButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            ((IKKullanicilarRecordControl)(this.Page.FindControlRecursively("IKKullanicilarRecordControl"))).ResetData = true;
                
            ((HaberlerTableControl)(this.Page.FindControlRecursively("HaberlerTableControl"))).ResetData = true;
                
            ((HaberlerTableControl1)(this.Page.FindControlRecursively("HaberlerTableControl1"))).ResetData = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void HaberlerResetButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
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
            

        // Generate the event handling functions for filter and search events.
        

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

        private HaberlerRecord[] _DataSource = null;
        public  HaberlerRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Label HaberlerTotalItems {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerTotalItems");
            }
        }
        
        public KumePortali.UI.IPagination HaberlerPagination {
            get {
                return (KumePortali.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerAddButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerRefreshButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRefreshButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerResetButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox HaberlerToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerToggleAll");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberBaslikLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslikLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberBaslikENLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslikENLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberOnYaziLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYaziLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberOnYaziENLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYaziENLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal HaberIcerikLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerikLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal HaberIcerikENLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerikENLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberAktifLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberAktifLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton YetkiIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OlusturmaTarihiLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihiLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DuzenlenmeTarihiLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihiLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DuzenleyenIDLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenIDLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AktifPasifLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasifLabel1");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                HaberlerTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
                }

                HaberlerRecord rec = null;
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
            foreach (HaberlerTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.HaberlerRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public HaberlerTableControlRow GetSelectedRecordControl()
        {
        HaberlerTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public HaberlerTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (HaberlerTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.HaberlerRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (HaberlerTableControlRow[])(selectedList.ToArray(Type.GetType("KumePortali.UI.Controls.EditIKKullanicilarPage.HaberlerTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            HaberlerTableControlRow[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
            }
            
            foreach (HaberlerTableControlRow recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.HaberlerRecordRowSelection.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public HaberlerTableControlRow[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("HaberlerTableControlRepeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                HaberlerTableControlRow recControl = (HaberlerTableControlRow)repItem.FindControl("HaberlerTableControlRow");
                recList.Add(recControl);
            }

            return (HaberlerTableControlRow[])recList.ToArray(Type.GetType("KumePortali.UI.Controls.EditIKKullanicilarPage.HaberlerTableControlRow"));
        }

        public new BaseApplicationPage Page {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

    #endregion

    

    }
  
// Base class for the HaberlerTableControl1Row control on the EditIKKullanicilarPage page.
// Do not modify this class. Instead override any method in HaberlerTableControl1Row.
public class BaseHaberlerTableControl1Row : KumePortali.UI.BaseApplicationRecordControl
{
        public BaseHaberlerTableControl1Row()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in HaberlerTableControl1Row.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            
      
      
            // Register the event handlers.
        
              this.HaberlerRowViewButton1.Click += new ImageClickEventHandler(HaberlerRowViewButton1_Click);
              this.HaberlerRowEditButton1.Click += new ImageClickEventHandler(HaberlerRowEditButton1_Click);
              this.HaberlerRowDeleteButton1.Click += new ImageClickEventHandler(HaberlerRowDeleteButton1_Click);
                this.OlusturanID2AddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.OlusturanID2.UniqueID + "&DFKA=Adi";
                this.OlusturanID2AddRecordLink.Attributes["onClick"] = "window.open('" + this.OlusturanID2AddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.OlusturanID2AddRecordLink.Click += new ImageClickEventHandler(OlusturanID2AddRecordLink_Click);
              this.OlusturanID2.SelectedIndexChanged += new EventHandler(OlusturanID2_SelectedIndexChanged);
            
        }

        // To customize, override this method in HaberlerTableControl1Row.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.HaberlerRowDeleteButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "KumePortali") + "'));");
        }

        // Read data from database. To customize, override this method in HaberlerTableControl1Row.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = HaberlerTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseHaberlerTableControl1 when the data for the entire
            // table is loaded.
            this.DataSource = new HaberlerRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in HaberlerTableControl1Row.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.HaberBaslikSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberBaslik);
                this.HaberBaslik1.Text = formattedValue;
              
               
            } else {  
                this.HaberBaslik1.Text = HaberlerTable.HaberBaslik.Format(HaberlerTable.HaberBaslik.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberBaslikENSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberBaslikEN);
                this.HaberBaslikEN1.Text = formattedValue;
              
               
            } else {  
                this.HaberBaslikEN1.Text = HaberlerTable.HaberBaslikEN.Format(HaberlerTable.HaberBaslikEN.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberOnYaziSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberOnYazi);
                this.HaberOnYazi1.Text = formattedValue;
              
               
            } else {  
                this.HaberOnYazi1.Text = HaberlerTable.HaberOnYazi.Format(HaberlerTable.HaberOnYazi.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberOnYaziENSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberOnYaziEN);
                this.HaberOnYaziEN1.Text = formattedValue;
              
               
            } else {  
                this.HaberOnYaziEN1.Text = HaberlerTable.HaberOnYaziEN.Format(HaberlerTable.HaberOnYaziEN.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberIcerikSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberIcerik);
                this.HaberIcerik1.Value = formattedValue;
                this.HaberIcerik1.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
              
               
            } else {  
                this.HaberIcerik1.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
                this.HaberIcerik1.Value = HaberlerTable.HaberIcerik.Format(HaberlerTable.HaberIcerik.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberIcerikENSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.HaberIcerikEN);
                this.HaberIcerikEN1.Value = formattedValue;
                this.HaberIcerikEN1.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
              
               
            } else {  
                this.HaberIcerikEN1.DefaultLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
                this.HaberIcerikEN1.Value = HaberlerTable.HaberIcerikEN.Format(HaberlerTable.HaberIcerikEN.DefaultValue);
                            
            }
                    
            if (this.DataSource.HaberAktifSpecified) {
                this.HaberAktif1.Checked = this.DataSource.HaberAktif;
            } else {
                if (!this.DataSource.IsCreated) {
                    this.HaberAktif1.Checked = HaberlerTable.HaberAktif.ParseValue(HaberlerTable.HaberAktif.DefaultValue).ToBoolean();
                }
            }
                    
            if (this.DataSource.YetkiIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.YetkiID);
                this.YetkiID1.Text = formattedValue;
              
               
            } else {  
                this.YetkiID1.Text = HaberlerTable.YetkiID.Format(HaberlerTable.YetkiID.DefaultValue);
                            
            }
                    
            this.OlusturmaTarihi2.Attributes.Add("onfocus", "toggleEnableDisableDateFormatter(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
            this.OlusturmaTarihi2.Attributes.Add("onblur", "presubmitDateValidation(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
                    
            if (this.DataSource.OlusturmaTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.OlusturmaTarihi);
                this.OlusturmaTarihi2.Text = formattedValue;
              
               
            } else {  
                this.OlusturmaTarihi2.Text = HaberlerTable.OlusturmaTarihi.Format(HaberlerTable.OlusturmaTarihi.DefaultValue);
                            
            }
                    
            if (this.DataSource.OlusturanIDSpecified) {
                this.PopulateOlusturanID2DropDownList(this.DataSource.OlusturanID.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateOlusturanID2DropDownList(HaberlerTable.OlusturanID.DefaultValue, 100);
                } else {
                this.PopulateOlusturanID2DropDownList(null, 100);
                }
            }
                
            this.DuzenlenmeTarihi2.Attributes.Add("onfocus", "toggleEnableDisableDateFormatter(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
            this.DuzenlenmeTarihi2.Attributes.Add("onblur", "presubmitDateValidation(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
                    
            if (this.DataSource.DuzenlenmeTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(HaberlerTable.DuzenlenmeTarihi);
                this.DuzenlenmeTarihi2.Text = formattedValue;
              
               
            } else {  
                this.DuzenlenmeTarihi2.Text = HaberlerTable.DuzenlenmeTarihi.Format(HaberlerTable.DuzenlenmeTarihi.DefaultValue);
                            
            }
                    
            if (this.DataSource.AktifPasifSpecified) {
                this.AktifPasif2.Checked = this.DataSource.AktifPasif;
            } else {
                if (!this.DataSource.IsCreated) {
                    this.AktifPasif2.Checked = HaberlerTable.AktifPasif.ParseValue(HaberlerTable.AktifPasif.DefaultValue).ToBoolean();
                }
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
        
        

        //  To customize, override this method in HaberlerTableControl1Row.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // IKKullanicilar in IKKullanicilarRecordControl is One To Many to HaberlerTableControl1.
                    
            // Setup the parent id in the record.
            IKKullanicilarRecordControl recIKKullanicilarRecordControl = (IKKullanicilarRecordControl)this.Page.FindControlRecursively("IKKullanicilarRecordControl");
            if (recIKKullanicilarRecordControl != null && recIKKullanicilarRecordControl.DataSource == null) {
                // Load the record if it is not loaded yet.
                recIKKullanicilarRecordControl.LoadData();
            }
            if (recIKKullanicilarRecordControl == null || recIKKullanicilarRecordControl.DataSource == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "KumePortali"));
            }
                    
            this.DataSource.DuzenleyenID = recIKKullanicilarRecordControl.DataSource.KullaniciID;
            
            // 2. Validate the data.  Override in HaberlerTableControl1Row to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in HaberlerTableControl1Row to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((HaberlerTableControl1)MiscUtils.GetParentControlObject(this, "HaberlerTableControl1")).DataChanged = true;
                ((HaberlerTableControl1)MiscUtils.GetParentControlObject(this, "HaberlerTableControl1")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in HaberlerTableControl1Row.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(this.HaberBaslik1.Text, HaberlerTable.HaberBaslik);
              
            this.DataSource.Parse(this.HaberBaslikEN1.Text, HaberlerTable.HaberBaslikEN);
              
            this.DataSource.Parse(this.HaberOnYazi1.Text, HaberlerTable.HaberOnYazi);
              
            this.DataSource.Parse(this.HaberOnYaziEN1.Text, HaberlerTable.HaberOnYaziEN);
              
                this.DataSource.Parse(this.HaberIcerik1.Value, HaberlerTable.HaberIcerik);
              
                this.DataSource.Parse(this.HaberIcerikEN1.Value, HaberlerTable.HaberIcerikEN);
              
            this.DataSource.HaberAktif = this.HaberAktif1.Checked;
                    
            this.DataSource.Parse(this.YetkiID1.Text, HaberlerTable.YetkiID);
              
            this.DataSource.Parse(this.OlusturmaTarihi2.Text, HaberlerTable.OlusturmaTarihi);
              
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.OlusturanID2), HaberlerTable.OlusturanID);
                  
            this.DataSource.Parse(this.DuzenlenmeTarihi2.Text, HaberlerTable.DuzenlenmeTarihi);
              
            this.DataSource.AktifPasif = this.AktifPasif2.Checked;
                    
      }

      

        //  To customize, override this method in HaberlerTableControl1Row.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        
        

        //  To customize, override this method in HaberlerTableControl1Row.
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
            HaberlerTable.DeleteRecord(pk);

          
            ((HaberlerTableControl1)MiscUtils.GetParentControlObject(this, "HaberlerTableControl1")).DataChanged = true;
            ((HaberlerTableControl1)MiscUtils.GetParentControlObject(this, "HaberlerTableControl1")).ResetData = true;
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

        
        public virtual WhereClause CreateWhereClause_OlusturanID2DropDownList() {
            return new WhereClause();
        }
                
        // Fill the OlusturanID2 list.
        protected virtual void PopulateOlusturanID2DropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_OlusturanID2DropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(IKKullanicilarTable.Adi, OrderByItem.OrderDir.Asc);

                      this.OlusturanID2.Items.Clear();
            foreach (IKKullanicilarRecord itemValue in IKKullanicilarTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.KullaniciIDSpecified) {
                    cvalue = itemValue.KullaniciID.ToString();
                    fvalue = itemValue.Format(IKKullanicilarTable.Adi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.OlusturanID2.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.OlusturanID2, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.OlusturanID2, HaberlerTable.OlusturanID.Format(selectedValue))) {
                string fvalue = HaberlerTable.OlusturanID.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.OlusturanID2.Items.Insert(0, item);
            }

                  
            this.OlusturanID2.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "KumePortali"), "--PLEASE_SELECT--"));
                  
        }
                
        // event handler for ImageButton
        public virtual void HaberlerRowViewButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../Haberler/ShowHaberlerPage.aspx?Haberler={PK}";
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
        public virtual void HaberlerRowEditButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../Haberler/EditHaberlerPage.aspx?Haberler={PK}";
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
        public virtual void HaberlerRowDeleteButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        HaberlerTableControl1 tc= ((HaberlerTableControl1)MiscUtils.GetParentControlObject(this, "HaberlerTableControl1"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((HaberlerTableControl1Row)this);
                    }
					this.Visible = false;
                }
              
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
        public virtual void OlusturanID2AddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKKullanicilar/AddIKKullanicilarPage.aspx";
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
            
              protected virtual void OlusturanID2_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.OlusturanID2);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.OlusturanID2, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.OlusturanID2, HaberlerTable.OlusturanID.Format(selectedValue))) {
              string fvalue = HaberlerTable.OlusturanID.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.OlusturanID2.Items.Insert(0, item);
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
                return (string)this.ViewState["BaseHaberlerTableControl1Row_Rec"];
            }
            set {
                this.ViewState["BaseHaberlerTableControl1Row_Rec"] = value;
            }
        }
        
        private HaberlerRecord _DataSource;
        public HaberlerRecord DataSource {
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
        
        public System.Web.UI.WebControls.ImageButton HaberlerRowViewButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRowViewButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerRowEditButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRowEditButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerRowDeleteButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRowDeleteButton1");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox HaberlerRecordRowSelection1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRecordRowSelection1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox HaberBaslik1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslik1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HaberBaslikEN1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslikEN1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HaberOnYazi1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYazi1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HaberOnYaziEN1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYaziEN1");
            }
        }
            
           public FredCK.FCKeditorV2.FCKeditor HaberIcerik1 {
              get {
                 return (FredCK.FCKeditorV2.FCKeditor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerik1");
              }
           }
            
           public FredCK.FCKeditorV2.FCKeditor HaberIcerikEN1 {
              get {
                 return (FredCK.FCKeditorV2.FCKeditor)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerikEN1");
              }
           }
            
        public System.Web.UI.WebControls.CheckBox HaberAktif1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberAktif1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox YetkiID1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiID1");
            }
        }
            
        public System.Web.UI.WebControls.TextBox OlusturmaTarihi2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihi2");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList OlusturanID2 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanID2");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton OlusturanID2AddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanID2AddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.TextBox DuzenlenmeTarihi2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihi2");
            }
        }
            
        public System.Web.UI.WebControls.CheckBox AktifPasif2 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasif2");
            }
        }
            
#endregion

#region "Helper Functions"
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            HaberlerRecord rec = null;
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

        public HaberlerRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return HaberlerTable.GetRecord(this.RecordUniqueId, true);
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

  
// Base class for the HaberlerTableControl1 control on the EditIKKullanicilarPage page.
// Do not modify this class. Instead override any method in HaberlerTableControl1.
public class BaseHaberlerTableControl1 : KumePortali.UI.BaseApplicationTableControl
{
        public BaseHaberlerTableControl1()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.HaberlerPagination1.FirstPage.Click += new ImageClickEventHandler(HaberlerPagination1_FirstPage_Click);
              this.HaberlerPagination1.LastPage.Click += new ImageClickEventHandler(HaberlerPagination1_LastPage_Click);
              this.HaberlerPagination1.NextPage.Click += new ImageClickEventHandler(HaberlerPagination1_NextPage_Click);
              this.HaberlerPagination1.PageSizeButton.Click += new EventHandler(HaberlerPagination1_PageSizeButton_Click);
            
              this.HaberlerPagination1.PreviousPage.Click += new ImageClickEventHandler(HaberlerPagination1_PreviousPage_Click);

            // Setup the sorting events.
        
              this.HaberBaslikLabel3.Click += new EventHandler(HaberBaslikLabel3_Click);
            
              this.HaberBaslikENLabel1.Click += new EventHandler(HaberBaslikENLabel1_Click);
            
              this.HaberOnYaziLabel1.Click += new EventHandler(HaberOnYaziLabel1_Click);
            
              this.HaberOnYaziENLabel1.Click += new EventHandler(HaberOnYaziENLabel1_Click);
            
              this.HaberAktifLabel1.Click += new EventHandler(HaberAktifLabel1_Click);
            
              this.YetkiIDLabel1.Click += new EventHandler(YetkiIDLabel1_Click);
            
              this.OlusturmaTarihiLabel2.Click += new EventHandler(OlusturmaTarihiLabel2_Click);
            
              this.OlusturanIDLabel3.Click += new EventHandler(OlusturanIDLabel3_Click);
            
              this.DuzenlenmeTarihiLabel2.Click += new EventHandler(DuzenlenmeTarihiLabel2_Click);
            
              this.AktifPasifLabel2.Click += new EventHandler(AktifPasifLabel2_Click);
            

            // Setup the button events.
        
              this.HaberlerAddButton1.Click += new ImageClickEventHandler(HaberlerAddButton1_Click);
              this.HaberlerDeleteButton1.Click += new ImageClickEventHandler(HaberlerDeleteButton1_Click);
              this.HaberlerRefreshButton1.Click += new ImageClickEventHandler(HaberlerRefreshButton1_Click);
              this.HaberlerResetButton1.Click += new ImageClickEventHandler(HaberlerResetButton1_Click);

            // Setup the filter and search events.
        

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
                this.HaberlerDeleteButton1.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "KumePortali") + "'));");
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
                    this.DataSource = (HaberlerRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
                    // Add records to the list if needed.
                    this.AddNewRecords();
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = HaberlerTable.GetRecordCount(wc);

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
                    this.DataSource = (HaberlerRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (HaberlerTableControl1Row rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (HaberlerRecord[])(postdata.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = HaberlerTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
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
        
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();

            // Setup the pagination controls.
            BindPaginationControls();

            // Populate all filters data.
        

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("HaberlerTableControl1Repeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                HaberlerTableControl1Row recControl = (HaberlerTableControl1Row)(repItem.FindControl("HaberlerTableControl1Row"));
                recControl.DataSource = this.DataSource[index];
                recControl.DataBind();
                recControl.Visible = !this.InDeletedRecordIds(recControl);
                index += 1;
            }
        }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(HaberlerTable.OlusturanID, this.DataSource);
        }
         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for HaberlerTableControl1 pagination.
        
            this.HaberlerPagination1.FirstPage.Enabled = !(this.PageIndex == 0);
            this.HaberlerPagination1.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.HaberlerPagination1.LastPage.Enabled = false;
            }
          
            this.HaberlerPagination1.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.HaberlerPagination1.NextPage.Enabled = false;
            }
          
            this.HaberlerPagination1.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.HaberlerPagination1.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.HaberlerPagination1.CurrentPage.Text = "0";
            }
            this.HaberlerPagination1.PageSize.Text = this.PageSize.ToString();
            this.HaberlerTotalItems1.Text = this.TotalRecords.ToString();
            this.HaberlerPagination1.TotalItems.Text = this.TotalRecords.ToString();
            this.HaberlerPagination1.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (HaberlerTableControl1Row recCtl in this.GetRecordControls())
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
            HaberlerTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        IKKullanicilarRecordControl parentRecordControl = (IKKullanicilarRecordControl)(this.Page.FindControlRecursively("IKKullanicilarRecordControl"));
            IKKullanicilarRecord parentRec = parentRecordControl.GetRecord();
            if (parentRec == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:ParentNotInitialized", "KumePortali"));
            }
           
            if (parentRec.KullaniciIDSpecified) {
                wc.iAND(HaberlerTable.DuzenleyenID, BaseFilter.ComparisonOperator.EqualsTo, parentRec.KullaniciID.ToString());
            } else {
                wc.RunQuery = false;
                return wc;
            }
            
            return (wc);
        }
        
         
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            HaberlerTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelatvieVirtualPath"];
          
            String recId  = (String)HttpContext.Current.Session["SelectedID"];
            if (recId != null) {
                if (KeyValue.IsXmlKey(recId)) {
                    KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                    wc.iAND(HaberlerTable.DuzenleyenID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(IKKullanicilarTable.KullaniciID).ToString());
                
                } else {
                
                    wc.iAND(HaberlerTable.DuzenleyenID, BaseFilter.ComparisonOperator.EqualsTo, recId);
              
                }
            }
              
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            return wc;
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
        
            if (this.HaberlerPagination1.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.HaberlerPagination1.PageSize.Text);
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
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("HaberlerTableControl1Repeater"));

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    HaberlerTableControl1Row recControl = (HaberlerTableControl1Row)(repItem.FindControl("HaberlerTableControl1Row"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        HaberlerRecord rec = new HaberlerRecord();
        
                        if (recControl.HaberBaslik1.Text != "") {
                            rec.Parse(recControl.HaberBaslik1.Text, HaberlerTable.HaberBaslik);
                  }
                
                        if (recControl.HaberBaslikEN1.Text != "") {
                            rec.Parse(recControl.HaberBaslikEN1.Text, HaberlerTable.HaberBaslikEN);
                  }
                
                        if (recControl.HaberOnYazi1.Text != "") {
                            rec.Parse(recControl.HaberOnYazi1.Text, HaberlerTable.HaberOnYazi);
                  }
                
                        if (recControl.HaberOnYaziEN1.Text != "") {
                            rec.Parse(recControl.HaberOnYaziEN1.Text, HaberlerTable.HaberOnYaziEN);
                  }
                
                  if (recControl.HaberIcerik1.Value != "") {
                  rec.Parse(recControl.HaberIcerik1.Value, HaberlerTable.HaberIcerik);
                  }
                
                  if (recControl.HaberIcerikEN1.Value != "") {
                  rec.Parse(recControl.HaberIcerikEN1.Value, HaberlerTable.HaberIcerikEN);
                  }
                
                        rec.HaberAktif = recControl.HaberAktif1.Checked;
                
                        if (recControl.YetkiID1.Text != "") {
                            rec.Parse(recControl.YetkiID1.Text, HaberlerTable.YetkiID);
                  }
                
                        if (recControl.OlusturmaTarihi2.Text != "") {
                            rec.Parse(recControl.OlusturmaTarihi2.Text, HaberlerTable.OlusturmaTarihi);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.OlusturanID2)) {
                            rec.Parse(recControl.OlusturanID2.SelectedItem.Value, HaberlerTable.OlusturanID);
                        }
                        if (recControl.DuzenlenmeTarihi2.Text != "") {
                            rec.Parse(recControl.DuzenlenmeTarihi2.Text, HaberlerTable.DuzenlenmeTarihi);
                  }
                
                        rec.AktifPasif = recControl.AktifPasif2.Checked;
                
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new HaberlerRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (HaberlerRecord[])(finalList.ToArray(Type.GetType("KumePortali.Business.HaberlerRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(HaberlerTableControl1Row rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(HaberlerTableControl1Row rec)            
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
          
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["HaberlerTableControl1_OrderBy"];
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
                this.ViewState["HaberlerTableControl1_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void HaberlerPagination1_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberlerPagination1_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberlerPagination1_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberlerPagination1_PageSizeButton_Click(object sender, EventArgs args)
        {
        
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.HaberlerPagination1.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.HaberlerPagination1.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void HaberlerPagination1_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void HaberBaslikLabel3_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberBaslik);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberBaslik, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberBaslikENLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberBaslikEN);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberBaslikEN, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberOnYaziLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberOnYazi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberOnYazi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberOnYaziENLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberOnYaziEN);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberOnYaziEN, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HaberAktifLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.HaberAktif);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.HaberAktif, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void YetkiIDLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.YetkiID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.YetkiID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void OlusturmaTarihiLabel2_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.OlusturmaTarihi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.OlusturmaTarihi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void OlusturanIDLabel3_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.OlusturanID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.OlusturanID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void DuzenlenmeTarihiLabel2_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.DuzenlenmeTarihi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.DuzenlenmeTarihi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void AktifPasifLabel2_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(HaberlerTable.AktifPasif);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(HaberlerTable.AktifPasif, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void HaberlerAddButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
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
        public virtual void HaberlerDeleteButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
          
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
        public virtual void HaberlerRefreshButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            ((IKKullanicilarRecordControl)(this.Page.FindControlRecursively("IKKullanicilarRecordControl"))).ResetData = true;
                
            ((HaberlerTableControl)(this.Page.FindControlRecursively("HaberlerTableControl"))).ResetData = true;
                
            ((HaberlerTableControl1)(this.Page.FindControlRecursively("HaberlerTableControl1"))).ResetData = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void HaberlerResetButton1_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
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
            

        // Generate the event handling functions for filter and search events.
        

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

        private HaberlerRecord[] _DataSource = null;
        public  HaberlerRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Label HaberlerTotalItems1 {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerTotalItems1");
            }
        }
        
        public KumePortali.UI.IPagination HaberlerPagination1 {
            get {
                return (KumePortali.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerPagination1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerAddButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerAddButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerDeleteButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerDeleteButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerRefreshButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerRefreshButton1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton HaberlerResetButton1 {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerResetButton1");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox HaberlerToggleAll1 {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberlerToggleAll1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberBaslikLabel3 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslikLabel3");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberBaslikENLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberBaslikENLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberOnYaziLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYaziLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberOnYaziENLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberOnYaziENLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal HaberIcerikLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerikLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal HaberIcerikENLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberIcerikENLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HaberAktifLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HaberAktifLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton YetkiIDLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiIDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OlusturmaTarihiLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihiLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OlusturanIDLabel3 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanIDLabel3");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DuzenlenmeTarihiLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihiLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AktifPasifLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasifLabel2");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                HaberlerTableControl1Row recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
                }

                HaberlerRecord rec = null;
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
            foreach (HaberlerTableControl1Row recControl in this.GetRecordControls())
            {
                if (recControl.HaberlerRecordRowSelection1.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public HaberlerTableControl1Row GetSelectedRecordControl()
        {
        HaberlerTableControl1Row[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public HaberlerTableControl1Row[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (HaberlerTableControl1Row recControl in this.GetRecordControls())
            {
                if (recControl.HaberlerRecordRowSelection1.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (HaberlerTableControl1Row[])(selectedList.ToArray(Type.GetType("KumePortali.UI.Controls.EditIKKullanicilarPage.HaberlerTableControl1Row")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            HaberlerTableControl1Row[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
            }
            
            foreach (HaberlerTableControl1Row recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.HaberlerRecordRowSelection1.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public HaberlerTableControl1Row[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("HaberlerTableControl1Repeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                HaberlerTableControl1Row recControl = (HaberlerTableControl1Row)repItem.FindControl("HaberlerTableControl1Row");
                recList.Add(recControl);
            }

            return (HaberlerTableControl1Row[])recList.ToArray(Type.GetType("KumePortali.UI.Controls.EditIKKullanicilarPage.HaberlerTableControl1Row"));
        }

        public new BaseApplicationPage Page {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

    #endregion

    

    }
  
// Base class for the IKKullanicilarRecordControl control on the EditIKKullanicilarPage page.
// Do not modify this class. Instead override any method in IKKullanicilarRecordControl.
public class BaseIKKullanicilarRecordControl : KumePortali.UI.BaseApplicationRecordControl
{
        public BaseIKKullanicilarRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in IKKullanicilarRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            
      
          // Setup the pagination events.
        
          
        // Setup the filter and search events.
        
      
            // Register the event handlers.
        
                this.FirmaIDAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.FirmaID.UniqueID + "&DFKA=FirmaAdi";
                this.FirmaIDAddRecordLink.Attributes["onClick"] = "window.open('" + this.FirmaIDAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.FirmaIDAddRecordLink.Click += new ImageClickEventHandler(FirmaIDAddRecordLink_Click);
                this.UnvanIDAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.UnvanID.UniqueID + "&DFKA=UnvanAdi";
                this.UnvanIDAddRecordLink.Attributes["onClick"] = "window.open('" + this.UnvanIDAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.UnvanIDAddRecordLink.Click += new ImageClickEventHandler(UnvanIDAddRecordLink_Click);
                this.OlusturanIDAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.OlusturanID.UniqueID + "&DFKA=Adi";
                this.OlusturanIDAddRecordLink.Attributes["onClick"] = "window.open('" + this.OlusturanIDAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.OlusturanIDAddRecordLink.Click += new ImageClickEventHandler(OlusturanIDAddRecordLink_Click);
                this.DuzenleyenIDAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.DuzenleyenID.UniqueID + "&DFKA=Adi";
                this.DuzenleyenIDAddRecordLink.Attributes["onClick"] = "window.open('" + this.DuzenleyenIDAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.DuzenleyenIDAddRecordLink.Click += new ImageClickEventHandler(DuzenleyenIDAddRecordLink_Click);
              this.FirmaID.SelectedIndexChanged += new EventHandler(FirmaID_SelectedIndexChanged);
            
              this.UnvanID.SelectedIndexChanged += new EventHandler(UnvanID_SelectedIndexChanged);
            
              this.OlusturanID.SelectedIndexChanged += new EventHandler(OlusturanID_SelectedIndexChanged);
            
              this.DuzenleyenID.SelectedIndexChanged += new EventHandler(DuzenleyenID_SelectedIndexChanged);
            
        }

        // To customize, override this method in IKKullanicilarRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
        }

        // Read data from database. To customize, override this method in IKKullanicilarRecordControl.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = IKKullanicilarTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            WhereClause wc = this.CreateWhereClause();
            
            if (wc == null || !(wc.RunQuery)) {
              this.DataSource = new IKKullanicilarRecord();
              
              return;
            }
                        
          

            // Retrieve the record from the database.
            IKKullanicilarRecord[] recList = IKKullanicilarTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                throw new Exception(Page.GetResourceValue("Err:NoRecRetrieved", "KumePortali"));
            }
              
            this.DataSource = IKKullanicilarTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        // Populate the UI controls using the DataSource. To customize, override this method in IKKullanicilarRecordControl.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.AdiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.Adi);
                this.Adi.Text = formattedValue;
              
               
            } else {  
                this.Adi.Text = IKKullanicilarTable.Adi.Format(IKKullanicilarTable.Adi.DefaultValue);
                            
            }
                    
            if (this.DataSource.SoyadiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.Soyadi);
                this.Soyadi.Text = formattedValue;
              
               
            } else {  
                this.Soyadi.Text = IKKullanicilarTable.Soyadi.Format(IKKullanicilarTable.Soyadi.DefaultValue);
                            
            }
                    
            if (this.DataSource.EpostaSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.Eposta);
                this.Eposta.Text = formattedValue;
              
               
            } else {  
                this.Eposta.Text = IKKullanicilarTable.Eposta.Format(IKKullanicilarTable.Eposta.DefaultValue);
                            
            }
                    
            if (this.DataSource.GSMSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.GSM);
                this.GSM.Text = formattedValue;
              
               
            } else {  
                this.GSM.Text = IKKullanicilarTable.GSM.Format(IKKullanicilarTable.GSM.DefaultValue);
                            
            }
                    
            if (this.DataSource.FirmaIDSpecified) {
                this.PopulateFirmaIDDropDownList(this.DataSource.FirmaID.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateFirmaIDDropDownList(IKKullanicilarTable.FirmaID.DefaultValue, 100);
                } else {
                this.PopulateFirmaIDDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.UnvanIDSpecified) {
                this.PopulateUnvanIDDropDownList(this.DataSource.UnvanID.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateUnvanIDDropDownList(IKKullanicilarTable.UnvanID.DefaultValue, 100);
                } else {
                this.PopulateUnvanIDDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.YetkiTurIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.YetkiTurID);
                this.YetkiTurID.Text = formattedValue;
              
               
            } else {  
                this.YetkiTurID.Text = IKKullanicilarTable.YetkiTurID.Format(IKKullanicilarTable.YetkiTurID.DefaultValue);
                            
            }
                    
            if (this.DataSource.HesapIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.HesapID);
                this.HesapID.Text = formattedValue;
              
               
            } else {  
                this.HesapID.Text = IKKullanicilarTable.HesapID.Format(IKKullanicilarTable.HesapID.DefaultValue);
                            
            }
                    
            if (this.DataSource.TCKimlikNoSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.TCKimlikNo);
                this.TCKimlikNo.Text = formattedValue;
              
               
            } else {  
                this.TCKimlikNo.Text = IKKullanicilarTable.TCKimlikNo.Format(IKKullanicilarTable.TCKimlikNo.DefaultValue);
                            
            }
                    
            if (this.DataSource.IsTelefonuSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.IsTelefonu);
                this.IsTelefonu.Text = formattedValue;
              
               
            } else {  
                this.IsTelefonu.Text = IKKullanicilarTable.IsTelefonu.Format(IKKullanicilarTable.IsTelefonu.DefaultValue);
                            
            }
                    
            if (this.DataSource.KullaniciAdiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.KullaniciAdi);
                this.KullaniciAdi.Text = formattedValue;
              
               
            } else {  
                this.KullaniciAdi.Text = IKKullanicilarTable.KullaniciAdi.Format(IKKullanicilarTable.KullaniciAdi.DefaultValue);
                            
            }
                    
            this.OlusturmaTarihi.Attributes.Add("onfocus", "toggleEnableDisableDateFormatter(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
            this.OlusturmaTarihi.Attributes.Add("onblur", "presubmitDateValidation(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
                    
            if (this.DataSource.OlusturmaTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.OlusturmaTarihi);
                this.OlusturmaTarihi.Text = formattedValue;
              
               
            } else {  
                this.OlusturmaTarihi.Text = IKKullanicilarTable.OlusturmaTarihi.Format(IKKullanicilarTable.OlusturmaTarihi.DefaultValue);
                            
            }
                    
            if (this.DataSource.OlusturanIDSpecified) {
                this.PopulateOlusturanIDDropDownList(this.DataSource.OlusturanID.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateOlusturanIDDropDownList(IKKullanicilarTable.OlusturanID.DefaultValue, 100);
                } else {
                this.PopulateOlusturanIDDropDownList(null, 100);
                }
            }
                
            this.DuzenlenmeTarihi.Attributes.Add("onfocus", "toggleEnableDisableDateFormatter(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
            this.DuzenlenmeTarihi.Attributes.Add("onblur", "presubmitDateValidation(this, '" + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("'", "").ToLower() + "');");
                    
            if (this.DataSource.DuzenlenmeTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.DuzenlenmeTarihi);
                this.DuzenlenmeTarihi.Text = formattedValue;
              
               
            } else {  
                this.DuzenlenmeTarihi.Text = IKKullanicilarTable.DuzenlenmeTarihi.Format(IKKullanicilarTable.DuzenlenmeTarihi.DefaultValue);
                            
            }
                    
            if (this.DataSource.DuzenleyenIDSpecified) {
                this.PopulateDuzenleyenIDDropDownList(this.DataSource.DuzenleyenID.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateDuzenleyenIDDropDownList(IKKullanicilarTable.DuzenleyenID.DefaultValue, 100);
                } else {
                this.PopulateDuzenleyenIDDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.AktifPasifSpecified) {
                this.AktifPasif.Checked = this.DataSource.AktifPasif;
            } else {
                if (!this.DataSource.IsCreated) {
                    this.AktifPasif.Checked = IKKullanicilarTable.AktifPasif.ParseValue(IKKullanicilarTable.AktifPasif.DefaultValue).ToBoolean();
                }
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
        
        

        //  To customize, override this method in IKKullanicilarRecordControl.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in IKKullanicilarRecordControl to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in IKKullanicilarRecordControl to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in IKKullanicilarRecordControl.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(this.Adi.Text, IKKullanicilarTable.Adi);
              
            this.DataSource.Parse(this.Soyadi.Text, IKKullanicilarTable.Soyadi);
              
            this.DataSource.Parse(this.Eposta.Text, IKKullanicilarTable.Eposta);
              
            this.DataSource.Parse(this.GSM.Text, IKKullanicilarTable.GSM);
              
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.FirmaID), IKKullanicilarTable.FirmaID);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.UnvanID), IKKullanicilarTable.UnvanID);
                  
            this.DataSource.Parse(this.YetkiTurID.Text, IKKullanicilarTable.YetkiTurID);
              
            this.DataSource.Parse(this.HesapID.Text, IKKullanicilarTable.HesapID);
              
            this.DataSource.Parse(this.TCKimlikNo.Text, IKKullanicilarTable.TCKimlikNo);
              
            this.DataSource.Parse(this.IsTelefonu.Text, IKKullanicilarTable.IsTelefonu);
              
            this.DataSource.Parse(this.KullaniciAdi.Text, IKKullanicilarTable.KullaniciAdi);
              
            this.DataSource.Parse(this.OlusturmaTarihi.Text, IKKullanicilarTable.OlusturmaTarihi);
              
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.OlusturanID), IKKullanicilarTable.OlusturanID);
                  
            this.DataSource.Parse(this.DuzenlenmeTarihi.Text, IKKullanicilarTable.DuzenlenmeTarihi);
              
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.DuzenleyenID), IKKullanicilarTable.DuzenleyenID);
                  
            this.DataSource.AktifPasif = this.AktifPasif.Checked;
                    
      }

      

        //  To customize, override this method in IKKullanicilarRecordControl.
        public virtual WhereClause CreateWhereClause()
        {
        
            WhereClause wc;
            IKKullanicilarTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.

            
            // Retrieve the record id from the URL parameter.
              
            string recId = this.Page.Request.QueryString["IKKullanicilar"];
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "KumePortali").Replace("{URL}", "IKKullanicilar"));
            }
            HttpContext.Current.Session["SelectedID"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                wc.iAND(IKKullanicilarTable.KullaniciID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(IKKullanicilarTable.KullaniciID).ToString());
            } else {
                
                wc.iAND(IKKullanicilarTable.KullaniciID, BaseFilter.ComparisonOperator.EqualsTo, recId);
            }
              

            
            return wc;
          
        }
        
        
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            IKKullanicilarTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelatvieVirtualPath"];
          
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            return wc;
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
        
        

        //  To customize, override this method in IKKullanicilarRecordControl.
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
            IKKullanicilarTable.DeleteRecord(pk);

          
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

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
        public virtual WhereClause CreateWhereClause_FirmaIDDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_UnvanIDDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_OlusturanIDDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_DuzenleyenIDDropDownList() {
            return new WhereClause();
        }
                
        // Fill the FirmaID list.
        protected virtual void PopulateFirmaIDDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_FirmaIDDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MIYSAHesaplarTable.FirmaAdi, OrderByItem.OrderDir.Asc);

                      this.FirmaID.Items.Clear();
            foreach (MIYSAHesaplarRecord itemValue in MIYSAHesaplarTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.HesapIDSpecified) {
                    cvalue = itemValue.HesapID.ToString();
                    fvalue = itemValue.Format(MIYSAHesaplarTable.FirmaAdi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.FirmaID.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.FirmaID, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.FirmaID, IKKullanicilarTable.FirmaID.Format(selectedValue))) {
                string fvalue = IKKullanicilarTable.FirmaID.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.FirmaID.Items.Insert(0, item);
            }

                  
            this.FirmaID.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "KumePortali"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the UnvanID list.
        protected virtual void PopulateUnvanIDDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_UnvanIDDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(IKUnvanlarTable.UnvanAdi, OrderByItem.OrderDir.Asc);

                      this.UnvanID.Items.Clear();
            foreach (IKUnvanlarRecord itemValue in IKUnvanlarTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.UnvanIDSpecified) {
                    cvalue = itemValue.UnvanID.ToString();
                    fvalue = itemValue.Format(IKUnvanlarTable.UnvanAdi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.UnvanID.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.UnvanID, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.UnvanID, IKKullanicilarTable.UnvanID.Format(selectedValue))) {
                string fvalue = IKKullanicilarTable.UnvanID.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.UnvanID.Items.Insert(0, item);
            }

                  
            this.UnvanID.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "KumePortali"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the OlusturanID list.
        protected virtual void PopulateOlusturanIDDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_OlusturanIDDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(IKKullanicilarTable.Adi, OrderByItem.OrderDir.Asc);

                      this.OlusturanID.Items.Clear();
            foreach (IKKullanicilarRecord itemValue in IKKullanicilarTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.KullaniciIDSpecified) {
                    cvalue = itemValue.KullaniciID.ToString();
                    fvalue = itemValue.Format(IKKullanicilarTable.Adi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.OlusturanID.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.OlusturanID, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.OlusturanID, IKKullanicilarTable.OlusturanID.Format(selectedValue))) {
                string fvalue = IKKullanicilarTable.OlusturanID.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.OlusturanID.Items.Insert(0, item);
            }

                  
            this.OlusturanID.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "KumePortali"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the DuzenleyenID list.
        protected virtual void PopulateDuzenleyenIDDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_DuzenleyenIDDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(IKKullanicilarTable.Adi, OrderByItem.OrderDir.Asc);

                      this.DuzenleyenID.Items.Clear();
            foreach (IKKullanicilarRecord itemValue in IKKullanicilarTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.KullaniciIDSpecified) {
                    cvalue = itemValue.KullaniciID.ToString();
                    fvalue = itemValue.Format(IKKullanicilarTable.Adi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.DuzenleyenID.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.DuzenleyenID, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.DuzenleyenID, IKKullanicilarTable.DuzenleyenID.Format(selectedValue))) {
                string fvalue = IKKullanicilarTable.DuzenleyenID.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.DuzenleyenID.Items.Insert(0, item);
            }

                  
            this.DuzenleyenID.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "KumePortali"), "--PLEASE_SELECT--"));
                  
        }
                
        // event handler for ImageButton
        public virtual void FirmaIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../MIYSAHesaplar/AddMIYSAHesaplarPage.aspx";
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
        public virtual void UnvanIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKUnvanlar/AddIKUnvanlarPage.aspx";
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
        public virtual void OlusturanIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKKullanicilar/AddIKKullanicilarPage.aspx";
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
        public virtual void DuzenleyenIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKKullanicilar/AddIKKullanicilarPage.aspx";
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
            
              protected virtual void FirmaID_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.FirmaID);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.FirmaID, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.FirmaID, IKKullanicilarTable.FirmaID.Format(selectedValue))) {
              string fvalue = IKKullanicilarTable.FirmaID.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.FirmaID.Items.Insert(0, item);
              }
              }
            
              protected virtual void UnvanID_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.UnvanID);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.UnvanID, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.UnvanID, IKKullanicilarTable.UnvanID.Format(selectedValue))) {
              string fvalue = IKKullanicilarTable.UnvanID.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.UnvanID.Items.Insert(0, item);
              }
              }
            
              protected virtual void OlusturanID_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.OlusturanID);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.OlusturanID, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.OlusturanID, IKKullanicilarTable.OlusturanID.Format(selectedValue))) {
              string fvalue = IKKullanicilarTable.OlusturanID.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.OlusturanID.Items.Insert(0, item);
              }
              }
            
              protected virtual void DuzenleyenID_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.DuzenleyenID);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.DuzenleyenID, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.DuzenleyenID, IKKullanicilarTable.DuzenleyenID.Format(selectedValue))) {
              string fvalue = IKKullanicilarTable.DuzenleyenID.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.DuzenleyenID.Items.Insert(0, item);
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
                return (string)this.ViewState["BaseIKKullanicilarRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseIKKullanicilarRecordControl_Rec"] = value;
            }
        }
        
        private IKKullanicilarRecord _DataSource;
        public IKKullanicilarRecord DataSource {
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
        
        public System.Web.UI.WebControls.Literal IKKullanicilarTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarTitle");
            }
        }
        
        public System.Web.UI.WebControls.Literal AdiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal SoyadiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SoyadiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal EpostaLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EpostaLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal GSMLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSMLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirmaIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal UnvanIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal YetkiTurIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiTurIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal HesapIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HesapIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TCKimlikNoLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TCKimlikNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal IsTelefonuLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IsTelefonuLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal KullaniciAdiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KullaniciAdiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal OlusturmaTarihiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal OlusturanIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal DuzenlenmeTarihiLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihiLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal DuzenleyenIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal AktifPasifLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasifLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Adi {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Adi");
            }
        }
            
        public System.Web.UI.WebControls.TextBox Soyadi {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Soyadi");
            }
        }
            
        public System.Web.UI.WebControls.TextBox Eposta {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Eposta");
            }
        }
            
        public System.Web.UI.WebControls.TextBox GSM {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSM");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList FirmaID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton FirmaIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList UnvanID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton UnvanIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.TextBox YetkiTurID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiTurID");
            }
        }
            
        public System.Web.UI.WebControls.TextBox HesapID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HesapID");
            }
        }
            
        public System.Web.UI.WebControls.TextBox TCKimlikNo {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TCKimlikNo");
            }
        }
            
        public System.Web.UI.WebControls.TextBox IsTelefonu {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IsTelefonu");
            }
        }
            
        public System.Web.UI.WebControls.TextBox KullaniciAdi {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KullaniciAdi");
            }
        }
            
        public System.Web.UI.WebControls.TextBox OlusturmaTarihi {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihi");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList OlusturanID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton OlusturanIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.TextBox DuzenlenmeTarihi {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihi");
            }
        }
            
        public System.Web.UI.WebControls.DropDownList DuzenleyenID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton DuzenleyenIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox AktifPasif {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasif");
            }
        }
            
#endregion

#region "Helper Functions"
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            IKKullanicilarRecord rec = null;
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

        public IKKullanicilarRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return IKKullanicilarTable.GetRecord(this.RecordUniqueId, true);
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

  

#endregion
    
  
}

  