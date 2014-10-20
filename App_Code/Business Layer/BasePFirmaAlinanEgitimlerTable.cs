// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaAlinanEgitimlerTable.cs


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
/// The generated superclass for the <see cref="PFirmaAlinanEgitimlerTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named PFirmaAlinanEgitimler.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="PFirmaAlinanEgitimlerTable.Instance">PFirmaAlinanEgitimlerTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="PFirmaAlinanEgitimlerTable"></seealso>
[SerializableAttribute()]
public class BasePFirmaAlinanEgitimlerTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = PFirmaAlinanEgitimlerDefinition.GetXMLString();







    protected BasePFirmaAlinanEgitimlerTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.PFirmaAlinanEgitimlerTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.PFirmaAlinanEgitimlerRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new PFirmaAlinanEgitimlerSqlTable();
        ((PFirmaAlinanEgitimlerSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.EgitimID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EgitimIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.EgitimID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EgitimID
    {
        get
        {
            return PFirmaAlinanEgitimlerTable.Instance.EgitimIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return PFirmaAlinanEgitimlerTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.EgitimAdi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn EgitimAdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.EgitimAdi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn EgitimAdi
    {
        get
        {
            return PFirmaAlinanEgitimlerTable.Instance.EgitimAdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.EgitimFirmasi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn EgitimFirmasiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.EgitimFirmasi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn EgitimFirmasi
    {
        get
        {
            return PFirmaAlinanEgitimlerTable.Instance.EgitimFirmasiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.BaslamaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn BaslamaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.BaslamaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn BaslamaTarihi
    {
        get
        {
            return PFirmaAlinanEgitimlerTable.Instance.BaslamaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.BitisTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn BitisTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaAlinanEgitimler_.BitisTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn BitisTarihi
    {
        get
        {
            return PFirmaAlinanEgitimlerTable.Instance.BitisTarihiColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of PFirmaAlinanEgitimlerRecord records using a where clause.
    /// </summary>
    public static PFirmaAlinanEgitimlerRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of PFirmaAlinanEgitimlerRecord records using a where and order by clause.
    /// </summary>
    public static PFirmaAlinanEgitimlerRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of PFirmaAlinanEgitimlerRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static PFirmaAlinanEgitimlerRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = PFirmaAlinanEgitimlerTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (PFirmaAlinanEgitimlerRecord[])recList.ToArray(Type.GetType("KumePortali.Business.PFirmaAlinanEgitimlerRecord"));
    }   
    
    public static PFirmaAlinanEgitimlerRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = PFirmaAlinanEgitimlerTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (PFirmaAlinanEgitimlerRecord[])recList.ToArray(Type.GetType("KumePortali.Business.PFirmaAlinanEgitimlerRecord"));
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

        return (int)PFirmaAlinanEgitimlerTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)PFirmaAlinanEgitimlerTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PFirmaAlinanEgitimlerRecord record using a where clause.
    /// </summary>
    public static PFirmaAlinanEgitimlerRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PFirmaAlinanEgitimlerRecord record using a where and order by clause.
    /// </summary>
    public static PFirmaAlinanEgitimlerRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = PFirmaAlinanEgitimlerTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        PFirmaAlinanEgitimlerRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (PFirmaAlinanEgitimlerRecord)recList[0];
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

        return PFirmaAlinanEgitimlerTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        PFirmaAlinanEgitimlerRecord[] recs = GetRecords(where);
        return  PFirmaAlinanEgitimlerTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        PFirmaAlinanEgitimlerRecord[] recs = GetRecords(where, orderBy);
        return  PFirmaAlinanEgitimlerTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        PFirmaAlinanEgitimlerRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  PFirmaAlinanEgitimlerTable.Instance.CreateDataTable(recs, null);
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
        PFirmaAlinanEgitimlerTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  PFirmaAlinanEgitimlerTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return PFirmaAlinanEgitimlerTable.Instance.ExportRecordData(whereFilter);
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

        return PFirmaAlinanEgitimlerTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return PFirmaAlinanEgitimlerTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return PFirmaAlinanEgitimlerTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return PFirmaAlinanEgitimlerTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return PFirmaAlinanEgitimlerTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return PFirmaAlinanEgitimlerTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = PFirmaAlinanEgitimlerTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static PFirmaAlinanEgitimlerRecord GetRecord(string id, bool bMutable)
        {
            return (PFirmaAlinanEgitimlerRecord)PFirmaAlinanEgitimlerTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static PFirmaAlinanEgitimlerRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (PFirmaAlinanEgitimlerRecord)PFirmaAlinanEgitimlerTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string FirmaIDValue, 
        string EgitimAdiValue, 
        string EgitimFirmasiValue, 
        string BaslamaTarihiValue, 
        string BitisTarihiValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(EgitimAdiValue, EgitimAdiColumn);
        rec.SetString(EgitimFirmasiValue, EgitimFirmasiColumn);
        rec.SetString(BaslamaTarihiValue, BaslamaTarihiColumn);
        rec.SetString(BitisTarihiValue, BitisTarihiColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			PFirmaAlinanEgitimlerTable.Instance.DeleteOneRecord(kv);
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
				PFirmaAlinanEgitimlerTable.GetRecord(kv, false);
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
            if (!(PFirmaAlinanEgitimlerTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return PFirmaAlinanEgitimlerTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(PFirmaAlinanEgitimlerTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = PFirmaAlinanEgitimlerTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = PFirmaAlinanEgitimlerTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (PFirmaAlinanEgitimlerTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = PFirmaAlinanEgitimlerTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
