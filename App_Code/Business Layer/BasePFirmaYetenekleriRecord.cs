// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaYetenekleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFirmaYetenekleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFirmaYetenekleriTable"></see> class.
/// </remarks>
/// <seealso cref="PFirmaYetenekleriTable"></seealso>
/// <seealso cref="PFirmaYetenekleriRecord"></seealso>
public class BasePFirmaYetenekleriRecord : PrimaryKeyRecord
{

	public readonly static PFirmaYetenekleriTable TableUtils = PFirmaYetenekleriTable.Instance;

	// Constructors
 
	protected BasePFirmaYetenekleriRecord() : base(TableUtils)
	{
	}

	protected BasePFirmaYetenekleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaYetenekleri_.FirmaYetenekID field.
	/// </summary>
	public ColumnValue GetFirmaYetenekIDValue()
	{
		return this.GetValue(TableUtils.FirmaYetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaYetenekleri_.FirmaYetenekID field.
	/// </summary>
	public Int32 GetFirmaYetenekIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaYetenekIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public ColumnValue GetYetenekIDValue()
	{
		return this.GetValue(TableUtils.YetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public Int32 GetYetenekIDFieldValue()
	{
		return this.GetValue(TableUtils.YetenekIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public void SetYetenekIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public void SetYetenekIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.YetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public void SetYetenekIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public void SetYetenekIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public void SetYetenekIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetenekIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaYetenekleri_.FirmaYetenekID field.
	/// </summary>
	public Int32 FirmaYetenekID
	{
		get
		{
			return this.GetValue(TableUtils.FirmaYetenekIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaYetenekIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaYetenekIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaYetenekIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaYetenekID field.
	/// </summary>
	public string FirmaYetenekIDDefault
	{
		get
		{
			return TableUtils.FirmaYetenekIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaYetenekleri_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public Int32 YetenekID
	{
		get
		{
			return this.GetValue(TableUtils.YetenekIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetenekIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetenekIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetenekIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaYetenekleri_.YetenekID field.
	/// </summary>
	public string YetenekIDDefault
	{
		get
		{
			return TableUtils.YetenekIDColumn.DefaultValue;
		}
	}


#endregion
}

}
