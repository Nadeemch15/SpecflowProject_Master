using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.CustomException
{
    public class NoSuitableDriverFound : Exception
        
    {
        public NoSuitableDriverFound(string msg) : base(msg)
        {

        }
    }
}
