using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kod
{
    public class RangeError : Exception
    {
        public RangeError(string message) : base(message) {}
    }
}
