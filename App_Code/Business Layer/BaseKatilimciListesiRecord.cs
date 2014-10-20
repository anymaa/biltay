// This class is "generated" and will be overwritten.
// Your customizations should be made in KatilimciListesiRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="KatilimciListesiRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="KatilimciListesiTable"></see> class.
/// </remarks>
/// <seealso cref="KatilimciListesiTable"></seealso>
/// <seealso cref="KatilimciListesiRecord"></seealso>
public class BaseKatilimciListesiRecord : PrimaryKeyRecord
{

	public readonly static KatilimciListesiTable TableUtils = KatilimciListesiTable.Instance;

	// Constructors
 
	protected BaseKatilimciListesiRecord() : base(TableUtils)
	{
	}

	protected BaseKatilimciListesiRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.KatilimciID field.
	/// </summary>
	public ColumnValue GetKatilimciIDValue()
	{
		return this.GetValue(TableUtils.KatilimciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.KatilimciID field.
	/// </summary>
	public Int32 GetKatilimciIDFieldValue()
	{
		return this.GetValue(TableUtils.KatilimciIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public ColumnValue GetEtkinlikIDValue()
	{
		return this.GetValue(TableUtils.EtkinlikIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public Int32 GetEtkinlikIDFieldValue()
	{
		return this.GetValue(TableUtils.EtkinlikIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public void SetEtkinlikIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EtkinlikIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public void SetEtkinlikIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.EtkinlikIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public void SetEtkinlikIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EtkinlikIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public void SetEtkinlikIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EtkinlikIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public void SetEtkinlikIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EtkinlikIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public ColumnValue GetKullaniciIDValue()
	{
		return this.GetValue(TableUtils.KullaniciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public Int32 GetKullaniciIDFieldValue()
	{
		return this.GetValue(TableUtils.KullaniciIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public void SetKullaniciIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KullaniciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public void SetKullaniciIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.KullaniciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public void SetKullaniciIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KullaniciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public void SetKullaniciIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KullaniciIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public void SetKullaniciIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KullaniciIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public ColumnValue GetEgitiminKalitesiValue()
	{
		return this.GetValue(TableUtils.EgitiminKalitesiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public Byte GetEgitiminKalitesiFieldValue()
	{
		return this.GetValue(TableUtils.EgitiminKalitesiColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public void SetEgitiminKalitesiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitiminKalitesiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public void SetEgitiminKalitesiFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitiminKalitesiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public void SetEgitiminKalitesiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKalitesiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public void SetEgitiminKalitesiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKalitesiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public void SetEgitiminKalitesiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKalitesiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public ColumnValue GetEgitiminKonusuValue()
	{
		return this.GetValue(TableUtils.EgitiminKonusuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public Byte GetEgitiminKonusuFieldValue()
	{
		return this.GetValue(TableUtils.EgitiminKonusuColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public void SetEgitiminKonusuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitiminKonusuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public void SetEgitiminKonusuFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitiminKonusuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public void SetEgitiminKonusuFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKonusuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public void SetEgitiminKonusuFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKonusuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public void SetEgitiminKonusuFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKonusuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public ColumnValue GetEgitimSuresiValue()
	{
		return this.GetValue(TableUtils.EgitimSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public Byte GetEgitimSuresiFieldValue()
	{
		return this.GetValue(TableUtils.EgitimSuresiColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public void SetEgitimSuresiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitimSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public void SetEgitimSuresiFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitimSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public void SetEgitimSuresiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public void SetEgitimSuresiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimSuresiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public void SetEgitimSuresiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimSuresiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public ColumnValue GetEgitimZamaniValue()
	{
		return this.GetValue(TableUtils.EgitimZamaniColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public Byte GetEgitimZamaniFieldValue()
	{
		return this.GetValue(TableUtils.EgitimZamaniColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public void SetEgitimZamaniFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitimZamaniColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public void SetEgitimZamaniFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitimZamaniColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public void SetEgitimZamaniFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimZamaniColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public void SetEgitimZamaniFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimZamaniColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public void SetEgitimZamaniFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimZamaniColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public ColumnValue GetEgitimOrtamValue()
	{
		return this.GetValue(TableUtils.EgitimOrtamColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public Byte GetEgitimOrtamFieldValue()
	{
		return this.GetValue(TableUtils.EgitimOrtamColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public void SetEgitimOrtamFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitimOrtamColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public void SetEgitimOrtamFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitimOrtamColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public void SetEgitimOrtamFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimOrtamColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public void SetEgitimOrtamFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimOrtamColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public void SetEgitimOrtamFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimOrtamColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public ColumnValue GetEgitiminIseKatkisiValue()
	{
		return this.GetValue(TableUtils.EgitiminIseKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public Byte GetEgitiminIseKatkisiFieldValue()
	{
		return this.GetValue(TableUtils.EgitiminIseKatkisiColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public void SetEgitiminIseKatkisiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitiminIseKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public void SetEgitiminIseKatkisiFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitiminIseKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public void SetEgitiminIseKatkisiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminIseKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public void SetEgitiminIseKatkisiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminIseKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public void SetEgitiminIseKatkisiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminIseKatkisiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public ColumnValue GetEgitiminKisiyeKatkisiValue()
	{
		return this.GetValue(TableUtils.EgitiminKisiyeKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public Byte GetEgitiminKisiyeKatkisiFieldValue()
	{
		return this.GetValue(TableUtils.EgitiminKisiyeKatkisiColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public void SetEgitiminKisiyeKatkisiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitiminKisiyeKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public void SetEgitiminKisiyeKatkisiFieldValue(string val)
	{
		this.SetString(val, TableUtils.EgitiminKisiyeKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public void SetEgitiminKisiyeKatkisiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKisiyeKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public void SetEgitiminKisiyeKatkisiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKisiyeKatkisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public void SetEgitiminKisiyeKatkisiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitiminKisiyeKatkisiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.KatilimciID field.
	/// </summary>
	public Int32 KatilimciID
	{
		get
		{
			return this.GetValue(TableUtils.KatilimciIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KatilimciIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KatilimciIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KatilimciIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KatilimciID field.
	/// </summary>
	public string KatilimciIDDefault
	{
		get
		{
			return TableUtils.KatilimciIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EtkinlikID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EtkinlikID field.
	/// </summary>
	public string EtkinlikIDDefault
	{
		get
		{
			return TableUtils.EtkinlikIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.KullaniciID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.KullaniciID field.
	/// </summary>
	public string KullaniciIDDefault
	{
		get
		{
			return TableUtils.KullaniciIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public Byte EgitiminKalitesi
	{
		get
		{
			return this.GetValue(TableUtils.EgitiminKalitesiColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitiminKalitesiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitiminKalitesiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitiminKalitesiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKalitesi field.
	/// </summary>
	public string EgitiminKalitesiDefault
	{
		get
		{
			return TableUtils.EgitiminKalitesiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public Byte EgitiminKonusu
	{
		get
		{
			return this.GetValue(TableUtils.EgitiminKonusuColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitiminKonusuColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitiminKonusuSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitiminKonusuColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKonusu field.
	/// </summary>
	public string EgitiminKonusuDefault
	{
		get
		{
			return TableUtils.EgitiminKonusuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public Byte EgitimSuresi
	{
		get
		{
			return this.GetValue(TableUtils.EgitimSuresiColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitimSuresiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitimSuresiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitimSuresiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimSuresi field.
	/// </summary>
	public string EgitimSuresiDefault
	{
		get
		{
			return TableUtils.EgitimSuresiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public Byte EgitimZamani
	{
		get
		{
			return this.GetValue(TableUtils.EgitimZamaniColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitimZamaniColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitimZamaniSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitimZamaniColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimZamani field.
	/// </summary>
	public string EgitimZamaniDefault
	{
		get
		{
			return TableUtils.EgitimZamaniColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public Byte EgitimOrtam
	{
		get
		{
			return this.GetValue(TableUtils.EgitimOrtamColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitimOrtamColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitimOrtamSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitimOrtamColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitimOrtam field.
	/// </summary>
	public string EgitimOrtamDefault
	{
		get
		{
			return TableUtils.EgitimOrtamColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public Byte EgitiminIseKatkisi
	{
		get
		{
			return this.GetValue(TableUtils.EgitiminIseKatkisiColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitiminIseKatkisiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitiminIseKatkisiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitiminIseKatkisiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminIseKatkisi field.
	/// </summary>
	public string EgitiminIseKatkisiDefault
	{
		get
		{
			return TableUtils.EgitiminIseKatkisiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public Byte EgitiminKisiyeKatkisi
	{
		get
		{
			return this.GetValue(TableUtils.EgitiminKisiyeKatkisiColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitiminKisiyeKatkisiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitiminKisiyeKatkisiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitiminKisiyeKatkisiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's KatilimciListesi_.EgitiminKisiyeKatkisi field.
	/// </summary>
	public string EgitiminKisiyeKatkisiDefault
	{
		get
		{
			return TableUtils.EgitiminKisiyeKatkisiColumn.DefaultValue;
		}
	}


#endregion
}

}
