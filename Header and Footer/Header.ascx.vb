

Imports System
Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports BaseClasses
Imports BaseClasses.Utils

        
Imports SCIENTA.Business
Imports SCIENTA.Data
        
Namespace SCIENTA.UI

  ' Code-behind class for the Header user control.
Partial Class Header
        Inherits BaseApplicationUserControl
        Implements IHeader


      #Region "Section 1: Place your customizations here."

'        Public Sub LoadData()
'            ' LoadData reads database data and assigns it to UI controls.
'            ' Customize by adding code before or after the call to LoadData_Base()
'            ' or replace the call to LoadData_Base().
'            LoadData_Base()
'        End Sub
      


      
#Region "Ajax Functions"

'        <System.Web.Services.WebMethod()> _
'        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
'                                                  ByVal recordID As String, _
'                                                  ByVal columnName As String, _
'                                                  ByVal title As String, _
'                                                  ByVal persist As Boolean, _
'                                                  ByVal popupWindowHeight As Integer, _
'                                                  ByVal popupWindowWidth As Integer, _
'                                                  ByVal popupWindowScrollBar As Boolean _
'                                                  ) As Object()
'            ' GetRecordFieldValue gets the pop up window content from the column specified by
'            ' columnName in the record specified by the recordID in data base table specified by tableName.
'            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
'            ' or replace the call to  GetRecordFieldValue_Base().
'            Return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
'        End Function

'        <System.Web.Services.WebMethod()> _
'        Public Shared Function GetImage(ByVal tableName As String, _
'                                        ByVal recordID As String, _
'                                        ByVal columnName As String, _
'                                        ByVal title As String, _
'                                        ByVal persist As Boolean, _
'                                        ByVal popupWindowHeight As Integer, _
'                                        ByVal popupWindowWidth As Integer, _
'                                        ByVal popupWindowScrollBar As Boolean _
'                                        ) As Object()
'            ' GetImage gets the Image url for the image in the column "columnName" and
'            ' in the record specified by recordID in data base table specified by tableName.
'            ' Customize by adding code before or after the call to  GetImage_Base()
'            ' or replace the call to  GetImage_Base().
'            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
'        End Function
    
#End Region

        'Page Event Handlers - buttons, sort, links

'        Public Sub SignInBarSetLanguageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
'
'            ' Click handler for SignInBarSetLanguageButton.
'            ' Customize by adding code before the call or replace the call to the Base function with your own code.
'            SignInBarSetLanguageButton_Click_Base(sender, args)
'            ' NOTE: If the Base function redirects to another page, any code here will not be executed.
'        End Sub

'        Public Sub SIOImage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
'
'            ' Click handler for SIOImage.
'            ' Customize by adding code before the call or replace the call to the Base function with your own code.
'            SIOImage_Click_Base(sender, args)
'            ' NOTE: If the Base function redirects to another page, any code here will not be executed.
'        End Sub

'        Public Sub SignIn_Click(ByVal sender As Object, ByVal args As EventArgs)
'
'            ' Click handler for SignIn.
'            ' Customize by adding code before the call or replace the call to the Base function with your own code.
'            SignIn_Click_Base(sender, args)
'            ' NOTE: If the Base function redirects to another page, any code here will not be executed.
'        End Sub


