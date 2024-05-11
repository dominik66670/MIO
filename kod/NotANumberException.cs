using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kod
{
    public class NotANumberException : Exception
    {
        public NotANumberException(string message) :base(message) { }
        public NotANumberException() : base("Wprowadzono nie właścią wartość w polu precyzja (D)") { }
    }
}
