using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.model
{
    internal class Point2D : Point
    {
        public int Y { get; set; }

        public override string? ToString()
        {
            return $"({X} ,{Y})";
        }

        public override void Move5()
        {
            base.Move5();
            Y += 5;
        }



        //public Point2D() : base()
        //{
        //    Y = 0;
        //}


    }
}
