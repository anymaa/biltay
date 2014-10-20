// This class is "generated" and will be overwritten.
// Your customizations should be made in TedarikciDegerlendirmeTable.cs


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
/// The generated superclass for the <see cref="TedarikciDegerlendirmeTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named TedarikciDegerlendirme.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="TedarikciDegerlendirmeTable.Instance">TedarikciDegerlendirmeTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="TedarikciDegerlendirmeTable"></seealso>
[SerializableAttribute()]
public class BaseTedarikciDegerlendirmeTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = TedarikciDegerlendirmeDefinition.GetXMLString();







    protected BaseTedarikciDegerlendirmeTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.TedarikciDegerlendirmeTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.TedarikciDegerlendirmeRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new TedarikciDegerlendirmeSqlTable();
        ((TedarikciDegerlendirmeSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.DegerlendirmeID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DegerlendirmeIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.DegerlendirmeID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DegerlendirmeID
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.DegerlendirmeIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.IhaleID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IhaleIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.IhaleID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IhaleID
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.IhaleIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.IhaleTeklifID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IhaleTeklifIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.IhaleTeklifID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IhaleTeklifID
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.IhaleTeklifIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.TeslimTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn TeslimTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.TeslimTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn TeslimTarihi
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.TeslimTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.Gonderilen column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn GonderilenColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.Gonderilen column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Gonderilen
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.GonderilenColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.Fire column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FireColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.Fire column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Fire
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.FireColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.SorunlaraCozum column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SorunlaraCozumColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.SorunlaraCozum column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SorunlaraCozum
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.SorunlaraCozumColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.TeknikYeterlilik column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TeknikYeterlilikColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.TeknikYeterlilik column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TeknikYeterlilik
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.TeknikYeterlilikColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.TalepleriKarsilayabilme column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TalepleriKarsilayabilmeColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.TalepleriKarsilayabilme column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn TalepleriKarsilayabilme
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.TalepleriKarsilayabilmeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.KaliteProsesleri column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn KaliteProsesleriColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.KaliteProsesleri column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn KaliteProsesleri
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.KaliteProsesleriColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's TedarikciDegerlendirme_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return TedarikciDegerlendirmeTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of TedarikciDegerlendirmeRecord records using a where clause.
    /// </summary>
    public static TedarikciDegerlendirmeRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of TedarikciDegerlendirmeRecord records using a where and order by clause.
    /// </summary>
    public static TedarikciDegerlendirmeRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of TedarikciDegerlendirmeRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static TedarikciDegerlendirmeRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = TedarikciDegerlendirmeTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (TedarikciDegerlendirmeRecord[])recList.ToArray(Type.GetType("KumePortali.Business.TedarikciDegerlendirmeRecord"));
    }   
    
    public static TedarikciDegerlendirmeRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = TedarikciDegerlendirmeTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (TedarikciDegerlendirmeRecord[])recList.ToArray(Type.GetType("KumePortali.Business.TedarikciDegerlendirmeRecord"));
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

        return (int)TedarikciDegerlendirmeTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)TedarikciDegerlendirmeTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a TedarikciDegerlendirmeRecord record using a where clause.
    /// </summary>
    public static TedarikciDegerlendirmeRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a TedarikciDegerlendirmeRecord record using a where and order by clause.
    /// </summary>
    public static TedarikciDegerlendirmeRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = TedarikciDegerlendirmeTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        TedarikciDegerlendirmeRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (TedarikciDegerlendirmeRecord)recList[0];
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

        return TedarikciDegerlendirmeTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        TedarikciDegerlendirmeRecord[] recs = GetRecords(where);
        return  TedarikciDegerlendirmeTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        TedarikciDegerlendirmeRecord[] recs = GetRecords(where, orderBy);
        return  TedarikciDegerlendirmeTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        TedarikciDegerlendirmeRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  TedarikciDegerlendirmeTable.Instance.CreateDataTable(recs, null);
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
        TedarikciDegerlendirmeTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  TedarikciDegerlendirmeTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return TedarikciDegerlendirmeTable.Instance.ExportRecordData(whereFilter);
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

        return TedarikciDegerlendirmeTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return TedarikciDegerlendirmeTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return TedarikciDegerlendirmeTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return TedarikciDegerlendirmeTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return TedarikciDegerlendirmeTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return TedarikciDegerlendirmeTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = TedarikciDegerlendirmeTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static TedarikciDegerlendirmeRecord GetRecord(string id, bool bMutable)
        {
            return (TedarikciDegerlendirmeRecord)TedarikciDegerlendirmeTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static TedarikciDegerlendirmeRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (TedarikciDegerlendirmeRecord)TedarikciDegerlendirmeTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string IhaleIDValue, 
        string IhaleTeklifIDValue, 
        string FirmaIDValue, 
        string TeslimTarihiValue, 
        string GonderilenValue, 
        string FireValue, 
        string SorunlaraCozumValue, 
        string TeknikYeterlilikValue, 
        string TalepleriKarsilayabilmeValue, 
        string KaliteProsesleriValue, 
        string OlusturmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(IhaleIDValue, IhaleIDColumn);
        rec.SetString(IhaleTeklifIDValue, IhaleTeklifIDColumn);
        rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(TeslimTarihiValue, TeslimTarihiColumn);
        rec.SetString(GonderilenValue, GonderilenColumn);
        rec.SetString(FireValue, FireColumn);
        rec.SetString(SorunlaraCozumValue, SorunlaraCozumColumn);
        rec.SetString(TeknikYeterlilikValue, TeknikYeterlilikColumn);
        rec.SetString(TalepleriKarsilayabilmeValue, TalepleriKarsilayabilmeColumn);
        rec.SetString(KaliteProsesleriValue, KaliteProsesleriColumn);
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
			TedarikciDegerlendirmeTable.Instance.DeleteOneRecord(kv);
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
				TedarikciDegerlendirmeTable.GetRecord(kv, false);
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
            if (!(TedarikciDegerlendirmeTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return TedarikciDegerlendirmeTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(TedarikciDegerlendirmeTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = TedarikciDegerlendirmeTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = TedarikciDegerlendirmeTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (TedarikciDegerlendirmeTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = TedarikciDegerlendirmeTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
