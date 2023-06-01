using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy3
{
    public interface IEncryptionStrategy
    {
        string Encrypt(string pTextToEncript);
        string Decrypt(string pTextToDecrypt);
        bool Init();
    }
}
