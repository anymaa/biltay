// This class is "generated" and will be overwritten.
// Your customizations should be made in PHesapTurleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PHesapTurleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PHesapTurleriTable"></see> class.
/// </remarks>
/// <seealso cref="PHesapTurleriTable"></seealso>
/// <seealso cref="PHesapTurleriRecord"></seealso>
public class BasePHesapTurleriRecord : PrimaryKeyRecord
{

	public readonly static PHesapTurleriTable TableUtils = PHesapTurleriTable.Instance;

	// Constructors
 
	protected BasePHesapTurleriRecord() : base(TableUtils)
	{
	}

	protected BasePHesapTurleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PHesapTurleri_.HesapTurID field.
	/// </summary>
	public ColumnValue GetHesapTurIDValue()
	{
		return this.GetValue(TableUtils.HesapTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PHesapTurleri_.HesapTurID field.
	/// </summary>
	public string GetHesapTurIDFieldValue()
	{
		return this.GetValue(TableUtils.HesapTurIDColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.HesapTurID field.
	/// </summary>
	public void SetHesapTurIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HesapTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.HesapTurID field.
	/// </summary>
	public void SetHesapTurIDFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HesapTurIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PHesapTurleri_.HesapTuru field.
	/// </summary>
	public ColumnValue GetHesapTuruValue()
	{
		return this.GetValue(TableUtils.HesapTuruColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PHesapTurleri_.HesapTuru field.
	/// </summary>
	public string GetHesapTuruFieldValue()
	{
		return this.GetValue(TableUtils.HesapTuruColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.HesapTuru field.
	/// </summary>
	public void SetHesapTuruFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.HesapTuruColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.HesapTuru field.
	/// </summary>
	public void SetHesapTuruFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.HesapTuruColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PHesapTurleri_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PHesapTurleri_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PHesapTurleri_.HesapTurID field.
	/// </summary>
	public string HesapTurID
	{
		get
		{
			return this.GetValue(TableUtils.HesapTurIDColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HesapTurIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HesapTurIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HesapTurIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.HesapTurID field.
	/// </summary>
	public string HesapTurIDDefault
	{
		get
		{
			return TableUtils.HesapTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PHesapTurleri_.HesapTuru field.
	/// </summary>
	public string HesapTuru
	{
		get
		{
			return this.GetValue(TableUtils.HesapTuruColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.HesapTuruColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool HesapTuruSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.HesapTuruColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.HesapTuru field.
	/// </summary>
	public string HesapTuruDefault
	{
		get
		{
			return TableUtils.HesapTuruColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PHesapTurleri_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PHesapTurleri_.Aciklama field.
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
