// This class is "generated" and will be overwritten.
// Your customizations should be made in OlcuKatsayisiBirimleriTable.cs


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
/// The generated superclass for the <see cref="OlcuKatsayisiBirimleriTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named OlcuKatsayisiBirimleri.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="OlcuKatsayisiBirimleriTable.Instance">OlcuKatsayisiBirimleriTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="OlcuKatsayisiBirimleriTable"></seealso>
[SerializableAttribute()]
public class BaseOlcuKatsayisiBirimleriTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = OlcuKatsayisiBirimleriDefinition.GetXMLString();







    protected BaseOlcuKatsayisiBirimleriTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.OlcuKatsayisiBirimleriTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.OlcuKatsayisiBirimleriRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new OlcuKatsayisiBirimleriSqlTable();
        ((OlcuKatsayisiBirimleriSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.OlcuBirimID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlcuBirimIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.OlcuBirimID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlcuBirimID
    {
        get
        {
            return OlcuKatsayisiBirimleriTable.Instance.OlcuBirimIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.OlcuBirimAdi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OlcuBirimAdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.OlcuBirimAdi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OlcuBirimAdi
    {
        get
        {
            return OlcuKatsayisiBirimleriTable.Instance.OlcuBirimAdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OlcuBirimAdiENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OlcuBirimAdiEN
    {
        get
        {
            return OlcuKatsayisiBirimleriTable.Instance.OlcuBirimAdiENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.BirimTuru column object.
    /// </summary>
    public BaseClasses.Data.StringColumn BirimTuruColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.BirimTuru column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn BirimTuru
    {
        get
        {
            return OlcuKatsayisiBirimleriTable.Instance.BirimTuruColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.TR column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TRColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.TR column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TR
    {
        get
        {
            return OlcuKatsayisiBirimleriTable.Instance.TRColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.EN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's OlcuKatsayisiBirimleri_.EN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn EN
    {
        get
        {
            return OlcuKatsayisiBirimleriTable.Instance.ENColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of OlcuKatsayisiBirimleriRecord records using a where clause.
    /// </summary>
    public static OlcuKatsayisiBirimleriRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of OlcuKatsayisiBirimleriRecord records using a where and order by clause.
    /// </summary>
    public static OlcuKatsayisiBirimleriRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of OlcuKatsayisiBirimleriRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static OlcuKatsayisiBirimleriRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = OlcuKatsayisiBirimleriTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (OlcuKatsayisiBirimleriRecord[])recList.ToArray(Type.GetType("KumePortali.Business.OlcuKatsayisiBirimleriRecord"));
    }   
    
    public static OlcuKatsayisiBirimleriRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = OlcuKatsayisiBirimleriTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (OlcuKatsayisiBirimleriRecord[])recList.ToArray(Type.GetType("KumePortali.Business.OlcuKatsayisiBirimleriRecord"));
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

        return (int)OlcuKatsayisiBirimleriTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)OlcuKatsayisiBirimleriTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a OlcuKatsayisiBirimleriRecord record using a where clause.
    /// </summary>
    public static OlcuKatsayisiBirimleriRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a OlcuKatsayisiBirimleriRecord record using a where and order by clause.
    /// </summary>
    public static OlcuKatsayisiBirimleriRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = OlcuKatsayisiBirimleriTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        OlcuKatsayisiBirimleriRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (OlcuKatsayisiBirimleriRecord)recList[0];
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

        return OlcuKatsayisiBirimleriTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        OlcuKatsayisiBirimleriRecord[] recs = GetRecords(where);
        return  OlcuKatsayisiBirimleriTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        OlcuKatsayisiBirimleriRecord[] recs = GetRecords(where, orderBy);
        return  OlcuKatsayisiBirimleriTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        OlcuKatsayisiBirimleriRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  OlcuKatsayisiBirimleriTable.Instance.CreateDataTable(recs, null);
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
        OlcuKatsayisiBirimleriTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  OlcuKatsayisiBirimleriTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return OlcuKatsayisiBirimleriTable.Instance.ExportRecordData(whereFilter);
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

        return OlcuKatsayisiBirimleriTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return OlcuKatsayisiBirimleriTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return OlcuKatsayisiBirimleriTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return OlcuKatsayisiBirimleriTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return OlcuKatsayisiBirimleriTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return OlcuKatsayisiBirimleriTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = OlcuKatsayisiBirimleriTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static OlcuKatsayisiBirimleriRecord GetRecord(string id, bool bMutable)
        {
            return (OlcuKatsayisiBirimleriRecord)OlcuKatsayisiBirimleriTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static OlcuKatsayisiBirimleriRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (OlcuKatsayisiBirimleriRecord)OlcuKatsayisiBirimleriTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string OlcuBirimAdiValue, 
        string OlcuBirimAdiENValue, 
        string BirimTuruValue, 
        string TRValue, 
        string ENValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(OlcuBirimAdiValue, OlcuBirimAdiColumn);
        rec.SetString(OlcuBirimAdiENValue, OlcuBirimAdiENColumn);
        rec.SetString(BirimTuruValue, BirimTuruColumn);
        rec.SetString(TRValue, TRColumn);
        rec.SetString(ENValue, ENColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			OlcuKatsayisiBirimleriTable.Instance.DeleteOneRecord(kv);
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
				OlcuKatsayisiBirimleriTable.GetRecord(kv, false);
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
            if (!(OlcuKatsayisiBirimleriTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return OlcuKatsayisiBirimleriTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(OlcuKatsayisiBirimleriTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = OlcuKatsayisiBirimleriTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = OlcuKatsayisiBirimleriTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (OlcuKatsayisiBirimleriTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = OlcuKatsayisiBirimleriTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
