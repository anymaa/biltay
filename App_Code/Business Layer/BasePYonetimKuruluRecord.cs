// This class is "generated" and will be overwritten.
// Your customizations should be made in PYonetimKuruluRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PYonetimKuruluRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PYonetimKuruluTable"></see> class.
/// </remarks>
/// <seealso cref="PYonetimKuruluTable"></seealso>
/// <seealso cref="PYonetimKuruluRecord"></seealso>
public class BasePYonetimKuruluRecord : PrimaryKeyRecord
{

	public readonly static PYonetimKuruluTable TableUtils = PYonetimKuruluTable.Instance;

	// Constructors
 
	protected BasePYonetimKuruluRecord() : base(TableUtils)
	{
	}

	protected BasePYonetimKuruluRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YonetimID field.
	/// </summary>
	public ColumnValue GetYonetimIDValue()
	{
		return this.GetValue(TableUtils.YonetimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YonetimID field.
	/// </summary>
	public Int32 GetYonetimIDFieldValue()
	{
		return this.GetValue(TableUtils.YonetimIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiPozisyon field.
	/// </summary>
	public ColumnValue GetYoneticiPozisyonValue()
	{
		return this.GetValue(TableUtils.YoneticiPozisyonColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiPozisyon field.
	/// </summary>
	public string GetYoneticiPozisyonFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiPozisyonColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiPozisyon field.
	/// </summary>
	public void SetYoneticiPozisyonFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiPozisyonColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiPozisyon field.
	/// </summary>
	public void SetYoneticiPozisyonFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiPozisyonColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiPozisyonEN field.
	/// </summary>
	public ColumnValue GetYoneticiPozisyonENValue()
	{
		return this.GetValue(TableUtils.YoneticiPozisyonENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiPozisyonEN field.
	/// </summary>
	public string GetYoneticiPozisyonENFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiPozisyonENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiPozisyonEN field.
	/// </summary>
	public void SetYoneticiPozisyonENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiPozisyonENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiPozisyonEN field.
	/// </summary>
	public void SetYoneticiPozisyonENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiPozisyonENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiAd field.
	/// </summary>
	public ColumnValue GetYoneticiAdValue()
	{
		return this.GetValue(TableUtils.YoneticiAdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiAd field.
	/// </summary>
	public string GetYoneticiAdFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiAdColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiAd field.
	/// </summary>
	public void SetYoneticiAdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiAdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiAd field.
	/// </summary>
	public void SetYoneticiAdFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiAdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiSoyad field.
	/// </summary>
	public ColumnValue GetYoneticiSoyadValue()
	{
		return this.GetValue(TableUtils.YoneticiSoyadColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiSoyad field.
	/// </summary>
	public string GetYoneticiSoyadFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiSoyadColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSoyad field.
	/// </summary>
	public void SetYoneticiSoyadFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiSoyadColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSoyad field.
	/// </summary>
	public void SetYoneticiSoyadFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiSoyadColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiIletisim field.
	/// </summary>
	public ColumnValue GetYoneticiIletisimValue()
	{
		return this.GetValue(TableUtils.YoneticiIletisimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiIletisim field.
	/// </summary>
	public string GetYoneticiIletisimFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiIletisimColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiIletisim field.
	/// </summary>
	public void SetYoneticiIletisimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiIletisimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiIletisim field.
	/// </summary>
	public void SetYoneticiIletisimFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiIletisimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public ColumnValue GetYoneticiGrupIDValue()
	{
		return this.GetValue(TableUtils.YoneticiGrupIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public Int16 GetYoneticiGrupIDFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiGrupIDColumn).ToInt16();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public void SetYoneticiGrupIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiGrupIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public void SetYoneticiGrupIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.YoneticiGrupIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public void SetYoneticiGrupIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiGrupIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public void SetYoneticiGrupIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiGrupIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public void SetYoneticiGrupIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiGrupIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public ColumnValue GetYoneticiSiraValue()
	{
		return this.GetValue(TableUtils.YoneticiSiraColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public Int16 GetYoneticiSiraFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiSiraColumn).ToInt16();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public void SetYoneticiSiraFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiSiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public void SetYoneticiSiraFieldValue(string val)
	{
		this.SetString(val, TableUtils.YoneticiSiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public void SetYoneticiSiraFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiSiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public void SetYoneticiSiraFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiSiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public void SetYoneticiSiraFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiSiraColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public ColumnValue GetYoneticiResimValue()
	{
		return this.GetValue(TableUtils.YoneticiResimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public byte[] GetYoneticiResimFieldValue()
	{
		return this.GetValue(TableUtils.YoneticiResimColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public void SetYoneticiResimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YoneticiResimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public void SetYoneticiResimFieldValue(string val)
	{
		this.SetString(val, TableUtils.YoneticiResimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public void SetYoneticiResimFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YoneticiResimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YonetimID field.
	/// </summary>
	public Int32 YonetimID
	{
		get
		{
			return this.GetValue(TableUtils.YonetimIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YonetimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YonetimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YonetimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YonetimID field.
	/// </summary>
	public string YonetimIDDefault
	{
		get
		{
			return TableUtils.YonetimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiPozisyon field.
	/// </summary>
	public string YoneticiPozisyon
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiPozisyonColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiPozisyonColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiPozisyonSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiPozisyonColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiPozisyon field.
	/// </summary>
	public string YoneticiPozisyonDefault
	{
		get
		{
			return TableUtils.YoneticiPozisyonColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiPozisyonEN field.
	/// </summary>
	public string YoneticiPozisyonEN
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiPozisyonENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiPozisyonENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiPozisyonENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiPozisyonENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiPozisyonEN field.
	/// </summary>
	public string YoneticiPozisyonENDefault
	{
		get
		{
			return TableUtils.YoneticiPozisyonENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiAd field.
	/// </summary>
	public string YoneticiAd
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiAdColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiAdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiAdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiAdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiAd field.
	/// </summary>
	public string YoneticiAdDefault
	{
		get
		{
			return TableUtils.YoneticiAdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiSoyad field.
	/// </summary>
	public string YoneticiSoyad
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiSoyadColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiSoyadColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiSoyadSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiSoyadColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSoyad field.
	/// </summary>
	public string YoneticiSoyadDefault
	{
		get
		{
			return TableUtils.YoneticiSoyadColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiIletisim field.
	/// </summary>
	public string YoneticiIletisim
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiIletisimColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiIletisimColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiIletisimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiIletisimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiIletisim field.
	/// </summary>
	public string YoneticiIletisimDefault
	{
		get
		{
			return TableUtils.YoneticiIletisimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public Int16 YoneticiGrupID
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiGrupIDColumn).ToInt16();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiGrupIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiGrupIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiGrupIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiGrupID field.
	/// </summary>
	public string YoneticiGrupIDDefault
	{
		get
		{
			return TableUtils.YoneticiGrupIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public Int16 YoneticiSira
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiSiraColumn).ToInt16();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiSiraColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiSiraSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiSiraColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiSira field.
	/// </summary>
	public string YoneticiSiraDefault
	{
		get
		{
			return TableUtils.YoneticiSiraColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public byte[] YoneticiResim
	{
		get
		{
			return this.GetValue(TableUtils.YoneticiResimColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YoneticiResimColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YoneticiResimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YoneticiResimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.YoneticiResim field.
	/// </summary>
	public string YoneticiResimDefault
	{
		get
		{
			return TableUtils.YoneticiResimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYonetimKurulu_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYonetimKurulu_.DuzenleyenID field.
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
