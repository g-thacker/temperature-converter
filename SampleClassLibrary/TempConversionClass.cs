using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassLibrary
{
    public class TempConversionClass
    {
        private double StartTemp;
        private double EndTemp;
        private string ConversionType;

        public double InputTemp
        {
            set
            {
                StartTemp = value;
            }
            get
            {
                return StartTemp;
            }
        }
        public string TargetScale
        {
            set
            {
                ConversionType = value;
            }
            get
            {
                return ConversionType;
            }
        }
        public double OutputTemp
        {
            get
            {
                return EndTemp;
            }
        }
        public void PerformConversion()
        {
            switch (ConversionType)
            {
                case "fToC":
                    EndTemp = (StartTemp - 32) / 1.8;
                    break;
                case "cToF":
                    EndTemp = (StartTemp * 1.8) + 32;
                    break;
            }

        }
    }
}
