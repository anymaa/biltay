// This class is "generated" and will be overwritten.
// Your customizations should be made in PUlkelerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PUlkelerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PUlkelerTable"></see> class.
/// </remarks>
/// <seealso cref="PUlkelerTable"></seealso>
/// <seealso cref="PUlkelerRecord"></seealso>
public class BasePUlkelerRecord : PrimaryKeyRecord
{

	public readonly static PUlkelerTable TableUtils = PUlkelerTable.Instance;

	// Constructors
 
	protected BasePUlkelerRecord() : base(TableUtils)
	{
	}

	protected BasePUlkelerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public ColumnValue GetUlkeIDValue()
	{
		return this.GetValue(TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public Int16 GetUlkeIDFieldValue()
	{
		return this.GetValue(TableUtils.UlkeIDColumn).ToInt16();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.Ulkeadi field.
	/// </summary>
	public ColumnValue GetUlkeadiValue()
	{
		return this.GetValue(TableUtils.UlkeadiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.Ulkeadi field.
	/// </summary>
	public string GetUlkeadiFieldValue()
	{
		return this.GetValue(TableUtils.UlkeadiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.Ulkeadi field.
	/// </summary>
	public void SetUlkeadiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UlkeadiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.Ulkeadi field.
	/// </summary>
	public void SetUlkeadiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeadiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.Bolgesi field.
	/// </summary>
	public ColumnValue GetBolgesiValue()
	{
		return this.GetValue(TableUtils.BolgesiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.Bolgesi field.
	/// </summary>
	public string GetBolgesiFieldValue()
	{
		return this.GetValue(TableUtils.BolgesiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.Bolgesi field.
	/// </summary>
	public void SetBolgesiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BolgesiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.Bolgesi field.
	/// </summary>
	public void SetBolgesiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BolgesiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.TelefonKodu field.
	/// </summary>
	public ColumnValue GetTelefonKoduValue()
	{
		return this.GetValue(TableUtils.TelefonKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.TelefonKodu field.
	/// </summary>
	public string GetTelefonKoduFieldValue()
	{
		return this.GetValue(TableUtils.TelefonKoduColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.TelefonKodu field.
	/// </summary>
	public void SetTelefonKoduFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TelefonKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.TelefonKodu field.
	/// </summary>
	public void SetTelefonKoduFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TelefonKoduColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.ENUlkeAdi field.
	/// </summary>
	public ColumnValue GetENUlkeAdiValue()
	{
		return this.GetValue(TableUtils.ENUlkeAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PUlkeler_.ENUlkeAdi field.
	/// </summary>
	public string GetENUlkeAdiFieldValue()
	{
		return this.GetValue(TableUtils.ENUlkeAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.ENUlkeAdi field.
	/// </summary>
	public void SetENUlkeAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ENUlkeAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.ENUlkeAdi field.
	/// </summary>
	public void SetENUlkeAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ENUlkeAdiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public Int16 UlkeID
	{
		get
		{
			return this.GetValue(TableUtils.UlkeIDColumn).ToInt16();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UlkeIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UlkeIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UlkeIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.UlkeID field.
	/// </summary>
	public string UlkeIDDefault
	{
		get
		{
			return TableUtils.UlkeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PUlkeler_.Ulkeadi field.
	/// </summary>
	public string Ulkeadi
	{
		get
		{
			return this.GetValue(TableUtils.UlkeadiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UlkeadiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UlkeadiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UlkeadiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.Ulkeadi field.
	/// </summary>
	public string UlkeadiDefault
	{
		get
		{
			return TableUtils.UlkeadiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PUlkeler_.Bolgesi field.
	/// </summary>
	public string Bolgesi
	{
		get
		{
			return this.GetValue(TableUtils.BolgesiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BolgesiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BolgesiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BolgesiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.Bolgesi field.
	/// </summary>
	public string BolgesiDefault
	{
		get
		{
			return TableUtils.BolgesiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PUlkeler_.TelefonKodu field.
	/// </summary>
	public string TelefonKodu
	{
		get
		{
			return this.GetValue(TableUtils.TelefonKoduColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TelefonKoduColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TelefonKoduSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TelefonKoduColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.TelefonKodu field.
	/// </summary>
	public string TelefonKoduDefault
	{
		get
		{
			return TableUtils.TelefonKoduColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PUlkeler_.ENUlkeAdi field.
	/// </summary>
	public string ENUlkeAdi
	{
		get
		{
			return this.GetValue(TableUtils.ENUlkeAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ENUlkeAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ENUlkeAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ENUlkeAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PUlkeler_.ENUlkeAdi field.
	/// </summary>
	public string ENUlkeAdiDefault
	{
		get
		{
			return TableUtils.ENUlkeAdiColumn.DefaultValue;
		}
	}


#endregion
}

}
