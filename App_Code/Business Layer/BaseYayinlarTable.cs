// This class is "generated" and will be overwritten.
// Your customizations should be made in YayinlarTable.cs


using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using KumePortali.Data;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="YayinlarTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named Yayinlar.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="YayinlarTable.Instance">YayinlarTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="YayinlarTable"></seealso>
[SerializableAttribute()]
public class BaseYayinlarTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = YayinlarDefinition.GetXMLString();







    protected BaseYayinlarTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.YayinlarTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.YayinlarRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new YayinlarSqlTable();
        ((YayinlarSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.YayinID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn YayinIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.YayinID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn YayinID
    {
        get
        {
            return YayinlarTable.Instance.YayinIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.Konu column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KonuColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.Konu column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Konu
    {
        get
        {
            return YayinlarTable.Instance.KonuColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.KonuEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KonuENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.KonuEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn KonuEN
    {
        get
        {
            return YayinlarTable.Instance.KonuENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.OnYazi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OnYaziColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.OnYazi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OnYazi
    {
        get
        {
            return YayinlarTable.Instance.OnYaziColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.OnYaziEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OnYaziENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.OnYaziEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OnYaziEN
    {
        get
        {
            return YayinlarTable.Instance.OnYaziENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.Aciklama column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AciklamaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.Aciklama column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Aciklama
    {
        get
        {
            return YayinlarTable.Instance.AciklamaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.AciklamaEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AciklamaENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.AciklamaEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn AciklamaEN
    {
        get
        {
            return YayinlarTable.Instance.AciklamaENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.DosyaLinki column object.
    /// </summary>
    public BaseClasses.Data.StringColumn DosyaLinkiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.DosyaLinki column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn DosyaLinki
    {
        get
        {
            return YayinlarTable.Instance.DosyaLinkiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.EkleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EkleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.EkleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EkleyenID
    {
        get
        {
            return YayinlarTable.Instance.EkleyenIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return YayinlarTable.Instance.AktifPasifColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.EklenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn EklenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.EklenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn EklenmeTarihi
    {
        get
        {
            return YayinlarTable.Instance.EklenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.DuzenlenyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenlenyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.DuzenlenyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenlenyenID
    {
        get
        {
            return YayinlarTable.Instance.DuzenlenyenIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Yayinlar_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return YayinlarTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of YayinlarRecord records using a where clause.
    /// </summary>
    public static YayinlarRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of YayinlarRecord records using a where and order by clause.
    /// </summary>
    public static YayinlarRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of YayinlarRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static YayinlarRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = YayinlarTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (YayinlarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.YayinlarRecord"));
    }   
    
    public static YayinlarRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = YayinlarTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (YayinlarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.YayinlarRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)YayinlarTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)YayinlarTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a YayinlarRecord record using a where clause.
    /// </summary>
    public static YayinlarRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a YayinlarRecord record using a where and order by clause.
    /// </summary>
    public static YayinlarRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = YayinlarTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        YayinlarRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (YayinlarRecord)recList[0];
        }

        return rec;
    }
    
    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return YayinlarTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        YayinlarRecord[] recs = GetRecords(where);
        return  YayinlarTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        YayinlarRecord[] recs = GetRecords(where, orderBy);
        return  YayinlarTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        YayinlarRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  YayinlarTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        YayinlarTable.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  YayinlarTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return YayinlarTable.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return YayinlarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return YayinlarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return YayinlarTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return YayinlarTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return YayinlarTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return YayinlarTable.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = YayinlarTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static YayinlarRecord GetRecord(string id, bool bMutable)
        {
            return (YayinlarRecord)YayinlarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static YayinlarRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (YayinlarRecord)YayinlarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string KonuValue, 
        string KonuENValue, 
        string OnYaziValue, 
        string OnYaziENValue, 
        string AciklamaValue, 
        string AciklamaENValue, 
        string DosyaLinkiValue, 
        string EkleyenIDValue, 
        string AktifPasifValue, 
        string EklenmeTarihiValue, 
        string DuzenlenyenIDValue, 
        string DuzenlenmeTarihiValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(KonuValue, KonuColumn);
        rec.SetString(KonuENValue, KonuENColumn);
        rec.SetString(OnYaziValue, OnYaziColumn);
        rec.SetString(OnYaziENValue, OnYaziENColumn);
        rec.SetString(AciklamaValue, AciklamaColumn);
        rec.SetString(AciklamaENValue, AciklamaENColumn);
        rec.SetString(DosyaLinkiValue, DosyaLinkiColumn);
        rec.SetString(EkleyenIDValue, EkleyenIDColumn);
        rec.SetString(AktifPasifValue, AktifPasifColumn);
        rec.SetString(EklenmeTarihiValue, EklenmeTarihiColumn);
        rec.SetString(DuzenlenyenIDValue, DuzenlenyenIDColumn);
        rec.SetString(DuzenlenmeTarihiValue, DuzenlenmeTarihiColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			YayinlarTable.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				YayinlarTable.GetRecord(kv, false);
			}
			catch (Exception)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(YayinlarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return YayinlarTable.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(YayinlarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = YayinlarTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = YayinlarTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (YayinlarTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = YayinlarTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
