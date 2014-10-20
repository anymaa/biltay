// This class is "generated" and will be overwritten.
// Your customizations should be made in PYetenekTurleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PYetenekTurleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PYetenekTurleriTable"></see> class.
/// </remarks>
/// <seealso cref="PYetenekTurleriTable"></seealso>
/// <seealso cref="PYetenekTurleriRecord"></seealso>
public class BasePYetenekTurleriRecord : PrimaryKeyRecord
{

	public readonly static PYetenekTurleriTable TableUtils = PYetenekTurleriTable.Instance;

	// Constructors
 
	protected BasePYetenekTurleriRecord() : base(TableUtils)
	{
	}

	protected BasePYetenekTurleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekTurleri_.YetenekTurID field.
	/// </summary>
	public ColumnValue GetYetenekTurIDValue()
	{
		return this.GetValue(TableUtils.YetenekTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekTurleri_.YetenekTurID field.
	/// </summary>
	public Int32 GetYetenekTurIDFieldValue()
	{
		return this.GetValue(TableUtils.YetenekTurIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekTurleri_.YeteneginTuru field.
	/// </summary>
	public ColumnValue GetYeteneginTuruValue()
	{
		return this.GetValue(TableUtils.YeteneginTuruColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekTurleri_.YeteneginTuru field.
	/// </summary>
	public string GetYeteneginTuruFieldValue()
	{
		return this.GetValue(TableUtils.YeteneginTuruColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekTurleri_.YeteneginTuru field.
	/// </summary>
	public void SetYeteneginTuruFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YeteneginTuruColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekTurleri_.YeteneginTuru field.
	/// </summary>
	public void SetYeteneginTuruFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YeteneginTuruColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYetenekTurleri_.YetenekTurID field.
	/// </summary>
	public Int32 YetenekTurID
	{
		get
		{
			return this.GetValue(TableUtils.YetenekTurIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetenekTurIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetenekTurIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetenekTurIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekTurleri_.YetenekTurID field.
	/// </summary>
	public string YetenekTurIDDefault
	{
		get
		{
			return TableUtils.YetenekTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYetenekTurleri_.YeteneginTuru field.
	/// </summary>
	public string YeteneginTuru
	{
		get
		{
			return this.GetValue(TableUtils.YeteneginTuruColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YeteneginTuruColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YeteneginTuruSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YeteneginTuruColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekTurleri_.YeteneginTuru field.
	/// </summary>
	public string YeteneginTuruDefault
	{
		get
		{
			return TableUtils.YeteneginTuruColumn.DefaultValue;
		}
	}


#endregion
}

}
