// This class is "generated" and will be overwritten.
// Your customizations should be made in PSehirlerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PSehirlerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PSehirlerTable"></see> class.
/// </remarks>
/// <seealso cref="PSehirlerTable"></seealso>
/// <seealso cref="PSehirlerRecord"></seealso>
public class BasePSehirlerRecord : PrimaryKeyRecord
{

	public readonly static PSehirlerTable TableUtils = PSehirlerTable.Instance;

	// Constructors
 
	protected BasePSehirlerRecord() : base(TableUtils)
	{
	}

	protected BasePSehirlerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.IlID field.
	/// </summary>
	public ColumnValue GetIlIDValue()
	{
		return this.GetValue(TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.IlID field.
	/// </summary>
	public Int32 GetIlIDFieldValue()
	{
		return this.GetValue(TableUtils.IlIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlID field.
	/// </summary>
	public void SetIlIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public ColumnValue GetIlTrefikKoduValue()
	{
		return this.GetValue(TableUtils.IlTrefikKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public Int32 GetIlTrefikKoduFieldValue()
	{
		return this.GetValue(TableUtils.IlTrefikKoduColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public void SetIlTrefikKoduFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlTrefikKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public void SetIlTrefikKoduFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlTrefikKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public void SetIlTrefikKoduFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlTrefikKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public void SetIlTrefikKoduFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlTrefikKoduColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public void SetIlTrefikKoduFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlTrefikKoduColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.SehirAdi field.
	/// </summary>
	public ColumnValue GetSehirAdiValue()
	{
		return this.GetValue(TableUtils.SehirAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.SehirAdi field.
	/// </summary>
	public string GetSehirAdiFieldValue()
	{
		return this.GetValue(TableUtils.SehirAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.SehirAdi field.
	/// </summary>
	public void SetSehirAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SehirAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.SehirAdi field.
	/// </summary>
	public void SetSehirAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SehirAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.Bolgesi field.
	/// </summary>
	public ColumnValue GetBolgesiValue()
	{
		return this.GetValue(TableUtils.BolgesiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.Bolgesi field.
	/// </summary>
	public string GetBolgesiFieldValue()
	{
		return this.GetValue(TableUtils.BolgesiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.Bolgesi field.
	/// </summary>
	public void SetBolgesiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BolgesiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.Bolgesi field.
	/// </summary>
	public void SetBolgesiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BolgesiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public ColumnValue GetUlkeIDValue()
	{
		return this.GetValue(TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public Int16 GetUlkeIDFieldValue()
	{
		return this.GetValue(TableUtils.UlkeIDColumn).ToInt16();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public void SetUlkeIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UlkeIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSehirler_.IlID field.
	/// </summary>
	public Int32 IlID
	{
		get
		{
			return this.GetValue(TableUtils.IlIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlID field.
	/// </summary>
	public string IlIDDefault
	{
		get
		{
			return TableUtils.IlIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public Int32 IlTrefikKodu
	{
		get
		{
			return this.GetValue(TableUtils.IlTrefikKoduColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlTrefikKoduColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlTrefikKoduSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlTrefikKoduColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.IlTrefikKodu field.
	/// </summary>
	public string IlTrefikKoduDefault
	{
		get
		{
			return TableUtils.IlTrefikKoduColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSehirler_.SehirAdi field.
	/// </summary>
	public string SehirAdi
	{
		get
		{
			return this.GetValue(TableUtils.SehirAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SehirAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SehirAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SehirAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.SehirAdi field.
	/// </summary>
	public string SehirAdiDefault
	{
		get
		{
			return TableUtils.SehirAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSehirler_.Bolgesi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.Bolgesi field.
	/// </summary>
	public string BolgesiDefault
	{
		get
		{
			return TableUtils.BolgesiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PSehirler_.UlkeID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PSehirler_.UlkeID field.
	/// </summary>
	public string UlkeIDDefault
	{
		get
		{
			return TableUtils.UlkeIDColumn.DefaultValue;
		}
	}


#endregion
}

}
