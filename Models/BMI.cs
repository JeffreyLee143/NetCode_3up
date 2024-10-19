using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP_BMI.Models
{
    public class BMI
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Caculate_BMI()
        {
            double b;
            string r="Your BMI: ";
            if (Height >= 2) Height /= 100;
            if (Weight <= 0) throw new Exception();
            b= Math.Round(Weight / (Height * Height),2);
            r += b+"<br>";
            if (b < 18.5)
            {
                r += "體重過輕";
            }else if (b < 24)
            {
                r += "正常範圍";
            }else if (b < 27)
            {
                r += "過重";
            }else if (b < 30)
            {
                r += "輕度肥胖";
            }else if (b < 35)
            {
                r += "中度肥胖";
            }
            else
            {
                r += "重度肥胖";
            }
            return r;
        }
        public BMI(double height, double weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}