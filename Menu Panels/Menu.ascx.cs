
using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Web.UI;
using BaseClasses.Web.UI.WebControls;
        
using KumePortali.Business;
using KumePortali.Data;
        
namespace KumePortali.UI
{

  // Code-behind class for the Menu user control.
partial class Menu : BaseApplicationMenuControl , IMenu
{
        


#region "Section 1: Place your customizations here."    

        public Menu()
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
     

      
          public void ModifyMenuItem(object sender, MenuEventArgs e)
          {
          ModifyMenuItem_Base(sender, e);
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

            
        }

        // Handles base.Init. Registers event handler for any button, sort or links.
        // You can add additional Init handlers in Section 1.
        protected virtual void Page_InitializeEventHandlers(object sender, System.EventArgs e)
        {
            // Register the Event handler for any Events.
        
            // Add handler for Menu item data bound event
            MultiLevelMenu.MenuItemDataBound += new MenuEventHandler(ModifyMenuItem);
        
        }

        // Handles base.Load.  Read database data and put into the UI controls.
        // You can add additional Load handlers in Section 1.
        protected virtual void Page_Load(object sender, EventArgs e)
        {
        
                // Load data only when displaying the page for the first time
            if ((!this.IsPostBack)) {   
        

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
  
    public void ModifyMenuItem_Base(object sender, MenuEventArgs e)
    {
        // Retrieve menu item's text and tool tip value from RESX file.
        e.Item.Text=ReplaceTextWithResourceValue(e.Item.Text);
        e.Item.ToolTip = ReplaceTextWithResourceValue(e.Item.ToolTip);
        // If imageUrl is specified in the sitemap node then, display image next to menu item.
        String imageUrl=((System.Web.SiteMapNode)e.Item.DataItem)["imageUrl"];
        if (imageUrl !=null && !imageUrl.Trim().Equals("")){
                  e.Item.ImageUrl = imageUrl;
        }
    }
    
     private String ReplaceTextWithResourceValue(String value)
    {
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("{");        
        // Check if a part of value is surrounded with {} eg: {Menu:Add}
        while (regex.IsMatch(value))
        {
            int startIndex = regex.Match(value).Index + regex.Match(value).Length;
            if (System.Text.RegularExpressions.Regex.IsMatch(value, "}"))
            {
                int endIndex = System.Text.RegularExpressions.Regex.Match(value, "}").Index;
                string textToLookUp = value.Substring(startIndex, endIndex - startIndex);
                // Replace text including {} with value retreived from resex file
                value = value.Replace(value.Substring(startIndex - 1, endIndex - startIndex + 2), GetResourceValue(textToLookUp, "KumePortali"));
            }
        }
        return value;
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
        
#region Interface Properties
          
      public override bool Visible {
          get {
              return base.Visible;
          }
          set {
              base.Visible = value;
          }
      }
            
#endregion
    
#endregion

  

}
  
}

  