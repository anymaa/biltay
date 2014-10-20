// This class is "generated" and will be overwritten.
// Your customizations should be made in YayinlarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="YayinlarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="YayinlarTable"></see> class.
/// </remarks>
/// <seealso cref="YayinlarTable"></seealso>
/// <seealso cref="YayinlarRecord"></seealso>
public class BaseYayinlarRecord : PrimaryKeyRecord
{

	public readonly static YayinlarTable TableUtils = YayinlarTable.Instance;

	// Constructors
 
	protected BaseYayinlarRecord() : base(TableUtils)
	{
	}

	protected BaseYayinlarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.YayinID field.
	/// </summary>
	public ColumnValue GetYayinIDValue()
	{
		return this.GetValue(TableUtils.YayinIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.YayinID field.
	/// </summary>
	public Int32 GetYayinIDFieldValue()
	{
		return this.GetValue(TableUtils.YayinIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.Konu field.
	/// </summary>
	public ColumnValue GetKonuValue()
	{
		return this.GetValue(TableUtils.KonuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.Konu field.
	/// </summary>
	public string GetKonuFieldValue()
	{
		return this.GetValue(TableUtils.KonuColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.Konu field.
	/// </summary>
	public void SetKonuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KonuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.Konu field.
	/// </summary>
	public void SetKonuFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KonuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.KonuEN field.
	/// </summary>
	public ColumnValue GetKonuENValue()
	{
		return this.GetValue(TableUtils.KonuENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.KonuEN field.
	/// </summary>
	public string GetKonuENFieldValue()
	{
		return this.GetValue(TableUtils.KonuENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.KonuEN field.
	/// </summary>
	public void SetKonuENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KonuENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.KonuEN field.
	/// </summary>
	public void SetKonuENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KonuENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.OnYazi field.
	/// </summary>
	public ColumnValue GetOnYaziValue()
	{
		return this.GetValue(TableUtils.OnYaziColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.OnYazi field.
	/// </summary>
	public string GetOnYaziFieldValue()
	{
		return this.GetValue(TableUtils.OnYaziColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.OnYazi field.
	/// </summary>
	public void SetOnYaziFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnYaziColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.OnYazi field.
	/// </summary>
	public void SetOnYaziFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnYaziColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.OnYaziEN field.
	/// </summary>
	public ColumnValue GetOnYaziENValue()
	{
		return this.GetValue(TableUtils.OnYaziENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.OnYaziEN field.
	/// </summary>
	public string GetOnYaziENFieldValue()
	{
		return this.GetValue(TableUtils.OnYaziENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.OnYaziEN field.
	/// </summary>
	public void SetOnYaziENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OnYaziENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.OnYaziEN field.
	/// </summary>
	public void SetOnYaziENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OnYaziENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.AciklamaEN field.
	/// </summary>
	public ColumnValue GetAciklamaENValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.AciklamaEN field.
	/// </summary>
	public string GetAciklamaENFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.DosyaLinki field.
	/// </summary>
	public ColumnValue GetDosyaLinkiValue()
	{
		return this.GetValue(TableUtils.DosyaLinkiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.DosyaLinki field.
	/// </summary>
	public string GetDosyaLinkiFieldValue()
	{
		return this.GetValue(TableUtils.DosyaLinkiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DosyaLinki field.
	/// </summary>
	public void SetDosyaLinkiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DosyaLinkiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DosyaLinki field.
	/// </summary>
	public void SetDosyaLinkiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DosyaLinkiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public ColumnValue GetEkleyenIDValue()
	{
		return this.GetValue(TableUtils.EkleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public Int32 GetEkleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.EkleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public void SetEkleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EkleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public void SetEkleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.EkleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public void SetEkleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EkleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public void SetEkleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EkleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public void SetEkleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EkleyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public ColumnValue GetEklenmeTarihiValue()
	{
		return this.GetValue(TableUtils.EklenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public DateTime GetEklenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.EklenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public void SetEklenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EklenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public void SetEklenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.EklenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public void SetEklenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EklenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public ColumnValue GetDuzenlenyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public Int32 GetDuzenlenyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Yayinlar_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.YayinID field.
	/// </summary>
	public Int32 YayinID
	{
		get
		{
			return this.GetValue(TableUtils.YayinIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YayinIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YayinIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YayinIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.YayinID field.
	/// </summary>
	public string YayinIDDefault
	{
		get
		{
			return TableUtils.YayinIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.Konu field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.Konu field.
	/// </summary>
	public string KonuDefault
	{
		get
		{
			return TableUtils.KonuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.KonuEN field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.KonuEN field.
	/// </summary>
	public string KonuENDefault
	{
		get
		{
			return TableUtils.KonuENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.OnYazi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.OnYazi field.
	/// </summary>
	public string OnYaziDefault
	{
		get
		{
			return TableUtils.OnYaziColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.OnYaziEN field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.OnYaziEN field.
	/// </summary>
	public string OnYaziENDefault
	{
		get
		{
			return TableUtils.OnYaziENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.Aciklama field.
	/// </summary>
	public string AciklamaDefault
	{
		get
		{
			return TableUtils.AciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.AciklamaEN field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AciklamaEN field.
	/// </summary>
	public string AciklamaENDefault
	{
		get
		{
			return TableUtils.AciklamaENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.DosyaLinki field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DosyaLinki field.
	/// </summary>
	public string DosyaLinkiDefault
	{
		get
		{
			return TableUtils.DosyaLinkiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public Int32 EkleyenID
	{
		get
		{
			return this.GetValue(TableUtils.EkleyenIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EkleyenIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EkleyenIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EkleyenIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EkleyenID field.
	/// </summary>
	public string EkleyenIDDefault
	{
		get
		{
			return TableUtils.EkleyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public DateTime EklenmeTarihi
	{
		get
		{
			return this.GetValue(TableUtils.EklenmeTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EklenmeTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EklenmeTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EklenmeTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.EklenmeTarihi field.
	/// </summary>
	public string EklenmeTarihiDefault
	{
		get
		{
			return TableUtils.EklenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public Int32 DuzenlenyenID
	{
		get
		{
			return this.GetValue(TableUtils.DuzenlenyenIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DuzenlenyenIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DuzenlenyenIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenyenID field.
	/// </summary>
	public string DuzenlenyenIDDefault
	{
		get
		{
			return TableUtils.DuzenlenyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Yayinlar_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Yayinlar_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}


#endregion
}

}
