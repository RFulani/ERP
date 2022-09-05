using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using System.IO;
namespace INV.Code
{
    class ClassQR
    {
        public string encodeQrText(string CompanyName, string TaxNumber, string BillDateTime, string TotalAfterVAT, string TotalVAT)
        {
            //use UTF8 with sallerName to solve arabic issue
            byte[] bytes = Encoding.UTF8.GetBytes(CompanyName);
            string L1 = bytes.Length.ToString("X");
            string tag1Hex = BitConverter.ToString(bytes);
            tag1Hex = tag1Hex.Replace("-", "");

            string L2 = TaxNumber.Length.ToString("X");
            string L3 = BillDateTime.Length.ToString("X");
            string L4 = TotalAfterVAT.Length.ToString("X");
            string L5 = TotalVAT.Length.ToString("X");
            //length tag must be 2 digit like '0C' 
            string hex = "01" + ((L1.Length == 1) ? ("0" + L1) : L1) + tag1Hex +
                         "02" + ((L2.Length == 1) ? ("0" + L2) : L2) + ToHexString(TaxNumber) +
                         "03" + ((L3.Length == 1) ? ("0" + L3) : L3) + ToHexString(BillDateTime) +
                         "04" + ((L4.Length == 1) ? ("0" + L4) : L4) + ToHexString(TotalAfterVAT) +
                         "05" + ((L5.Length == 1) ? ("0" + L5) : L5) + ToHexString(TotalVAT);

            return HexToBase64(hex);
        }

        private string ToHexString(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            string hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        private string HexToBase64(string strInput)
        {
            try
            {
                var bytes = new byte[strInput.Length / 2];
                for (var i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
                }
                return Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {
                return "-1";
            }
        }
    }
}
