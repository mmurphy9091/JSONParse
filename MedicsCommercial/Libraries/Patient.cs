using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicsCommercial.Libraries;

namespace MedicsCommercial
{
    public class Patient
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string SSN;
        public string DOB;
        public string age;
        public string Rank;
        public string unitName;
        public string unitPhone;
        public string height;
        public string weight;
        public string gender;

        public string HR;
        public string Resp;
        public string NIBPSYS;
        public string NIBPDIA;
        public string Temp;
        public string EtC02;
        public string SPO2;

        //Zoll trend stuff
        public TrendResponse Trend = new TrendResponse();
        public int zollIndex = 0;

        public List<string> injuries = new List<string>();

        public string airway;
        public string breathing;
        public string circulation;
        public string skin;
        public string head;
        public string neck;
        public string chest;
        public string abdomen;
        public string pelvis;
        public string back;

        public string ParklandPercent;

        public bool CRPgiven = false;

        //public billableActivities billActiv = new billableActivities();

        public void setVitals()
        {
            //HR
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.HR.TrendDataHR.HRVAL.Value != null)
                {
                    HR = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.HR.TrendDataHR.HRVAL.Value.ToString();
                }
            //RESP
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.RESP.TrendDataResp.RESPVAL.Value != null)
                {
                    Resp = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.RESP.TrendDataResp.RESPVAL.Value.ToString();
                }
            //BP
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.NIBP.NDIA.NDIATrendData.NDIAVAL.Value != null)
                {
                    NIBPDIA = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.NIBP.NDIA.NDIATrendData.NDIAVAL.Value.ToString();
                }
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.NIBP.NSYS.NSYSTrendData.NSYSVAL.Value != null)
                {
                    NIBPSYS = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.NIBP.NSYS.NSYSTrendData.NSYSVAL.Value.ToString();
                }
            //TEMP
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.TEMP[zollIndex].TempTrendData.TempVAL.Value != null)
                {
                    Temp = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.TEMP[zollIndex].TempTrendData.TempVAL.Value.ToString();
                }
            //ETCO2
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.ETcO2.TrendDataETCO2.ETVAL.Value != null)
                {
                    EtC02 = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.ETcO2.TrendDataETCO2.ETVAL.Value.ToString();
                }
            //SPO2
                if (Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.SPO2.SpTrendData.SpVAL.Value != null)
                {
                    SPO2 = Trend.Zoll.TrendReport[zollIndex].TrendRpt.Trend.SPO2.SpTrendData.SpVAL.Value.ToString();
                }
            

        }
    }
}