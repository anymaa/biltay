// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleTable.cs


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
/// The generated superclass for the <see cref="IhaleTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named Ihale.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="IhaleTable.Instance">IhaleTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="IhaleTable"></seealso>
[SerializableAttribute()]
public class BaseIhaleTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = IhaleDefinition.GetXMLString();







    protected BaseIhaleTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IhaleTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "KumePortali.Business.IhaleRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new IhaleSqlTable();
        ((IhaleSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IhaleIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IhaleID
    {
        get
        {
            return IhaleTable.Instance.IhaleIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.YetkiliKisiID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn YetkiliKisiIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.YetkiliKisiID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn YetkiliKisiID
    {
        get
        {
            return IhaleTable.Instance.YetkiliKisiIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.FirmaID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn FirmaIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.FirmaID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn FirmaID
    {
        get
        {
            return IhaleTable.Instance.FirmaIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleKaynagi column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IhaleKaynagiColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleKaynagi column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IhaleKaynagi
    {
        get
        {
            return IhaleTable.Instance.IhaleKaynagiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleKayitNoEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IhaleKayitNoENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleKayitNoEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IhaleKayitNoEN
    {
        get
        {
            return IhaleTable.Instance.IhaleKayitNoENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleKayitNo column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IhaleKayitNoColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleKayitNo column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IhaleKayitNo
    {
        get
        {
            return IhaleTable.Instance.IhaleKayitNoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.SonTeklifTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn SonTeklifTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.SonTeklifTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn SonTeklifTarihi
    {
        get
        {
            return IhaleTable.Instance.SonTeklifTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleUsulu column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IhaleUsuluColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleUsulu column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IhaleUsulu
    {
        get
        {
            return IhaleTable.Instance.IhaleUsuluColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleTurID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IhaleTurIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleTurID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IhaleTurID
    {
        get
        {
            return IhaleTable.Instance.IhaleTurIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsinSuresi column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn IsinSuresiColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsinSuresi column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn IsinSuresi
    {
        get
        {
            return IhaleTable.Instance.IsinSuresiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsTeslimTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn IsTeslimTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsTeslimTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn IsTeslimTarihi
    {
        get
        {
            return IhaleTable.Instance.IsTeslimTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.SatinAlmaKatSayisi column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SatinAlmaKatSayisiColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.SatinAlmaKatSayisi column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SatinAlmaKatSayisi
    {
        get
        {
            return IhaleTable.Instance.SatinAlmaKatSayisiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.SatinAlmaBirimID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn SatinAlmaBirimIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.SatinAlmaBirimID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn SatinAlmaBirimID
    {
        get
        {
            return IhaleTable.Instance.SatinAlmaBirimIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.ParaBirimID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ParaBirimIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.ParaBirimID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ParaBirimID
    {
        get
        {
            return IhaleTable.Instance.ParaBirimIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsinYapilacagiYer column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IsinYapilacagiYerColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsinYapilacagiYer column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IsinYapilacagiYer
    {
        get
        {
            return IhaleTable.Instance.IsinYapilacagiYerColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsınYapilacagiYerEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IsınYapilacagiYerENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsınYapilacagiYerEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IsınYapilacagiYerEN
    {
        get
        {
            return IhaleTable.Instance.IsınYapilacagiYerENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.Aciklama column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AciklamaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.Aciklama column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Aciklama
    {
        get
        {
            return IhaleTable.Instance.AciklamaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.AciklamaEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn AciklamaENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.AciklamaEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn AciklamaEN
    {
        get
        {
            return IhaleTable.Instance.AciklamaENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.OlusturmaTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn OlusturmaTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.OlusturmaTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn OlusturmaTarihi
    {
        get
        {
            return IhaleTable.Instance.OlusturmaTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeknikDokuman column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn TeknikDokumanColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeknikDokuman column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn TeknikDokuman
    {
        get
        {
            return IhaleTable.Instance.TeknikDokumanColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleDokuman column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn IhaleDokumanColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IhaleDokuman column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn IhaleDokuman
    {
        get
        {
            return IhaleTable.Instance.IhaleDokumanColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DokumanAciklama column object.
    /// </summary>
    public BaseClasses.Data.StringColumn DokumanAciklamaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DokumanAciklama column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn DokumanAciklama
    {
        get
        {
            return IhaleTable.Instance.DokumanAciklamaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DokumanAciklamaEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn DokumanAciklamaENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DokumanAciklamaEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn DokumanAciklamaEN
    {
        get
        {
            return IhaleTable.Instance.DokumanAciklamaENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsBitirmeDokuman column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn IsBitirmeDokumanColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.IsBitirmeDokuman column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn IsBitirmeDokuman
    {
        get
        {
            return IhaleTable.Instance.IsBitirmeDokumanColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeminatMektubu column object.
    /// </summary>
    public BaseClasses.Data.ImageColumn TeminatMektubuColumn
    {
        get
        {
            return (BaseClasses.Data.ImageColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeminatMektubu column object.
    /// </summary>
    public static BaseClasses.Data.ImageColumn TeminatMektubu
    {
        get
        {
            return IhaleTable.Instance.TeminatMektubuColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeminatAciklama column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TeminatAciklamaColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeminatAciklama column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TeminatAciklama
    {
        get
        {
            return IhaleTable.Instance.TeminatAciklamaColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeminatAciklamaEN column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TeminatAciklamaENColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.TeminatAciklamaEN column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TeminatAciklamaEN
    {
        get
        {
            return IhaleTable.Instance.TeminatAciklamaENColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.AktifPasif column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn AktifPasifColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.AktifPasif column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn AktifPasif
    {
        get
        {
            return IhaleTable.Instance.AktifPasifColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.OlusturanID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OlusturanIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.OlusturanID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OlusturanID
    {
        get
        {
            return IhaleTable.Instance.OlusturanIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DuzenlenmeTarihi column object.
    /// </summary>
    public BaseClasses.Data.DateColumn DuzenlenmeTarihiColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DuzenlenmeTarihi column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn DuzenlenmeTarihi
    {
        get
        {
            return IhaleTable.Instance.DuzenlenmeTarihiColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DuzenleyenID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn DuzenleyenIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Ihale_.DuzenleyenID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn DuzenleyenID
    {
        get
        {
            return IhaleTable.Instance.DuzenleyenIDColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of IhaleRecord records using a where clause.
    /// </summary>
    public static IhaleRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of IhaleRecord records using a where and order by clause.
    /// </summary>
    public static IhaleRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of IhaleRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static IhaleRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = IhaleTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (IhaleRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IhaleRecord"));
    }   
    
    public static IhaleRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = IhaleTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (IhaleRecord[])recList.ToArray(Type.GetType("KumePortali.Business.IhaleRecord"));
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

        return (int)IhaleTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)IhaleTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IhaleRecord record using a where clause.
    /// </summary>
    public static IhaleRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a IhaleRecord record using a where and order by clause.
    /// </summary>
    public static IhaleRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = IhaleTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        IhaleRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (IhaleRecord)recList[0];
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

        return IhaleTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        IhaleRecord[] recs = GetRecords(where);
        return  IhaleTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        IhaleRecord[] recs = GetRecords(where, orderBy);
        return  IhaleTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        IhaleRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  IhaleTable.Instance.CreateDataTable(recs, null);
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
        IhaleTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  IhaleTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return IhaleTable.Instance.ExportRecordData(whereFilter);
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

        return IhaleTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return IhaleTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return IhaleTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return IhaleTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return IhaleTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return IhaleTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = IhaleTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static IhaleRecord GetRecord(string id, bool bMutable)
        {
            return (IhaleRecord)IhaleTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static IhaleRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (IhaleRecord)IhaleTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string YetkiliKisiIDValue, 
        string FirmaIDValue, 
        string IhaleKaynagiValue, 
        string IhaleKayitNoENValue, 
        string IhaleKayitNoValue, 
        string SonTeklifTarihiValue, 
        string IhaleUsuluValue, 
        string IhaleTurIDValue, 
        string IsinSuresiValue, 
        string IsTeslimTarihiValue, 
        string SatinAlmaKatSayisiValue, 
        string SatinAlmaBirimIDValue, 
        string ParaBirimIDValue, 
        string IsinYapilacagiYerValue, 
        string IsınYapilacagiYerENValue, 
        string AciklamaValue, 
        string AciklamaENValue, 
        string OlusturmaTarihiValue, 
        string TeknikDokumanValue, 
        string IhaleDokumanValue, 
        string DokumanAciklamaValue, 
        string DokumanAciklamaENValue, 
        string IsBitirmeDokumanValue, 
        string TeminatMektubuValue, 
        string TeminatAciklamaValue, 
        string TeminatAciklamaENValue, 
        string AktifPasifValue, 
        string OlusturanIDValue, 
        string DuzenlenmeTarihiValue, 
        string DuzenleyenIDValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(YetkiliKisiIDValue, YetkiliKisiIDColumn);
        rec.SetString(FirmaIDValue, FirmaIDColumn);
        rec.SetString(IhaleKaynagiValue, IhaleKaynagiColumn);
        rec.SetString(IhaleKayitNoENValue, IhaleKayitNoENColumn);
        rec.SetString(IhaleKayitNoValue, IhaleKayitNoColumn);
        rec.SetString(SonTeklifTarihiValue, SonTeklifTarihiColumn);
        rec.SetString(IhaleUsuluValue, IhaleUsuluColumn);
        rec.SetString(IhaleTurIDValue, IhaleTurIDColumn);
        rec.SetString(IsinSuresiValue, IsinSuresiColumn);
        rec.SetString(IsTeslimTarihiValue, IsTeslimTarihiColumn);
        rec.SetString(SatinAlmaKatSayisiValue, SatinAlmaKatSayisiColumn);
        rec.SetString(SatinAlmaBirimIDValue, SatinAlmaBirimIDColumn);
        rec.SetString(ParaBirimIDValue, ParaBirimIDColumn);
        rec.SetString(IsinYapilacagiYerValue, IsinYapilacagiYerColumn);
        rec.SetString(IsınYapilacagiYerENValue, IsınYapilacagiYerENColumn);
        rec.SetString(AciklamaValue, AciklamaColumn);
        rec.SetString(AciklamaENValue, AciklamaENColumn);
        rec.SetString(OlusturmaTarihiValue, OlusturmaTarihiColumn);
        rec.SetString(TeknikDokumanValue, TeknikDokumanColumn);
        rec.SetString(IhaleDokumanValue, IhaleDokumanColumn);
        rec.SetString(DokumanAciklamaValue, DokumanAciklamaColumn);
        rec.SetString(DokumanAciklamaENValue, DokumanAciklamaENColumn);
        rec.SetString(IsBitirmeDokumanValue, IsBitirmeDokumanColumn);
        rec.SetString(TeminatMektubuValue, TeminatMektubuColumn);
        rec.SetString(TeminatAciklamaValue, TeminatAciklamaColumn);
        rec.SetString(TeminatAciklamaENValue, TeminatAciklamaENColumn);
        rec.SetString(AktifPasifValue, AktifPasifColumn);
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
			IhaleTable.Instance.DeleteOneRecord(kv);
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
				IhaleTable.GetRecord(kv, false);
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
            if (!(IhaleTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return IhaleTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(IhaleTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = IhaleTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = IhaleTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (IhaleTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = IhaleTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
