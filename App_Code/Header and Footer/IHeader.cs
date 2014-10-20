
using Microsoft.VisualBasic;
  
namespace KumePortali.UI
{

  

    public interface IHeader {

#region Interface Properties
        
        System.Web.UI.WebControls.Image Divider1 {get;}
                
        System.Web.UI.WebControls.Image Divider2 {get;}
                
        System.Web.UI.WebControls.Image Divider3 {get;}
                
        System.Web.UI.WebControls.Image LeftImage {get;}
                
        System.Web.UI.WebControls.Image PageHeader__Logo {get;}
                
        System.Web.UI.WebControls.ImageButton SIOImage {get;}
                
        System.Web.UI.WebControls.LinkButton SignIn {get;}
                
        System.Web.UI.WebControls.Image SignInBarPrintButton {get;}
                
        System.Web.UI.WebControls.ImageButton SignInBarSetLanguageButton {get;}
                
        System.Web.UI.WebControls.Label UserStatusLbl {get;}
                
      bool Visible {get; set;}
            

#endregion

    }

  
}
  