// This class is "generated" and will be overwritten.
// Your customizations should be made in PIlcelerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PIlcelerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PIlcelerTable"></see> class.
/// </remarks>
/// <seealso cref="PIlcelerTable"></seealso>
/// <seealso cref="PIlcelerRecord"></seealso>
public class BasePIlcelerRecord : PrimaryKeyRecord
{

	public readonly static PIlcelerTable TableUtils = PIlcelerTable.Instance;

	// Constructors
 
	protected BasePIlcelerRecord() : base(TableUtils)
	{
	}

	protected BasePIlcelerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public ColumnValue GetIlceIDValue()
	{
		return this.GetValue(TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public Int32 GetIlceIDFieldValue()
	{
		return this.GetValue(TableUtils.IlceIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlceIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public void SetIlceIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlceIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PIlceler_.IlID field.
	/// </summary>
	public ColumnValue GetIlIDValue()
	{
		return this.GetValue(TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PIlceler_.IlID field.
	/// </summary>
	public Int32 GetIlIDFieldValue()
	{
		return this.GetValue(TableUtils.IlIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PIlceler_.Ad field.
	/// </summary>
	public ColumnValue GetAdValue()
	{
		return this.GetValue(TableUtils.AdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PIlceler_.Ad field.
	/// </summary>
	public string GetAdFieldValue()
	{
		return this.GetValue(TableUtils.AdColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.Ad field.
	/// </summary>
	public void SetAdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.Ad field.
	/// </summary>
	public void SetAdFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public Int32 IlceID
	{
		get
		{
			return this.GetValue(TableUtils.IlceIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlceIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlceIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlceIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlceID field.
	/// </summary>
	public string IlceIDDefault
	{
		get
		{
			return TableUtils.IlceIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PIlceler_.IlID field.
	/// </summary>
	public Int32 IlID
	{
		get
		{
			return this.GetValue(TableUtils.IlIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.IlID field.
	/// </summary>
	public string IlIDDefault
	{
		get
		{
			return TableUtils.IlIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PIlceler_.Ad field.
	/// </summary>
	public string Ad
	{
		get
		{
			return this.GetValue(TableUtils.AdColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PIlceler_.Ad field.
	/// </summary>
	public string AdDefault
	{
		get
		{
			return TableUtils.AdColumn.DefaultValue;
		}
	}


#endregion
}

}
