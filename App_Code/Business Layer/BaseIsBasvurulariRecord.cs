// This class is "generated" and will be overwritten.
// Your customizations should be made in IsBasvurulariRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IsBasvurulariRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IsBasvurulariTable"></see> class.
/// </remarks>
/// <seealso cref="IsBasvurulariTable"></seealso>
/// <seealso cref="IsBasvurulariRecord"></seealso>
public class BaseIsBasvurulariRecord : PrimaryKeyRecord
{

	public readonly static IsBasvurulariTable TableUtils = IsBasvurulariTable.Instance;

	// Constructors
 
	protected BaseIsBasvurulariRecord() : base(TableUtils)
	{
	}

	protected BaseIsBasvurulariRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.IsBasvuruID field.
	/// </summary>
	public ColumnValue GetIsBasvuruIDValue()
	{
		return this.GetValue(TableUtils.IsBasvuruIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.IsBasvuruID field.
	/// </summary>
	public Int32 GetIsBasvuruIDFieldValue()
	{
		return this.GetValue(TableUtils.IsBasvuruIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public ColumnValue GetIlanIDValue()
	{
		return this.GetValue(TableUtils.IlanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public Int32 GetIlanIDFieldValue()
	{
		return this.GetValue(TableUtils.IlanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public void SetIlanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public void SetIlanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public void SetIlanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public void SetIlanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public void SetIlanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public ColumnValue GetAdayIDValue()
	{
		return this.GetValue(TableUtils.AdayIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public Int32 GetAdayIDFieldValue()
	{
		return this.GetValue(TableUtils.AdayIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public void SetAdayIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AdayIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public void SetAdayIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.AdayIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public void SetAdayIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdayIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public void SetAdayIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdayIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public void SetAdayIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AdayIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public ColumnValue GetBasvuruTarihiValue()
	{
		return this.GetValue(TableUtils.BasvuruTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public DateTime GetBasvuruTarihiFieldValue()
	{
		return this.GetValue(TableUtils.BasvuruTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public void SetBasvuruTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BasvuruTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public void SetBasvuruTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.BasvuruTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public void SetBasvuruTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BasvuruTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.BasvuruDegerlendirme field.
	/// </summary>
	public ColumnValue GetBasvuruDegerlendirmeValue()
	{
		return this.GetValue(TableUtils.BasvuruDegerlendirmeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.BasvuruDegerlendirme field.
	/// </summary>
	public string GetBasvuruDegerlendirmeFieldValue()
	{
		return this.GetValue(TableUtils.BasvuruDegerlendirmeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruDegerlendirme field.
	/// </summary>
	public void SetBasvuruDegerlendirmeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BasvuruDegerlendirmeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruDegerlendirme field.
	/// </summary>
	public void SetBasvuruDegerlendirmeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BasvuruDegerlendirmeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public ColumnValue GetDegerlendirmeTarihiValue()
	{
		return this.GetValue(TableUtils.DegerlendirmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public DateTime GetDegerlendirmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DegerlendirmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public void SetDegerlendirmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DegerlendirmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public void SetDegerlendirmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DegerlendirmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public void SetDegerlendirmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DegerlendirmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.DegerlendirmeNotu field.
	/// </summary>
	public ColumnValue GetDegerlendirmeNotuValue()
	{
		return this.GetValue(TableUtils.DegerlendirmeNotuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IsBasvurulari_.DegerlendirmeNotu field.
	/// </summary>
	public string GetDegerlendirmeNotuFieldValue()
	{
		return this.GetValue(TableUtils.DegerlendirmeNotuColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeNotu field.
	/// </summary>
	public void SetDegerlendirmeNotuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DegerlendirmeNotuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeNotu field.
	/// </summary>
	public void SetDegerlendirmeNotuFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DegerlendirmeNotuColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.IsBasvuruID field.
	/// </summary>
	public Int32 IsBasvuruID
	{
		get
		{
			return this.GetValue(TableUtils.IsBasvuruIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsBasvuruIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsBasvuruIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsBasvuruIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IsBasvuruID field.
	/// </summary>
	public string IsBasvuruIDDefault
	{
		get
		{
			return TableUtils.IsBasvuruIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public Int32 IlanID
	{
		get
		{
			return this.GetValue(TableUtils.IlanIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlanIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlanIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlanIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.IlanID field.
	/// </summary>
	public string IlanIDDefault
	{
		get
		{
			return TableUtils.IlanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public Int32 AdayID
	{
		get
		{
			return this.GetValue(TableUtils.AdayIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AdayIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AdayIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AdayIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.AdayID field.
	/// </summary>
	public string AdayIDDefault
	{
		get
		{
			return TableUtils.AdayIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public DateTime BasvuruTarihi
	{
		get
		{
			return this.GetValue(TableUtils.BasvuruTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BasvuruTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BasvuruTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BasvuruTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruTarihi field.
	/// </summary>
	public string BasvuruTarihiDefault
	{
		get
		{
			return TableUtils.BasvuruTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.BasvuruDegerlendirme field.
	/// </summary>
	public string BasvuruDegerlendirme
	{
		get
		{
			return this.GetValue(TableUtils.BasvuruDegerlendirmeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BasvuruDegerlendirmeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BasvuruDegerlendirmeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BasvuruDegerlendirmeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.BasvuruDegerlendirme field.
	/// </summary>
	public string BasvuruDegerlendirmeDefault
	{
		get
		{
			return TableUtils.BasvuruDegerlendirmeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public DateTime DegerlendirmeTarihi
	{
		get
		{
			return this.GetValue(TableUtils.DegerlendirmeTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DegerlendirmeTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DegerlendirmeTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DegerlendirmeTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeTarihi field.
	/// </summary>
	public string DegerlendirmeTarihiDefault
	{
		get
		{
			return TableUtils.DegerlendirmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IsBasvurulari_.DegerlendirmeNotu field.
	/// </summary>
	public string DegerlendirmeNotu
	{
		get
		{
			return this.GetValue(TableUtils.DegerlendirmeNotuColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DegerlendirmeNotuColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DegerlendirmeNotuSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DegerlendirmeNotuColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IsBasvurulari_.DegerlendirmeNotu field.
	/// </summary>
	public string DegerlendirmeNotuDefault
	{
		get
		{
			return TableUtils.DegerlendirmeNotuColumn.DefaultValue;
		}
	}


#endregion
}

}
