using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace KumePortali
{
    /// <summary>
    /// Summary description for CalendarExtendarClass
    /// </summary>
    public class CalendarExtendarClass : AjaxControlToolkit.CalendarExtender
    {
        public CalendarExtendarClass()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        protected override void OnLoad(EventArgs e)
        {
            TextBox textBox = (TextBox)base.TargetControl;
            if (this.IsLanguageDefaultRTL)
            {
                if (!this.Page.IsPostBack)
                {
                    if (textBox.Text == string.Empty)
                    {
                        ((TextBox)base.TargetControl).Text = DateTime.Today.ToString(base.Format);
                    }
                }

            }
            base.OnLoad(e);
        }
        public bool IsLanguageDefaultRTL
        {
            get
            {
                  if (string.Compare(this.Page.Culture, "Arabic (Saudi Arabia)", StringComparison.InvariantCulture) == 0 ||
                    string.Compare(this.Page.Culture, "Thai(Thailand)", StringComparison.InvariantCulture) == 0 ||
                    string.Compare(this.Page.Culture, "Divehi (Maldives)", StringComparison.InvariantCulture) == 0 ||
                    string.Compare(this.Page.Culture, "Persian (Iran)", StringComparison.InvariantCulture) == 0)
                                     
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}