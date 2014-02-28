using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicsCommercial.Libraries
{
    public class TrendData
    {
        heartRate hr;
        etco2 et;
        spo2 sp;
        bloodPressure bp;
        resp re;
        temperature t;

        //constructor with just default values
        public TrendData(string heart, string etc, string spo, string blood, string respi, string temp)
        {
            hr = new heartRate(heart);
            et = new etco2(etc);
            sp = new spo2(spo);
            bp = new bloodPressure(blood);
            re = new resp(respi);
            t = new temperature(temp);
        }

        //create constructor with value overloads later
    }

    class heartRate
    {
        string value;
        string rate;

        //Default to beats per minutes
        public heartRate(string setValue)
        {
            value = setValue;
            rate = "bpm";
        }

        public heartRate(string setValue, string setRate)
        {
            value = setValue;
            rate = setRate;
        }
    }

    class etco2
    {
        string value;
        string rate;

        public etco2(string setValue)
        {
            value = setValue;
            rate = "mmHG";
        }

    }

    class spo2
    {
        string value;
        string rate;

        public spo2(string setValue)
        {
            value = setValue;
            rate = "%";
        }

    }

    class bloodPressure
    {
        string value;

        public bloodPressure(string setValue)
        {
            value = setValue;
        }

    }

    class resp
    {
        string value;
        string rate;

        //Default to breaths per minutes
        public resp(string setValue)
        {
            value = setValue;
            rate = "bpm";
        }

        public resp(string setValue, string setRate)
        {
            value = setValue;
            rate = setRate;
        }
    }

    class temperature
    {
        string value;
        string rate;

        //Default to F
        public temperature(string setValue)
        {
            value = setValue;
            rate = "F";
        }

        public temperature(string setValue, string setRate)
        {
            value = setValue;
            rate = setRate;
        }
    }
}
