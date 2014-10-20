// This class is "generated" and will be overwritten.
// Your customizations should be made in EtkinliklerTable.cs


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
/// The generated superclass for the <see cref="EtkinliklerTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named Etkinlikler.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="EtkinliklerTable.Instance">EtkinliklerTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="EtkinliklerTable"></seealso>
[SerializableAttribute()]
public class BaseEtkinliklerTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = EtkinliklerDefinition.GetXMLString();







    protected BaseEtkinliklerTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.EtkinliklerTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.EtkinliklerRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new EtkinliklerSqlTable();
        ((EtkinliklerSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn EtkinlikIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn EtkinlikID
    {
        get
        {
            return EtkinliklerTable.Instance.EtkinlikIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Konu column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KonuColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Konu column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Konu
    {
        get
        {
            return EtkinliklerTable.Instance.KonuColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.KonuEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KonuENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.KonuEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn KonuEN
    {
        get
        {
            return EtkinliklerTable.Instance.KonuENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OnYazi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OnYaziColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OnYazi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OnYazi
    {
        get
        {
            return EtkinliklerTable.Instance.OnYaziColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OnyaziEn column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OnyaziEnColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OnyaziEn column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OnyaziEn
    {
        get
        {
            return EtkinliklerTable.Instance.OnyaziEnColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Aciklama column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn AciklamaColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Aciklama column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn Aciklama
    {
        get
        {
            return EtkinliklerTable.Instance.AciklamaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.AciklamaEN column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn AciklamaENColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.AciklamaEN column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn AciklamaEN
    {
        get
        {
            return EtkinliklerTable.Instance.AciklamaENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikBaslangic column object.
    /// </summary>
    public BaseClasses.Data.DateColumn EtkinlikBaslangicColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikBaslangic column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn EtkinlikBaslangic
    {
        get
        {
            return EtkinliklerTable.Instance.EtkinlikBaslangicColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikBitis column object.
    /// </summary>
    public BaseClasses.Data.DateColumn EtkinlikBitisColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikBitis column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn EtkinlikBitis
    {
        get
        {
            return EtkinliklerTable.Instance.EtkinlikBitisColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Yer column object.
    /// </summary>
    public BaseClasses.Data.StringColumn YerColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Yer column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Yer
    {
        get
        {
            return EtkinliklerTable.Instance.YerColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Kayit column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KayitColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.Kayit column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Kayit
    {
        get
        {
            return EtkinliklerTable.Instance.KayitColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return EtkinliklerTable.Instance.AktifPasifColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikEgitim column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn EtkinlikEgitimColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.EtkinlikEgitim column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn EtkinlikEgitim
    {
        get
        {
            return EtkinliklerTable.Instance.EtkinlikEgitimColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OlusturulmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturulmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OlusturulmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturulmaTarihi
    {
        get
        {
            return EtkinliklerTable.Instance.OlusturulmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return EtkinliklerTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return EtkinliklerTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Etkinlikler_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return EtkinliklerTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of EtkinliklerRecord records using a where clause.
    /// </summary>
    public static EtkinliklerRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of EtkinliklerRecord records using a where and order by clause.
    /// </summary>
    public static EtkinliklerRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of EtkinliklerRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static EtkinliklerRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = EtkinliklerTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (EtkinliklerRecord[])recList.ToArray(Type.GetType("KumePortali.Business.EtkinliklerRecord"));
    }   
    
    public static EtkinliklerRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = EtkinliklerTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (EtkinliklerRecord[])recList.ToArray(Type.GetType("KumePortali.Business.EtkinliklerRecord"));
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

        return (int)EtkinliklerTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)EtkinliklerTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EtkinliklerRecord record using a where clause.
    /// </summary>
    public static EtkinliklerRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a EtkinliklerRecord record using a where and order by clause.
    /// </summary>
    public static EtkinliklerRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = EtkinliklerTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        EtkinliklerRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (EtkinliklerRecord)recList[0];
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

        return EtkinliklerTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        EtkinliklerRecord[] recs = GetRecords(where);
        return  EtkinliklerTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        EtkinliklerRecord[] recs = GetRecords(where, orderBy);
        return  EtkinliklerTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        EtkinliklerRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  EtkinliklerTable.Instance.CreateDataTable(recs, null);
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
        EtkinliklerTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  EtkinliklerTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return EtkinliklerTable.Instance.ExportRecordData(whereFilter);
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

        return EtkinliklerTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return EtkinliklerTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return EtkinliklerTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return EtkinliklerTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return EtkinliklerTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return EtkinliklerTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = EtkinliklerTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static EtkinliklerRecord GetRecord(string id, bool bMutable)
        {
            return (EtkinliklerRecord)EtkinliklerTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static EtkinliklerRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (EtkinliklerRecord)EtkinliklerTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string KonuValue, 
        string KonuENValue, 
        string OnYaziValue, 
        string OnyaziEnValue, 
        string AciklamaValue, 
        string AciklamaENValue, 
        string EtkinlikBaslangicValue, 
        string EtkinlikBitisValue, 
        string YerValue, 
        string KayitValue, 
        string AktifPasifValue, 
        string EtkinlikEgitimValue, 
        string OlusturulmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(KonuValue, KonuColumn);
        rec.SetString(KonuENValue, KonuENColumn);
        rec.SetString(OnYaziValue, OnYaziColumn);
        rec.SetString(OnyaziEnValue, OnyaziEnColumn);
        rec.SetString(AciklamaValue, AciklamaColumn);
        rec.SetString(AciklamaENValue, AciklamaENColumn);
        rec.SetString(EtkinlikBaslangicValue, EtkinlikBaslangicColumn);
        rec.SetString(EtkinlikBitisValue, EtkinlikBitisColumn);
        rec.SetString(YerValue, YerColumn);
        rec.SetString(KayitValue, KayitColumn);
        rec.SetString(AktifPasifValue, AktifPasifColumn);
        rec.SetString(EtkinlikEgitimValue, EtkinlikEgitimColumn);
        rec.SetString(OlusturulmaTarihiValue, OlusturulmaTarihiColumn);
        rec.SetString(OlusturanIDValue, OlusturanIDColumn);
        rec.SetString(DuzenlenmeTarihiValue, DuzenlenmeTarihiColumn);
        rec.SetString(DuzenleyenIDValue, DuzenleyenIDColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			EtkinliklerTable.Instance.DeleteOneRecord(kv);
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
				EtkinliklerTable.GetRecord(kv, false);
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
            if (!(EtkinliklerTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return EtkinliklerTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(EtkinliklerTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = EtkinliklerTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = EtkinliklerTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (EtkinliklerTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = EtkinliklerTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
