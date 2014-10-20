// This class is "generated" and will be overwritten.
// Your customizations should be made in PYProjeKategorileriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PYProjeKategorileriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PYProjeKategorileriTable"></see> class.
/// </remarks>
/// <seealso cref="PYProjeKategorileriTable"></seealso>
/// <seealso cref="PYProjeKategorileriRecord"></seealso>
public class BasePYProjeKategorileriRecord : PrimaryKeyRecord
{

	public readonly static PYProjeKategorileriTable TableUtils = PYProjeKategorileriTable.Instance;

	// Constructors
 
	protected BasePYProjeKategorileriRecord() : base(TableUtils)
	{
	}

	protected BasePYProjeKategorileriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeKategorileri_.ProjeKategoriID field.
	/// </summary>
	public ColumnValue GetProjeKategoriIDValue()
	{
		return this.GetValue(TableUtils.ProjeKategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeKategorileri_.ProjeKategoriID field.
	/// </summary>
	public Int32 GetProjeKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.ProjeKategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public ColumnValue GetProjeIDValue()
	{
		return this.GetValue(TableUtils.ProjeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public Int32 GetProjeIDFieldValue()
	{
		return this.GetValue(TableUtils.ProjeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public void SetProjeIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ProjeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public void SetProjeIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ProjeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public void SetProjeIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public void SetProjeIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public void SetProjeIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ProjeIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public ColumnValue GetKategoriIDValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public Int32 GetKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeKategorileri_.ProjeKategoriID field.
	/// </summary>
	public Int32 ProjeKategoriID
	{
		get
		{
			return this.GetValue(TableUtils.ProjeKategoriIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeKategoriIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeKategoriIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeKategoriIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeKategoriID field.
	/// </summary>
	public string ProjeKategoriIDDefault
	{
		get
		{
			return TableUtils.ProjeKategoriIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public Int32 ProjeID
	{
		get
		{
			return this.GetValue(TableUtils.ProjeIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ProjeIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ProjeIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ProjeIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.ProjeID field.
	/// </summary>
	public string ProjeIDDefault
	{
		get
		{
			return TableUtils.ProjeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYProjeKategorileri_.KategoriID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYProjeKategorileri_.KategoriID field.
	/// </summary>
	public string KategoriIDDefault
	{
		get
		{
			return TableUtils.KategoriIDColumn.DefaultValue;
		}
	}


#endregion
}

}
