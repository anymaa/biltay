

Imports System
Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports BaseClasses
Imports BaseClasses.Utils

        
Imports SCIENTA.Business
Imports SCIENTA.Data

Namespace SCIENTA.UI

    ' Code-behind class for the Footer user control.
    Partial Class Footer
        Inherits BaseApplicationUserControl
        Implements IFooter


#Region "Section 1: Place your customizations here."

'        Public Sub LoadData()
'            LoadData_Base()
'        End Sub




#Region "Ajax Functions"

'        <Services.WebMethod()> _
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

'        <Services.WebMethod()> _
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

        ' Page Event Handlers - buttons, sort, links


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
#End Region

#Region "Section 2: Do not modify this section."


        Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. Registers event handler for any button, sort or links.
            ' You can add additional Init handlers in Section 1.

        
        End Sub

        ' Handles MyBase.Load.  Read database data and put into the UI controls.
        ' If you need to, you can add additional Load handlers in Section 1.
        Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            ' Load data only when displaying the page for the first time
            If (Not Me.IsPostBack) Then
        

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
        
        #Region "Interface Properties"
        
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Copyright() As Literal  Implements IFooter.Copyright
            Get
                Return CType(MiscUtils.FindControlRecursively(Me, "_Copyright"), Literal)
            End Get
        End Property
                
      Public Overrides Property Visible() As Boolean Implements IFooter.Visible
  
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

  