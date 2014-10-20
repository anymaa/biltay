// This class is "generated" and will be overwritten.
// Your customizations should be made in PYProjelerTable.cs


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
/// The generated superclass for the <see cref="PYProjelerTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named PYProjeler.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="PYProjelerTable.Instance">PYProjelerTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="PYProjelerTable"></seealso>
[SerializableAttribute()]
public class BasePYProjelerTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = PYProjelerDefinition.GetXMLString();







    protected BasePYProjelerTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.PYProjelerTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.PYProjelerRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new PYProjelerSqlTable();
        ((PYProjelerSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ProjeIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ProjeID
    {
        get
        {
            return PYProjelerTable.Instance.ProjeIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Konu column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KonuColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Konu column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Konu
    {
        get
        {
            return PYProjelerTable.Instance.KonuColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.KonuEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn KonuENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.KonuEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn KonuEN
    {
        get
        {
            return PYProjelerTable.Instance.KonuENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Onyazi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OnyaziColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Onyazi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Onyazi
    {
        get
        {
            return PYProjelerTable.Instance.OnyaziColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.OnYaziEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn OnYaziENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.OnYaziEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn OnYaziEN
    {
        get
        {
            return PYProjelerTable.Instance.OnYaziENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Resim column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn ResimColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Resim column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn Resim
    {
        get
        {
            return PYProjelerTable.Instance.ResimColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.DosyaLinki column object.
    /// </summary>
    public BaseClasses.Data.StringColumn DosyaLinkiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.DosyaLinki column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn DosyaLinki
    {
        get
        {
            return PYProjelerTable.Instance.DosyaLinkiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeYoneticisi column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ProjeYoneticisiColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeYoneticisi column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ProjeYoneticisi
    {
        get
        {
            return PYProjelerTable.Instance.ProjeYoneticisiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeEkibi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ProjeEkibiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeEkibi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ProjeEkibi
    {
        get
        {
            return PYProjelerTable.Instance.ProjeEkibiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeOnerisiTum column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ProjeOnerisiTumColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeOnerisiTum column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ProjeOnerisiTum
    {
        get
        {
            return PYProjelerTable.Instance.ProjeOnerisiTumColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeOnerisiTumEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn ProjeOnerisiTumENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeOnerisiTumEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn ProjeOnerisiTumEN
    {
        get
        {
            return PYProjelerTable.Instance.ProjeOnerisiTumENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.UniversiteFakulteBolum column object.
    /// </summary>
    public BaseClasses.Data.BinaryColumn UniversiteFakulteBolumColumn
    {
        get
        {
            return (BaseClasses.Data.BinaryColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.UniversiteFakulteBolum column object.
    /// </summary>
    public static BaseClasses.Data.BinaryColumn UniversiteFakulteBolum
    {
        get
        {
            return PYProjelerTable.Instance.UniversiteFakulteBolumColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeBitisTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn ProjeBitisTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.ProjeBitisTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn ProjeBitisTarihi
    {
        get
        {
            return PYProjelerTable.Instance.ProjeBitisTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Iletisim column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IletisimColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.Iletisim column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Iletisim
    {
        get
        {
            return PYProjelerTable.Instance.IletisimColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return PYProjelerTable.Instance.AktifPasifColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.OnaylanmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OnaylanmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.OnaylanmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OnaylanmaTarihi
    {
        get
        {
            return PYProjelerTable.Instance.OnaylanmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.OnaylayanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OnaylayanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.OnaylayanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OnaylayanID
    {
        get
        {
            return PYProjelerTable.Instance.OnaylayanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return PYProjelerTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's PYProjeler_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return PYProjelerTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of PYProjelerRecord records using a where clause.
    /// </summary>
    public static PYProjelerRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of PYProjelerRecord records using a where and order by clause.
    /// </summary>
    public static PYProjelerRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of PYProjelerRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static PYProjelerRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = PYProjelerTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (PYProjelerRecord[])recList.ToArray(Type.GetType("KumePortali.Business.PYProjelerRecord"));
    }   
    
    public static PYProjelerRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = PYProjelerTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (PYProjelerRecord[])recList.ToArray(Type.GetType("KumePortali.Business.PYProjelerRecord"));
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

        return (int)PYProjelerTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)PYProjelerTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PYProjelerRecord record using a where clause.
    /// </summary>
    public static PYProjelerRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a PYProjelerRecord record using a where and order by clause.
    /// </summary>
    public static PYProjelerRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = PYProjelerTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        PYProjelerRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (PYProjelerRecord)recList[0];
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

        return PYProjelerTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        PYProjelerRecord[] recs = GetRecords(where);
        return  PYProjelerTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        PYProjelerRecord[] recs = GetRecords(where, orderBy);
        return  PYProjelerTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        PYProjelerRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  PYProjelerTable.Instance.CreateDataTable(recs, null);
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
        PYProjelerTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  PYProjelerTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return PYProjelerTable.Instance.ExportRecordData(whereFilter);
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

        return PYProjelerTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return PYProjelerTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return PYProjelerTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return PYProjelerTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return PYProjelerTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return PYProjelerTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = PYProjelerTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static PYProjelerRecord GetRecord(string id, bool bMutable)
        {
            return (PYProjelerRecord)PYProjelerTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static PYProjelerRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (PYProjelerRecord)PYProjelerTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string KonuValue, 
        string KonuENValue, 
        string OnyaziValue, 
        string OnYaziENValue, 
        string ResimValue, 
        string DosyaLinkiValue, 
        string ProjeYoneticisiValue, 
        string ProjeEkibiValue, 
        string ProjeOnerisiTumValue, 
        string ProjeOnerisiTumENValue, 
        string UniversiteFakulteBolumValue, 
        string ProjeBitisTarihiValue, 
        string IletisimValue, 
        string AktifPasifValue, 
        string OnaylanmaTarihiValue, 
        string OnaylayanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(KonuValue, KonuColumn);
        rec.SetString(KonuENValue, KonuENColumn);
        rec.SetString(OnyaziValue, OnyaziColumn);
        rec.SetString(OnYaziENValue, OnYaziENColumn);
        rec.SetString(ResimValue, ResimColumn);
        rec.SetString(DosyaLinkiValue, DosyaLinkiColumn);
        rec.SetString(ProjeYoneticisiValue, ProjeYoneticisiColumn);
        rec.SetString(ProjeEkibiValue, ProjeEkibiColumn);
        rec.SetString(ProjeOnerisiTumValue, ProjeOnerisiTumColumn);
        rec.SetString(ProjeOnerisiTumENValue, ProjeOnerisiTumENColumn);
        rec.SetString(UniversiteFakulteBolumValue, UniversiteFakulteBolumColumn);
        rec.SetString(ProjeBitisTarihiValue, ProjeBitisTarihiColumn);
        rec.SetString(IletisimValue, IletisimColumn);
        rec.SetString(AktifPasifValue, AktifPasifColumn);
        rec.SetString(OnaylanmaTarihiValue, OnaylanmaTarihiColumn);
        rec.SetString(OnaylayanIDValue, OnaylayanIDColumn);
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
			PYProjelerTable.Instance.DeleteOneRecord(kv);
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
				PYProjelerTable.GetRecord(kv, false);
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
            if (!(PYProjelerTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return PYProjelerTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(PYProjelerTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = PYProjelerTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = PYProjelerTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (PYProjelerTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = PYProjelerTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
