using System;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using BaseClasses.Web.UI.WebControls;
using KumePortali.Business;
using KumePortali.Data;

namespace KumePortali.UI
{

    // Code-behind class for the LargeListSelector page.
    // Place your customizations in Section 1. Do not modify Section 2.
    partial class LargeListSelector : BaseApplicationPage
    {

#region "Section 1: Place your customizations here."

        public LargeListSelector()
        {
            this.IsUpdatesSessionNavigationHistory = false;
            this.Load += new EventHandler(Page_Load);
        }

        // LoadData reads database data and assigns it to UI controls.
        // Customize by adding code before or after the call to LoadData_Base()
        // or replace the call to LoadData_Base().
        public void LoadData()
        {
            LoadData_Base();
        }
        
#region "Ajax Functions"

        [System.Web.Services.WebMethod()]
	public static string[] GetAutoCompletionList_StartsWith(string prefixText, int count) 
	{ 
	    // GetEmployeesSearchAreaCompletionList gets the list of suggestions from the database. 
	    // prefixText is the search text typed by the user . 
	    // count specifies the number of suggestions to be returned. 
	    // Customize by adding code before or after the call to GetAutoCompletionList_EmployeesSearchArea() 
	    // or replace the call to GetAutoCompletionList_EmployeesSearchArea(). 
	    return GetAutoCompletionList_Base(prefixText, null, count); 
	} 


        [System.Web.Services.WebMethod()]
	public static string[] GetAutoCompletionList_Contains(string prefixText, int count) 
	{ 
	    // GetEmployeesSearchAreaCompletionList gets the list of suggestions from the database. 
	    // prefixText is the search text typed by the user . 
	    // count specifies the number of suggestions to be returned. 
	    // Customize by adding code before or after the call to GetAutoCompletionList_EmployeesSearchArea() 
	    // or replace the call to GetAutoCompletionList_EmployeesSearchArea(). 
	    return GetAutoCompletionList_Base(null, prefixText, count); 
	} 

#endregion

#endregion

#region "Section 2: Do not modify this section."

        // Handles MyBase.Load.  If you need to, you can add additional Load handlers in Section 1.
        // Read database data and put into the UI controls.
        protected virtual void Page_Load(System.Object sender, System.EventArgs e)
        {
            // Load data only when displaying the page for the first time
            if (!this.IsPostBack)
            {

                // Check if user has access to this page.  Redirects to either sign-in page 
                // or 'no access' page if not. Does not do anything if role-based security 
                // is not turned on, but you can override to add your own security.
                this.Authorize(this.GetAuthorizedRoles());

                // Read the data for all controls on the page.
                // To change the behavior, override the DataBind method for the individual
                // record or table UI controls.
                this.LoadData();
            }
        }


	public static string[] GetAutoCompletionList_Base(string startsWithText, string containsText, int count) 
	{ 
	    // Since this method is a shared/static method it does not maintain information about page or controls within the page. 
	    // Hence we can not invoke any method associated with any controls. 
	    // So, if we need to use any control in the page we need to instantiate it. 
	    KumePortali.UI.Controls.LargeListSelector.ItemsTable control; 
	    control = new KumePortali.UI.Controls.LargeListSelector.ItemsTable(); 
	    return control.GetAutoCompletionList(startsWithText, containsText, count); 
	} 

        // Load data from database into UI controls. 
        // Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        // the individual table and record controls to customize.
        public void LoadData_Base()
        {
            try
            {
                // Load data only when displaying the page for the first time
                if (!this.IsPostBack)
                {
                    // Must start a transaction before performing database operations
                    DbUtils.StartTransaction();

                    // Load data for each record and table UI control.
                    // Ordering is important because child controls get 
                    // their parent ids from their parent UI controls.
                }
            }
            catch (Exception ex)
            {
                // An error has occured so display an error message.
                MiscUtils.RegisterJScriptAlert(this, "Page_Load_Error_Message", ex.Message);
            }
            finally
            {
                if (!this.IsPostBack)
                {
                    // End database transaction
                    DbUtils.EndTransaction();
                }
            }
        }

        protected override void UpdateSessionNavigationHistory()
        {
            //Do nothing
        }

#endregion

    }
}