
// This file implements the code-behind class for SetLanguagePage.aspx.
// App_Code\SetLanguagePage.Controls.vb contains the Table, Row and Record control classes
// for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#region "Using statements"    

using System;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Web;
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
  
partial class SetLanguagePage
        : BaseApplicationPage
// Code-behind class for the SetLanguagePage page.
// Place your customizations in Section 1. Do not modify Section 2.
{
        


#region "Section 1: Place your customizations here."    

        public SetLanguagePage()
      {
      this.Initialize();
      }

      public void LoadData()
      {
      // LoadData reads database data and assigns it to UI controls.
      // Customize by adding code before or after the call to LoadData_Base()
      // or replace the call to LoadData_Base().
      LoadData_Base();
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
    

#endregion

#region "Section 2: Do not modify this section."

      
        private void Initialize()
        {
            // Called by the class constructor to initialize event handlers for Init and Load
            // You can customize by modifying the constructor in Section 1.
            this.Init += new EventHandler(Page_InitializeEventHandlers);
            this.Load += new EventHandler(Page_Load);

            
      base.Load += new System.EventHandler(this.MyPage_Load);
      this.Init +=new EventHandler(MyPage_Init);
    
        }

        // Handles base.Init. Registers event handler for any button, sort or links.
        // You can add additional Init handlers in Section 1.
        protected virtual void Page_InitializeEventHandlers(object sender, System.EventArgs e)
        {
            // Register the Event handler for any Events.
        
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
                this.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "KumePortali");
             

      // Read the data for all controls on the page.
      // To change the behavior, override the DataBind method for the individual
      // record or table UI controls.
      this.LoadData();
      }
      else if ( this.Request["__EVENTTARGET"] == "ChildWindowPostBack")
      {
      try {

      // Must start a transaction before performing database operations
      DbUtils.StartTransaction();

      // Load data for each record and table UI control.
      // Ordering is important because child controls get
      // their parent ids from their parent UI controls.
      

      this.DataBind();

      

      } catch (Exception ex)
      {
      // An error has occured so display an error message.
      BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "Page_Load_Error_Message", ex.Message);
      }
      finally
      {
      // End database transaction
      DbUtils.EndTransaction();
      }

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
    
            try {
                // Load data only when displaying the page for the first time
                if ((!this.IsPostBack)) {

                    // Must start a transaction before performing database operations
                    DbUtils.StartTransaction();

                    // Load data for each record and table UI control.
                    // Ordering is important because child controls get 
                    // their parent ids from their parent UI controls.
        
                
                    this.DataBind();
                    
        
                }
            } catch (Exception ex) {
                // An error has occured so display an error message.
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "Page_Load_Error_Message", ex.Message);
            } finally {
                if (!this.IsPostBack) {
                    // End database transaction
                    DbUtils.EndTransaction();
                }
            }
      
        }

        // Write out event methods for the page events
        
    
  
    private void MyPage_Init(object sender, System.EventArgs e)
    {
     this.Button.Button.Click += new EventHandler(Custom_Button_Click);
    }

    private void MyPage_Load(object sender, System.EventArgs e)
    {
     string resourceDir = "bin";
     string resourcePath = this.Request.PhysicalApplicationPath + resourceDir + "\\";
     if (System.IO.Directory.Exists(resourcePath)) {
       string[] resourceFiles = System.IO.Directory.GetFiles(resourcePath, "*.*.resx");
       SortedList sortedLangList = new SortedList();
       foreach (string resourceFile in resourceFiles) {
         System.IO.FileInfo finfo = new System.IO.FileInfo(resourceFile);
         string fileName = finfo.Name;
         string splitBy = ".";
         string[] namePieces = fileName.Split(splitBy.ToCharArray());
         int length = namePieces.Length;
         int index = length - 2;
         string cultureName = namePieces[index];
         System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo(cultureName);
         if (!(sortedLangList.ContainsKey(cultureInfo.DisplayName))) {
           sortedLangList.Add(cultureInfo.DisplayName, cultureInfo.Name);
         }
       }
       string val;
       foreach (string key in sortedLangList.Keys) {
         val = ((string)(sortedLangList[key]));
         ListItem li = new ListItem(key, val);
         if (!(this.LanguageBox.Items.Contains(li))) {
           this.LanguageBox.Items.Add(li);
           if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == val) {
             li.Selected = true;
           }
         }
       }
     }
    }

    public void Custom_Button_Click(object sender, EventArgs e)
    {
     try {
       System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(this.LanguageBox.SelectedItem.Value);
       Session["AppCultureUI"] = this.LanguageBox.SelectedItem.Value;
     } catch  {
     }
     string url = "../default.aspx";
     this.Response.Redirect(url);
    }
    
    


#endregion

  
}
  
}
  