using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CustomNamespace
{
    class Class2
    {
        public int Value;
        public Class2()
        {
            Value = 3;
        }

        public void Test()
        {
            try
            {
                var j = 9;
                for (int i = 0; i < 5; i++)
                {
                    j++;
                }


            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
