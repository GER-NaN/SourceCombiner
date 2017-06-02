using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private int test;

        public Class1()
        {
            test = 45;
            Debug.WriteLine(test);
        }
    }

    public class WhatsUpDawg
    {
        public string Name { get; set; }

        public WhatsUpDawg()
        {
            IEnumerable<Class1> linqUsage = new List<Class1>();
            var x = linqUsage.Where(t => t.GetHashCode() > 1);

            var y = this.ToCrazyObject();
        }

    }

    public static class WhatsUpDawgExtensions
    {
        public static object ToCrazyObject(this WhatsUpDawg dawg)
        {
            return new object();
        }
    }

}
