// This class is "generated" and will be overwritten.
// Your customizations should be made in MIYSAHesaplarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="MIYSAHesaplarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MIYSAHesaplarTable"></see> class.
/// </remarks>
/// <seealso cref="MIYSAHesaplarTable"></seealso>
/// <seealso cref="MIYSAHesaplarRecord"></seealso>
public class BaseMIYSAHesaplarRecord : PrimaryKeyRecord
{

	public readonly static MIYSAHesaplarTable TableUtils = MIYSAHesaplarTable.Instance;

	// Constructors
 
	protected BaseMIYSAHesaplarRecord() : base(TableUtils)
	{
	}

	protected BaseMIYSAHesaplarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.HesapID field.
	/// </summary>
	public ColumnValue GetHesapIDValue()
	{
		return this.GetValue(TableUtils.HesapIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.HesapID field.
	/// </summary>
	public Int32 GetHesapIDFieldValue()
	{
		return this.GetValue(TableUtils.HesapIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.HesapTurID field.
	/// </summary>
	public ColumnValue GetHesapTurIDValue()
	{
		return this.GetValue(TableUtils.HesapTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.HesapTurID field.
	/// </summary>
	public string GetHesapTurIDFieldValue()
	{
		return this.GetValue(TableUtils.HesapTurIDColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.HesapTurID field.
	/// </summary>
	public void SetHesapTurIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HesapTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.HesapTurID field.
	/// </summary>
	public void SetHesapTurIDFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HesapTurIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaAdi field.
	/// </summary>
	public ColumnValue GetFirmaAdiValue()
	{
		return this.GetValue(TableUtils.FirmaAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaAdi field.
	/// </summary>
	public string GetFirmaAdiFieldValue()
	{
		return this.GetValue(TableUtils.FirmaAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaAdi field.
	/// </summary>
	public void SetFirmaAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaAdi field.
	/// </summary>
	public void SetFirmaAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.Adres field.
	/// </summary>
	public ColumnValue GetAdresValue()
	{
		return this.GetValue(TableUtils.AdresColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.Adres field.
	/// </summary>
	public string GetAdresFieldValue()
	{
		return this.GetValue(TableUtils.AdresColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Adres field.
	/// </summary>
	public void SetAdresFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdresColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Adres field.
	/// </summary>
	public void SetAdresFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdresColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public ColumnValue GetIlIDValue()
	{
		return this.GetValue(TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public Int32 GetIlIDFieldValue()
	{
		return this.GetValue(TableUtils.IlIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public ColumnValue GetIlceIDValue()
	{
		return this.GetValue(TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public Int32 GetIlceIDFieldValue()
	{
		return this.GetValue(TableUtils.IlceIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlceIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.Telefon field.
	/// </summary>
	public ColumnValue GetTelefonValue()
	{
		return this.GetValue(TableUtils.TelefonColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.Telefon field.
	/// </summary>
	public string GetTelefonFieldValue()
	{
		return this.GetValue(TableUtils.TelefonColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Telefon field.
	/// </summary>
	public void SetTelefonFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TelefonColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Telefon field.
	/// </summary>
	public void SetTelefonFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TelefonColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.Eposta field.
	/// </summary>
	public ColumnValue GetEpostaValue()
	{
		return this.GetValue(TableUtils.EpostaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.Eposta field.
	/// </summary>
	public string GetEpostaFieldValue()
	{
		return this.GetValue(TableUtils.EpostaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Eposta field.
	/// </summary>
	public void SetEpostaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EpostaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Eposta field.
	/// </summary>
	public void SetEpostaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EpostaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.WebSite field.
	/// </summary>
	public ColumnValue GetWebSiteValue()
	{
		return this.GetValue(TableUtils.WebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.WebSite field.
	/// </summary>
	public string GetWebSiteFieldValue()
	{
		return this.GetValue(TableUtils.WebSiteColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.WebSite field.
	/// </summary>
	public void SetWebSiteFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.WebSiteColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.WebSite field.
	/// </summary>
	public void SetWebSiteFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.WebSiteColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public ColumnValue GetFaaliyetAlaniIDValue()
	{
		return this.GetValue(TableUtils.FaaliyetAlaniIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public Int32 GetFaaliyetAlaniIDFieldValue()
	{
		return this.GetValue(TableUtils.FaaliyetAlaniIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public void SetFaaliyetAlaniIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaaliyetAlaniIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public void SetFaaliyetAlaniIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FaaliyetAlaniIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public void SetFaaliyetAlaniIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaaliyetAlaniIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public void SetFaaliyetAlaniIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaaliyetAlaniIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public void SetFaaliyetAlaniIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaaliyetAlaniIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public ColumnValue GetArgeCalismasiValue()
	{
		return this.GetValue(TableUtils.ArgeCalismasiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public bool GetArgeCalismasiFieldValue()
	{
		return this.GetValue(TableUtils.ArgeCalismasiColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public void SetArgeCalismasiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ArgeCalismasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public void SetArgeCalismasiFieldValue(string val)
	{
		this.SetString(val, TableUtils.ArgeCalismasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public void SetArgeCalismasiFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ArgeCalismasiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaOnYazisi field.
	/// </summary>
	public ColumnValue GetFirmaOnYazisiValue()
	{
		return this.GetValue(TableUtils.FirmaOnYazisiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaOnYazisi field.
	/// </summary>
	public string GetFirmaOnYazisiFieldValue()
	{
		return this.GetValue(TableUtils.FirmaOnYazisiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaOnYazisi field.
	/// </summary>
	public void SetFirmaOnYazisiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaOnYazisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaOnYazisi field.
	/// </summary>
	public void SetFirmaOnYazisiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaOnYazisiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaOnYazisiEN field.
	/// </summary>
	public ColumnValue GetFirmaOnYazisiENValue()
	{
		return this.GetValue(TableUtils.FirmaOnYazisiENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaOnYazisiEN field.
	/// </summary>
	public string GetFirmaOnYazisiENFieldValue()
	{
		return this.GetValue(TableUtils.FirmaOnYazisiENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaOnYazisiEN field.
	/// </summary>
	public void SetFirmaOnYazisiENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaOnYazisiENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaOnYazisiEN field.
	/// </summary>
	public void SetFirmaOnYazisiENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaOnYazisiENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitim field.
	/// </summary>
	public ColumnValue GetFirmaTanitimValue()
	{
		return this.GetValue(TableUtils.FirmaTanitimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitim field.
	/// </summary>
	public string GetFirmaTanitimFieldValue()
	{
		return this.GetValue(TableUtils.FirmaTanitimColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitim field.
	/// </summary>
	public void SetFirmaTanitimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaTanitimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitim field.
	/// </summary>
	public void SetFirmaTanitimFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaTanitimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitimEN field.
	/// </summary>
	public ColumnValue GetFirmaTanitimENValue()
	{
		return this.GetValue(TableUtils.FirmaTanitimENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitimEN field.
	/// </summary>
	public string GetFirmaTanitimENFieldValue()
	{
		return this.GetValue(TableUtils.FirmaTanitimENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimEN field.
	/// </summary>
	public void SetFirmaTanitimENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaTanitimENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimEN field.
	/// </summary>
	public void SetFirmaTanitimENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaTanitimENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public ColumnValue GetFirmaLogoValue()
	{
		return this.GetValue(TableUtils.FirmaLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public byte[] GetFirmaLogoFieldValue()
	{
		return this.GetValue(TableUtils.FirmaLogoColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public void SetFirmaLogoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public void SetFirmaLogoFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaLogoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public void SetFirmaLogoFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaLogoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public ColumnValue GetFirmaTanitimDosyasiValue()
	{
		return this.GetValue(TableUtils.FirmaTanitimDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public byte[] GetFirmaTanitimDosyasiFieldValue()
	{
		return this.GetValue(TableUtils.FirmaTanitimDosyasiColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public void SetFirmaTanitimDosyasiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaTanitimDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public void SetFirmaTanitimDosyasiFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaTanitimDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public void SetFirmaTanitimDosyasiFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaTanitimDosyasiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public ColumnValue GetFirmaSunumDosyasiValue()
	{
		return this.GetValue(TableUtils.FirmaSunumDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public byte[] GetFirmaSunumDosyasiFieldValue()
	{
		return this.GetValue(TableUtils.FirmaSunumDosyasiColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public void SetFirmaSunumDosyasiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaSunumDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public void SetFirmaSunumDosyasiFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaSunumDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public void SetFirmaSunumDosyasiFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaSunumDosyasiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public ColumnValue GetFirmaKatalogDosyasiValue()
	{
		return this.GetValue(TableUtils.FirmaKatalogDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public byte[] GetFirmaKatalogDosyasiFieldValue()
	{
		return this.GetValue(TableUtils.FirmaKatalogDosyasiColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public void SetFirmaKatalogDosyasiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaKatalogDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public void SetFirmaKatalogDosyasiFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaKatalogDosyasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public void SetFirmaKatalogDosyasiFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaKatalogDosyasiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.HesapID field.
	/// </summary>
	public Int32 HesapID
	{
		get
		{
			return this.GetValue(TableUtils.HesapIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HesapIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HesapIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HesapIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.HesapID field.
	/// </summary>
	public string HesapIDDefault
	{
		get
		{
			return TableUtils.HesapIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.HesapTurID field.
	/// </summary>
	public string HesapTurID
	{
		get
		{
			return this.GetValue(TableUtils.HesapTurIDColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HesapTurIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HesapTurIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HesapTurIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.HesapTurID field.
	/// </summary>
	public string HesapTurIDDefault
	{
		get
		{
			return TableUtils.HesapTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaAdi field.
	/// </summary>
	public string FirmaAdi
	{
		get
		{
			return this.GetValue(TableUtils.FirmaAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaAdi field.
	/// </summary>
	public string FirmaAdiDefault
	{
		get
		{
			return TableUtils.FirmaAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.Adres field.
	/// </summary>
	public string Adres
	{
		get
		{
			return this.GetValue(TableUtils.AdresColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdresColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdresSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdresColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Adres field.
	/// </summary>
	public string AdresDefault
	{
		get
		{
			return TableUtils.AdresColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public Int32 IlID
	{
		get
		{
			return this.GetValue(TableUtils.IlIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlID field.
	/// </summary>
	public string IlIDDefault
	{
		get
		{
			return TableUtils.IlIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public Int32 IlceID
	{
		get
		{
			return this.GetValue(TableUtils.IlceIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlceIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlceIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlceIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.IlceID field.
	/// </summary>
	public string IlceIDDefault
	{
		get
		{
			return TableUtils.IlceIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.Telefon field.
	/// </summary>
	public string Telefon
	{
		get
		{
			return this.GetValue(TableUtils.TelefonColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TelefonColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TelefonSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TelefonColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Telefon field.
	/// </summary>
	public string TelefonDefault
	{
		get
		{
			return TableUtils.TelefonColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.Eposta field.
	/// </summary>
	public string Eposta
	{
		get
		{
			return this.GetValue(TableUtils.EpostaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EpostaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EpostaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EpostaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.Eposta field.
	/// </summary>
	public string EpostaDefault
	{
		get
		{
			return TableUtils.EpostaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.WebSite field.
	/// </summary>
	public string WebSite
	{
		get
		{
			return this.GetValue(TableUtils.WebSiteColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.WebSiteColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool WebSiteSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.WebSiteColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.WebSite field.
	/// </summary>
	public string WebSiteDefault
	{
		get
		{
			return TableUtils.WebSiteColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public Int32 FaaliyetAlaniID
	{
		get
		{
			return this.GetValue(TableUtils.FaaliyetAlaniIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaaliyetAlaniIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaaliyetAlaniIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaaliyetAlaniIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FaaliyetAlaniID field.
	/// </summary>
	public string FaaliyetAlaniIDDefault
	{
		get
		{
			return TableUtils.FaaliyetAlaniIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public bool ArgeCalismasi
	{
		get
		{
			return this.GetValue(TableUtils.ArgeCalismasiColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ArgeCalismasiColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ArgeCalismasiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ArgeCalismasiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.ArgeCalismasi field.
	/// </summary>
	public string ArgeCalismasiDefault
	{
		get
		{
			return TableUtils.ArgeCalismasiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaOnYazisi field.
	/// </summary>
	public string FirmaOnYazisi
	{
		get
		{
			return this.GetValue(TableUtils.FirmaOnYazisiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaOnYazisiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaOnYazisiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaOnYazisiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaOnYazisi field.
	/// </summary>
	public string FirmaOnYazisiDefault
	{
		get
		{
			return TableUtils.FirmaOnYazisiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaOnYazisiEN field.
	/// </summary>
	public string FirmaOnYazisiEN
	{
		get
		{
			return this.GetValue(TableUtils.FirmaOnYazisiENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaOnYazisiENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaOnYazisiENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaOnYazisiENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaOnYazisiEN field.
	/// </summary>
	public string FirmaOnYazisiENDefault
	{
		get
		{
			return TableUtils.FirmaOnYazisiENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitim field.
	/// </summary>
	public string FirmaTanitim
	{
		get
		{
			return this.GetValue(TableUtils.FirmaTanitimColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaTanitimColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaTanitimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaTanitimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitim field.
	/// </summary>
	public string FirmaTanitimDefault
	{
		get
		{
			return TableUtils.FirmaTanitimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitimEN field.
	/// </summary>
	public string FirmaTanitimEN
	{
		get
		{
			return this.GetValue(TableUtils.FirmaTanitimENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaTanitimENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaTanitimENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaTanitimENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimEN field.
	/// </summary>
	public string FirmaTanitimENDefault
	{
		get
		{
			return TableUtils.FirmaTanitimENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public byte[] FirmaLogo
	{
		get
		{
			return this.GetValue(TableUtils.FirmaLogoColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaLogoColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaLogoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaLogoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaLogo field.
	/// </summary>
	public string FirmaLogoDefault
	{
		get
		{
			return TableUtils.FirmaLogoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public byte[] FirmaTanitimDosyasi
	{
		get
		{
			return this.GetValue(TableUtils.FirmaTanitimDosyasiColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaTanitimDosyasiColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaTanitimDosyasiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaTanitimDosyasiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaTanitimDosyasi field.
	/// </summary>
	public string FirmaTanitimDosyasiDefault
	{
		get
		{
			return TableUtils.FirmaTanitimDosyasiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public byte[] FirmaSunumDosyasi
	{
		get
		{
			return this.GetValue(TableUtils.FirmaSunumDosyasiColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaSunumDosyasiColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaSunumDosyasiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaSunumDosyasiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaSunumDosyasi field.
	/// </summary>
	public string FirmaSunumDosyasiDefault
	{
		get
		{
			return TableUtils.FirmaSunumDosyasiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public byte[] FirmaKatalogDosyasi
	{
		get
		{
			return this.GetValue(TableUtils.FirmaKatalogDosyasiColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaKatalogDosyasiColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaKatalogDosyasiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaKatalogDosyasiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.FirmaKatalogDosyasi field.
	/// </summary>
	public string FirmaKatalogDosyasiDefault
	{
		get
		{
			return TableUtils.FirmaKatalogDosyasiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MIYSAHesaplar_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MIYSAHesaplar_.DuzenleyenID field.
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
