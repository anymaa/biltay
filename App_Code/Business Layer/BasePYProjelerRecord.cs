// This class is "generated" and will be overwritten.
// Your customizations should be made in PYProjelerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PYProjelerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PYProjelerTable"></see> class.
/// </remarks>
/// <seealso cref="PYProjelerTable"></seealso>
/// <seealso cref="PYProjelerRecord"></seealso>
public class BasePYProjelerRecord : PrimaryKeyRecord
{

	public readonly static PYProjelerTable TableUtils = PYProjelerTable.Instance;

	// Constructors
 
	protected BasePYProjelerRecord() : base(TableUtils)
	{
	}

	protected BasePYProjelerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeID field.
	/// </summary>
	public ColumnValue GetProjeIDValue()
	{
		return this.GetValue(TableUtils.ProjeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeID field.
	/// </summary>
	public Int32 GetProjeIDFieldValue()
	{
		return this.GetValue(TableUtils.ProjeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Konu field.
	/// </summary>
	public ColumnValue GetKonuValue()
	{
		return this.GetValue(TableUtils.KonuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Konu field.
	/// </summary>
	public string GetKonuFieldValue()
	{
		return this.GetValue(TableUtils.KonuColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Konu field.
	/// </summary>
	public void SetKonuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KonuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Konu field.
	/// </summary>
	public void SetKonuFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KonuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.KonuEN field.
	/// </summary>
	public ColumnValue GetKonuENValue()
	{
		return this.GetValue(TableUtils.KonuENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.KonuEN field.
	/// </summary>
	public string GetKonuENFieldValue()
	{
		return this.GetValue(TableUtils.KonuENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.KonuEN field.
	/// </summary>
	public void SetKonuENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KonuENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.KonuEN field.
	/// </summary>
	public void SetKonuENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KonuENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Onyazi field.
	/// </summary>
	public ColumnValue GetOnyaziValue()
	{
		return this.GetValue(TableUtils.OnyaziColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Onyazi field.
	/// </summary>
	public string GetOnyaziFieldValue()
	{
		return this.GetValue(TableUtils.OnyaziColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Onyazi field.
	/// </summary>
	public void SetOnyaziFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnyaziColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Onyazi field.
	/// </summary>
	public void SetOnyaziFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnyaziColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.OnYaziEN field.
	/// </summary>
	public ColumnValue GetOnYaziENValue()
	{
		return this.GetValue(TableUtils.OnYaziENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.OnYaziEN field.
	/// </summary>
	public string GetOnYaziENFieldValue()
	{
		return this.GetValue(TableUtils.OnYaziENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnYaziEN field.
	/// </summary>
	public void SetOnYaziENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnYaziENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnYaziEN field.
	/// </summary>
	public void SetOnYaziENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnYaziENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public ColumnValue GetResimValue()
	{
		return this.GetValue(TableUtils.ResimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public byte[] GetResimFieldValue()
	{
		return this.GetValue(TableUtils.ResimColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public void SetResimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ResimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public void SetResimFieldValue(string val)
	{
		this.SetString(val, TableUtils.ResimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public void SetResimFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ResimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.DosyaLinki field.
	/// </summary>
	public ColumnValue GetDosyaLinkiValue()
	{
		return this.GetValue(TableUtils.DosyaLinkiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.DosyaLinki field.
	/// </summary>
	public string GetDosyaLinkiFieldValue()
	{
		return this.GetValue(TableUtils.DosyaLinkiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DosyaLinki field.
	/// </summary>
	public void SetDosyaLinkiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DosyaLinkiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DosyaLinki field.
	/// </summary>
	public void SetDosyaLinkiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DosyaLinkiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public ColumnValue GetProjeYoneticisiValue()
	{
		return this.GetValue(TableUtils.ProjeYoneticisiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public Int32 GetProjeYoneticisiFieldValue()
	{
		return this.GetValue(TableUtils.ProjeYoneticisiColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public void SetProjeYoneticisiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjeYoneticisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public void SetProjeYoneticisiFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjeYoneticisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public void SetProjeYoneticisiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeYoneticisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public void SetProjeYoneticisiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeYoneticisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public void SetProjeYoneticisiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeYoneticisiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeEkibi field.
	/// </summary>
	public ColumnValue GetProjeEkibiValue()
	{
		return this.GetValue(TableUtils.ProjeEkibiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeEkibi field.
	/// </summary>
	public string GetProjeEkibiFieldValue()
	{
		return this.GetValue(TableUtils.ProjeEkibiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeEkibi field.
	/// </summary>
	public void SetProjeEkibiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjeEkibiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeEkibi field.
	/// </summary>
	public void SetProjeEkibiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeEkibiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeOnerisiTum field.
	/// </summary>
	public ColumnValue GetProjeOnerisiTumValue()
	{
		return this.GetValue(TableUtils.ProjeOnerisiTumColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeOnerisiTum field.
	/// </summary>
	public string GetProjeOnerisiTumFieldValue()
	{
		return this.GetValue(TableUtils.ProjeOnerisiTumColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeOnerisiTum field.
	/// </summary>
	public void SetProjeOnerisiTumFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjeOnerisiTumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeOnerisiTum field.
	/// </summary>
	public void SetProjeOnerisiTumFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeOnerisiTumColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeOnerisiTumEN field.
	/// </summary>
	public ColumnValue GetProjeOnerisiTumENValue()
	{
		return this.GetValue(TableUtils.ProjeOnerisiTumENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeOnerisiTumEN field.
	/// </summary>
	public string GetProjeOnerisiTumENFieldValue()
	{
		return this.GetValue(TableUtils.ProjeOnerisiTumENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeOnerisiTumEN field.
	/// </summary>
	public void SetProjeOnerisiTumENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjeOnerisiTumENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeOnerisiTumEN field.
	/// </summary>
	public void SetProjeOnerisiTumENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeOnerisiTumENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public ColumnValue GetUniversiteFakulteBolumValue()
	{
		return this.GetValue(TableUtils.UniversiteFakulteBolumColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public byte[] GetUniversiteFakulteBolumFieldValue()
	{
		return this.GetValue(TableUtils.UniversiteFakulteBolumColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public void SetUniversiteFakulteBolumFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UniversiteFakulteBolumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public void SetUniversiteFakulteBolumFieldValue(string val)
	{
		this.SetString(val, TableUtils.UniversiteFakulteBolumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public void SetUniversiteFakulteBolumFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UniversiteFakulteBolumColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public ColumnValue GetProjeBitisTarihiValue()
	{
		return this.GetValue(TableUtils.ProjeBitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public DateTime GetProjeBitisTarihiFieldValue()
	{
		return this.GetValue(TableUtils.ProjeBitisTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public void SetProjeBitisTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjeBitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public void SetProjeBitisTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjeBitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public void SetProjeBitisTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeBitisTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Iletisim field.
	/// </summary>
	public ColumnValue GetIletisimValue()
	{
		return this.GetValue(TableUtils.IletisimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.Iletisim field.
	/// </summary>
	public string GetIletisimFieldValue()
	{
		return this.GetValue(TableUtils.IletisimColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Iletisim field.
	/// </summary>
	public void SetIletisimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IletisimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Iletisim field.
	/// </summary>
	public void SetIletisimFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IletisimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public ColumnValue GetOnaylanmaTarihiValue()
	{
		return this.GetValue(TableUtils.OnaylanmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public DateTime GetOnaylanmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OnaylanmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public void SetOnaylanmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnaylanmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public void SetOnaylanmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OnaylanmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public void SetOnaylanmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnaylanmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public ColumnValue GetOnaylayanIDValue()
	{
		return this.GetValue(TableUtils.OnaylayanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public Int32 GetOnaylayanIDFieldValue()
	{
		return this.GetValue(TableUtils.OnaylayanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public void SetOnaylayanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnaylayanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public void SetOnaylayanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OnaylayanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public void SetOnaylayanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnaylayanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public void SetOnaylayanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnaylayanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public void SetOnaylayanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnaylayanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.ProjeID field.
	/// </summary>
	public Int32 ProjeID
	{
		get
		{
			return this.GetValue(TableUtils.ProjeIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeID field.
	/// </summary>
	public string ProjeIDDefault
	{
		get
		{
			return TableUtils.ProjeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.Konu field.
	/// </summary>
	public string Konu
	{
		get
		{
			return this.GetValue(TableUtils.KonuColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KonuColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KonuSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KonuColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Konu field.
	/// </summary>
	public string KonuDefault
	{
		get
		{
			return TableUtils.KonuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.KonuEN field.
	/// </summary>
	public string KonuEN
	{
		get
		{
			return this.GetValue(TableUtils.KonuENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KonuENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KonuENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KonuENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.KonuEN field.
	/// </summary>
	public string KonuENDefault
	{
		get
		{
			return TableUtils.KonuENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.Onyazi field.
	/// </summary>
	public string Onyazi
	{
		get
		{
			return this.GetValue(TableUtils.OnyaziColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OnyaziColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnyaziSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnyaziColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Onyazi field.
	/// </summary>
	public string OnyaziDefault
	{
		get
		{
			return TableUtils.OnyaziColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.OnYaziEN field.
	/// </summary>
	public string OnYaziEN
	{
		get
		{
			return this.GetValue(TableUtils.OnYaziENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OnYaziENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnYaziENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnYaziENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnYaziEN field.
	/// </summary>
	public string OnYaziENDefault
	{
		get
		{
			return TableUtils.OnYaziENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public byte[] Resim
	{
		get
		{
			return this.GetValue(TableUtils.ResimColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ResimColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ResimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ResimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Resim field.
	/// </summary>
	public string ResimDefault
	{
		get
		{
			return TableUtils.ResimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.DosyaLinki field.
	/// </summary>
	public string DosyaLinki
	{
		get
		{
			return this.GetValue(TableUtils.DosyaLinkiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DosyaLinkiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DosyaLinkiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DosyaLinkiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DosyaLinki field.
	/// </summary>
	public string DosyaLinkiDefault
	{
		get
		{
			return TableUtils.DosyaLinkiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public Int32 ProjeYoneticisi
	{
		get
		{
			return this.GetValue(TableUtils.ProjeYoneticisiColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeYoneticisiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeYoneticisiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeYoneticisiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeYoneticisi field.
	/// </summary>
	public string ProjeYoneticisiDefault
	{
		get
		{
			return TableUtils.ProjeYoneticisiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.ProjeEkibi field.
	/// </summary>
	public string ProjeEkibi
	{
		get
		{
			return this.GetValue(TableUtils.ProjeEkibiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeEkibiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeEkibiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeEkibiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeEkibi field.
	/// </summary>
	public string ProjeEkibiDefault
	{
		get
		{
			return TableUtils.ProjeEkibiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.ProjeOnerisiTum field.
	/// </summary>
	public string ProjeOnerisiTum
	{
		get
		{
			return this.GetValue(TableUtils.ProjeOnerisiTumColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeOnerisiTumColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeOnerisiTumSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeOnerisiTumColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeOnerisiTum field.
	/// </summary>
	public string ProjeOnerisiTumDefault
	{
		get
		{
			return TableUtils.ProjeOnerisiTumColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.ProjeOnerisiTumEN field.
	/// </summary>
	public string ProjeOnerisiTumEN
	{
		get
		{
			return this.GetValue(TableUtils.ProjeOnerisiTumENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeOnerisiTumENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeOnerisiTumENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeOnerisiTumENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeOnerisiTumEN field.
	/// </summary>
	public string ProjeOnerisiTumENDefault
	{
		get
		{
			return TableUtils.ProjeOnerisiTumENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public byte[] UniversiteFakulteBolum
	{
		get
		{
			return this.GetValue(TableUtils.UniversiteFakulteBolumColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UniversiteFakulteBolumColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UniversiteFakulteBolumSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UniversiteFakulteBolumColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.UniversiteFakulteBolum field.
	/// </summary>
	public string UniversiteFakulteBolumDefault
	{
		get
		{
			return TableUtils.UniversiteFakulteBolumColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public DateTime ProjeBitisTarihi
	{
		get
		{
			return this.GetValue(TableUtils.ProjeBitisTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeBitisTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeBitisTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeBitisTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.ProjeBitisTarihi field.
	/// </summary>
	public string ProjeBitisTarihiDefault
	{
		get
		{
			return TableUtils.ProjeBitisTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.Iletisim field.
	/// </summary>
	public string Iletisim
	{
		get
		{
			return this.GetValue(TableUtils.IletisimColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IletisimColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IletisimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IletisimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.Iletisim field.
	/// </summary>
	public string IletisimDefault
	{
		get
		{
			return TableUtils.IletisimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public DateTime OnaylanmaTarihi
	{
		get
		{
			return this.GetValue(TableUtils.OnaylanmaTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OnaylanmaTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnaylanmaTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnaylanmaTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylanmaTarihi field.
	/// </summary>
	public string OnaylanmaTarihiDefault
	{
		get
		{
			return TableUtils.OnaylanmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public Int32 OnaylayanID
	{
		get
		{
			return this.GetValue(TableUtils.OnaylayanIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OnaylayanIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnaylayanIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnaylayanIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.OnaylayanID field.
	/// </summary>
	public string OnaylayanIDDefault
	{
		get
		{
			return TableUtils.OnaylayanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeler_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeler_.DuzenleyenID field.
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
