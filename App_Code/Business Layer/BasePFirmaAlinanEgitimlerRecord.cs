// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaAlinanEgitimlerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFirmaAlinanEgitimlerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFirmaAlinanEgitimlerTable"></see> class.
/// </remarks>
/// <seealso cref="PFirmaAlinanEgitimlerTable"></seealso>
/// <seealso cref="PFirmaAlinanEgitimlerRecord"></seealso>
public class BasePFirmaAlinanEgitimlerRecord : PrimaryKeyRecord
{

	public readonly static PFirmaAlinanEgitimlerTable TableUtils = PFirmaAlinanEgitimlerTable.Instance;

	// Constructors
 
	protected BasePFirmaAlinanEgitimlerRecord() : base(TableUtils)
	{
	}

	protected BasePFirmaAlinanEgitimlerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimID field.
	/// </summary>
	public ColumnValue GetEgitimIDValue()
	{
		return this.GetValue(TableUtils.EgitimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimID field.
	/// </summary>
	public Int32 GetEgitimIDFieldValue()
	{
		return this.GetValue(TableUtils.EgitimIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimAdi field.
	/// </summary>
	public ColumnValue GetEgitimAdiValue()
	{
		return this.GetValue(TableUtils.EgitimAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimAdi field.
	/// </summary>
	public string GetEgitimAdiFieldValue()
	{
		return this.GetValue(TableUtils.EgitimAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimAdi field.
	/// </summary>
	public void SetEgitimAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitimAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimAdi field.
	/// </summary>
	public void SetEgitimAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimFirmasi field.
	/// </summary>
	public ColumnValue GetEgitimFirmasiValue()
	{
		return this.GetValue(TableUtils.EgitimFirmasiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimFirmasi field.
	/// </summary>
	public string GetEgitimFirmasiFieldValue()
	{
		return this.GetValue(TableUtils.EgitimFirmasiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimFirmasi field.
	/// </summary>
	public void SetEgitimFirmasiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EgitimFirmasiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimFirmasi field.
	/// </summary>
	public void SetEgitimFirmasiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EgitimFirmasiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public ColumnValue GetBaslamaTarihiValue()
	{
		return this.GetValue(TableUtils.BaslamaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public DateTime GetBaslamaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.BaslamaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public void SetBaslamaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BaslamaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public void SetBaslamaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.BaslamaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public void SetBaslamaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaslamaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public ColumnValue GetBitisTarihiValue()
	{
		return this.GetValue(TableUtils.BitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public DateTime GetBitisTarihiFieldValue()
	{
		return this.GetValue(TableUtils.BitisTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public void SetBitisTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public void SetBitisTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.BitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public void SetBitisTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BitisTarihiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimID field.
	/// </summary>
	public Int32 EgitimID
	{
		get
		{
			return this.GetValue(TableUtils.EgitimIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimID field.
	/// </summary>
	public string EgitimIDDefault
	{
		get
		{
			return TableUtils.EgitimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimAdi field.
	/// </summary>
	public string EgitimAdi
	{
		get
		{
			return this.GetValue(TableUtils.EgitimAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitimAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitimAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitimAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimAdi field.
	/// </summary>
	public string EgitimAdiDefault
	{
		get
		{
			return TableUtils.EgitimAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaAlinanEgitimler_.EgitimFirmasi field.
	/// </summary>
	public string EgitimFirmasi
	{
		get
		{
			return this.GetValue(TableUtils.EgitimFirmasiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EgitimFirmasiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EgitimFirmasiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EgitimFirmasiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.EgitimFirmasi field.
	/// </summary>
	public string EgitimFirmasiDefault
	{
		get
		{
			return TableUtils.EgitimFirmasiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public DateTime BaslamaTarihi
	{
		get
		{
			return this.GetValue(TableUtils.BaslamaTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BaslamaTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BaslamaTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BaslamaTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BaslamaTarihi field.
	/// </summary>
	public string BaslamaTarihiDefault
	{
		get
		{
			return TableUtils.BaslamaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public DateTime BitisTarihi
	{
		get
		{
			return this.GetValue(TableUtils.BitisTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BitisTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BitisTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BitisTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaAlinanEgitimler_.BitisTarihi field.
	/// </summary>
	public string BitisTarihiDefault
	{
		get
		{
			return TableUtils.BitisTarihiColumn.DefaultValue;
		}
	}


#endregion
}

}
