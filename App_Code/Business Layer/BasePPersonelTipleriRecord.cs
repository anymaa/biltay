// This class is "generated" and will be overwritten.
// Your customizations should be made in PPersonelTipleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PPersonelTipleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PPersonelTipleriTable"></see> class.
/// </remarks>
/// <seealso cref="PPersonelTipleriTable"></seealso>
/// <seealso cref="PPersonelTipleriRecord"></seealso>
public class BasePPersonelTipleriRecord : PrimaryKeyRecord
{

	public readonly static PPersonelTipleriTable TableUtils = PPersonelTipleriTable.Instance;

	// Constructors
 
	protected BasePPersonelTipleriRecord() : base(TableUtils)
	{
	}

	protected BasePPersonelTipleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PPersonelTipleri_.PersoneTipID field.
	/// </summary>
	public ColumnValue GetPersoneTipIDValue()
	{
		return this.GetValue(TableUtils.PersoneTipIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PPersonelTipleri_.PersoneTipID field.
	/// </summary>
	public Int32 GetPersoneTipIDFieldValue()
	{
		return this.GetValue(TableUtils.PersoneTipIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PPersonelTipleri_.PersonelTipiAdi field.
	/// </summary>
	public ColumnValue GetPersonelTipiAdiValue()
	{
		return this.GetValue(TableUtils.PersonelTipiAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PPersonelTipleri_.PersonelTipiAdi field.
	/// </summary>
	public string GetPersonelTipiAdiFieldValue()
	{
		return this.GetValue(TableUtils.PersonelTipiAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.PersonelTipiAdi field.
	/// </summary>
	public void SetPersonelTipiAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PersonelTipiAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.PersonelTipiAdi field.
	/// </summary>
	public void SetPersonelTipiAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PersonelTipiAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PPersonelTipleri_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PPersonelTipleri_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PPersonelTipleri_.PersoneTipID field.
	/// </summary>
	public Int32 PersoneTipID
	{
		get
		{
			return this.GetValue(TableUtils.PersoneTipIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PersoneTipIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PersoneTipIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PersoneTipIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.PersoneTipID field.
	/// </summary>
	public string PersoneTipIDDefault
	{
		get
		{
			return TableUtils.PersoneTipIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PPersonelTipleri_.PersonelTipiAdi field.
	/// </summary>
	public string PersonelTipiAdi
	{
		get
		{
			return this.GetValue(TableUtils.PersonelTipiAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PersonelTipiAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PersonelTipiAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PersonelTipiAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.PersonelTipiAdi field.
	/// </summary>
	public string PersonelTipiAdiDefault
	{
		get
		{
			return TableUtils.PersonelTipiAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PPersonelTipleri_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PPersonelTipleri_.Aciklama field.
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
