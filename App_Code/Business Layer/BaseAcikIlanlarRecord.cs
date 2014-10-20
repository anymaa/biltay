// This class is "generated" and will be overwritten.
// Your customizations should be made in AcikIlanlarRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="AcikIlanlarRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AcikIlanlarTable"></see> class.
/// </remarks>
/// <seealso cref="AcikIlanlarTable"></seealso>
/// <seealso cref="AcikIlanlarRecord"></seealso>
public class BaseAcikIlanlarRecord : PrimaryKeyRecord
{

	public readonly static AcikIlanlarTable TableUtils = AcikIlanlarTable.Instance;

	// Constructors
 
	protected BaseAcikIlanlarRecord() : base(TableUtils)
	{
	}

	protected BaseAcikIlanlarRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanID field.
	/// </summary>
	public ColumnValue GetIlanIDValue()
	{
		return this.GetValue(TableUtils.IlanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanID field.
	/// </summary>
	public Int32 GetIlanIDFieldValue()
	{
		return this.GetValue(TableUtils.IlanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanNo field.
	/// </summary>
	public ColumnValue GetIlanNoValue()
	{
		return this.GetValue(TableUtils.IlanNoColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanNo field.
	/// </summary>
	public string GetIlanNoFieldValue()
	{
		return this.GetValue(TableUtils.IlanNoColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanNo field.
	/// </summary>
	public void SetIlanNoFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlanNoColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanNo field.
	/// </summary>
	public void SetIlanNoFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanNoColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.PozisyonAdi field.
	/// </summary>
	public ColumnValue GetPozisyonAdiValue()
	{
		return this.GetValue(TableUtils.PozisyonAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.PozisyonAdi field.
	/// </summary>
	public string GetPozisyonAdiFieldValue()
	{
		return this.GetValue(TableUtils.PozisyonAdiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.PozisyonAdi field.
	/// </summary>
	public void SetPozisyonAdiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PozisyonAdiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.PozisyonAdi field.
	/// </summary>
	public void SetPozisyonAdiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PozisyonAdiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IsTanimi field.
	/// </summary>
	public ColumnValue GetIsTanimiValue()
	{
		return this.GetValue(TableUtils.IsTanimiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IsTanimi field.
	/// </summary>
	public string GetIsTanimiFieldValue()
	{
		return this.GetValue(TableUtils.IsTanimiColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IsTanimi field.
	/// </summary>
	public void SetIsTanimiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsTanimiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IsTanimi field.
	/// </summary>
	public void SetIsTanimiFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsTanimiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.ArananNitelikler field.
	/// </summary>
	public ColumnValue GetArananNiteliklerValue()
	{
		return this.GetValue(TableUtils.ArananNiteliklerColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.ArananNitelikler field.
	/// </summary>
	public string GetArananNiteliklerFieldValue()
	{
		return this.GetValue(TableUtils.ArananNiteliklerColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.ArananNitelikler field.
	/// </summary>
	public void SetArananNiteliklerFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ArananNiteliklerColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.ArananNitelikler field.
	/// </summary>
	public void SetArananNiteliklerFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ArananNiteliklerColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IsAlani field.
	/// </summary>
	public ColumnValue GetIsAlaniValue()
	{
		return this.GetValue(TableUtils.IsAlaniColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IsAlani field.
	/// </summary>
	public string GetIsAlaniFieldValue()
	{
		return this.GetValue(TableUtils.IsAlaniColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IsAlani field.
	/// </summary>
	public void SetIsAlaniFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IsAlaniColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IsAlani field.
	/// </summary>
	public void SetIsAlaniFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IsAlaniColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.OrganizasyondakiYeri field.
	/// </summary>
	public ColumnValue GetOrganizasyondakiYeriValue()
	{
		return this.GetValue(TableUtils.OrganizasyondakiYeriColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.OrganizasyondakiYeri field.
	/// </summary>
	public string GetOrganizasyondakiYeriFieldValue()
	{
		return this.GetValue(TableUtils.OrganizasyondakiYeriColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OrganizasyondakiYeri field.
	/// </summary>
	public void SetOrganizasyondakiYeriFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OrganizasyondakiYeriColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OrganizasyondakiYeri field.
	/// </summary>
	public void SetOrganizasyondakiYeriFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrganizasyondakiYeriColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.CalismaSekli field.
	/// </summary>
	public ColumnValue GetCalismaSekliValue()
	{
		return this.GetValue(TableUtils.CalismaSekliColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.CalismaSekli field.
	/// </summary>
	public string GetCalismaSekliFieldValue()
	{
		return this.GetValue(TableUtils.CalismaSekliColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.CalismaSekli field.
	/// </summary>
	public void SetCalismaSekliFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CalismaSekliColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.CalismaSekli field.
	/// </summary>
	public void SetCalismaSekliFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CalismaSekliColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public ColumnValue GetIlanBaslangicTarihiValue()
	{
		return this.GetValue(TableUtils.IlanBaslangicTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public DateTime GetIlanBaslangicTarihiFieldValue()
	{
		return this.GetValue(TableUtils.IlanBaslangicTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public void SetIlanBaslangicTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlanBaslangicTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public void SetIlanBaslangicTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlanBaslangicTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public void SetIlanBaslangicTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanBaslangicTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public ColumnValue GetIlanBitisTarihiValue()
	{
		return this.GetValue(TableUtils.IlanBitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public DateTime GetIlanBitisTarihiFieldValue()
	{
		return this.GetValue(TableUtils.IlanBitisTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public void SetIlanBitisTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlanBitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public void SetIlanBitisTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlanBitisTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public void SetIlanBitisTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanBitisTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public ColumnValue GetIlanDurumuValue()
	{
		return this.GetValue(TableUtils.IlanDurumuColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public bool GetIlanDurumuFieldValue()
	{
		return this.GetValue(TableUtils.IlanDurumuColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public void SetIlanDurumuFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IlanDurumuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public void SetIlanDurumuFieldValue(string val)
	{
		this.SetString(val, TableUtils.IlanDurumuColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public void SetIlanDurumuFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IlanDurumuColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AcikIlanlar_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IlanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanID field.
	/// </summary>
	public string IlanIDDefault
	{
		get
		{
			return TableUtils.IlanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IlanNo field.
	/// </summary>
	public string IlanNo
	{
		get
		{
			return this.GetValue(TableUtils.IlanNoColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlanNoColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlanNoSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlanNoColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanNo field.
	/// </summary>
	public string IlanNoDefault
	{
		get
		{
			return TableUtils.IlanNoColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.PozisyonAdi field.
	/// </summary>
	public string PozisyonAdi
	{
		get
		{
			return this.GetValue(TableUtils.PozisyonAdiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PozisyonAdiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PozisyonAdiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PozisyonAdiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.PozisyonAdi field.
	/// </summary>
	public string PozisyonAdiDefault
	{
		get
		{
			return TableUtils.PozisyonAdiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IsTanimi field.
	/// </summary>
	public string IsTanimi
	{
		get
		{
			return this.GetValue(TableUtils.IsTanimiColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsTanimiColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsTanimiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsTanimiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IsTanimi field.
	/// </summary>
	public string IsTanimiDefault
	{
		get
		{
			return TableUtils.IsTanimiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.ArananNitelikler field.
	/// </summary>
	public string ArananNitelikler
	{
		get
		{
			return this.GetValue(TableUtils.ArananNiteliklerColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ArananNiteliklerColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ArananNiteliklerSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ArananNiteliklerColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.ArananNitelikler field.
	/// </summary>
	public string ArananNiteliklerDefault
	{
		get
		{
			return TableUtils.ArananNiteliklerColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IsAlani field.
	/// </summary>
	public string IsAlani
	{
		get
		{
			return this.GetValue(TableUtils.IsAlaniColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IsAlaniColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IsAlaniSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IsAlaniColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IsAlani field.
	/// </summary>
	public string IsAlaniDefault
	{
		get
		{
			return TableUtils.IsAlaniColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.OrganizasyondakiYeri field.
	/// </summary>
	public string OrganizasyondakiYeri
	{
		get
		{
			return this.GetValue(TableUtils.OrganizasyondakiYeriColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OrganizasyondakiYeriColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OrganizasyondakiYeriSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OrganizasyondakiYeriColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OrganizasyondakiYeri field.
	/// </summary>
	public string OrganizasyondakiYeriDefault
	{
		get
		{
			return TableUtils.OrganizasyondakiYeriColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.CalismaSekli field.
	/// </summary>
	public string CalismaSekli
	{
		get
		{
			return this.GetValue(TableUtils.CalismaSekliColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CalismaSekliColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CalismaSekliSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CalismaSekliColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.CalismaSekli field.
	/// </summary>
	public string CalismaSekliDefault
	{
		get
		{
			return TableUtils.CalismaSekliColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public DateTime IlanBaslangicTarihi
	{
		get
		{
			return this.GetValue(TableUtils.IlanBaslangicTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlanBaslangicTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlanBaslangicTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlanBaslangicTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBaslangicTarihi field.
	/// </summary>
	public string IlanBaslangicTarihiDefault
	{
		get
		{
			return TableUtils.IlanBaslangicTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public DateTime IlanBitisTarihi
	{
		get
		{
			return this.GetValue(TableUtils.IlanBitisTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IlanBitisTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlanBitisTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlanBitisTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanBitisTarihi field.
	/// </summary>
	public string IlanBitisTarihiDefault
	{
		get
		{
			return TableUtils.IlanBitisTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public bool IlanDurumu
	{
		get
		{
			return this.GetValue(TableUtils.IlanDurumuColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.IlanDurumuColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IlanDurumuSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IlanDurumuColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.IlanDurumu field.
	/// </summary>
	public string IlanDurumuDefault
	{
		get
		{
			return TableUtils.IlanDurumuColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AcikIlanlar_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AcikIlanlar_.AktifPasif field.
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
