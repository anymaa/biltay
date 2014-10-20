// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaPersonelAltYapisiRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFirmaPersonelAltYapisiRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFirmaPersonelAltYapisiTable"></see> class.
/// </remarks>
/// <seealso cref="PFirmaPersonelAltYapisiTable"></seealso>
/// <seealso cref="PFirmaPersonelAltYapisiRecord"></seealso>
public class BasePFirmaPersonelAltYapisiRecord : PrimaryKeyRecord
{

	public readonly static PFirmaPersonelAltYapisiTable TableUtils = PFirmaPersonelAltYapisiTable.Instance;

	// Constructors
 
	protected BasePFirmaPersonelAltYapisiRecord() : base(TableUtils)
	{
	}

	protected BasePFirmaPersonelAltYapisiRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersoneAltYapiID field.
	/// </summary>
	public ColumnValue GetPersoneAltYapiIDValue()
	{
		return this.GetValue(TableUtils.PersoneAltYapiIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersoneAltYapiID field.
	/// </summary>
	public Int32 GetPersoneAltYapiIDFieldValue()
	{
		return this.GetValue(TableUtils.PersoneAltYapiIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public ColumnValue GetPersonelTipIDValue()
	{
		return this.GetValue(TableUtils.PersonelTipIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public Int32 GetPersonelTipIDFieldValue()
	{
		return this.GetValue(TableUtils.PersonelTipIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public void SetPersonelTipIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PersonelTipIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public void SetPersonelTipIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PersonelTipIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public void SetPersonelTipIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelTipIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public void SetPersonelTipIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelTipIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public void SetPersonelTipIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelTipIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public ColumnValue GetPersonelSayisiValue()
	{
		return this.GetValue(TableUtils.PersonelSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public Int32 GetPersonelSayisiFieldValue()
	{
		return this.GetValue(TableUtils.PersonelSayisiColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public void SetPersonelSayisiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PersonelSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public void SetPersonelSayisiFieldValue(string val)
	{
		this.SetString(val, TableUtils.PersonelSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public void SetPersonelSayisiFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public void SetPersonelSayisiFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelSayisiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public void SetPersonelSayisiFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelSayisiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersoneAltYapiID field.
	/// </summary>
	public Int32 PersoneAltYapiID
	{
		get
		{
			return this.GetValue(TableUtils.PersoneAltYapiIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PersoneAltYapiIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PersoneAltYapiIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PersoneAltYapiIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersoneAltYapiID field.
	/// </summary>
	public string PersoneAltYapiIDDefault
	{
		get
		{
			return TableUtils.PersoneAltYapiIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public Int32 PersonelTipID
	{
		get
		{
			return this.GetValue(TableUtils.PersonelTipIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PersonelTipIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PersonelTipIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PersonelTipIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelTipID field.
	/// </summary>
	public string PersonelTipIDDefault
	{
		get
		{
			return TableUtils.PersonelTipIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public Int32 PersonelSayisi
	{
		get
		{
			return this.GetValue(TableUtils.PersonelSayisiColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PersonelSayisiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PersonelSayisiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PersonelSayisiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaPersonelAltYapisi_.PersonelSayisi field.
	/// </summary>
	public string PersonelSayisiDefault
	{
		get
		{
			return TableUtils.PersonelSayisiColumn.DefaultValue;
		}
	}


#endregion
}

}
