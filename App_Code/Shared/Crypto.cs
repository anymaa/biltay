
using System.IO;
using System.Text;
using System.Web;
using System.Security.Cryptography;

//SymmCrypto is a wrapper of System.Security.Cryptography.SymmetricAlgorithm classes
//and simplifies the interface. It supports customized SymmetricAlgorithm as well.
//Original Code from Frank Fang
//Revised by Jerome Howard to remove Bad Data errors, create seperate CryptoIV and
//use the maximum legal keysize for each encryption algorithm

namespace KumePortali.Business
{
    public class Crypto
    {
        //256 Bit IV Key that is truncated when a smaller keys are required
        private byte [] _bytIV = {78, 90, 23, 7, 54, 109, 34, 231, 90, 66, 109, 185, 228, 143, 89, 77, 190, 89, 103, 148, 54, 4, 98, 67, 243, 162, 68, 201, 73, 59, 184, 52 };
        private byte [] bytIV;
        //Supported .Net intrinsic SymmetricAlgorithm classes.
        public enum Providers {  DES, RC2, Rijndael }
        private SymmetricAlgorithm _CryptoService;
        //Constructor for using an intrinsic .Net SymmetricAlgorithm class.
        public Crypto(Providers NetSelected)
        {
            switch (NetSelected)
            {
                case Providers.DES:
                    _CryptoService = new DESCryptoServiceProvider();
                    break;
                case Providers.RC2:
                    _CryptoService = new RC2CryptoServiceProvider();
                    break;
                case Providers.Rijndael:
                    _CryptoService = new RijndaelManaged();
                    break;
            }
        }
        //Constructor for using a customized SymmetricAlgorithm class.
        public Crypto(SymmetricAlgorithm ServiceProvider)
        {
            _CryptoService = ServiceProvider;
        }
        //Depending on the legal key size limitations of a specific CryptoService provider
        //and length of the private key provided, padding the secret key with a character
        //or triming it to meet the legal size of the algorithm. 
        private byte[] GetLegalKey(string Key)
        {
            //key sizes are in bits
            string sTemp;
            int dValue;
            if (_CryptoService.LegalKeySizes.Length > 0)
            {
                int maxSize = _CryptoService.LegalKeySizes[0].MaxSize;
                dValue = (int)(maxSize / 8);
                if (Key.Length * 8 > maxSize) { sTemp = Key.Substring(0, dValue); }
                else
                {
                    int moreSize = _CryptoService.LegalKeySizes[0].MinSize;
                    while (Key.Length * 8 > moreSize) { moreSize += _CryptoService.LegalKeySizes[0].SkipSize; }
                    sTemp = Key.PadRight(dValue, "X"[0]);
                }
            }
            else {                sTemp=Key; }
            if (_CryptoService.LegalBlockSizes.Length > 0)
                {
                int maxSize = _CryptoService.LegalBlockSizes[0].MaxSize;
                dValue = (int)(maxSize / 8);
                int byteIVsize;
                if(sTemp.Length * 8 > maxSize) byteIVsize = dValue; 
                else byteIVsize = sTemp.Length;
                this.bytIV = new byte[byteIVsize];
                for (int i = 0; (i < this._bytIV.Length) && (i < byteIVsize); i++ ) this.bytIV[i] = this._bytIV[i];
            }
            
            // not finished
 //convert the secret key to byte array 
		return ASCIIEncoding.ASCII.GetBytes(sTemp); 
	    }

        public string Encrypt(string Source, string Key, bool Encoded)
        {
            return this.Encrypt(Source, Key, System.Text.Encoding.ASCII, Encoded);
        }

        public string Encrypt(string Source, string Key, System.Text.Encoding Encoding, bool Encoded) 
	    { 
		    if (Encoded) {
                Source = System.Web.HttpUtility.UrlEncode(Source); 
		    } 
            byte[] bytIn;
            if (Encoding == System.Text.Encoding.ASCII)
            {
                bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(Source);
            }
            else if (Encoding == System.Text.Encoding.Unicode)
            {
                bytIn = System.Text.UnicodeEncoding.Unicode.GetBytes(Source);
            }
            else
            {
                bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(Source);
            }
		//byte[] bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(Source); 
		MemoryStream ms = new MemoryStream(); 
        

		//set the keys 
		_CryptoService.Key = GetLegalKey(Key);
        if (this.bytIV == null) _CryptoService.IV = _bytIV;
        else 		_CryptoService.IV = bytIV; 

		//create an Encryptor from the Provider Service instance 
		ICryptoTransform encrypto = _CryptoService.CreateEncryptor(); 

		//create Crypto Stream that transforms a stream using the encryption 
		CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write); 

		//write out encrypted content into MemoryStream 
		cs.Write(bytIn, 0, bytIn.Length); 
		cs.FlushFinalBlock(); 
		cs.Close(); 
		byte[] bytOut = ms.ToArray(); 
		ms.Close(); 

		return System.Convert.ToBase64String(bytOut); 
		//convert into Base64 so that the result can be used in xml 
	    }

        public string Decrypt(string Source, string Key, bool Encoded)
        {
            return this.Decrypt(Source, Key, System.Text.Encoding.ASCII, Encoded);
        }

        public string Decrypt(string Source, string Key, System.Text.Encoding Encoding, bool Encoded) 
	    { 
		//convert from Base64 to binary 
		    byte[] bytIn = System.Convert.FromBase64String(Source); 
		    MemoryStream ms = new MemoryStream(bytIn); 

		    byte[] bytKey = GetLegalKey(Key); 
		    byte[] bytTemp = new byte[bytIn.Length + 1]; 

		    //set the private key 
		    _CryptoService.Key = bytKey;
            if (this.bytIV == null) _CryptoService.IV = _bytIV;
            else _CryptoService.IV = bytIV; 

		    //create a Decryptor from the Provider Service instance 
		    ICryptoTransform encrypto = _CryptoService.CreateDecryptor(); 

		    //create Crypto Stream that transforms a stream using the decryption 
		    CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read); 
		    string output = ""; 
		    try { 
		        //read out the result from the Crypto Stream 
                StreamReader sr;
                if (Encoding == System.Text.Encoding.ASCII)
                {
                    sr = new StreamReader(cs);
                }
                else if (Encoding == System.Text.Encoding.Unicode)
                {
                    sr = new StreamReader(cs, System.Text.UnicodeEncoding.Unicode);
                }
                else
                {
                    sr = new StreamReader(cs);
                }
		        //StreamReader sr = new StreamReader(cs, System.Text.UnicodeEncoding.Unicode); 

		        output = sr.ReadToEnd(); 
		        sr.Close(); 
		        ms.Close(); 
		        cs.Close(); 
		    } 
		    catch { 
		    } 
		    if (Encoded) {
                output = System.Web.HttpUtility.UrlDecode(output); 
		    } 
		    return output; 
	    } 
	} 
}