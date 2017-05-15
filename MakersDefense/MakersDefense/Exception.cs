using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class MakersDefenseException : Exception
    {
        public MakersDefenseException()
        {
        }

        public MakersDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : MakersDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
