
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

  // Code-behind class for the Header user control.
partial class Header : BaseApplicationUserControl , IHeader
{
        


#region "Section 1: Place your customizations here."    

        public Header()
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
    
        public void SignInBarSetLanguageButton_Click(object sender, ImageClickEventArgs args)
        {
            
          // Click handler for SignInBarSetLanguageButton.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          SignInBarSetLanguageButton_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
        }
        
        public void SIOImage_Click(object sender, ImageClickEventArgs args)
        {
            
          // Click handler for SIOImage.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          SIOImage_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
        }
        
        public void SignIn_Click(object sender, EventArgs args)
        {
            
          // Click handler for SignIn.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          SignIn_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
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
        
              this.SIOImage.Click += new ImageClickEventHandler(SIOImage_Click);
              this.SignInBarSetLanguageButton.Click += new ImageClickEventHandler(SignInBarSetLanguageButton_Click);
              this.SignIn.Click += new EventHandler(SignIn_Click);
            
        }

        // Handles base.Load.  Read database data and put into the UI controls.
        // You can add additional Load handlers in Section 1.
        protected virtual void Page_Load(object sender, EventArgs e)
        {
        
            this.UserStatusInit(); 
            this.PrintButtonInit(); 
            this.SignInButtonInit(); 
            this.SignInBarLanguageButtonInit(); 
            this._SkipNavigationLinks.Visible = false; 
                // Load data only when displaying the page for the first time
            if ((!this.IsPostBack)) {   
        
          this._SkipNavigationLinks.NavigateUrl = this.Page.AppRelativeVirtualPath + this._SkipNavigationLinks.NavigateUrl; 
        

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
  
      //Initializes Sign In status text.
      protected virtual void UserStatusInit() {
      
        switch (((BaseApplicationPage)(this.Page)).CurrentSecurity.GetUserStatus()){
        case null:
        case "":
          this._UserStatusLbl.Text = GetResourceValue("Txt:UserNotSignedIn", "KumePortali");
        break;
        default:
          this._UserStatusLbl.Text = GetResourceValue("Txt:Hello", "KumePortali");
          this._UserStatusLbl.Text = (this._UserStatusLbl.Text + ((BaseApplicationPage)(this.Page)).CurrentSecurity.GetUserStatus());
        break;
        }
      
      }
    
      //Initializes Print button.
      private void PrintButtonInit() {
      
        this._SignInBarPrintButton.Visible = false;
        this._Divider3.Visible = false; 
      }
    
      //Initializes Select language button.
      protected virtual void SignInBarLanguageButtonInit() {
           
        this._SignInBarSetLanguageButton.Visible = false;
        this._SignInBarSetLanguageButton.Enabled = false;
        this._Divider1.Visible = false; 
      }
    
      //Initializes Sign In LinkButton.
      protected virtual void SignInButtonInit(){
      
        this._UserStatusLbl.Visible = false; 
        this._SIOImage.Visible = false; 
        this._SignIn.Visible = false;
        this._Divider2.Visible = false; 
        switch (((BaseApplicationPage)(this.Page)).CurrentSecurity.GetUserStatus()) {
          case null:
          case "":
          
            this._SignIn.Text = GetResourceValue("Txt:SignIn", "KumePortali");
            this._SignIn.ToolTip = GetResourceValue("Txt:SignIn", "KumePortali"); 
            this._SIOImage.ImageUrl = "../Images/SignInBarSignIn.gif";
            this._SIOImage.Attributes.Add("onmouseover", "this.src='../Images/SignInBarSignInOver.gif'");
            this._SIOImage.Attributes.Add("onmouseout", "this.src='../Images/SignInBarSignIn.gif'");
            this._SIOImage.ToolTip = GetResourceValue("Txt:SignIn", "KumePortali"); 
            break;
          default:
          
            this._SignIn.Text = GetResourceValue("Txt:SignOut", "KumePortali");
            this._SignIn.ToolTip = GetResourceValue("Txt:SignOut", "KumePortali"); 
            this._SIOImage.ImageUrl = "../Images/SignInBarSignOut.gif";
            this._SIOImage.Attributes.Add("onmouseover", "this.src='../Images/SignInBarSignOutOver.gif'");
            this._SIOImage.Attributes.Add("onmouseout", "this.src='../Images/SignInBarSignOut.gif'");
            this._SIOImage.ToolTip = GetResourceValue("Txt:SignOut", "KumePortali"); 
            break;
        }
      }
      //Performs SignIn and SignOut.
      protected virtual void SignInOutProceed(object sender)
      {
        string url;
        bool shouldRedirect;
        
        switch (((BaseApplicationPage)(this.Page)).CurrentSecurity.GetUserStatus())
        {
          case null:
          case "":
            url = BaseClasses.Configuration.ApplicationSettings.Current.SignInPageUrl;           
            url = ".." + url.Substring(BaseClasses.Configuration.ApplicationSettings.Current.AppRootPath.Length-1);
            shouldRedirect = true;
            try
            {
              DbUtils.StartTransaction();
              url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "", false);
              ((BaseApplicationPage)this.Page).CommitTransaction(sender);
            }
            catch (Exception ex)
            {
              ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
              shouldRedirect = false;
              ((BaseApplicationPage)this.Page).ErrorOnPage = true;
              BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            }
            finally
            {
              DbUtils.EndTransaction();
            }
            
            if (shouldRedirect)
            {
              ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
            break;
            
          default:
          url = BaseClasses.Configuration.ApplicationSettings.Current.SignedOutPageUrl;
          url = ".." + url.Substring(BaseClasses.Configuration.ApplicationSettings.Current.AppRootPath.Length-1);
          shouldRedirect = true;
          try
          {
            DbUtils.StartTransaction();
            ((BaseApplicationPage)(this.Page)).CurrentSecurity.Logout((BaseApplicationPage)(this.Page));
            url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "", false);
            ((BaseApplicationPage)this.Page).CommitTransaction(sender);
          }
          catch (Exception ex)
          {
            ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
            shouldRedirect = false;
            ((BaseApplicationPage)this.Page).ErrorOnPage = true;
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
          }
          finally
          {
            DbUtils.EndTransaction();
          }
          
          if (shouldRedirect)
          {
            ((BaseApplicationPage)this.Page).ShouldSaveControlsToSession = true;
            ((BaseApplicationPage)this.Page).Response.Redirect(url);
          }
          break;
        }
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
        
        // event handler for ImageButton
        public void SIOImage_Click_Base(object sender, ImageClickEventArgs args)
        {
        
              this.SignInOutProceed(sender);
                
        }
            
        // event handler for ImageButton
        public void SignInBarSetLanguageButton_Click_Base(object sender, ImageClickEventArgs args)
        {
        
              //do nothing because click is handled by Java code in control itself
                
        }
            
        // event handler for LinkButton
        public void SignIn_Click_Base(object sender, EventArgs args)
        {
        
              this.SignInOutProceed(sender);
              
        }
            
#region Interface Properties
          
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Image Divider1 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_Divider1");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Image Divider2 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_Divider2");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Image Divider3 {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_Divider3");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Image LeftImage {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_LeftImage");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Image PageHeader__Logo {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_PageHeader__Logo");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.ImageButton SIOImage {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_SIOImage");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.LinkButton SignIn {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_SignIn");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Image SignInBarPrintButton {
            get {
                return (System.Web.UI.WebControls.Image)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_SignInBarPrintButton");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.ImageButton SignInBarSetLanguageButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_SignInBarSetLanguageButton");
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public System.Web.UI.WebControls.Label UserStatusLbl {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "_UserStatusLbl");
            }
        }
                
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

  