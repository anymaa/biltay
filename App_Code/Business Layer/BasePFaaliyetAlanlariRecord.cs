// This class is "generated" and will be overwritten.
// Your customizations should be made in PFaaliyetAlanlariRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFaaliyetAlanlariRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFaaliyetAlanlariTable"></see> class.
/// </remarks>
/// <seealso cref="PFaaliyetAlanlariTable"></seealso>
/// <seealso cref="PFaaliyetAlanlariRecord"></seealso>
public class BasePFaaliyetAlanlariRecord : PrimaryKeyRecord
{

	public readonly static PFaaliyetAlanlariTable TableUtils = PFaaliyetAlanlariTable.Instance;

	// Constructors
 
	protected BasePFaaliyetAlanlariRecord() : base(TableUtils)
	{
	}

	protected BasePFaaliyetAlanlariRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFaaliyetAlanlari_.FaaliyetAlaniID field.
	/// </summary>
	public ColumnValue GetFaaliyetAlaniIDValue()
	{
		return this.GetValue(TableUtils.FaaliyetAlaniIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFaaliyetAlanlari_.FaaliyetAlaniID field.
	/// </summary>
	public Int32 GetFaaliyetAlaniIDFieldValue()
	{
		return this.GetValue(TableUtils.FaaliyetAlaniIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFaaliyetAlanlari_.FaaliyetAlanAdi field.
	/// </summary>
	public ColumnValue GetFaaliyetAlanAdiValue()
	{
		return this.GetValue(TableUtils.FaaliyetAlanAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFaaliyetAlanlari_.FaaliyetAlanAdi field.
	/// </summary>
	public string GetFaaliyetAlanAdiFieldValue()
	{
		return this.GetValue(TableUtils.FaaliyetAlanAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.FaaliyetAlanAdi field.
	/// </summary>
	public void SetFaaliyetAlanAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FaaliyetAlanAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.FaaliyetAlanAdi field.
	/// </summary>
	public void SetFaaliyetAlanAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FaaliyetAlanAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFaaliyetAlanlari_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFaaliyetAlanlari_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFaaliyetAlanlari_.FaaliyetAlaniID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.FaaliyetAlaniID field.
	/// </summary>
	public string FaaliyetAlaniIDDefault
	{
		get
		{
			return TableUtils.FaaliyetAlaniIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFaaliyetAlanlari_.FaaliyetAlanAdi field.
	/// </summary>
	public string FaaliyetAlanAdi
	{
		get
		{
			return this.GetValue(TableUtils.FaaliyetAlanAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FaaliyetAlanAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FaaliyetAlanAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FaaliyetAlanAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.FaaliyetAlanAdi field.
	/// </summary>
	public string FaaliyetAlanAdiDefault
	{
		get
		{
			return TableUtils.FaaliyetAlanAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFaaliyetAlanlari_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFaaliyetAlanlari_.AktifPasif field.
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
