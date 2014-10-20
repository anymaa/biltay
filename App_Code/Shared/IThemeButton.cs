
using Microsoft.VisualBasic;
  
namespace KumePortali.UI
{

  

    public interface IThemeButton {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
            

#endregion

    }

  
}
  