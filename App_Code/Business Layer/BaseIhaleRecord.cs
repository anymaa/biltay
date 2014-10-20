// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IhaleRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IhaleTable"></see> class.
/// </remarks>
/// <seealso cref="IhaleTable"></seealso>
/// <seealso cref="IhaleRecord"></seealso>
public class BaseIhaleRecord : PrimaryKeyRecord
{

	public readonly static IhaleTable TableUtils = IhaleTable.Instance;

	// Constructors
 
	protected BaseIhaleRecord() : base(TableUtils)
	{
	}

	protected BaseIhaleRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleID field.
	/// </summary>
	public ColumnValue GetIhaleIDValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleID field.
	/// </summary>
	public Int32 GetIhaleIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public ColumnValue GetYetkiliKisiIDValue()
	{
		return this.GetValue(TableUtils.YetkiliKisiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public Int32 GetYetkiliKisiIDFieldValue()
	{
		return this.GetValue(TableUtils.YetkiliKisiIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public void SetYetkiliKisiIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetkiliKisiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public void SetYetkiliKisiIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.YetkiliKisiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public void SetYetkiliKisiIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiliKisiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public void SetYetkiliKisiIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiliKisiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public void SetYetkiliKisiIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiliKisiIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleKaynagi field.
	/// </summary>
	public ColumnValue GetIhaleKaynagiValue()
	{
		return this.GetValue(TableUtils.IhaleKaynagiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleKaynagi field.
	/// </summary>
	public string GetIhaleKaynagiFieldValue()
	{
		return this.GetValue(TableUtils.IhaleKaynagiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKaynagi field.
	/// </summary>
	public void SetIhaleKaynagiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleKaynagiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKaynagi field.
	/// </summary>
	public void SetIhaleKaynagiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleKaynagiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleKayitNoEN field.
	/// </summary>
	public ColumnValue GetIhaleKayitNoENValue()
	{
		return this.GetValue(TableUtils.IhaleKayitNoENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleKayitNoEN field.
	/// </summary>
	public string GetIhaleKayitNoENFieldValue()
	{
		return this.GetValue(TableUtils.IhaleKayitNoENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKayitNoEN field.
	/// </summary>
	public void SetIhaleKayitNoENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleKayitNoENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKayitNoEN field.
	/// </summary>
	public void SetIhaleKayitNoENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleKayitNoENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleKayitNo field.
	/// </summary>
	public ColumnValue GetIhaleKayitNoValue()
	{
		return this.GetValue(TableUtils.IhaleKayitNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleKayitNo field.
	/// </summary>
	public string GetIhaleKayitNoFieldValue()
	{
		return this.GetValue(TableUtils.IhaleKayitNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKayitNo field.
	/// </summary>
	public void SetIhaleKayitNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleKayitNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKayitNo field.
	/// </summary>
	public void SetIhaleKayitNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleKayitNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public ColumnValue GetSonTeklifTarihiValue()
	{
		return this.GetValue(TableUtils.SonTeklifTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public DateTime GetSonTeklifTarihiFieldValue()
	{
		return this.GetValue(TableUtils.SonTeklifTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public void SetSonTeklifTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SonTeklifTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public void SetSonTeklifTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.SonTeklifTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public void SetSonTeklifTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SonTeklifTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public ColumnValue GetIhaleUsuluValue()
	{
		return this.GetValue(TableUtils.IhaleUsuluColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public Byte GetIhaleUsuluFieldValue()
	{
		return this.GetValue(TableUtils.IhaleUsuluColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public void SetIhaleUsuluFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleUsuluColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public void SetIhaleUsuluFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleUsuluColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public void SetIhaleUsuluFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleUsuluColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public void SetIhaleUsuluFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleUsuluColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public void SetIhaleUsuluFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleUsuluColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public ColumnValue GetIhaleTurIDValue()
	{
		return this.GetValue(TableUtils.IhaleTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public Byte GetIhaleTurIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleTurIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public void SetIhaleTurIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public void SetIhaleTurIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public void SetIhaleTurIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public void SetIhaleTurIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public void SetIhaleTurIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTurIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public ColumnValue GetIsinSuresiValue()
	{
		return this.GetValue(TableUtils.IsinSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public Int32 GetIsinSuresiFieldValue()
	{
		return this.GetValue(TableUtils.IsinSuresiColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public void SetIsinSuresiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsinSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public void SetIsinSuresiFieldValue(string val)
	{
		this.SetString(val, TableUtils.IsinSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public void SetIsinSuresiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsinSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public void SetIsinSuresiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsinSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public void SetIsinSuresiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsinSuresiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public ColumnValue GetIsTeslimTarihiValue()
	{
		return this.GetValue(TableUtils.IsTeslimTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public DateTime GetIsTeslimTarihiFieldValue()
	{
		return this.GetValue(TableUtils.IsTeslimTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public void SetIsTeslimTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsTeslimTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public void SetIsTeslimTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.IsTeslimTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public void SetIsTeslimTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsTeslimTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public ColumnValue GetSatinAlmaKatSayisiValue()
	{
		return this.GetValue(TableUtils.SatinAlmaKatSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public Int32 GetSatinAlmaKatSayisiFieldValue()
	{
		return this.GetValue(TableUtils.SatinAlmaKatSayisiColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public void SetSatinAlmaKatSayisiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SatinAlmaKatSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public void SetSatinAlmaKatSayisiFieldValue(string val)
	{
		this.SetString(val, TableUtils.SatinAlmaKatSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public void SetSatinAlmaKatSayisiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SatinAlmaKatSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public void SetSatinAlmaKatSayisiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SatinAlmaKatSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public void SetSatinAlmaKatSayisiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SatinAlmaKatSayisiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public ColumnValue GetSatinAlmaBirimIDValue()
	{
		return this.GetValue(TableUtils.SatinAlmaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public Byte GetSatinAlmaBirimIDFieldValue()
	{
		return this.GetValue(TableUtils.SatinAlmaBirimIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public void SetSatinAlmaBirimIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SatinAlmaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public void SetSatinAlmaBirimIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SatinAlmaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public void SetSatinAlmaBirimIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SatinAlmaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public void SetSatinAlmaBirimIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SatinAlmaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public void SetSatinAlmaBirimIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SatinAlmaBirimIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public ColumnValue GetParaBirimIDValue()
	{
		return this.GetValue(TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public Byte GetParaBirimIDFieldValue()
	{
		return this.GetValue(TableUtils.ParaBirimIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsinYapilacagiYer field.
	/// </summary>
	public ColumnValue GetIsinYapilacagiYerValue()
	{
		return this.GetValue(TableUtils.IsinYapilacagiYerColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsinYapilacagiYer field.
	/// </summary>
	public string GetIsinYapilacagiYerFieldValue()
	{
		return this.GetValue(TableUtils.IsinYapilacagiYerColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinYapilacagiYer field.
	/// </summary>
	public void SetIsinYapilacagiYerFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsinYapilacagiYerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinYapilacagiYer field.
	/// </summary>
	public void SetIsinYapilacagiYerFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsinYapilacagiYerColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsınYapilacagiYerEN field.
	/// </summary>
	public ColumnValue GetIsınYapilacagiYerENValue()
	{
		return this.GetValue(TableUtils.IsınYapilacagiYerENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsınYapilacagiYerEN field.
	/// </summary>
	public string GetIsınYapilacagiYerENFieldValue()
	{
		return this.GetValue(TableUtils.IsınYapilacagiYerENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsınYapilacagiYerEN field.
	/// </summary>
	public void SetIsınYapilacagiYerENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsınYapilacagiYerENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsınYapilacagiYerEN field.
	/// </summary>
	public void SetIsınYapilacagiYerENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsınYapilacagiYerENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.AciklamaEN field.
	/// </summary>
	public ColumnValue GetAciklamaENValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.AciklamaEN field.
	/// </summary>
	public string GetAciklamaENFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public ColumnValue GetTeknikDokumanValue()
	{
		return this.GetValue(TableUtils.TeknikDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public byte[] GetTeknikDokumanFieldValue()
	{
		return this.GetValue(TableUtils.TeknikDokumanColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public void SetTeknikDokumanFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeknikDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public void SetTeknikDokumanFieldValue(string val)
	{
		this.SetString(val, TableUtils.TeknikDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public void SetTeknikDokumanFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeknikDokumanColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public ColumnValue GetIhaleDokumanValue()
	{
		return this.GetValue(TableUtils.IhaleDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public byte[] GetIhaleDokumanFieldValue()
	{
		return this.GetValue(TableUtils.IhaleDokumanColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public void SetIhaleDokumanFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public void SetIhaleDokumanFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public void SetIhaleDokumanFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleDokumanColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DokumanAciklama field.
	/// </summary>
	public ColumnValue GetDokumanAciklamaValue()
	{
		return this.GetValue(TableUtils.DokumanAciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DokumanAciklama field.
	/// </summary>
	public string GetDokumanAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.DokumanAciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DokumanAciklama field.
	/// </summary>
	public void SetDokumanAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DokumanAciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DokumanAciklama field.
	/// </summary>
	public void SetDokumanAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DokumanAciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DokumanAciklamaEN field.
	/// </summary>
	public ColumnValue GetDokumanAciklamaENValue()
	{
		return this.GetValue(TableUtils.DokumanAciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DokumanAciklamaEN field.
	/// </summary>
	public string GetDokumanAciklamaENFieldValue()
	{
		return this.GetValue(TableUtils.DokumanAciklamaENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DokumanAciklamaEN field.
	/// </summary>
	public void SetDokumanAciklamaENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DokumanAciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DokumanAciklamaEN field.
	/// </summary>
	public void SetDokumanAciklamaENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DokumanAciklamaENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public ColumnValue GetIsBitirmeDokumanValue()
	{
		return this.GetValue(TableUtils.IsBitirmeDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public byte[] GetIsBitirmeDokumanFieldValue()
	{
		return this.GetValue(TableUtils.IsBitirmeDokumanColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public void SetIsBitirmeDokumanFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsBitirmeDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public void SetIsBitirmeDokumanFieldValue(string val)
	{
		this.SetString(val, TableUtils.IsBitirmeDokumanColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public void SetIsBitirmeDokumanFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsBitirmeDokumanColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public ColumnValue GetTeminatMektubuValue()
	{
		return this.GetValue(TableUtils.TeminatMektubuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public byte[] GetTeminatMektubuFieldValue()
	{
		return this.GetValue(TableUtils.TeminatMektubuColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public void SetTeminatMektubuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeminatMektubuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public void SetTeminatMektubuFieldValue(string val)
	{
		this.SetString(val, TableUtils.TeminatMektubuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public void SetTeminatMektubuFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeminatMektubuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeminatAciklama field.
	/// </summary>
	public ColumnValue GetTeminatAciklamaValue()
	{
		return this.GetValue(TableUtils.TeminatAciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeminatAciklama field.
	/// </summary>
	public string GetTeminatAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.TeminatAciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatAciklama field.
	/// </summary>
	public void SetTeminatAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeminatAciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatAciklama field.
	/// </summary>
	public void SetTeminatAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeminatAciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeminatAciklamaEN field.
	/// </summary>
	public ColumnValue GetTeminatAciklamaENValue()
	{
		return this.GetValue(TableUtils.TeminatAciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.TeminatAciklamaEN field.
	/// </summary>
	public string GetTeminatAciklamaENFieldValue()
	{
		return this.GetValue(TableUtils.TeminatAciklamaENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatAciklamaEN field.
	/// </summary>
	public void SetTeminatAciklamaENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeminatAciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatAciklamaEN field.
	/// </summary>
	public void SetTeminatAciklamaENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeminatAciklamaENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleID field.
	/// </summary>
	public Int32 IhaleID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleID field.
	/// </summary>
	public string IhaleIDDefault
	{
		get
		{
			return TableUtils.IhaleIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public Int32 YetkiliKisiID
	{
		get
		{
			return this.GetValue(TableUtils.YetkiliKisiIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetkiliKisiIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetkiliKisiIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetkiliKisiIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.YetkiliKisiID field.
	/// </summary>
	public string YetkiliKisiIDDefault
	{
		get
		{
			return TableUtils.YetkiliKisiIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public Int32 FirmaID
	{
		get
		{
			return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleKaynagi field.
	/// </summary>
	public string IhaleKaynagi
	{
		get
		{
			return this.GetValue(TableUtils.IhaleKaynagiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleKaynagiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleKaynagiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleKaynagiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKaynagi field.
	/// </summary>
	public string IhaleKaynagiDefault
	{
		get
		{
			return TableUtils.IhaleKaynagiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleKayitNoEN field.
	/// </summary>
	public string IhaleKayitNoEN
	{
		get
		{
			return this.GetValue(TableUtils.IhaleKayitNoENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleKayitNoENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleKayitNoENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleKayitNoENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKayitNoEN field.
	/// </summary>
	public string IhaleKayitNoENDefault
	{
		get
		{
			return TableUtils.IhaleKayitNoENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleKayitNo field.
	/// </summary>
	public string IhaleKayitNo
	{
		get
		{
			return this.GetValue(TableUtils.IhaleKayitNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleKayitNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleKayitNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleKayitNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleKayitNo field.
	/// </summary>
	public string IhaleKayitNoDefault
	{
		get
		{
			return TableUtils.IhaleKayitNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public DateTime SonTeklifTarihi
	{
		get
		{
			return this.GetValue(TableUtils.SonTeklifTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SonTeklifTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SonTeklifTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SonTeklifTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SonTeklifTarihi field.
	/// </summary>
	public string SonTeklifTarihiDefault
	{
		get
		{
			return TableUtils.SonTeklifTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public Byte IhaleUsulu
	{
		get
		{
			return this.GetValue(TableUtils.IhaleUsuluColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleUsuluColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleUsuluSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleUsuluColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleUsulu field.
	/// </summary>
	public string IhaleUsuluDefault
	{
		get
		{
			return TableUtils.IhaleUsuluColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public Byte IhaleTurID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleTurIDColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleTurIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleTurIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleTurIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleTurID field.
	/// </summary>
	public string IhaleTurIDDefault
	{
		get
		{
			return TableUtils.IhaleTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public Int32 IsinSuresi
	{
		get
		{
			return this.GetValue(TableUtils.IsinSuresiColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsinSuresiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsinSuresiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsinSuresiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinSuresi field.
	/// </summary>
	public string IsinSuresiDefault
	{
		get
		{
			return TableUtils.IsinSuresiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public DateTime IsTeslimTarihi
	{
		get
		{
			return this.GetValue(TableUtils.IsTeslimTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsTeslimTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsTeslimTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsTeslimTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsTeslimTarihi field.
	/// </summary>
	public string IsTeslimTarihiDefault
	{
		get
		{
			return TableUtils.IsTeslimTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public Int32 SatinAlmaKatSayisi
	{
		get
		{
			return this.GetValue(TableUtils.SatinAlmaKatSayisiColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SatinAlmaKatSayisiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SatinAlmaKatSayisiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SatinAlmaKatSayisiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaKatSayisi field.
	/// </summary>
	public string SatinAlmaKatSayisiDefault
	{
		get
		{
			return TableUtils.SatinAlmaKatSayisiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public Byte SatinAlmaBirimID
	{
		get
		{
			return this.GetValue(TableUtils.SatinAlmaBirimIDColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SatinAlmaBirimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SatinAlmaBirimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SatinAlmaBirimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.SatinAlmaBirimID field.
	/// </summary>
	public string SatinAlmaBirimIDDefault
	{
		get
		{
			return TableUtils.SatinAlmaBirimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public Byte ParaBirimID
	{
		get
		{
			return this.GetValue(TableUtils.ParaBirimIDColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParaBirimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParaBirimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParaBirimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.ParaBirimID field.
	/// </summary>
	public string ParaBirimIDDefault
	{
		get
		{
			return TableUtils.ParaBirimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IsinYapilacagiYer field.
	/// </summary>
	public string IsinYapilacagiYer
	{
		get
		{
			return this.GetValue(TableUtils.IsinYapilacagiYerColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsinYapilacagiYerColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsinYapilacagiYerSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsinYapilacagiYerColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsinYapilacagiYer field.
	/// </summary>
	public string IsinYapilacagiYerDefault
	{
		get
		{
			return TableUtils.IsinYapilacagiYerColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IsınYapilacagiYerEN field.
	/// </summary>
	public string IsınYapilacagiYerEN
	{
		get
		{
			return this.GetValue(TableUtils.IsınYapilacagiYerENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsınYapilacagiYerENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsınYapilacagiYerENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsınYapilacagiYerENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsınYapilacagiYerEN field.
	/// </summary>
	public string IsınYapilacagiYerENDefault
	{
		get
		{
			return TableUtils.IsınYapilacagiYerENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.Aciklama field.
	/// </summary>
	public string Aciklama
	{
		get
		{
			return this.GetValue(TableUtils.AciklamaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AciklamaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AciklamaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AciklamaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.Aciklama field.
	/// </summary>
	public string AciklamaDefault
	{
		get
		{
			return TableUtils.AciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.AciklamaEN field.
	/// </summary>
	public string AciklamaEN
	{
		get
		{
			return this.GetValue(TableUtils.AciklamaENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AciklamaENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AciklamaENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AciklamaENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AciklamaEN field.
	/// </summary>
	public string AciklamaENDefault
	{
		get
		{
			return TableUtils.AciklamaENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public DateTime OlusturmaTarihi
	{
		get
		{
			return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlusturmaTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlusturmaTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public byte[] TeknikDokuman
	{
		get
		{
			return this.GetValue(TableUtils.TeknikDokumanColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeknikDokumanColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeknikDokumanSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeknikDokumanColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeknikDokuman field.
	/// </summary>
	public string TeknikDokumanDefault
	{
		get
		{
			return TableUtils.TeknikDokumanColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public byte[] IhaleDokuman
	{
		get
		{
			return this.GetValue(TableUtils.IhaleDokumanColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleDokumanColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleDokumanSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleDokumanColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IhaleDokuman field.
	/// </summary>
	public string IhaleDokumanDefault
	{
		get
		{
			return TableUtils.IhaleDokumanColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.DokumanAciklama field.
	/// </summary>
	public string DokumanAciklama
	{
		get
		{
			return this.GetValue(TableUtils.DokumanAciklamaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DokumanAciklamaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DokumanAciklamaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DokumanAciklamaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DokumanAciklama field.
	/// </summary>
	public string DokumanAciklamaDefault
	{
		get
		{
			return TableUtils.DokumanAciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.DokumanAciklamaEN field.
	/// </summary>
	public string DokumanAciklamaEN
	{
		get
		{
			return this.GetValue(TableUtils.DokumanAciklamaENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DokumanAciklamaENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DokumanAciklamaENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DokumanAciklamaENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DokumanAciklamaEN field.
	/// </summary>
	public string DokumanAciklamaENDefault
	{
		get
		{
			return TableUtils.DokumanAciklamaENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public byte[] IsBitirmeDokuman
	{
		get
		{
			return this.GetValue(TableUtils.IsBitirmeDokumanColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsBitirmeDokumanColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsBitirmeDokumanSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsBitirmeDokumanColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.IsBitirmeDokuman field.
	/// </summary>
	public string IsBitirmeDokumanDefault
	{
		get
		{
			return TableUtils.IsBitirmeDokumanColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public byte[] TeminatMektubu
	{
		get
		{
			return this.GetValue(TableUtils.TeminatMektubuColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeminatMektubuColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeminatMektubuSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeminatMektubuColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatMektubu field.
	/// </summary>
	public string TeminatMektubuDefault
	{
		get
		{
			return TableUtils.TeminatMektubuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.TeminatAciklama field.
	/// </summary>
	public string TeminatAciklama
	{
		get
		{
			return this.GetValue(TableUtils.TeminatAciklamaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeminatAciklamaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeminatAciklamaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeminatAciklamaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatAciklama field.
	/// </summary>
	public string TeminatAciklamaDefault
	{
		get
		{
			return TableUtils.TeminatAciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.TeminatAciklamaEN field.
	/// </summary>
	public string TeminatAciklamaEN
	{
		get
		{
			return this.GetValue(TableUtils.TeminatAciklamaENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeminatAciklamaENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeminatAciklamaENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeminatAciklamaENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.TeminatAciklamaEN field.
	/// </summary>
	public string TeminatAciklamaENDefault
	{
		get
		{
			return TableUtils.TeminatAciklamaENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public bool AktifPasif
	{
		get
		{
			return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.AktifPasifColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AktifPasifSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AktifPasifColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public Int32 OlusturanID
	{
		get
		{
			return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlusturanIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlusturanIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlusturanIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime DuzenlenmeTarihi
	{
		get
		{
			return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DuzenlenmeTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public Int32 DuzenleyenID
	{
		get
		{
			return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DuzenleyenIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DuzenleyenIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Ihale_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}


#endregion
}

}
