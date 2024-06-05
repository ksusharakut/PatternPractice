using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class President
    {
        private static President _instance;

        private President() {}

        public static President GetInstance()
        {
            if(_instance == null)
            {
                _instance = new President();
            }
            return _instance;
        }

        public void SignLaw(string message)
        {
            Console.WriteLine($"Президент подписал закон: {message}");
        }
    }
}
