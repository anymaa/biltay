
// This file implements the code-behind class for SelectFileToImport.aspx.
// App_Code\FirstPage.Controls.vb contains the Table, Row and Record control classes
// for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#region "Using statements"    

using System;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using BaseClasses.Web.UI.WebControls;
        
using KumePortali.Business;
using KumePortali.Data;
        

#endregion

  
namespace KumePortali.UI
{
  
partial class SelectFileToImport
        : BaseApplicationPage
// Code-behind class for the SelectFileToImport page.
// Place your customizations in Section 1. Do not modify Section 2.
{
        


#region "Section 1: Place your customizations here."    

        public SelectFileToImport()
        {
            this.Initialize();
            this.Page.Title = this.GetResourceValue("Import:Step1", this.AppName);
        }

        public void LoadData()
        {
            // LoadData reads database data and assigns it to UI controls.
            // Customize by adding code before or after the call to LoadData_Base()
            // or replace the call to LoadData_Base().
            LoadData_Base();
            this.InfoLabel.Text = this.GetResourceValue("Import:InfoText", this.AppName);
           

        }
    public string AppName
    {
        get
        {
            return BaseClasses.Configuration.ApplicationSettings.Current.GetAppSetting(BaseClasses.Configuration.ApplicationSettings.ConfigurationKey.ApplicationName);
        }
    }
    public  string TableName
    {
        get
        {
            return this.Decrypt(BaseClasses.Utils.NetUtils.GetUrlParam(this,"TableName" , true));
        }
    }
#region "Ajax Functions"

        [System.Web.Services.WebMethod()]
        public static Object[] GetRecordFieldValue(String tableName , 
                                                    String recordID , 
                                                    String columnName, 
                                                    String title, 
                                                    bool persist, 
                                                    int popupWindowHeight, 
                                                    int popupWindowWidth, 
                                                    bool popupWindowScrollBar)
        {
            // GetRecordFieldValue gets the pop up window content from the column specified by
            // columnName in the record specified by the recordID in data base table specified by tableName.
            // Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            // or replace the call to  GetRecordFieldValue_Base().

            return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar);
        }

        [System.Web.Services.WebMethod()]
        public static object[] GetImage(String tableName,
                                        String recordID, 
                                        String columnName, 
                                        String title, 
                                        bool persist, 
                                        int popupWindowHeight, 
                                        int popupWindowWidth, 
                                        bool popupWindowScrollBar)
        {
            // GetImage gets the Image url for the image in the column "columnName" and
            // in the record specified by recordID in data base table specified by tableName.
            // Customize by adding code before or after the call to  GetImage_Base()
            // or replace the call to  GetImage_Base().
            return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar);
        }
        
    

    
#endregion

    // Page Event Handlers - buttons, sort, links
    public void NextButton_Click(object sender, EventArgs args)
    {
        NextButton_Click_Base(sender, args);
    }

    
#endregion

