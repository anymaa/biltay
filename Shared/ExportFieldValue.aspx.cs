using System;
using BaseClasses.Utils;
using BaseClasses.Data;

namespace KumePortali
{
    partial class ExportFieldValue : KumePortali.UI.BaseApplicationPage
    {

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
        }

        private void Page_Init(object sender, System.EventArgs e)
        {
            InitializeComponent();
        }

        public string FieldId
        {
            get
            {
                return this.Decrypt(this.Request.Params["Field"]);
            }
        }

        public string FileName
        {
            get
            {
                return this.Request.Params["FileName"];
            }
        }
        
        public string RecordId
        {
            get
            {
                return this.Decrypt(this.Request.Params["Record"]);
            }
        }

        public string TableId
        {
            get
            {
                string errMsg;
                string TYPE_FORMAT = "{0}.{1}{2},{3}";
                string tableName = ((string)this.Request.Params["Table"]);
                tableName = this.Decrypt(tableName);
                tableName = tableName.Replace(" ", "_");
                try
                {
                    string tableType = string.Format(TYPE_FORMAT, "KumePortali.Business", tableName, "Table", "App_Code");
                    System.Type.GetType(tableType, true, true);
                    return tableType;
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                }
                try
                {
                    string viewType = string.Format(TYPE_FORMAT, "KumePortali.Business", tableName, "View", "App_Code");
                    System.Type.GetType(viewType, true, true);
                    return viewType;
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                }
                try
                {
                    string queryType = string.Format(TYPE_FORMAT, "KumePortali.Business", tableName, "Query", "App_Code");
                    System.Type.GetType(queryType, true, true);
                    return queryType;
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                }
                return "";
            }
        }

        public int Offset
        {
            get
            {
                if (this.Request.Params["Offset"] != null)
                {
                    return System.Convert.ToInt32(this.Request.Params["Offset"]);
                }
                else
                {
                    return 0;
                }
            }
        }
        public int ImageHeight
		{
		    get
		    {
				if (this.Request.Params["ImageHeight"] != null)
				{
				    return int.Parse(this.Request.Params["ImageHeight"]);
				}
				else
				{
				    return 0;
				}
		    }
		}
		public int ImageWidth
		{
		    get
		    {
				if (this.Request.Params["ImageWidth"] != null)
				{
				    return int.Parse(this.Request.Params["ImageWidth"]);
				}
				else
				{
				    return 0;
				}
		    }
        }
		public double ImagePercentSize
		{
			get
			{
				if (this.Request.Params["ImagePercentSize"] != null)
				{
					return double.Parse(this.Request.Params["ImagePercentSize"]);
				}
				else
				{
					return 0.0;
				}
			}
		}
        public ExportFieldValue()
        {
            this.Load += new EventHandler(Page_Load);
        }

        private void Page_Load(object sender, System.EventArgs e)
        {
            if ((BaseClasses.Utils.NetUtils.GetUrlParam(this, "Table", true) == null) ||
                (BaseClasses.Utils.NetUtils.GetUrlParam(this, "Table", true).Length == 0) ||
                (BaseClasses.Utils.NetUtils.GetUrlParam(this, "Record", true) == null) ||
                (BaseClasses.Utils.NetUtils.GetUrlParam(this, "Record", true).Length == 0) ||
                (BaseClasses.Utils.NetUtils.GetUrlParam(this, "Field", true) == null) ||
                (BaseClasses.Utils.NetUtils.GetUrlParam(this, "Field", true).Length == 0))
            {
                return;
            }
            this.DataBind();
            this.ExportData();
        }

