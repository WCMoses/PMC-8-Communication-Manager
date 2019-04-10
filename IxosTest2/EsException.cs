using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxosTest2
{
    [Serializable]
    public class EsException:Exception
    {
        public EsException()
        {

        }
        public EsException(string message) : base(message)
        {

        }
        public EsException(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
