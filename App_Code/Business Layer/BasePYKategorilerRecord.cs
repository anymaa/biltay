// This class is "generated" and will be overwritten.
// Your customizations should be made in PYKategorilerRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PYKategorilerRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PYKategorilerTable"></see> class.
/// </remarks>
/// <seealso cref="PYKategorilerTable"></seealso>
/// <seealso cref="PYKategorilerRecord"></seealso>
public class BasePYKategorilerRecord : PrimaryKeyRecord
{

	public readonly static PYKategorilerTable TableUtils = PYKategorilerTable.Instance;

	// Constructors
 
	protected BasePYKategorilerRecord() : base(TableUtils)
	{
	}

	protected BasePYKategorilerRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.KategoriID field.
	/// </summary>
	public ColumnValue GetKategoriIDValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.KategoriID field.
	/// </summary>
	public Int32 GetKategoriIDFieldValue()
	{
		return this.GetValue(TableUtils.KategoriIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.KategoriAdi field.
	/// </summary>
	public ColumnValue GetKategoriAdiValue()
	{
		return this.GetValue(TableUtils.KategoriAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.KategoriAdi field.
	/// </summary>
	public string GetKategoriAdiFieldValue()
	{
		return this.GetValue(TableUtils.KategoriAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriAdi field.
	/// </summary>
	public void SetKategoriAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KategoriAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriAdi field.
	/// </summary>
	public void SetKategoriAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.KategoriAdiEN field.
	/// </summary>
	public ColumnValue GetKategoriAdiENValue()
	{
		return this.GetValue(TableUtils.KategoriAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.KategoriAdiEN field.
	/// </summary>
	public string GetKategoriAdiENFieldValue()
	{
		return this.GetValue(TableUtils.KategoriAdiENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriAdiEN field.
	/// </summary>
	public void SetKategoriAdiENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KategoriAdiENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriAdiEN field.
	/// </summary>
	public void SetKategoriAdiENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KategoriAdiENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.KategoriID field.
	/// </summary>
	public Int32 KategoriID
	{
		get
		{
			return this.GetValue(TableUtils.KategoriIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KategoriIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KategoriIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KategoriIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriID field.
	/// </summary>
	public string KategoriIDDefault
	{
		get
		{
			return TableUtils.KategoriIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.KategoriAdi field.
	/// </summary>
	public string KategoriAdi
	{
		get
		{
			return this.GetValue(TableUtils.KategoriAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KategoriAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KategoriAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KategoriAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriAdi field.
	/// </summary>
	public string KategoriAdiDefault
	{
		get
		{
			return TableUtils.KategoriAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.KategoriAdiEN field.
	/// </summary>
	public string KategoriAdiEN
	{
		get
		{
			return this.GetValue(TableUtils.KategoriAdiENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KategoriAdiENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KategoriAdiENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KategoriAdiENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.KategoriAdiEN field.
	/// </summary>
	public string KategoriAdiENDefault
	{
		get
		{
			return TableUtils.KategoriAdiENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public Int32 OlusturanID
	{
		get
		{
			return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlusturanIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlusturanIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlusturanIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public DateTime OlusturmaTarihi
	{
		get
		{
			return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlusturmaTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlusturmaTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public Int32 DuzenleyenID
	{
		get
		{
			return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DuzenleyenIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DuzenleyenIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime DuzenlenmeTarihi
	{
		get
		{
			return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DuzenlenmeTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PYKategoriler_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}


#endregion
}

}
