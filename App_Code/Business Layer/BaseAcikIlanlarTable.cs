// This class is "generated" and will be overwritten.
// Your customizations should be made in AcikIlanlarTable.cs


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
/// The generated superclass for the <see cref="AcikIlanlarTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named AcikIlanlar.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="AcikIlanlarTable.Instance">AcikIlanlarTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="AcikIlanlarTable"></seealso>
[SerializableAttribute()]
public class BaseAcikIlanlarTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = AcikIlanlarDefinition.GetXMLString();







    protected BaseAcikIlanlarTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.AcikIlanlarTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.AcikIlanlarRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new AcikIlanlarSqlTable();
        ((AcikIlanlarSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IlanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IlanID
    {
        get
        {
            return AcikIlanlarTable.Instance.IlanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IlanNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IlanNo
    {
        get
        {
            return AcikIlanlarTable.Instance.IlanNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return AcikIlanlarTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.PozisyonAdi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PozisyonAdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.PozisyonAdi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PozisyonAdi
    {
        get
        {
            return AcikIlanlarTable.Instance.PozisyonAdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IsTanimi column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn IsTanimiColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IsTanimi column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn IsTanimi
    {
        get
        {
            return AcikIlanlarTable.Instance.IsTanimiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.ArananNitelikler column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn ArananNiteliklerColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.ArananNitelikler column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn ArananNitelikler
    {
        get
        {
            return AcikIlanlarTable.Instance.ArananNiteliklerColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IsAlani column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn IsAlaniColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IsAlani column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn IsAlani
    {
        get
        {
            return AcikIlanlarTable.Instance.IsAlaniColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.OrganizasyondakiYeri column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OrganizasyondakiYeriColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.OrganizasyondakiYeri column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OrganizasyondakiYeri
    {
        get
        {
            return AcikIlanlarTable.Instance.OrganizasyondakiYeriColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.CalismaSekli column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CalismaSekliColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.CalismaSekli column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CalismaSekli
    {
        get
        {
            return AcikIlanlarTable.Instance.CalismaSekliColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanBaslangicTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn IlanBaslangicTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanBaslangicTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn IlanBaslangicTarihi
    {
        get
        {
            return AcikIlanlarTable.Instance.IlanBaslangicTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanBitisTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn IlanBitisTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanBitisTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn IlanBitisTarihi
    {
        get
        {
            return AcikIlanlarTable.Instance.IlanBitisTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanDurumu column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn IlanDurumuColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.IlanDurumu column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn IlanDurumu
    {
        get
        {
            return AcikIlanlarTable.Instance.IlanDurumuColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return AcikIlanlarTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return AcikIlanlarTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return AcikIlanlarTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return AcikIlanlarTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's AcikIlanlar_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return AcikIlanlarTable.Instance.AktifPasifColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of AcikIlanlarRecord records using a where clause.
    /// </summary>
    public static AcikIlanlarRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of AcikIlanlarRecord records using a where and order by clause.
    /// </summary>
    public static AcikIlanlarRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of AcikIlanlarRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static AcikIlanlarRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = AcikIlanlarTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (AcikIlanlarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.AcikIlanlarRecord"));
    }   
    
    public static AcikIlanlarRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = AcikIlanlarTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (AcikIlanlarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.AcikIlanlarRecord"));
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

        return (int)AcikIlanlarTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)AcikIlanlarTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a AcikIlanlarRecord record using a where clause.
    /// </summary>
    public static AcikIlanlarRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a AcikIlanlarRecord record using a where and order by clause.
    /// </summary>
    public static AcikIlanlarRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = AcikIlanlarTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        AcikIlanlarRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (AcikIlanlarRecord)recList[0];
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

        return AcikIlanlarTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        AcikIlanlarRecord[] recs = GetRecords(where);
        return  AcikIlanlarTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        AcikIlanlarRecord[] recs = GetRecords(where, orderBy);
        return  AcikIlanlarTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        AcikIlanlarRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  AcikIlanlarTable.Instance.CreateDataTable(recs, null);
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
        AcikIlanlarTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  AcikIlanlarTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return AcikIlanlarTable.Instance.ExportRecordData(whereFilter);
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

        return AcikIlanlarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return AcikIlanlarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return AcikIlanlarTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return AcikIlanlarTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return AcikIlanlarTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return AcikIlanlarTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = AcikIlanlarTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static AcikIlanlarRecord GetRecord(string id, bool bMutable)
        {
            return (AcikIlanlarRecord)AcikIlanlarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static AcikIlanlarRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (AcikIlanlarRecord)AcikIlanlarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string IlanNoValue, 
        string FirmaIDValue, 
        string PozisyonAdiValue, 
        string IsTanimiValue, 
        string ArananNiteliklerValue, 
        string IsAlaniValue, 
        string OrganizasyondakiYeriValue, 
        string CalismaSekliValue, 
        string IlanBaslangicTarihiValue, 
        string IlanBitisTarihiValue, 
        string IlanDurumuValue, 
        string OlusturmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue, 
        string AktifPasifValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(IlanNoValue, IlanNoColumn);
        rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(PozisyonAdiValue, PozisyonAdiColumn);
        rec.SetString(IsTanimiValue, IsTanimiColumn);
        rec.SetString(ArananNiteliklerValue, ArananNiteliklerColumn);
        rec.SetString(IsAlaniValue, IsAlaniColumn);
        rec.SetString(OrganizasyondakiYeriValue, OrganizasyondakiYeriColumn);
        rec.SetString(CalismaSekliValue, CalismaSekliColumn);
        rec.SetString(IlanBaslangicTarihiValue, IlanBaslangicTarihiColumn);
        rec.SetString(IlanBitisTarihiValue, IlanBitisTarihiColumn);
        rec.SetString(IlanDurumuValue, IlanDurumuColumn);
        rec.SetString(OlusturmaTarihiValue, OlusturmaTarihiColumn);
        rec.SetString(OlusturanIDValue, OlusturanIDColumn);
        rec.SetString(DuzenlenmeTarihiValue, DuzenlenmeTarihiColumn);
        rec.SetString(DuzenleyenIDValue, DuzenleyenIDColumn);
        rec.SetString(AktifPasifValue, AktifPasifColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			AcikIlanlarTable.Instance.DeleteOneRecord(kv);
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
				AcikIlanlarTable.GetRecord(kv, false);
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
            if (!(AcikIlanlarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return AcikIlanlarTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(AcikIlanlarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = AcikIlanlarTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = AcikIlanlarTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (AcikIlanlarTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = AcikIlanlarTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
