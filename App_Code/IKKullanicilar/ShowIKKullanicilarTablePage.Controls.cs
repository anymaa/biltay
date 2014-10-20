
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowIKKullanicilarTablePage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace KumePortali.UI.Controls.ShowIKKullanicilarTablePage
{
  

#region "Section 1: Place your customizations here."

    
public class IKKullanicilarTableControlRow : BaseIKKullanicilarTableControlRow
{
      
        // The BaseIKKullanicilarTableControlRow implements code for a ROW within the
        // the IKKullanicilarTableControl table.  The BaseIKKullanicilarTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of IKKullanicilarTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class IKKullanicilarTableControl : BaseIKKullanicilarTableControl
{
        // The BaseIKKullanicilarTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The IKKullanicilarTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the IKKullanicilarTableControlRow control on the ShowIKKullanicilarTablePage page.
// Do not modify this class. Instead override any method in IKKullanicilarTableControlRow.
public class BaseIKKullanicilarTableControlRow : KumePortali.UI.BaseApplicationRecordControl
{
        public BaseIKKullanicilarTableControlRow()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in IKKullanicilarTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            
      
      
            // Register the event handlers.
        
              this.IKKullanicilarRowViewButton.Click += new ImageClickEventHandler(IKKullanicilarRowViewButton_Click);
              this.IKKullanicilarRowEditButton.Click += new ImageClickEventHandler(IKKullanicilarRowEditButton_Click);
              this.IKKullanicilarRowDeleteButton.Click += new ImageClickEventHandler(IKKullanicilarRowDeleteButton_Click);
              this.FirmaID.Click += new EventHandler(FirmaID_Click);
            
              this.UnvanID.Click += new EventHandler(UnvanID_Click);
            
              this.OlusturanID.Click += new EventHandler(OlusturanID_Click);
            
              this.DuzenleyenID.Click += new EventHandler(DuzenleyenID_Click);
            
        }

        // To customize, override this method in IKKullanicilarTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.IKKullanicilarRowDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "KumePortali") + "'));");
        }

        // Read data from database. To customize, override this method in IKKullanicilarTableControlRow.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = IKKullanicilarTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseIKKullanicilarTableControl when the data for the entire
            // table is loaded.
            this.DataSource = new IKKullanicilarRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in IKKullanicilarTableControlRow.
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
                    
                this.Adi.Text = formattedValue;
              
               
            } else {  
                this.Adi.Text = IKKullanicilarTable.Adi.Format(IKKullanicilarTable.Adi.DefaultValue);
                            
            }
                    
            if (this.Adi.Text == null ||
                this.Adi.Text.Trim().Length == 0) {
                this.Adi.Text = "&nbsp;";
            }
                  
            if (this.DataSource.SoyadiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.Soyadi);
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
                    
                this.Soyadi.Text = formattedValue;
              
               
            } else {  
                this.Soyadi.Text = IKKullanicilarTable.Soyadi.Format(IKKullanicilarTable.Soyadi.DefaultValue);
                            
            }
                    
            if (this.Soyadi.Text == null ||
                this.Soyadi.Text.Trim().Length == 0) {
                this.Soyadi.Text = "&nbsp;";
            }
                  
            if (this.DataSource.EpostaSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.Eposta);
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
                    
                this.Eposta.Text = formattedValue;
              
               
            } else {  
                this.Eposta.Text = IKKullanicilarTable.Eposta.Format(IKKullanicilarTable.Eposta.DefaultValue);
                            
            }
                    
            if (this.Eposta.Text == null ||
                this.Eposta.Text.Trim().Length == 0) {
                this.Eposta.Text = "&nbsp;";
            }
                  
            if (this.DataSource.GSMSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.GSM);
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
                    
                this.GSM.Text = formattedValue;
              
               
            } else {  
                this.GSM.Text = IKKullanicilarTable.GSM.Format(IKKullanicilarTable.GSM.DefaultValue);
                            
            }
                    
            if (this.GSM.Text == null ||
                this.GSM.Text.Trim().Length == 0) {
                this.GSM.Text = "&nbsp;";
            }
                  
            if (this.DataSource.FirmaIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.FirmaID);
                this.FirmaID.Text = formattedValue;
              
               
            } else {  
                this.FirmaID.Text = IKKullanicilarTable.FirmaID.Format(IKKullanicilarTable.FirmaID.DefaultValue);
                            
            }
                    
            if (this.DataSource.UnvanIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.UnvanID);
                this.UnvanID.Text = formattedValue;
              
               
            } else {  
                this.UnvanID.Text = IKKullanicilarTable.UnvanID.Format(IKKullanicilarTable.UnvanID.DefaultValue);
                            
            }
                    
            if (this.DataSource.YetkiTurIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.YetkiTurID);
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
                    
                this.YetkiTurID.Text = formattedValue;
              
               
            } else {  
                this.YetkiTurID.Text = IKKullanicilarTable.YetkiTurID.Format(IKKullanicilarTable.YetkiTurID.DefaultValue);
                            
            }
                    
            if (this.YetkiTurID.Text == null ||
                this.YetkiTurID.Text.Trim().Length == 0) {
                this.YetkiTurID.Text = "&nbsp;";
            }
                  
            if (this.DataSource.HesapIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.HesapID);
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
                    
                this.HesapID.Text = formattedValue;
              
               
            } else {  
                this.HesapID.Text = IKKullanicilarTable.HesapID.Format(IKKullanicilarTable.HesapID.DefaultValue);
                            
            }
                    
            if (this.HesapID.Text == null ||
                this.HesapID.Text.Trim().Length == 0) {
                this.HesapID.Text = "&nbsp;";
            }
                  
            if (this.DataSource.TCKimlikNoSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.TCKimlikNo);
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
                    
                this.TCKimlikNo.Text = formattedValue;
              
               
            } else {  
                this.TCKimlikNo.Text = IKKullanicilarTable.TCKimlikNo.Format(IKKullanicilarTable.TCKimlikNo.DefaultValue);
                            
            }
                    
            if (this.TCKimlikNo.Text == null ||
                this.TCKimlikNo.Text.Trim().Length == 0) {
                this.TCKimlikNo.Text = "&nbsp;";
            }
                  
            if (this.DataSource.IsTelefonuSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.IsTelefonu);
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
                    
                this.IsTelefonu.Text = formattedValue;
              
               
            } else {  
                this.IsTelefonu.Text = IKKullanicilarTable.IsTelefonu.Format(IKKullanicilarTable.IsTelefonu.DefaultValue);
                            
            }
                    
            if (this.IsTelefonu.Text == null ||
                this.IsTelefonu.Text.Trim().Length == 0) {
                this.IsTelefonu.Text = "&nbsp;";
            }
                  
            if (this.DataSource.KullaniciAdiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.KullaniciAdi);
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
                    
                this.KullaniciAdi.Text = formattedValue;
              
               
            } else {  
                this.KullaniciAdi.Text = IKKullanicilarTable.KullaniciAdi.Format(IKKullanicilarTable.KullaniciAdi.DefaultValue);
                            
            }
                    
            if (this.KullaniciAdi.Text == null ||
                this.KullaniciAdi.Text.Trim().Length == 0) {
                this.KullaniciAdi.Text = "&nbsp;";
            }
                  
            if (this.DataSource.OlusturmaTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.OlusturmaTarihi);
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
                    
                this.OlusturmaTarihi.Text = formattedValue;
              
               
            } else {  
                this.OlusturmaTarihi.Text = IKKullanicilarTable.OlusturmaTarihi.Format(IKKullanicilarTable.OlusturmaTarihi.DefaultValue);
                            
            }
                    
            if (this.OlusturmaTarihi.Text == null ||
                this.OlusturmaTarihi.Text.Trim().Length == 0) {
                this.OlusturmaTarihi.Text = "&nbsp;";
            }
                  
            if (this.DataSource.OlusturanIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.OlusturanID);
                this.OlusturanID.Text = formattedValue;
              
               
            } else {  
                this.OlusturanID.Text = IKKullanicilarTable.OlusturanID.Format(IKKullanicilarTable.OlusturanID.DefaultValue);
                            
            }
                    
            if (this.DataSource.DuzenlenmeTarihiSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.DuzenlenmeTarihi);
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
                    
                this.DuzenlenmeTarihi.Text = formattedValue;
              
               
            } else {  
                this.DuzenlenmeTarihi.Text = IKKullanicilarTable.DuzenlenmeTarihi.Format(IKKullanicilarTable.DuzenlenmeTarihi.DefaultValue);
                            
            }
                    
            if (this.DuzenlenmeTarihi.Text == null ||
                this.DuzenlenmeTarihi.Text.Trim().Length == 0) {
                this.DuzenlenmeTarihi.Text = "&nbsp;";
            }
                  
            if (this.DataSource.DuzenleyenIDSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.DuzenleyenID);
                this.DuzenleyenID.Text = formattedValue;
              
               
            } else {  
                this.DuzenleyenID.Text = IKKullanicilarTable.DuzenleyenID.Format(IKKullanicilarTable.DuzenleyenID.DefaultValue);
                            
            }
                    
            if (this.DataSource.AktifPasifSpecified) {
                      
                string formattedValue = this.DataSource.Format(IKKullanicilarTable.AktifPasif);
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
                    
                this.AktifPasif.Text = formattedValue;
              
               
            } else {  
                this.AktifPasif.Text = IKKullanicilarTable.AktifPasif.Format(IKKullanicilarTable.AktifPasif.DefaultValue);
                            
            }
                    
            if (this.AktifPasif.Text == null ||
                this.AktifPasif.Text.Trim().Length == 0) {
                this.AktifPasif.Text = "&nbsp;";
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
        
        

        //  To customize, override this method in IKKullanicilarTableControlRow.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in IKKullanicilarTableControlRow to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in IKKullanicilarTableControlRow to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((IKKullanicilarTableControl)MiscUtils.GetParentControlObject(this, "IKKullanicilarTableControl")).DataChanged = true;
                ((IKKullanicilarTableControl)MiscUtils.GetParentControlObject(this, "IKKullanicilarTableControl")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in IKKullanicilarTableControlRow.
        public virtual void GetUIData()
        {
        
      }

      

        //  To customize, override this method in IKKullanicilarTableControlRow.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        
        

        //  To customize, override this method in IKKullanicilarTableControlRow.
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

          
            ((IKKullanicilarTableControl)MiscUtils.GetParentControlObject(this, "IKKullanicilarTableControl")).DataChanged = true;
            ((IKKullanicilarTableControl)MiscUtils.GetParentControlObject(this, "IKKullanicilarTableControl")).ResetData = true;
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
        public virtual void IKKullanicilarRowViewButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={PK}";
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
        public virtual void IKKullanicilarRowEditButton_Click(object sender, ImageClickEventArgs args)
        {
        
            string url = @"../IKKullanicilar/EditIKKullanicilarPage.aspx?IKKullanicilar={PK}";
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
        public virtual void IKKullanicilarRowDeleteButton_Click(object sender, ImageClickEventArgs args)
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
            
        // event handler for LinkButton
        public virtual void FirmaID_Click(object sender, EventArgs args)
        {
        
            string url = @"../MIYSAHesaplar/ShowMIYSAHesaplarPage.aspx?MIYSAHesaplar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_Firma}";
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
            
        // event handler for LinkButton
        public virtual void UnvanID_Click(object sender, EventArgs args)
        {
        
            string url = @"../IKUnvanlar/ShowIKUnvanlarPage.aspx?IKUnvanlar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_IKUnvanlar}";
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
            
        // event handler for LinkButton
        public virtual void OlusturanID_Click(object sender, EventArgs args)
        {
        
            string url = @"../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_IKKullanicilar}";
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
            
        // event handler for LinkButton
        public virtual void DuzenleyenID_Click(object sender, EventArgs args)
        {
        
            string url = @"../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_IKKullanicilar1}";
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
                return (string)this.ViewState["BaseIKKullanicilarTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseIKKullanicilarTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarRowViewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarRowViewButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarRowEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarRowEditButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox IKKullanicilarRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarRecordRowSelection");
            }
        }
        
        public System.Web.UI.WebControls.Literal Adi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Adi");
            }
        }
            
        public System.Web.UI.WebControls.Literal Soyadi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Soyadi");
            }
        }
            
        public System.Web.UI.WebControls.Literal Eposta {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Eposta");
            }
        }
            
        public System.Web.UI.WebControls.Literal GSM {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSM");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton FirmaID {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaID");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton UnvanID {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanID");
            }
        }
            
        public System.Web.UI.WebControls.Literal YetkiTurID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiTurID");
            }
        }
            
        public System.Web.UI.WebControls.Literal HesapID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HesapID");
            }
        }
            
        public System.Web.UI.WebControls.Literal TCKimlikNo {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TCKimlikNo");
            }
        }
            
        public System.Web.UI.WebControls.Literal IsTelefonu {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IsTelefonu");
            }
        }
            
        public System.Web.UI.WebControls.Literal KullaniciAdi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KullaniciAdi");
            }
        }
            
        public System.Web.UI.WebControls.Literal OlusturmaTarihi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihi");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton OlusturanID {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanID");
            }
        }
            
        public System.Web.UI.WebControls.Literal DuzenlenmeTarihi {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihi");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton DuzenleyenID {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenID");
            }
        }
            
        public System.Web.UI.WebControls.Literal AktifPasif {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasif");
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

  
// Base class for the IKKullanicilarTableControl control on the ShowIKKullanicilarTablePage page.
// Do not modify this class. Instead override any method in IKKullanicilarTableControl.
public class BaseIKKullanicilarTableControl : KumePortali.UI.BaseApplicationTableControl
{
        public BaseIKKullanicilarTableControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.IKKullanicilarPagination.FirstPage.Click += new ImageClickEventHandler(IKKullanicilarPagination_FirstPage_Click);
              this.IKKullanicilarPagination.LastPage.Click += new ImageClickEventHandler(IKKullanicilarPagination_LastPage_Click);
              this.IKKullanicilarPagination.NextPage.Click += new ImageClickEventHandler(IKKullanicilarPagination_NextPage_Click);
              this.IKKullanicilarPagination.PageSizeButton.Click += new EventHandler(IKKullanicilarPagination_PageSizeButton_Click);
            
              this.IKKullanicilarPagination.PreviousPage.Click += new ImageClickEventHandler(IKKullanicilarPagination_PreviousPage_Click);

            // Setup the sorting events.
        
              this.AdiLabel.Click += new EventHandler(AdiLabel_Click);
            
              this.SoyadiLabel.Click += new EventHandler(SoyadiLabel_Click);
            
              this.EpostaLabel.Click += new EventHandler(EpostaLabel_Click);
            
              this.GSMLabel.Click += new EventHandler(GSMLabel_Click);
            
              this.FirmaIDLabel1.Click += new EventHandler(FirmaIDLabel1_Click);
            
              this.UnvanIDLabel1.Click += new EventHandler(UnvanIDLabel1_Click);
            
              this.YetkiTurIDLabel.Click += new EventHandler(YetkiTurIDLabel_Click);
            
              this.HesapIDLabel.Click += new EventHandler(HesapIDLabel_Click);
            
              this.TCKimlikNoLabel.Click += new EventHandler(TCKimlikNoLabel_Click);
            
              this.IsTelefonuLabel.Click += new EventHandler(IsTelefonuLabel_Click);
            
              this.KullaniciAdiLabel.Click += new EventHandler(KullaniciAdiLabel_Click);
            
              this.OlusturmaTarihiLabel.Click += new EventHandler(OlusturmaTarihiLabel_Click);
            
              this.OlusturanIDLabel.Click += new EventHandler(OlusturanIDLabel_Click);
            
              this.DuzenlenmeTarihiLabel.Click += new EventHandler(DuzenlenmeTarihiLabel_Click);
            
              this.DuzenleyenIDLabel.Click += new EventHandler(DuzenleyenIDLabel_Click);
            
              this.AktifPasifLabel.Click += new EventHandler(AktifPasifLabel_Click);
            

            // Setup the button events.
        
              this.IKKullanicilarNewButton.Click += new ImageClickEventHandler(IKKullanicilarNewButton_Click);
              this.IKKullanicilarDeleteButton.Click += new ImageClickEventHandler(IKKullanicilarDeleteButton_Click);
              this.IKKullanicilarExportExcelButton.Click += new ImageClickEventHandler(IKKullanicilarExportExcelButton_Click);
                      this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"IKKullanicilarExportExcelButton"), MiscUtils.GetParentControlObject(this,"IKKullanicilarTableControlUpdatePanel"));
                    
              this.IKKullanicilarRefreshButton.Click += new ImageClickEventHandler(IKKullanicilarRefreshButton_Click);
              this.IKKullanicilarResetButton.Click += new ImageClickEventHandler(IKKullanicilarResetButton_Click);
              this.IKKullanicilarSearchButton.Button.Click += new EventHandler(IKKullanicilarSearchButton_Click);

            // Setup the filter and search events.
        
            this.UnvanIDFilter.SelectedIndexChanged += new EventHandler(UnvanIDFilter_SelectedIndexChanged);
            this.FirmaIDFilter.SelectedIndexChanged += new EventHandler(FirmaIDFilter_SelectedIndexChanged);
            if (!this.Page.IsPostBack && this.InSession(this.IKKullanicilarSearchArea)) {
                
                this.IKKullanicilarSearchArea.Text = this.GetFromSession(this.IKKullanicilarSearchArea);
                
            }
            if (!this.Page.IsPostBack && this.InSession(this.UnvanIDFilter)) {
                this.UnvanIDFilter.Items.Add(new ListItem(this.GetFromSession(this.UnvanIDFilter), this.GetFromSession(this.UnvanIDFilter)));
                this.UnvanIDFilter.SelectedValue = this.GetFromSession(this.UnvanIDFilter);
                
            }
            if (!this.Page.IsPostBack && this.InSession(this.FirmaIDFilter)) {
                this.FirmaIDFilter.Items.Add(new ListItem(this.GetFromSession(this.FirmaIDFilter), this.GetFromSession(this.FirmaIDFilter)));
                this.FirmaIDFilter.SelectedValue = this.GetFromSession(this.FirmaIDFilter);
                
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
                this.IKKullanicilarDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "KumePortali") + "'));");
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
                    this.DataSource = (IKKullanicilarRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.IKKullanicilarRecord")));
                    // Add records to the list if needed.
                    this.AddNewRecords();
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = IKKullanicilarTable.GetRecordCount(wc);

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
                    this.DataSource = (IKKullanicilarRecord[])(alist.ToArray(Type.GetType("KumePortali.Business.IKKullanicilarRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (IKKullanicilarTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (IKKullanicilarRecord[])(postdata.ToArray(Type.GetType("KumePortali.Business.IKKullanicilarRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = IKKullanicilarTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
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
        
            this.PopulateUnvanIDFilter(MiscUtils.GetSelectedValue(this.UnvanIDFilter, this.GetFromSession(this.UnvanIDFilter)), 500);
                    
            this.PopulateFirmaIDFilter(MiscUtils.GetSelectedValue(this.FirmaIDFilter, this.GetFromSession(this.FirmaIDFilter)), 500);
                    

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("IKKullanicilarTableControlRepeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                IKKullanicilarTableControlRow recControl = (IKKullanicilarTableControlRow)(repItem.FindControl("IKKullanicilarTableControlRow"));
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
          
            this.Page.PregetDfkaRecords(IKKullanicilarTable.FirmaID, this.DataSource);
            this.Page.PregetDfkaRecords(IKKullanicilarTable.UnvanID, this.DataSource);
            this.Page.PregetDfkaRecords(IKKullanicilarTable.OlusturanID, this.DataSource);
            this.Page.PregetDfkaRecords(IKKullanicilarTable.DuzenleyenID, this.DataSource);
        }
         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for IKKullanicilarTableControl pagination.
        
            this.IKKullanicilarPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            this.IKKullanicilarPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.IKKullanicilarPagination.LastPage.Enabled = false;
            }
          
            this.IKKullanicilarPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.IKKullanicilarPagination.NextPage.Enabled = false;
            }
          
            this.IKKullanicilarPagination.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.IKKullanicilarPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.IKKullanicilarPagination.CurrentPage.Text = "0";
            }
            this.IKKullanicilarPagination.PageSize.Text = this.PageSize.ToString();
            this.IKKullanicilarTotalItems.Text = this.TotalRecords.ToString();
            this.IKKullanicilarPagination.TotalItems.Text = this.TotalRecords.ToString();
            this.IKKullanicilarPagination.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (IKKullanicilarTableControlRow recCtl in this.GetRecordControls())
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
            IKKullanicilarTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        
            if (MiscUtils.IsValueSelected(this.IKKullanicilarSearchArea)) {
                // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (this.IKKullanicilarSearchArea.Text.StartsWith("...")) {
                    this.IKKullanicilarSearchArea.Text = this.IKKullanicilarSearchArea.Text.Substring(3,this.IKKullanicilarSearchArea.Text.Length-3);
                }
                if (this.IKKullanicilarSearchArea.Text.EndsWith("...")) {
                    this.IKKullanicilarSearchArea.Text = this.IKKullanicilarSearchArea.Text.Substring(0,this.IKKullanicilarSearchArea.Text.Length-3);
                }
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.IKKullanicilarSearchArea)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    WhereClause search = new WhereClause();
                    
                    search.iOR(IKKullanicilarTable.Adi, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.IKKullanicilarSearchArea, this.GetFromSession(this.IKKullanicilarSearchArea)), true, false);
        
                    search.iOR(IKKullanicilarTable.Soyadi, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.IKKullanicilarSearchArea, this.GetFromSession(this.IKKullanicilarSearchArea)), true, false);
        
                    wc.iAND(search);
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.UnvanIDFilter)) {
                        
                wc.iAND(IKKullanicilarTable.UnvanID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.UnvanIDFilter, this.GetFromSession(this.UnvanIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.FirmaIDFilter)) {
                        
                wc.iAND(IKKullanicilarTable.FirmaID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.FirmaIDFilter, this.GetFromSession(this.FirmaIDFilter)), false, false);
                    
            }
                      
            return (wc);
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
          
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "IKKullanicilarSearchArea") {
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
                
                        search.iOR(IKKullanicilarTable.Adi, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                        search.iOR(IKKullanicilarTable.Adi, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                  
                
                        search.iOR(IKKullanicilarTable.Soyadi, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                        search.iOR(IKKullanicilarTable.Soyadi, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                  
                
                    } else {
                        
                        search.iOR(IKKullanicilarTable.Adi, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
                        search.iOR(IKKullanicilarTable.Soyadi, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
                    } 
                    wc.iAND(search);
                }
            }
                  
            String UnvanIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "UnvanIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(UnvanIDFilterSelectedValue)) {
                wc.iAND(IKKullanicilarTable.UnvanID, BaseFilter.ComparisonOperator.EqualsTo, UnvanIDFilterSelectedValue, false, false);
            }
                      
            String FirmaIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "FirmaIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(FirmaIDFilterSelectedValue)) {
                wc.iAND(IKKullanicilarTable.FirmaID, BaseFilter.ComparisonOperator.EqualsTo, FirmaIDFilterSelectedValue, false, false);
            }
                      
            return wc;
        }
          
         public virtual string[] GetAutoCompletionList_IKKullanicilarSearchArea(String prefixText,int count)
         {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            int iteration = 0;
            
            WhereClause wc= CreateWhereClause(prefixText,"IKKullanicilarSearchArea", "AnyWhereInString", "[^a-zA-Z0-9]");
            while (resultList.Count < count && iteration < 5){
                // Fetch 100 records in each iteration
                KumePortali.Business.IKKullanicilarRecord[] records = IKKullanicilarTable.GetRecords(wc, null, iteration, 100);
                String resultItem = "";
                foreach (IKKullanicilarRecord rec in records){
                    // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                    if (resultList.Count >= count) {
                        break;
                    }
                    // If the field is configured to Display as Foreign key, Format() method returns the 
                    // Display as Forien Key value instead of original field value.
                    // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                    // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
            
                    resultItem = rec.Format(IKKullanicilarTable.Adi);
                    if (StringUtils.InvariantUCase(resultItem).Contains(StringUtils.InvariantUCase(prefixText))) {
                        bool isAdded = FormatSuggestions(prefixText, resultItem, 50, "InMiddleOfMatchedString", "AnyWhereInString", "[^a-zA-Z0-9]", resultList);
                        if (isAdded) {
                            continue;
                        }
                    }
      
                    resultItem = rec.Format(IKKullanicilarTable.Soyadi);
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
        
            if (this.IKKullanicilarPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.IKKullanicilarPagination.PageSize.Text);
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
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("IKKullanicilarTableControlRepeater"));

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    IKKullanicilarTableControlRow recControl = (IKKullanicilarTableControlRow)(repItem.FindControl("IKKullanicilarTableControlRow"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        IKKullanicilarRecord rec = new IKKullanicilarRecord();
        
                        if (recControl.Adi.Text != "") {
                            rec.Parse(recControl.Adi.Text, IKKullanicilarTable.Adi);
                  }
                
                        if (recControl.Soyadi.Text != "") {
                            rec.Parse(recControl.Soyadi.Text, IKKullanicilarTable.Soyadi);
                  }
                
                        if (recControl.Eposta.Text != "") {
                            rec.Parse(recControl.Eposta.Text, IKKullanicilarTable.Eposta);
                  }
                
                        if (recControl.GSM.Text != "") {
                            rec.Parse(recControl.GSM.Text, IKKullanicilarTable.GSM);
                  }
                
                        if (recControl.FirmaID.Text != "") {
                            rec.Parse(recControl.FirmaID.Text, IKKullanicilarTable.FirmaID);
                  }
                
                        if (recControl.UnvanID.Text != "") {
                            rec.Parse(recControl.UnvanID.Text, IKKullanicilarTable.UnvanID);
                  }
                
                        if (recControl.YetkiTurID.Text != "") {
                            rec.Parse(recControl.YetkiTurID.Text, IKKullanicilarTable.YetkiTurID);
                  }
                
                        if (recControl.HesapID.Text != "") {
                            rec.Parse(recControl.HesapID.Text, IKKullanicilarTable.HesapID);
                  }
                
                        if (recControl.TCKimlikNo.Text != "") {
                            rec.Parse(recControl.TCKimlikNo.Text, IKKullanicilarTable.TCKimlikNo);
                  }
                
                        if (recControl.IsTelefonu.Text != "") {
                            rec.Parse(recControl.IsTelefonu.Text, IKKullanicilarTable.IsTelefonu);
                  }
                
                        if (recControl.KullaniciAdi.Text != "") {
                            rec.Parse(recControl.KullaniciAdi.Text, IKKullanicilarTable.KullaniciAdi);
                  }
                
                        if (recControl.OlusturmaTarihi.Text != "") {
                            rec.Parse(recControl.OlusturmaTarihi.Text, IKKullanicilarTable.OlusturmaTarihi);
                  }
                
                        if (recControl.OlusturanID.Text != "") {
                            rec.Parse(recControl.OlusturanID.Text, IKKullanicilarTable.OlusturanID);
                  }
                
                        if (recControl.DuzenlenmeTarihi.Text != "") {
                            rec.Parse(recControl.DuzenlenmeTarihi.Text, IKKullanicilarTable.DuzenlenmeTarihi);
                  }
                
                        if (recControl.DuzenleyenID.Text != "") {
                            rec.Parse(recControl.DuzenleyenID.Text, IKKullanicilarTable.DuzenleyenID);
                  }
                
                        if (recControl.AktifPasif.Text != "") {
                            rec.Parse(recControl.AktifPasif.Text, IKKullanicilarTable.AktifPasif);
                  }
                
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new IKKullanicilarRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (IKKullanicilarRecord[])(finalList.ToArray(Type.GetType("KumePortali.Business.IKKullanicilarRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(IKKullanicilarTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(IKKullanicilarTableControlRow rec)            
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
        
        // Get the filters' data for UnvanIDFilter.
                
        protected virtual void PopulateUnvanIDFilter(string selectedValue, int maxItems)
                    
        {
              
            //Setup the WHERE clause.
            WhereClause wc = new WhereClause();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(IKUnvanlarTable.UnvanAdi, OrderByItem.OrderDir.Asc);

            string noValueFormat = Page.GetResourceValue("Txt:Other", "KumePortali");

            this.UnvanIDFilter.Items.Clear();
            foreach (IKUnvanlarRecord itemValue in IKUnvanlarTable.GetRecords(wc, orderBy, 0, maxItems))
            {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = noValueFormat;
                if (itemValue.UnvanIDSpecified) {
                    cvalue = itemValue.UnvanID.ToString();
                    fvalue = itemValue.Format(IKUnvanlarTable.UnvanAdi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                if (this.UnvanIDFilter.Items.IndexOf(item) < 0) {
                    this.UnvanIDFilter.Items.Add(item);
                }
            }
                
            // Set the selected value.
            MiscUtils.SetSelectedValue(this.UnvanIDFilter, selectedValue);

            // Add the All item.
            this.UnvanIDFilter.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:All", "KumePortali"), "--ANY--"));
                
        }
            
        // Get the filters' data for FirmaIDFilter.
                
        protected virtual void PopulateFirmaIDFilter(string selectedValue, int maxItems)
                    
        {
              
            //Setup the WHERE clause.
            WhereClause wc = new WhereClause();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MIYSAHesaplarTable.FirmaAdi, OrderByItem.OrderDir.Asc);

            string noValueFormat = Page.GetResourceValue("Txt:Other", "KumePortali");

            this.FirmaIDFilter.Items.Clear();
            foreach (MIYSAHesaplarRecord itemValue in MIYSAHesaplarTable.GetRecords(wc, orderBy, 0, maxItems))
            {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = noValueFormat;
                if (itemValue.HesapIDSpecified) {
                    cvalue = itemValue.HesapID.ToString();
                    fvalue = itemValue.Format(MIYSAHesaplarTable.FirmaAdi);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                if (this.FirmaIDFilter.Items.IndexOf(item) < 0) {
                    this.FirmaIDFilter.Items.Add(item);
                }
            }
                
            // Set the selected value.
            MiscUtils.SetSelectedValue(this.FirmaIDFilter, selectedValue);

            // Add the All item.
            this.FirmaIDFilter.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:All", "KumePortali"), "--ANY--"));
                
        }
                          
        // Create a where clause for the filter IKKullanicilarSearchArea.
        public virtual WhereClause CreateWhereClause_IKKullanicilarSearchArea()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.UnvanIDFilter)) {
                        
                wc.iAND(IKKullanicilarTable.UnvanID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.UnvanIDFilter, this.GetFromSession(this.UnvanIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.FirmaIDFilter)) {
                        
                wc.iAND(IKKullanicilarTable.FirmaID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.FirmaIDFilter, this.GetFromSession(this.FirmaIDFilter)), false, false);
                    
            }
                      
            return wc;
        }
                          
        // Create a where clause for the filter UnvanIDFilter.
        public virtual WhereClause CreateWhereClause_UnvanIDFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.IKKullanicilarSearchArea)) {
                // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (this.IKKullanicilarSearchArea.Text.StartsWith("...")) {
                    this.IKKullanicilarSearchArea.Text = this.IKKullanicilarSearchArea.Text.Substring(3,this.IKKullanicilarSearchArea.Text.Length-3);
                }
                if (this.IKKullanicilarSearchArea.Text.EndsWith("...")) {
                    this.IKKullanicilarSearchArea.Text = this.IKKullanicilarSearchArea.Text.Substring(0,this.IKKullanicilarSearchArea.Text.Length-3);
                }
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.IKKullanicilarSearchArea)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    WhereClause search = new WhereClause();
                    
                    search.iOR(IKKullanicilarTable.Adi, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.IKKullanicilarSearchArea, this.GetFromSession(this.IKKullanicilarSearchArea)), true, false);
        
                    search.iOR(IKKullanicilarTable.Soyadi, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.IKKullanicilarSearchArea, this.GetFromSession(this.IKKullanicilarSearchArea)), true, false);
        
                    wc.iAND(search);
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.FirmaIDFilter)) {
                        
                wc.iAND(IKKullanicilarTable.FirmaID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.FirmaIDFilter, this.GetFromSession(this.FirmaIDFilter)), false, false);
                    
            }
                      
            return wc;
        }
                          
        // Create a where clause for the filter FirmaIDFilter.
        public virtual WhereClause CreateWhereClause_FirmaIDFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.IKKullanicilarSearchArea)) {
                // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (this.IKKullanicilarSearchArea.Text.StartsWith("...")) {
                    this.IKKullanicilarSearchArea.Text = this.IKKullanicilarSearchArea.Text.Substring(3,this.IKKullanicilarSearchArea.Text.Length-3);
                }
                if (this.IKKullanicilarSearchArea.Text.EndsWith("...")) {
                    this.IKKullanicilarSearchArea.Text = this.IKKullanicilarSearchArea.Text.Substring(0,this.IKKullanicilarSearchArea.Text.Length-3);
                }
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.IKKullanicilarSearchArea)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    WhereClause search = new WhereClause();
                    
                    search.iOR(IKKullanicilarTable.Adi, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.IKKullanicilarSearchArea, this.GetFromSession(this.IKKullanicilarSearchArea)), true, false);
        
                    search.iOR(IKKullanicilarTable.Soyadi, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.IKKullanicilarSearchArea, this.GetFromSession(this.IKKullanicilarSearchArea)), true, false);
        
                    wc.iAND(search);
                }
            }
                  
            if (MiscUtils.IsValueSelected(this.UnvanIDFilter)) {
                        
                wc.iAND(IKKullanicilarTable.UnvanID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.UnvanIDFilter, this.GetFromSession(this.UnvanIDFilter)), false, false);
                    
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
        
            this.SaveToSession(this.IKKullanicilarSearchArea, this.IKKullanicilarSearchArea.Text);
                  
            this.SaveToSession(this.UnvanIDFilter, this.UnvanIDFilter.SelectedValue);
                  
            this.SaveToSession(this.FirmaIDFilter, this.FirmaIDFilter.SelectedValue);
                  
            
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
          
            this.SaveToSession("IKKullanicilarSearchArea_Ajax", this.IKKullanicilarSearchArea.Text);
            this.SaveToSession("UnvanIDFilter_Ajax", this.UnvanIDFilter.SelectedValue);
            this.SaveToSession("FirmaIDFilter_Ajax", this.FirmaIDFilter.SelectedValue);
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.IKKullanicilarSearchArea);
            this.RemoveFromSession(this.UnvanIDFilter);
            this.RemoveFromSession(this.FirmaIDFilter);
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["IKKullanicilarTableControl_OrderBy"];
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
                this.ViewState["IKKullanicilarTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void IKKullanicilarPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void IKKullanicilarPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void IKKullanicilarPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void IKKullanicilarPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
        
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.IKKullanicilarPagination.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.IKKullanicilarPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void IKKullanicilarPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void AdiLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.Adi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.Adi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void SoyadiLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.Soyadi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.Soyadi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void EpostaLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.Eposta);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.Eposta, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void GSMLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.GSM);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.GSM, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void FirmaIDLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.FirmaID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.FirmaID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void UnvanIDLabel1_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.UnvanID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.UnvanID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void YetkiTurIDLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.YetkiTurID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.YetkiTurID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void HesapIDLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.HesapID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.HesapID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void TCKimlikNoLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.TCKimlikNo);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.TCKimlikNo, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void IsTelefonuLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.IsTelefonu);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.IsTelefonu, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void KullaniciAdiLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.KullaniciAdi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.KullaniciAdi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void OlusturmaTarihiLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.OlusturmaTarihi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.OlusturmaTarihi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void OlusturanIDLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.OlusturanID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.OlusturanID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void DuzenlenmeTarihiLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.DuzenlenmeTarihi);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.DuzenlenmeTarihi, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void DuzenleyenIDLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.DuzenleyenID);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.DuzenleyenID, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            
        // event handler for FieldSort
        public virtual void AktifPasifLabel_Click(object sender, EventArgs args)
        {
              
            OrderByItem sd = this.CurrentSortOrder.Find(IKKullanicilarTable.AktifPasif);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(IKKullanicilarTable.AktifPasif, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void IKKullanicilarNewButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void IKKullanicilarDeleteButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void IKKullanicilarExportExcelButton_Click(object sender, ImageClickEventArgs args)
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
            ExportData excelReport = new ExportData(IKKullanicilarTable.Instance, wc, orderBy);
            // Add each of the columns in order of export.
            // To customize the data type, change the second parameter of the new ExcelColumn to be
            // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.Adi, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.Soyadi, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.Eposta, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.GSM, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.FirmaID, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.UnvanID, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.YetkiTurID, @"0"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.HesapID, @"0"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.TCKimlikNo, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.IsTelefonu, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.KullaniciAdi, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.OlusturmaTarihi, @"Short Date"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.OlusturanID, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.DuzenlenmeTarihi, @"Short Date"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.DuzenleyenID, @"Default"));
             excelReport.AddColumn(new ExcelColumn(IKKullanicilarTable.AktifPasif, @"Default"));

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
        public virtual void IKKullanicilarRefreshButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
            ((IKKullanicilarTableControl)(this.Page.FindControlRecursively("IKKullanicilarTableControl"))).ResetData = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          
            } finally {
    
            }
    
        }
            
        // event handler for ImageButton
        public virtual void IKKullanicilarResetButton_Click(object sender, ImageClickEventArgs args)
        {
        
            try {
                
              this.UnvanIDFilter.ClearSelection();
            
              this.FirmaIDFilter.ClearSelection();
            
              this.IKKullanicilarSearchArea.Text = "";
            
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
        public virtual void IKKullanicilarSearchButton_Click(object sender, EventArgs args)
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
        protected virtual void UnvanIDFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            this.DataChanged = true;
        }
            
        // event handler for FieldFilter
        protected virtual void FirmaIDFilter_SelectedIndexChanged(object sender, EventArgs args)
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

        private IKKullanicilarRecord[] _DataSource = null;
        public  IKKullanicilarRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal IKKullanicilarTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarTitle");
            }
        }
        
        public System.Web.UI.WebControls.Label IKKullanicilarTotalItems {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarTotalItems");
            }
        }
        
        public System.Web.UI.WebControls.TextBox IKKullanicilarSearchArea {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarSearchArea");
            }
        }
        
        public KumePortali.UI.IThemeButton IKKullanicilarSearchButton {
            get {
                return (KumePortali.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarSearchButton");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList UnvanIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal UnvanIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList FirmaIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirmaIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaIDLabel");
            }
        }
        
        public KumePortali.UI.IPagination IKKullanicilarPagination {
            get {
                return (KumePortali.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarNewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarNewButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarExportExcelButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarRefreshButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarRefreshButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton IKKullanicilarResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarResetButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox IKKullanicilarToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IKKullanicilarToggleAll");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AdiLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AdiLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton SoyadiLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SoyadiLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton EpostaLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "EpostaLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton GSMLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "GSMLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FirmaIDLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirmaIDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton UnvanIDLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UnvanIDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton YetkiTurIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YetkiTurIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton HesapIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "HesapIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TCKimlikNoLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TCKimlikNoLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton IsTelefonuLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IsTelefonuLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton KullaniciAdiLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "KullaniciAdiLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OlusturmaTarihiLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturmaTarihiLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OlusturanIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OlusturanIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DuzenlenmeTarihiLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenlenmeTarihiLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DuzenleyenIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DuzenleyenIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton AktifPasifLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "AktifPasifLabel");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                IKKullanicilarTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
                }

                IKKullanicilarRecord rec = null;
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
            foreach (IKKullanicilarTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.IKKullanicilarRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public IKKullanicilarTableControlRow GetSelectedRecordControl()
        {
        IKKullanicilarTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public IKKullanicilarTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (IKKullanicilarTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.IKKullanicilarRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (IKKullanicilarTableControlRow[])(selectedList.ToArray(Type.GetType("KumePortali.UI.Controls.ShowIKKullanicilarTablePage.IKKullanicilarTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            IKKullanicilarTableControlRow[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "KumePortali"));
            }
            
            foreach (IKKullanicilarTableControlRow recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.IKKullanicilarRecordRowSelection.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public IKKullanicilarTableControlRow[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("IKKullanicilarTableControlRepeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                IKKullanicilarTableControlRow recControl = (IKKullanicilarTableControlRow)repItem.FindControl("IKKullanicilarTableControlRow");
                recList.Add(recControl);
            }

            return (IKKullanicilarTableControlRow[])recList.ToArray(Type.GetType("KumePortali.UI.Controls.ShowIKKullanicilarTablePage.IKKullanicilarTableControlRow"));
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

  