'<System.Web.Services.WebMethod()> _
'        Public Shared Function GetImage(ByVal tableName As String, _
'                                        ByVal recordID As String, _
'                                        ByVal columnName As String, _
'                                        ByVal title As String, _
'                                        ByVal persist As Boolean, _
'                                        ByVal popupWindowHeight As Integer, _
'                                        ByVal popupWindowWidth As Integer, _
'                                        ByVal popupWindowScrollBar As Boolean _
'                                        ) As Object()
'            ' GetImage gets the Image url for the image in the column "columnName" and
'            ' in the record specified by recordID in data base table specified by tableName.
'            ' Customize by adding code before or after the call to  GetImage_Base()
'            ' or replace the call to  GetImage_Base().
'            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
'        End Function
'<System.Web.Services.WebMethod()> _
'        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
'                                                  ByVal recordID As String, _
'                                                  ByVal columnName As String, _
'                                                  ByVal title As String, _
'                                                  ByVal persist As Boolean, _
'                                                  ByVal popupWindowHeight As Integer, _
'                                                  ByVal popupWindowWidth As Integer, _
'                                                  ByVal popupWindowScrollBar As Boolean _
'                                                  ) As Object()
'            ' GetRecordFieldValue gets the pop up window content from the column specified by
'            ' columnName in the record specified by the recordID in data base table specified by tableName.
'            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
'            ' or replace the call to  GetRecordFieldValue_Base().
'            Return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
'        End Function
'Public Sub SignIn_Click(ByVal sender As Object, ByVal args As EventArgs)
'            
'          ' Click handler for SignIn.
'          ' Customize by adding code before the call or replace the call to the Base function with your own code.
'          SignIn_Click_Base(sender, args)
'          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
'        End Sub
'Public Sub SIOImage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
'            
'          ' Click handler for SIOImage.
'          ' Customize by adding code before the call or replace the call to the Base function with your own code.
'          SIOImage_Click_Base(sender, args)
'          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
'        End Sub
'Public Sub SignInBarSetLanguageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
'            
'          ' Click handler for SignInBarSetLanguageButton.
'          ' Customize by adding code before the call or replace the call to the Base function with your own code.
'          SignInBarSetLanguageButton_Click_Base(sender, args)
'          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
'        End Sub
'<System.Web.Services.WebMethod()> _
'        Public Shared Function GetImage(ByVal tableName As String, _
'                                        ByVal recordID As String, _
'                                        ByVal columnName As String, _
'                                        ByVal title As String, _
'                                        ByVal persist As Boolean, _
'                                        ByVal popupWindowHeight As Integer, _
'                                        ByVal popupWindowWidth As Integer, _
'                                        ByVal popupWindowScrollBar As Boolean _
'                                        ) As Object()
'            ' GetImage gets the Image url for the image in the column "columnName" and
'            ' in the record specified by recordID in data base table specified by tableName.
'            ' Customize by adding code before or after the call to  GetImage_Base()
'            ' or replace the call to  GetImage_Base().
'            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
'        End Function
'<System.Web.Services.WebMethod()> _
'        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
'                                                  ByVal recordID As String, _
'                                                  ByVal columnName As String, _
'                                                  ByVal title As String, _
'                                                  ByVal persist As Boolean, _
'                                                  ByVal popupWindowHeight As Integer, _
'                                                  ByVal popupWindowWidth As Integer, _
'                                                  ByVal popupWindowScrollBar As Boolean _
'                                                  ) As Object()
'            ' GetRecordFieldValue gets the pop up window content from the column specified by
'            ' columnName in the record specified by the recordID in data base table specified by tableName.
'            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
'            ' or replace the call to  GetRecordFieldValue_Base().
'            Return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
'        End Function
'Public Sub LoadData()
'      ' LoadData reads database data and assigns it to UI controls.
'      ' Customize by adding code before or after the call to LoadData_Base()
'      ' or replace the call to LoadData_Base().
'      LoadData_Base()
'      End Sub
Public Sub SignIn_Click(ByVal sender As Object, ByVal args As EventArgs)
            
          ' Click handler for SignIn.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          SignIn_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
Public Sub SIOImage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            
          ' Click handler for SIOImage.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          SIOImage_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
Public Sub SignInBarSetLanguageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            
          ' Click handler for SignInBarSetLanguageButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          SignInBarSetLanguageButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
