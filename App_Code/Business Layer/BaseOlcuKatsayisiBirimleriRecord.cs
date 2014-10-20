// This class is "generated" and will be overwritten.
// Your customizations should be made in OlcuKatsayisiBirimleriRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="OlcuKatsayisiBirimleriRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="OlcuKatsayisiBirimleriTable"></see> class.
/// </remarks>
/// <seealso cref="OlcuKatsayisiBirimleriTable"></seealso>
/// <seealso cref="OlcuKatsayisiBirimleriRecord"></seealso>
public class BaseOlcuKatsayisiBirimleriRecord : PrimaryKeyRecord
{

	public readonly static OlcuKatsayisiBirimleriTable TableUtils = OlcuKatsayisiBirimleriTable.Instance;

	// Constructors
 
	protected BaseOlcuKatsayisiBirimleriRecord() : base(TableUtils)
	{
	}

	protected BaseOlcuKatsayisiBirimleriRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimID field.
	/// </summary>
	public ColumnValue GetOlcuBirimIDValue()
	{
		return this.GetValue(TableUtils.OlcuBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimID field.
	/// </summary>
	public Byte GetOlcuBirimIDFieldValue()
	{
		return this.GetValue(TableUtils.OlcuBirimIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdi field.
	/// </summary>
	public ColumnValue GetOlcuBirimAdiValue()
	{
		return this.GetValue(TableUtils.OlcuBirimAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdi field.
	/// </summary>
	public string GetOlcuBirimAdiFieldValue()
	{
		return this.GetValue(TableUtils.OlcuBirimAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdi field.
	/// </summary>
	public void SetOlcuBirimAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlcuBirimAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdi field.
	/// </summary>
	public void SetOlcuBirimAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlcuBirimAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN field.
	/// </summary>
	public ColumnValue GetOlcuBirimAdiENValue()
	{
		return this.GetValue(TableUtils.OlcuBirimAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN field.
	/// </summary>
	public string GetOlcuBirimAdiENFieldValue()
	{
		return this.GetValue(TableUtils.OlcuBirimAdiENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN field.
	/// </summary>
	public void SetOlcuBirimAdiENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlcuBirimAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN field.
	/// </summary>
	public void SetOlcuBirimAdiENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlcuBirimAdiENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.BirimTuru field.
	/// </summary>
	public ColumnValue GetBirimTuruValue()
	{
		return this.GetValue(TableUtils.BirimTuruColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.BirimTuru field.
	/// </summary>
	public string GetBirimTuruFieldValue()
	{
		return this.GetValue(TableUtils.BirimTuruColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.BirimTuru field.
	/// </summary>
	public void SetBirimTuruFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BirimTuruColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.BirimTuru field.
	/// </summary>
	public void SetBirimTuruFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BirimTuruColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.TR field.
	/// </summary>
	public ColumnValue GetTRValue()
	{
		return this.GetValue(TableUtils.TRColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.TR field.
	/// </summary>
	public string GetTRFieldValue()
	{
		return this.GetValue(TableUtils.TRColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.TR field.
	/// </summary>
	public void SetTRFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TRColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.TR field.
	/// </summary>
	public void SetTRFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TRColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.EN field.
	/// </summary>
	public ColumnValue GetENValue()
	{
		return this.GetValue(TableUtils.ENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.EN field.
	/// </summary>
	public string GetENFieldValue()
	{
		return this.GetValue(TableUtils.ENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.EN field.
	/// </summary>
	public void SetENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.EN field.
	/// </summary>
	public void SetENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ENColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimID field.
	/// </summary>
	public Byte OlcuBirimID
	{
		get
		{
			return this.GetValue(TableUtils.OlcuBirimIDColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlcuBirimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlcuBirimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlcuBirimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimID field.
	/// </summary>
	public string OlcuBirimIDDefault
	{
		get
		{
			return TableUtils.OlcuBirimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdi field.
	/// </summary>
	public string OlcuBirimAdi
	{
		get
		{
			return this.GetValue(TableUtils.OlcuBirimAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlcuBirimAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlcuBirimAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlcuBirimAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdi field.
	/// </summary>
	public string OlcuBirimAdiDefault
	{
		get
		{
			return TableUtils.OlcuBirimAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN field.
	/// </summary>
	public string OlcuBirimAdiEN
	{
		get
		{
			return this.GetValue(TableUtils.OlcuBirimAdiENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlcuBirimAdiENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlcuBirimAdiENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlcuBirimAdiENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.OlcuBirimAdiEN field.
	/// </summary>
	public string OlcuBirimAdiENDefault
	{
		get
		{
			return TableUtils.OlcuBirimAdiENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.BirimTuru field.
	/// </summary>
	public string BirimTuru
	{
		get
		{
			return this.GetValue(TableUtils.BirimTuruColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BirimTuruColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BirimTuruSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BirimTuruColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.BirimTuru field.
	/// </summary>
	public string BirimTuruDefault
	{
		get
		{
			return TableUtils.BirimTuruColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.TR field.
	/// </summary>
	public string TR
	{
		get
		{
			return this.GetValue(TableUtils.TRColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TRColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TRSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TRColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.TR field.
	/// </summary>
	public string TRDefault
	{
		get
		{
			return TableUtils.TRColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OlcuKatsayisiBirimleri_.EN field.
	/// </summary>
	public string EN
	{
		get
		{
			return this.GetValue(TableUtils.ENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OlcuKatsayisiBirimleri_.EN field.
	/// </summary>
	public string ENDefault
	{
		get
		{
			return TableUtils.ENColumn.DefaultValue;
		}
	}


#endregion
}

}
