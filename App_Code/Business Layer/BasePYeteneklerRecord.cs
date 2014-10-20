// This class is "generated" and will be overwritten.
// Your customizations should be made in PYeteneklerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PYeteneklerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PYeteneklerTable"></see> class.
/// </remarks>
/// <seealso cref="PYeteneklerTable"></seealso>
/// <seealso cref="PYeteneklerRecord"></seealso>
public class BasePYeteneklerRecord : PrimaryKeyRecord
{

	public readonly static PYeteneklerTable TableUtils = PYeteneklerTable.Instance;

	// Constructors
 
	protected BasePYeteneklerRecord() : base(TableUtils)
	{
	}

	protected BasePYeteneklerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.YetenekID field.
	/// </summary>
	public ColumnValue GetYetenekIDValue()
	{
		return this.GetValue(TableUtils.YetenekIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.YetenekID field.
	/// </summary>
	public Int32 GetYetenekIDFieldValue()
	{
		return this.GetValue(TableUtils.YetenekIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.YeteneginAdi field.
	/// </summary>
	public ColumnValue GetYeteneginAdiValue()
	{
		return this.GetValue(TableUtils.YeteneginAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.YeteneginAdi field.
	/// </summary>
	public string GetYeteneginAdiFieldValue()
	{
		return this.GetValue(TableUtils.YeteneginAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YeteneginAdi field.
	/// </summary>
	public void SetYeteneginAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YeteneginAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YeteneginAdi field.
	/// </summary>
	public void SetYeteneginAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YeteneginAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public ColumnValue GetYetenekTurIDValue()
	{
		return this.GetValue(TableUtils.YetenekTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public Int32 GetYetenekTurIDFieldValue()
	{
		return this.GetValue(TableUtils.YetenekTurIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public void SetYetenekTurIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YetenekTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public void SetYetenekTurIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.YetenekTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public void SetYetenekTurIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetenekTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public void SetYetenekTurIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetenekTurIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public void SetYetenekTurIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YetenekTurIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYetenekler_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYetenekler_.YetenekID field.
	/// </summary>
	public Int32 YetenekID
	{
		get
		{
			return this.GetValue(TableUtils.YetenekIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetenekIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetenekIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetenekIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekID field.
	/// </summary>
	public string YetenekIDDefault
	{
		get
		{
			return TableUtils.YetenekIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYetenekler_.YeteneginAdi field.
	/// </summary>
	public string YeteneginAdi
	{
		get
		{
			return this.GetValue(TableUtils.YeteneginAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YeteneginAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YeteneginAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YeteneginAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YeteneginAdi field.
	/// </summary>
	public string YeteneginAdiDefault
	{
		get
		{
			return TableUtils.YeteneginAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public Int32 YetenekTurID
	{
		get
		{
			return this.GetValue(TableUtils.YetenekTurIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YetenekTurIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YetenekTurIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YetenekTurIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.YetenekTurID field.
	/// </summary>
	public string YetenekTurIDDefault
	{
		get
		{
			return TableUtils.YetenekTurIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYetenekler_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PYetenekler_.Aciklama field.
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