<System.Web.Services.WebMethod()> _
        Public Shared Function GetImage(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            ' GetImage gets the Image url for the image in the column "columnName" and
            ' in the record specified by recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetImage_Base()
            ' or replace the call to  GetImage_Base().
            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function
<System.Web.Services.WebMethod()> _
        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
                                                  ByVal recordID As String, _
                                                  ByVal columnName As String, _
                                                  ByVal title As String, _
                                                  ByVal persist As Boolean, _
                                                  ByVal popupWindowHeight As Integer, _
                                                  ByVal popupWindowWidth As Integer, _
                                                  ByVal popupWindowScrollBar As Boolean _
                                                  ) As Object()
            ' GetRecordFieldValue gets the pop up window content from the column specified by
            ' columnName in the record specified by the recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            ' or replace the call to  GetRecordFieldValue_Base().
            Return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function
Public Sub LoadData()
      ' LoadData reads database data and assigns it to UI controls.
      ' Customize by adding code before or after the call to LoadData_Base()
      ' or replace the call to LoadData_Base().
      LoadData_Base()
      End Sub
Public Sub EmployeeStatusButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            
          ' Click handler for EmployeeStatusButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
           
            Dim url As String = "../InsanKaynaklari/sIK00G.aspx?IKCalisanlar=" & SystemUtils.GetUserID
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                DbUtils.StartTransaction
                
                url = Ctype(Me.Page, BaseApplicationPage).ModifyRedirectUrl(url, "",False)
                        Ctype(Me.Page, BaseApplicationPage).CommitTransaction(sender)
          
            Catch ex As Exception
                Ctype(Me.Page, BaseApplicationPage).RollBackTransaction(sender)
                shouldRedirect = False
                Ctype(Me.Page, BaseApplicationPage).ErrorOnPage = True
    
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Ctype(Me.Page, BaseApplicationPage).Response.Redirect(url)
            End If              
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
Public Sub HelpButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            
          ' Click handler for HelpButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          HelpButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
#End Region

