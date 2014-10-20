// This class is "generated" and will be overwritten.
// Your customizations should be made in TedarikciDegerlendirmeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="TedarikciDegerlendirmeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="TedarikciDegerlendirmeTable"></see> class.
/// </remarks>
/// <seealso cref="TedarikciDegerlendirmeTable"></seealso>
/// <seealso cref="TedarikciDegerlendirmeRecord"></seealso>
public class BaseTedarikciDegerlendirmeRecord : PrimaryKeyRecord
{

	public readonly static TedarikciDegerlendirmeTable TableUtils = TedarikciDegerlendirmeTable.Instance;

	// Constructors
 
	protected BaseTedarikciDegerlendirmeRecord() : base(TableUtils)
	{
	}

	protected BaseTedarikciDegerlendirmeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.DegerlendirmeID field.
	/// </summary>
	public ColumnValue GetDegerlendirmeIDValue()
	{
		return this.GetValue(TableUtils.DegerlendirmeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.DegerlendirmeID field.
	/// </summary>
	public Int32 GetDegerlendirmeIDFieldValue()
	{
		return this.GetValue(TableUtils.DegerlendirmeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public ColumnValue GetIhaleIDValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public Int32 GetIhaleIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public void SetIhaleIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public ColumnValue GetIhaleTeklifIDValue()
	{
		return this.GetValue(TableUtils.IhaleTeklifIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public Int32 GetIhaleTeklifIDFieldValue()
	{
		return this.GetValue(TableUtils.IhaleTeklifIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public void SetIhaleTeklifIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IhaleTeklifIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public void SetIhaleTeklifIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.IhaleTeklifIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public void SetIhaleTeklifIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTeklifIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public void SetIhaleTeklifIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTeklifIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public void SetIhaleTeklifIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IhaleTeklifIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public ColumnValue GetFirmaIDValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public Int32 GetFirmaIDFieldValue()
	{
		return this.GetValue(TableUtils.FirmaIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public void SetFirmaIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirmaIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public ColumnValue GetTeslimTarihiValue()
	{
		return this.GetValue(TableUtils.TeslimTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public DateTime GetTeslimTarihiFieldValue()
	{
		return this.GetValue(TableUtils.TeslimTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public void SetTeslimTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeslimTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public void SetTeslimTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.TeslimTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public void SetTeslimTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeslimTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public ColumnValue GetGonderilenValue()
	{
		return this.GetValue(TableUtils.GonderilenColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public Int32 GetGonderilenFieldValue()
	{
		return this.GetValue(TableUtils.GonderilenColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public void SetGonderilenFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.GonderilenColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public void SetGonderilenFieldValue(string val)
	{
		this.SetString(val, TableUtils.GonderilenColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public void SetGonderilenFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GonderilenColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public void SetGonderilenFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GonderilenColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public void SetGonderilenFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.GonderilenColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public ColumnValue GetFireValue()
	{
		return this.GetValue(TableUtils.FireColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public Int32 GetFireFieldValue()
	{
		return this.GetValue(TableUtils.FireColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public void SetFireFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FireColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public void SetFireFieldValue(string val)
	{
		this.SetString(val, TableUtils.FireColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public void SetFireFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FireColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public void SetFireFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FireColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public void SetFireFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FireColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public ColumnValue GetSorunlaraCozumValue()
	{
		return this.GetValue(TableUtils.SorunlaraCozumColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public Byte GetSorunlaraCozumFieldValue()
	{
		return this.GetValue(TableUtils.SorunlaraCozumColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public void SetSorunlaraCozumFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SorunlaraCozumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public void SetSorunlaraCozumFieldValue(string val)
	{
		this.SetString(val, TableUtils.SorunlaraCozumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public void SetSorunlaraCozumFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SorunlaraCozumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public void SetSorunlaraCozumFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SorunlaraCozumColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public void SetSorunlaraCozumFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SorunlaraCozumColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public ColumnValue GetTeknikYeterlilikValue()
	{
		return this.GetValue(TableUtils.TeknikYeterlilikColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public Byte GetTeknikYeterlilikFieldValue()
	{
		return this.GetValue(TableUtils.TeknikYeterlilikColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public void SetTeknikYeterlilikFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TeknikYeterlilikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public void SetTeknikYeterlilikFieldValue(string val)
	{
		this.SetString(val, TableUtils.TeknikYeterlilikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public void SetTeknikYeterlilikFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeknikYeterlilikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public void SetTeknikYeterlilikFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeknikYeterlilikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public void SetTeknikYeterlilikFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TeknikYeterlilikColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public ColumnValue GetTalepleriKarsilayabilmeValue()
	{
		return this.GetValue(TableUtils.TalepleriKarsilayabilmeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public Byte GetTalepleriKarsilayabilmeFieldValue()
	{
		return this.GetValue(TableUtils.TalepleriKarsilayabilmeColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public void SetTalepleriKarsilayabilmeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TalepleriKarsilayabilmeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public void SetTalepleriKarsilayabilmeFieldValue(string val)
	{
		this.SetString(val, TableUtils.TalepleriKarsilayabilmeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public void SetTalepleriKarsilayabilmeFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TalepleriKarsilayabilmeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public void SetTalepleriKarsilayabilmeFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TalepleriKarsilayabilmeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public void SetTalepleriKarsilayabilmeFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TalepleriKarsilayabilmeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public ColumnValue GetKaliteProsesleriValue()
	{
		return this.GetValue(TableUtils.KaliteProsesleriColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public Byte GetKaliteProsesleriFieldValue()
	{
		return this.GetValue(TableUtils.KaliteProsesleriColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public void SetKaliteProsesleriFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.KaliteProsesleriColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public void SetKaliteProsesleriFieldValue(string val)
	{
		this.SetString(val, TableUtils.KaliteProsesleriColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public void SetKaliteProsesleriFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KaliteProsesleriColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public void SetKaliteProsesleriFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KaliteProsesleriColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public void SetKaliteProsesleriFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.KaliteProsesleriColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
	/// </summary>
	public DateTime GetOlusturmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
	/// </summary>
	public void SetOlusturmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.DegerlendirmeID field.
	/// </summary>
	public Int32 DegerlendirmeID
	{
		get
		{
			return this.GetValue(TableUtils.DegerlendirmeIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DegerlendirmeIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DegerlendirmeIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DegerlendirmeIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DegerlendirmeID field.
	/// </summary>
	public string DegerlendirmeIDDefault
	{
		get
		{
			return TableUtils.DegerlendirmeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public Int32 IhaleID
	{
		get
		{
			return this.GetValue(TableUtils.IhaleIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IhaleIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IhaleIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IhaleIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleID field.
	/// </summary>
	public string IhaleIDDefault
	{
		get
		{
			return TableUtils.IhaleIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.IhaleTeklifID field.
	/// </summary>
	public string IhaleTeklifIDDefault
	{
		get
		{
			return TableUtils.IhaleTeklifIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.FirmaID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.FirmaID field.
	/// </summary>
	public string FirmaIDDefault
	{
		get
		{
			return TableUtils.FirmaIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public DateTime TeslimTarihi
	{
		get
		{
			return this.GetValue(TableUtils.TeslimTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeslimTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeslimTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeslimTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeslimTarihi field.
	/// </summary>
	public string TeslimTarihiDefault
	{
		get
		{
			return TableUtils.TeslimTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public Int32 Gonderilen
	{
		get
		{
			return this.GetValue(TableUtils.GonderilenColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.GonderilenColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool GonderilenSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.GonderilenColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Gonderilen field.
	/// </summary>
	public string GonderilenDefault
	{
		get
		{
			return TableUtils.GonderilenColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public Int32 Fire
	{
		get
		{
			return this.GetValue(TableUtils.FireColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FireColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FireSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FireColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.Fire field.
	/// </summary>
	public string FireDefault
	{
		get
		{
			return TableUtils.FireColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public Byte SorunlaraCozum
	{
		get
		{
			return this.GetValue(TableUtils.SorunlaraCozumColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SorunlaraCozumColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SorunlaraCozumSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SorunlaraCozumColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.SorunlaraCozum field.
	/// </summary>
	public string SorunlaraCozumDefault
	{
		get
		{
			return TableUtils.SorunlaraCozumColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public Byte TeknikYeterlilik
	{
		get
		{
			return this.GetValue(TableUtils.TeknikYeterlilikColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TeknikYeterlilikColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TeknikYeterlilikSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TeknikYeterlilikColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TeknikYeterlilik field.
	/// </summary>
	public string TeknikYeterlilikDefault
	{
		get
		{
			return TableUtils.TeknikYeterlilikColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public Byte TalepleriKarsilayabilme
	{
		get
		{
			return this.GetValue(TableUtils.TalepleriKarsilayabilmeColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TalepleriKarsilayabilmeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TalepleriKarsilayabilmeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TalepleriKarsilayabilmeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.TalepleriKarsilayabilme field.
	/// </summary>
	public string TalepleriKarsilayabilmeDefault
	{
		get
		{
			return TableUtils.TalepleriKarsilayabilmeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public Byte KaliteProsesleri
	{
		get
		{
			return this.GetValue(TableUtils.KaliteProsesleriColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.KaliteProsesleriColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool KaliteProsesleriSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.KaliteProsesleriColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.KaliteProsesleri field.
	/// </summary>
	public string KaliteProsesleriDefault
	{
		get
		{
			return TableUtils.KaliteProsesleriColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturmaTarihi field.
	/// </summary>
	public string OlusturmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's TedarikciDegerlendirme_.DuzenleyenID field.
	/// </summary>
	public string DuzenleyenIDDefault
	{
		get
		{
			return TableUtils.DuzenleyenIDColumn.DefaultValue;
		}
	}


#endregion
}

}
