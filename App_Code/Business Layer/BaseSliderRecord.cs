// This class is "generated" and will be overwritten.
// Your customizations should be made in SliderRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace KumePortali.Business
{

/// <summary>
/// The generated superclass for the <see cref="SliderRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SliderTable"></see> class.
/// </remarks>
/// <seealso cref="SliderTable"></seealso>
/// <seealso cref="SliderRecord"></seealso>
public class BaseSliderRecord : PrimaryKeyRecord
{

	public readonly static SliderTable TableUtils = SliderTable.Instance;

	// Constructors
 
	protected BaseSliderRecord() : base(TableUtils)
	{
	}

	protected BaseSliderRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.SliderResimID field.
	/// </summary>
	public ColumnValue GetSliderResimIDValue()
	{
		return this.GetValue(TableUtils.SliderResimIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.SliderResimID field.
	/// </summary>
	public Int32 GetSliderResimIDFieldValue()
	{
		return this.GetValue(TableUtils.SliderResimIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Resim field.
	/// </summary>
	public ColumnValue GetResimValue()
	{
		return this.GetValue(TableUtils.ResimColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Resim field.
	/// </summary>
	public byte[] GetResimFieldValue()
	{
		return this.GetValue(TableUtils.ResimColumn).ToBinary();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Resim field.
	/// </summary>
	public void SetResimFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ResimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Resim field.
	/// </summary>
	public void SetResimFieldValue(string val)
	{
		this.SetString(val, TableUtils.ResimColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Resim field.
	/// </summary>
	public void SetResimFieldValue(byte[] val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ResimColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Url field.
	/// </summary>
	public ColumnValue GetUrlValue()
	{
		return this.GetValue(TableUtils.UrlColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Url field.
	/// </summary>
	public string GetUrlFieldValue()
	{
		return this.GetValue(TableUtils.UrlColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Url field.
	/// </summary>
	public void SetUrlFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UrlColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Url field.
	/// </summary>
	public void SetUrlFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UrlColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Baslik field.
	/// </summary>
	public ColumnValue GetBaslikValue()
	{
		return this.GetValue(TableUtils.BaslikColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Baslik field.
	/// </summary>
	public string GetBaslikFieldValue()
	{
		return this.GetValue(TableUtils.BaslikColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Baslik field.
	/// </summary>
	public void SetBaslikFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BaslikColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Baslik field.
	/// </summary>
	public void SetBaslikFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaslikColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.BaslikEn field.
	/// </summary>
	public ColumnValue GetBaslikEnValue()
	{
		return this.GetValue(TableUtils.BaslikEnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.BaslikEn field.
	/// </summary>
	public string GetBaslikEnFieldValue()
	{
		return this.GetValue(TableUtils.BaslikEnColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.BaslikEn field.
	/// </summary>
	public void SetBaslikEnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BaslikEnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.BaslikEn field.
	/// </summary>
	public void SetBaslikEnFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BaslikEnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Aciklama field.
	/// </summary>
	public ColumnValue GetAciklamaValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Aciklama field.
	/// </summary>
	public string GetAciklamaFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Aciklama field.
	/// </summary>
	public void SetAciklamaFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.AciklamaEn field.
	/// </summary>
	public ColumnValue GetAciklamaEnValue()
	{
		return this.GetValue(TableUtils.AciklamaEnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.AciklamaEn field.
	/// </summary>
	public string GetAciklamaEnFieldValue()
	{
		return this.GetValue(TableUtils.AciklamaEnColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AciklamaEn field.
	/// </summary>
	public void SetAciklamaEnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AciklamaEnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AciklamaEn field.
	/// </summary>
	public void SetAciklamaEnFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AciklamaEnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.AktifPasif field.
	/// </summary>
	public ColumnValue GetAktifPasifValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.AktifPasif field.
	/// </summary>
	public bool GetAktifPasifFieldValue()
	{
		return this.GetValue(TableUtils.AktifPasifColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(string val)
	{
		this.SetString(val, TableUtils.AktifPasifColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AktifPasif field.
	/// </summary>
	public void SetAktifPasifFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AktifPasifColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Sira field.
	/// </summary>
	public ColumnValue GetSiraValue()
	{
		return this.GetValue(TableUtils.SiraColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.Sira field.
	/// </summary>
	public Byte GetSiraFieldValue()
	{
		return this.GetValue(TableUtils.SiraColumn).ToByte();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Sira field.
	/// </summary>
	public void SetSiraFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.SiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Sira field.
	/// </summary>
	public void SetSiraFieldValue(string val)
	{
		this.SetString(val, TableUtils.SiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Sira field.
	/// </summary>
	public void SetSiraFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Sira field.
	/// </summary>
	public void SetSiraFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiraColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Sira field.
	/// </summary>
	public void SetSiraFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.SiraColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public ColumnValue GetOlusturulmaTarihiValue()
	{
		return this.GetValue(TableUtils.OlusturulmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public DateTime GetOlusturulmaTarihiFieldValue()
	{
		return this.GetValue(TableUtils.OlusturulmaTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public void SetOlusturulmaTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturulmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public void SetOlusturulmaTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturulmaTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public void SetOlusturulmaTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturulmaTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public ColumnValue GetOlusturanIDValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public Int32 GetOlusturanIDFieldValue()
	{
		return this.GetValue(TableUtils.OlusturanIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public void SetOlusturanIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OlusturanIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.DuzenlenmeTarihi field.
	/// </summary>
	public ColumnValue GetDuzenlenmeTarihiValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.DuzenlenmeTarihi field.
	/// </summary>
	public DateTime GetDuzenlenmeTarihiFieldValue()
	{
		return this.GetValue(TableUtils.DuzenlenmeTarihiColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenlenmeTarihiColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenlenmeTarihi field.
	/// </summary>
	public void SetDuzenlenmeTarihiFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenlenmeTarihiColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public ColumnValue GetDuzenleyenIDValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public Int32 GetDuzenleyenIDFieldValue()
	{
		return this.GetValue(TableUtils.DuzenleyenIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenleyenID field.
	/// </summary>
	public void SetDuzenleyenIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DuzenleyenIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.SliderResimID field.
	/// </summary>
	public Int32 SliderResimID
	{
		get
		{
			return this.GetValue(TableUtils.SliderResimIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SliderResimIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SliderResimIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SliderResimIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.SliderResimID field.
	/// </summary>
	public string SliderResimIDDefault
	{
		get
		{
			return TableUtils.SliderResimIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.Resim field.
	/// </summary>
	public byte[] Resim
	{
		get
		{
			return this.GetValue(TableUtils.ResimColumn).ToBinary();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ResimColumn);			 
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ResimSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ResimColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Resim field.
	/// </summary>
	public string ResimDefault
	{
		get
		{
			return TableUtils.ResimColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.Url field.
	/// </summary>
	public string Url
	{
		get
		{
			return this.GetValue(TableUtils.UrlColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UrlColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UrlSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UrlColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Url field.
	/// </summary>
	public string UrlDefault
	{
		get
		{
			return TableUtils.UrlColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.Baslik field.
	/// </summary>
	public string Baslik
	{
		get
		{
			return this.GetValue(TableUtils.BaslikColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BaslikColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BaslikSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BaslikColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Baslik field.
	/// </summary>
	public string BaslikDefault
	{
		get
		{
			return TableUtils.BaslikColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.BaslikEn field.
	/// </summary>
	public string BaslikEn
	{
		get
		{
			return this.GetValue(TableUtils.BaslikEnColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BaslikEnColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BaslikEnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BaslikEnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.BaslikEn field.
	/// </summary>
	public string BaslikEnDefault
	{
		get
		{
			return TableUtils.BaslikEnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.Aciklama field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Aciklama field.
	/// </summary>
	public string AciklamaDefault
	{
		get
		{
			return TableUtils.AciklamaColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.AciklamaEn field.
	/// </summary>
	public string AciklamaEn
	{
		get
		{
			return this.GetValue(TableUtils.AciklamaEnColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AciklamaEnColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AciklamaEnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AciklamaEnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AciklamaEn field.
	/// </summary>
	public string AciklamaEnDefault
	{
		get
		{
			return TableUtils.AciklamaEnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.AktifPasif field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.AktifPasif field.
	/// </summary>
	public string AktifPasifDefault
	{
		get
		{
			return TableUtils.AktifPasifColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.Sira field.
	/// </summary>
	public Byte Sira
	{
		get
		{
			return this.GetValue(TableUtils.SiraColumn).ToByte();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SiraColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SiraSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SiraColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.Sira field.
	/// </summary>
	public string SiraDefault
	{
		get
		{
			return TableUtils.SiraColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public DateTime OlusturulmaTarihi
	{
		get
		{
			return this.GetValue(TableUtils.OlusturulmaTarihiColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OlusturulmaTarihiColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OlusturulmaTarihiSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OlusturulmaTarihiColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturulmaTarihi field.
	/// </summary>
	public string OlusturulmaTarihiDefault
	{
		get
		{
			return TableUtils.OlusturulmaTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.OlusturanID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.OlusturanID field.
	/// </summary>
	public string OlusturanIDDefault
	{
		get
		{
			return TableUtils.OlusturanIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.DuzenlenmeTarihi field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenlenmeTarihi field.
	/// </summary>
	public string DuzenlenmeTarihiDefault
	{
		get
		{
			return TableUtils.DuzenlenmeTarihiColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Slider_.DuzenleyenID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Slider_.DuzenleyenID field.
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