#region "Section 2: Do not modify this section."

      
        private void Initialize()
        {
            // Called by the class constructor to initialize event handlers for Init and Load
            // You can customize by modifying the constructor in Section 1.
            this.Init += new EventHandler(Page_InitializeEventHandlers);
            this.Load += new EventHandler(Page_Load);

            
        }

        // Handles base.Init. Registers event handler for any button, sort or links.
        // You can add additional Init handlers in Section 1.
        protected virtual void Page_InitializeEventHandlers(object sender, System.EventArgs e)
        {
            // Register the Event handler for any Events.
        
             
              this.NextButton.Button.Click += new EventHandler(NextButton_Click);
             
        }

        // Handles base.Load.  Read database data and put into the UI controls.
        // You can add additional Load handlers in Section 1.
        protected virtual void Page_Load(object sender, EventArgs e)
        {
        
            // Check if user has access to this page.  Redirects to either sign-in page
            // or 'no access' page if not. Does not do anything if role-based security
            // is not turned on, but you can override to add your own security.
            this.Authorize(this.GetAuthorizedRoles());
                // Load data only when displaying the page for the first time
            if ((!this.IsPostBack)) {   
        
                // Setup the header text for the validation summary control.
                this.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", this.AppName);
             

        // Read the data for all controls on the page.
        // To change the behavior, override the DataBind method for the individual
        // record or table UI controls.
        this.LoadData();
        
    }
    }

    public static object[] GetRecordFieldValue_Base(String tableName , 
                                                    String recordID , 
                                                    String columnName, 
                                                    String title, 
                                                    bool persist, 
                                                    int popupWindowHeight, 
                                                    int popupWindowWidth, 
                                                    bool popupWindowScrollBar)
    {
        string content =  NetUtils.EncodeStringForHtmlDisplay(BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)) ;
        // returnValue is an array of string values.
        // returnValue(0) represents title of the pop up window.
        // returnValue(1) represents content ie, image url.
        // returnValue(2) represents whether pop up window should be made persistant
        // or it should close as soon as mouse moves out.
        // returnValue(3), (4) represents pop up window height and width respectivly
        // returnValue(5) represents whether pop up window should contain scroll bar.
        // (0),(2),(3) and (4) is initially set as pass through attribute.
        // They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        object[] returnValue = new object[6];
        returnValue[0] = title;
        returnValue[1] = content;
        returnValue[2] = persist;
        returnValue[3] = popupWindowWidth;
        returnValue[4] = popupWindowHeight;
        returnValue[5] = popupWindowScrollBar;
        return returnValue;
    }

    public static object[] GetImage_Base(String tableName, 
                                          String recordID, 
                                          String columnName, 
                                          String title, 
                                          bool persist, 
                                          int popupWindowHeight, 
                                          int popupWindowWidth, 
                                          bool popupWindowScrollBar)
    {
        string  content= "<IMG src =" + "\"../Shared/ExportFieldValue.aspx?Table=" + tableName + "&Field=" + columnName + "&Record=" + recordID + "\"/>";
        // returnValue is an array of string values.
        // returnValue(0) represents title of the pop up window.
        // returnValue(1) represents content ie, image url.
        // returnValue(2) represents whether pop up window should be made persistant
        // or it should close as soon as mouse moves out.
        // returnValue(3), (4) represents pop up window height and width respectivly
        // returnValue(5) represents whether pop up window should contain scroll bar.
        // (0),(2),(3), (4) and (5) is initially set as pass through attribute.
        // They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        object[] returnValue = new object[6];
        returnValue[0] = title;
        returnValue[1] = content;
        returnValue[2] = persist;
        returnValue[3] = popupWindowWidth;
        returnValue[4] = popupWindowHeight;
        returnValue[5] = popupWindowScrollBar;
        return returnValue;
    }
  

    // Load data from database into UI controls.
    // Modify LoadData in Section 1 above to customize.  Or override DataBind() in
    // the individual table and record controls to customize.
    public void LoadData_Base()
    {
        
        
        }

        // Write out event methods for the page events
        
        
            
        // event handler for Button with Layout
        public void NextButton_Click_Base(object sender, EventArgs args)
        {
            System.Web.UI.HtmlControls.HtmlInputFile inputFile;
            inputFile = ((System.Web.UI.HtmlControls.HtmlInputFile)(this.Page.FindControl("inputFile")));
            String tmpPath = String.Empty;  
            try {
               
                if ((!(inputFile.PostedFile == null) && (inputFile.PostedFile.ContentLength > 0)))
                {
                    if (IsFileTypeSupported(inputFile.PostedFile.FileName))
                    {
                        try
                        {
                            tmpPath = System.IO.Path.GetTempFileName();
                            this.Page.Session["FilePath"] = tmpPath;
                            inputFile.PostedFile.SaveAs(tmpPath);
                        }
                        catch
                        {
                            string tempDir = AppDomain.CurrentDomain.BaseDirectory + "~temp";
                            try
                            {
                                if (!Directory.Exists(tempDir))
                                    Directory.CreateDirectory(tempDir);
                            }
                            catch (Exception ex)
                            {
                                if (Directory.Exists(tempDir))
                                    throw new Exception("Fail to create " + tempDir + ".  " + ex.Message);
                            }
                            try
                            {
                                DirectoryInfo info = new DirectoryInfo(tempDir);
                                info.Attributes = FileAttributes.Hidden;
                            }
                            catch 
                            {
                                //do nothing
                            }
                           

                        }
                        this.Page.Response.Redirect("ImportData.aspx?TableName=" + this.Encrypt(this.TableName)); // pass the table name with encryption.    
                    }
                    else
                    {
                        BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", this.GetResourceValue("Import:ValidFileMsg", this.AppName));
                    }
                }
                else
                {
                    BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", this.GetResourceValue("Import:SelectFile", this.AppName));
                }
            } catch (Exception ex) {
                this.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
        }
            
       
            
#endregion

  
}
  
}
  