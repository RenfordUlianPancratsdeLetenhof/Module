using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Volyery
    {
        public double LandArea { get; set; }
        public double SwimArea { get; set; }
        public double LandWidth { get; set; }
        public double LandLength { get; set; }

        public Volyery(double landWidth, double landLength, double swimArea = 0)
        {
            LandWidth = landWidth;
            LandLength = landLength;
            SwimArea = swimArea;
            LandArea = landWidth * landLength;
        }
    }

    interface IArea
    {
        double area();
    }

    public class DackArea : Volyery, IArea
    {
        public DackArea(double landWidth, double landLength, double swimArea = 0) : base(landWidth, landLength, swimArea)
        {
        }

        public double area()
        {
            return LandLength * SwimArea;
        }
    }

    public class PenguinArea : Volyery, IArea
    {
        public PenguinArea(double landWidth, double landLength, double swimArea = 0) : base(landWidth, landLength, swimArea)
        {
        }

        public double area()
        {
            return LandLength * SwimArea;
        }
    }
    public class KiwiArea : Volyery, IArea
    {
        public KiwiArea(double landWidth, double landLength, double swimArea = 0) : base(landWidth, landLength, swimArea)
        {
        }

        public double area()
        {
            return LandLength * SwimArea;
        }
    }

}
