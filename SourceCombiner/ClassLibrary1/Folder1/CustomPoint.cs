using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Folder1
{
    class CustomPoint
    {
        public Point myPoint = new Point(1,1);
        public PointF myPointF;

        public CustomPoint()
        {
            var p2 = new Point(2, 2);
            var max = Math.Max(p2.X, myPoint.X);
            myPointF = new PointF(4f,2f);
        }

    }
}
