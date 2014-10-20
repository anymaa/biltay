// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleFirmaRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IhaleFirmaRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IhaleFirmaTable"></see> class.
/// </remarks>
/// <seealso cref="IhaleFirmaTable"></seealso>
/// <seealso cref="IhaleFirmaRecord"></seealso>
public class BaseIhaleFirmaRecord : PrimaryKeyRecord
{

	public readonly static IhaleFirmaTable TableUtils = IhaleFirmaTable.Instance;

	// Constructors
 
	protected BaseIhaleFirmaRecord() : base(TableUtils)
	{
	}

	protected BaseIhaleFirmaRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleFirma_.IhaleFirmaID field.
	/// </summary>
	public ColumnValue GetIhaleFirmaIDValue()
	{
		return this.GetValue(TableUtils.IhaleFirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleFirma_.IhaleFirmaID field.
	/// </summary>
	public Int32 GetIhaleFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleFirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public ColumnValue GetIhaleIDValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public Int32 GetIhaleIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleFirma_.IhaleFirmaID field.
	/// </summary>
	public Int32 IhaleFirmaID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleFirmaIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleFirmaIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleFirmaIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleFirmaIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleFirmaID field.
	/// </summary>
	public string IhaleFirmaIDDefault
	{
		get
		{
			return TableUtils.IhaleFirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleFirma_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public Int32 IhaleID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleFirma_.IhaleID field.
	/// </summary>
	public string IhaleIDDefault
	{
		get
		{
			return TableUtils.IhaleIDColumn.DefaultValue;
		}
	}


#endregion
}

}
