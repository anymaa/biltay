// This class is "generated" and will be overwritten.
// Your customizations should be made in PFirmaReferanslarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="PFirmaReferanslarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PFirmaReferanslarTable"></see> class.
/// </remarks>
/// <seealso cref="PFirmaReferanslarTable"></seealso>
/// <seealso cref="PFirmaReferanslarRecord"></seealso>
public class BasePFirmaReferanslarRecord : PrimaryKeyRecord
{

	public readonly static PFirmaReferanslarTable TableUtils = PFirmaReferanslarTable.Instance;

	// Constructors
 
	protected BasePFirmaReferanslarRecord() : base(TableUtils)
	{
	}

	protected BasePFirmaReferanslarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.FirmaReferansID field.
	/// </summary>
	public ColumnValue GetFirmaReferansIDValue()
	{
		return this.GetValue(TableUtils.FirmaReferansIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.FirmaReferansID field.
	/// </summary>
	public Int32 GetFirmaReferansIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaReferansIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.ReferansFirmaAdi field.
	/// </summary>
	public ColumnValue GetReferansFirmaAdiValue()
	{
		return this.GetValue(TableUtils.ReferansFirmaAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.ReferansFirmaAdi field.
	/// </summary>
	public string GetReferansFirmaAdiFieldValue()
	{
		return this.GetValue(TableUtils.ReferansFirmaAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.ReferansFirmaAdi field.
	/// </summary>
	public void SetReferansFirmaAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ReferansFirmaAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.ReferansFirmaAdi field.
	/// </summary>
	public void SetReferansFirmaAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ReferansFirmaAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.Telefon field.
	/// </summary>
	public ColumnValue GetTelefonValue()
	{
		return this.GetValue(TableUtils.TelefonColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.Telefon field.
	/// </summary>
	public string GetTelefonFieldValue()
	{
		return this.GetValue(TableUtils.TelefonColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.Telefon field.
	/// </summary>
	public void SetTelefonFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TelefonColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.Telefon field.
	/// </summary>
	public void SetTelefonFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TelefonColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.Eposta field.
	/// </summary>
	public ColumnValue GetEpostaValue()
	{
		return this.GetValue(TableUtils.EpostaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.Eposta field.
	/// </summary>
	public string GetEpostaFieldValue()
	{
		return this.GetValue(TableUtils.EpostaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.Eposta field.
	/// </summary>
	public void SetEpostaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.EpostaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.Eposta field.
	/// </summary>
	public void SetEpostaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.EpostaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.KontakAdi field.
	/// </summary>
	public ColumnValue GetKontakAdiValue()
	{
		return this.GetValue(TableUtils.KontakAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.KontakAdi field.
	/// </summary>
	public string GetKontakAdiFieldValue()
	{
		return this.GetValue(TableUtils.KontakAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.KontakAdi field.
	/// </summary>
	public void SetKontakAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KontakAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.KontakAdi field.
	/// </summary>
	public void SetKontakAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KontakAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.KontakSoyadi field.
	/// </summary>
	public ColumnValue GetKontakSoyadiValue()
	{
		return this.GetValue(TableUtils.KontakSoyadiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PFirmaReferanslar_.KontakSoyadi field.
	/// </summary>
	public string GetKontakSoyadiFieldValue()
	{
		return this.GetValue(TableUtils.KontakSoyadiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.KontakSoyadi field.
	/// </summary>
	public void SetKontakSoyadiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KontakSoyadiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.KontakSoyadi field.
	/// </summary>
	public void SetKontakSoyadiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KontakSoyadiColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.FirmaReferansID field.
	/// </summary>
	public Int32 FirmaReferansID
	{
		get
		{
			return this.GetValue(TableUtils.FirmaReferansIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaReferansIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaReferansIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaReferansIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaReferansID field.
	/// </summary>
	public string FirmaReferansIDDefault
	{
		get
		{
			return TableUtils.FirmaReferansIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public Int32 FirmaID
	{
		get
		{
			return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.ReferansFirmaAdi field.
	/// </summary>
	public string ReferansFirmaAdi
	{
		get
		{
			return this.GetValue(TableUtils.ReferansFirmaAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ReferansFirmaAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ReferansFirmaAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ReferansFirmaAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.ReferansFirmaAdi field.
	/// </summary>
	public string ReferansFirmaAdiDefault
	{
		get
		{
			return TableUtils.ReferansFirmaAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.Telefon field.
	/// </summary>
	public string Telefon
	{
		get
		{
			return this.GetValue(TableUtils.TelefonColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TelefonColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TelefonSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TelefonColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.Telefon field.
	/// </summary>
	public string TelefonDefault
	{
		get
		{
			return TableUtils.TelefonColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.Eposta field.
	/// </summary>
	public string Eposta
	{
		get
		{
			return this.GetValue(TableUtils.EpostaColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.EpostaColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool EpostaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.EpostaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.Eposta field.
	/// </summary>
	public string EpostaDefault
	{
		get
		{
			return TableUtils.EpostaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.KontakAdi field.
	/// </summary>
	public string KontakAdi
	{
		get
		{
			return this.GetValue(TableUtils.KontakAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KontakAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KontakAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KontakAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.KontakAdi field.
	/// </summary>
	public string KontakAdiDefault
	{
		get
		{
			return TableUtils.KontakAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PFirmaReferanslar_.KontakSoyadi field.
	/// </summary>
	public string KontakSoyadi
	{
		get
		{
			return this.GetValue(TableUtils.KontakSoyadiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KontakSoyadiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KontakSoyadiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KontakSoyadiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PFirmaReferanslar_.KontakSoyadi field.
	/// </summary>
	public string KontakSoyadiDefault
	{
		get
		{
			return TableUtils.KontakSoyadiColumn.DefaultValue;
		}
	}


#endregion
}

}
