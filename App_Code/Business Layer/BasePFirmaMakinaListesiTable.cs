// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaMakinaListesiTable.cs


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
/// The generated superclass for the <see cref="PFirmaMakinaListesiTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named PFirmaMakinaListesi.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="PFirmaMakinaListesiTable.Instance">PFirmaMakinaListesiTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="PFirmaMakinaListesiTable"></seealso>
[SerializableAttribute()]
public class BasePFirmaMakinaListesiTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = PFirmaMakinaListesiDefinition.GetXMLString();







    protected BasePFirmaMakinaListesiTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.PFirmaMakinaListesiTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.PFirmaMakinaListesiRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new PFirmaMakinaListesiSqlTable();
        ((PFirmaMakinaListesiSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.MakineListeID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MakineListeIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.MakineListeID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MakineListeID
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.MakineListeIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.MakinaAdi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MakinaAdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.MakinaAdi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MakinaAdi
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.MakinaAdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.YapimYili column object.
    /// </summary>
    public BaseClasses.Data.StringColumn YapimYiliColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.YapimYili column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn YapimYili
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.YapimYiliColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.CalismaSaati column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CalismaSaatiColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.CalismaSaati column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CalismaSaati
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.CalismaSaatiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.SonBakimTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn SonBakimTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.SonBakimTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn SonBakimTarihi
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.SonBakimTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PFirmaMakinaListesi_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return PFirmaMakinaListesiTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of PFirmaMakinaListesiRecord records using a where clause.
    /// </summary>
    public static PFirmaMakinaListesiRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of PFirmaMakinaListesiRecord records using a where and order by clause.
    /// </summary>
    public static PFirmaMakinaListesiRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of PFirmaMakinaListesiRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static PFirmaMakinaListesiRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = PFirmaMakinaListesiTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (PFirmaMakinaListesiRecord[])recList.ToArray(Type.GetType("KumePortali.Business.PFirmaMakinaListesiRecord"));
    }   
    
    public static PFirmaMakinaListesiRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = PFirmaMakinaListesiTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (PFirmaMakinaListesiRecord[])recList.ToArray(Type.GetType("KumePortali.Business.PFirmaMakinaListesiRecord"));
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

        return (int)PFirmaMakinaListesiTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)PFirmaMakinaListesiTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PFirmaMakinaListesiRecord record using a where clause.
    /// </summary>
    public static PFirmaMakinaListesiRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PFirmaMakinaListesiRecord record using a where and order by clause.
    /// </summary>
    public static PFirmaMakinaListesiRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = PFirmaMakinaListesiTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        PFirmaMakinaListesiRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (PFirmaMakinaListesiRecord)recList[0];
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

        return PFirmaMakinaListesiTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        PFirmaMakinaListesiRecord[] recs = GetRecords(where);
        return  PFirmaMakinaListesiTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        PFirmaMakinaListesiRecord[] recs = GetRecords(where, orderBy);
        return  PFirmaMakinaListesiTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        PFirmaMakinaListesiRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  PFirmaMakinaListesiTable.Instance.CreateDataTable(recs, null);
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
        PFirmaMakinaListesiTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  PFirmaMakinaListesiTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return PFirmaMakinaListesiTable.Instance.ExportRecordData(whereFilter);
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

        return PFirmaMakinaListesiTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return PFirmaMakinaListesiTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return PFirmaMakinaListesiTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return PFirmaMakinaListesiTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return PFirmaMakinaListesiTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return PFirmaMakinaListesiTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = PFirmaMakinaListesiTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static PFirmaMakinaListesiRecord GetRecord(string id, bool bMutable)
        {
            return (PFirmaMakinaListesiRecord)PFirmaMakinaListesiTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static PFirmaMakinaListesiRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (PFirmaMakinaListesiRecord)PFirmaMakinaListesiTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string MakinaAdiValue, 
        string YapimYiliValue, 
        string CalismaSaatiValue, 
        string SonBakimTarihiValue, 
        string FirmaIDValue, 
        string OlusturmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(MakinaAdiValue, MakinaAdiColumn);
        rec.SetString(YapimYiliValue, YapimYiliColumn);
        rec.SetString(CalismaSaatiValue, CalismaSaatiColumn);
        rec.SetString(SonBakimTarihiValue, SonBakimTarihiColumn);
        rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(OlusturmaTarihiValue, OlusturmaTarihiColumn);
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
			PFirmaMakinaListesiTable.Instance.DeleteOneRecord(kv);
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
				PFirmaMakinaListesiTable.GetRecord(kv, false);
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
            if (!(PFirmaMakinaListesiTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return PFirmaMakinaListesiTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(PFirmaMakinaListesiTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = PFirmaMakinaListesiTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = PFirmaMakinaListesiTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (PFirmaMakinaListesiTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = PFirmaMakinaListesiTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
