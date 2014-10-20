// This class is "generated" and will be overwritten.
// Your customizations should be made in IKUnvanlarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IKUnvanlarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IKUnvanlarTable"></see> class.
/// </remarks>
/// <seealso cref="IKUnvanlarTable"></seealso>
/// <seealso cref="IKUnvanlarRecord"></seealso>
public class BaseIKUnvanlarRecord : PrimaryKeyRecord
{

	public readonly static IKUnvanlarTable TableUtils = IKUnvanlarTable.Instance;

	// Constructors
 
	protected BaseIKUnvanlarRecord() : base(TableUtils)
	{
	}

	protected BaseIKUnvanlarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKUnvanlar_.UnvanID field.
	/// </summary>
	public ColumnValue GetUnvanIDValue()
	{
		return this.GetValue(TableUtils.UnvanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKUnvanlar_.UnvanID field.
	/// </summary>
	public Int32 GetUnvanIDFieldValue()
	{
		return this.GetValue(TableUtils.UnvanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKUnvanlar_.UnvanAdi field.
	/// </summary>
	public ColumnValue GetUnvanAdiValue()
	{
		return this.GetValue(TableUtils.UnvanAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKUnvanlar_.UnvanAdi field.
	/// </summary>
	public string GetUnvanAdiFieldValue()
	{
		return this.GetValue(TableUtils.UnvanAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.UnvanAdi field.
	/// </summary>
	public void SetUnvanAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UnvanAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.UnvanAdi field.
	/// </summary>
	public void SetUnvanAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UnvanAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKUnvanlar_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IKUnvanlar_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKUnvanlar_.UnvanID field.
	/// </summary>
	public Int32 UnvanID
	{
		get
		{
			return this.GetValue(TableUtils.UnvanIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UnvanIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UnvanIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UnvanIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.UnvanID field.
	/// </summary>
	public string UnvanIDDefault
	{
		get
		{
			return TableUtils.UnvanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKUnvanlar_.UnvanAdi field.
	/// </summary>
	public string UnvanAdi
	{
		get
		{
			return this.GetValue(TableUtils.UnvanAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UnvanAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UnvanAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UnvanAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.UnvanAdi field.
	/// </summary>
	public string UnvanAdiDefault
	{
		get
		{
			return TableUtils.UnvanAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IKUnvanlar_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IKUnvanlar_.Aciklama field.
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
