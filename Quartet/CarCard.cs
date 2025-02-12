using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//top speed
//0-60
//hourse power
//CubicCM
//cylinders
//RPM
namespace Quartet
{
    internal class CarCard
    {
        //6 properties
        public int MaxSpeed { get; set; }
        public double ZeroToSixty { get; set; }
        public int HorsePower { get; set; }
        public int CC {  get; set; }
        public int cylinders { get; set; }
        public int RPM { get; set; }
    }
}
