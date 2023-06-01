using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy3
{
    internal class CaesarStrategy : IEncryptionStrategy
    {
        public string Decrypt(string pTextToDecrypt)
        {
            string result = null;
            result = pTextToDecrypt + " - Desencriptado metodo Caesar - ";
            return result;
        }

        public string Encrypt(string pTextToEncript)
        {
            string result = null;
            result = pTextToEncript + " - Encriptado metodo Caesar - ";
            return result;
        }

        public bool Init()
        {
            bool result = true;
            return result;
        }
    }
}
