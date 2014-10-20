// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleTeklifTable.cs


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
/// The generated superclass for the <see cref="IhaleTeklifTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named IhaleTeklif.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="IhaleTeklifTable.Instance">IhaleTeklifTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="IhaleTeklifTable"></seealso>
[SerializableAttribute()]
public class BaseIhaleTeklifTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = IhaleTeklifDefinition.GetXMLString();







    protected BaseIhaleTeklifTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IhaleTeklifTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IhaleTeklifRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new IhaleTeklifSqlTable();
        ((IhaleTeklifSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.IhaleTeklifID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IhaleTeklifIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.IhaleTeklifID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IhaleTeklifID
    {
        get
        {
            return IhaleTeklifTable.Instance.IhaleTeklifIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return IhaleTeklifTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.FirmaTeklif column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaTeklifColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.FirmaTeklif column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaTeklif
    {
        get
        {
            return IhaleTeklifTable.Instance.FirmaTeklifColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.Aciklama column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AciklamaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.Aciklama column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Aciklama
    {
        get
        {
            return IhaleTeklifTable.Instance.AciklamaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.AciklamaEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AciklamaENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.AciklamaEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn AciklamaEN
    {
        get
        {
            return IhaleTeklifTable.Instance.AciklamaENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.Dosya column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn DosyaColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.Dosya column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn Dosya
    {
        get
        {
            return IhaleTeklifTable.Instance.DosyaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.KontaktID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn KontaktIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.KontaktID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn KontaktID
    {
        get
        {
            return IhaleTeklifTable.Instance.KontaktIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.TeklifTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn TeklifTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.TeklifTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn TeklifTarihi
    {
        get
        {
            return IhaleTeklifTable.Instance.TeklifTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.TerminTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn TerminTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.TerminTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn TerminTarihi
    {
        get
        {
            return IhaleTeklifTable.Instance.TerminTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.ParaBirimID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ParaBirimIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.ParaBirimID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ParaBirimID
    {
        get
        {
            return IhaleTeklifTable.Instance.ParaBirimIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return IhaleTeklifTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return IhaleTeklifTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return IhaleTeklifTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return IhaleTeklifTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IhaleTeklif_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return IhaleTeklifTable.Instance.AktifPasifColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of IhaleTeklifRecord records using a where clause.
    /// </summary>
    public static IhaleTeklifRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of IhaleTeklifRecord records using a where and order by clause.
    /// </summary>
    public static IhaleTeklifRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of IhaleTeklifRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static IhaleTeklifRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = IhaleTeklifTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (IhaleTeklifRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IhaleTeklifRecord"));
    }   
    
    public static IhaleTeklifRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = IhaleTeklifTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (IhaleTeklifRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IhaleTeklifRecord"));
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

        return (int)IhaleTeklifTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)IhaleTeklifTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IhaleTeklifRecord record using a where clause.
    /// </summary>
    public static IhaleTeklifRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IhaleTeklifRecord record using a where and order by clause.
    /// </summary>
    public static IhaleTeklifRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = IhaleTeklifTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        IhaleTeklifRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (IhaleTeklifRecord)recList[0];
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

        return IhaleTeklifTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        IhaleTeklifRecord[] recs = GetRecords(where);
        return  IhaleTeklifTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        IhaleTeklifRecord[] recs = GetRecords(where, orderBy);
        return  IhaleTeklifTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        IhaleTeklifRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  IhaleTeklifTable.Instance.CreateDataTable(recs, null);
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
        IhaleTeklifTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  IhaleTeklifTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return IhaleTeklifTable.Instance.ExportRecordData(whereFilter);
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

        return IhaleTeklifTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return IhaleTeklifTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return IhaleTeklifTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return IhaleTeklifTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return IhaleTeklifTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return IhaleTeklifTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = IhaleTeklifTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static IhaleTeklifRecord GetRecord(string id, bool bMutable)
        {
            return (IhaleTeklifRecord)IhaleTeklifTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static IhaleTeklifRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (IhaleTeklifRecord)IhaleTeklifTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string FirmaIDValue, 
        string FirmaTeklifValue, 
        string AciklamaValue, 
        string AciklamaENValue, 
        string DosyaValue, 
        string KontaktIDValue, 
        string TeklifTarihiValue, 
        string TerminTarihiValue, 
        string ParaBirimIDValue, 
        string OlusturmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue, 
        string AktifPasifValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(FirmaTeklifValue, FirmaTeklifColumn);
        rec.SetString(AciklamaValue, AciklamaColumn);
        rec.SetString(AciklamaENValue, AciklamaENColumn);
        rec.SetString(DosyaValue, DosyaColumn);
        rec.SetString(KontaktIDValue, KontaktIDColumn);
        rec.SetString(TeklifTarihiValue, TeklifTarihiColumn);
        rec.SetString(TerminTarihiValue, TerminTarihiColumn);
        rec.SetString(ParaBirimIDValue, ParaBirimIDColumn);
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
			IhaleTeklifTable.Instance.DeleteOneRecord(kv);
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
				IhaleTeklifTable.GetRecord(kv, false);
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
            if (!(IhaleTeklifTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return IhaleTeklifTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(IhaleTeklifTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = IhaleTeklifTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = IhaleTeklifTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (IhaleTeklifTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = IhaleTeklifTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
