// This class is "generated" and will be overwritten.
// Your customizations should be made in HaberlerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="HaberlerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="HaberlerTable"></see> class.
/// </remarks>
/// <seealso cref="HaberlerTable"></seealso>
/// <seealso cref="HaberlerRecord"></seealso>
public class BaseHaberlerRecord : PrimaryKeyRecord
{

	public readonly static HaberlerTable TableUtils = HaberlerTable.Instance;

	// Constructors
 
	protected BaseHaberlerRecord() : base(TableUtils)
	{
	}

	protected BaseHaberlerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberID field.
	/// </summary>
	public ColumnValue GetHaberIDValue()
	{
		return this.GetValue(TableUtils.HaberIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberID field.
	/// </summary>
	public Int32 GetHaberIDFieldValue()
	{
		return this.GetValue(TableUtils.HaberIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberBaslik field.
	/// </summary>
	public ColumnValue GetHaberBaslikValue()
	{
		return this.GetValue(TableUtils.HaberBaslikColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberBaslik field.
	/// </summary>
	public string GetHaberBaslikFieldValue()
	{
		return this.GetValue(TableUtils.HaberBaslikColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberBaslik field.
	/// </summary>
	public void SetHaberBaslikFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberBaslikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberBaslik field.
	/// </summary>
	public void SetHaberBaslikFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberBaslikColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberBaslikEN field.
	/// </summary>
	public ColumnValue GetHaberBaslikENValue()
	{
		return this.GetValue(TableUtils.HaberBaslikENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberBaslikEN field.
	/// </summary>
	public string GetHaberBaslikENFieldValue()
	{
		return this.GetValue(TableUtils.HaberBaslikENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberBaslikEN field.
	/// </summary>
	public void SetHaberBaslikENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberBaslikENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberBaslikEN field.
	/// </summary>
	public void SetHaberBaslikENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberBaslikENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberOnYazi field.
	/// </summary>
	public ColumnValue GetHaberOnYaziValue()
	{
		return this.GetValue(TableUtils.HaberOnYaziColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberOnYazi field.
	/// </summary>
	public string GetHaberOnYaziFieldValue()
	{
		return this.GetValue(TableUtils.HaberOnYaziColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberOnYazi field.
	/// </summary>
	public void SetHaberOnYaziFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberOnYaziColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberOnYazi field.
	/// </summary>
	public void SetHaberOnYaziFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberOnYaziColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberOnYaziEN field.
	/// </summary>
	public ColumnValue GetHaberOnYaziENValue()
	{
		return this.GetValue(TableUtils.HaberOnYaziENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberOnYaziEN field.
	/// </summary>
	public string GetHaberOnYaziENFieldValue()
	{
		return this.GetValue(TableUtils.HaberOnYaziENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberOnYaziEN field.
	/// </summary>
	public void SetHaberOnYaziENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberOnYaziENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberOnYaziEN field.
	/// </summary>
	public void SetHaberOnYaziENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberOnYaziENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberIcerik field.
	/// </summary>
	public ColumnValue GetHaberIcerikValue()
	{
		return this.GetValue(TableUtils.HaberIcerikColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberIcerik field.
	/// </summary>
	public string GetHaberIcerikFieldValue()
	{
		return this.GetValue(TableUtils.HaberIcerikColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberIcerik field.
	/// </summary>
	public void SetHaberIcerikFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberIcerikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberIcerik field.
	/// </summary>
	public void SetHaberIcerikFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberIcerikColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberIcerikEN field.
	/// </summary>
	public ColumnValue GetHaberIcerikENValue()
	{
		return this.GetValue(TableUtils.HaberIcerikENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberIcerikEN field.
	/// </summary>
	public string GetHaberIcerikENFieldValue()
	{
		return this.GetValue(TableUtils.HaberIcerikENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberIcerikEN field.
	/// </summary>
	public void SetHaberIcerikENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberIcerikENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberIcerikEN field.
	/// </summary>
	public void SetHaberIcerikENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberIcerikENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public ColumnValue GetHaberAktifValue()
	{
		return this.GetValue(TableUtils.HaberAktifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public bool GetHaberAktifFieldValue()
	{
		return this.GetValue(TableUtils.HaberAktifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public void SetHaberAktifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HaberAktifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public void SetHaberAktifFieldValue(string val)
	{
		this.SetString(val, TableUtils.HaberAktifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public void SetHaberAktifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HaberAktifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public ColumnValue GetYetkiIDValue()
	{
		return this.GetValue(TableUtils.YetkiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public Int32 GetYetkiIDFieldValue()
	{
		return this.GetValue(TableUtils.YetkiIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public void SetYetkiIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetkiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public void SetYetkiIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.YetkiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public void SetYetkiIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public void SetYetkiIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public void SetYetkiIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Haberler_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberID field.
	/// </summary>
	public Int32 HaberID
	{
		get
		{
			return this.GetValue(TableUtils.HaberIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberID field.
	/// </summary>
	public string HaberIDDefault
	{
		get
		{
			return TableUtils.HaberIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberBaslik field.
	/// </summary>
	public string HaberBaslik
	{
		get
		{
			return this.GetValue(TableUtils.HaberBaslikColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberBaslikColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberBaslikSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberBaslikColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberBaslik field.
	/// </summary>
	public string HaberBaslikDefault
	{
		get
		{
			return TableUtils.HaberBaslikColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberBaslikEN field.
	/// </summary>
	public string HaberBaslikEN
	{
		get
		{
			return this.GetValue(TableUtils.HaberBaslikENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberBaslikENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberBaslikENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberBaslikENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberBaslikEN field.
	/// </summary>
	public string HaberBaslikENDefault
	{
		get
		{
			return TableUtils.HaberBaslikENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberOnYazi field.
	/// </summary>
	public string HaberOnYazi
	{
		get
		{
			return this.GetValue(TableUtils.HaberOnYaziColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberOnYaziColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberOnYaziSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberOnYaziColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberOnYazi field.
	/// </summary>
	public string HaberOnYaziDefault
	{
		get
		{
			return TableUtils.HaberOnYaziColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberOnYaziEN field.
	/// </summary>
	public string HaberOnYaziEN
	{
		get
		{
			return this.GetValue(TableUtils.HaberOnYaziENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberOnYaziENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberOnYaziENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberOnYaziENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberOnYaziEN field.
	/// </summary>
	public string HaberOnYaziENDefault
	{
		get
		{
			return TableUtils.HaberOnYaziENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberIcerik field.
	/// </summary>
	public string HaberIcerik
	{
		get
		{
			return this.GetValue(TableUtils.HaberIcerikColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberIcerikColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberIcerikSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberIcerikColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberIcerik field.
	/// </summary>
	public string HaberIcerikDefault
	{
		get
		{
			return TableUtils.HaberIcerikColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberIcerikEN field.
	/// </summary>
	public string HaberIcerikEN
	{
		get
		{
			return this.GetValue(TableUtils.HaberIcerikENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HaberIcerikENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberIcerikENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberIcerikENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberIcerikEN field.
	/// </summary>
	public string HaberIcerikENDefault
	{
		get
		{
			return TableUtils.HaberIcerikENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public bool HaberAktif
	{
		get
		{
			return this.GetValue(TableUtils.HaberAktifColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.HaberAktifColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HaberAktifSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HaberAktifColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.HaberAktif field.
	/// </summary>
	public string HaberAktifDefault
	{
		get
		{
			return TableUtils.HaberAktifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public Int32 YetkiID
	{
		get
		{
			return this.GetValue(TableUtils.YetkiIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetkiIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetkiIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetkiIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.YetkiID field.
	/// </summary>
	public string YetkiIDDefault
	{
		get
		{
			return TableUtils.YetkiIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Haberler_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Haberler_.AktifPasif field.
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
