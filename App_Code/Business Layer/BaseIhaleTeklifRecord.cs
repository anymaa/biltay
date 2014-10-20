// This class is "generated" and will be overwritten.
// Your customizations should be made in IhaleTeklifRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="IhaleTeklifRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="IhaleTeklifTable"></see> class.
/// </remarks>
/// <seealso cref="IhaleTeklifTable"></seealso>
/// <seealso cref="IhaleTeklifRecord"></seealso>
public class BaseIhaleTeklifRecord : PrimaryKeyRecord
{

	public readonly static IhaleTeklifTable TableUtils = IhaleTeklifTable.Instance;

	// Constructors
 
	protected BaseIhaleTeklifRecord() : base(TableUtils)
	{
	}

	protected BaseIhaleTeklifRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.IhaleTeklifID field.
	/// </summary>
	public ColumnValue GetIhaleTeklifIDValue()
	{
		return this.GetValue(TableUtils.IhaleTeklifIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.IhaleTeklifID field.
	/// </summary>
	public Int32 GetIhaleTeklifIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleTeklifIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public ColumnValue GetFirmaTeklifValue()
	{
		return this.GetValue(TableUtils.FirmaTeklifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public Int32 GetFirmaTeklifFieldValue()
	{
		return this.GetValue(TableUtils.FirmaTeklifColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public void SetFirmaTeklifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaTeklifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public void SetFirmaTeklifFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaTeklifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public void SetFirmaTeklifFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaTeklifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public void SetFirmaTeklifFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaTeklifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public void SetFirmaTeklifFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaTeklifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.AciklamaEN field.
	/// </summary>
	public ColumnValue GetAciklamaENValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.AciklamaEN field.
	/// </summary>
	public string GetAciklamaENFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaENColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaENColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AciklamaEN field.
	/// </summary>
	public void SetAciklamaENFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaENColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public ColumnValue GetDosyaValue()
	{
		return this.GetValue(TableUtils.DosyaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public byte[] GetDosyaFieldValue()
	{
		return this.GetValue(TableUtils.DosyaColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public void SetDosyaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DosyaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public void SetDosyaFieldValue(string val)
	{
		this.SetString(val, TableUtils.DosyaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public void SetDosyaFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DosyaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public ColumnValue GetKontaktIDValue()
	{
		return this.GetValue(TableUtils.KontaktIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public Int32 GetKontaktIDFieldValue()
	{
		return this.GetValue(TableUtils.KontaktIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public void SetKontaktIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KontaktIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public void SetKontaktIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.KontaktIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public void SetKontaktIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KontaktIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public void SetKontaktIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KontaktIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public void SetKontaktIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KontaktIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public ColumnValue GetTeklifTarihiValue()
	{
		return this.GetValue(TableUtils.TeklifTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public DateTime GetTeklifTarihiFieldValue()
	{
		return this.GetValue(TableUtils.TeklifTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public void SetTeklifTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeklifTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public void SetTeklifTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.TeklifTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public void SetTeklifTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeklifTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public ColumnValue GetTerminTarihiValue()
	{
		return this.GetValue(TableUtils.TerminTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public DateTime GetTerminTarihiFieldValue()
	{
		return this.GetValue(TableUtils.TerminTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public void SetTerminTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TerminTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public void SetTerminTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.TerminTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public void SetTerminTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TerminTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public ColumnValue GetParaBirimIDValue()
	{
		return this.GetValue(TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public Byte GetParaBirimIDFieldValue()
	{
		return this.GetValue(TableUtils.ParaBirimIDColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public void SetParaBirimIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ParaBirimIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.IhaleTeklifID field.
	/// </summary>
	public Int32 IhaleTeklifID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleTeklifIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleTeklifIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleTeklifIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleTeklifIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.IhaleTeklifID field.
	/// </summary>
	public string IhaleTeklifIDDefault
	{
		get
		{
			return TableUtils.IhaleTeklifIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public Int32 FirmaTeklif
	{
		get
		{
			return this.GetValue(TableUtils.FirmaTeklifColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirmaTeklifColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirmaTeklifSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirmaTeklifColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.FirmaTeklif field.
	/// </summary>
	public string FirmaTeklifDefault
	{
		get
		{
			return TableUtils.FirmaTeklifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Aciklama field.
	/// </summary>
	public string AciklamaDefault
	{
		get
		{
			return TableUtils.AciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.AciklamaEN field.
	/// </summary>
	public string AciklamaEN
	{
		get
		{
			return this.GetValue(TableUtils.AciklamaENColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AciklamaENColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AciklamaENSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AciklamaENColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AciklamaEN field.
	/// </summary>
	public string AciklamaENDefault
	{
		get
		{
			return TableUtils.AciklamaENColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public byte[] Dosya
	{
		get
		{
			return this.GetValue(TableUtils.DosyaColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DosyaColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DosyaSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DosyaColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.Dosya field.
	/// </summary>
	public string DosyaDefault
	{
		get
		{
			return TableUtils.DosyaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public Int32 KontaktID
	{
		get
		{
			return this.GetValue(TableUtils.KontaktIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KontaktIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KontaktIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KontaktIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.KontaktID field.
	/// </summary>
	public string KontaktIDDefault
	{
		get
		{
			return TableUtils.KontaktIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public DateTime TeklifTarihi
	{
		get
		{
			return this.GetValue(TableUtils.TeklifTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeklifTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeklifTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeklifTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TeklifTarihi field.
	/// </summary>
	public string TeklifTarihiDefault
	{
		get
		{
			return TableUtils.TeklifTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public DateTime TerminTarihi
	{
		get
		{
			return this.GetValue(TableUtils.TerminTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TerminTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TerminTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TerminTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.TerminTarihi field.
	/// </summary>
	public string TerminTarihiDefault
	{
		get
		{
			return TableUtils.TerminTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public Byte ParaBirimID
	{
		get
		{
			return this.GetValue(TableUtils.ParaBirimIDColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ParaBirimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ParaBirimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ParaBirimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.ParaBirimID field.
	/// </summary>
	public string ParaBirimIDDefault
	{
		get
		{
			return TableUtils.ParaBirimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public bool AktifPasif
	{
		get
		{
			return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.AktifPasifColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AktifPasifSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AktifPasifColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's IhaleTeklif_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}


#endregion
}

}
