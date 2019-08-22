using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDay20190822
{
    public class EasyService
    {
        private int _intBaseNum = 2;

        public  int GetCalResult()
        {
            return _intBaseNum + 5;
        }

        public int GetCalResult2()
        {
            return _intBaseNum + 8;
        }
    }
}
