// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaKategoriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFirmaKategoriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFirmaKategoriTable"></see> class.
/// </remarks>
/// <seealso cref="PFirmaKategoriTable"></seealso>
/// <seealso cref="PFirmaKategoriRecord"></seealso>
public class BasePFirmaKategoriRecord : PrimaryKeyRecord
{

	public readonly static PFirmaKategoriTable TableUtils = PFirmaKategoriTable.Instance;

	// Constructors
 
	protected BasePFirmaKategoriRecord() : base(TableUtils)
	{
	}

	protected BasePFirmaKategoriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaKategori_.FirmaKategoriID field.
	/// </summary>
	public ColumnValue GetFirmaKategoriIDValue()
	{
		return this.GetValue(TableUtils.FirmaKategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaKategori_.FirmaKategoriID field.
	/// </summary>
	public Int32 GetFirmaKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaKategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public ColumnValue GetKategoriIDValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public Int32 GetKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public void SetKategoriIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaKategori_.FirmaKategoriID field.
	/// </summary>
	public Int32 FirmaKategoriID
	{
		get
		{
			return this.GetValue(TableUtils.FirmaKategoriIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaKategoriIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaKategoriIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaKategoriIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaKategoriID field.
	/// </summary>
	public string FirmaKategoriIDDefault
	{
		get
		{
			return TableUtils.FirmaKategoriIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaKategori_.KategoriID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.KategoriID field.
	/// </summary>
	public string KategoriIDDefault
	{
		get
		{
			return TableUtils.KategoriIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaKategori_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaKategori_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}


#endregion
}

}