        protected void ExportData()
        {
            try
            {
                PrimaryKeyTable t = (PrimaryKeyTable)BaseTable.CreateInstance(this.TableId);
                BaseRecord rec = (BaseRecord)t.GetRecordData(this.RecordId, false);
                if (!(this.ImagePercentSize == 0.0) || !((this.ImageHeight == 0) || (this.ImageWidth == 0)))
                {
					//To display image with shrinking according to user specified height/width or ImagePercentSize
                    ColumnValue fieldData = MiscUtils.GetData(rec, t.TableDefinition.ColumnList.GetByAnyName(this.FieldId));
                    byte[] binaryData = MiscUtils.GetBinaryData(t.TableDefinition.ColumnList.GetByAnyName(this.FieldId), fieldData);
                    byte[] thumbNailSizeImage = GetThumbNailSizeImage(binaryData);
                    string filName = MiscUtils.GetFileNameWithExtension(t.TableDefinition.ColumnList.GetByAnyName(this.FieldId), binaryData, null);
                    MiscUtils.SendToWriteResponse(this.Response, thumbNailSizeImage, filName, t.TableDefinition.ColumnList.GetByAnyName(this.FieldId), fieldData, this.Offset);
                }
                else
                {
					//Calling ExportFieldData method without image shrinking.
	                MiscUtils.ExportFieldData(this.Response, rec, t.TableDefinition.ColumnList.GetByAnyName(this.FieldId), this.FileName, this.Offset);
                }
            }
            catch 
            {
            }
        }

        protected byte[] GetThumbNailSizeImage(byte[] binaryData)
        {
            byte[] ThumbNailBinaryData=null;
            try
            {
                System.IO.MemoryStream TempMemStream = new System.IO.MemoryStream(binaryData);
                System.Drawing.Image ImageObj;
                System.Drawing.Image ThumbSizeImageObj;
                ImageObj = System.Drawing.Image.FromStream(TempMemStream);
				int temHeight;
				int temWidth;
				temHeight = ImageObj.Height;
				temWidth = ImageObj.Width;
                System.IO.MemoryStream TempFileStream = new System.IO.MemoryStream();
				// If Imagesize is less than 20*20 then return the original image
				if (((temWidth < 20) 
					&& (temHeight < 20))) 
				{
					byte[] ImageBinaryData;
					ImageObj.Save(TempFileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
					ImageBinaryData = new byte[] {((byte)(TempFileStream.Length))};
					ImageBinaryData = TempFileStream.ToArray();
					return ImageBinaryData;
				}
				double percentSize = this.ImagePercentSize;
				 
                // If the ImagePercentSize is 0.2 then the actual percent calculation will result in generating
                // temHeight and temWidth as Zero. When the height and width is zero, GetThumbnailImage() 
                // will generate image of arbitrary size. Hence the image will not display as predicted, 
                // ie, with size 0.2%. For this purpose, to maintain consistant image size, when ImagePercentSize 
                // is less than 1, it is taken as actual percentage for eg. when ImagePercentSize is 0.2, it is considered as 20%
                // and image will displayed with 20% of original size.
                if (this.ImagePercentSize <= 1)
				{ 
					percentSize = this.ImagePercentSize * 100;
				}
                //Actual percentage calculation. as ImagePercentSize value provided by client is a number not a percent
                percentSize = percentSize / 100;
				temHeight = (int)((percentSize * temHeight));
				temWidth = (int)((percentSize * temWidth));
				// Create thumbnail size of the original Image ImageObj
				if (this.ImagePercentSize == 0) 
				{
					ThumbSizeImageObj = ImageObj.GetThumbnailImage(this.ImageWidth, this.ImageHeight, null, IntPtr.Zero);
				}
				else 
				{
					ThumbSizeImageObj = ImageObj.GetThumbnailImage(temWidth, temHeight, null, IntPtr.Zero);
				}
                ThumbSizeImageObj.Save(TempFileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                ThumbNailBinaryData = new byte[] {
                    ((byte)(TempFileStream.Length))};
                ThumbNailBinaryData = TempFileStream.ToArray();
            }
            catch 
            {
            }
            return ThumbNailBinaryData;
        }
        protected override void UpdateSessionNavigationHistory()
        {
        }
    }
}