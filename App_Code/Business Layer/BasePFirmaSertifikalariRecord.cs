// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaSertifikalariRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFirmaSertifikalariRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFirmaSertifikalariTable"></see> class.
/// </remarks>
/// <seealso cref="PFirmaSertifikalariTable"></seealso>
/// <seealso cref="PFirmaSertifikalariRecord"></seealso>
public class BasePFirmaSertifikalariRecord : PrimaryKeyRecord
{

	public readonly static PFirmaSertifikalariTable TableUtils = PFirmaSertifikalariTable.Instance;

	// Constructors
 
	protected BasePFirmaSertifikalariRecord() : base(TableUtils)
	{
	}

	protected BasePFirmaSertifikalariRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaSertifikalari_.FirmaSertifikaID field.
	/// </summary>
	public ColumnValue GetFirmaSertifikaIDValue()
	{
		return this.GetValue(TableUtils.FirmaSertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaSertifikalari_.FirmaSertifikaID field.
	/// </summary>
	public Int32 GetFirmaSertifikaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaSertifikaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public ColumnValue GetSertifikaIDValue()
	{
		return this.GetValue(TableUtils.SertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public Int32 GetSertifikaIDFieldValue()
	{
		return this.GetValue(TableUtils.SertifikaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public void SetSertifikaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public void SetSertifikaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.SertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public void SetSertifikaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public void SetSertifikaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SertifikaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public void SetSertifikaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SertifikaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaSertifikalari_.FirmaSertifikaID field.
	/// </summary>
	public Int32 FirmaSertifikaID
	{
		get
		{
			return this.GetValue(TableUtils.FirmaSertifikaIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaSertifikaIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaSertifikaIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaSertifikaIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaSertifikaID field.
	/// </summary>
	public string FirmaSertifikaIDDefault
	{
		get
		{
			return TableUtils.FirmaSertifikaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaSertifikalari_.SertifikaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.SertifikaID field.
	/// </summary>
	public string SertifikaIDDefault
	{
		get
		{
			return TableUtils.SertifikaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaSertifikalari_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaSertifikalari_.FirmaID field.
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