#Region "Section 2: Do not modify this section."


        Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. Registers event handler for any button, sort or links.
            ' You can add additional Init handlers in Section 1.

        
              AddHandler Me.EmployeeStatusButton.Click, AddressOf EmployeeStatusButton_Click
              AddHandler Me.HelpButton.Click, AddressOf HelpButton_Click
              AddHandler Me.SIOImage.Click, AddressOf SIOImage_Click
              AddHandler Me.SignInBarSetLanguageButton.Click, AddressOf SignInBarSetLanguageButton_Click
              AddHandler Me.SignIn.Click, AddressOf SignIn_Click
            
        End Sub

        ' Handles MyBase.Load.  Read database data and put into the UI controls.
        ' If you need to, you can add additional Load handlers in Section 1.
        Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            Me.UserStatusInit() 
            Me.PrintButtonInit() 
            Me.SignInButtonInit() 
            Me.SignInBarLanguageButtonInit() 
            Me._SkipNavigationLinks.Visible = False 
            ' Load data only when displaying the page for the first time
            If (Not Me.IsPostBack) Then
        
            Me._SkipNavigationLinks.NavigateUrl = Me.Page.AppRelativeVirtualPath & Me._SkipNavigationLinks.NavigateUrl
        

      ' Read the data for all controls on the page.
      ' To change the behavior, override the DataBind method for the individual
      ' record or table UI controls.
      Me.LoadData()
      ElseIf (Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then

      Try

      ' Must start a transaction before performing database operations
      DbUtils.StartTransaction()

      ' Load data for each record and table UI control.
      ' Ordering is important because child controls get
      ' their parent ids from their parent UI controls.
      

      Me.DataBind()

      

      Catch ex As Exception
      'An error has occured so display an error message.
      BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
      Finally
      'End database transaction
      DbUtils.EndTransaction()
      End Try

      End If
      End Sub

      Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
      ByVal recordID As String, _
      ByVal columnName As String, _
      ByVal title As String, _
      ByVal persist As Boolean, _
      ByVal popupWindowHeight As Integer, _
      ByVal popupWindowWidth As Integer, _
      ByVal popupWindowScrollBar As Boolean _
      ) As Object()
      Dim content as String = NetUtils.EncodeStringForHtmlDisplay(BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName))
      'content=(formattedValue)
      'returnValue is an array of string values.
      'returnValue(0) represents title of the pop up window
      'returnValue(1) represents content of the pop up window
      ' retrunValue(2) represents whether pop up window should be made persistant
      ' or it should closes as soon as mouse moved out.
      ' returnValue(5) represents whether pop up window should contain scroll bar.
      ' returnValue(3), (4) represents pop up window height and width respectivly
      ' (0),(2),(3),(4) and (5)  is initially set as pass through attribute.
      ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
      Dim returnValue(6) As Object
      returnValue(0) = title
      returnValue(1) = content
      returnValue(2) = persist
      returnValue(3) = popupWindowWidth
      returnValue(4) = popupWindowHeight
      returnValue(5) = popupWindowScrollBar
      Return returnValue
      End Function

      Public Shared Function GetImage_Base(ByVal tableName As String, _
      ByVal recordID As String, _
      ByVal columnName As String, _
      ByVal title As String, _
      ByVal persist As Boolean, _
      ByVal popupWindowHeight As Integer, _
      ByVal popupWindowWidth As Integer, _
      ByVal popupWindowScrollBar As Boolean _
      ) As Object()
      Dim content As String = "<IMG src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
            'returnValue is an array of string values.
            'returnValue(0) represents title of the pop up window.
            'returnValue(1) represents content ie, image url.
            ' retrunValue(2) represents whether pop up window should be made persistant
            ' or it should closes as soon as mouse moved out.
            ' returnValue(3), (4) represents pop up window height and width respectivly
            ' returnValue(5) represents whether pop up window should contain scroll bar.
            ' (0),(2),(3),(4) and (5) is initially set as pass through attribute.
            ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
            Dim returnValue(6) As Object
            returnValue(0) = title
            returnValue(1) = content
            returnValue(2) = persist
            returnValue(3) = popupWindowWidth
            returnValue(4) = popupWindowHeight
            returnValue(5) = popupWindowScrollBar
            Return returnValue
        End Function
        
    
      'Initializes Sign In status text.
      Protected Overridable Sub UserStatusInit()
      
            Select Case DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus()
              Case Nothing
                Me._UserStatusLbl.Text = GetResourceValue("Txt:UserNotSignedIn", "SCIENTA")
              Case ""
                Me._UserStatusLbl.Text = GetResourceValue("Txt:UserNotSignedIn", "SCIENTA")
              Case Else
                Me._UserStatusLbl.Text = GetResourceValue("Txt:Hello", "SCIENTA")
                Me._UserStatusLbl.Text +=DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus()
            End Select
             
        End Sub
        
        'Initializes Print Button.
        Protected Overridable Sub PrintButtonInit()
        
          Me._SignInBarPrintButton.Visible = False
          Me._Divider3.Visible = False 
        End Sub
       
        'Initializes Set Language button.
        Protected Overridable Sub SignInBarLanguageButtonInit()
         
          Me._SignInBarSetLanguageButton.Visible = False
          Me._SignInBarSetLanguageButton.Enabled = False
          Me._Divider1.Visible = False 
        End Sub
      
        'Initializes SignIn LinkButton.
        'You can change the behavior of this method in Section 1.
        Protected Overridable Sub SignInButtonInit()
        
            Me._UserStatusLbl.Visible = False  
            If (BaseClasses.Configuration.ApplicationSettings.Current.AuthenticationType = BaseClasses.Configuration.SecurityConstants.None) Then
            
              Me._SIOImage.Visible = False  
              Me._SignIn.Visible = False 
              Me._Divider2.Visible = False
            Else
              
              Me._SIOImage.Visible = True  
              Me._SignIn.Visible = True 
              Me._Divider2.Visible = True 
              Me._UserStatusLbl.Visible = True
            
            End If
          
                   
        Select Case (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus())
            Case Nothing, ""
              
              Me._SignIn.Text = GetResourceValue("Txt:SignIn", "SCIENTA")
              Me._SignIn.ToolTip = GetResourceValue("Txt:SignIn", "SCIENTA") 
              
              Me._SIOImage.ImageUrl = "../Images/SignInBarSignIn.gif"
              Me._SIOImage.Attributes.Add("onmouseover", "this.src='../Images/SignInBarSignInOver.gif'")
              Me._SIOImage.Attributes.Add("onmouseout", "this.src='../Images/SignInBarSignIn.gif'")
              Me._SIOImage.ToolTip = GetResourceValue("Txt:SignIn", "SCIENTA")
              
        Case Else
              
              Me._SignIn.Text = GetResourceValue("Txt:SignOut", "SCIENTA")
              Me._SignIn.ToolTip = GetResourceValue("Txt:SignOut", "SCIENTA")
              
              Me._SIOImage.ImageUrl = "../Images/SignInBarSignOut.gif"
              Me._SIOImage.Attributes.Add("onmouseover", "this.src='../Images/SignInBarSignOutOver.gif'")
              Me._SIOImage.Attributes.Add("onmouseout", "this.src='../Images/SignInBarSignOut.gif'")
              Me._SIOImage.ToolTip = GetResourceValue("Txt:SignOut", "SCIENTA")
              
          End Select
        End Sub
        'Performs SignIn and SignOut. 
        Protected Overridable Sub SignInOutProceed(ByVal sender As Object)
          Dim url As String
          Dim shouldRedirect As Boolean
        Select Case (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus())
            Case Nothing, ""
              url = BaseClasses.Configuration.ApplicationSettings.Current.SignInPageUrl()
              url = ".." + url.Substring(BaseClasses.Configuration.ApplicationSettings.Current.AppRootPath.Length-1)
              shouldRedirect = True
              Try
                DbUtils.StartTransaction()
                url = CType(Me.Page, BaseApplicationPage).ModifyRedirectUrl(url, "", False)
                CType(Me.Page, BaseApplicationPage).CommitTransaction(sender)
              Catch ex As Exception
                CType(Me.Page, BaseApplicationPage).RollBackTransaction(sender)
                shouldRedirect = False
                CType(Me.Page, BaseApplicationPage).ErrorOnPage = True
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
              Finally
                DbUtils.EndTransaction()
              End Try
              If shouldRedirect Then
                CType(Me.Page, BaseApplicationPage).Response.Redirect(url)
              End If
            Case Else
              url = BaseClasses.Configuration.ApplicationSettings.Current.SignedOutPageUrl()
              url = ".." + url.Substring(BaseClasses.Configuration.ApplicationSettings.Current.AppRootPath.Length-1)
              shouldRedirect = True
              Try
                DbUtils.StartTransaction()
                DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.Logout(CType(Me.Page, BaseApplicationPage))
                url = CType(Me.Page, BaseApplicationPage).ModifyRedirectUrl(url, "", False)
                CType(Me.Page, BaseApplicationPage).CommitTransaction(sender)
              Catch ex As Exception
                CType(Me.Page, BaseApplicationPage).RollBackTransaction(sender)
                shouldRedirect = False
                CType(Me.Page, BaseApplicationPage).ErrorOnPage = True
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
              Finally
                DbUtils.EndTransaction()
              End Try
              If shouldRedirect Then
                CType(Me.Page, BaseApplicationPage).ShouldSaveControlsToSession = True
                CType(Me.Page, BaseApplicationPage).Response.Redirect(url)
              End If
          End Select
        End Sub
        
        ' Load data from database into UI controls.
        ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        ' the individual table and record controls to customize.
        Public Sub LoadData_Base()
            Try
              ' Load data only when displaying the page for the first time
              If (Not Me.IsPostBack) Then

                ' Must start a transaction before performing database operations
                DbUtils.StartTransaction()

                ' Load data for each record and table UI control.
                ' Ordering is important because child controls get
                ' their parent ids from their parent UI controls.
        
      
                Me.DataBind()
    
        
              End If

            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If Not Me.IsPostBack Then
                    ' End database transaction
                      DbUtils.EndTransaction()
                End If
            End Try
        End Sub

        ' Write out event methods for the page events
        
        ' event handler for ImageButton
        Public Sub EmployeeStatusButton_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Dim url As String = "../InsanKaynaklari/sIK00G.aspx?IKCalisanlar=6"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                DbUtils.StartTransaction
                
                url = Ctype(Me.Page, BaseApplicationPage).ModifyRedirectUrl(url, "",False)
                        Ctype(Me.Page, BaseApplicationPage).CommitTransaction(sender)
          
            Catch ex As Exception
                Ctype(Me.Page, BaseApplicationPage).RollBackTransaction(sender)
                shouldRedirect = False
                Ctype(Me.Page, BaseApplicationPage).ErrorOnPage = True
    
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Ctype(Me.Page, BaseApplicationPage).Response.Redirect(url)
            End If              
        End Sub
            
        ' event handler for ImageButton
        Public Sub HelpButton_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Dim url As String = "http://176.40.125.173/biltay"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                DbUtils.StartTransaction
                
                url = Ctype(Me.Page, BaseApplicationPage).ModifyRedirectUrl(url, "",False)
                        Ctype(Me.Page, BaseApplicationPage).CommitTransaction(sender)
          
            Catch ex As Exception
                Ctype(Me.Page, BaseApplicationPage).RollBackTransaction(sender)
                shouldRedirect = False
                Ctype(Me.Page, BaseApplicationPage).ErrorOnPage = True
    
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Ctype(Me.Page, BaseApplicationPage).Response.Redirect(url)
            End If              
        End Sub
            
        ' event handler for ImageButton
        Public Sub SIOImage_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
              Me.SignInOutProceed(sender)
                          
        End Sub
            
        ' event handler for ImageButton
        Public Sub SignInBarSetLanguageButton_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
              'do nothing because click is handled by Java code in control itself
                          
        End Sub
            
        ' event handler for LinkButton
        Public Sub SignIn_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
              Me.SignInOutProceed(sender)
                
        End Sub
            
        #Region "Interface Properties"
        
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Divider() As Image Implements IHeader.Divider
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_Divider"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Divider1() As Image Implements IHeader.Divider1
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_Divider1"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Divider2() As Image Implements IHeader.Divider2
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_Divider2"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Divider3() As Image Implements IHeader.Divider3
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_Divider3"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Divider4() As Image Implements IHeader.Divider4
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_Divider4"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property EmployeeStatusButton() As ImageButton Implements IHeader.EmployeeStatusButton
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_EmployeeStatusButton"), ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property HelpButton() As ImageButton Implements IHeader.HelpButton
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_HelpButton"), ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property LeftImage() As Image Implements IHeader.LeftImage
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_LeftImage"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property PageHeader__Logo() As Image Implements IHeader.PageHeader__Logo
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_PageHeader__Logo"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property SIOImage() As ImageButton Implements IHeader.SIOImage
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_SIOImage"), ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property SignIn() As LinkButton Implements IHeader.SignIn
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_SignIn"), LinkButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property SignInBarPrintButton() As Image Implements IHeader.SignInBarPrintButton
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_SignInBarPrintButton"), Image)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property SignInBarSetLanguageButton() As ImageButton Implements IHeader.SignInBarSetLanguageButton
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_SignInBarSetLanguageButton"), ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property UserStatusLbl() As Label Implements IHeader.UserStatusLbl
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_UserStatusLbl"), Label)
            End Get
        End Property
                
      Public Overrides Property Visible() As Boolean Implements IHeader.Visible
  
          Get
              Return MyBase.Visible
          End Get
          Set(ByVal value As Boolean)
              MyBase.Visible = value
          End Set
      End Property
            
        #End Region
  
#End Region

  

End Class
  
End Namespace

  