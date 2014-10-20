// This class is "generated" and will be overwritten.
// Your customizations should be made in IKKullanicilarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IKKullanicilarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IKKullanicilarTable"></see> class.
/// </remarks>
/// <seealso cref="IKKullanicilarTable"></seealso>
/// <seealso cref="IKKullanicilarRecord"></seealso>
public class BaseIKKullanicilarRecord : PrimaryKeyRecord
{

	public readonly static IKKullanicilarTable TableUtils = IKKullanicilarTable.Instance;

	// Constructors
 
	protected BaseIKKullanicilarRecord() : base(TableUtils)
	{
	}

	protected BaseIKKullanicilarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.KullaniciID field.
	/// </summary>
	public ColumnValue GetKullaniciIDValue()
	{
		return this.GetValue(TableUtils.KullaniciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.KullaniciID field.
	/// </summary>
	public Int32 GetKullaniciIDFieldValue()
	{
		return this.GetValue(TableUtils.KullaniciIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Adi field.
	/// </summary>
	public ColumnValue GetAdiValue()
	{
		return this.GetValue(TableUtils.AdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Adi field.
	/// </summary>
	public string GetAdiFieldValue()
	{
		return this.GetValue(TableUtils.AdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Adi field.
	/// </summary>
	public void SetAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Adi field.
	/// </summary>
	public void SetAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Soyadi field.
	/// </summary>
	public ColumnValue GetSoyadiValue()
	{
		return this.GetValue(TableUtils.SoyadiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Soyadi field.
	/// </summary>
	public string GetSoyadiFieldValue()
	{
		return this.GetValue(TableUtils.SoyadiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Soyadi field.
	/// </summary>
	public void SetSoyadiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SoyadiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Soyadi field.
	/// </summary>
	public void SetSoyadiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SoyadiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Eposta field.
	/// </summary>
	public ColumnValue GetEpostaValue()
	{
		return this.GetValue(TableUtils.EpostaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Eposta field.
	/// </summary>
	public string GetEpostaFieldValue()
	{
		return this.GetValue(TableUtils.EpostaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Eposta field.
	/// </summary>
	public void SetEpostaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EpostaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Eposta field.
	/// </summary>
	public void SetEpostaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EpostaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.GSM field.
	/// </summary>
	public ColumnValue GetGSMValue()
	{
		return this.GetValue(TableUtils.GSMColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.GSM field.
	/// </summary>
	public string GetGSMFieldValue()
	{
		return this.GetValue(TableUtils.GSMColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.GSM field.
	/// </summary>
	public void SetGSMFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GSMColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.GSM field.
	/// </summary>
	public void SetGSMFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GSMColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public ColumnValue GetUnvanIDValue()
	{
		return this.GetValue(TableUtils.UnvanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public Int32 GetUnvanIDFieldValue()
	{
		return this.GetValue(TableUtils.UnvanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public void SetUnvanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UnvanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public void SetUnvanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.UnvanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public void SetUnvanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UnvanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public void SetUnvanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UnvanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public void SetUnvanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UnvanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public ColumnValue GetYetkiTurIDValue()
	{
		return this.GetValue(TableUtils.YetkiTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public Int32 GetYetkiTurIDFieldValue()
	{
		return this.GetValue(TableUtils.YetkiTurIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public void SetYetkiTurIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetkiTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public void SetYetkiTurIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.YetkiTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public void SetYetkiTurIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public void SetYetkiTurIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public void SetYetkiTurIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiTurIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public ColumnValue GetHesapIDValue()
	{
		return this.GetValue(TableUtils.HesapIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public Int32 GetHesapIDFieldValue()
	{
		return this.GetValue(TableUtils.HesapIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public void SetHesapIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HesapIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public void SetHesapIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.HesapIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public void SetHesapIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HesapIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public void SetHesapIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HesapIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public void SetHesapIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HesapIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.TCKimlikNo field.
	/// </summary>
	public ColumnValue GetTCKimlikNoValue()
	{
		return this.GetValue(TableUtils.TCKimlikNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.TCKimlikNo field.
	/// </summary>
	public string GetTCKimlikNoFieldValue()
	{
		return this.GetValue(TableUtils.TCKimlikNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.TCKimlikNo field.
	/// </summary>
	public void SetTCKimlikNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TCKimlikNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.TCKimlikNo field.
	/// </summary>
	public void SetTCKimlikNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TCKimlikNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.IsTelefonu field.
	/// </summary>
	public ColumnValue GetIsTelefonuValue()
	{
		return this.GetValue(TableUtils.IsTelefonuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.IsTelefonu field.
	/// </summary>
	public string GetIsTelefonuFieldValue()
	{
		return this.GetValue(TableUtils.IsTelefonuColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.IsTelefonu field.
	/// </summary>
	public void SetIsTelefonuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsTelefonuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.IsTelefonu field.
	/// </summary>
	public void SetIsTelefonuFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsTelefonuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.KullaniciAdi field.
	/// </summary>
	public ColumnValue GetKullaniciAdiValue()
	{
		return this.GetValue(TableUtils.KullaniciAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.KullaniciAdi field.
	/// </summary>
	public string GetKullaniciAdiFieldValue()
	{
		return this.GetValue(TableUtils.KullaniciAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.KullaniciAdi field.
	/// </summary>
	public void SetKullaniciAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KullaniciAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.KullaniciAdi field.
	/// </summary>
	public void SetKullaniciAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KullaniciAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public ColumnValue GetSifreValue()
	{
		return this.GetValue(TableUtils.SifreColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public byte[] GetSifreFieldValue()
	{
		return this.GetValue(TableUtils.SifreColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public void SetSifreFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SifreColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public void SetSifreFieldValue(string val)
	{
		this.SetString(val, TableUtils.SifreColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public void SetSifreFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SifreColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKKullanicilar_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.KullaniciID field.
	/// </summary>
	public Int32 KullaniciID
	{
		get
		{
			return this.GetValue(TableUtils.KullaniciIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KullaniciIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KullaniciIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KullaniciIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.KullaniciID field.
	/// </summary>
	public string KullaniciIDDefault
	{
		get
		{
			return TableUtils.KullaniciIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.Adi field.
	/// </summary>
	public string Adi
	{
		get
		{
			return this.GetValue(TableUtils.AdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Adi field.
	/// </summary>
	public string AdiDefault
	{
		get
		{
			return TableUtils.AdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.Soyadi field.
	/// </summary>
	public string Soyadi
	{
		get
		{
			return this.GetValue(TableUtils.SoyadiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SoyadiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SoyadiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SoyadiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Soyadi field.
	/// </summary>
	public string SoyadiDefault
	{
		get
		{
			return TableUtils.SoyadiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.Eposta field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Eposta field.
	/// </summary>
	public string EpostaDefault
	{
		get
		{
			return TableUtils.EpostaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.GSM field.
	/// </summary>
	public string GSM
	{
		get
		{
			return this.GetValue(TableUtils.GSMColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GSMColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GSMSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GSMColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.GSM field.
	/// </summary>
	public string GSMDefault
	{
		get
		{
			return TableUtils.GSMColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public Int32 UnvanID
	{
		get
		{
			return this.GetValue(TableUtils.UnvanIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UnvanIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UnvanIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UnvanIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.UnvanID field.
	/// </summary>
	public string UnvanIDDefault
	{
		get
		{
			return TableUtils.UnvanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public Int32 YetkiTurID
	{
		get
		{
			return this.GetValue(TableUtils.YetkiTurIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetkiTurIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetkiTurIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetkiTurIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.YetkiTurID field.
	/// </summary>
	public string YetkiTurIDDefault
	{
		get
		{
			return TableUtils.YetkiTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.HesapID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.HesapID field.
	/// </summary>
	public string HesapIDDefault
	{
		get
		{
			return TableUtils.HesapIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.TCKimlikNo field.
	/// </summary>
	public string TCKimlikNo
	{
		get
		{
			return this.GetValue(TableUtils.TCKimlikNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TCKimlikNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TCKimlikNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TCKimlikNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.TCKimlikNo field.
	/// </summary>
	public string TCKimlikNoDefault
	{
		get
		{
			return TableUtils.TCKimlikNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.IsTelefonu field.
	/// </summary>
	public string IsTelefonu
	{
		get
		{
			return this.GetValue(TableUtils.IsTelefonuColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsTelefonuColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsTelefonuSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsTelefonuColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.IsTelefonu field.
	/// </summary>
	public string IsTelefonuDefault
	{
		get
		{
			return TableUtils.IsTelefonuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.KullaniciAdi field.
	/// </summary>
	public string KullaniciAdi
	{
		get
		{
			return this.GetValue(TableUtils.KullaniciAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KullaniciAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KullaniciAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KullaniciAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.KullaniciAdi field.
	/// </summary>
	public string KullaniciAdiDefault
	{
		get
		{
			return TableUtils.KullaniciAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public byte[] Sifre
	{
		get
		{
			return this.GetValue(TableUtils.SifreColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SifreColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SifreSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SifreColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.Sifre field.
	/// </summary>
	public string SifreDefault
	{
		get
		{
			return TableUtils.SifreColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKKullanicilar_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKKullanicilar_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}


#endregion
}

}
