using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftNetTraining.Encryption
{
    public class LearningRSA
    {
        public static void Run()
        {
            string plainText = "This is my super secret data";
            Console.WriteLine("Plain text: {0}", plainText);
           
            // RSA works on byte arrays, not strings of text
            // This will convert our input string into bytes and back
            // ASCIIEncoding converter = new ASCIIEncoding();

            // Convert the plain text into a byte array or encoding
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            DumpBytes("Plain bytes: ", plainBytes);

            byte[] encryptedBytes;
            byte[] decryptedBytes;

            // Create a new RSA to encrypt the data
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();

            // get the keys out of the encryptor
            string publicKey = rsaEncrypt.ToXmlString(includePrivateParameters: false);
            Console.WriteLine("Public key: {0}", publicKey);
            string privateKey = rsaEncrypt.ToXmlString(includePrivateParameters: true);
            Console.WriteLine("Private key: {0}", privateKey);

            // Now tell the encyryptor to use the public key to encrypt the data
            rsaEncrypt.FromXmlString(publicKey);

            // Use the encryptor to encrypt the data. The fOAEP parameter
            // specfies how the output is "padded" with extra bytes
            // For maximum compatibility with receiving systems, set this as
            // false
            encryptedBytes = rsaEncrypt.Encrypt(plainBytes, fOAEP:false);

            DumpBytes("Encrypted bytes: ", encryptedBytes);

            // Now do the decode - use the private key for this
          
            // We have sent someone our public key and they 
            // have used this to encrypt data that they are sending to us

            // Create a new RSA to decrypt the data
            RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider();

            // Configure the decryptor from the XML in the private key
            rsaDecrypt.FromXmlString(privateKey);
 
            decryptedBytes = rsaDecrypt.Decrypt(encryptedBytes, fOAEP: false);

            //decoding
            string decryptedText = Encoding.ASCII.GetString(decryptedBytes);
            
            DumpBytes("Decrypted bytes: ", decryptedBytes);
            Console.WriteLine("Decrypted string: {0}",decryptedText );

        }
        
        static void DumpBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (byte b in bytes)
            {
                Console.Write("{0:X} ", b);
            }
            Console.WriteLine();
        }
    }
}