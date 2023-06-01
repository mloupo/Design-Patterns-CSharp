using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy3
{
    public class StrategyContext
    {
        private IEncryptionStrategy strategy;
        public StrategyContext(IEncryptionStrategy strategy)
        {
            SetStrategy(strategy);
        }

        public string EncryptText(string pText)
        {
            string result = strategy.Encrypt(pText);
            return result;
        }

        public string DecryptText(string pText)
        {
            string result = strategy.Decrypt(pText); return result;
        }

        public void SetStrategy(IEncryptionStrategy pStrategy) 
        {
            this.strategy = pStrategy;
            this.strategy.Init();
        }
    }
}
