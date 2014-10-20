// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleTurleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IhaleTurleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IhaleTurleriTable"></see> class.
/// </remarks>
/// <seealso cref="IhaleTurleriTable"></seealso>
/// <seealso cref="IhaleTurleriRecord"></seealso>
public class BaseIhaleTurleriRecord : PrimaryKeyRecord
{

	public readonly static IhaleTurleriTable TableUtils = IhaleTurleriTable.Instance;

	// Constructors
 
	protected BaseIhaleTurleriRecord() : base(TableUtils)
	{
	}

	protected BaseIhaleTurleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.IhaleTurID field.
	/// </summary>
	public ColumnValue GetIhaleTurIDValue()
	{
		return this.GetValue(TableUtils.IhaleTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.IhaleTurID field.
	/// </summary>
	public Byte GetIhaleTurIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleTurIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.IhaleTurAdi field.
	/// </summary>
	public ColumnValue GetIhaleTurAdiValue()
	{
		return this.GetValue(TableUtils.IhaleTurAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.IhaleTurAdi field.
	/// </summary>
	public string GetIhaleTurAdiFieldValue()
	{
		return this.GetValue(TableUtils.IhaleTurAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurAdi field.
	/// </summary>
	public void SetIhaleTurAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleTurAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurAdi field.
	/// </summary>
	public void SetIhaleTurAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTurAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.IhaleTurAdiEN field.
	/// </summary>
	public ColumnValue GetIhaleTurAdiENValue()
	{
		return this.GetValue(TableUtils.IhaleTurAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.IhaleTurAdiEN field.
	/// </summary>
	public string GetIhaleTurAdiENFieldValue()
	{
		return this.GetValue(TableUtils.IhaleTurAdiENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurAdiEN field.
	/// </summary>
	public void SetIhaleTurAdiENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleTurAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurAdiEN field.
	/// </summary>
	public void SetIhaleTurAdiENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTurAdiENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public ColumnValue GetDuzenlenyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public Int32 GetDuzenlenyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public void SetDuzenlenyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTurleri_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.IhaleTurID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurID field.
	/// </summary>
	public string IhaleTurIDDefault
	{
		get
		{
			return TableUtils.IhaleTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.IhaleTurAdi field.
	/// </summary>
	public string IhaleTurAdi
	{
		get
		{
			return this.GetValue(TableUtils.IhaleTurAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleTurAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleTurAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleTurAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurAdi field.
	/// </summary>
	public string IhaleTurAdiDefault
	{
		get
		{
			return TableUtils.IhaleTurAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.IhaleTurAdiEN field.
	/// </summary>
	public string IhaleTurAdiEN
	{
		get
		{
			return this.GetValue(TableUtils.IhaleTurAdiENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleTurAdiENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleTurAdiENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleTurAdiENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.IhaleTurAdiEN field.
	/// </summary>
	public string IhaleTurAdiENDefault
	{
		get
		{
			return TableUtils.IhaleTurAdiENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.DuzenlenyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.DuzenlenyenID field.
	/// </summary>
	public string DuzenlenyenIDDefault
	{
		get
		{
			return TableUtils.DuzenlenyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTurleri_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTurleri_.AktifPasif field.
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
