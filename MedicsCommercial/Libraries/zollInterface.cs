using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Security;
using MedicsCommercial.Libraries;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace MedicsCommercial.Libraries
{
    class zollInterface
    {
        string ip_addr = "192.168.222.2";
        //TrendData trend = new TrendData();

        public TrendResponse getTrend()
        {
            string url = "https://" + ip_addr + "/Trend/current?now";
            HttpWebRequest GETRequest = (HttpWebRequest)WebRequest.Create(url);
            GETRequest.Method = "GET";
            GETRequest.Accept = "application/json";
            GETRequest.ContentType = "application/json";
            GETRequest.Headers.Add("Client-Id", "12345");
            GETRequest.Headers.Add("Authorization", "Basic em9sbGRhdGE6SGVsbG8sMSdtRnJvbVpPTEw=");

            //trust the ip
            InitiateSSLTrust();

            //Sending the request
            Console.WriteLine("Sending GET request");
            try
            {
                HttpWebResponse GETResponse = (HttpWebResponse)GETRequest.GetResponse();
                //Stream GETResponseStream = GETResponse.GetResponseStream();
                
                //JSON Parse stuff
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TrendResponse));
                object objResponse = jsonSerializer.ReadObject(GETResponse.GetResponseStream());
                TrendResponse TRENDRESPONSE = objResponse as TrendResponse;

                //string test = TRENDRESPONSE.Zoll.TrendReport[0].TrendRpt.Trend.HR.TrendDataHR.HRVAL.Value.ToString;
                

                return TRENDRESPONSE;
            }
            catch
            {
                Console.WriteLine("fail");
                return null;
            }
        }

        public static void InitiateSSLTrust()
        {
            try
            {
                //Change SSL checks so that all checks pass
                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(
                        delegate
                        { return true; }
                    );
            }
            catch
            {
                //ActivityLog.InsertSyncActivity(ex);
            }
        }

        public void trendParse(string jsonData)
        {
            
        }
    }
}
