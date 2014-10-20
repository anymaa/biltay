// This class is "generated" and will be overwritten.
// Your customizations should be made in IKYetkilerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IKYetkilerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IKYetkilerTable"></see> class.
/// </remarks>
/// <seealso cref="IKYetkilerTable"></seealso>
/// <seealso cref="IKYetkilerRecord"></seealso>
public class BaseIKYetkilerRecord : PrimaryKeyRecord
{

	public readonly static IKYetkilerTable TableUtils = IKYetkilerTable.Instance;

	// Constructors
 
	protected BaseIKYetkilerRecord() : base(TableUtils)
	{
	}

	protected BaseIKYetkilerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKYetkiler_.YetkiID field.
	/// </summary>
	public ColumnValue GetYetkiIDValue()
	{
		return this.GetValue(TableUtils.YetkiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKYetkiler_.YetkiID field.
	/// </summary>
	public Int32 GetYetkiIDFieldValue()
	{
		return this.GetValue(TableUtils.YetkiIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKYetkiler_.Yetki field.
	/// </summary>
	public ColumnValue GetYetkiValue()
	{
		return this.GetValue(TableUtils.YetkiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKYetkiler_.Yetki field.
	/// </summary>
	public string GetYetkiFieldValue()
	{
		return this.GetValue(TableUtils.YetkiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.Yetki field.
	/// </summary>
	public void SetYetkiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetkiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.Yetki field.
	/// </summary>
	public void SetYetkiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKYetkiler_.YetkiAciklamasi field.
	/// </summary>
	public ColumnValue GetYetkiAciklamasiValue()
	{
		return this.GetValue(TableUtils.YetkiAciklamasiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKYetkiler_.YetkiAciklamasi field.
	/// </summary>
	public string GetYetkiAciklamasiFieldValue()
	{
		return this.GetValue(TableUtils.YetkiAciklamasiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.YetkiAciklamasi field.
	/// </summary>
	public void SetYetkiAciklamasiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetkiAciklamasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.YetkiAciklamasi field.
	/// </summary>
	public void SetYetkiAciklamasiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetkiAciklamasiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKYetkiler_.YetkiID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.YetkiID field.
	/// </summary>
	public string YetkiIDDefault
	{
		get
		{
			return TableUtils.YetkiIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKYetkiler_.Yetki field.
	/// </summary>
	public string Yetki
	{
		get
		{
			return this.GetValue(TableUtils.YetkiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetkiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetkiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetkiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.Yetki field.
	/// </summary>
	public string YetkiDefault
	{
		get
		{
			return TableUtils.YetkiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKYetkiler_.YetkiAciklamasi field.
	/// </summary>
	public string YetkiAciklamasi
	{
		get
		{
			return this.GetValue(TableUtils.YetkiAciklamasiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetkiAciklamasiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetkiAciklamasiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetkiAciklamasiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKYetkiler_.YetkiAciklamasi field.
	/// </summary>
	public string YetkiAciklamasiDefault
	{
		get
		{
			return TableUtils.YetkiAciklamasiColumn.DefaultValue;
		}
	}


#endregion
}

}
