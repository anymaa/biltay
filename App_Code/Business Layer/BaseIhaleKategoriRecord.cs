// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleKategoriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IhaleKategoriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IhaleKategoriTable"></see> class.
/// </remarks>
/// <seealso cref="IhaleKategoriTable"></seealso>
/// <seealso cref="IhaleKategoriRecord"></seealso>
public class BaseIhaleKategoriRecord : PrimaryKeyRecord
{

	public readonly static IhaleKategoriTable TableUtils = IhaleKategoriTable.Instance;

	// Constructors
 
	protected BaseIhaleKategoriRecord() : base(TableUtils)
	{
	}

	protected BaseIhaleKategoriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleKategori_.IhaleKategoriID field.
	/// </summary>
	public ColumnValue GetIhaleKategoriIDValue()
	{
		return this.GetValue(TableUtils.IhaleKategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleKategori_.IhaleKategoriID field.
	/// </summary>
	public Int32 GetIhaleKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleKategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public ColumnValue GetKategoriIDValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public Int32 GetKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public ColumnValue GetIhaleIDValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public Int32 GetIhaleIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleKategori_.IhaleKategoriID field.
	/// </summary>
	public Int32 IhaleKategoriID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleKategoriIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleKategoriIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleKategoriIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleKategoriIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleKategoriID field.
	/// </summary>
	public string IhaleKategoriIDDefault
	{
		get
		{
			return TableUtils.IhaleKategoriIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public Int32 KategoriID
	{
		get
		{
			return this.GetValue(TableUtils.KategoriIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KategoriIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KategoriIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KategoriIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.KategoriID field.
	/// </summary>
	public string KategoriIDDefault
	{
		get
		{
			return TableUtils.KategoriIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleKategori_.IhaleID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleKategori_.IhaleID field.
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
