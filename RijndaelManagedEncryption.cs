using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PDA_1._0
{
    public class RijndaelManagedEncryption
    {
        //private static byte[] KEY_192 = { 42, 16, 93, 156, 78, 4, 218, 32, 15, 167, 44, 80, 26, 250, 155, 112, 12, 94, 111, 204, 119, 35, 184, 197 };
        //private static byte[] IV_192 = { 55, 103, 246, 79, 36, 99, 167, 33, 42, 55, 62, 83, 184, 77, 209, 13, 145, 23, 200, 58, 173, 10, 121, 222 };
        
        internal const string Inputkey = "560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";
        public static void EncryptFile(string inputFile, string outputFile, string key)
        {
            try
            {
                byte[] keyBytes;
                keyBytes = Encoding.Unicode.GetBytes(key);

                //Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);
                string saltValue = "LRT%YUR#VBNL@112";
                string initVector = "HR$2pIjHR$2pIj12";
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);


                RijndaelManaged rijndaelCSP = new RijndaelManaged();
                rijndaelCSP.Key = saltValueBytes;
                rijndaelCSP.IV = initVectorBytes;

                ICryptoTransform encryptor = rijndaelCSP.CreateEncryptor();

                FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);

                byte[] inputFileData = new byte[(int)inputFileStream.Length];
                inputFileStream.Read(inputFileData, 0, (int)inputFileStream.Length);

                FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

                CryptoStream encryptStream = new CryptoStream(outputFileStream, encryptor, CryptoStreamMode.Write);
                encryptStream.Write(inputFileData, 0, (int)inputFileStream.Length);
                encryptStream.FlushFinalBlock();

                rijndaelCSP.Clear();
                encryptStream.Close();
                inputFileStream.Close();
                outputFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Encryption Failed!");
                return;
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string key)
        {
            try
            {
                byte[] keyBytes = Encoding.Unicode.GetBytes(key);

                //Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);
                string saltValue = "LRT%YUR#VBNL@112";
                string initVector = "HR$2pIjHR$2pIj12";
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

                RijndaelManaged rijndaelCSP = new RijndaelManaged();
                rijndaelCSP.Key = saltValueBytes;
                rijndaelCSP.IV = initVectorBytes;
                ICryptoTransform decryptor = rijndaelCSP.CreateDecryptor();

                FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);

                CryptoStream decryptStream = new CryptoStream(inputFileStream, decryptor, CryptoStreamMode.Read);

                byte[] inputFileData = new byte[(int)inputFileStream.Length];
                decryptStream.Read(inputFileData, 0, (int)inputFileStream.Length);

                FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                outputFileStream.Write(inputFileData, 0, inputFileData.Length);
                outputFileStream.Flush();

                rijndaelCSP.Clear();

                decryptStream.Close();
                inputFileStream.Close();
                outputFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Decryption Failed!");
                return;
            }

            MessageBox.Show("File Decryption Complete!");
        }






        public static string EncryptRijndael(string text, string salt)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text");

            var aesAlg = NewRijndaelManaged(salt);

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(text);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }

       
        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) &&
                   Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }

        public static string DecryptRijndael(string cipherText, string salt)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");

            if (!IsBase64String(cipherText))
                throw new Exception("The cipherText input parameter is not base64 encoded");

            string text;

            var aesAlg = NewRijndaelManaged(salt);
            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            var cipher = Convert.FromBase64String(cipherText);

            using (var msDecrypt = new MemoryStream(cipher))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        text = srDecrypt.ReadToEnd();
                    }
                }
            }
            return text;
        }


        private static RijndaelManaged NewRijndaelManaged(string salt)
        {
            if (salt == null) throw new ArgumentNullException("salt");
            //var saltBytes = Encoding.ASCII.GetBytes(salt);
            //var key = Encoding.ASCII.GetBytes(salt);

            var aesAlg = new RijndaelManaged();

            string saltValue = "LRT%YUR#VBNL@1";
            string initVector = "HR$2pIjHR$2pIj12";

            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            aesAlg.Key = saltValueBytes;
            aesAlg.IV = initVectorBytes;

            return aesAlg;
        }
    }
}

