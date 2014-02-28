using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace MedicsCommercial.Libraries
{
    [DataContract]
    public class TrendResponse
    {
        [DataMember(Name = "ZOLL")]
        public Zoll Zoll { get; set; }
    }

    [DataContract]
    public class Zoll
    {
        [DataMember(Name = "@SchemaVersion")]
        public string SchemaVersion { get; set; }
        [DataMember(Name = "TrendReport")]
        public TrendReport[] TrendReport { get; set; }

    }

    [DataContract]
    public class TrendReport
    {
        [DataMember(Name = "TrendRpt")]
        public TrendRpt TrendRpt { get; set; }
    }

    [DataContract]
    public class TrendRpt
    {
        [DataMember(Name = "Trend")]
        public Trend Trend { get; set; }
    }

    [DataContract]
    public class Trend
    {
        [DataMember(Name = "Etco2")]
        public ETCO2 ETcO2 { get; set; }
        [DataMember(Name = "Fico2")]
        public FICO2 FICO2 { get; set; }
        [DataMember(Name = "Hr")]
        public HR HR { get; set; }
        [DataMember(Name = "Ibp")]
        public IBP[] IBP { get; set; }
        [DataMember(Name = "Nibp")]
        public NIBP NIBP { get; set; }
        [DataMember(Name = "LtaState")]
        public int LtaState { get; set; }
        [DataMember(Name = "LtaStateVal")]
        public string LtaStateVal { get; set; }
        [DataMember(Name = "PatMode")]
        public int PatientMode { get; set; }
        [DataMember(Name = "Resp")]
        public RESP RESP { get; set; }
        [DataMember(Name = "Spo2")]
        public SPO2 SPO2 { get; set; }
        [DataMember(Name = "Temp")]
        public TEMP[] TEMP { get; set; }

    }

    //ETCO2 Work
    [DataContract]
    public class ETCO2
    {
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "TrendData")]
        public TrendDataETCO2 TrendDataETCO2 { get; set; }
    }

    [DataContract]
    public class TrendDataETCO2
    {
        [DataMember(Name = "Alarm")]
        public int Alarm {get; set;}
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public ETVAL ETVAL { get; set; }
    }

    [DataContract]
    public class ETVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    //FICO2 Work
    [DataContract]
    public class FICO2
    {
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "DispFlag")]
        public string DisplayFlag { get; set; }
        [DataMember(Name = "TrendData")]
        public TrendDataFico TrendDataFico { get; set; }
    }

    [DataContract]
    public class TrendDataFico
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public FIVAL FIVAL { get; set; }
    }

    [DataContract]
    public class FIVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    //HR Work
    [DataContract]
    public class HR
    {
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "SrcLabel")]
        public int SrcLabel { get; set; }
        [DataMember(Name = "SrcLabelVal")]
        public string SrcLabelVal { get; set; }
        [DataMember(Name = "TrendData")]
        public TrendDataHR TrendDataHR { get; set; }
    }

    [DataContract]
    public class TrendDataHR
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public HRVAL HRVAL { get; set; }
    }

    [DataContract]
    public class HRVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    //IBP Work
    [DataContract]
    public class IBP
    {
        [DataMember(Name = "@ChanNum")]
        public int ChannelNumber { get; set; }
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "Dia")]
        public IDIA IDIA { get; set; }
        [DataMember(Name = "DispForm")]
        public int DisplayForm { get; set; }
        [DataMember(Name = "Map")]
        public IMAP IMAP { get; set; }
        [DataMember(Name = "SrcLabel")]
        public int SrcLabel { get; set; }
        [DataMember(Name = "SrcLabelVal")]
        public string SrcLabelVal { get; set; }
        [DataMember(Name = "Sys")]
        public ISYS ISYS { get; set; }
    }

    [DataContract]
    public class IDIA
    {
        [DataMember(Name = "TrendData")]
        public IDIATrendData IDIATrendData { get; set; }
    }

    [DataContract]
    public class IDIATrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public IDIAVAL IDIAVAL { get; set; }
    }

    [DataContract]
    public class IDIAVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    [DataContract]
    public class IMAP
    {
        [DataMember(Name = "TrendData")]
        public IMAPTrendData IMAPTrendData { get; set; }
    }

    [DataContract]
    public class IMAPTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public IMAPVAL IMAPVAL { get; set; }
    }

    [DataContract]
    public class IMAPVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    [DataContract]
    public class ISYS
    {
        [DataMember(Name = "TrendData")]
        public ISYSTrendData ISYSTrendData { get; set; }
    }

    [DataContract]
    public class ISYSTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public ISYSVAL ISYSVAL { get; set; }
    }

    [DataContract]
    public class ISYSVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }


    //NIBP Work
    [DataContract]
    public class NIBP
    {
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "Dia")]
        public NDIA NDIA { get; set; }
        [DataMember(Name = "DispForm")]
        public int DisplayForm { get; set; }
        [DataMember(Name = "Map")]
        public NMAP NMAP { get; set; }
        [DataMember(Name = "SrcLabel")]
        public int SrcLabel { get; set; } 
        [DataMember(Name = "Sys")]
        public NSYS NSYS { get; set; }
        [DataMember(Name = "Time")]
        public string Time { get; set; }
    }

    [DataContract]
    public class NDIA
    {
        [DataMember(Name = "TrendData")]
        public NDIATrendData NDIATrendData { get; set; }
    }

    [DataContract]
    public class NDIATrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public NDIAVAL NDIAVAL { get; set; }
    }

    [DataContract]
    public class NDIAVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    [DataContract]
    public class NMAP
    {
        [DataMember(Name = "TrendData")]
        public NMAPTrendData NMAPTrendData { get; set; }
    }

    [DataContract]
    public class NMAPTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public NMAPVAL NMAPVAL { get; set; }
    }

    [DataContract]
    public class NMAPVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    [DataContract]
    public class NSYS
    {
        [DataMember(Name = "TrendData")]
        public NSYSTrendData NSYSTrendData { get; set; }
    }

    [DataContract]
    public class NSYSTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public NSYSVAL NSYSVAL { get; set; }
    }

    [DataContract]
    public class NSYSVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

    //Resp Work
    [DataContract]
    public class RESP
    {
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "NoBreathAlarmActive")]
        public int NoBreathAlarmActive { get; set; }
        [DataMember(Name = "SrcLabel")]
        public int SrcLabel { get; set; }
        [DataMember(Name = "SrcLabelVal")]
        public string SrcLabelVal { get; set; }
        [DataMember(Name = "TrendData")]
        public TrendDataResp TrendDataResp { get; set; }
    }

    [DataContract]
    public class TrendDataResp
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public RESPVAL RESPVAL { get; set; }
    }

    [DataContract]
    public class RESPVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }


    //SPO2 Work
    [DataContract]
    public class SPO2
    {
        [DataMember(Name = "ChanState")]
        public int ChanelState { get; set; }
        [DataMember(Name = "SpCo")]
        public SpCo SpCo { get; set; }
        [DataMember(Name = "SpHb")]
        public SpHb SpHb { get; set; }
        [DataMember(Name = "SpMet")]
        public SpMet SpMet { get; set; }
        [DataMember(Name = "TrendData")]
        public SpTrendData SpTrendData { get; set; }
    }

        //SpCo
    [DataContract]
    public class SpCo
    {
        [DataMember(Name = "Monitoring")]
        public int Monitoring { get; set; }
        [DataMember(Name = "TrendData")]
        public SpCoTrendData SpCoTrendData { get; set; }
    }

    [DataContract]
    public class SpCoTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public SpCoVAL SpCoVAL { get; set; }
    }

    [DataContract]
    public class SpCoVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

        //SpHb
    [DataContract]
    public class SpHb
    {
        [DataMember(Name = "Monitoring")]
        public int Monitoring { get; set; }
        [DataMember(Name = "TrendData")]
        public SpHbTrendData SpHbTrendData { get; set; }
    }

    [DataContract]
    public class SpHbTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public SpHbVAL SpHbVAL { get; set; }
    }

    [DataContract]
    public class SpHbVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

        //SpMet
    [DataContract]
    public class SpMet
    {
        [DataMember(Name = "Monitoring")]
        public int Monitoring { get; set; }
        [DataMember(Name = "TrendData")]
        public SpMetTrendData SpMetTrendData { get; set; }
    }

    [DataContract]
    public class SpMetTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public SpMetVAL SpMetVAL { get; set; }
    }

    [DataContract]
    public class SpMetVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }

        //The rest of the SPO2 parse
    [DataContract]
    public class SpTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public SpVAL SpVAL { get; set; }
    }

    [DataContract]
    public class SpVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }


    //Temp work
    [DataContract]
    public class TEMP
    {
        [DataMember(Name = "@Type")]
        public int Type { get; set; }
        [DataMember(Name = "ChanState")]
        public int ChannelState { get; set; }
        [DataMember(Name = "SrcLabel")]
        public int SrcLabel { get; set; }
        [DataMember(Name = "SrcLabelVal")]
        public string SrcLabelValue { get; set; }
        [DataMember(Name = "TrendData")]
        public TempTrendData TempTrendData { get; set; }
    }

    [DataContract]
    public class TempTrendData
    {
        [DataMember(Name = "Alarm")]
        public int Alarm { get; set; }
        [DataMember(Name = "DataState")]
        public string DataState { get; set; }
        [DataMember(Name = "DataStatus")]
        public int DataStatus { get; set; }
        [DataMember(Name = "Val")]
        public TempVAL TempVAL { get; set; }
    }

    [DataContract]
    public class TempVAL
    {
        [DataMember(Name = "#text")]
        public double Value { get; set; }
        [DataMember(Name = "@Units")]
        public int Units { get; set; }
        [DataMember(Name = "@UnitsVal")]
        public string UnitsVal { get; set; }
    }


}
