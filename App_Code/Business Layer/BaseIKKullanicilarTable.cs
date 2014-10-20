﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in IKKullanicilarTable.cs


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
/// The generated superclass for the <see cref="IKKullanicilarTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named IKKullanicilar.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="IKKullanicilarTable.Instance">IKKullanicilarTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="IKKullanicilarTable"></seealso>
[SerializableAttribute()]
public class BaseIKKullanicilarTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = IKKullanicilarDefinition.GetXMLString();







    protected BaseIKKullanicilarTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IKKullanicilarTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IKKullanicilarRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new IKKullanicilarSqlTable();
        ((IKKullanicilarSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.KullaniciID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn KullaniciIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.KullaniciID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn KullaniciID
    {
        get
        {
            return IKKullanicilarTable.Instance.KullaniciIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Adi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Adi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Adi
    {
        get
        {
            return IKKullanicilarTable.Instance.AdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Soyadi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn SoyadiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Soyadi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Soyadi
    {
        get
        {
            return IKKullanicilarTable.Instance.SoyadiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Eposta column object.
    /// </summary>
    public BaseClasses.Data.StringColumn EpostaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Eposta column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Eposta
    {
        get
        {
            return IKKullanicilarTable.Instance.EpostaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.GSM column object.
    /// </summary>
    public BaseClasses.Data.StringColumn GSMColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.GSM column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn GSM
    {
        get
        {
            return IKKullanicilarTable.Instance.GSMColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return IKKullanicilarTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.UnvanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn UnvanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.UnvanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn UnvanID
    {
        get
        {
            return IKKullanicilarTable.Instance.UnvanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.YetkiTurID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn YetkiTurIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.YetkiTurID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn YetkiTurID
    {
        get
        {
            return IKKullanicilarTable.Instance.YetkiTurIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.HesapID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn HesapIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.HesapID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn HesapID
    {
        get
        {
            return IKKullanicilarTable.Instance.HesapIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.TCKimlikNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TCKimlikNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.TCKimlikNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TCKimlikNo
    {
        get
        {
            return IKKullanicilarTable.Instance.TCKimlikNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.IsTelefonu column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IsTelefonuColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.IsTelefonu column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IsTelefonu
    {
        get
        {
            return IKKullanicilarTable.Instance.IsTelefonuColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.KullaniciAdi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KullaniciAdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.KullaniciAdi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn KullaniciAdi
    {
        get
        {
            return IKKullanicilarTable.Instance.KullaniciAdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Sifre column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn SifreColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.Sifre column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn Sifre
    {
        get
        {
            return IKKullanicilarTable.Instance.SifreColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return IKKullanicilarTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return IKKullanicilarTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return IKKullanicilarTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return IKKullanicilarTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's IKKullanicilar_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return IKKullanicilarTable.Instance.AktifPasifColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of IKKullanicilarRecord records using a where clause.
    /// </summary>
    public static IKKullanicilarRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of IKKullanicilarRecord records using a where and order by clause.
    /// </summary>
    public static IKKullanicilarRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of IKKullanicilarRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static IKKullanicilarRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = IKKullanicilarTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (IKKullanicilarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IKKullanicilarRecord"));
    }   
    
    public static IKKullanicilarRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = IKKullanicilarTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (IKKullanicilarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IKKullanicilarRecord"));
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

        return (int)IKKullanicilarTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)IKKullanicilarTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IKKullanicilarRecord record using a where clause.
    /// </summary>
    public static IKKullanicilarRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IKKullanicilarRecord record using a where and order by clause.
    /// </summary>
    public static IKKullanicilarRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = IKKullanicilarTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        IKKullanicilarRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (IKKullanicilarRecord)recList[0];
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

        return IKKullanicilarTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        IKKullanicilarRecord[] recs = GetRecords(where);
        return  IKKullanicilarTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        IKKullanicilarRecord[] recs = GetRecords(where, orderBy);
        return  IKKullanicilarTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        IKKullanicilarRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  IKKullanicilarTable.Instance.CreateDataTable(recs, null);
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
        IKKullanicilarTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  IKKullanicilarTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return IKKullanicilarTable.Instance.ExportRecordData(whereFilter);
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

        return IKKullanicilarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return IKKullanicilarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return IKKullanicilarTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return IKKullanicilarTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return IKKullanicilarTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return IKKullanicilarTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = IKKullanicilarTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static IKKullanicilarRecord GetRecord(string id, bool bMutable)
        {
            return (IKKullanicilarRecord)IKKullanicilarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static IKKullanicilarRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (IKKullanicilarRecord)IKKullanicilarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string AdiValue, 
        string SoyadiValue, 
        string EpostaValue, 
        string GSMValue, 
        string FirmaIDValue, 
        string UnvanIDValue, 
        string YetkiTurIDValue, 
        string HesapIDValue, 
        string TCKimlikNoValue, 
        string IsTelefonuValue, 
        string KullaniciAdiValue, 
        string SifreValue, 
        string OlusturmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue, 
        string AktifPasifValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(AdiValue, AdiColumn);
        rec.SetString(SoyadiValue, SoyadiColumn);
        rec.SetString(EpostaValue, EpostaColumn);
        rec.SetString(GSMValue, GSMColumn);
        rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(UnvanIDValue, UnvanIDColumn);
        rec.SetString(YetkiTurIDValue, YetkiTurIDColumn);
        rec.SetString(HesapIDValue, HesapIDColumn);
        rec.SetString(TCKimlikNoValue, TCKimlikNoColumn);
        rec.SetString(IsTelefonuValue, IsTelefonuColumn);
        rec.SetString(KullaniciAdiValue, KullaniciAdiColumn);
        rec.SetString(SifreValue, SifreColumn);
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
			IKKullanicilarTable.Instance.DeleteOneRecord(kv);
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
				IKKullanicilarTable.GetRecord(kv, false);
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
            if (!(IKKullanicilarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return IKKullanicilarTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(IKKullanicilarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = IKKullanicilarTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = IKKullanicilarTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (IKKullanicilarTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = IKKullanicilarTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
