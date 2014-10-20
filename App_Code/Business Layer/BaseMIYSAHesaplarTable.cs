// This class is "generated" and will be overwritten.
// Your customizations should be made in MIYSAHesaplarTable.cs


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
/// The generated superclass for the <see cref="MIYSAHesaplarTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named MIYSAHesaplar.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="MIYSAHesaplarTable.Instance">MIYSAHesaplarTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="MIYSAHesaplarTable"></seealso>
[SerializableAttribute()]
public class BaseMIYSAHesaplarTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = MIYSAHesaplarDefinition.GetXMLString();







    protected BaseMIYSAHesaplarTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.MIYSAHesaplarTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.MIYSAHesaplarRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new MIYSAHesaplarSqlTable();
        ((MIYSAHesaplarSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.HesapID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn HesapIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.HesapID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn HesapID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.HesapIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.HesapTurID column object.
    /// </summary>
    public BaseClasses.Data.StringColumn HesapTurIDColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.HesapTurID column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn HesapTurID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.HesapTurIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaAdi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirmaAdiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaAdi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirmaAdi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaAdiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.Adres column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AdresColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.Adres column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Adres
    {
        get
        {
            return MIYSAHesaplarTable.Instance.AdresColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.IlID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IlIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.IlID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IlID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.IlIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.IlceID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IlceIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.IlceID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IlceID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.IlceIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.Telefon column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TelefonColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.Telefon column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Telefon
    {
        get
        {
            return MIYSAHesaplarTable.Instance.TelefonColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.Eposta column object.
    /// </summary>
    public BaseClasses.Data.StringColumn EpostaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.Eposta column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Eposta
    {
        get
        {
            return MIYSAHesaplarTable.Instance.EpostaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.WebSite column object.
    /// </summary>
    public BaseClasses.Data.StringColumn WebSiteColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.WebSite column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn WebSite
    {
        get
        {
            return MIYSAHesaplarTable.Instance.WebSiteColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FaaliyetAlaniID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FaaliyetAlaniIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FaaliyetAlaniID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FaaliyetAlaniID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FaaliyetAlaniIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.ArgeCalismasi column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ArgeCalismasiColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.ArgeCalismasi column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn ArgeCalismasi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.ArgeCalismasiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaOnYazisi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirmaOnYazisiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaOnYazisi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirmaOnYazisi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaOnYazisiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaOnYazisiEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirmaOnYazisiENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaOnYazisiEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirmaOnYazisiEN
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaOnYazisiENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaTanitim column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn FirmaTanitimColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaTanitim column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn FirmaTanitim
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaTanitimColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaTanitimEN column object.
    /// </summary>
    public BaseClasses.Data.ClobColumn FirmaTanitimENColumn
    {
        get
        {
            return (BaseClasses.Data.ClobColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaTanitimEN column object.
    /// </summary>
    public static BaseClasses.Data.ClobColumn FirmaTanitimEN
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaTanitimENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaLogo column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn FirmaLogoColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaLogo column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn FirmaLogo
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaLogoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaTanitimDosyasi column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn FirmaTanitimDosyasiColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaTanitimDosyasi column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn FirmaTanitimDosyasi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaTanitimDosyasiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaSunumDosyasi column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn FirmaSunumDosyasiColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaSunumDosyasi column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn FirmaSunumDosyasi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaSunumDosyasiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaKatalogDosyasi column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn FirmaKatalogDosyasiColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.FirmaKatalogDosyasi column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn FirmaKatalogDosyasi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.FirmaKatalogDosyasiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return MIYSAHesaplarTable.Instance.AktifPasifColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return MIYSAHesaplarTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MIYSAHesaplar_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return MIYSAHesaplarTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of MIYSAHesaplarRecord records using a where clause.
    /// </summary>
    public static MIYSAHesaplarRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of MIYSAHesaplarRecord records using a where and order by clause.
    /// </summary>
    public static MIYSAHesaplarRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MIYSAHesaplarRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MIYSAHesaplarRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = MIYSAHesaplarTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (MIYSAHesaplarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.MIYSAHesaplarRecord"));
    }   
    
    public static MIYSAHesaplarRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = MIYSAHesaplarTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (MIYSAHesaplarRecord[])recList.ToArray(Type.GetType("KumePortali.Business.MIYSAHesaplarRecord"));
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

        return (int)MIYSAHesaplarTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)MIYSAHesaplarTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MIYSAHesaplarRecord record using a where clause.
    /// </summary>
    public static MIYSAHesaplarRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MIYSAHesaplarRecord record using a where and order by clause.
    /// </summary>
    public static MIYSAHesaplarRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = MIYSAHesaplarTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MIYSAHesaplarRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MIYSAHesaplarRecord)recList[0];
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

        return MIYSAHesaplarTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        MIYSAHesaplarRecord[] recs = GetRecords(where);
        return  MIYSAHesaplarTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        MIYSAHesaplarRecord[] recs = GetRecords(where, orderBy);
        return  MIYSAHesaplarTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MIYSAHesaplarRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  MIYSAHesaplarTable.Instance.CreateDataTable(recs, null);
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
        MIYSAHesaplarTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  MIYSAHesaplarTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return MIYSAHesaplarTable.Instance.ExportRecordData(whereFilter);
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

        return MIYSAHesaplarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return MIYSAHesaplarTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return MIYSAHesaplarTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return MIYSAHesaplarTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return MIYSAHesaplarTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return MIYSAHesaplarTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = MIYSAHesaplarTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static MIYSAHesaplarRecord GetRecord(string id, bool bMutable)
        {
            return (MIYSAHesaplarRecord)MIYSAHesaplarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static MIYSAHesaplarRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (MIYSAHesaplarRecord)MIYSAHesaplarTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string HesapTurIDValue, 
        string FirmaAdiValue, 
        string AdresValue, 
        string IlIDValue, 
        string IlceIDValue, 
        string TelefonValue, 
        string EpostaValue, 
        string WebSiteValue, 
        string FaaliyetAlaniIDValue, 
        string ArgeCalismasiValue, 
        string FirmaOnYazisiValue, 
        string FirmaOnYazisiENValue, 
        string FirmaTanitimValue, 
        string FirmaTanitimENValue, 
        string FirmaLogoValue, 
        string FirmaTanitimDosyasiValue, 
        string FirmaSunumDosyasiValue, 
        string FirmaKatalogDosyasiValue, 
        string AktifPasifValue, 
        string OlusturmaTarihiValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(HesapTurIDValue, HesapTurIDColumn);
        rec.SetString(FirmaAdiValue, FirmaAdiColumn);
        rec.SetString(AdresValue, AdresColumn);
        rec.SetString(IlIDValue, IlIDColumn);
        rec.SetString(IlceIDValue, IlceIDColumn);
        rec.SetString(TelefonValue, TelefonColumn);
        rec.SetString(EpostaValue, EpostaColumn);
        rec.SetString(WebSiteValue, WebSiteColumn);
        rec.SetString(FaaliyetAlaniIDValue, FaaliyetAlaniIDColumn);
        rec.SetString(ArgeCalismasiValue, ArgeCalismasiColumn);
        rec.SetString(FirmaOnYazisiValue, FirmaOnYazisiColumn);
        rec.SetString(FirmaOnYazisiENValue, FirmaOnYazisiENColumn);
        rec.SetString(FirmaTanitimValue, FirmaTanitimColumn);
        rec.SetString(FirmaTanitimENValue, FirmaTanitimENColumn);
        rec.SetString(FirmaLogoValue, FirmaLogoColumn);
        rec.SetString(FirmaTanitimDosyasiValue, FirmaTanitimDosyasiColumn);
        rec.SetString(FirmaSunumDosyasiValue, FirmaSunumDosyasiColumn);
        rec.SetString(FirmaKatalogDosyasiValue, FirmaKatalogDosyasiColumn);
        rec.SetString(AktifPasifValue, AktifPasifColumn);
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
			MIYSAHesaplarTable.Instance.DeleteOneRecord(kv);
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
				MIYSAHesaplarTable.GetRecord(kv, false);
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
            if (!(MIYSAHesaplarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return MIYSAHesaplarTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(MIYSAHesaplarTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = MIYSAHesaplarTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = MIYSAHesaplarTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (MIYSAHesaplarTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = MIYSAHesaplarTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
