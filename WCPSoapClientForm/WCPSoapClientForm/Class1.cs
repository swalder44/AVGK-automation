using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WCPSoapClientForm
{
    public partial class Class1
    {
        private readonly DataSet DSRes;
        public int[] ACc;
        public decimal[] AIc;
        public decimal[] ALc;
        public string DTc;
        public string CPCc;
        public int Dc;
        public decimal TWc; public int PrNal;
        public string GRZc; public string NSR; public string NZapr;
        public string DSR; public string SrDSR;
        public string RMarshr; public decimal RM;
        public decimal LSR; public decimal WSR; public decimal HSR;
        public int KRPr; public int KOstPr;
        public decimal Hc;
        public decimal Lc;
        public decimal Wc;
        public string cstrU;
        public decimal IdPr;
        public string IdPrSTR;
        public Int64 NZaprFalse;
        public string Wim;
        public Decimal NPR;
        public decimal[] IInt;
        public string VDocNum;
        public DateTime DDS;
        public Guid INPR1;
        public int Rrc;
        public string DTN;
        public struct structure
        {
            public string VehicleRegNumber;
            public string DocumentNumber;
            public string DocumentDateSign;
            public string DateFrom;
            public string DateTo;
            public int TripCount;
            public int LeftTripCount;
            public string Route;
            public string Dimensions;
            public decimal[] AxlesLoads;
            public decimal FullWeight;
        }
        public double[] prevnar;
        public structure a;
        public structure a2;
        public structure cc;
        public int i;

        private string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public void button1_Click()
        {
            DTN = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(string.Format("http://10.10.10.49:5050/Service.asmx")));//"http://{0}:5050/Service.asmx", "10.10.10.49"))); // "192.168.110.39"))); //Environment.MachineName))); //"192.168.20.30")));
            var serviceClient = new ServiceReference1.RASVSRClient(binding, endpoint);
            
            ServiceReference1.CheckRequestData request_send = new ServiceReference1.CheckRequestData()
            {
                AxlesCount = ACc,//new int[] { 1, 2, 3 },
                AxlesInvervals = AIc,//new decimal[] { 1m, 2m, 3m },
                AxlesLoads = ALc,//new decimal[] { 1m, 2m, 3m },
                CheckDate = Convert.ToDateTime(DTc.ToString()),//DateTime.Now,
                CheckPointCode = CPCc.ToString(),//"001",
                Direction = Dc,
                TotalWeight = TWc,//10m,
                VehicleRegNumber = GRZc,//"123ка77",
                TotalSize = new ServiceReference1.CheckRequestDataTotalSize()
                {
                    Height = Hc,//10m,
                    Length = Lc,//10m,
                    Width = Wc,//10m
                }
            };
            XmlSerializer formatter_input = new XmlSerializer(typeof(ServiceReference1.CheckRequestData));
            MemoryStream memoryStreamInput = new MemoryStream();
            formatter_input.Serialize(memoryStreamInput, request_send);
            try
            {
                
                var rezRequest = serviceClient.Check(request_send);
                Rrc = rezRequest.Count;
                if (rezRequest.Count == 1)
                {
                    //DTN = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
                    int INPR = 0;
                    INPR1 = Guid.NewGuid();
                    IdPrSTR = Convert.ToString(INPR1).Replace("-", "");
                    NZaprFalse = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd") + NZapr.ToString());
                    ConnectStr ResRegionSR = new ConnectStr();
                    ResRegionSR.ConStr(1);
                    cstrU = ResRegionSR.StP;
                    MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);
                    //dataGridView1.DataSource = rezRequest;//ServiceReference1.CheckResultDataList;

                    foreach (var b in rezRequest)//int i=0; i<rezRequest.Count; i++)
                    {
                        //if (b.wr)
                        a.VehicleRegNumber = b.VehicleRegNumber.ToString();
                        a.DocumentNumber = b.Resolution.DocumentNumber.ToString();
                       a.DocumentDateSign = b.Resolution.DocumentDateSign.ToString();
                       a.DateFrom = b.DateFrom.ToString();
                       a.DateTo = b.DateTo.ToString();
                       a.TripCount = b.TripCount;
                       a.LeftTripCount = b.LeftTripCount;
                       a.Route = b.Route.ToString();
                       a.Dimensions = b.Dimensions.ToString();
                       a.AxlesLoads = b.AxlesLoads;
                       a.FullWeight = b.FullWeight;
                           
                        PrNal = Convert.ToInt32(b.RouteCheck.Code);
                        NSR = b.Resolution.DocumentNumber;
                        DSR = Convert.ToString(b.Resolution.DocumentDateSign);
                        SrDSR = Convert.ToString(b.DateTo);
                        RMarshr = b.Route;
                        RM = b.FullWeight;
                        KRPr = b.TripCount;
                        KOstPr = b.LeftTripCount;
                        LSR = b.Dimensions.Length;
                        WSR = b.Dimensions.Width;
                        HSR = b.Dimensions.Height;
                        INPR1 = Guid.NewGuid();
                        IdPrSTR = Convert.ToString(INPR1).Replace("-", "");
                        NZaprFalse = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd") + NZapr.ToString());

                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd.CommandText = "INSERT INTO raptssprrazr "
                        + "("
                        + "idts, "
                        + "dateregsr, "
                        + "grzrasp, "
                        + "KemVid, "
                        + "VidPerevoz, "
                        + "GRZSR, "
                        + "NomSR, "
                        + "DateVidSR, "
                        + "SrokDeistvSR, "
                        + "RazrMarshr, "
                        + "RazrMassa, "
                        + "KolRazrPr, "
                        + "IspolzPR, "
                        + "LengthSR, "
                        + "WidthSR, "
                        + "HeightSR, "
                        + "NarushenMarshrSR, "
                        + "DateZapr, "
                        + "NomZapr, "
                        + "DPR, "
                        + "OstatPR, "
                        + "NZFalse ) "
                        + "VALUES "
                        + "(" + IdPr + ", "
                        + "'" + b.DateFrom.ToString("o") + "', "
                        + "'" + GRZc + "', "
                        + "'ГБУ Севастопольский Автодор', "
                        + "'" + b.ShippingType + "', "
                        + "'" + b.VehicleRegNumber + "', "
                        + "'" + b.Resolution.DocumentNumber + "', "
                        + "'" + b.Resolution.DocumentDateSign.ToString("o") + "', "
                        + "'" + b.DateTo.ToString("o") + "', "
                        + "'" + b.Route + "', "
                        + "" + b.FullWeight + ", "
                        + "" + b.TripCount + ", "
                        + "" + (b.TripCount - b.LeftTripCount + 1)+", "//b.LeftTripCount + ", "
                        + "" + b.Dimensions.Length + ", "
                        + "" + b.Dimensions.Width + ", "
                        + "" + b.Dimensions.Height + ", "
                        + "'" + b.RouteCheck.Code + "', "
                        + "'"+ DTN +"', "
                        + "'" + IdPrSTR + "', "
                        + "'" + Convert.ToDateTime(DTc.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "', "
                        +"" + b.LeftTripCount + ", "
                        + "" + Convert.ToInt64(NZaprFalse) + "); ";
                        //Guid.NewGuid() 
                        cmd.Connection = sqlConnectionT;
                        if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                        { sqlConnectionT.Open(); }
                        //sqlConnectionT.Open();
                        cmd.ExecuteNonQuery();
                        ;

                        IInt = new decimal[b.AxlesInvervals.Length + 1];
                        IInt[0] = 0;
                        for (int iint = 0; iint < b.AxlesInvervals.Length; iint++)
                        { IInt[iint + 1] = b.AxlesInvervals[iint]; }
                        for (int iax = 0; iax < b.AxlesLoads.Length; iax++)
                        {

                            MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand();
                            cmd2.CommandText = "INSERT INTO rapsprazraxel( "
                            + "IDSR, "
                            + "NomAx, "
                            //+ "NomGr, "
                            + "MasAxSR, "
                            + "IntervalAxSR, "
                            + "SkatAxSR, "
                            + "CountRAxSR, "
                            + "Created, "
                            + "NSR) "
                            + "VALUES("
                            + "'" + IdPrSTR + "', "
                            + "" + iax + ", "
                            //+ "DEFAULT, "
                            + "" + b.AxlesLoads[iax] + ", "
                            + "" + IInt[iax] + ", "
                            + "" + b.AxlesWeelsEx[iax] + ", "
                            + "" + b.AxlesWheels[iax] + ", "
                            + "'"+ DTN +"', "
                            + "'" + b.Resolution.DocumentNumber + "'); ";
                            cmd2.Connection = sqlConnectionT;
                            if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                            { sqlConnectionT.Open(); }
                            //sqlConnectionT.Open();
                            cmd2.ExecuteNonQuery();
                        }
                        sqlConnectionT.Close();

                    }

                }
                else if (rezRequest.Count == 0)
                {
                   // DTN = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
                    INPR1 = Guid.NewGuid();
                        IdPrSTR = Convert.ToString(INPR1).Replace("-", "");
                    NZaprFalse = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd") + NZapr.ToString());

                    ConnectStr ResRegionSR = new ConnectStr();
                        ResRegionSR.ConStr(1);
                        cstrU = ResRegionSR.StP;
                        MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);
                        MySql.Data.MySqlClient.MySqlCommand cmd3 = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd3.CommandText = "INSERT INTO raptssprrazr "
                        + "("
                        + "idts, "
                        + "grzrasp, "
                        + "DateZapr, "
                        + "NomZapr, "
                            + "DPR, "
                            + "NZFalse) "
                        + "VALUES "
                        + "(" + IdPr + ", "
                        + "'" + GRZc + "', "
                        + "'"+ DTN +"', "
                        + "'" + IdPrSTR + "', "
                        + "'" + Convert.ToDateTime(DTc.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "', "
                        + "" + Convert.ToInt64(NZaprFalse) + "); ";
                    //Guid.NewGuid() 
                    cmd3.Connection = sqlConnectionT;
                        if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                        { sqlConnectionT.Open(); }
                        //sqlConnectionT.Open();
                        cmd3.ExecuteNonQuery();
                        /* sqlConnectionT.Close()*/
                        ;

                    MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand();
                    cmd2.CommandText = "delete n "
                        + "from raptssprrazr h "
                        + "join raptssprrazr n on n.idts = h.idts AND n.PriznNal = h.PriznNal and n.IdPor > h.IdPor;";

                    cmd2.Connection = sqlConnectionT;
                    if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                    { sqlConnectionT.Open(); }
                    //sqlConnectionT.Open();
                    cmd2.ExecuteNonQuery();

                    sqlConnectionT.Close();



                    MySqlCommand command = new MySqlCommand();
                    ConnectStr conStr = new ConnectStr();
                    //Zapros zapros = new Zapros();
                    conStr.ConStr(1);

                    //zapros.ZaprObrSpRazrLoc(IDT, NamU, 1);
                    MySqlConnection connection = new MySqlConnection(conStr.StP);
                    string z = "UPDATE vehiclecontainer_r"
+ " SET `Change` = 1,"
+ " ChangeType =  1 ,"
+ " DateChang = '"+ DTN +"',"
+ " NameUs = 'AUTO',"
+ " Prim = 'Изменено Спец. Разрешение'"
+ " WHERE ID = " + IdPr + " ;";
                    command.CommandText = z;
                    command.Connection = connection;
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    catch (MySqlException ex)
                    { Console.WriteLine("Error: \r\n{0}", ex.ToString()); }
                    finally
                    { command.Connection.Close(); }

                }
                else if (rezRequest.Count > 1)
                {
                    Boolean[] flags = new Boolean[10];
                    int INPR = 0;
                    int j;
                   // DTN = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
                    decimal minos; decimal minosproc; decimal minosi = 0;
                   Boolean flag; Boolean flagnorm;
                    INPR1 = Guid.NewGuid();
                    IdPrSTR = Convert.ToString(INPR1).Replace("-", "");
                    NZaprFalse = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd") + NZapr.ToString());
                    ConnectStr ResRegionSR = new ConnectStr();
                    ResRegionSR.ConStr(1);
                    cstrU = ResRegionSR.StP;
                    MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);
                    //dataGridView1.DataSource = rezRequest;//ServiceReference1.CheckResultDataList;
                    minos = 10000; minosproc = 0;
                    decimal[] bufer;
                    
                    j = 0;
                    foreach (var b in rezRequest)//int i=0; i<rezRequest.Count; i++)
                    {
                        i = 0;
                        flag = true;

                        cc.AxlesLoads = b.AxlesLoads;
                        foreach (var c in cc.AxlesLoads)
                        { if ((ALc[i] - c > 0) && (prevnar[i] > 3)) { flag = false; } i = i + 1; }
                        
                        if (flag == true)
                        {
                            flags[j] = true;
                            
                        }
                        j = j + 1;
                    }
                    j = 0;
                    // без форичей запоминаем его номер
                    foreach (var b in rezRequest)//int i=0; i<rezRequest.Count; i++)
                    {
                        i = 0;
                        cc.AxlesLoads = b.AxlesLoads;

                        foreach (var c in cc.AxlesLoads)
                        {
                            //от парадокса избавляемся двумя циклами                    
                            if ((Math.Abs(ALc[i] - c) < minos) && (flags[j] == true)) { minos = Math.Abs(ALc[i] - c); minosi = j; }
                        }
                    }
                    j = 0;
                    // без форичей запоминаем его номер
                    foreach (var b in rezRequest)//int i=0; i<rezRequest.Count; i++)
                    {
                        if (j == minosi)
                        {
                            //if (b.wr)
                            a.VehicleRegNumber = b.VehicleRegNumber.ToString();
                            a.DocumentNumber = b.Resolution.DocumentNumber.ToString();
                            a.DocumentDateSign = b.Resolution.DocumentDateSign.ToString();
                            a.DateFrom = b.DateFrom.ToString();
                            a.DateTo = b.DateTo.ToString();
                            a.TripCount = b.TripCount;
                            a.LeftTripCount = b.LeftTripCount;
                            a.Route = b.Route.ToString();
                            a.Dimensions = b.Dimensions.ToString();
                            a.AxlesLoads = b.AxlesLoads;
                            a.FullWeight = b.FullWeight;

                            PrNal = Convert.ToInt32(b.RouteCheck.Code);
                            NSR = b.Resolution.DocumentNumber;
                            DSR = Convert.ToString(b.Resolution.DocumentDateSign);
                            SrDSR = Convert.ToString(b.DateTo);
                            RMarshr = b.Route;
                            RM = b.FullWeight;
                            KRPr = b.TripCount;
                            KOstPr = b.LeftTripCount;
                            LSR = b.Dimensions.Length;
                            WSR = b.Dimensions.Width;
                            HSR = b.Dimensions.Height;
                            //IdPrSTR = DateTime.Now.ToString("yyMMdd")+ IdPr.ToString() ;
                            // IdPr = Convert.ToDecimal(IdPrSTR.ToString());
                            INPR1 = Guid.NewGuid();
                            IdPrSTR = Convert.ToString(INPR1).Replace("-", "");
                            NZaprFalse = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd") + NZapr.ToString());

                            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                            cmd.CommandText = "INSERT INTO raptssprrazr "
                            + "("
                            + "idts, "
                            + "dateregsr, "
                            + "grzrasp, "
                            + "KemVid, "
                            + "VidPerevoz, "
                            + "GRZSR, "
                            + "NomSR, "
                            + "DateVidSR, "
                            + "SrokDeistvSR, "
                            + "RazrMarshr, "
                            + "RazrMassa, "
                            + "KolRazrPr, "
                            + "IspolzPR, "
                            + "LengthSR, "
                            + "WidthSR, "
                            + "HeightSR, "
                            + "NarushenMarshrSR, "
                            + "DateZapr, "
                            + "NomZapr, "
                            + "DPR, "
                            + "OstatPR, "
                            + "NZFalse ) "
                            + "VALUES "
                            + "(" + IdPr + ", "
                            + "'" + b.DateFrom.ToString("o") + "', "
                            + "'" + GRZc + "', "
                            + "'ГБУ Севастопольский Автодор', "
                            + "'" + b.ShippingType + "', "
                            + "'" + b.VehicleRegNumber + "', "
                            + "'" + b.Resolution.DocumentNumber + "', "
                            + "'" + b.Resolution.DocumentDateSign.ToString("o") + "', "
                            + "'" + b.DateTo.ToString("o") + "', "
                            + "'" + b.Route + "', "
                            + "" + b.FullWeight + ", "
                            + "" + (b.TripCount - b.LeftTripCount + 1) + ", "//b.TripCount + ", "
                            + "" + b.LeftTripCount + ", "
                            + "" + b.Dimensions.Length + ", "
                            + "" + b.Dimensions.Width + ", "
                            + "" + b.Dimensions.Height + ", "
                            + "'" + b.RouteCheck.Code + "', "
                            + "'" + DTN +"', "
                            + "'" + IdPrSTR + "', "
                            + "'" + Convert.ToDateTime(DTc.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "', "
                            + "" + b.LeftTripCount + ", "
                        + "" + Convert.ToInt64(NZaprFalse) + "); ";
                            //Guid.NewGuid() 
                            cmd.Connection = sqlConnectionT;
                            if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                            { sqlConnectionT.Open(); }
                            //sqlConnectionT.Open();
                            cmd.ExecuteNonQuery();
                            /* sqlConnectionT.Close()*/
                            ;

                            IInt = new decimal[b.AxlesInvervals.Length + 1];
                            IInt[0] = 0;
                            for (int iint = 0; iint < b.AxlesInvervals.Length; iint++)
                            { IInt[iint + 1] = b.AxlesInvervals[iint]; }
                            for (int iax = 0; iax < b.AxlesLoads.Length; iax++)
                            {

                                MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand();
                                cmd2.CommandText = "INSERT INTO rapsprazraxel( "
                                + "IDSR, "
                                + "NomAx, "
                                //+ "NomGr, "
                                + "MasAxSR, "
                                + "IntervalAxSR, "
                                + "SkatAxSR, "
                                + "CountRAxSR, "
                                + "Created, "
                                + "NSR) "
                                + "VALUES("
                                + "'" + IdPrSTR + "', "
                                + "" + iax + ", "
                                //+ "DEFAULT, "
                                + "" + b.AxlesLoads[iax] + ", "
                                + "" + IInt[iax] + ", "
                                + "" + b.AxlesWeelsEx[iax] + ", "
                                + "" + b.AxlesWheels[iax] + ", "
                                + "'"+ DTN +"', "
                                + "'" + b.Resolution.DocumentNumber + "'); ";
                                cmd2.Connection = sqlConnectionT;
                                if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                                { sqlConnectionT.Open(); }
                                //sqlConnectionT.Open();
                                cmd2.ExecuteNonQuery(); 
                            }                                 
                            a2 = a;    
                    }
                        else
                        {
                            //if (b.wr)
                            a.VehicleRegNumber = b.VehicleRegNumber.ToString();
                            a.DocumentNumber = b.Resolution.DocumentNumber.ToString();
                            a.DocumentDateSign = b.Resolution.DocumentDateSign.ToString();
                            a.DateFrom = b.DateFrom.ToString();
                            a.DateTo = b.DateTo.ToString();
                            a.TripCount = b.TripCount;
                            a.LeftTripCount = b.LeftTripCount;
                            a.Route = b.Route.ToString();
                            a.Dimensions = b.Dimensions.ToString();
                            a.AxlesLoads = b.AxlesLoads;
                            a.FullWeight = b.FullWeight;
                            PrNal = Convert.ToInt32(b.RouteCheck.Code);
                            NSR = b.Resolution.DocumentNumber;
                            DSR = Convert.ToString(b.Resolution.DocumentDateSign);
                            SrDSR = Convert.ToString(b.DateTo);
                            RMarshr = b.Route;
                            RM = b.FullWeight;
                            KRPr = b.TripCount;
                            KOstPr = b.LeftTripCount;
                            LSR = b.Dimensions.Length;
                            WSR = b.Dimensions.Width;
                            HSR = b.Dimensions.Height;
                            //IdPrSTR = DateTime.Now.ToString("yyMMdd")+ IdPr.ToString() ;
                            // IdPr = Convert.ToDecimal(IdPrSTR.ToString());
                            INPR1 = Guid.NewGuid();
                            IdPrSTR = Convert.ToString(INPR1).Replace("-", "");
                            NZaprFalse = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd") + NZapr.ToString());

                            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                            cmd.CommandText = "INSERT INTO raptssprrazr "
                            + "("
                            //+ "idts, "
                            + "dateregsr, "
                           // + "grzrasp, "
                            + "KemVid, "
                            + "VidPerevoz, "
                            + "GRZSR, "
                            + "NomSR, "
                            + "DateVidSR, "
                            + "SrokDeistvSR, "
                            + "RazrMarshr, "
                            + "RazrMassa, "
                            + "KolRazrPr, "
                            + "IspolzPR, "
                            + "LengthSR, "
                            + "WidthSR, "
                            + "HeightSR, "
                            + "NarushenMarshrSR, "
                            + "DateZapr, "
                            + "NomZapr, "
                             + "DPR, "
                             + "OstatPR, "
                             + "NZFalse ) "
                            + "VALUES ("
                           // + "(" + IdPr + ", "
                            + "'" + b.DateFrom.ToString("o") + "', "
                           // + "'" + GRZc + "', "
                            + "'ГБУ Севастопольский Автодор', "
                            + "'" + b.ShippingType + "', "
                            + "'" + b.VehicleRegNumber + "', "
                            + "'" + b.Resolution.DocumentNumber + "', "
                            + "'" + b.Resolution.DocumentDateSign.ToString("o") + "', "
                            + "'" + b.DateTo.ToString("o") + "', "
                            + "'" + b.Route + "', "
                            + "" + b.FullWeight + ", "
                            + "" + (b.TripCount - b.LeftTripCount + 1) + ", "//b.TripCount + ", "
                            + "" + b.LeftTripCount + ", "
                            + "" + b.Dimensions.Length + ", "
                            + "" + b.Dimensions.Width + ", "
                            + "" + b.Dimensions.Height + ", "
                            + "'" + b.RouteCheck.Code + "', "
                            + "'"+ DTN +"', "
                            + "'" + IdPrSTR + "', "
                             + "'" + Convert.ToDateTime(DTc.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "', "
                        + "" + b.LeftTripCount + ", "
                        + "" + Convert.ToInt64(NZaprFalse) + "); ";
                            //Guid.NewGuid() 
                            cmd.Connection = sqlConnectionT;
                            if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                            { sqlConnectionT.Open(); }
                            //sqlConnectionT.Open();
                            cmd.ExecuteNonQuery();
                            /* sqlConnectionT.Close()*/
                            
                            //ConnectStr ResRegionSR = new ConnectStr();
                            //ResRegionSR.ConStr(1);
                            //cstrU = ResRegionSR.StP;
                            //MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);

                            IInt = new decimal[b.AxlesInvervals.Length + 1];
                            IInt[0] = 0;
                            for (int iint = 0; iint < b.AxlesInvervals.Length; iint++)
                            { IInt[iint + 1] = b.AxlesInvervals[iint]; }
                            for (int iax = 0; iax < b.AxlesLoads.Length; iax++)
                            {

                                MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand();
                                cmd2.CommandText = "INSERT INTO rapsprazraxel( "
                                + "IDSR, "
                                + "NomAx, "
                                //+ "NomGr, "
                                + "MasAxSR, "
                                + "IntervalAxSR, "
                                + "SkatAxSR, "
                                + "CountRAxSR, "
                                + "Created, "
                                + "NSR) "
                                + "VALUES("
                                + "'" + IdPrSTR + "', "
                                + "" + iax + ", "
                                //+ "DEFAULT, "
                                + "" + b.AxlesLoads[iax] + ", "
                                + "" + IInt[iax] + ", "
                                + "" + b.AxlesWeelsEx[iax] + ", "
                                + "" + b.AxlesWheels[iax] + ", "
                                + "'"+ DTN +"', "
                                + "'" + b.Resolution.DocumentNumber + "'); ";
                                cmd2.Connection = sqlConnectionT;
                                if (sqlConnectionT.State == System.Data.ConnectionState.Closed)
                                { sqlConnectionT.Open(); }
                                //sqlConnectionT.Open();
                                cmd2.ExecuteNonQuery();
                            }
                                                        
                        }
                    }
                    sqlConnectionT.Close();

                    MySqlCommand command = new MySqlCommand();
                    ConnectStr conStr = new ConnectStr();
                    //Zapros zapros = new Zapros();
                    conStr.ConStr(1);
                    //zapros.ZaprObrSpRazrLoc(IDT, NamU, 1);
                    MySqlConnection connection = new MySqlConnection(conStr.StP);
                    string z = "UPDATE vehiclecontainer_r"
+ " SET `Change` = 1,"
+ " ChangeType =  1 ,"
+ " DateChang = '" + DTN + "',"
+ " NameUs = 'AUTO',"
+ " Prim = 'Изменено Спец. Разрешение'"
+ " WHERE ID = " + IdPr + " ;";
                    command.CommandText = z;
                    command.Connection = connection;
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    catch (MySqlException ex)
                    { Console.WriteLine("Error: \r\n{0}", ex.ToString()); }
                    finally
                    { command.Connection.Close(); }
                }                    
            }
            catch (Exception ex)
            {
                MySqlCommand command = new MySqlCommand();
                ConnectStr conStr = new ConnectStr();
                //Zapros zapros = new Zapros();
                conStr.ConStr(1);

                //zapros.ZaprObrSpRazrLoc(IDT, NamU, 1);
                MySqlConnection connection = new MySqlConnection(conStr.StP);
                string z = "UPDATE vehiclecontainer_r"
+ " SET `Change` = 1,"
+ " ChangeType =  20 ,"
+ " DateChang = '" + DTN + "',"
+ " NameUs = 'AUTO',"
+ " Prim = 'Проверка не окончена (невозможно подключиться к серверу СВСР)'"
+ " WHERE ID = " + IdPr + " ;";
                command.CommandText = z;
                command.Connection = connection;
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (MySqlException exy)
                { Console.WriteLine("Error: \r\n{0}", exy.ToString()); }
                finally
                { command.Connection.Close(); }
            }
        }
        private string DecToStr(decimal[] Dax)
        {
            return String.Join("; ", Dax);
        }

        public void button2_Click(string NZ, Int64 IDpish, string data16, string data17, string PLN, string NZCHASTY)
        {
            if (NZ!="")
            {
                ConnectStr ResRegionSR = new ConnectStr();
                ResRegionSR.ConStr(1);
                cstrU = ResRegionSR.StP;
                MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "DELETE FROM raptssprrazr WHERE NomZapr = '" + NZ + "' ;";
                cmd.Connection = sqlConnectionT;
                sqlConnectionT.Open();
                cmd.ExecuteNonQuery();
                sqlConnectionT.Close();
               
            }
            if (Rrc == 1)
            {
                //int currentRow = dataGridView1.CurrentRow.Index; // номер строки, по которой кликнули
                VDocNum = a.DocumentNumber;//dataGridView1[1, currentRow].Value.ToString(); //ID
                DDS = Convert.ToDateTime(a.DocumentDateSign);//Convert.ToDateTime(dataGridView1[2, currentRow].Value.ToString());
                ConnectStr ResRegionSR = new ConnectStr();
                ResRegionSR.ConStr(1);
                cstrU = ResRegionSR.StP;
                MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "UPDATE raptssprrazr SET PriznNal = 1 WHERE NomSR = '" + VDocNum + "' ;";
                cmd.Connection = sqlConnectionT;
                sqlConnectionT.Open();
                cmd.ExecuteNonQuery();
                sqlConnectionT.Close();


                var binding = new BasicHttpBinding();
                var endpoint = new EndpointAddress(new Uri(string.Format("http://10.10.10.49:5050/Service.asmx")));//"http://{0}:5050/Service.asmx", "10.10.10.49"))); // ;Environment.MachineName))); // "192.168.20.30")));
                var serviceClient = new ServiceReference1.RASVSRClient(binding, endpoint);
                ServiceReference1.WriteOfTripDataRequest writeOfRequest = new ServiceReference1.WriteOfTripDataRequest()
                {
                    IdTrip = Convert.ToString(IdPr),
                    RequestID=Convert.ToString(IdPrSTR),
                    //DelNum=NZ,
                    AxlesCount = ACc,//new int[] { 1, 2, 3 },
                    AxlesInvervals = AIc,//new decimal[] { 1m, 2m, 3m },
                    AxlesLoads = ALc,//new decimal[] { 1m, 2m, 3m },
                    TripDate = Convert.ToDateTime(DTc.ToString()),//DateTime.Now,
                    CheckPointCode = CPCc.ToString(),//"001",
                    //////////////////////////////////+"'" + DTN + "', "
                    //////////////////////////////////    + "'" + IdPrSTR + "', "
                    Direction = Dc,//1,
                                   //Latitude = Convert.ToDecimal("123,5"),
                                   //Longitude = Convert.ToDecimal("127,5"),
                    TotalWeight = TWc,//10m,
                    DocumentDateSign = DDS,
                    DocumentNumber = VDocNum,
                    TotalSize = new ServiceReference1.CheckRequestDataTotalSize()
                    {
                        Height = Hc,//10m,
                        Length = Lc,//10m,
                        Width = Wc,//10m
                    }

                };
                
                    using (MemoryStream memoryStreamInput = new MemoryStream())
                {
                    XmlSerializer formatter_input = new XmlSerializer(typeof(ServiceReference1.WriteOfTripDataRequest));
                    formatter_input.Serialize(memoryStreamInput, writeOfRequest);
                    //textBox1.Text = StreamToString(memoryStreamInput);
                }
                try
                {
                    var rezRequest = serviceClient.WriteOfTrip(writeOfRequest);
                    using (MemoryStream memoryStreamOutput = new MemoryStream())
                    {
                        XmlSerializer formatter_output = new XmlSerializer(typeof(ServiceReference1.WriteOffAnswerData));
                        formatter_output.Serialize(memoryStreamOutput, rezRequest);
                        // textBox1.Text += StreamToString(memoryStreamOutput);
                    }
                }
                catch (Exception ex) { }
            }
            else if (Rrc > 1)
            {
                //int currentRow = dataGridView1.CurrentRow.Index; // номер строки, по которой кликнули
                VDocNum = a2.DocumentNumber;//dataGridView1[1, currentRow].Value.ToString(); //ID
                DDS = Convert.ToDateTime(a2.DocumentDateSign);//Convert.ToDateTime(dataGridView1[2, currentRow].Value.ToString());
                ConnectStr ResRegionSR = new ConnectStr();
                ResRegionSR.ConStr(1);
                cstrU = ResRegionSR.StP;
                MySqlConnection sqlConnectionT = new MySqlConnection(cstrU);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "UPDATE raptssprrazr SET PriznNal = 1 WHERE NomSR = '" + VDocNum + "' ;";
                cmd.Connection = sqlConnectionT;
                sqlConnectionT.Open();
                cmd.ExecuteNonQuery();
                sqlConnectionT.Close();


                var binding = new BasicHttpBinding();
                var endpoint = new EndpointAddress(new Uri(string.Format("http://10.10.10.49:5050/Service.asmx")));//"http://{0}:5050/Service.asmx", "10.10.10.49"))); // ;Environment.MachineName))); // "192.168.20.30")));
                var serviceClient = new ServiceReference1.RASVSRClient(binding, endpoint);
                ServiceReference1.WriteOfTripDataRequest writeOfRequest = new ServiceReference1.WriteOfTripDataRequest()
                {
                    IdTrip = Convert.ToString(IdPr),
                    RequestID = Convert.ToString(IdPrSTR),
                    AxlesCount = ACc,//new int[] { 1, 2, 3 },
                    AxlesInvervals = AIc,//new decimal[] { 1m, 2m, 3m },
                    AxlesLoads = ALc,//new decimal[] { 1m, 2m, 3m },
                    TripDate = Convert.ToDateTime(DTc.ToString()),//DateTime.Now,
                    CheckPointCode = CPCc.ToString(),//"001",
                    Direction = Dc,//1,
                                   //Latitude = Convert.ToDecimal("123,5"),
                                   //Longitude = Convert.ToDecimal("127,5"),
                    TotalWeight = TWc,//10m,
                    DocumentDateSign = DDS,
                    DocumentNumber = VDocNum,
                    TotalSize = new ServiceReference1.CheckRequestDataTotalSize()
                    {
                        Height = Hc,//10m,
                        Length = Lc,//10m,
                        Width = Wc,//10m
                    }

                };

                using (MemoryStream memoryStreamInput = new MemoryStream())
                {
                    XmlSerializer formatter_input = new XmlSerializer(typeof(ServiceReference1.WriteOfTripDataRequest));
                    formatter_input.Serialize(memoryStreamInput, writeOfRequest);
                    //textBox1.Text = StreamToString(memoryStreamInput);
                }
                try
                {
                    var rezRequest = serviceClient.WriteOfTrip(writeOfRequest);
                    using (MemoryStream memoryStreamOutput = new MemoryStream())
                    {
                        XmlSerializer formatter_output = new XmlSerializer(typeof(ServiceReference1.WriteOffAnswerData));
                        formatter_output.Serialize(memoryStreamOutput, rezRequest);
                        // textBox1.Text += StreamToString(memoryStreamOutput);
                    }
                    MySqlCommand command3 = new MySqlCommand();
                    ConnectStr conStr3 = new ConnectStr();
                    conStr3.ConStr(1);
                    string connectionString3;
                    connectionString3 = conStr3.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                    MySqlConnection connection3 = new MySqlConnection(connectionString3);
                    string z3 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
          + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data16 + " " + data17).ToString("yyyyMMddHHmmss")) + "', 1, 'направлен запрос СР', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                    //MySqlCommand command = new MySqlCommand(z);
                    command3.CommandText = z3;// commandString;
                    command3.Connection = connection3;
                    connection3.Open();
                    command3.ExecuteNonQuery();
                    command3.Connection.Close();

                    MySqlCommand command2 = new MySqlCommand();
                    ConnectStr conStr2 = new ConnectStr();
                    conStr2.ConStr(1);
                    string connectionString2;
                    connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                    MySqlConnection connection2 = new MySqlConnection(connectionString3);
                    string z2 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
          + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data16 + " " + data17).ToString("yyyyMMddHHmmss")) + "', 2, 'получен ответ СР', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                    //MySqlCommand command = new MySqlCommand(z);
                    command2.CommandText = z2;// commandString;
                    command2.Connection = connection2;
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    command2.Connection.Close();
                    //if (StatAng > 0 && (data1.a[241] != data1.a[244]))
                    //{ a.button2_Click(Nzapr); }
                    //else { a.button2_Click(""); }

                }
                catch (Exception ex) { }
            }
            else if (Rrc != 0)
            {
            }
            
        }
    }
}
