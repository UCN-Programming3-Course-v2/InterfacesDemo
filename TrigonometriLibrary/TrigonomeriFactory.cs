using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometriLibrary
{
    public static class TrigonomeriFactory
    {
        public static IPythagoras CreatePythagorasCalculator()
        {
            return new Pythagoras2();
        }
    }
}
