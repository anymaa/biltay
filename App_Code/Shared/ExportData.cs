using Microsoft.VisualBasic;
using System.IO;
using BaseClasses.Data;
using CarlosAg.ExcelXmlWriter;
using System;
using System.Collections;

// The ExportData class exports to Excel and sends the XLS file to the response stream.
namespace KumePortali
{
 public class ExportData
 {
    #region "Properties"
    private BaseTable _tbl;
    private BaseTable DBTable
    {
            get 
            {
                return this._tbl;
            }
            set
            {
                this._tbl = value;
            }
    }

    WhereClause _wc;
    private WhereClause SelectWhereClause 
    {
        get
        {
            return this._wc;
        }
        set
        {
            this._wc = value;
        }
    }
        
    OrderBy _orderby;
    private OrderBy SelectOrderBy
    {
        get
        {
            return this._orderby;
        }
        set
        {
            this._orderby = value;
        }
    }

    BaseColumn[] _columns;
    private BaseColumn[] DisplayColumns
    {
        get
        {
            return _columns;
        }
            set
            {
                this._columns = value;
            }
    }
    #endregion

    #region "Constructor"

    public ExportData(BaseTable tbl, WhereClause wc, OrderBy orderBy, BaseColumn[] columns)
    {
        this.DBTable = tbl;
        this.SelectWhereClause = wc;
        this.SelectOrderBy = orderBy;
        this.DisplayColumns = columns;
    }
    public ExportData(BaseTable tbl, WhereClause wc, OrderBy orderBy)
    {
           this.DBTable = tbl;
           this.SelectWhereClause = wc;
           this.SelectOrderBy = orderBy;
    }
    #endregion

    #region "Public Methods"

    public void ExportToCSV(System.Web.HttpResponse response)
    {
            bool done = false;
            int pageIndex = 0;
            int pageSize = 100;
            string val;
            bool skip;
            bool IsString;
        
            if (!(response == null))
            {
                string fileName = (DBTable.TableDefinition.Name + ".csv");
                response.ClearHeaders();
                response.Clear();
                response.Cache.SetCacheability(System.Web.HttpCacheability.Private);
                response.Cache.SetMaxAge(new TimeSpan(0));
                response.Cache.SetExpires(new DateTime(0));
                response.Cache.SetNoServerCaching();
                response.ContentType = "text/plain";
                response.AppendHeader("Content-Disposition", ("attachment; filename=\"" + (fileName + "\"")));
                
        StreamWriter writer = new StreamWriter(response.OutputStream, System.Text.Encoding.UTF8); 
        //  First write out the Column Headers
        foreach (BaseColumn col in DisplayColumns)
        {
            if (!(col == null))
            {
                if (((col.ColumnType != BaseColumn.ColumnTypes.Binary) && (col.ColumnType != BaseColumn.ColumnTypes.Image)))
                {
                    writer.Write(("\"" + (col.Name.Replace("\"", "\"\"") + "\",")));
                }
                }
        }
        writer.WriteLine();
        int totalRowsReturned = 0;
        //  Read 100 records at a time and write out the CSV file.
        while (!done)
        {
            ArrayList recList = null;
            if (SelectWhereClause.RunQuery)
            {
                recList = DBTable.GetRecordList(SelectWhereClause.GetFilter(), SelectOrderBy, pageIndex, pageSize, ref totalRowsReturned);
                totalRowsReturned = recList.Count;
            }
            if ((totalRowsReturned <= 0))
            {
                    done = true;
            }
            else 
            {
                    foreach (BaseRecord rec in recList)
                    {
                            foreach (BaseColumn col in DisplayColumns)
                            {
                                if (col != null)
                                {
                                        skip = false;
                                        val = "";
                                        IsString = true;
                                        if (col.TableDefinition.IsExpandableNonCompositeForeignKey(col))
                                        {
                                            //  Foreign Key column, so we will use DFKA and String type.
                                            val = rec.Format(col);
                                        }
                                    else
                                    {
                            switch (col.ColumnType)
                            {
                                                case BaseColumn.ColumnTypes.Binary:
                                case BaseColumn.ColumnTypes.Image:
                                                    //  Skip - do nothing for these columns
                                                    skip = true;
                                                    break;
                                case BaseColumn.ColumnTypes.Currency:
                                case BaseColumn.ColumnTypes.Number:
                                case BaseColumn.ColumnTypes.Percentage:
                                                    IsString = false;
                                                    val = rec.Format(col);
                                                    break;
                                                default:
                                                    val = rec.Format(col);
                                                    break;
                                        }
                                    }
                                    if ((val == null))
                                    {
                                        val = "";
                                    }
                                    if (!skip) 
                                    {
                                        if ((IsString) || (val.Contains(","))) 
                                        {
                                                writer.Write(("\"" + (val.Replace("\"", "\"\"") + "\",")));
                                        }
                                        else
                                        {
                                                writer.Write((val + ","));
                                        }
                                    }
                            }
                        }
            writer.WriteLine();
        }
            pageIndex++;
            //  If we already are below the pageSize, then we are done.
            if ((totalRowsReturned < pageSize))
            {
                    done = true;
            }
       }
    }
    writer.Flush();
    response.End();      
    }
}


