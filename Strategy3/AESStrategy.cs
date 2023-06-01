using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Strategy3
{
    internal class AESStrategy : IEncryptionStrategy
    {
        private KeyGenerator generator;
        private Key key;
        private Cipher cipher;

        public string Decrypt(string pTextToDecrypt)
        {
            string result = null;
            result = pTextToDecrypt + "- Desencriptado metodo Aes - ";
            return result;
        }

        public string Encrypt(string pTextToEncript)
        {
            string result = null;
            result = pTextToEncript + "- Encriptado metodo Aes - ";
            return result;
        }

        public bool Init()
        {
            bool result = true;       
            return result;
        }       
    }
}
