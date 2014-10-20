// This class is "generated" and will be overwritten.
// Your customizations should be made in ParaBirimleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="ParaBirimleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ParaBirimleriTable"></see> class.
/// </remarks>
/// <seealso cref="ParaBirimleriTable"></seealso>
/// <seealso cref="ParaBirimleriRecord"></seealso>
public class BaseParaBirimleriRecord : PrimaryKeyRecord
{

	public readonly static ParaBirimleriTable TableUtils = ParaBirimleriTable.Instance;

	// Constructors
 
	protected BaseParaBirimleriRecord() : base(TableUtils)
	{
	}

	protected BaseParaBirimleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ParaBirimID field.
	/// </summary>
	public ColumnValue GetParaBirimIDValue()
	{
		return this.GetValue(TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ParaBirimID field.
	/// </summary>
	public Byte GetParaBirimIDFieldValue()
	{
		return this.GetValue(TableUtils.ParaBirimIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ParaBirimAdi field.
	/// </summary>
	public ColumnValue GetParaBirimAdiValue()
	{
		return this.GetValue(TableUtils.ParaBirimAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ParaBirimAdi field.
	/// </summary>
	public string GetParaBirimAdiFieldValue()
	{
		return this.GetValue(TableUtils.ParaBirimAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimAdi field.
	/// </summary>
	public void SetParaBirimAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParaBirimAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimAdi field.
	/// </summary>
	public void SetParaBirimAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ParaBirimAdiEN field.
	/// </summary>
	public ColumnValue GetParaBirimAdiENValue()
	{
		return this.GetValue(TableUtils.ParaBirimAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ParaBirimAdiEN field.
	/// </summary>
	public string GetParaBirimAdiENFieldValue()
	{
		return this.GetValue(TableUtils.ParaBirimAdiENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimAdiEN field.
	/// </summary>
	public void SetParaBirimAdiENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParaBirimAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimAdiEN field.
	/// </summary>
	public void SetParaBirimAdiENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimAdiENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.Sembolu field.
	/// </summary>
	public ColumnValue GetSemboluValue()
	{
		return this.GetValue(TableUtils.SemboluColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.Sembolu field.
	/// </summary>
	public string GetSemboluFieldValue()
	{
		return this.GetValue(TableUtils.SemboluColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.Sembolu field.
	/// </summary>
	public void SetSemboluFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SemboluColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.Sembolu field.
	/// </summary>
	public void SetSemboluFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SemboluColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ISO4127Kodu field.
	/// </summary>
	public ColumnValue GetISO4127KoduValue()
	{
		return this.GetValue(TableUtils.ISO4127KoduColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.ISO4127Kodu field.
	/// </summary>
	public string GetISO4127KoduFieldValue()
	{
		return this.GetValue(TableUtils.ISO4127KoduColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ISO4127Kodu field.
	/// </summary>
	public void SetISO4127KoduFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ISO4127KoduColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ISO4127Kodu field.
	/// </summary>
	public void SetISO4127KoduFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ISO4127KoduColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public ColumnValue GetDuzenleyeneIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyeneIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public Int32 GetDuzenleyeneIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyeneIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public void SetDuzenleyeneIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyeneIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public void SetDuzenleyeneIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyeneIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public void SetDuzenleyeneIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyeneIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public void SetDuzenleyeneIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyeneIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public void SetDuzenleyeneIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyeneIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ParaBirimleri_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.ParaBirimID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimID field.
	/// </summary>
	public string ParaBirimIDDefault
	{
		get
		{
			return TableUtils.ParaBirimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.ParaBirimAdi field.
	/// </summary>
	public string ParaBirimAdi
	{
		get
		{
			return this.GetValue(TableUtils.ParaBirimAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParaBirimAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParaBirimAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParaBirimAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimAdi field.
	/// </summary>
	public string ParaBirimAdiDefault
	{
		get
		{
			return TableUtils.ParaBirimAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.ParaBirimAdiEN field.
	/// </summary>
	public string ParaBirimAdiEN
	{
		get
		{
			return this.GetValue(TableUtils.ParaBirimAdiENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParaBirimAdiENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParaBirimAdiENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParaBirimAdiENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ParaBirimAdiEN field.
	/// </summary>
	public string ParaBirimAdiENDefault
	{
		get
		{
			return TableUtils.ParaBirimAdiENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.Sembolu field.
	/// </summary>
	public string Sembolu
	{
		get
		{
			return this.GetValue(TableUtils.SemboluColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SemboluColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SemboluSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SemboluColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.Sembolu field.
	/// </summary>
	public string SemboluDefault
	{
		get
		{
			return TableUtils.SemboluColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.ISO4127Kodu field.
	/// </summary>
	public string ISO4127Kodu
	{
		get
		{
			return this.GetValue(TableUtils.ISO4127KoduColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ISO4127KoduColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ISO4127KoduSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ISO4127KoduColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.ISO4127Kodu field.
	/// </summary>
	public string ISO4127KoduDefault
	{
		get
		{
			return TableUtils.ISO4127KoduColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public Int32 DuzenleyeneID
	{
		get
		{
			return this.GetValue(TableUtils.DuzenleyeneIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DuzenleyeneIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DuzenleyeneIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DuzenleyeneIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.DuzenleyeneID field.
	/// </summary>
	public string DuzenleyeneIDDefault
	{
		get
		{
			return TableUtils.DuzenleyeneIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ParaBirimleri_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's ParaBirimleri_.AktifPasif field.
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
