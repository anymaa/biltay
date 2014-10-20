// This class is "generated" and will be overwritten.
// Your customizations should be made in PSertifikalarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PSertifikalarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PSertifikalarTable"></see> class.
/// </remarks>
/// <seealso cref="PSertifikalarTable"></seealso>
/// <seealso cref="PSertifikalarRecord"></seealso>
public class BasePSertifikalarRecord : PrimaryKeyRecord
{

	public readonly static PSertifikalarTable TableUtils = PSertifikalarTable.Instance;

	// Constructors
 
	protected BasePSertifikalarRecord() : base(TableUtils)
	{
	}

	protected BasePSertifikalarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSertifikalar_.SertifikaID field.
	/// </summary>
	public ColumnValue GetSertifikaIDValue()
	{
		return this.GetValue(TableUtils.SertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSertifikalar_.SertifikaID field.
	/// </summary>
	public Int32 GetSertifikaIDFieldValue()
	{
		return this.GetValue(TableUtils.SertifikaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSertifikalar_.SertifikaAdi field.
	/// </summary>
	public ColumnValue GetSertifikaAdiValue()
	{
		return this.GetValue(TableUtils.SertifikaAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSertifikalar_.SertifikaAdi field.
	/// </summary>
	public string GetSertifikaAdiFieldValue()
	{
		return this.GetValue(TableUtils.SertifikaAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.SertifikaAdi field.
	/// </summary>
	public void SetSertifikaAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SertifikaAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.SertifikaAdi field.
	/// </summary>
	public void SetSertifikaAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SertifikaAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSertifikalar_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSertifikalar_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSertifikalar_.SertifikaID field.
	/// </summary>
	public Int32 SertifikaID
	{
		get
		{
			return this.GetValue(TableUtils.SertifikaIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SertifikaIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SertifikaIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SertifikaIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.SertifikaID field.
	/// </summary>
	public string SertifikaIDDefault
	{
		get
		{
			return TableUtils.SertifikaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSertifikalar_.SertifikaAdi field.
	/// </summary>
	public string SertifikaAdi
	{
		get
		{
			return this.GetValue(TableUtils.SertifikaAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SertifikaAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SertifikaAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SertifikaAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.SertifikaAdi field.
	/// </summary>
	public string SertifikaAdiDefault
	{
		get
		{
			return TableUtils.SertifikaAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSertifikalar_.Aciklama field.
	/// </summary>
	public string Aciklama
	{
		get
		{
			return this.GetValue(TableUtils.AciklamaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AciklamaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AciklamaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AciklamaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSertifikalar_.Aciklama field.
	/// </summary>
	public string AciklamaDefault
	{
		get
		{
			return TableUtils.AciklamaColumn.DefaultValue;
		}
	}


#endregion
}

}
