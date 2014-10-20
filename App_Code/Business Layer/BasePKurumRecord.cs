// This class is "generated" and will be overwritten.
// Your customizations should be made in PKurumRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PKurumRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PKurumTable"></see> class.
/// </remarks>
/// <seealso cref="PKurumTable"></seealso>
/// <seealso cref="PKurumRecord"></seealso>
public class BasePKurumRecord : PrimaryKeyRecord
{

	public readonly static PKurumTable TableUtils = PKurumTable.Instance;

	// Constructors
 
	protected BasePKurumRecord() : base(TableUtils)
	{
	}

	protected BasePKurumRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumID field.
	/// </summary>
	public ColumnValue GetKurumIDValue()
	{
		return this.GetValue(TableUtils.KurumIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumID field.
	/// </summary>
	public Int32 GetKurumIDFieldValue()
	{
		return this.GetValue(TableUtils.KurumIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumAdres field.
	/// </summary>
	public ColumnValue GetKurumAdresValue()
	{
		return this.GetValue(TableUtils.KurumAdresColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumAdres field.
	/// </summary>
	public string GetKurumAdresFieldValue()
	{
		return this.GetValue(TableUtils.KurumAdresColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumAdres field.
	/// </summary>
	public void SetKurumAdresFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KurumAdresColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumAdres field.
	/// </summary>
	public void SetKurumAdresFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KurumAdresColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumEnlem field.
	/// </summary>
	public ColumnValue GetKurumEnlemValue()
	{
		return this.GetValue(TableUtils.KurumEnlemColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumEnlem field.
	/// </summary>
	public string GetKurumEnlemFieldValue()
	{
		return this.GetValue(TableUtils.KurumEnlemColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumEnlem field.
	/// </summary>
	public void SetKurumEnlemFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KurumEnlemColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumEnlem field.
	/// </summary>
	public void SetKurumEnlemFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KurumEnlemColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumBoylam field.
	/// </summary>
	public ColumnValue GetKurumBoylamValue()
	{
		return this.GetValue(TableUtils.KurumBoylamColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PKurum_.KurumBoylam field.
	/// </summary>
	public string GetKurumBoylamFieldValue()
	{
		return this.GetValue(TableUtils.KurumBoylamColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumBoylam field.
	/// </summary>
	public void SetKurumBoylamFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KurumBoylamColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumBoylam field.
	/// </summary>
	public void SetKurumBoylamFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KurumBoylamColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PKurum_.KurumID field.
	/// </summary>
	public Int32 KurumID
	{
		get
		{
			return this.GetValue(TableUtils.KurumIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KurumIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KurumIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KurumIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumID field.
	/// </summary>
	public string KurumIDDefault
	{
		get
		{
			return TableUtils.KurumIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PKurum_.KurumAdres field.
	/// </summary>
	public string KurumAdres
	{
		get
		{
			return this.GetValue(TableUtils.KurumAdresColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KurumAdresColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KurumAdresSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KurumAdresColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumAdres field.
	/// </summary>
	public string KurumAdresDefault
	{
		get
		{
			return TableUtils.KurumAdresColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PKurum_.KurumEnlem field.
	/// </summary>
	public string KurumEnlem
	{
		get
		{
			return this.GetValue(TableUtils.KurumEnlemColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KurumEnlemColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KurumEnlemSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KurumEnlemColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumEnlem field.
	/// </summary>
	public string KurumEnlemDefault
	{
		get
		{
			return TableUtils.KurumEnlemColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PKurum_.KurumBoylam field.
	/// </summary>
	public string KurumBoylam
	{
		get
		{
			return this.GetValue(TableUtils.KurumBoylamColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KurumBoylamColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KurumBoylamSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KurumBoylamColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PKurum_.KurumBoylam field.
	/// </summary>
	public string KurumBoylamDefault
	{
		get
		{
			return TableUtils.KurumBoylamColumn.DefaultValue;
		}
	}


#endregion
}

}
