using System.ComponentModel;
using System.Web.UI;
using System.Web;

namespace KumePortali
{
    public class FvLlsHyperLink : BaseClasses.Web.UI.WebControls.PopupWindowHyperLink
    {

        public FvLlsHyperLink()
            : base()
        {
            this.WindowFeatures = "width=600, height=400, resizable, scrollbars";
            this.WindowName = "llswin";
            this.ImageUrl = "~/Images/LargeListSelector.gif";
            this.CssClass = "llslink";
        }

        [Editor("System.Web.UI.Design.UrlEditor, System.Design, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor)), Category("Navigation"), DefaultValue(""), Description("HyperLink_NavigateUrl"), Bindable(false)]
        public new string NavigateUrl
        {
            get
            {
                return this.DeriveNavigateUrl();
            }
        }
        private string _ControlToUpdate = "";

        [Bindable(true), Category("Behavior"), DefaultValue("")]
        public string ControlToUpdate
        {
            get
            {
                return this._ControlToUpdate;
            }
            set
            {
                this._ControlToUpdate = value;
            }
        }
        private int _MinListItems = 100;

        [Bindable(true), Category("Behavior"), DefaultValue("100"), Description("The minimum number of items that must be in the ControlToUpdate for this control to be visible.")]
        public int MinListItems
        {
            get
            {
                return this._MinListItems;
            }
            set
            {
                if ((value < 0))
                {
                    value = 0;
                }
                this._MinListItems = value;
            }
        }

        public Control GetControlToUpdate()
        {
            if (this.ControlToUpdate != null && this.ControlToUpdate.Length > 0)
            {
                return this.NamingContainer.FindControl(this.ControlToUpdate);
            }
            return null;
        }

        protected string DeriveNavigateUrl()
        {
            Control c = this.GetControlToUpdate();
            string tableName = this.Attributes["Table"];
            string fieldName = this.Attributes["Field"];
            string displayFieldName = this.Attributes["DisplayField"];
            if (displayFieldName == null)
            {
                displayFieldName = fieldName;
            }
            // encrypt all the fields
            tableName = ((KumePortali.UI.BaseApplicationPage)this.Page).Encrypt(tableName);
            fieldName = ((KumePortali.UI.BaseApplicationPage)this.Page).Encrypt(fieldName);
            displayFieldName = ((KumePortali.UI.BaseApplicationPage)this.Page).Encrypt(displayFieldName);

            return string.Format("~/Shared/LargeListSelector.aspx?Table={0}&Field={1}&DisplayField={2}&Target={3}&usnh=n", tableName, fieldName, displayFieldName, HttpUtility.UrlEncode(c.ClientID));
        }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
        
            if ((this.MinListItems > 0))
            {
                Control c = this.GetControlToUpdate();                
                if (c != null && !c.Visible) 
                {
                    return;
                }

                if (((c) is System.Web.UI.WebControls.ListControl))
                {
                    System.Web.UI.WebControls.ListControl lc = ((System.Web.UI.WebControls.ListControl)(c));
                    int listItemCount = lc.Items.Count;
                    if ((!(listItemCount >= this.MinListItems)))
                    {
                        return;
                    }
                }
            }
            string baseNavUrl = base.NavigateUrl;
            base.NavigateUrl = this.NavigateUrl;
            base.Render(writer);
            base.NavigateUrl = baseNavUrl;
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            this._ControlToUpdate = System.Convert.ToString(this.ViewState["ControlToUpdate"]);
            this._MinListItems = System.Convert.ToInt32(this.ViewState["MinListItems"]);
        }

        protected override object SaveViewState()
        {
            this.ViewState["ControlToUpdate"] = this._ControlToUpdate;
            this.ViewState["MinListItems"] = this._MinListItems;
            return base.SaveViewState();
        }
    }
}