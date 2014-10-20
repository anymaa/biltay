// This class is "generated" and will be overwritten.
// Your customizations should be made in SysdiagramsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="SysdiagramsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SysdiagramsTable"></see> class.
/// </remarks>
/// <seealso cref="SysdiagramsTable"></seealso>
/// <seealso cref="SysdiagramsRecord"></seealso>
public class BaseSysdiagramsRecord : PrimaryKeyRecord
{

	public readonly static SysdiagramsTable TableUtils = SysdiagramsTable.Instance;

	// Constructors
 
	protected BaseSysdiagramsRecord() : base(TableUtils)
	{
	}

	protected BaseSysdiagramsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.name field.
	/// </summary>
	public ColumnValue GetnameValue()
	{
		return this.GetValue(TableUtils.nameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.name field.
	/// </summary>
	public string GetnameFieldValue()
	{
		return this.GetValue(TableUtils.nameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.name field.
	/// </summary>
	public void SetnameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.nameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.name field.
	/// </summary>
	public void SetnameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.nameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public ColumnValue Getprincipal_idValue()
	{
		return this.GetValue(TableUtils.principal_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public Int32 Getprincipal_idFieldValue()
	{
		return this.GetValue(TableUtils.principal_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public void Setprincipal_idFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.principal_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public void Setprincipal_idFieldValue(string val)
	{
		this.SetString(val, TableUtils.principal_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public void Setprincipal_idFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.principal_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public void Setprincipal_idFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.principal_idColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public void Setprincipal_idFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.principal_idColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.diagram_id field.
	/// </summary>
	public ColumnValue Getdiagram_idValue()
	{
		return this.GetValue(TableUtils.diagram_idColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.diagram_id field.
	/// </summary>
	public Int32 Getdiagram_idFieldValue()
	{
		return this.GetValue(TableUtils.diagram_idColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public ColumnValue GetversionValue()
	{
		return this.GetValue(TableUtils.versionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public Int32 GetversionFieldValue()
	{
		return this.GetValue(TableUtils.versionColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public void SetversionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.versionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public void SetversionFieldValue(string val)
	{
		this.SetString(val, TableUtils.versionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public void SetversionFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.versionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public void SetversionFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.versionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public void SetversionFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.versionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public ColumnValue GetdefinitionValue()
	{
		return this.GetValue(TableUtils.definitionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public byte[] GetdefinitionFieldValue()
	{
		return this.GetValue(TableUtils.definitionColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public void SetdefinitionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.definitionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public void SetdefinitionFieldValue(string val)
	{
		this.SetString(val, TableUtils.definitionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public void SetdefinitionFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.definitionColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sysdiagrams_.name field.
	/// </summary>
	public string name
	{
		get
		{
			return this.GetValue(TableUtils.nameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.nameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool nameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.nameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.name field.
	/// </summary>
	public string nameDefault
	{
		get
		{
			return TableUtils.nameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public Int32 principal_id
	{
		get
		{
			return this.GetValue(TableUtils.principal_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.principal_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool principal_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.principal_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.principal_id field.
	/// </summary>
	public string principal_idDefault
	{
		get
		{
			return TableUtils.principal_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sysdiagrams_.diagram_id field.
	/// </summary>
	public Int32 diagram_id
	{
		get
		{
			return this.GetValue(TableUtils.diagram_idColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.diagram_idColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool diagram_idSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.diagram_idColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.diagram_id field.
	/// </summary>
	public string diagram_idDefault
	{
		get
		{
			return TableUtils.diagram_idColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public Int32 version
	{
		get
		{
			return this.GetValue(TableUtils.versionColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.versionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool versionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.versionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.version field.
	/// </summary>
	public string versionDefault
	{
		get
		{
			return TableUtils.versionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public byte[] definition
	{
		get
		{
			return this.GetValue(TableUtils.definitionColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.definitionColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool definitionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.definitionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Sysdiagrams_.definition field.
	/// </summary>
	public string definitionDefault
	{
		get
		{
			return TableUtils.definitionColumn.DefaultValue;
		}
	}


#endregion
}

}
