// This class is "generated" and will be overwritten.
// Your customizations should be made in IsBasvurulariTable.cs


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
/// The generated superclass for the <see cref="IsBasvurulariTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named IsBasvurulari.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="IsBasvurulariTable.Instance">IsBasvurulariTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="IsBasvurulariTable"></seealso>
[SerializableAttribute()]
public class BaseIsBasvurulariTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = IsBasvurulariDefinition.GetXMLString();







    protected BaseIsBasvurulariTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IsBasvurulariTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IsBasvurulariRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new IsBasvurulariSqlTable();
        ((IsBasvurulariSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.IsBasvuruID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IsBasvuruIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.IsBasvuruID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IsBasvuruID
    {
        get
        {
            return IsBasvurulariTable.Instance.IsBasvuruIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.IlanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IlanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.IlanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IlanID
    {
        get
        {
            return IsBasvurulariTable.Instance.IlanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.AdayID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn AdayIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.AdayID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn AdayID
    {
        get
        {
            return IsBasvurulariTable.Instance.AdayIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.BasvuruTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn BasvuruTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.BasvuruTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn BasvuruTarihi
    {
        get
        {
            return IsBasvurulariTable.Instance.BasvuruTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.BasvuruDegerlendirme column object.
    /// </summary>
    public BaseClasses.Data.StringColumn BasvuruDegerlendirmeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.BasvuruDegerlendirme column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn BasvuruDegerlendirme
    {
        get
        {
            return IsBasvurulariTable.Instance.BasvuruDegerlendirmeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.DegerlendirmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DegerlendirmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.DegerlendirmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DegerlendirmeTarihi
    {
        get
        {
            return IsBasvurulariTable.Instance.DegerlendirmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.DegerlendirmeNotu column object.
    /// </summary>
    public BaseClasses.Data.StringColumn DegerlendirmeNotuColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IsBasvurulari_.DegerlendirmeNotu column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn DegerlendirmeNotu
    {
        get
        {
            return IsBasvurulariTable.Instance.DegerlendirmeNotuColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of IsBasvurulariRecord records using a where clause.
    /// </summary>
    public static IsBasvurulariRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of IsBasvurulariRecord records using a where and order by clause.
    /// </summary>
    public static IsBasvurulariRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of IsBasvurulariRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static IsBasvurulariRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = IsBasvurulariTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (IsBasvurulariRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IsBasvurulariRecord"));
    }   
    
    public static IsBasvurulariRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = IsBasvurulariTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (IsBasvurulariRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IsBasvurulariRecord"));
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

        return (int)IsBasvurulariTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)IsBasvurulariTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IsBasvurulariRecord record using a where clause.
    /// </summary>
    public static IsBasvurulariRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IsBasvurulariRecord record using a where and order by clause.
    /// </summary>
    public static IsBasvurulariRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = IsBasvurulariTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        IsBasvurulariRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (IsBasvurulariRecord)recList[0];
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

        return IsBasvurulariTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        IsBasvurulariRecord[] recs = GetRecords(where);
        return  IsBasvurulariTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        IsBasvurulariRecord[] recs = GetRecords(where, orderBy);
        return  IsBasvurulariTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        IsBasvurulariRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  IsBasvurulariTable.Instance.CreateDataTable(recs, null);
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
        IsBasvurulariTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  IsBasvurulariTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return IsBasvurulariTable.Instance.ExportRecordData(whereFilter);
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

        return IsBasvurulariTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return IsBasvurulariTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return IsBasvurulariTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return IsBasvurulariTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return IsBasvurulariTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return IsBasvurulariTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = IsBasvurulariTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static IsBasvurulariRecord GetRecord(string id, bool bMutable)
        {
            return (IsBasvurulariRecord)IsBasvurulariTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static IsBasvurulariRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (IsBasvurulariRecord)IsBasvurulariTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string IlanIDValue, 
        string AdayIDValue, 
        string BasvuruTarihiValue, 
        string BasvuruDegerlendirmeValue, 
        string DegerlendirmeTarihiValue, 
        string DegerlendirmeNotuValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(IlanIDValue, IlanIDColumn);
        rec.SetString(AdayIDValue, AdayIDColumn);
        rec.SetString(BasvuruTarihiValue, BasvuruTarihiColumn);
        rec.SetString(BasvuruDegerlendirmeValue, BasvuruDegerlendirmeColumn);
        rec.SetString(DegerlendirmeTarihiValue, DegerlendirmeTarihiColumn);
        rec.SetString(DegerlendirmeNotuValue, DegerlendirmeNotuColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			IsBasvurulariTable.Instance.DeleteOneRecord(kv);
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
				IsBasvurulariTable.GetRecord(kv, false);
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
            if (!(IsBasvurulariTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return IsBasvurulariTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(IsBasvurulariTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = IsBasvurulariTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = IsBasvurulariTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (IsBasvurulariTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = IsBasvurulariTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
