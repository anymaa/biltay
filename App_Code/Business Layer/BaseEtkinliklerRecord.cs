// This class is "generated" and will be overwritten.
// Your customizations should be made in EtkinliklerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="EtkinliklerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="EtkinliklerTable"></see> class.
/// </remarks>
/// <seealso cref="EtkinliklerTable"></seealso>
/// <seealso cref="EtkinliklerRecord"></seealso>
public class BaseEtkinliklerRecord : PrimaryKeyRecord
{

	public readonly static EtkinliklerTable TableUtils = EtkinliklerTable.Instance;

	// Constructors
 
	protected BaseEtkinliklerRecord() : base(TableUtils)
	{
	}

	protected BaseEtkinliklerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikID field.
	/// </summary>
	public ColumnValue GetEtkinlikIDValue()
	{
		return this.GetValue(TableUtils.EtkinlikIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikID field.
	/// </summary>
	public Int32 GetEtkinlikIDFieldValue()
	{
		return this.GetValue(TableUtils.EtkinlikIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Konu field.
	/// </summary>
	public ColumnValue GetKonuValue()
	{
		return this.GetValue(TableUtils.KonuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Konu field.
	/// </summary>
	public string GetKonuFieldValue()
	{
		return this.GetValue(TableUtils.KonuColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Konu field.
	/// </summary>
	public void SetKonuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KonuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Konu field.
	/// </summary>
	public void SetKonuFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KonuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.KonuEN field.
	/// </summary>
	public ColumnValue GetKonuENValue()
	{
		return this.GetValue(TableUtils.KonuENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.KonuEN field.
	/// </summary>
	public string GetKonuENFieldValue()
	{
		return this.GetValue(TableUtils.KonuENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.KonuEN field.
	/// </summary>
	public void SetKonuENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KonuENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.KonuEN field.
	/// </summary>
	public void SetKonuENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KonuENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OnYazi field.
	/// </summary>
	public ColumnValue GetOnYaziValue()
	{
		return this.GetValue(TableUtils.OnYaziColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OnYazi field.
	/// </summary>
	public string GetOnYaziFieldValue()
	{
		return this.GetValue(TableUtils.OnYaziColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OnYazi field.
	/// </summary>
	public void SetOnYaziFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnYaziColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OnYazi field.
	/// </summary>
	public void SetOnYaziFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnYaziColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OnyaziEn field.
	/// </summary>
	public ColumnValue GetOnyaziEnValue()
	{
		return this.GetValue(TableUtils.OnyaziEnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OnyaziEn field.
	/// </summary>
	public string GetOnyaziEnFieldValue()
	{
		return this.GetValue(TableUtils.OnyaziEnColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OnyaziEn field.
	/// </summary>
	public void SetOnyaziEnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnyaziEnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OnyaziEn field.
	/// </summary>
	public void SetOnyaziEnFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnyaziEnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.AciklamaEN field.
	/// </summary>
	public ColumnValue GetAciklamaENValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.AciklamaEN field.
	/// </summary>
	public string GetAciklamaENFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public ColumnValue GetEtkinlikBaslangicValue()
	{
		return this.GetValue(TableUtils.EtkinlikBaslangicColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public DateTime GetEtkinlikBaslangicFieldValue()
	{
		return this.GetValue(TableUtils.EtkinlikBaslangicColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public void SetEtkinlikBaslangicFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EtkinlikBaslangicColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public void SetEtkinlikBaslangicFieldValue(string val)
	{
		this.SetString(val, TableUtils.EtkinlikBaslangicColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public void SetEtkinlikBaslangicFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EtkinlikBaslangicColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public ColumnValue GetEtkinlikBitisValue()
	{
		return this.GetValue(TableUtils.EtkinlikBitisColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public DateTime GetEtkinlikBitisFieldValue()
	{
		return this.GetValue(TableUtils.EtkinlikBitisColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public void SetEtkinlikBitisFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EtkinlikBitisColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public void SetEtkinlikBitisFieldValue(string val)
	{
		this.SetString(val, TableUtils.EtkinlikBitisColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public void SetEtkinlikBitisFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EtkinlikBitisColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Yer field.
	/// </summary>
	public ColumnValue GetYerValue()
	{
		return this.GetValue(TableUtils.YerColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Yer field.
	/// </summary>
	public string GetYerFieldValue()
	{
		return this.GetValue(TableUtils.YerColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Yer field.
	/// </summary>
	public void SetYerFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Yer field.
	/// </summary>
	public void SetYerFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YerColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Kayit field.
	/// </summary>
	public ColumnValue GetKayitValue()
	{
		return this.GetValue(TableUtils.KayitColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.Kayit field.
	/// </summary>
	public string GetKayitFieldValue()
	{
		return this.GetValue(TableUtils.KayitColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Kayit field.
	/// </summary>
	public void SetKayitFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KayitColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Kayit field.
	/// </summary>
	public void SetKayitFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KayitColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public ColumnValue GetEtkinlikEgitimValue()
	{
		return this.GetValue(TableUtils.EtkinlikEgitimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public bool GetEtkinlikEgitimFieldValue()
	{
		return this.GetValue(TableUtils.EtkinlikEgitimColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public void SetEtkinlikEgitimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EtkinlikEgitimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public void SetEtkinlikEgitimFieldValue(string val)
	{
		this.SetString(val, TableUtils.EtkinlikEgitimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public void SetEtkinlikEgitimFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EtkinlikEgitimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturulmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturulmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public DateTime GetOlusturulmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturulmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public void SetOlusturulmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturulmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public void SetOlusturulmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturulmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public void SetOlusturulmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturulmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.EtkinlikID field.
	/// </summary>
	public Int32 EtkinlikID
	{
		get
		{
			return this.GetValue(TableUtils.EtkinlikIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EtkinlikIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EtkinlikIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EtkinlikIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikID field.
	/// </summary>
	public string EtkinlikIDDefault
	{
		get
		{
			return TableUtils.EtkinlikIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.Konu field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Konu field.
	/// </summary>
	public string KonuDefault
	{
		get
		{
			return TableUtils.KonuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.KonuEN field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.KonuEN field.
	/// </summary>
	public string KonuENDefault
	{
		get
		{
			return TableUtils.KonuENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.OnYazi field.
	/// </summary>
	public string OnYazi
	{
		get
		{
			return this.GetValue(TableUtils.OnYaziColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OnYaziColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnYaziSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnYaziColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OnYazi field.
	/// </summary>
	public string OnYaziDefault
	{
		get
		{
			return TableUtils.OnYaziColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.OnyaziEn field.
	/// </summary>
	public string OnyaziEn
	{
		get
		{
			return this.GetValue(TableUtils.OnyaziEnColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OnyaziEnColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OnyaziEnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OnyaziEnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OnyaziEn field.
	/// </summary>
	public string OnyaziEnDefault
	{
		get
		{
			return TableUtils.OnyaziEnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Aciklama field.
	/// </summary>
	public string AciklamaDefault
	{
		get
		{
			return TableUtils.AciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.AciklamaEN field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AciklamaEN field.
	/// </summary>
	public string AciklamaENDefault
	{
		get
		{
			return TableUtils.AciklamaENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public DateTime EtkinlikBaslangic
	{
		get
		{
			return this.GetValue(TableUtils.EtkinlikBaslangicColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EtkinlikBaslangicColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EtkinlikBaslangicSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EtkinlikBaslangicColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBaslangic field.
	/// </summary>
	public string EtkinlikBaslangicDefault
	{
		get
		{
			return TableUtils.EtkinlikBaslangicColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public DateTime EtkinlikBitis
	{
		get
		{
			return this.GetValue(TableUtils.EtkinlikBitisColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EtkinlikBitisColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EtkinlikBitisSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EtkinlikBitisColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikBitis field.
	/// </summary>
	public string EtkinlikBitisDefault
	{
		get
		{
			return TableUtils.EtkinlikBitisColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.Yer field.
	/// </summary>
	public string Yer
	{
		get
		{
			return this.GetValue(TableUtils.YerColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YerColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YerSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YerColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Yer field.
	/// </summary>
	public string YerDefault
	{
		get
		{
			return TableUtils.YerColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.Kayit field.
	/// </summary>
	public string Kayit
	{
		get
		{
			return this.GetValue(TableUtils.KayitColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KayitColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KayitSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KayitColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.Kayit field.
	/// </summary>
	public string KayitDefault
	{
		get
		{
			return TableUtils.KayitColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public bool EtkinlikEgitim
	{
		get
		{
			return this.GetValue(TableUtils.EtkinlikEgitimColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.EtkinlikEgitimColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EtkinlikEgitimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EtkinlikEgitimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.EtkinlikEgitim field.
	/// </summary>
	public string EtkinlikEgitimDefault
	{
		get
		{
			return TableUtils.EtkinlikEgitimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public DateTime OlusturulmaTarihi
	{
		get
		{
			return this.GetValue(TableUtils.OlusturulmaTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlusturulmaTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlusturulmaTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlusturulmaTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturulmaTarihi field.
	/// </summary>
	public string OlusturulmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturulmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Etkinlikler_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Etkinlikler_.DuzenleyenID field.
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