      ArrayList ColumnList = new ArrayList();
       public void AddColumn(ExcelColumn col) 
       {
           this.ColumnList.Add(col);
       }


    CarlosAg.ExcelXmlWriter.DataType excelDataType;
    public void ExportToExcel(System.Web.HttpResponse response)
    {
        bool done = false;
        string val;
        bool skip;
        bool skipHeader;

            if (!(response == null))
            {            	
                CarlosAg.ExcelXmlWriter.Workbook excelBook = new CarlosAg.ExcelXmlWriter.Workbook();
                excelBook.Properties.Title = DBTable.TableDefinition.Name;
                excelBook.Properties.Created = DateTime.Now;
                excelBook.Properties.Author = "";

                CarlosAg.ExcelXmlWriter.Worksheet excelSheet = excelBook.Worksheets.Add("Sheet1");
                excelSheet.Options.SplitHorizontal = 1;
                excelSheet.Options.FreezePanes = true;
                excelSheet.Options.TopRowBottomPane = 1;

                CarlosAg.ExcelXmlWriter.WorksheetRow excelRow = excelSheet.Table.Rows.Add();
                
                CarlosAg.ExcelXmlWriter.WorksheetStyle excelHeaderStyle = excelBook.Styles.Add("HeaderRowStyle");
                excelHeaderStyle.Font.Bold = true;
                excelHeaderStyle.Font.FontName = "Verdana";
                excelHeaderStyle.Font.Size = 8;
                excelHeaderStyle.Font.Color = "#FFFFFF";
                excelHeaderStyle.Interior.Color = "#000000";
                excelHeaderStyle.Interior.Pattern = StyleInteriorPattern.Solid;
                        

                int width = 0;

              //  First write out the Column Headers
                foreach (ExcelColumn elem in ColumnList){
                    ExcelColumn exCol = ((ExcelColumn)(elem));
                    BaseColumn col = exCol.DisplayColumn;
                    if (!(col == null)) {
                        skipHeader = false;
                        if (col.TableDefinition.IsExpandableNonCompositeForeignKey(col)) {
                            // Set width if field is a foreign key field
                            width = 100;
                        }
                        else {
                            switch (col.ColumnType) {
                            case BaseColumn.ColumnTypes.Binary:
                            case BaseColumn.ColumnTypes.Image:
                                //  Skip - do nothing for these columns
                                skipHeader = true;
                                break;
                            case BaseColumn.ColumnTypes.Currency:
                            case BaseColumn.ColumnTypes.Number:
                            case BaseColumn.ColumnTypes.Percentage:
                                width = 60;
                                break;
                            case BaseColumn.ColumnTypes.String:
                            case BaseColumn.ColumnTypes.Very_Large_String:
                                width = 110;
                                break;
                            default:
                                width = 50;
                                break;
                        }
                    }
                    if (!skipHeader) {
                        // excelHeaderStyle.NumberFormat = exCol.DisplayFormat
                        excelRow.Cells.Add(new WorksheetCell(col.Name, "HeaderRowStyle"));
                        WorksheetColumn worksheetColumn = excelSheet.Table.Columns.Add(width);
                    }
                }
            }
                // Read 100 records at a time and write out the Excel file.
                int pageIndex = 0;
                int pageSize = 100;
                int totalRowsReturned = 0;
                int rowCounter = 0;
                decimal deciNumber;

                while (!done)
                {
                    ArrayList recList = null;
                    if (SelectWhereClause.RunQuery)
                    {
                        recList = DBTable.GetRecordList(SelectWhereClause.GetFilter(), SelectOrderBy, pageIndex, pageSize, ref totalRowsReturned);
                        totalRowsReturned = recList.Count;
                    }
                    if ((totalRowsReturned <= 0))
                    {
                        done = true;
                    }
                    else
                    {
                        foreach (BaseRecord rec in recList)
                        {
                            excelRow = excelSheet.Table.Rows.Add();
                            int columnCounter = 0;
                            foreach (ExcelColumn elem in ColumnList)
                            {
                                ExcelColumn exCol = ((ExcelColumn)(elem));
                                BaseColumn col = exCol.DisplayColumn;
                                if (col != null)
                                {
                                    skip = false;
                                    val = "";
                                    if (col.TableDefinition.IsExpandableNonCompositeForeignKey(col))
                                    {
                                        //  Foreign Key column, so we will use DFKA and String type.
                                        excelDataType = DataType.String;
                                        val = rec.Format(col);
                                    }
                                    else
                                    {
                                        switch (col.ColumnType) 
                                        {
                                            case BaseColumn.ColumnTypes.Binary:
                                            case BaseColumn.ColumnTypes.Image:
                                                //  Skip - do nothing for these columns
                                                skip = true;
                                                break;

                                            case BaseColumn.ColumnTypes.Number:
                                            case BaseColumn.ColumnTypes.Percentage:
                                                excelDataType = DataType.Number;
                                                ColumnValue numVal = rec.GetValue(col);
                                                //If the value of the column to be exported is nothing, add an empty cell to the Excel file
                                                if (numVal.IsNull)
                                                {
                                                    excelRow.Cells.Add(new WorksheetCell());
                                                    skip = true;
                                                }
                                                else
                                                {
                                                        deciNumber = numVal.ToDecimal();
                                                        val = deciNumber.ToString(System.Globalization.CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case BaseColumn.ColumnTypes.Currency:
                                                excelDataType = DataType.Number;
                                                ColumnValue curVal = rec.GetValue(col);
                                                //If the value of the column to be exported is nothing, add an empty cell to the Excel file
                                                if (curVal.IsNull)
                                                {
                                                    excelRow.Cells.Add(new WorksheetCell());
                                                    skip = true;
                                                }
                                                else
                                                {
                                                    deciNumber = curVal.ToDecimal();
                                                    val = deciNumber.ToString(System.Globalization.CultureInfo.InvariantCulture);
                                                }
                                                break;

                                            case BaseColumn.ColumnTypes.Date:
                                                excelDataType = DataType.DateTime;
                                                ColumnValue dateVal = rec.GetValue(col);
                                                if (dateVal.IsNull) 
                                                {
                                                    excelRow.Cells.Add(new WorksheetCell());
                                                    skip = true;
                                                }
                                                else 
                                                {  // Specify the default Excel format for the date field 
                                                    val = rec.Format(col, "s");
                                                    val += ".000";
                                                }
                                                break;

                                            case BaseColumn.ColumnTypes.Very_Large_String:
                                                excelDataType = DataType.String;
                                                val = rec.GetValue(col).ToString();
                                                break;
                                            
                                            case BaseColumn.ColumnTypes.Boolean:
                                                excelDataType = DataType.String;
                                                val = rec.Format(col);
                                                break;

                                            default:
                                                excelDataType = DataType.String;
                                                val = rec.Format(col);
                                                break;
                                        }
                                    }
                                    // Define a unique column style for each column in the table to be exported
                                    if ((rowCounter == 0)) 
                                    {
                                        CarlosAg.ExcelXmlWriter.WorksheetStyle excelColumnStyle = excelBook.Styles.Add((exCol.DisplayColumn.ToString() + columnCounter));
                                        excelColumnStyle.Font.FontName = "Verdana";
                                        excelColumnStyle.Font.Size = 8;
                                        if (!exCol.DisplayFormat.Equals("Default")) 
                                        {
                                            excelColumnStyle.NumberFormat = exCol.DisplayFormat;
                                        }
                                    }

                                    if (!skip) 
                                    {
                                        excelRow.Cells.Add(new WorksheetCell(val, excelDataType, (exCol.DisplayColumn.ToString() + columnCounter)));
                                    }
                                }
                                columnCounter++;
                            }
                            rowCounter++;
                        }
                        pageIndex++;
                        // If we already are below the pageSize, then we are done.
                        if ((totalRowsReturned < pageSize))
                        {
                           done = true;
                        }
                    }
                }
                string fileName;
                if (DBTable.TableDefinition.Name != null)
                {
                    fileName = (DBTable.TableDefinition.Name + ".xls");
                }
                else 
                {
                    fileName = "Untitled.xls";
                }
                response.ClearHeaders();
                response.Clear();
                response.Cache.SetCacheability(System.Web.HttpCacheability.Private);
                response.Cache.SetMaxAge(new TimeSpan(0));
                response.Cache.SetExpires(new DateTime(0));
                response.Cache.SetNoServerCaching();
                response.ContentType = "application/vnd.ms-excel";
                response.AppendHeader("Content-Disposition", ("attachment; filename=\"" + (fileName + "\"")));
                excelBook.Save(response.OutputStream);
                response.End();
            }
        }
    #endregion
 }

  public class ExcelColumn 
  {
    #region "Properties"   
      private BaseColumn _column;
      private string _format;
      #endregion
      
    #region "Constructor"
      public ExcelColumn(BaseColumn col, string format)
      {
        DisplayColumn = col;
        DisplayFormat = format;
      }
       #endregion

    #region "Public Methods"
       public BaseColumn DisplayColumn 
       {
          get {
              return _column;
          }
          set {
              this._column = value;
          }
       }
    
       public string DisplayFormat 
       {
            get {
                return _format;
            }
            set {
                this._format = value;
            }
        }
      #endregion
  }
}