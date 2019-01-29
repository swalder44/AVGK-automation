﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.Common;
using System.Diagnostics;
using System.Xml.Linq;
using System.Net;
using System.ServiceModel;
using System.Xml.Serialization;
using MySql.Data;
using Ionic.Zip;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Signers;

namespace AVGK
{
    class AutoPDF
    {
        public struct names
        {
            public string massFact;
            public string BaseDistance;
            public string BaseNumber;
            public string massPrev;
            public string massSR;
            public string PDKmass;
            public string BaseDistanceSR;
            public string factPremission;
            public string massK;
            public string massPrevSR;
            public string massSign;
            public string groupNumber;
            public string skatnost;
            public string BaseDistancePrevSign;
            public string BaseDistanceNorm;
            public string LoadAxisPermission;
            public string DifferencePermissionFact;
            public string AxisIntervalsNorm;
            public string AxisIntervalsPermission;
            public string SignExcessIntervalAxis;
            public string NomStatei;
            public string DifferencePDKFact;
           
        }
        public struct namesGR
        {
            public string BaseNumber;
            public string skatnost;
            public string CountAxesInGroup;
            public string BaseDistance;
            public string massFact;
            public string massK;
            public string PDKmass; 
            public string massSR;             
            public string massPrev;
            public string massSign;
            public string groupNumber;
            public string BaseDistanceSR;
            public string factPremission;            
            public string massPrevSR;            
            public string BaseDistancePrevSign;
            public string BaseDistanceNorm;
            public string LoadAxisPermission;
            public string DifferencePermissionFact;
            public string DifferencePDKFact;
            public string AxisIntervalsNorm;
            public string AxisIntervalsPermission;
            public string SignExcessIntervalAxis;
            public string NomStatei;

        }
        public struct CODE
        {
            public string CodNarANg;
            public string TypNarTXTA;
            public string EDIzmA;
            public double MAXPREVA ;
            public double MAXPREVPROTCA;
            public int KNRA;
        }
            public struct structure
        {
            public string[] a; //= new string[250];
            public string[,] b;
            public string[,] c;
            public Bitmap p1;
            public Bitmap p2;
            public Bitmap p3;

        }
        public double b8; public double b9; public double b10; public double b11; public double b12;
        public double c8; public double c9; public double c10; public double c11; public double c12;

        public string cstrU;
        public string z1; string NamPD;
        public string dateSR;
        public string numberSR; string Nzapr; int StatAng;
        public string VNTN;
        public double PrevDlPr; public int NOG; public string CodNar; public string CodNarM;
        public Bitmap Im; public Bitmap ImPl; Bitmap ImAlt; Bitmap SkS; Bitmap ImAlt1; Bitmap ImAlt2; Bitmap Im1; Bitmap Im2; Bitmap SkF; Bitmap SkT; Bitmap ImR; Bitmap ImAltR; Bitmap ImPlR;
        public Bitmap ImOb; Bitmap ImROb;
        public int iPic = 2;
        public System.IO.Stream[] Pic = new System.IO.Stream[10];
        public string NRUB;
        public int PicCount;
        public string zLB;
        public Int64 IDpish;
        public Int64 IDW;
        public string PLN;
        public int ss;
        public string TSh = "";
        public string[] XDate = new string[39];
        public names[] names3;// = new names[10];
        public namesGR[] namesGRUP;// = new namesGR[10];
        public string CodSTAll; public string CodSTGabarL; public string CodSTGabarW; public string CodSTGabarH; public string CodSTSpeed;
        public string[] names1 = new string[10];
        public string[] names2 = new string[10];
        public DataSet DSPR = new DataSet();
        public Zapros zapros = new Zapros();
        public string IDSravn = "";
        Stream ms = null;
        public CODE[] CodNarAN; /*= new CODE[26];*/
        //Stream mstil = null;
        Stream nz = null;
        Stream onz = null;
        public string FFF;
        public string FF;
        public int COs;
        public string D1; public string D2;
        public int Cl;
        public string WM;
        public string cstr;
        public string z;
        public string zLPR;
        public string di; public string dii;
        public string odi; public string odii;
        public int KnPriv;
        public int IDTSIsh; public int IDTSKon;
        public string NDI; public string NDII;
        public string OII; public string OIID;   public string OGRZ;    public string OKL;
        public string NLP;
        public string OlDat;
        public int chang;
        public int IDSV;
        public double[] PDKOsTel = new double[10];
        Stream msdop = null;       // Stream mstildop = null;
        Stream nzdop = null; Stream onzdop = null;
        public string tiposhema = "";
        public int KGr = 1;
        public static double widh;
        public static int location;
        public static int locOpisOs;
        public double[] l = new double[10];
        public double[] D = new double[10]; ///Группа из скольки колес
        public double[] DoubO = new double[10];///Двойные скаты на какой оси
        public double[] TypO = new double[10];///Тип оси
        public double[] PDKO = new double[10];///PDK оси
        public double[] PDKTel = new double[10];///пдк тележки
        public string[] CodNarANG = new string[26];///Для кодов наруш
        public string EDIzm;
        public string[] A1 = new string[280];///Для акта
        public string[] A2 = new string[260];///Для акта связаного
        public string[] Ch = new string[260];///Для акта
        public int a1i = 0;
        public int a2i = 0;
        public int GNach;
        public int GEnd;
        public int j;
        public int Fx;
        public string Sk;
        public int[,] KN = new int[2, 10];  public int[,] KNn = new int[2, 10]; public int[,] KNR = new int[2, 10]; public int[] KNM = new int[9];
        public double[] G2 = new double[10]; public double[] G3 = new double[10];  public double[] G5 = new double[10];  public double[] G6 = new double[10];   public double[] G7 = new double[10];
        public double[] D111 = new double[10];
        public double D1_2 = 0; public double D1S_2S = 0; public double D2_3 = 0;  public double D3_4 = 0; public double D4_5 = 0;  public double D5_6 = 0; public double D6_7 = 0;
        public double D7_8 = 0; public double ObshMass = 0;
        public double ADNagr = 0;
        public double RasstOs = 0;
        public double DLINATS = 0;
        public double SHIRTS = 0;
        public double VISTS = 0;
        public int DO = 0;
        public int TypeO = 0;
        public int KolOs = 0;
        public int TTS = 0;
        public int FPR = 0;
        public int rowIndex = 0;
        public int kol = 0;
        public int currentRowLeft;
        public int IDKLLeft = 0;
        public int kol3;
        public int rowIndex3;
        public int RowCountC;
        public int RowCountB;
        public int[] AC;
        public decimal[] AI;
        public decimal[] AL;
        public string DT;
        public string CPC;
        public int Dc;
        public decimal TW;
        public string GRZ;
        public decimal H;
        public decimal L;
        public decimal W;
        public int i = 1;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public Image bin;
        public string NNarushen; public int SubKKl;
        public int ic;
        public int icO;
        public int icC;
        public int GrO = 0;
        private MySqlConnection connection;  public MySqlConnection connection1;  public MySqlConnection connection2;  public MySqlConnection connectionR;  private MySqlDataAdapter mySqlDataAdapter;
        public string NamU;
        public int KolOsR;
        public string NarOb;
        public double[,] PDK = new double[7, 10]; public double[,] PDKGR = new double[7, 10]; public double[,] BetOs = new double[22, 10];
        public double NarOsM; public string NarOs;  public double NarGRM; public string NarObMS;
        public string LPPR;
        public decimal Lpr;  public decimal Hpr; public decimal Wpr;
        public string tipoS;
        public structure data1; 
        public Int64 NPicKR = 0;
        public int ColPicKR; int MAXiNar; 
        public string FFFT;
        public int TypNar; public string TypNarTXT; public double PPRNAR; public int iNar; public double MAXPREV = 0; public double MAXPREVPROTC = 0;
        public double[] PrevNar = new double[40];//0-9 нагр на ось; 10-16 нагр на тел; 17 Общ масса; 18-20 габариты; 21 скорость, полоса, ограничения 25 Срок действия поверки
                                                 //26- Количество осей 27-одиночн/автопоезд 28 ТТС/КТС/ТКТС 29 наличие с/р 30 Ось/группа/общ.масса/длина/ширина/высота
                                                 //31-№оси/группы 32-превышение поПДК или по СР 33 - степень превышения (%,м) 34- часть статьи 1-11 35 - выезд на встречку/выезд на обочину 36 - доп часть ПДД
        public string PNarSTEPEN;
        public int Cr11; int Ind;
        public string[] SPEED_ALL = new string[8];
        public string GDAng; int AngStat = 0; public Guid INAng;
        public string Gross;
        public string Part;
        public string Group;
        public string siz;
        public string speed; public int KLISPR; public string PLACE; public int KOGrNar;
        public string TypNarTXTM;
        public string EDIzmM ;
        public string MAXPREVM;
        public string MAXPREVPROTCM;
        public string KNRM; string NZaprF; int ChastNZapr; int KolZap; string SigAx="False"; string SigGr="False"; string SigAll= "False"; string PlID;
        public string NSPov; string DVPov; string ValidPov; double NagrTel; int KolGr; double SrednRTel;

        public bool OpenConnection() //// Открытие соединения
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection() //// Закрытие соединения
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void LoadPDF(int IDTS, string NUs, int ChNZ)//// загрузка формы уже с пользователем и проездом
        {
            ChastNZapr = ChNZ;
            NamU = NUs;
            IDTSIsh = IDTS;
            data1.a = new string[253];
            data1.b = new string[13, 10];
            data1.c = new string[13, 7];


            ////////////////////////////////////////////////////////////////////////////////////////////////////
            MySqlCommand command = new MySqlCommand();
            ConnectStr conStr = new ConnectStr();
            conStr.ConStr(1);
            Zapros zapros = new Zapros();
            string connectionString;
            connectionString = conStr.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            zapros.ZaprAllCamNaprLO(IDTS, 0);
            string z = zapros.commandStringTest;
            command.CommandText = z;
            command.Connection = connection;
            MySqlDataReader reader;

            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PlID = reader["PlatformId"].ToString();
                    KolZap = KolZap + 1;
                    KolOs = Convert.ToInt32(reader["AxleCount"].ToString());
                    ObshMass = Convert.ToInt32(reader["Weight"].ToString());

                    if (Convert.ToString(reader["UIDAng"].ToString()) != "")
                    {
                        AngStat = 1; GDAng = Convert.ToString(reader["UIDAng"].ToString());
                    }
                   
                    if (Convert.ToInt32(reader["StatAng"].ToString()) == 2)
                    {  GRZ = reader["OldGRZ"].ToString(); }
                    else
                    {
                        if (reader["PlateConfidence"].ToString() == "0")
                        { GRZ = reader["PlateRear"].ToString(); }
                        else
                        {   GRZ = reader["Plate"].ToString();    }
                    }
                    Gross= reader["IsOverweightGross"].ToString();
                    Part = reader["IsOverweightPartial"].ToString();
                    Group = reader["IsOverweightGroup"].ToString();
                    siz = reader["IsOversized"].ToString();
                    speed = reader["IsOverspeed"].ToString();
                    KLISPR= Convert.ToInt32(reader["KlNew"].ToString());
                    //if (reader["PlateConfidence"].ToString() == "0")
                    //{
                    //    GRZ = reader["PlateRear"].ToString();
                    //}
                    //else
                    //{
                    //    GRZ = reader["Plate"].ToString();

                    //}
                    Cr11 = Convert.ToInt32(reader["CredenceExceeded"].ToString());
                    Ind = Convert.ToInt32(reader["ChangeType"].ToString());
                    StatAng = Convert.ToInt32(reader["StatAng"].ToString());

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }

            /////////////////////////////////////////
            //    запрос для формирования ячеек с сертификата поверки
            //MySqlCommand command = new MySqlCommand();
            //ConnectStr conStr = new ConnectStr();
            conStr.ConStr(1);
            //Zapros zapros = new Zapros();
            string commandStringPoverka;
            connectionString = conStr.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            commandStringPoverka = "SELECT " +
                                   "rap_svid_poverki_si.IDWim, " +
                                   "rap_svid_poverki_si.VidSPSI, " +
                                   "rap_svid_poverki_si.NomSPSI, " +
                                   "rap_svid_poverki_si.DateVidSPSI, " +
                                   "rap_svid_poverki_si.SrokSPSI, " +
                                   "rap_svid_poverki_si.PhotoSvidPSI " +
                                   "FROM rap_svid_poverki_si " +
                                   "WHERE rap_svid_poverki_si.IDWim = '" + PlID + "' " +
                                   "AND DATE_FORMAT(STR_TO_DATE(SrokSPSI, '%d.%m.%Y'), '%Y%m%d') > DATE_FORMAT(NOW(), '%Y%m%d')";
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //zapros.ZaprAllCamNaprLO(IDTS, 0);
            //string z = zapros.commandStringTest;
            command.CommandText = commandStringPoverka;
            command.Connection = connection;
            MySqlDataReader readerPoverka;
            int NumberIter = 0;
            try
            {
                command.Connection.Open();
                readerPoverka = command.ExecuteReader();

                while (readerPoverka.Read())
                {
                    if (NumberIter == 0)
                    {
                        NSPov= readerPoverka["NomSPSI"].ToString();
                        DVPov = readerPoverka["DateVidSPSI"].ToString();
                        ValidPov = readerPoverka["SrokSPSI"].ToString();
                    }
                    if (NumberIter == 1)
                    {
                        NSPov = NSPov + " / " + readerPoverka["NomSPSI"].ToString();
                        DVPov = DVPov + " / " + readerPoverka["DateVidSPSI"].ToString();
                        ValidPov = ValidPov + " / " + readerPoverka["SrokSPSI"].ToString();
                    }
                    if (NumberIter == 2)
                    {
                        NSPov = NSPov + " / " + readerPoverka["NomSPSI"].ToString();
                        DVPov = DVPov + " / " + readerPoverka["DateVidSPSI"].ToString();
                        ValidPov = ValidPov + " / " + readerPoverka["SrokSPSI"].ToString();
                    }
                    NumberIter = NumberIter + 1;
                }
                readerPoverka.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            ////////////////////////////////////////////////////

            //////////////////////////////////////////
            //   формируем ГУИД для ангелов если его нет
            if (AngStat == 0)
            {
                AngStat = 1;
                INAng = Guid.NewGuid();
                GDAng = Convert.ToString(INAng);//.Replace("-", "");

                MySqlCommand command3 = new MySqlCommand();
                ConnectStr conStr3 = new ConnectStr();
                Zapros zapros3 = new Zapros();
                conStr3.ConStr(1);
                cstr = conStr3.StP;
                zapros3.ZUIDAng(IDTS, GDAng);
                MySqlConnection connection3 = new MySqlConnection(cstr);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                string z3 = zapros3.commandStringTest;
                cmd.CommandText = z3;
                cmd.Connection = connection3;
                connection3.Open();
                cmd.ExecuteNonQuery();
                connection3.Close();

            }


            /////////////////////////////////////////////
            if (KolOs > 1 && ObshMass != 0 && Ind != 4 && Ind != 14 && Ind != 17 && Cr11 == 0 && GRZ != "" && StatAng==0 && IDTS!= 3058932 && KolOs == KolZap)
            {
                try
                {
                    proc2(IDTS);              
                  
                    ////////////////////////////////////////////////////// Запрос класса ТС (левый)   //////////////////////////
                    if (data1.a[3] != "" && ImOb != null && data1.a[150] != "4" && data1.a[150] != "11" && data1.a[150] != "14" && data1.a[150] != "17" && data1.a[145] == "0" && ObshMass != 0 && data1.a[1] != "0")//&& ImPl,ImAlt )
                {
                    ZKL();
                      
                        //if (KLISPR != 0 && KLISPR != 1 /*&& KLISPR != 10 && KLISPR != 11*/ && data1.a[3] != "" && ImOb != null && data1.a[150] != "4" && data1.a[150] != "11" && data1.a[150] != "14" && data1.a[150] != "17"
                        //    && data1.a[145] == "0" && ObshMass != 0 && data1.a[1] != "0" && (Gross != "0" || Part != "0" || Group != "0" || siz != "0" /*|| speed != "0" */))//&& ImPl,ImAlt )
                        //{
                     PDKOs();
                    ZObPDK();
                    ZGabarPDK();
                     soap2();
                        //PDKOs();
                        for (i = 0; i < GrO; i++)
                        { if (data1.c[10, i] == null || data1.c[10, i] == "-") { data1.c[10, i] = "0"; } }
                        proc2(IDTS);
                        PDKOs();
                        ZObPDK();
                        ZGabarPDK();
                       
                        proc1();                                            
                }
                else if (data1.a[3] == "")
                {
                    if (data1.a[150] != "14")//&& ImPl,ImAlt )
                    {
                        MySqlCommand command1 = new MySqlCommand();
                        ConnectStr conStr1 = new ConnectStr();
                        conStr1.ConStr(1);
                        string connectionString1;
                        connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                        MySqlConnection connection1 = new MySqlConnection(connectionString1);
                        string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
                                    + "VALUES(" + IDpish + ", " + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + ", 14, 'проверка закочилась в автоматическом режиме с ошибкой (отсутствует распознанный ГРЗ)', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                        command1.CommandText = z1;
                        command1.Connection = connection1;
                        connection1.Open();
                        command1.ExecuteNonQuery();
                        command1.Connection.Close();

                        MySqlCommand command3 = new MySqlCommand();
                        ConnectStr conStr3 = new ConnectStr();
                        Zapros zapros3 = new Zapros();
                        conStr3.ConStr(1);
                        cstr = conStr3.StP;
                        zapros3.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), NamU, 14, "проверка закочилась в автоматическом режиме с ошибкой (отсутствует распознанный ГРЗ)", "0",0,"","","");
                        MySqlConnection connection3 = new MySqlConnection(cstr);
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        string z3 = zapros3.commandStringTest;
                        cmd.CommandText = z3;
                        cmd.Connection = connection3;

                        connection3.Open();
                        cmd.ExecuteNonQuery();
                        connection3.Close();
                    }

                }
                else if (data1.a[145] != "0")
                {
                   
                }
                else if (ImOb == null)
                {
                    if (data1.a[150] != "14")
                    {
                        MySqlCommand command1 = new MySqlCommand();
                        ConnectStr conStr1 = new ConnectStr();
                        conStr1.ConStr(1);
                        string connectionString1;
                        connectionString1 = conStr1.StP;
                        MySqlConnection connection1 = new MySqlConnection(connectionString1);
                        string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
      + "VALUES(" + IDpish + ", " + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + ", 14, 'проверка закочилась в автоматическом режиме с ошибкой (отсутствует фотофиксация ТС)', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                        command1.CommandText = z1;
                        command1.Connection = connection1;
                        connection1.Open();
                        command1.ExecuteNonQuery();
                        command1.Connection.Close();
                        MySqlCommand command3 = new MySqlCommand();
                        ConnectStr conStr3 = new ConnectStr();
                        Zapros zapros3 = new Zapros();
                        conStr3.ConStr(1);
                        cstr = conStr3.StP;
                        zapros3.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), "AUTO", 14, "проверка закочилась в автоматическом режиме с ошибкой (отсутствует фотофиксация ТС)", "0", 0,"","","");
                        MySqlConnection connection3 = new MySqlConnection(cstr);
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        string z3 = zapros3.commandStringTest;
                        cmd.CommandText = z3;
                        cmd.Connection = connection3;
                        connection3.Open();
                        cmd.ExecuteNonQuery();
                        connection3.Close();
                    }
                }
                }
                catch (MySqlException ex)
                { return; }
                finally
                { int w = 1; }
            }
            else if (KolOs > 1 && ObshMass != 0 && (Ind == 4 || Ind != 14 || Ind != 17) && Cr11 == 0 && GRZ != "" && StatAng==2)
            {
                proc2(IDTS);
                ////////////////////////////////////////////////////// Запрос класса ТС (левый)   //////////////////////////
                if (data1.a[3] != "" && ImOb != null /*&& data1.a[150] != "4" && data1.a[150] != "11" && data1.a[150] != "14" && data1.a[150] != "17"*/ && data1.a[145] == "0" && ObshMass != 0 && data1.a[1] != "0")//&& ImPl,ImAlt )
                {
                    ZKL();
                    PDKOs();
                    ZObPDK();
                    ZGabarPDK();
                    soap2();
                   
                    for (i = 0; i < GrO; i++)
                    { if (data1.c[10, i] == null || data1.c[10, i] == "-") { data1.c[10, i] = "0"; } }
                    proc2(IDTS);
                    PDKOs();
                    ZObPDK();
                    ZGabarPDK();
                    //if (data1.a[150] != "20")
                    //надо соап2 на последнее место, а потом добавить "иф ..... {снова все, но с новыми параметрами}"
                    { proc1(); }
                    //////////////////////////////////////////////////////// Запрос ПДК Общ массы
                    //////////////////////////////////////////////////////// Запрос ПДК Габаритов
                }
                else if (data1.a[3] == "")
                {
                    if (data1.a[150] != "14")//&& ImPl,ImAlt )
                    {
                        MySqlCommand command1 = new MySqlCommand();
                        ConnectStr conStr1 = new ConnectStr();
                        conStr1.ConStr(1);
                        string connectionString1;
                        connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                        MySqlConnection connection1 = new MySqlConnection(connectionString1);
                        string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
                                    + "VALUES(" + IDpish + ", " + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + ", 14, 'проверка закочилась в автоматическом режиме с ошибкой (отсутствует распознанный ГРЗ)', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                        command1.CommandText = z1;
                        command1.Connection = connection1;
                        connection1.Open();
                        command1.ExecuteNonQuery();
                        command1.Connection.Close();

                        MySqlCommand command3 = new MySqlCommand();
                        ConnectStr conStr3 = new ConnectStr();
                        Zapros zapros3 = new Zapros();
                        conStr3.ConStr(1);
                        cstr = conStr3.StP;
                        zapros3.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), NamU, 14, "проверка закочилась в автоматическом режиме с ошибкой (отсутствует распознанный ГРЗ)", "0", 0, "", "", "");
                        MySqlConnection connection3 = new MySqlConnection(cstr);
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        string z3 = zapros3.commandStringTest;
                        cmd.CommandText = z3;
                        cmd.Connection = connection3;

                        connection3.Open();
                        cmd.ExecuteNonQuery();
                        connection3.Close();
                    }

                }
                else if (data1.a[145] != "0")
                {

                }
                else if (ImOb == null)
                {
                    if (data1.a[150] != "14")
                    {
                        MySqlCommand command1 = new MySqlCommand();
                        ConnectStr conStr1 = new ConnectStr();
                        conStr1.ConStr(1);
                        string connectionString1;
                        connectionString1 = conStr1.StP;
                        MySqlConnection connection1 = new MySqlConnection(connectionString1);
                        string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
      + "VALUES(" + IDpish + ", " + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + ", 14, 'проверка закочилась в автоматическом режиме с ошибкой (отсутствует фотофиксация ТС)', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                        command1.CommandText = z1;
                        command1.Connection = connection1;
                        connection1.Open();
                        command1.ExecuteNonQuery();
                        command1.Connection.Close();
                        MySqlCommand command3 = new MySqlCommand();
                        ConnectStr conStr3 = new ConnectStr();
                        Zapros zapros3 = new Zapros();
                        conStr3.ConStr(1);
                        cstr = conStr3.StP;
                        zapros3.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), "AUTO", 14, "проверка закочилась в автоматическом режиме с ошибкой (отсутствует фотофиксация ТС)", "0", 0, "", "", "");
                        MySqlConnection connection3 = new MySqlConnection(cstr);
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        string z3 = zapros3.commandStringTest;
                        cmd.CommandText = z3;
                        cmd.Connection = connection3;
                        connection3.Open();
                        cmd.ExecuteNonQuery();
                        connection3.Close();
                    }
                }
            }
        }

        private void proc2(int IDTS)
        {
           
            MySqlCommand commandNSR = new MySqlCommand();
            ConnectStr conStrNSR = new ConnectStr();
            conStrNSR.ConStr(1);
            Zapros zaprosNSR = new Zapros();
            string connectionStringNSR;
            connectionStringNSR = conStrNSR.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connectionNSR = new MySqlConnection(connectionStringNSR);
            zaprosNSR.PrNalSR(IDTS);
            string zNSR = zaprosNSR.commandStringTest;
            commandNSR.CommandText = zNSR;// commandString;
            commandNSR.Connection = connectionNSR;
            MySqlDataReader readerNSR;
            int NSR = 0;
            try
            {
                commandNSR.Connection.Open();
                readerNSR = commandNSR.ExecuteReader();
                while (readerNSR.Read())
                {
                    NSR = 1;
                }
                readerNSR.Close();
            }
            catch (MySqlException ex)
            {
                NSR = 0;
                //Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                commandNSR.Connection.Close();
            }

            MySqlCommand command = new MySqlCommand();
            ConnectStr conStr = new ConnectStr();
            conStr.ConStr(1);
            Zapros zapros = new Zapros();
            string connectionString;
            connectionString = conStr.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            zapros.ZaprAllCamNaprLO(IDTS, NSR);
            string z = zapros.commandStringTest;
            //MySqlCommand command = new MySqlCommand(z);
            command.CommandText = z;// commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            int NumberIter = 0;
            KNn = new int[2, 10];
            KN = new int[2, 10];
            BetOs = new double[32, 10];
            int i1 = 0;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                double pos = 0;
                while (reader.Read())
                {
                    ///////////////////  BetOs[22,9]
                    //Index               -0
                    //Unit                -1
                    //Group               -2
                    //Position            -3
                    //Weight              -4
                    //WeightLeft          -5
                    //WeightRight         -6
                    //WeightLimit         -7
                    //WheelCount          -8
                    ////////FootprintWidthLeft  -9
                    ////////FootprintWidthRight -10
                    //IsOverweight        -9
                    //Speed               -10
                    //Credence            -11
                    //MeasurementStatus   -12
                    //вес с погрешностью
                    //разница ВсП и Лимита
                    //разница ВсП и Лимита в %
                    ///////////////////
                    #region/////////////// Проход по представлению от Бетамонта //
                     if (NumberIter == 0)
                    {
                        string io = Convert.ToString(Convert.ToInt32(reader["wheelCount"]) / 2);
                        string iio = Convert.ToString(Convert.ToDouble(reader["weightAxel"]) / 1000);
                        BetOs[0, 0] = 0;
                        BetOs[1, 0] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 0] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 0] = 0;
                        BetOs[4, 0] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 0] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 0] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 0] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 0] = 2; }
                            else { BetOs[8, 0] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 0] = 1; }
                        // BetOs[8, 0] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 0] = 0; }
                        else { BetOs[9, 0] = 1; }
                        BetOs[10, 0] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(4, 5));
                        BetOs[11, 0] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 0] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 0] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 0] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 0] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 0] = 0; }
                        BetOs[17, 0] = 0;
                    }
                    if (NumberIter == 1)
                    {
                        l[1] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                        D1_2 = l[1];
                        BetOs[0, 1] = 0;
                        BetOs[1, 1] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 1] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 1] = l[1];
                        BetOs[4, 1] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 1] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 1] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 1] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 1] = 2; }
                            else { BetOs[8, 1] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 1] = 1; }
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 1] = 0; }
                        else { BetOs[9, 1] = 1; }
                        BetOs[10, 1] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 1] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 1] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 1] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 1] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 1] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 1] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 1] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 1] = 0; }
                    }
                    if (NumberIter == 2)
                    {
                        l[2] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                        D2_3 = l[2];
                        BetOs[0, 2] = 0;
                        BetOs[1, 2] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 2] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 2] = l[2];
                        BetOs[4, 2] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 2] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 2] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 2] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 2] = 2; }
                            else { BetOs[8, 2] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 2] = 1; }
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 2] = 0; }
                        else { BetOs[9, 2] = 1; }
                        BetOs[10, 2] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 2] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 2] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 2] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 2] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 2] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 2] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 2] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 2] = 0; }
                    }
                    if (NumberIter == 3)
                    {
                        l[3] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                         D3_4 = l[3];
                        BetOs[0, 3] = 0;
                        BetOs[1, 3] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 3] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 3] = l[3];
                        BetOs[4, 3] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 3] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 3] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 3] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 3] = 2; }
                            else { BetOs[8, 3] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 3] = 1; }
                        //BetOs[8, 3] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 3] = 0; }
                        else { BetOs[9, 3] = 1; }
                        BetOs[10, 3] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 3] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 3] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 3] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 3] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 3] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 3] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 3] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 3] = 0; }
                    }
                    if (NumberIter == 4)
                    {
                         l[4] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                        D4_5 = l[4];
                        BetOs[0, 4] = 0;
                        BetOs[1, 4] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 4] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 4] = l[4];
                        BetOs[4, 4] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 4] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 4] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 4] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 4] = 2; }
                            else { BetOs[8, 4] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 4] = 1; }
                        //BetOs[8, 4] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 4] = 0; }
                        else { BetOs[9, 4] = 1; }
                        BetOs[10, 4] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 4] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 4] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 4] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 4] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 4] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 4] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 4] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 4] = 0; }
                    }
                    if (NumberIter == 5)
                    {
                        l[5] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                        D5_6 = l[5];
                        BetOs[0, 5] = 0;
                        BetOs[1, 5] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 5] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 5] = l[5];
                        BetOs[4, 5] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 5] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 5] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 5] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 5] = 2; }
                            else { BetOs[8, 5] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 5] = 1; }
                        //BetOs[8, 5] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 5] = 0; }
                        else { BetOs[9, 5] = 1; }
                        BetOs[10, 5] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 5] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 5] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 5] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 5] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["Os6M"]) != null && Convert.ToString(reader["Os6M"]) != "" && Convert.ToString(reader["Os6M"]) != " ")
                        { BetOs[16, 5] = Convert.ToDouble(reader["Os6M"]); }
                        else { BetOs[16, 5] = 0; }
                        if (Convert.ToString(reader["AxInt5"]) != null && Convert.ToString(reader["AxInt5"]) != "" && Convert.ToString(reader["AxInt5"]) != " ")
                        { BetOs[17, 5] = Convert.ToDouble(reader["AxInt5"]); }
                        else { BetOs[17, 5] = 0; }
                    }
                    if (NumberIter == 6)
                    {
                        l[6] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                         D6_7 = l[6];
                        BetOs[0, 6] = 0;
                        BetOs[1, 6] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 6] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 6] = l[6];
                        BetOs[4, 6] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 6] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 6] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 6] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 6] = 2; }
                            else { BetOs[8, 6] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 6] = 1; }
                        //BetOs[8, 6] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 6] = 0; }
                        else { BetOs[9, 6] = 1; }
                        BetOs[10, 6] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 6] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 6] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 6] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 6] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 6] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 6] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 6] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 6] = 0; }
                    }
                    if (NumberIter == 7)
                    {
                        l[7] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                        D7_8 = l[7];
                        BetOs[0, 7] = 0;
                        BetOs[1, 7] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 7] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 7] = l[7];
                        BetOs[4, 7] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 7] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 7] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 7] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 7] = 2; }
                            else { BetOs[8, 7] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 7] = 1; }
                        //BetOs[8, 7] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 7] = 0; }
                        else { BetOs[9, 7] = 1; }
                        BetOs[10, 7] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 7] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 7] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 7] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 7] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 7] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 7] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 7] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 7] = 0; }
                    }
                    if (NumberIter == 8)
                    {
                       l[8] = (Convert.ToDouble(reader["position"]) / 100) - pos;
                        pos = Convert.ToDouble(reader["position"]) / 100;
                        BetOs[0, 8] = 0;
                        BetOs[1, 8] = Convert.ToDouble(reader["Unit"]);
                        BetOs[2, 8] = Convert.ToDouble(reader["Group"]);
                        BetOs[3, 8] = l[8];
                        BetOs[4, 8] = Convert.ToDouble(reader["weightAxel"]);
                        BetOs[5, 8] = Convert.ToDouble(reader["weightleft"]);
                        BetOs[6, 8] = Convert.ToDouble(reader["weightright"]);
                        BetOs[7, 8] = Convert.ToDouble(reader["weightlimitAxel"]);
                        if (reader["wheelcount"] != null && Convert.ToDouble(reader["wheelcount"]) > 1)
                        {
                            if (Convert.ToDouble(reader["wheelcount"]) / 2 > 2)
                            { BetOs[8, 8] = 2; }
                            else { BetOs[8, 8] = Convert.ToDouble(reader["wheelcount"]) / 2; }
                        }
                        else
                        { BetOs[8, 8] = 1; }
                        // BetOs[8, 8] = Convert.ToDouble(reader["wheelcount"]) / 2;
                        if (reader["isoverweightAxel"].ToString() == "false")
                        { BetOs[9, 8] = 0; }
                        else { BetOs[9, 8] = 1; }
                        BetOs[10, 8] = Convert.ToDouble(reader["SpeedAxel"].ToString());//.Substring(5, 9));
                        BetOs[11, 8] = Convert.ToDouble(reader["credenceAxel"]);
                        BetOs[13, 8] = Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10;
                        BetOs[14, 8] = (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10) - Convert.ToDouble(reader["weightlimitAxel"]);
                        BetOs[15, 8] = (Convert.ToDouble(reader["weightlimitAxel"]) / (Convert.ToDouble(reader["weightAxel"]) - Convert.ToDouble(reader["weightAxel"]) / 100 * 10)) * 100;
                        if (Convert.ToString(reader["MasAxSR"]) != null && Convert.ToString(reader["MasAxSR"]) != "" && Convert.ToString(reader["MasAxSR"]) != " ")
                        { BetOs[16, 8] = Convert.ToDouble(reader["MasAxSR"]); }
                        else { BetOs[16, 8] = 0; }
                        if (Convert.ToString(reader["IntervalAxSR"]) != null && Convert.ToString(reader["IntervalAxSR"]) != "" && Convert.ToString(reader["IntervalAxSR"]) != " ")
                        { BetOs[17, 8] = Convert.ToDouble(reader["IntervalAxSR"]); }
                        else { BetOs[17, 8] = 0; }
                    }


                    KNn[0, i1] = Convert.ToInt32(reader["group"]);
                    i1 = i1 + 1;
                    TSh = TSh + Convert.ToString(reader["group"]);
                    NumberIter = NumberIter + 1;

                    IDW = Convert.ToInt64(reader["ID_wim"].ToString());
                    PLN = reader["PlatformId"].ToString();
                    IDpish = Convert.ToInt64(reader["ID_wim"]);
                    #endregion///////////////////////////////////////////////////

                    #region //////////////////////////////////////////////        Заполнение переменных для рисунка  осей             /////////////////////////////////
                     data1.a[40] = "-";
                    if (reader["Class3"] != DBNull.Value)
                    {  NPicKR = Convert.ToInt64(reader["Class3"]);  }
                    else
                    {     NPicKR = 0;   }
                    KolOs = Convert.ToInt32(reader["AxleCount"].ToString());
                    ObshMass = Convert.ToInt32(reader["Weight"].ToString());
                    data1.a[1] = Convert.ToString(Math.Round(Convert.ToDouble(reader["AxleCount"].ToString())));

                    if (reader["KlNew"].ToString().Length > 0)
                    { data1.a[2] = reader["KlNew"].ToString();
                        data1.a[252] = reader["SubKateg"].ToString();
                    }                    
                    else { data1.a[2] = "12";
                        data1.a[252] = "-";
                    }


                    //if (reader["Class2"].ToString().Length > 3)
                    //{ data1.a[2] = reader["Class2"].ToString().Substring(0, 2); }
                    //else if (reader["Class2"].ToString().Length == 3)
                    //{ data1.a[2] = reader["Class2"].ToString().Substring(0, 1); }
                    //else { data1.a[2] = "12"; }

                    //data1.a[2] = Convert.ToString(Math.Round(Convert.ToDouble(reader["Class"].ToString())));
                    if (Convert.ToInt64(reader["PlatformId"].ToString()) == 2952855555)
                    { NRUB = "PK2"; }
                    else { NRUB = "PK1"; }
                    if (Convert.ToInt64(reader["PlatformId"].ToString()) == 2952855555)
                    { CPC = "2920002"; }
                    else if (Convert.ToInt64(reader["PlatformId"].ToString()) == 2952855553)
                    { CPC = "2920001"; }
                    else
                    { CPC = reader["PlatformId"].ToString(); }
                    if (reader["StatAng"].ToString() != "0")
                    {
                        GRZ = reader["OldGRZ"].ToString();
                        data1.a[3] = reader["OldGRZ"].ToString();
                        if (reader["PlateConfidence"].ToString() == "0")
                        {   data1.a[244] = reader["PlateRear"].ToString();}
                        else
                        { data1.a[244] = reader["Plate"].ToString();}
                    }
                    else
                    {
                        if (reader["PlateConfidence"].ToString() == "0")
                        {
                            GRZ = reader["PlateRear"].ToString();
                            data1.a[3] = reader["PlateRear"].ToString();
                        }
                        else
                        {
                            GRZ = reader["Plate"].ToString();
                            data1.a[3] = reader["Plate"].ToString();
                        }
                    }
                    data1.a[238] = Convert.ToDateTime(reader["Created"].ToString()).ToString("yyyyMMdd");
                    data1.a[4] = reader["ID"].ToString();
                    data1.a[5] = reader["Speed"].ToString();
                    data1.a[6] = reader["datepr"].ToString().Substring(0, 10);
                    data1.a[7] = reader["timepr"].ToString();
                    data1.a[8] = reader["Created"].ToString();
                    if (Convert.ToInt32(reader["StatAng"].ToString()) == 0)
                    {
                        data1.a[240] = reader["StatAng"].ToString();// Статус Ангелов - 0 нет подтверждения 1 проверено без подтверждения 2 пришло подтверждение 3 проверено с подтверждением
                        StatAng = Convert.ToInt32(reader["StatAng"].ToString());
                        data1.a[241] = " ";// новый номер
                        data1.a[242] = " ";// кто и когда
                    }
                    else if (Convert.ToInt32(reader["StatAng"].ToString()) == 2)
                    {
                        data1.a[240] = reader["StatAng"].ToString();// Статус Ангелов - 0 нет подтверждения 1 проверено без подтверждения 2 пришло подтверждение 3 проверено с подтверждением
                        StatAng = Convert.ToInt32(reader["StatAng"].ToString());
                        data1.a[241] = reader["OldGRZ"].ToString();// новый номер
                        data1.a[242] = reader["NaimKlNew"].ToString();// кто и когда
                    }
                    DT = data1.a[8];
                    Lpr = Convert.ToDecimal(reader["Length"].ToString());
                    Hpr = Convert.ToDecimal(reader["Width"].ToString());
                    Wpr = Convert.ToDecimal(reader["Height"].ToString());
                    Cl = Convert.ToInt32(reader["Class2"].ToString());
                    XDate[0] = reader["IsOverweightPartial"].ToString();
                    XDate[1] = reader["IsOverweight"].ToString();
                    XDate[2] = reader["IsExceededLength"].ToString();
                    XDate[3] = reader["IsExceededWidth"].ToString();
                    XDate[4] = reader["IsExceededHeight"].ToString();
                    data1.a[9] = reader["nameapvk"].ToString();//Наименование комплекса
                    data1.a[10] = reader["Vladel"].ToString();//Владелец комплекса
                    data1.a[11] = reader["TipSI"].ToString();//Тип СИ комплекса
                    data1.a[12] = reader["Model"].ToString();//Марка и модель комплекса
                    data1.a[13] = reader["sernum"].ToString();//Заводской № комплекса
                    if (Convert.ToInt64(reader["PlatformId"].ToString()) == 2952855555)
                    { data1.a[14] = "2920002"; }
                    else if (Convert.ToInt64(reader["PlatformId"].ToString()) == 2952855553)
                    { data1.a[14] = "2920001"; }
                    else
                    { data1.a[14] = reader["PlatformId"].ToString(); }
                    data1.a[15] = reader["NomSvidTipaSI"].ToString();//№ свид.типа комплекса
                    data1.a[16] = reader["DateVidSTSI"].ToString();//Дата выд СТК № комплекса
                    data1.a[17] = reader["RegNomSTSI"].ToString();//Рег№ СТК комплекса
                    data1.a[18] = reader["NomSPSI"].ToString();//№ свид.о поверке комплекса
                    data1.a[19] = reader["DateVidSPSI"].ToString();//Дата выд СПК № комплекса
                    data1.a[20] = reader["SrokSPSI"].ToString();//Срок СПК комплекса
                    data1.a[21] = reader["namead"].ToString();//№ и назван дороги
                    data1.a[22] = reader["ad_znachen"].ToString();//значение дороги
                    data1.a[23] = reader["CheckPointCode"].ToString();//уникальный код комплекса
                    data1.a[24] = reader["KodNapr"].ToString();//код направления
                    data1.a[25] = reader["shir"].ToString();//код направления
                    data1.a[26] = reader["dolg"].ToString();//код направления
                    data1.a[27] = reader["dislocationapvk"].ToString();//Дислокация дороги
                    data1.a[28] = "D: " + reader["dolg"].ToString() + " ; Sh: " + reader["shir"].ToString();//Географ координаты дороги
                    data1.a[29] = reader["partad"].ToString();//Контролируемый участок дороги
                    data1.a[30] = reader["namenapr"].ToString();//Направление дороги
                    data1.a[31] = reader["npolos"].ToString();//№ полосы дороги
                    data1.a[32] = reader["maxosnagr"].ToString();//Макс ос. нагр. дороги
                    data1.a[145] = reader["CredenceExceeded"].ToString();
                    ADNagr = Convert.ToDouble(data1.a[32].ToString());
                    //// ПО С/РАЗР ДАТА И НОМЕР ЗАПРОСА
                    data1.a[200] = reader["DateZapr"].ToString();
                    data1.a[201] = reader["NomZapr"].ToString();
                    if (Convert.ToDateTime(reader["SrokSPSI"].ToString()) >= DateTime.Now)
                    { PrevNar[25] = 1; }
                    else { PrevNar[25] = 0; }
                    PrevNar[26] = Convert.ToInt32(reader["AxleCount"].ToString());

                    if (reader["maxosnagr"].ToString() == "6")
                    { XDate[5] = "1"; }
                    else if (reader["maxosnagr"].ToString() == "10")
                    { XDate[5] = "2"; }
                    else if (reader["maxosnagr"].ToString() == "11.5")//|| reader["maxosnagr"].ToString() == "11,5")
                    { XDate[5] = "3"; }
                    if (reader["SpeedRubej"].ToString() == "0")
                    {
                        XDate[6] = "";
                        XDate[7] = "0";
                        XDate[8] = "False";
                    }
                    if (reader["SpeedRubej"].ToString() != "0")
                    {
                        XDate[6] = reader["SpeedRubej"].ToString();
                        if (Convert.ToDouble(reader["Speed"].ToString()) - Convert.ToDouble(reader["SpeedRubej"].ToString()) > 0)
                        {
                            XDate[7] = Convert.ToString(Convert.ToDouble(reader["Speed"].ToString()) - Convert.ToDouble(reader["SpeedRubej"].ToString()));
                            XDate[8] = "True";
                            SPEED_ALL[0] = "-2"; SPEED_ALL[1] = reader["Speed"].ToString(); SPEED_ALL[2] = Convert.ToString(Convert.ToDouble(reader["Speed"].ToString()) - 2);
                            SPEED_ALL[3] = reader["SpeedRubej"].ToString(); SPEED_ALL[6] = XDate[7].ToString();
                            SPEED_ALL[5] = Convert.ToString(Math.Round(Convert.ToDouble(reader["Speed"].ToString()) / Convert.ToDouble(reader["SpeedRubej"].ToString()) * 100 - 100, 0));
                        }

                        if (Convert.ToDouble(reader["Speed"].ToString()) - Convert.ToDouble(reader["SpeedRubej"].ToString()) <= 0)
                        {
                            XDate[7] = "0";
                            XDate[8] = "False";
                            SPEED_ALL[0] = "-2"; SPEED_ALL[1] = reader["Speed"].ToString(); SPEED_ALL[2] = Convert.ToString(Convert.ToDouble(reader["Speed"].ToString()) - 2);
                            SPEED_ALL[3] = reader["SpeedRubej"].ToString(); SPEED_ALL[6] = "-";
                            SPEED_ALL[5] = "-";
                        }
                    }
                    else
                    {
                        SPEED_ALL[0] = "-2"; SPEED_ALL[1] = reader["Speed"].ToString(); SPEED_ALL[2] = Convert.ToString(Convert.ToDouble(reader["Speed"].ToString()) - 2);
                        SPEED_ALL[3] = "-"; SPEED_ALL[6] = "-";
                        SPEED_ALL[5] = "-";
                    }
                    ///////////////////////////////// Данные о СР
                    Nzapr = "";
                    //string PrNS = reader["PriznNal"].ToString();
                    //if (PrNS != "" || reader["PriznNal"].ToString() != "False" )
                    //{ int PrN = Convert.ToInt32(reader["PriznNal"].ToString()); }
                    if (reader["PriznNal"].ToString() == "0" || reader["PriznNal"].ToString() == "False" || reader["PriznNal"].ToString() == null || reader["PriznNal"].ToString() == "")
                    {
                        
                        XDate[12] = "False";
                        //data1.a[33] = XDate[12].ToString();
                        XDate[13] = "";
                        data1.a[33] = "Не выдавалось";//XDate[12].ToString();
                        PrevNar[29] = 1;
                        XDate[14] = "";
                        XDate[15] = "";
                        XDate[16] = "";
                        XDate[17] = "";
                        XDate[18] = "";
                        XDate[19] = "0";
                        XDate[20] = "0";
                        XDate[21] = "0";
                        XDate[26] = "0";
                        SPEED_ALL[4] = "-";
                    }
                    else
                    {
                        XDate[12] = reader["PriznNal"].ToString();
                        data1.a[33] = "Выдано";//XDate[12].ToString();
                        PrevNar[29] = 2;
                        XDate[13] = reader["NomSR"].ToString();
                        data1.a[34] = XDate[13].ToString();
                        XDate[14] = reader["dateregsr"].ToString();

                        if (reader["VidPerevoz"].ToString() == "Local")
                        { data1.a[35] = "региональная"; }
                        if (reader["VidPerevoz"].ToString() == "Interregional")
                        { data1.a[35] = "межрегиональная"; }
                        if (reader["VidPerevoz"].ToString() == "International")
                        { data1.a[35] = "международная"; }

                       // data1.a[35] = reader["VidPerevoz"].ToString();
                        data1.a[36] = reader["GRZSR"].ToString();
                        data1.a[37] = reader["RazrMarshr"].ToString();
                        data1.a[38] = reader["OsjbUslDvSR"].ToString();
                        data1.a[39] = reader["KolRazrPr"].ToString();
                        data1.a[40] = reader["IspolzPR"].ToString();

                        XDate[15] = reader["KemVid"].ToString();
                        data1.a[41] = XDate[15].ToString();
                        XDate[16] = reader["DateVidSR"].ToString();
                        data1.a[42] = XDate[16].ToString();
                        XDate[17] = reader["SrokDeistvSR"].ToString();
                        data1.a[43] = XDate[17].ToString();
                        XDate[18] = reader["NarushenMarshrSR"].ToString();
                        XDate[19] = reader["LengthSR"].ToString();
                        XDate[20] = reader["WidthSR"].ToString();
                        if (reader["SpeedSR"].ToString() != "0")
                        {
                            SPEED_ALL[4] = reader["SpeedSR"].ToString();
                            if (Convert.ToDouble(reader["Speed"].ToString()) - 2 - Convert.ToDouble(reader["SpeedSR"].ToString()) > 0)
                            {
                                //XDate[7] = Convert.ToString(Convert.ToDouble(reader["Speed"].ToString()) - 2 - Convert.ToDouble(reader["SpeedRubej"].ToString()));
                                XDate[8] = "True";
                                SPEED_ALL[6] = Convert.ToString(Convert.ToDouble(reader["Speed"].ToString()) - 2 - Convert.ToDouble(reader["SpeedSR"].ToString()));
                                SPEED_ALL[5] = Convert.ToString(Math.Round(Convert.ToDouble(reader["Speed"].ToString()) / Convert.ToDouble(reader["SpeedSR"].ToString()) * 100 - 100, 0));
                            }
                            if (Convert.ToDouble(reader["Speed"].ToString()) - Convert.ToDouble(reader["SpeedSR"].ToString()) <= 0)
                            {
                                XDate[7] = "0";
                                XDate[8] = "False";
                                SPEED_ALL[6] = "-";
                                SPEED_ALL[5] = "-";
                            }
                        }
                        XDate[21] = reader["HeightSR"].ToString();
                        XDate[23]= reader["NomZapr"].ToString();
                        data1.a[243] = XDate[23].ToString();
                        Nzapr= XDate[23].ToString();
                    if (reader["RazrMassa"].ToString() != null && reader["RazrMassa"].ToString() != "" && reader["RazrMassa"].ToString() != " ")
                    { XDate[26] = reader["RazrMassa"].ToString(); }
                    else { XDate[26] = "0"; }

                    }
                    XDate[25] = ((Convert.ToDouble(reader["Weight"].ToString()) - (Convert.ToDouble(reader["Weight"].ToString()) / 100 * 5)) / 1000).ToString();
                    

                    data1.a[44] = reader["NormPravAktAD"].ToString();//Нормативн акт дороги
                    data1.a[45] = reader["ogranich"].ToString();//особ. условия. дороги
                    data1.a[150] = reader["ChangeType"].ToString();

                    data1.a[5] = "" + reader["Speed"].ToString() + " км/ч";// reader["velocity"].ToString();//скорость
                                                                           //  alphaBlendTextBox68.Text = reader["ogranich"].ToString();//особ. условия. дороги
                    for (int iDist = 1; iDist < KolOs + 1; iDist++)
                    {
                        D111[iDist] = BetOs[3, iDist];
                    }
                   
                    #endregion //////////////////////////////////////////////
                    //////////////////////////////////////////////////////////////////////////////////////////////
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }

            MySqlCommand command11 = new MySqlCommand();
            ConnectStr conStr11 = new ConnectStr();
            conStr11.ConStr(1);
            Zapros zapros11 = new Zapros();
            string connectionString11;
            connectionString11 = conStr11.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection11 = new MySqlConnection(connectionString11);
            zapros11.CB(IDpish);
            string z11 = zapros11.commandStringTest;
            //MySqlCommand command = new MySqlCommand(z);
            command11.CommandText = z11;// commandString;
            command11.Connection = connection11;

            MySqlDataReader readerLB11;
            try
            {
                command11.Connection.Open();
                readerLB11 = command11.ExecuteReader();
                 while (readerLB11.Read())
                {
                    ColPicKR = Convert.ToInt32(readerLB11["CB"]);
                }
                readerLB11.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command11.Connection.Close();
            }

            zLB = "SELECT " +
       "binarycontainer_n.*, " +
       "binarycontainer_n.ID_PR " +
       "FROM binarycontainer_n " +
       "WHERE binarycontainer_n.ID_PR = " + IDW + " AND platformid = " + PLN + ";";
            MySqlCommand commandLB = new MySqlCommand();
            ConnectStr conStrLB = new ConnectStr();
            conStrLB.ConStr(1);
            Zapros zaprosLB = new Zapros();
            string connectionStringLB;//, commandString;
            connectionStringLB = conStrLB.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connectionLB = new MySqlConnection(connectionStringLB);
            commandLB.CommandText = zLB;// commandString;
            commandLB.Connection = connectionLB;
            MySqlDataReader readerLB;
            try
            {
                commandLB.Connection.Open();
                readerLB = commandLB.ExecuteReader();
                while (readerLB.Read())
                {
                    if (readerLB["name"].ToString() != "Video")
                    {

                        // try
                        // {
                        //     if (readerLB["name"].ToString() == "Image")
                        //     {
                        //         string st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //       //  Im = new Bitmap(@"" + st9);
                        //     }
                        // }
                        // catch (MySqlException ex)
                        //{ return; }
                        // finally
                        // { int w = 1; }
                        //try
                        //{
                        //    if (readerLB["name"].ToString() == "ImgPlate")
                        //    {
                        //        string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //        ImPl = new Bitmap(@"" + st9);
                        //    }
                        //}
                        //catch (MySqlException ex)
                        //{ return; }
                        //finally
                        //{ int w = 1; }
                        //// try{ if (readerLB["name"].ToString() == "ImageAlt")

                        // {
                        //     string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        ////     ImAlt = new Bitmap(@"" + st9);
                        //     }
                        // }
                        // catch (MySqlException ex)  { return; }
                        // finally  { int w = 1; }
                        //if (readerLB["name"].ToString() == "ScanS")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    SkS = new Bitmap(@"" + st9);
                        //}
                        //if (readerLB["name"].ToString() == "ImageAlt1")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    ImAlt1 = new Bitmap(@"" + st9);
                        //}
                        //if (readerLB["name"].ToString() == "ImageAlt2")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    ImAlt2 = new Bitmap(@"" + st9);
                        //}
                        //if (readerLB["name"].ToString() == "Image1")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    Im1 = new Bitmap(@"" + st9);
                        //}
                        //if (readerLB["name"].ToString() == "Image2")
                        //{
                        //    string st9 = readerLB["dataavailable"].ToString();
                        //    Im2 = new Bitmap(@"" + st9);
                        //}
                        //if (readerLB["name"].ToString() == "ScanF")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    SkF = new Bitmap(@"" + st9);
                        //}
                        //if (readerLB["name"].ToString() == "ScanT")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    SkT = new Bitmap(@"" + st9);
                        //}
                        //try { if (readerLB["name"].ToString() == "ImageRea")
                        //{
                        //    string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //    //ImR = new Bitmap(@"" + st9);
                        //    }
                        //}
                        //catch (MySqlException ex) { return; }
                        //finally { int w = 1; }
                        try
                        {
                            if (readerLB["name"].ToString() == "ImgObj")
                            {
                                string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                                ImOb = new Bitmap(@"" + st9);
                            }
                        }
                        catch (MySqlException ex) { return; }
                        finally { int w = 1; }
                        ////try
                        ////{
                        ////    if (readerLB["name"].ToString() == "ReaAlt")
                        ////    {
                        ////        string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        ////        //ImAltR = new Bitmap(@"" + st9);
                        ////    }
                        ////}
                        ////catch (MySqlException ex) { return; }
                        ////finally { int w = 1; }
                        //try
                        //{
                        //    if (readerLB["name"].ToString() == "ReaObj")
                        //    {
                        //        string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //        ImROb = new Bitmap(@"" + st9);
                        //    }
                        //}
                        //catch (MySqlException ex) { return; }
                        //finally { int w = 1; }
                        //try
                        //{
                        //    if (readerLB["name"].ToString() == "ReaPlate")
                        //    {
                        //        string st9 = st9 = readerLB["dataavailable"].ToString();//@"X:\" + readerLB["dataavailable"].ToString().Substring(13, readerLB["dataavailable"].ToString().Length - 13);//
                        //        ImPlR = new Bitmap(@"" + st9);
                        //    }
                        //}
                        //catch (MySqlException ex) { return; }
                        //finally { int w = 1; }
                    }
                }
                readerLB.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                commandLB.Connection.Close();
            }
            #region От старой программы - позже к этому вернемся
            #region ///// Заполнение переменных о выбранном проезде для определения класса и расчета ПДК :)
            AC = new int[KolOs];
                if (KolOs != 0)
                {
                    AI = new decimal[(KolOs)];// - 1)];
                }
                AL = new decimal[KolOs];

                for (ic = 1; ic < KolOs + 1; ic++)
                {
                    //AC[ic - 1] = ic;
                    if (ic <= KolOs)
                    {
                        AI[ic - 1] = Convert.ToDecimal(BetOs[3, ic]);
                    }
                    AL[ic - 1] = Convert.ToDecimal(Math.Round((BetOs[4, ic - 1] - BetOs[4, ic - 1] / 100 * 10) / 1000, 3));
                    DT = data1.a[8];
                    Dc = 1;
                    TW = Convert.ToDecimal(ObshMass) / 1000;
                    if (Hpr != 0)
                    {
                        H = Hpr / 100;
                    }
                    else { H = 0; }
                    if (Lpr != 0)
                    {
                        L = Lpr / 100;
                    }
                    else { L = 0; }
                    if (Wpr != 0)
                    {
                        W = Wpr / 100;
                    }
                    else { W = 0; }
                }
                for (ic = 1; ic < KolOs + 1; ic++)
                    if (ic < 9)
                    {
                        if (l[ic] > 0)
                        {
                            D[ic] = (l[ic] + 0.03);
                        if (D[ic] < 2.5 && D[ic - 1] > 0 && D[ic] - D[ic - 1] < 0.8 && D[ic] > 2.36)
                        { D[ic] = D[ic] + (2.5 - D[ic]); }
                    }
                        DoubO[ic] = (Convert.ToInt32(BetOs[8, ic - 1]));
                        switch (ic)
                        {
                            case 1:
                                if (D[ic] >= 2.5)
                                { TypO[ic] = 1; }
                                else if (D[ic] > 0 && D[ic] < 2.5)
                                {
                                    if (KolOs == 2)
                                    {
                                        TypO[ic] = 1;
                                    }
                                    else
                                    {
                                        TypO[ic] = 2;
                                    }
                                }
                                break;
                            case 2:
                                if (D[ic] >= 2.5)
                                {
                                    if (D[ic - 1] >= 2.5)
                                    { TypO[ic] = 1; }
                                    else if (D[ic - 1] > 0 && D[ic - 1] < 2.5)
                                    {
                                        TypO[ic] = 2;
                                    }
                                }
                                else if (D[ic] > 0 && D[ic] < 2.5)
                                {
                                    if (D[ic - 1] >= 2.5)
                                    { TypO[ic] = 2; }
                                    else if (D[ic - 1] > 0 && D[ic - 1] < 2.5)
                                    {
                                        TypO[ic] = 3;
                                        TypO[ic - 1] = 3;
                                    }
                                }
                                if (KolOs == 2)
                                {
                                    TypO[ic] = 1;
                                }
                                break;
                            case 3:
                                if (D[ic] >= 2.5)
                                {
                                    if (D[ic + 1] >= 2.5)
                                    {
                                        if (D[ic - 1] >= 2.5)
                                        {
                                            TypO[ic] = 1;
                                        }
                                        else if (D[ic - 1] > 0 && D[ic - 1] < 2.5)
                                        {
                                            if (D[ic - 2] > 0 && D[ic - 2] < 2.5)
                                            {
                                                TypO[ic] = 3;
                                                TypO[ic - 1] = 3;
                                                TypO[ic - 2] = 3;
                                            }
                                            else
                                            {
                                                TypO[ic] = 2; TypO[ic - 1] = 2;
                                            }
                                        }
                                    }
                                    else if (D[ic + 1] >= 0 && D[ic + 1] < 2.5)
                                    {
                                        if (D[ic - 1] >= 2.5)
                                        { TypO[ic] = 1; }
                                        else if (D[ic - 1] > 0 && D[ic - 1] < 2.5)
                                        {
                                            if (D[ic - 2] > 0 && D[ic - 2] < 2.5)
                                            {
                                                TypO[ic] = 3;
                                                TypO[ic - 1] = 3;
                                                TypO[ic - 2] = 3;
                                            }
                                            else { TypO[ic] = 2; TypO[ic - 1] = 2; }
                                        }
                                    }
                                }
                                else if (D[ic] >= 0 && D[ic] < 2.5)
                                {
                                    if (D[ic - 1] >= 2.5)
                                    { TypO[ic] = 2; }
                                    else if (D[ic - 1] > 0 && D[ic - 1] < 2.5)
                                    {
                                        if (D[ic - 2] > 0 && D[ic - 2] < 2.5)
                                        {
                                            if (D[ic] == 0)
                                            { TypO[ic] = 3; TypO[ic - 1] = 3; TypO[ic - 2] = 3; break; }
                                            else { TypO[ic] = 4; TypO[ic - 1] = 4; TypO[ic - 2] = 4; }
                                        }
                                        else
                                        {
                                            if (D[ic] == 0)
                                            { TypO[ic] = 2; TypO[ic - 1] = 2; break; }
                                            else { TypO[ic] = 3; TypO[ic - 1] = 3; }
                                        }
                                    }
                                }
                                break;

                            default:
                                if (D[ic] >= 2.50)
                                {
                                    if (D[ic - 1] >= 2.50)
                                    { TypO[ic] = 1; }
                                    else if (D[ic - 1] > 0 && D[ic - 1] < 2.50)
                                    {
                                        if (D[ic - 2] > 0 && D[ic - 2] < 2.50)
                                        {
                                            if (D[ic - 3] > 0 && D[ic - 3] < 2.50)
                                            {
                                                TypO[ic] = 4; TypO[ic - 1] = 4; TypO[ic - 2] = 4; TypO[ic - 3] = 4;
                                            }
                                            else { TypO[ic] = 3; TypO[ic - 1] = 3; TypO[ic - 2] = 3; }
                                        }
                                        else { TypO[ic] = 2; TypO[ic - 1] = 2; }
                                    }
                                }
                                else if (D[ic] >= 0 && D[ic] < 2.50)
                                {
                                    if (D[ic - 1] >= 2.50)
                                    {
                                        if (D[ic] == 0)
                                    {
                                        if (D[ic - 2] > 0 && D[ic - 2] < 2.50)
                                        {
                                            TypO[ic] = 1; break;
                                        }
                                        else
                                        { TypO[ic] = 1; TypO[ic - 1] = 1; break; }
                                    }
                                        else
                                        { TypO[ic] = 2; }
                                    }
                                    else if (D[ic - 1] > 0 && D[ic - 1] < 2.50)
                                    {
                                        if (D[ic - 2] > 0 && D[ic - 2] < 2.50)
                                        {
                                            if (D[ic - 3] > 0 && D[ic - 3] < 2.50)
                                            {
                                                if (D[ic] == 0)
                                                { TypO[ic] = 4; TypO[ic - 1] = 4; TypO[ic - 2] = 4; TypO[ic - 3] = 4; break; }
                                                else { TypO[ic] = 4; TypO[ic - 1] = 4; TypO[ic - 2] = 4; TypO[ic - 3] = 4; }
                                            }
                                            else
                                            {
                                                if (D[ic] == 0)
                                                { TypO[ic] = 3; TypO[ic - 1] = 3; TypO[ic - 2] = 3; break; }
                                                else { TypO[ic] = 4; TypO[ic - 1] = 4; TypO[ic - 2] = 4; }
                                            }
                                        }
                                        else
                                        {
                                            if (D[ic] == 0)
                                            { TypO[ic] = 2; TypO[ic - 1] = 2; break; }
                                            else { TypO[ic] = 3; TypO[ic - 1] = 3; }
                                        }
                                    }
                                    else
                                    {
                                        if (D[ic] == 0)
                                        { TypO[ic] = 1; TypO[ic - 1] = 1; break; }
                                    }
                                }
                                break;
                        }
                    }
                for (i=1; i<KolOs+1; i++)
            {
                AC[i - 1] = Convert.ToInt32(DoubO[i]*2);
            }
                for (ic = KolOs + 1; ic < 9; ic++)
                {
                    D[ic] = 0;
                    DoubO[ic] = 0;
                    TypO[ic] = 0;
                }

                names2 = new string[KolOs];
                names3 = new names[KolOs];
                for (int KO = 1; KO <= KolOs; KO++)
                {
                    if (KO < 9)
                    {
                        D111[KO] = BetOs[3, KO];
                        if (KO != KolOs)
                        {
                            names2[KO - 1] = Convert.ToString(BetOs[3, KO] / 100);
                        }
                    }
                }
                DLINATS = Convert.ToDouble(Lpr.ToString());
                SHIRTS = Convert.ToDouble(Hpr.ToString());
                VISTS = Convert.ToDouble(Wpr.ToString());
                #endregion ////////////////////////////////////////////////////////////////////////////////////////////////////

                #region                   //////////////////////////      заполнение таблицы данными о ТС      ////////////////////////////
                if (KolOs > 0)
                {
                    GrO = 0;
                    RowCountB = KolOs;
                    for (ic = 0; ic < (KolOs); ic++)
                    {
                        names3[ic].massFact = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 3));
                        if (ic > 0)
                        {
                            names3[ic].BaseDistance = Convert.ToString(Math.Round(BetOs[3, ic],2));
                        }
                        else { names3[ic].BaseDistance = "0"; }
                        names3[ic].BaseNumber = Convert.ToString(ic + 1);
                        //names3[ic].groupNumber = Convert.ToString(GrO + 1);
                        names3[ic].skatnost = Convert.ToString(Convert.ToInt32(BetOs[8, ic]) + "/" + (Convert.ToInt32(BetOs[8, ic])) * 2);
                        names3[ic].BaseDistanceSR = Convert.ToString(BetOs[17, ic]);
                        names3[ic].massSR = Convert.ToString(BetOs[16, ic]); ;
                        names3[ic].BaseDistanceNorm = "";
                        names3[ic].BaseDistancePrevSign = "";
                        names3[ic].factPremission = "false";
                        names3[ic].massK = Convert.ToString((Math.Round((BetOs[4, ic] - (BetOs[4, ic] / 100 * 10)) / 1000, 3)));
                        names3[ic].LoadAxisPermission = Convert.ToString(BetOs[16, ic]);
                        names3[ic].AxisIntervalsPermission = Convert.ToString(BetOs[17, ic]);
                        names3[ic].massPrevSR = Convert.ToString(Convert.ToDouble(names3[ic].massK) - Convert.ToDouble(names3[ic].massSR));
                        if (Convert.ToDouble(names3[ic].massPrevSR) <= 0)
                        {  names3[ic].massPrevSR = "0";  }
                        else if (names3[ic].factPremission == "false")
                        { names3[ic].massPrevSR = "0";  }


                        data1.b[0, ic] = Convert.ToString(ic + 1);
                        string Sk = Convert.ToInt32(BetOs[8, ic]) + "/" + (Convert.ToInt32(BetOs[8, ic])) * 2;
                        data1.b[2, ic] = Sk;
                        if (ic > 0)
                        {
                        if (Math.Round(BetOs[3, ic] + 0.03, 2) >= 2.5)
                        {
                            
                            GrO = GrO + 1;
                            names3[ic].groupNumber = Convert.ToString(GrO);
                            data1.b[3, ic] = Convert.ToString(Math.Round(BetOs[3, ic], 2));
                            data1.b[1, ic] = Convert.ToString(GrO);
                            data1.b[4, ic] = Convert.ToString(Math.Round(BetOs[3, ic] + 0.03, 2));
                            data1.b[5, ic] = Convert.ToString(Math.Round(BetOs[5, ic] / 1000, 3));
                            data1.b[6, ic] = Convert.ToString(Math.Round(BetOs[6, ic] / 1000, 3));
                            data1.b[7, ic] = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 3));
                            data1.b[8, ic] = Convert.ToString(Math.Round((BetOs[4, ic] - BetOs[4, ic] / 100 * 10) / 1000, 3));
                        }
                        else if (Math.Round(BetOs[3, ic] + 0.03, 2) >= 2.5)
                        {
                            KGr = KGr + 1;
                            names3[ic].groupNumber = Convert.ToString(GrO);
                            //GrO = GrO; ///+ 1;
                            data1.b[3, ic] = Convert.ToString(Math.Round(BetOs[3, ic], 2));
                            data1.b[1, ic - 1] = Convert.ToString(GrO);
                            data1.b[1, ic] = Convert.ToString(GrO);
                            data1.b[4, ic] = Convert.ToString(Math.Round(BetOs[3, ic] + 0.03, 2));
                            data1.b[5, ic] = Convert.ToString(Math.Round(BetOs[5, ic] / 1000, 3));
                            data1.b[6, ic] = Convert.ToString(Math.Round(BetOs[6, ic] / 1000, 3));
                            data1.b[7, ic] = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 2));
                            data1.b[8, ic] = Convert.ToString(Math.Round((BetOs[4, ic] - BetOs[4, ic] / 100 * 10) / 1000, 3));
                        }
                        else
                        {
                            if (Math.Round((BetOs[3, ic] + 0.03), 2) < 2.5 && Math.Round((BetOs[3, ic - 1] + 0.03), 2) > 0 && Math.Round((BetOs[3, ic] + 0.03), 2) - Math.Round((BetOs[3, ic - 1] + 0.03), 2) < 0.8 && Math.Round((BetOs[3, ic] + 0.03), 2) > 2.36)
                            {
                                GrO = GrO + 1;
                                names3[ic].groupNumber = Convert.ToString(GrO);
                                data1.b[3, ic] = Convert.ToString(Math.Round(BetOs[3, ic], 2));
                                //data1.b[1, ic - 1] = Convert.ToString(GrO);
                                data1.b[1, ic] = Convert.ToString(GrO);
                                data1.b[4, ic] = Convert.ToString(Math.Round(BetOs[3, ic] + 0.03, 2));
                                data1.b[5, ic] = Convert.ToString(Math.Round(BetOs[5, ic] / 1000, 3));
                                data1.b[6, ic] = Convert.ToString(Math.Round(BetOs[6, ic] / 1000, 3));
                                data1.b[7, ic] = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 2));
                                data1.b[8, ic] = Convert.ToString(Math.Round((BetOs[4, ic] - BetOs[4, ic] / 100 * 10) / 1000, 3));
                            }
                            else
                            {
                                KGr = KGr + 1;
                                names3[ic].groupNumber = Convert.ToString(GrO);
                                data1.b[3, ic] = Convert.ToString(Math.Round(BetOs[3, ic], 2));
                                data1.b[1, ic - 1] = Convert.ToString(GrO);
                                data1.b[1, ic] = Convert.ToString(GrO);
                                data1.b[4, ic] = Convert.ToString(Math.Round(BetOs[3, ic] + 0.03, 2));
                                data1.b[5, ic] = Convert.ToString(Math.Round(BetOs[5, ic] / 1000, 3));
                                data1.b[6, ic] = Convert.ToString(Math.Round(BetOs[6, ic] / 1000, 3));
                                data1.b[7, ic] = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 3));
                                data1.b[8, ic] = Convert.ToString(Math.Round((BetOs[4, ic] - BetOs[4, ic] / 100 * 10) / 1000, 3));
                            }
                        }
                     }
                        else
                        {
                            //KGr = KGr++; data1.c
                            GrO = GrO + 1;
                        names3[ic].groupNumber = Convert.ToString(GrO);
                        data1.b[1, ic] = Convert.ToString(GrO);
                            data1.b[3, ic] = "-";
                            data1.b[4, ic] = "-";
                            data1.b[5, ic] = Convert.ToString(Math.Round(BetOs[5, ic] / 1000, 3));
                            data1.b[6, ic] = Convert.ToString(Math.Round(BetOs[6, ic] / 1000, 3));
                            data1.b[7, ic] = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 3));
                            data1.b[8, ic] = Convert.ToString(Math.Round((BetOs[4, ic] - BetOs[4, ic] / 100 * 10) / 1000, 3));
                        }
                        if (data1.b[11, ic] == "-") { data1.b[11, ic] = "0"; }
                        if (Convert.ToDouble(data1.b[11, ic]) < 0)
                        { data1.b[11, ic] = "0"; }
                    }
                }
                #endregion  ////////////////////////////////////////////////////////////////////////////////////

                #region/////////////////////////////////////////            заполнение таблицы групп осей
                if (GrO > 0)
                {
                namesGRUP = new namesGR[GrO];
                RowCountC = GrO;
                    KN[1, 0] = Convert.ToInt32(TypO[1]);
                    KN[0, 0] = 1;
                    /////////////////////////////////////////////       Заполняем первую строку ///////////////////////////////////////////////////
                    if (KN[1, 0] == 1)
                    {
                        data1.c[0, 0] = "1";
                        data1.c[1, 0] = Convert.ToString(TypO[1]);
                        Sk = Convert.ToInt32(BetOs[8, 0]) + "/" + (Convert.ToInt32(BetOs[8, 0])) * 2;
                        data1.c[2, 0] = Sk;

                        data1.c[3, 0] = "-";
                        data1.c[4, 0] = "-";
                        data1.c[5, 0] = Convert.ToString(Math.Round(BetOs[5, 0] / 1000, 3));
                        data1.c[6, 0] = Convert.ToString(Math.Round(BetOs[6, 0] / 1000, 3));
                        data1.c[7, 0] = Convert.ToString(Math.Round(BetOs[4, 0] / 1000, 3));
                        data1.c[8, 0] = Convert.ToString(Math.Round((BetOs[4, 0] - (BetOs[4, 0] / 100 * 10)) / 1000, 3));
                    }
                    else if (KN[1, 0] > 1)
                    {
                        D1_2 = 0;
                        D2_3 = 0;
                        D3_4 = 0;
                        D4_5 = 0;
                        D5_6 = 0;
                        for (ic = 0; ic < TypO[1]; ic++)
                        {
                            D1_2 = D1_2 + BetOs[8, ic];
                            D2_3 = D2_3 + (Math.Round(BetOs[5, ic] / 1000, 3));
                            D3_4 = D3_4 + (Math.Round(BetOs[6, ic] / 1000, 3));
                            D4_5 = D4_5 + (Math.Round(BetOs[4, ic] / 1000, 3));
                            D5_6 = Math.Round(D5_6 + BetOs[3, ic],2);
                        }
                        data1.c[0, 0] = "1";
                        data1.c[1, 0] = Convert.ToString(TypO[1]);
                    if (D1_2 % 2 == 0)
                    {
                        Sk = D1_2 / TypO[1] + "/" + (D1_2 * 2) / TypO[1];
                    }
                    else
                    {
                        D1_2 = D1_2 - 1;
                        Sk = D1_2 / TypO[1] + "/" + (D1_2 * 2) / TypO[1];
                    }
                    data1.c[2, 0] = Sk;
                        data1.c[3, 0] = Convert.ToString(Math.Round(D5_6 / (TypO[1] - 1),2));// BetOs[3, 0];
                        data1.c[4, 0] = Convert.ToString(D5_6 / (TypO[1] - 1) + 0.03); ;
                        data1.c[5, 0] = Convert.ToString(D2_3);
                        data1.c[6, 0] = Convert.ToString(D3_4);
                        data1.c[7, 0] = Convert.ToString(D4_5);
                        data1.c[8, 0] = Convert.ToString((D4_5) - (D4_5 / 100 * 10));
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    //////////////////////// Заполняем строки таблицы больше чем первая
                    string tiposhema = "";
                    for (ic = 1; ic < GrO; ic++)
                    {
                        Sk = "";
                        for (j = 0; j <= ic; j++)
                        {
                            Sk = Sk + Convert.ToString(KN[1, j]);
                        }
                        Sk = Sk + "1";
                        Fx = 0;
                        for (j = 0; j < Sk.Length; j++)
                        {
                            Fx = Fx + int.Parse(Convert.ToString(Sk[j]));
                        }
                        int b = 0;
                        foreach (double c in TypO)
                        {
                            if (Convert.ToInt32(c) == 4)
                            { b = b + 1; }
                        }
                        if (Convert.ToInt32(TypO[Fx]) == 4)
                        {
                            KN[1, ic] = b;
                        }
                        else
                        {
                            KN[1, ic] = Convert.ToInt32(TypO[Fx]);//Количество
                        }
                        tiposhema = tiposhema + "+" + Convert.ToString(KN[1, ic]);
                        KN[0, ic] = Fx; //Позиция                            
                    }
                    //////////////////////////////////////////////////////////////////////

                    for (ic = 1; ic < GrO; ic++)
                    {
                        if (KN[1, ic] == 1)
                        {
                            data1.c[0, ic] = Convert.ToString(ic + 1);
                            data1.c[1, ic] = Convert.ToString(KN[1, ic]); //Convert.ToString(TypO[KN[0, ic]]);
                            Sk = Convert.ToInt32(BetOs[8, ic]) + "/" + Convert.ToInt32(BetOs[8, ic] * 2);
                            data1.c[2, ic] = Sk;
                            data1.c[3, ic] = Convert.ToString(Math.Round(BetOs[3, KN[0, ic] - 1],2));
                            data1.c[4, ic] = Convert.ToString(Math.Round(BetOs[3, KN[0, ic] - 1] + 0.03,2)); ;
                            data1.c[5, ic] = Convert.ToString(Math.Round(BetOs[5, ic] / 1000, 3));
                            data1.c[6, ic] = Convert.ToString(Math.Round(BetOs[6, ic] / 1000, 3));
                            data1.c[7, ic] = Convert.ToString(Math.Round(BetOs[4, ic] / 1000, 3));
                            data1.c[8, ic] = Convert.ToString(Math.Round((BetOs[4, ic] - (BetOs[4, ic] / 100 * 10)) / 1000, 3));
                        }
                        else if (KN[1, ic] > 1)
                        {
                            D1_2 = 0;
                            D2_3 = 0;
                            D3_4 = 0;
                            D4_5 = 0;
                            D5_6 = 0;
                            for (icC = KN[0, ic]; icC <= (KN[0, ic] - 1 + KN[1, ic]); icC++)
                            {
                                D1_2 = D1_2 + BetOs[8, icC - 1];
                                D2_3 = D2_3 + (Math.Round(BetOs[5, icC - 1] / 1000, 3));
                                D3_4 = D3_4 + (Math.Round(BetOs[6, icC - 1] / 1000, 3));
                                D4_5 = D4_5 + (Math.Round(BetOs[4, icC - 1] / 1000, 3));
                                if (KN[1, ic] > 2)
                                { D5_6 = D5_6 + BetOs[3, icC]; }// KN[0, ic]]; }
                                else { D5_6 = BetOs[3, KN[0, ic]]; }
                            }
                            data1.c[0, ic] = Convert.ToString(ic + 1);
                            data1.c[1, ic] = Convert.ToString(KN[1, ic]);//Convert.ToString(TypO[KN[0, ic]]);
                        Sk = (Math.Truncate(Math.Floor(Convert.ToInt32(D1_2) / TypO[KN[0, ic]]))) + "/" + Math.Truncate(Math.Floor((Convert.ToInt32(D1_2) / TypO[KN[0, ic]])) * 2);
                        //Sk = (Math.Floor(Convert.ToInt32(D1_2) / TypO[KN[0, ic]])) + "/" + Math.Floor((Convert.ToInt32(D1_2) / TypO[KN[0, ic]]) * 2);
                        data1.c[2, ic] = Sk;

                            if (KN[1, ic] > 2)
                            {
                                data1.c[3, ic] = Convert.ToString(Math.Round(D5_6 / (KN[1, ic] - 1), 2));//Convert.ToString(Math.Round(D5_6 / (TypO[KN[0, ic]] - 1),2));// BetOs[3, 0];
                                data1.c[4, ic] = Convert.ToString(Math.Round((D5_6 / (KN[1, ic] - 1) + 0.03), 2));//Convert.ToString(Math.Round(D5_6 / (TypO[KN[0, ic]] - 1) + 0.03,2));
                            }
                            else
                            {
                                data1.c[3, ic] = Convert.ToString(Math.Round(D5_6,2));// BetOs[3, 0];
                                data1.c[4, ic] = Convert.ToString(Math.Round(D5_6 + 0.03,2));
                            }
                            data1.c[5, ic] = Convert.ToString(D2_3);
                            data1.c[6, ic] = Convert.ToString(D3_4);
                            data1.c[7, ic] = Convert.ToString(D4_5);
                            data1.c[8, ic] = Convert.ToString(Math.Round(D4_5 - (Convert.ToDouble(D4_5) / 100 * 10), 3));
                        }
                    }
                }
            } 
        #endregion/////////////////////////////////////////            заполнение таблицы групп осей

        private void proc1()
        {
            //MessageBox.Show("В разработке (выбрасывает проезд в формате XML)");
            #region ////////////////////////////////////// Запрос XML для федералов и регионалов по СПЕЦРАЗРЕШЕНИЮ    ////////////////////////////////
            //if ((Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56])) > 0)
            //{
            //    data1.a[64] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2));
            //}
            //else { data1.a[64] = "-"; }

            //if (data1.a[64] != "-")
            //{
            //    data1.a[65] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[64]) / Convert.ToDouble(data1.a[56]) * 100, 2));
            //}
            //else { data1.a[65] = "-"; }

            //data1.a[66] = "-";
            //data1.a[67] = "-";
            //data1.a[68] = "-";
            //data1.a[69] = "-";
            #endregion ////////////////////////////////////////////////////////////////     ////////////////////////////////
            #region ////////////////////////////////////// Запрос XML для АНГЕЛОВ    ////////////////////////////////
            if (data1.a[3] != "" && (XDate[31] == "True" || XDate[30] == "True" || XDate[2] == "True" || XDate[4] == "True" || XDate[3] == "True") && ImOb != null && TypNar > 0)//&& ImPl,ImAlt )
            {
                MySqlCommand command1 = new MySqlCommand();
                ConnectStr conStr1 = new ConnectStr();
                conStr1.ConStr(1);
                string connectionString1;
                connectionString1 = conStr1.StP;
                MySqlConnection connection1 = new MySqlConnection(connectionString1);
                //if (Convert.ToInt32(data1.a[240]) == 0)
                //{
                    z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
                              + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 16, '" + VNTN + "', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                //}
                //else if (Convert.ToInt32(data1.a[240]) == 2)
                //{
                //    z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
                //              + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 16, '" + VNTN + "', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                //}
                command1.CommandText = z1;// commandString;
                command1.Connection = connection1;
                connection1.Open();
                command1.ExecuteNonQuery();
                command1.Connection.Close();
                
                if (data1.a[22] == "Региональная") { PLACE = "Автомобильная дорога регионального значения " + data1.a[27].ToString(); }
                else if (data1.a[22] == "Муниципальная") { PLACE = "Автомобильная дорога муниципального значения  " + data1.a[27].ToString(); }
                else if (data1.a[22] == "Федеральная") { PLACE = "Автомобильная дорога федерального значения  " + data1.a[27].ToString(); }
                try
                {
                    XNamespace rpvk1 = "urn:smtp-violation";
                    XDocument doc = new XDocument(
                    new XElement("CaseData",
                    new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
             new XElement("CaseViolation",
            new XElement("EquipmentName", data1.a[9].ToString()),
            new XElement("EquipmentID", data1.a[14].ToString()),
            new XElement("EquipmentType", data1.a[11].ToString()),
            new XElement("EquipmentSeriaNumber", data1.a[13].ToString()),
            new XElement("EquipmentOwner", data1.a[10].ToString()),
            new XElement("CertificateStatementSuchMeasurementNumber", data1.a[15].ToString()), //alphaBlendTextBox107.Text.ToString()),//2016-06-29T13:02:06.473935+05:00
            new XElement("CertificateStatementSuchMeasurementDate", data1.a[16].ToString()),
            new XElement("CertificateStatementSuchMeasurementRegistrationNumber", data1.a[17].ToString()),
            new XElement("CheckingDocNumber", NSPov.ToString()), //data1.a[18].ToString() + " / " + data1.a[203].ToString()),
            new XElement("CheckingCertificateDate", DVPov.ToString()),// data1.a[19].ToString() + " / " + data1.a[204].ToString()),
            new XElement("CheckingValid", ValidPov.ToString()),// data1.a[20].ToString() + " / " + data1.a[205].ToString()),
            new XElement("Place", PLACE.ToString() + ", по направлению движения " + data1.a[30].ToString()), //alphaBlendTextBox107.Text.ToString()),//2016-06-29T13:02:06.473935+05:00
            new XElement("Longitude", data1.a[26].ToString()),
            new XElement("Latitude", data1.a[25].ToString()),
            new XElement("HighwayName", data1.a[21].ToString()),
            new XElement("FactID", GDAng.ToString()), //data1.a[4].ToString()),
            new XElement("ViolationDateTime", Convert.ToString(Convert.ToDateTime(data1.a[8].ToString()).ToString("yyyy-MM-ddTHH:mm:ss"))),
            new XElement("StateNumber", data1.a[3].ToString()),
            new XElement("MovementDirection", data1.a[30].ToString()),
            new XElement("QuantityAxes", data1.a[1].ToString()),
            new XElement("ActID", NRUB.ToString() + "-" + data1.a[4].ToString()), //Convert.ToString(data1.a[14].ToString() + " - " + data1.a[4].ToString())),
            new XElement("SpecialPermissionSign", XDate[12].ToString()),//alphaBlendTextBox69.Text.ToString()),
            new XElement("SpecialPermissionNumber", XDate[13].ToString()),//alphaBlendTextBox74.Text.ToString()),
            new XElement("SpecialPermissionRegistrationDate", XDate[14].ToString()),//alphaBlendTextBox73.Text.ToString()),
            new XElement("ExcessAxesSign", SigAx.ToString()),//XDate[0].ToString()),//alphaBlendTextBox106.Text.ToString()),//!!!!!!!!!!!!!!!
            new XElement("ExcessAxesGroupSign", SigGr.ToString()),
            new XElement("ExcessFullWeightSign", SigAll.ToString()),//XDate[1].ToString()),//Convert.ToString(Convert.ToDateTime(alphaBlendTextBox28.Text).ToString())), //alphaBlendTextBox107.Text.ToString()),//2016-06-29T13:02:06.473935+05:00
            new XElement("ExcessLengthSign", XDate[2].ToString()),//!!!!!!!!!!!!!!!!!!
            new XElement("ExcessHeightSign", XDate[4].ToString()),//!!!!!!!!!!!!!!!!!!!!!!!!alphaBlendTextBox36.Text.ToString()),
            new XElement("ExcessWidthSign", XDate[3].ToString()),//!!!!!!!!!!!!!!!!!!!!!!!!alphaBlendTextBox103.Text.ToString()),
            new XElement("ResolvedLoadAxisMax", data1.a[32].ToString()),
            new XElement("TrackCategory", data1.a[32].ToString()), //alphaBlendTextBox32.Text.ToString()),
            new XElement("TrackType", XDate[5].ToString()),//alphaBlendTextBox105.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            new XElement("SpecialPermissionCompany", XDate[15].ToString()),//alphaBlendTextBox70.Text.ToString()),
            new XElement("SpecialPermissionStartDate", XDate[16].ToString()),//Convert.ToString(Convert.ToDateTime(alphaBlendTextBox73.Text).ToString("yyyy-MM-ddTHH:mm:ss.FFF"))), //alphaBlendTextBox107.Text.ToString()),//2016-06-29T13:02:06.473935+05:00
            new XElement("SpecialPermissionEndDate", XDate[17].ToString()),//Convert.ToString(Convert.ToDateTime(alphaBlendTextBox75.Text).ToString("yyyy-MM-ddTHH:mm:ss.FFF"))),// alphaBlendTextBox36.Text.ToString()),
            new XElement("RouteViolationSign", XDate[18].ToString()),//!!!!!!!!!!!!!!!!!!!!alphaBlendTextBox1.Text.ToString()),
            new XElement("TripCountFact", data1.a[40].ToString()),
            new XElement("RoadType", data1.a[22].ToString()), //alphaBlendTextBox32.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!!!
            new XElement("ExcessFactMedia", GDAng.ToString() + "_1.jpg"),//!!!!!!!!!!!!!!!!!!!!!!alphaBlendTextBox106.Text.ToString()),
            new XElement("ExcessFactMedia", GDAng.ToString() + "_grz.jpg"),//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Convert.ToDateTime(alphaBlendTextBox107.Text).ToString("yyyy-MM-ddTHH:mm:ss.FFF")), //alphaBlendTextBox107.Text.ToString()),//2016-06-29T13:02:06.473935+05:00
            new XElement("ExcessFactMedia", GDAng.ToString() + ".jpg")),//!!!!!!!!!!!!!!!!!!!!!!!!!!!//alphaBlendTextBox36.Text.ToString())),
            
             new XElement("SpeedViolation",
            new XElement("Speed", data1.a[5].ToString()),
            new XElement("SpeedWIM", XDate[6].ToString()),//(Convert.ToDouble(alphaBlendTextBox80.Text.ToString()) - Convert.ToDouble(alphaBlendTextBox80.Text.ToString()) / 100 * 10)),//!!!!!!!!!!!!!!!!!!alphaBlendTextBox43.Text.ToString()),
            new XElement("DifferenceSpeedPermissionFact", XDate[7].ToString()),//alphaBlendTextBox43.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!
            new XElement("ExcessSpeed", XDate[8].ToString())),//alphaBlendTextBox46.Text.ToString())),//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            
             new XElement("DimensionViolation",
            new XElement("LengthNorm", data1.a[56].ToString()),
            new XElement("WidthNorm", data1.a[59].ToString()),
            new XElement("HeightNorm", data1.a[62].ToString()),
            new XElement("ExtraLength", data1.a[54].ToString()),
            new XElement("ExtraWidth", data1.a[57].ToString()),
            new XElement("LengthPermission", XDate[19].ToString()),//!!!!!!!!!!!!!!!!!!alphaBlendTextBox43.Text.ToString()),
            new XElement("WidthPermission", XDate[20].ToString()),
            new XElement("HeightPermission", XDate[21].ToString()),//!!!!!!!!!!!!!!!!!!!alphaBlendTextBox43.Text.ToString()),
            new XElement("LengthFact", data1.a[55].ToString()),
            new XElement("WidthFact", data1.a[58].ToString()),
            new XElement("HeightFact", data1.a[61].ToString()),
            new XElement("DifferenceLengthNormaFact", XDate[9].ToString()),//alphaBlendTextBox40.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!!!!
            new XElement("DifferenceWidthNormaFact", XDate[10].ToString()),//alphaBlendTextBox50.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!!!!
            new XElement("DifferenceHeightNormaFact", XDate[11].ToString()),//alphaBlendTextBox52.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!!!!!
            new XElement("DifferenceLengthPermissionFact", XDate[22].ToString()),//alphaBlendTextBox43.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!
            new XElement("DifferenceWidthPermissionFact", XDate[23].ToString()),//alphaBlendTextBox46.Text.ToString()),//!!!!!!!!!!!!!!!!!!!!!!!!
            new XElement("DifferenceHeightPermissionFact", XDate[24].ToString()),//alphaBlendTextBox46.Text.ToString())),//!!!!!!!!!!!!!!!!!!!!!!!!
            new XElement("NomStateyLength", CodSTGabarL),
            new XElement("NomStateyWidth", CodSTGabarW),
            new XElement("NomStateyHeight", CodSTGabarH)),

            from n in names3
            select new XElement("LoadAxisViolation",
            new XElement("AxisNumber", n.BaseNumber),//Convert.ToString(names1.Length.ToString())),// alphaBlendTextBox43.Text.ToString()),
            new XElement("LoadAxisFact", n.massK),//alphaBlendTextBox43.Text.ToString()),
            new XElement("LoadAxisPermission", n.massSR), //alphaBlendTextBox46.Text.ToString()),
            new XElement("MeasuredValueAxis", n.massFact),//alphaBlendTextBox37.Text.ToString()),
            new XElement("DifferenceNormFact", n.massPrev),//alphaBlendTextBox43.Text.ToString()),
             new XElement("PercentageExceeded", n.DifferencePDKFact),
            new XElement("DifferencePermissionFact", n.massPrevSR),//alphaBlendTextBox43.Text.ToString()),
            new XElement("SignExcessLoadAxis", n.massSign),//alphaBlendTextBox37.Text.ToString()),
            new XElement("AxisIntervalsNorm", n.BaseDistanceNorm),//alphaBlendTextBox43.Text.ToString()),
            new XElement("AxisIntervalsPermission", n.BaseDistanceSR),//alphaBlendTextBox43.Text.ToString()),
            new XElement("AxisIntervalsFact", n.BaseDistance),//alphaBlendTextBox46.Text.ToString()),
            new XElement("DiffInterPermissionFact", n.factPremission),//alphaBlendTextBox46.Text.ToString()),
            new XElement("LoadAxisNormForFact", n.PDKmass),//alphaBlendTextBox43.Text.ToString()),
            new XElement("SignExcessIntervalAxis", n.BaseDistancePrevSign),//alphaBlendTextBox43.Text.ToString()),
            new XElement("AxisWheelsExFact", n.skatnost),//alphaBlendTextBox46.Text.ToString()),
            new XElement("AxisWheelsNumFact", n.groupNumber),//alphaBlendTextBox46.Text.ToString())),
             new XElement("NomStateyAxis", n.NomStatei)),//alphaBlendTextBox46.Text.ToString())),

             from k in namesGRUP
             select new XElement("LoadGroupViolation",
             new XElement("GroupNumber", k.BaseNumber),//Convert.ToString(names1.Length.ToString())),// alphaBlendTextBox43.Text.ToString()),
             new XElement("LoadGroupFact", k.massK),//alphaBlendTextBox43.Text.ToString()),
             new XElement("MeasuredValueGroup", k.massFact),//alphaBlendTextBox37.Text.ToString()),
             new XElement("LoadGroupNormForFact", k.PDKmass),//alphaBlendTextBox43.Text.ToString()),
             new XElement("LoadGroupPermission", k.massSR), //alphaBlendTextBox46.Text.ToString()),             
             new XElement("DifferenceNormFact", k.massPrev),//alphaBlendTextBox43.Text.ToString()),
             new XElement("DifferencePermissionFact", k.massPrevSR),//alphaBlendTextBox43.Text.ToString()),
             new XElement("PercentageExceeded", k.DifferencePDKFact),
             new XElement("GroupIntervalsFact", k.BaseDistance),//alphaBlendTextBox46.Text.ToString()),
             new XElement("SignExcessLoadGroup", k.massSign),//alphaBlendTextBox37.Text.ToString()),
             new XElement("GroupIntervalsNorm", k.BaseDistanceNorm),//alphaBlendTextBox43.Text.ToString()),
             new XElement("GroupIntervalsPermission", k.BaseDistanceSR),//alphaBlendTextBox43.Text.ToString()),             
             new XElement("DiffInterPermissionFact", k.factPremission),//alphaBlendTextBox46.Text.ToString()),             
             new XElement("SignExcessIntervalGroup", k.BaseDistancePrevSign),//alphaBlendTextBox43.Text.ToString()),
             new XElement("GroupWheelsExFact", k.skatnost),//alphaBlendTextBox46.Text.ToString()),
             new XElement("GroupWheelsNumFact", k.groupNumber),//alphaBlendTextBox46.Text.ToString())),
             new XElement("CountAxesInGroup", k.CountAxesInGroup),//alphaBlendTextBox46.Text.ToString())),
             new XElement("NomStateyGroup", k.NomStatei)),//alphaBlendTextBox46.Text.ToString())),

             new XElement("FullWeightViolation",
            new XElement("FullWeightNorm", data1.a[50].ToString()),
            new XElement("FullWeightPermission", XDate[26].ToString()),//alphaBlendTextBox46.Text.ToString()),
            new XElement("FullWeightFact", XDate[25].ToString()),
            new XElement("ExtraMeasuredValue", data1.a[48].ToString()), 
            new XElement("DifferenceFullWeightNormaFact", XDate[27].ToString()),
            new XElement("DifferenceFullWeightPermissionFact", XDate[28].ToString()),//alphaBlendTextBox43.Text.ToString())),
              new XElement("NomStateyAll", CodSTAll)),//alphaBlendTextBox46.Text.ToString())),

            new XElement("FullViolationCode",
            from n in CodNarAN
            //select new XElement("FullViolationCode",
            select new XElement("nViolationCode", n.CodNarANg)),
           
            new XElement("ActPdf", GDAng.ToString() + ".pdf")));

                    doc.Save(@"F:\\archiv\\AKT\\" + GDAng.ToString() + ".xml");//NRUB + "_" + data1.a[4] + "_" + DateTime.Now.ToString("ddMMyyyy") + ".xml");

                    MySqlCommand command3 = new MySqlCommand();
                    ConnectStr conStr3 = new ConnectStr();
                    conStr3.ConStr(1);
                    string connectionString3;
                    connectionString3 = conStr3.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                    MySqlConnection connection3 = new MySqlConnection(connectionString3);
                    string z3 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
  + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 11, 'отправлен в ЦАФАП', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")"; ;
                    //MySqlCommand command = new MySqlCommand(z);
                    command3.CommandText = z3;// commandString;
                    command3.Connection = connection3;
                    connection3.Open();
                    command3.ExecuteNonQuery();
                    command3.Connection.Close();

                    PDF();
                   
                    string aaa = @"F:\\archiv\\AKT\\" + DateTime.Now.ToString("dd_MM_yyyy");
                    string bbb = @"F:\\archivACT\\act\\" + DateTime.Now.ToString("dd_MM_yyyy");
                    CopyFolderYesterdayFiles(@"F:\\archiv\\AKT\\", aaa,bbb, GDAng.ToString(), IDW.ToString(), PLN.ToString(), data1.a[238].ToString());

                    MySqlCommand command = new MySqlCommand();
                    ConnectStr conStr = new ConnectStr();
                    Zapros zapros = new Zapros();
                    conStr.ConStr(1);
                    cstr = conStr.StP;
                    if (Convert.ToInt32(data1.a[240]) == 0)
                    { zapros.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), "AUTO", 4, "отправлен в ЦАФАП", CodNarM, Convert.ToInt32(data1.a[240]) + 1, data1.a[3].ToString(), data1.a[242].ToString(), NamPD.ToString()); }
                    else { zapros.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), "AUTO", 4, "отправлен в ЦАФАП", CodNarM, Convert.ToInt32(data1.a[240]) + 1, data1.a[241].ToString(), data1.a[242].ToString(), NamPD.ToString()); }
                    MySqlConnection connection = new MySqlConnection(cstr);
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    string z = zapros.commandStringTest;
                    cmd.CommandText = z;
                    cmd.Connection = connection;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MySqlCommand command2 = new MySqlCommand();
                    ConnectStr conStr2 = new ConnectStr();
                    conStr2.ConStr(1);
                    string connectionString2;
                    connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                    MySqlConnection connection2 = new MySqlConnection(connectionString2);
                    string z2 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
  + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 12, 'проверка закочилась в автоматическом режиме', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")"; ;
                    command2.CommandText = z2;// commandString;
                    command2.Connection = connection2;
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    command2.Connection.Close();

                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить XML файл. Проезд " + IDpish.ToString(), "Ошибка.");
                }
            }
            else
            {
                MySqlCommand command1 = new MySqlCommand();
                ConnectStr conStr1 = new ConnectStr();
                conStr1.ConStr(1);
                string connectionString1;
                connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                MySqlConnection connection1 = new MySqlConnection(connectionString1);
                string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
  + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 17, 'нарушений не выявлено', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                command1.CommandText = z1;// commandString;
                command1.Connection = connection1;
                connection1.Open();
                command1.ExecuteNonQuery();
                command1.Connection.Close();
                MySqlCommand command = new MySqlCommand();
                ConnectStr conStr = new ConnectStr();
                Zapros zapros = new Zapros();
                conStr.ConStr(1);
                cstr = conStr.StP;
                zapros.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), "AUTO", 17, "Нарушений не выявлено", CodNarM, Convert.ToInt32(data1.a[240]) + 1, data1.a[241].ToString(), data1.a[242].ToString(), "");
                MySqlConnection connection = new MySqlConnection(cstr);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                string z = zapros.commandStringTest;
                cmd.CommandText = z;
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
             #endregion ////////////////////////////////////////////////////////////////     ////////////////////////////////
        }

        static void CopyFolderYesterdayFiles(string sourceFolder, string destFolder, string destFolderM, string GAng, string IW, string PL, string DPR)
        {
            DateTime YesterdayDate = DateTime.Today.Date;
            DirectoryInfo dirInfo = new DirectoryInfo(@"F:\\archiv\\AKT\\");
            if (!Directory.Exists(destFolder))
            {
                Directory.CreateDirectory(destFolder);
            }
            FileInfo[] files = dirInfo.GetFiles("" + GAng.ToString() + ".xml");//.AddDays(-1).ToString("yyyyMMdd") + "_*.xml");//sourceFolder);

            DirectoryInfo directory = new DirectoryInfo(@"F:\\archiv\\AKT\\" + YesterdayDate.ToString("ddMMyyyy"));//file => file.LastWriteTime.Date == YesterdayDate );

            foreach (FileInfo file in files)
                File.Delete(Path.Combine(destFolder, file.Name));

            foreach (FileInfo file in files)
                File.Copy(file.FullName, Path.Combine(destFolder, file.Name));

            string[] folders = Directory.GetDirectories(sourceFolder);

            foreach (FileInfo file in files)
                File.Delete(file.FullName);

            if (!Directory.Exists(destFolderM))
            {
                Directory.CreateDirectory(destFolderM);
            }

            FileInfo[] filesM = dirInfo.GetFiles("" + GAng.ToString() + ".pdf");
            DirectoryInfo directoryM = new DirectoryInfo(@"F:\\archivACT\\act\\" + YesterdayDate.ToString("ddMMyyyy"));//file => file.LastWriteTime.Date == YesterdayDate );
            //foreach (FileInfo file in filesM)
            //    File.Delete(Path.Combine(destFolderM, file.Name));
            foreach (FileInfo file in filesM)
                File.Copy(file.FullName, Path.Combine(destFolderM, file.Name));

            //string[] foldersM = Directory.GetDirectories(sourceFolderM);

            //foreach (FileInfo file in filesM)
            //    File.Delete(file.FullName);

            FileInfo[] filesP = dirInfo.GetFiles("" + GAng.ToString() + ".pdf");//*_" + DateTime.Today.Date.ToString("ddMMyyyy") + ".pdf");//.AddDays(-1).ToString("yyyyMMdd") + "_*.xml");//sourceFolder);

            DirectoryInfo directoryP = new DirectoryInfo(@"F:\\archiv\\AKT\\" + YesterdayDate.ToString("ddMMyyyy"));//file => file.LastWriteTime.Date == YesterdayDate );

            foreach (FileInfo file in filesP)
                File.Delete(Path.Combine(destFolder, file.Name));

            foreach (FileInfo file in filesP)
                File.Copy(file.FullName, Path.Combine(destFolder, file.Name));

            string[] foldersP = Directory.GetDirectories(sourceFolder);

            foreach (FileInfo file in filesP)
                File.Delete(file.FullName);

            //FileInfo[] filesI = dirInfo.GetFiles("" + GAng.ToString() + "*.Jpg");//.AddDays(-1).ToString("yyyyMMdd") + "_*.xml");//sourceFolder);

            //DirectoryInfo directoryI = new DirectoryInfo(@"F:\\archiv\\AKT\\" + YesterdayDate.ToString("ddMMyyyy"));//file => file.LastWriteTime.Date == YesterdayDate );

            //foreach (FileInfo file in filesI)
            //    File.Delete(Path.Combine(destFolder, file.Name));

            //foreach (FileInfo file in filesI)
            //    File.Copy(file.FullName, Path.Combine(destFolder, file.Name));

            //string[] foldersI = Directory.GetDirectories(sourceFolder);

            //foreach (FileInfo file in filesI)
            //    File.Delete(file.FullName);

            DirectoryInfo directoryVi = new DirectoryInfo(@"F:\\archivACT\\Photo\\" + YesterdayDate.ToString("dd_MM_yyyy"));//file => file.LastWriteTime.Date == YesterdayDate );
            FileInfo[] filesV = dirInfo.GetFiles("" + GAng.ToString() + "_*.Avi");//.AddDays(-1).ToString("yyyyMMdd") + "_*.xml");//sourceFolder);
            FileInfo[] filesVi = directoryVi.GetFiles("" + IW.ToString() + "_" + PL.ToString() + "_" + DPR.ToString() + "*.Avi");
            

            //foreach (FileInfo file in filesV)
            //    File.Delete(Path.Combine(destFolder, "" + GAng.ToString() + ".Avi"));

            foreach (FileInfo file in filesVi)
                File.Copy(file.FullName, Path.Combine(destFolder, "" + GAng.ToString() + ".Avi"));

            //string[] foldersI = Directory.GetDirectories(sourceFolder);

            //foreach (FileInfo file in filesI)
            //    File.Delete(file.FullName);

            DirectoryInfo directoryZ = new DirectoryInfo(@"F:\\archiv\\AKT\\" + YesterdayDate.ToString("dd_MM_yyyy"));
            FileInfo[] filesZ = directoryZ.GetFiles("" + GAng.ToString() + "*.*");//.AddDays(-1).ToString("yyyyMMdd") + "_*.xml");//sourceFolder);

            //DirectoryInfo directoryI = new DirectoryInfo(@"F:\\archiv\\AKT\\" + YesterdayDate.ToString("ddMMyyyy"));//file => file.LastWriteTime.Date == YesterdayDate );

            //foreach (FileInfo file in filesI)
            //    File.Delete(Path.Combine(destFolder, file.Name));
            ZipFile zf = new ZipFile();
            zf.ProvisionalAlternateEncoding = Encoding.GetEncoding("cp866");
            zf.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zf.UseZip64WhenSaving = Zip64Option.AsNecessary;
            foreach (FileInfo file in filesZ)
                //File.Copy(file.FullName, Path.Combine(destFolder, file.Name));
              
            zf.AddFile(file.FullName,"");//Добавляем папку
            zf.Save(Path.Combine(destFolder, "" + GAng.ToString() + ".zip")); //Сохраняем архив.
            //Directory.Delete((@"F:\\archivACT\\Photo\\" + NArchF.ToString()), true);

            string[] foldersZ = Directory.GetDirectories(sourceFolder);

            foreach (FileInfo file in filesZ)
                File.Delete(file.FullName);
        }
        
        public void PDF()
        {
            if (data1.a[33] == "Не выдавалось")
            {
                data1.a[41] = "-"; data1.a[35] = "-"; data1.a[36]="-";
                data1.a[34] = "-";data1.a[42] = "-";  data1.a[43] = "-"; data1.a[39] = "-"; data1.a[37] = "-";
                data1.a[40] = "-";
            }
            for (int datA=0; datA<8; datA++) 
            {
                if (data1.b[10, datA] == "0")
                { data1.b[10, datA] = "-"; }
            }
            for (int datAP = 0; datAP < 8; datAP++)
            {
                if (data1.b[11, datAP] == "0")
                { data1.b[11, datAP] = "-"; }
            }
            for (int datC = 0; datC <5; datC++)
            {
                if (data1.c[10, datC] == "0")
                { data1.c[10, datC] = "-"; }
            }
            for (int datCP = 0; datCP < 5; datCP++)
            {
                if (data1.c[11, datCP] == "0")
                { data1.c[11, datCP] = "-"; }
            }
            A1[0] = NRUB + "-" + data1.a[4];
            A1[259] = NRUB + "_" + data1.a[4];
            A1[250] = DateTime.Now.ToString("dd.MM.yyyy");
            A1[1] = (Convert.ToDateTime(data1.a[6])).ToString("dd.MM.yyyy");//alphaBlendTextBox26.Text;//
            A1[2] = data1.a[7];//DateTime.Now.ToString(" HH:mm:ss");
            A1[3] = data1.a[4];
            A1[4] = data1.a[9]; A1[5] = data1.a[11]; /*"Комплекс измерительный автоматического весового и габаритного контроля";*/ A1[6] = data1.a[12]; A1[7] = data1.a[13]; /*"001/02/2018 ";*/ A1[8] = data1.a[14];
            A1[9] = data1.a[27];/*"51 км. + 106 м.";*/ A1[10] = data1.a[28]; A1[11] = data1.a[10];/*" Betamont s.r.o. "*/; A1[12] = data1.a[15];/*"123456"*/; A1[13] = data1.a[16];
            A1[14] = data1.a[17]; A1[15] = NSPov.ToString();/*data1.a[18];*//*"Тets - 123"*/; A1[16] = DVPov.ToString(); /*data1.a[19];*/ A1[17] = ValidPov.ToString(); /*data1.a[20];*/ A1[18] = data1.a[22];
            A1[19] = data1.a[21];/*"г. Севастополь, а/д Симферополь-Бахчисарай-Севастополь 51 км. + 106 м.";*/
            if (data1.a[45] == " " || data1.a[45] == "") { A1[24] = "-"; } else { A1[24] = data1.a[45]; }
            A1[20] = data1.a[29]; A1[21] = data1.a[30]; A1[22] = data1.a[32] + " тонн/ось"; A1[23] = data1.a[44];
            /*A1[24] = data1.a[45];*/ A1[25] = data1.a[3]; A1[26] = FFFT;//data1.a[47];// alphaBlendTextBox12.Text;
            A1[27] = data1.a[2]; A1[28] = data1.a[1];
            A1[29] = GrO.ToString() + " (" + data1.a[46] + ")"; A1[30] = data1.a[33]; A1[31] = data1.a[41]; A1[32] = data1.a[35]; A1[33] = data1.a[36];
            A1[34] = data1.a[34]; A1[35] = data1.a[42]; A1[36] = data1.a[43]; A1[37] = data1.a[39]; A1[38] = data1.a[37];
            A1[39] = data1.a[40]; /*A1[40] = data1.a[38];*/
            if (data1.a[38] == " " || data1.a[38] == ""|| data1.a[38] == null) { A1[40] = "-"; } else { A1[40] = data1.a[38]; }
            if (TypNarTXTM.ToString() != "")
            { A1[41] = TypNarTXTM.ToString(); A1[42] = MAXPREVPROTCM.ToString(); A1[43] = MAXPREVM.ToString(); }
            else { A1[41] = "-"; A1[42] = "-"; A1[43] ="-"; }
            /*A1[43] = data1.a[52];*/ A1[44] = "- 0.60 м"; A1[45] = "- 0.10 м"; A1[46] = "- 0.06 м"; A1[47] = data1.a[54];
            if (data1.a[57]!="0") { A1[48] = data1.a[57]; A1[51] = data1.a[58];} else { A1[48] = "-"; A1[51] = "-"; }
            if (data1.a[60]!="0") { A1[49] = data1.a[60]; A1[52] = data1.a[61];} else { A1[49] = "-"; A1[52] = "-"; }
            A1[50] = data1.a[55];  
            A1[53] = data1.a[56]; A1[54] = data1.a[59]; A1[55] = data1.a[62];
            if (XDate[12].ToString() != "False")
            { A1[56] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[246]),2)); A1[57] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[247]),2)); A1[58] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[248]),2)); A1[69] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[245]),3)); /*A1[40] = data1.a[38];*/ }
            else
            { A1[56] = "-"; A1[57] = "-"; A1[58] = "-"; A1[69] = "-"; A1[40] = "-"; }

            A1[59] = data1.a[65]; A1[60] = data1.a[67]; A1[61] = data1.a[69]; A1[62] = data1.a[64];
            A1[63] = data1.a[66]; A1[64] = data1.a[68]; A1[65] = "- 5%"; A1[66] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[48]),3)); A1[67] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]),3));
            A1[68] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[50]),3)); 
            A1[71] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[52]), 3));
            if (A1[71] != "0") { A1[70] = data1.a[53]; A1[71] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[52]), 3)); }
            else { A1[70] = "-"; A1[71] = "-"; }

            A1[72] = data1.b[0, 0].ToString(); A1[73] = data1.b[2, 0].ToString(); A1[74] = data1.b[1, 0].ToString(); A1[75] = data1.b[3, 0].ToString(); A1[76] = data1.b[4, 0].ToString();
            A1[77] = data1.b[7, 0].ToString(); A1[78] = data1.b[8, 0].ToString(); A1[79] = data1.b[9, 0].ToString(); /*A1[80] =  data1.b[10, 0].ToString(); */
            A1[81] = data1.b[11, 0].ToString(); A1[82] = data1.b[12, 0].ToString();
            if (Convert.ToInt32(data1.a[1]) > 1)
            {
                A1[83] = data1.b[0, 1].ToString(); A1[84] = data1.b[2, 1].ToString(); A1[85] = data1.b[1, 1].ToString(); A1[86] = data1.b[3, 1].ToString(); A1[87] = data1.b[4, 1].ToString();
                A1[88] = data1.b[7, 1].ToString(); A1[89] = data1.b[8, 1].ToString(); A1[90] = data1.b[9, 1].ToString();/* A1[91] =  data1.b[10, 1].ToString();*/
                A1[92] = data1.b[11, 1].ToString(); A1[93] = data1.b[12, 1].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 2)
            {
                A1[94] = data1.b[0, 2].ToString(); A1[95] = data1.b[2, 2].ToString(); A1[96] = data1.b[1, 2].ToString(); A1[97] = data1.b[3, 2].ToString(); A1[98] = data1.b[4, 2].ToString();
                A1[99] = data1.b[7, 2].ToString(); A1[100] = data1.b[8, 2].ToString(); A1[101] = data1.b[9, 2].ToString();/* A1[102] =  data1.b[10, 2].ToString();*/ 
                A1[103] = data1.b[11, 2].ToString(); A1[104] = data1.b[12, 2].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 3)
            {
                A1[105] = data1.b[0, 3].ToString(); A1[106] = data1.b[2, 3].ToString(); A1[107] = data1.b[1, 3].ToString(); A1[108] = data1.b[3, 3].ToString(); A1[109] = data1.b[4, 3].ToString();
                A1[110] = data1.b[7, 3].ToString(); A1[111] = data1.b[8, 3].ToString(); A1[112] = data1.b[9, 3].ToString();/* A1[113] =  data1.b[10,3].ToString();*/ 
                A1[114] = data1.b[11, 3].ToString();
                A1[115] = data1.b[12, 3].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 4)
            {
                A1[116] = data1.b[0, 4].ToString(); A1[117] = data1.b[2, 4].ToString(); A1[118] = data1.b[1, 4].ToString(); A1[119] = data1.b[3, 4].ToString(); A1[120] = data1.b[4, 4].ToString();
                A1[121] = data1.b[7, 4].ToString(); A1[122] = data1.b[8, 4].ToString(); A1[123] = data1.b[9, 4].ToString();/* A1[124] =  data1.b[10, 4].ToString(); */
                A1[125] = data1.b[11, 4].ToString();
                A1[126] = data1.b[12, 4].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 5)
            {
                A1[127] = data1.b[0, 5].ToString(); A1[128] = data1.b[2, 5].ToString(); A1[129] = data1.b[1, 5].ToString(); A1[130] = data1.b[3, 5].ToString(); A1[131] = data1.b[4, 5].ToString();
                A1[132] = data1.b[7, 5].ToString(); A1[133] = data1.b[8, 5].ToString(); A1[134] = data1.b[9, 5].ToString();/* A1[135] =  data1.b[10, 5].ToString(); */
                A1[136] = data1.b[11, 5].ToString();
                A1[137] = data1.b[12, 5].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 6)
            {
                A1[138] = data1.b[0, 6].ToString(); A1[139] = data1.b[2, 6].ToString(); A1[140] = data1.b[1, 6].ToString(); A1[141] = data1.b[3, 6].ToString(); A1[142] = data1.b[4, 6].ToString();
                A1[143] = data1.b[7, 6].ToString(); A1[144] = data1.b[8, 6].ToString(); A1[145] = data1.b[9, 6].ToString();/* A1[146] =  data1.b[10, 6].ToString(); */
                A1[147] = data1.b[11, 6].ToString();
                A1[148] = data1.b[12, 6].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 7)
            {
                A1[149] = data1.b[0, 7].ToString(); A1[150] = data1.b[2, 7].ToString(); A1[151] = data1.b[1, 7].ToString(); A1[152] = data1.b[3, 7].ToString(); A1[153] = data1.b[4, 7].ToString();
                A1[154] = data1.b[7, 7].ToString(); A1[155] = data1.b[8, 7].ToString(); A1[156] = data1.b[9, 7].ToString(); /*A1[157] =  data1.b[10, 7].ToString(); */
                A1[158] = data1.b[11, 7].ToString();
                A1[159] = data1.b[12, 7].ToString();
            }
            if (Convert.ToInt32(data1.a[1]) > 8)
            {
                A1[160] = data1.b[0, 8].ToString(); A1[161] = data1.b[2, 8].ToString(); A1[162] = data1.b[1, 8].ToString(); A1[163] = data1.b[3, 8].ToString(); A1[164] = data1.b[4, 8].ToString();
                A1[165] = data1.b[7, 8].ToString(); A1[166] = data1.b[8, 8].ToString(); A1[167] = data1.b[9, 8].ToString();/* A1[168] =  data1.b[10, 8].ToString(); */
                A1[169] = data1.b[11, 8].ToString();
                A1[170] = data1.b[12, 8].ToString();
            }

            A1[171] = data1.c[0, 0].ToString(); A1[172] = data1.c[2, 0].ToString(); A1[173] = data1.c[1, 0].ToString(); /*A1[174] = data1.c[3, 0].ToString();*/
            A1[175] = data1.c[4, 0].ToString();
            A1[176] = data1.c[7, 0].ToString(); A1[177] = data1.c[8, 0].ToString(); A1[178] = data1.c[9, 0].ToString(); /*A1[179] =  data1.c[10,0].ToString(); */
            A1[180] = data1.c[11, 0].ToString();
            A1[181] = data1.c[12, 0].ToString();
            if (Convert.ToInt32(RowCountC) > 1)
            {
                A1[182] = data1.c[0, 1].ToString(); A1[183] = data1.c[2, 1].ToString(); A1[184] = data1.c[1, 1].ToString(); /*A1[185] = data1.c[3, 1].ToString();*/
                if (data1.c[1, 1].ToString() == "1") { A1[186] = "-"; } else { A1[186] = data1.c[4, 1].ToString(); }
                A1[187] = data1.c[7, 1].ToString(); A1[188] = data1.c[8, 1].ToString(); A1[189] = data1.c[9, 1].ToString();/* A1[190] =  data1.c[10, 1].ToString(); */
                A1[191] = data1.c[11, 1].ToString();
                A1[192] = data1.c[12, 1].ToString();
            }
            if (Convert.ToInt32(RowCountC) > 2)
            {
                A1[193] = data1.c[0, 2].ToString(); A1[194] = data1.c[2, 2].ToString(); A1[195] = data1.c[1, 2].ToString(); /*A1[196] = data1.c[3, 2].ToString();*/
                if (data1.c[1, 2].ToString() == "1") { A1[197] = "-"; } else { A1[197] = data1.c[4, 2].ToString(); }
                A1[198] = data1.c[7, 2].ToString(); A1[199] = data1.c[8, 2].ToString(); A1[200] = data1.c[9, 2].ToString(); /*A1[201] =  data1.c[10, 2].ToString(); */
                A1[202] = data1.c[11, 2].ToString();
                A1[203] = data1.c[12, 2].ToString();
            }
            if (Convert.ToInt32(RowCountC) > 3)
            {
                A1[204] = data1.c[0, 3].ToString(); A1[205] = data1.c[2, 3].ToString(); A1[206] = data1.c[1, 3].ToString(); /*A1[207] = data1.c[3, 3].ToString();*/
                if (data1.c[1, 3].ToString() == "1") { A1[208] = "-"; } else { A1[208] = data1.c[4, 3].ToString(); }
                A1[209] = data1.c[7, 3].ToString(); A1[210] = data1.c[8, 3].ToString(); A1[211] = data1.c[9, 3].ToString(); /*A1[212] =  data1.c[10,3].ToString(); */
                A1[213] = data1.c[11, 3].ToString();
                A1[214] = data1.c[12, 3].ToString();
            }
            if (Convert.ToInt32(RowCountC) > 4)
            {
                A1[215] = data1.c[0, 4].ToString(); A1[216] = data1.c[2, 4].ToString(); A1[217] = data1.c[1, 4].ToString();/* A1[218] = data1.c[3, 4].ToString();*/
                if (data1.c[1, 4].ToString() == "1") { A1[219] = "-"; } else { A1[219] = data1.c[4, 4].ToString(); }
                A1[220] = data1.c[7, 4].ToString(); A1[221] = data1.c[8, 4].ToString(); A1[222] = data1.c[9, 4].ToString();/* A1[223] =  data1.c[10,4].ToString(); */
                A1[224] = data1.c[11, 4].ToString();
                A1[225] = data1.c[12, 4].ToString();
            }
            if (Convert.ToInt32(RowCountC) > 5)
            {
                A1[226] = data1.c[0, 5].ToString(); A1[227] = data1.c[2, 5].ToString(); A1[228] = data1.c[1, 5].ToString(); /*A1[229] = data1.c[3, 5].ToString();*/
                if (data1.c[1, 5].ToString() == "1") { A1[230] = "-"; } else { A1[230] = data1.c[4, 5].ToString(); }
                //A1[230] = data1.c[4, 5].ToString();
                A1[231] = data1.c[7, 5].ToString(); A1[232] = data1.c[8, 5].ToString(); A1[233] = data1.c[9, 5].ToString();/* A1[234] =  data1.c[10, 5].ToString(); */
                A1[235] = data1.c[11, 5].ToString();
                A1[236] = data1.c[12, 5].ToString();
            }
            ////// Таблицы заполнить СПЕЦ.РАЗР
            if (XDate[12].ToString() != "False")
            {
                A1[80] = data1.b[10, 0].ToString(); 
                A1[91] = data1.b[10, 1].ToString();
                if (A1[94] != "" && A1[94] != null) { A1[102] = data1.b[10, 2].ToString(); }
                if (A1[105] != "" && A1[105] != null) { A1[113] = data1.b[10, 3].ToString(); }
                if (A1[116] != "" && A1[116] != null) { A1[124] = data1.b[10, 4].ToString(); }
                if (A1[127] != "" && A1[127] != null) { A1[135] = data1.b[10, 5].ToString(); }
                if (A1[138] != "" && A1[138] != null) { A1[146] = data1.b[10, 6].ToString(); }
                if (A1[149] != "" && A1[149] != null) { A1[157] = data1.b[10, 7].ToString(); }
                if (A1[160] != "" && A1[160] != null) { A1[168] = data1.b[10, 8].ToString(); }

                if (A1[171] != "" && A1[171] != null) { A1[179] = data1.c[10, 0].ToString(); }
                if (A1[182] != "" && A1[182] != null) { A1[190] = data1.c[10, 1].ToString(); }
                if (A1[193] != "" && A1[193] != null) { A1[201] = data1.c[10, 2].ToString(); }
                if (A1[204] != "" && A1[204] != null) { A1[212] = data1.c[10, 3].ToString(); }
                if (A1[215] != "" && A1[215] != null) { A1[223] = data1.c[10, 4].ToString(); }
                if (A1[226] != "" && A1[226] != null) { A1[234] = data1.c[10, 5].ToString(); }
            }
            else
            {
                A1[80] = "-";
                A1[91] = "-";
                if (A1[94] != "" && A1[94] != null) { A1[102] = "-"; }
                if (A1[105] != "" && A1[105] != null) { A1[113] = "-"; }
                if (A1[116] != "" && A1[116] != null) { A1[124] = "-"; }
                if (A1[127] != "" && A1[127] != null) { A1[135] = "-"; }
                if (A1[138] != "" && A1[138] != null) { A1[146] = "-"; }
                if (A1[149] != "" && A1[149] != null) { A1[157] = "-"; }
                if (A1[160] != "" && A1[160] != null) { A1[168] = "-"; }

                if (A1[171] != "" && A1[171] != null) { A1[179] = "-"; }
                if (A1[182] != "" && A1[182] != null) { A1[190] = "-"; }
                if (A1[193] != "" && A1[193] != null) { A1[201] = "-"; }
                if (A1[204] != "" && A1[204] != null) { A1[212] = "-"; }
                if (A1[215] != "" && A1[215] != null) { A1[223] = "-"; }
                if (A1[226] != "" && A1[226] != null) { A1[234] = "-"; }
            }
            //////
            if (numberSR != null)
            { A1[218] = Convert.ToString(dateSR.ToString()); A1[229] = Convert.ToString(NZaprF.ToString()/* + " " + numberSR.ToString()*/); }
            else { A1[218] = "-"; A1[229] = "-"; }
            A1[237] = "-"; A1[238] = "-"; A1[239] = "-"; A1[240] = "-";
            A1[241] = "-"; A1[242] = "-"; A1[243] = "-"; A1[244] = "-";
            A1[245] = "Настоящий акт № " + NRUB + "-" + data1.a[4] + " составлен в автоматическом режиме";
            A1[246] = "Настоящий акт направлен в ЦАФАП ОДД ГИБДД УМВД  России по г. Севастополю"; A1[247] = "-"; A1[248] = "-"; A1[249] = "-";
            /*SPEED*/
            A1[251] = SPEED_ALL[0]; A1[252] = SPEED_ALL[1]; A1[253] = SPEED_ALL[2]; A1[254] = SPEED_ALL[3]; A1[255] = SPEED_ALL[4]; A1[256] = SPEED_ALL[5]; A1[257] = SPEED_ALL[6];
            A1[258] = EDIzmM; A1[259] = SubKKl.ToString();

             //A1[245] = "В автоматическом режиме составлен настоящий акт № " + NRUB + "-" + data1.a[4];
             //A1[246] = "Настоящий акт отправлен в ЦАФАП ОГИБДД УМВД России по городу Севастополю"; A1[247] = "-"; A1[248] = "-"; A1[249] = "-";
            AKT_PDF_New AKT = new AKT_PDF_New();
            if (ImOb != null)
            {               
                    //if (ImPl != null)
                    //{ AKT.FormPDFN(Im, ImPl, ImOb, A1, NRUB, GDAng.ToString(), ImROb, ImAlt, ImR, ImAltR, KNR, IDW, PLN); }
                    //else if (ImPlR != null)
                    /*{ */AKT.FormPDFN(Im, ImPlR, ImOb, A1, NRUB, GDAng.ToString(), ImROb, ImAlt, ImR, ImAltR, KNR, IDW, PLN);/* }*/
            }
            //else if (ImAlt != null)
            //{
            //    if (ImPl != null)
            //    { AKT.FormPDFN(Im, ImPl, ImAlt, A1, NRUB, GDAng.ToString(), ImROb, ImOb, ImR, ImAltR, KNR, IDW, PLN); }
            //    else if (ImPlR != null)
            //    { AKT.FormPDFN(Im, ImPlR, ImAlt, A1, NRUB, GDAng.ToString(), ImROb, ImOb, ImR, ImAltR, KNR, IDW, PLN); }
            //}
            //else 
            //{
            //    if (ImPl != null)
            //    { AKT.FormPDFN(Im, ImPl, ImAltR, A1, NRUB, GDAng.ToString(), ImROb, ImOb, ImR, ImAltR, KNR, IDW, PLN); }
            //    else if (ImPlR != null)
            //    { AKT.FormPDFN(Im, ImPlR, ImAltR, A1, NRUB, GDAng.ToString(), ImROb, ImOb, ImR, ImAltR, KNR, IDW, PLN); }
            //}
            DateTime YesterdayDateA = DateTime.Today.Date;
            
            NamPD = @"F:\\archivACT\\act\\" + YesterdayDateA.ToString("dd_MM_yyyy") + @"\\" + GDAng.ToString() + ".pdf";//@"F:\\archiv\\AKT\\" + GDAng.ToString() + ".pdf"; //A1[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";

            // ... и запускам сразу в программе просмотра pdf файлов
        }
        #region //////////////////////////////////////////////////////////////// заполняем ПДК по осям и превышения (левая)    ////////////////////////////////

        public void PDKOs() {
          try { 
                KNR = new int[2, 10];
                ZOsPDK();

                #region //////////////////////////////////////////////////////////////// заполняем ПДК по тележкам и превышения (левая)    ////////////////////////////////
                KNR[1, 0] = Convert.ToInt32(TypO[1]);
                KNR[0, 0] = 1;
                //data1.c[9, 0] = Convert.ToString(PDKO[1]);// / Convert.ToInt32(TypO[ic + 1]);
                namesGRUP[0].BaseNumber = data1.c[0, 0];
                namesGRUP[0].massFact = data1.c[7, 0];
                //namesGRUP[0].massSR = data1.c[10, 0];
                namesGRUP[0].massK = data1.c[8, 0];
                namesGRUP[0].CountAxesInGroup = data1.c[1, 0];
                namesGRUP[0].skatnost = data1.c[2, 0];
                //namesGRUP[0].PDKmass = data1.c[9, 0];
                if (data1.c[4, 0] != "-")
                { namesGRUP[0].BaseDistance = data1.c[4, 0]; }
                else { namesGRUP[0].BaseDistance = "0"; }
                ///////////////////////////////////////////       Заполняем первую строку ///////////////////////////////////////////////////
                if (KNR[1, 0] == 1)
                {
                    data1.c[9, 0] = Convert.ToString(PDKO[1]);// / Convert.ToInt32(TypO[ic + 1]);
                    //namesGRUP[0].BaseNumber = data1.c[0, 0];
                    //namesGRUP[0].massFact= data1.c[7, 0];
                    ////namesGRUP[0].massSR = data1.c[10, 0];
                    //namesGRUP[0].massK = data1.c[8, 0];
                    //namesGRUP[0].CountAxesInGroup = data1.c[1, 0];
                    //namesGRUP[0].skatnost = data1.c[2, 0];
                    namesGRUP[0].PDKmass= data1.c[9, 0];
                    //namesGRUP[0].BaseDistance = data1.c[4, 0];
                    if (data1.c[8, 0] == "-") { c8 = 0; } else { c8 = Math.Round(Convert.ToDouble(data1.c[8, 0])); }
                    if (data1.c[9, 0] == "-") { c9 = 0; } else { c9 = Math.Round(Convert.ToDouble(data1.c[9, 0])); }
                   
                   

                    if (names3[1].massSR == "0")
                    {
                        namesGRUP[0].massSR = "0";
                        data1.c[10, 0] = "-";
                    if (data1.c[10, 0] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, 0])); }
                        if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c9)) * 100 - 100, 2) > 0)
                        {
                            data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c9)) * 100 - 100, 0));
                            data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(c9), 2));
                            if (data1.c[11, 0] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, 0])); }
                            if (data1.c[12, 0] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, 0])); }
                            if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c9)) * 100 - 100, 0) >= 3)
                            {
                                namesGRUP[0].DifferencePDKFact= c11.ToString(); 
                                namesGRUP[0].massPrev= data1.c[12, 0];
                                namesGRUP[0].massPrevSR = "0";
                                namesGRUP[0].massSign = "true";
                                SigGr = "true";
                                namesGRUP[0].factPremission = "false";

                                XDate[31] = "True";
                                PrevNar[10] = Math.Round(Convert.ToDouble(c11), 0);
                                PrevNar[37] = 1;
                            }
                            else { XDate[31] = "False";
                                namesGRUP[0].DifferencePDKFact = "0";
                                namesGRUP[0].massPrevSR = "0";
                                namesGRUP[0].massSign = "false";
                                namesGRUP[0].massPrev = "0";
                                namesGRUP[0].factPremission = "false";
                            }
                        }
                        else
                        {
                            data1.c[11, 0] = "-";
                            data1.c[12, 0] = "-";
                            namesGRUP[0].DifferencePDKFact = "0";
                            namesGRUP[0].massPrevSR = "0";
                            namesGRUP[0].massSign = "false";
                            namesGRUP[0].massPrev = "0";
                            namesGRUP[0].factPremission = "false";
                        }
                    }
                    else
                    {
                        namesGRUP[0].massSR = names3[1].massSR;
                        data1.c[10, 0] = names3[1].massSR;
                        if (data1.c[10, 0] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, 0])); }
                        if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(names3[1].massSR)) * 100 - 100, 2) > 0)
                        {
                            data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(names3[0].massSR)) * 100 - 100, 0));
                            data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(names3[0].massSR), 2));
                            if (data1.c[11, 0] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, 0])); }
                            if (data1.c[12, 0] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, 0])); }
                            if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(names3[0].massSR)) * 100 - 100, 0) >= 3)
                            {
                                namesGRUP[0].massPrevSR = Convert.ToString(c12);
                                namesGRUP[0].massPrev = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(c9), 2));
                                namesGRUP[0].PDKmass = Convert.ToString(c9);
                                namesGRUP[0].massSign = "true";
                               SigGr = "true";
                                namesGRUP[0].DifferencePDKFact = c11.ToString();
                                namesGRUP[0].factPremission = "true";

                                XDate[31] = "True";
                                PrevNar[10] = Math.Round(Convert.ToDouble(c11), 0);
                                PrevNar[37] = 1;
                            }
                            else { XDate[31] = "False";
                                namesGRUP[0].PDKmass = Convert.ToString(c9);
                                namesGRUP[0].massSign = "false";
                                namesGRUP[0].massPrevSR = "0";
                                namesGRUP[0].massPrev = "0";
                                namesGRUP[0].DifferencePDKFact = "0";
                                namesGRUP[0].factPremission = "false";

                            }
                        }
                        else
                        {
                            data1.c[11, 0] = "-"; data1.c[12, 0] = "-"; PrevNar[10] = 0;
                            namesGRUP[0].PDKmass = Convert.ToString(c9);
                            namesGRUP[0].massSign = "false";
                            namesGRUP[0].massPrevSR = "0";
                            namesGRUP[0].massPrev = "0";
                            namesGRUP[0].DifferencePDKFact = "0";
                            namesGRUP[0].factPremission = "false";

                        }
                    }
                }
                else if (KNR[1, 0] > 1 && KNR[1, 0] < 4)
                {
                    D1_2 = 0;
                    D1S_2S = 0;
                    for (icC = 1; icC <= TypO[1]; icC++)
                    {
                        D1_2 = D1_2 + PDKTel[icC];
                        D1S_2S = D1S_2S + Convert.ToDouble(names3[icC].massSR);////-1].massSR);
                    }
                    data1.c[9, 0] = Convert.ToString(D1_2 / TypO[1]);//icC;// / Convert.ToInt32(TypO[ic + 1]);
                    if (data1.c[8, 0] == "-") { c8 = 0; } else { c8 = Math.Round(Convert.ToDouble(data1.c[8, 0])); }
                    if (data1.c[9, 0] == "-") { c9 = 0; } else { c9 = Math.Round(Convert.ToDouble(data1.c[9, 0])); }
                    if (names3[1].massSR == "0")
                    {
                        namesGRUP[0].massSR = "0";
                        data1.c[10, 0] = "-";
                        if (data1.c[10, 0] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, 0])); }
                        if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c9)) * 100 - 100, 2) > 0)
                        {
                            data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 0));
                            data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) - Convert.ToDouble(data1.c[9, 0]), 2));
                            if (data1.c[11, 0] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, 0])); }
                            if (data1.c[12, 0] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, 0])); }
                            if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c9)) * 100 - 100, 0) >= 3)
                            {
                                namesGRUP[0].massPrevSR = "0";
                                namesGRUP[0].massPrev = Convert.ToString(c12);
                                namesGRUP[0].PDKmass = Convert.ToString(c9);
                                namesGRUP[0].massSign = "true";
                                SigGr = "true";
                                namesGRUP[0].DifferencePDKFact = c11.ToString();
                                namesGRUP[0].factPremission = "false";

                                XDate[31] = "True";
                                PrevNar[10] = Convert.ToDouble(c11);
                                PrevNar[37] = 1;

                                for (icC = 1; icC <= TypO[1]; icC++)
                                {
                                    PDKOsTel[icC] = 1;
                                }
                            }
                            else { XDate[31] = "False";
                                namesGRUP[0].PDKmass = Convert.ToString(c9);
                                namesGRUP[0].massSign = "false";
                                namesGRUP[0].massPrevSR = "0";
                                namesGRUP[0].massPrev = "0";
                                namesGRUP[0].DifferencePDKFact = "0";
                                namesGRUP[0].factPremission = "false";
                            }
                        }
                        else
                        {
                            PrevNar[10] = 0;
                            data1.c[11, 0] = "-";
                            data1.c[12, 0] = "-";
                            namesGRUP[0].PDKmass = Convert.ToString(c9);
                            namesGRUP[0].massSign = "false";
                            namesGRUP[0].massPrevSR = "0";
                            namesGRUP[0].massPrev = "0";
                            namesGRUP[0].DifferencePDKFact = "0";
                            namesGRUP[0].factPremission = "false";
                        }
                    }
                    else
                    {
                        namesGRUP[0].massSR = Convert.ToString(D1S_2S);
                        data1.c[10, 0] = Convert.ToString(D1S_2S);// / TypO[1];
                        if (data1.c[8, 0] == "-") { c8 = 0; } else { c8 = Math.Round(Convert.ToDouble(data1.c[8, 0])); }
                        if (data1.c[9, 0] == "-") { c9 = 0; } else { c9 = Math.Round(Convert.ToDouble(data1.c[9, 0])); }
                        if (data1.c[10, 0] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, 0])); }
                        if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c10)) * 100 - 100, 2) > 0)
                        {
                            data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c10)) * 100 - 100, 0));
                            data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(c10), 2));
                            if (data1.c[11, 0] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, 0])); }
                            if (data1.c[12, 0] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, 0])); }
                            if (Math.Round(Convert.ToDouble(c8) / (Convert.ToDouble(c10)) * 100 - 100, 0) >= 3)
                            {
                                namesGRUP[0].massPrevSR = Convert.ToString(c12);
                                namesGRUP[0].massPrev = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(c9), 2));
                                namesGRUP[0].PDKmass = Convert.ToString(c9);
                                namesGRUP[0].massSign = "true";
                                SigGr = "true";
                                namesGRUP[0].DifferencePDKFact = c11.ToString();
                                namesGRUP[0].factPremission = "true";

                                XDate[31] = "True";
                                PrevNar[10] = Math.Round(Convert.ToDouble(c11), 0);
                                PrevNar[37] = 1;
                                for (icC = 1; icC <= TypO[1]; icC++)
                                {
                                    PDKOsTel[icC] = 1;
                                }

                            }
                            else { XDate[31] = "False";
                                namesGRUP[0].PDKmass = Convert.ToString(c9);
                                namesGRUP[0].massSign = "false";
                                namesGRUP[0].massPrevSR = "0";
                                namesGRUP[0].massPrev = "0";
                                namesGRUP[0].DifferencePDKFact = "0";
                                namesGRUP[0].factPremission = "false";
                            }
                        }
                        else
                        {
                            PrevNar[10] = 0;
                            data1.c[11, 0] = "-";
                            data1.c[12, 0] = "-";
                            namesGRUP[0].PDKmass = Convert.ToString(c9);
                            namesGRUP[0].massSign = "false";
                            namesGRUP[0].massPrevSR = "0";
                            namesGRUP[0].massPrev = "0";
                            namesGRUP[0].DifferencePDKFact = "0";
                            namesGRUP[0].factPremission = "false";
                        }
                    }
                }
                else if (KNR[1, 0] > 3)
                {
                    XDate[31] = "False";
                    data1.c[2, 0] = "-";
                    data1.c[9, 0] = "-";
                    data1.c[10, 0] = "-";
                    data1.c[11, 0] = "-";
                    data1.c[12, 0] = "-";
                    PrevNar[10] = 0;
                    namesGRUP[0].massSR = "0";
                    namesGRUP[0].massSign = "false";
                    namesGRUP[0].massPrev = "0";
                    namesGRUP[0].PDKmass = "0";
                    namesGRUP[0].massPrevSR = "0";
                    namesGRUP[0].DifferencePDKFact = "0";
                    namesGRUP[0].factPremission = "false";
                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////// Заполняем строки таблицы больше чем первая 
                Fx = 0;
                for (ic = 1; ic < GrO; ic++)
                {
                    Sk = "";
                    for (j = 0; j <= ic; j++)
                    {
                        Sk = Sk + Convert.ToString(KNR[1, j]);
                    }
                    Sk = Sk + "1";
                    Fx = 0;
                    for (j = 0; j < Sk.Length; j++)
                    {
                        Fx = Fx + int.Parse(Convert.ToString(Sk[j]));
                    }
                    KNR[1, ic] = Convert.ToInt32(TypO[Fx]);//Количество
                    KNR[0, ic] = Fx; //Позиция
                }
                ////////////////////////////////////////////////////////////////////
                for (ic = 1; ic < GrO; ic++)
                {
                   
                    if (KNR[1, ic] == 1)
                    {
                        data1.c[9, ic] = Convert.ToString(PDKO[KNR[0, ic]]);// / Convert.ToInt32(TypO[ic + 1]);
                                                                         //data1.c[10, ic] = names3[ic].massSR;
                                                                            //if ((data1.c[10, ic] == null) || data1.c[10, ic] == "") {
                        if (names3[ic].massSR == "0")
                        {
                            data1.c[10, ic] = "-";
                            if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 2) > 0)
                            {
                                data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0));
                                data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[9, ic]), 2));
                                if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0) >= 3)
                                {
                                    XDate[31] = "True";
                                    PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
                                    PrevNar[37] = 1;
                                }
                                else { XDate[31] = "False"; }
                            }
                            else
                            {
                                data1.c[11, ic] = "-"; data1.c[12, ic] = "-"; PrevNar[ic + 10] = 0;
                            }
                        }
                        else
                        {
                            data1.c[10, ic] = names3[ic].massSR;
                            if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 2) > 0)
                            {
                                data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0));
                                data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[10, ic]), 2));
                                if (/*Math.Floor(*/Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0)/*)*/ >= 3)
                                {
                                    XDate[31] = "True";
                                    PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
                                    PrevNar[37] = 1;
                                }
                                else { XDate[31] = "False"; }
                            }
                            else
                            {
                                data1.c[11, ic] = "-"; data1.c[12, ic] = "-"; PrevNar[ic + 10] = 0;
                            }
                        }
                    }
                    else if (KNR[1, ic] > 1 && KNR[1, ic] < 4)
                    {
                        D1_2 = 0;
                        D1S_2S = 0;
                        for (icC = KNR[0, ic]; icC < (KNR[0, ic] - 1 + KNR[1, ic]); icC++)
                        {
                            D1S_2S = D1S_2S + Convert.ToDouble(names3[icC].massSR); ////-1].massSR);
                            if (icC < 8)
                            {
                                D1_2 = PDKTel[icC + 1];
                            }
                        }
                        data1.c[9, ic] = Convert.ToString(D1_2);// / Convert.ToInt32(TypO[ic + 1]);
                        if (names3[ic].massSR == "0")
                        {
                            data1.c[10, 0] = "-";
                            //data1.c[10, 0] = Convert.ToString(Convert.ToDouble(names3[0].massSR));
                            //data1.c[10, ic] = Convert.ToString(Convert.ToDouble(names3[ic].massSR) * KNR[1, ic]);
                            //if ((data1.c[10, ic] == null) || data1.c[10, ic] == "") { data1.c[10, ic] = "0"; }
                            //if ((data1.c[10, 0] == null) || data1.c[10, 0] == "") { data1.c[10, 0] = "0"; }
                            if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 2) > 0)
                            {
                                data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0));
                                data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[9, ic]), 2));
                                if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0) >= 3)
                                {
                                    XDate[31] = "True";
                                    PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
                                    PrevNar[37] = 1;
                                    for (icC = KNR[0, ic]; icC <= (KNR[0, ic] - 1 + KNR[1, ic]); icC++)
                                    {
                                        if (icC < 8)
                                        {
                                            PDKOsTel[icC] = 2;
                                        }
                                    }
                                }
                                else { XDate[31] = "False"; }
                            }
                            else
                            {
                                data1.c[11, ic] = "-";
                                data1.c[12, ic] = "-";
                                PrevNar[ic + 10] = 0;
                                //}
                            }
                        }
                        else
                        {
                            //dataGridView2[10, 0].Value = Convert.ToString(Convert.ToDouble(names3[0].massSR));
                            data1.c[10, ic] = Convert.ToString(Convert.ToDouble(names3[ic].massSR) * KNR[1, ic]);
                            if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 2) > 0)
                            {
                                data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0));
                                data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[10, ic]), 2));
                                if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0) >= 3)
                                {
                                    XDate[31] = "True";
                                    PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
                                    PrevNar[37] = 1;
                                    for (icC = KNR[0, ic]; icC <= (KNR[0, ic] - 1 + KNR[1, ic]); icC++)
                                    {
                                        if (icC < 8)
                                        {
                                            PDKOsTel[icC] = 2;

                                        }
                                    }
                                }
                                else { XDate[31] = "False"; }
                            }
                            else
                            {
                                data1.c[11, ic] = "-"; data1.c[12, ic] = "-"; PrevNar[ic + 10] = 0;
                                //}
                            }
                        }
                    }
                    else if (KNR[1, ic] > 3)
                    {
                        XDate[31] = "False";
                        data1.c[2, ic] = "-";
                        data1.c[9, ic] = "-";
                        data1.c[10, ic] = "-";
                        data1.c[11, ic] = "-";
                        data1.c[12, ic] = "-";
                    }
                    ////////////////////////////////////////////////////////////////////////
                    //if (data1.c[8, ic]=="-") { c8 = 0; } else { c8 = Math.Round(Convert.ToDouble(data1.c[8, ic])); }
                    //if (data1.c[9, ic] == "-") { c9 = 0; } else { c9 = Math.Round(Convert.ToDouble(data1.c[9, ic])); }
                    //if (data1.c[10, ic] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, ic])); }
                    //if (data1.c[11, ic] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, ic])); }
                    //if (data1.c[12, ic] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, ic])); }

                    if (names3[ic].massSR == "0")
                    {
                        if (data1.c[8, ic] == "-") { c8 = 0; } else { c8 = Math.Round(Convert.ToDouble(data1.c[8, ic])); }
                        if (data1.c[9, ic] == "-") { c9 = 0; } else { c9 = Math.Round(Convert.ToDouble(data1.c[9, ic])); }
                        if (data1.c[10, ic] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, ic])); }
                        if (data1.c[11, ic] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, ic])); }
                        if (data1.c[12, ic] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, ic])); }
                        namesGRUP[ic].massSR = "0";
                        namesGRUP[ic].massPrev = Convert.ToString(Math.Round(c8 - c9));
                        namesGRUP[ic].PDKmass = Convert.ToString(c9);
                        namesGRUP[ic].massPrevSR = "0";
                        namesGRUP[ic].factPremission = "false";
                        if (data1.c[11, ic] != "-")
                        {
                            if (Convert.ToDouble(data1.c[11, ic]) > 3)
                            {
                                namesGRUP[ic].massSign = "true";
                                SigGr = "true";
                                namesGRUP[ic].DifferencePDKFact = c11.ToString();
                            }
                            else
                            {
                                namesGRUP[ic].massSign = "false";
                                namesGRUP[ic].massPrev = "0";
                                namesGRUP[ic].massPrevSR = "0";
                                namesGRUP[ic].DifferencePDKFact = "0";
                                namesGRUP[ic].factPremission = "false";
                            }
                        }
                    }
                    else
                    {
                        if (data1.c[8, ic] == "-") { c8 = 0; } else { c8 = Math.Round(Convert.ToDouble(data1.c[8, ic])); }
                        if (data1.c[9, ic] == "-") { c9 = 0; } else { c9 = Math.Round(Convert.ToDouble(data1.c[9, ic])); }
                        if (data1.c[10, ic] == "-") { c10 = 0; } else { c10 = Math.Round(Convert.ToDouble(data1.c[10, ic])); }
                        if (data1.c[11, ic] == "-") { c11 = 0; } else { c11 = Math.Round(Convert.ToDouble(data1.c[11, ic])); }
                        if (data1.c[12, ic] == "-") { c12 = 0; } else { c12 = Math.Round(Convert.ToDouble(data1.c[12, ic])); }
                        namesGRUP[ic].massSR = c10.ToString();
                        namesGRUP[ic].massPrevSR = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(namesGRUP[ic].massSR), 2));
                        namesGRUP[ic].massPrev = Convert.ToString(Math.Round(Convert.ToDouble(c8) - Convert.ToDouble(c9), 2));
                        namesGRUP[ic].PDKmass = Convert.ToString(c9);
                        if (data1.c[11, ic] != "-")
                        {
                            if (Convert.ToDouble(data1.c[11, ic]) > 2)
                            {
                                namesGRUP[ic].massSign = "true";
                                SigGr = "true";
                                namesGRUP[ic].DifferencePDKFact = c11.ToString();
                                namesGRUP[ic].factPremission = "true";
                            }
                            else
                            {
                                namesGRUP[ic].massSign = "false";
                                namesGRUP[ic].massPrevSR = "0";
                                namesGRUP[ic].massPrev = "0";
                                namesGRUP[ic].DifferencePDKFact = "0";
                                namesGRUP[ic].factPremission = "false";
                            }
                        }
                    }
                    namesGRUP[ic].BaseNumber = data1.c[0, ic];
                    namesGRUP[ic].massFact = data1.c[7, ic];
                    //namesGRUP[ic].massSR = data1.c[10, ic];
                    namesGRUP[ic].massK = c8.ToString();
                    namesGRUP[ic].CountAxesInGroup = data1.c[1, ic];
                    namesGRUP[ic].skatnost = data1.c[2, ic];
                    namesGRUP[ic].PDKmass = c9.ToString();
                    namesGRUP[ic].BaseDistance = data1.c[4, ic];

                }
                #endregion ///////////////////////////////////////////

                #region //////////////////////////////////////////////////////////////// заполняем ПДК по осям и превышения (левая)    ////////////////////////////////
                for (ic = 0; ic < (KolOs); ic++) //Convert.ToInt32(alphaBlendTextBox13.Text)); ic++)
                {
                    if (ic < 9)
                    {
                        if (PDKOsTel[ic + 1] == 0 && Convert.ToInt32(TypO[ic + 1]) < 4)
                        //if (PDKO[ic + 1] != 0)
                        {
                            data1.b[9, ic] = Convert.ToString(PDKO[ic + 1]);
                            //data1.b[10, ic] = names3[ic].massSR;
                            if (names3[ic].massSR == "0")
                            //if ((data1.b[10, ic] == null) || data1.b[10, ic] == "" || data1.b[10, ic] == "0")
                            {
                                data1.b[10, ic] = "-"; /*}*/
                                if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (PDKO[ic + 1]) * 100 - 100, 2) > 0)
                                {
                                    data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (PDKO[ic + 1]) * 100 - 100, 0));
                                    data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - PDKO[ic + 1], 2));
                                    if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (PDKO[ic + 1]) * 100 - 100, 0) >= 3)
                                    {
                                        XDate[31] = "True";
                                        PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
                                        PrevNar[37] = 1;
                                    }
                                    else { XDate[31] = "False"; }
                                }
                                else
                                {
                                    data1.b[11, ic] = "-";
                                    data1.b[12, ic] = "-";
                                }
                            }
                            else
                            {
                                data1.b[10, ic] = names3[ic].massSR;
                                if (Math.Round((Convert.ToDouble(data1.b[8, ic]) / Convert.ToDouble(names3[ic].massSR) * 100 - 100), 2) > 0)
                                {
                                    data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / Convert.ToDouble(names3[ic].massSR) * 100 - 100, 0));
                                    data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
                                    if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / Convert.ToDouble(names3[ic].massSR) * 100 - 100, 0) > 2)
                                    {
                                        XDate[31] = "True";
                                        PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
                                        PrevNar[37] = 1;
                                    }
                                    else { XDate[31] = "False"; }
                                    //dataGridView1.Rows[ic].DefaultCellStyle.BackColor = Color.LightPink;//.Red;
                                }
                                else
                                {
                                    data1.b[11, ic] = "-";
                                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                    data1.b[12, ic] = "-";
                                }
                            }
                        }
                        else if (Convert.ToInt32(TypO[ic + 1]) < 4)
                        {
                            data1.b[9, ic] = Convert.ToString(PDKTel[ic + 1] / Convert.ToInt32(TypO[ic + 1]));
                            //data1.b[10, ic] = names3[ic].massSR;
                            //if ((data1.b[10,ic] == null) || data1.b[10, ic] =="")
                            if (names3[ic].massSR == "0")
                            {
                                data1.b[10, ic] = "-";
                                if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 2) > 0)
                                {
                                    data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 0));
                                    data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(data1.b[9, ic]), 2));
                                    if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 0) >= 3)
                                    {
                                        XDate[31] = "True";
                                        PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
                                        PrevNar[37] = 1;
                                    }
                                    else { XDate[31] = "False"; }
                                }
                                else
                                {
                                    data1.b[11, ic] = "-";
                                    data1.b[12, ic] = "-";
                                }
                            }
                            else
                            {
                                data1.b[10, ic] = names3[ic].massSR;
                                if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 2) > 0)
                                {
                                    data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0));
                                    data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
                                    if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0) > 2)
                                    { XDate[31] = "True"; PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]); PrevNar[37] = 1; }
                                    else { XDate[31] = "False"; }
                                    //dataGridView1.Rows[ic].DefaultCellStyle.BackColor = Color.LightPink;//.Red;
                                }
                                else
                                { data1.b[11, ic] = "-"; data1.b[12, ic] = "-"; }
                            }
                        }
                        else if (Convert.ToInt32(TypO[ic + 1]) > 3)
                        {
                            data1.b[9, ic] = Convert.ToString(PDKO[ic + 1]);
                            //data1.b[10, ic] = names3[ic].massSR;
                            //if ((data1.b[10, ic] == null) || data1.b[10, ic] == "")
                            if (names3[ic].massSR == "0")
                            {
                                data1.b[10, ic] = "-";
                                if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 2) > 0)
                                {
                                    data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 0));
                                    data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(data1.b[9, ic]), 2));
                                    if (Math.Floor(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 2)) >= 3)
                                    {
                                        XDate[31] = "True";
                                        PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
                                        PrevNar[37] = 1;
                                    }
                                    else { XDate[31] = "False"; }
                                }
                                else
                                {
                                    data1.b[11, ic] = "-";
                                    data1.b[12, ic] = "-";
                                }
                            }
                            else
                            {
                                data1.b[10, ic] = names3[ic].massSR;
                                if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 2) > 0)
                                {
                                    data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0));
                                    data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
                                    if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0) > 2)
                                    { XDate[31] = "True"; PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]); PrevNar[37] = 1; }
                                    else { XDate[31] = "False"; }
                                }
                                else
                                { data1.b[11, ic] = "-"; data1.b[12, ic] = "-"; }
                            }
                        }
                    }

                    //if (data1.b[8, ic] == "-") { b8 = 0; } else { b8 = Math.Round(Convert.ToDouble(data1.b[8, ic])); }
                    //if (data1.b[9, ic] == "-") { b9 = 0; } else { b9 = Math.Round(Convert.ToDouble(data1.b[9, ic])); }
                    //if (data1.b[10, ic] == "-") { b10 = 0; } else { b10 = Math.Round(Convert.ToDouble(data1.b[10, ic])); }
                    //if (data1.b[11, ic] == "-") { b11 = 0; } else { b11 = Math.Round(Convert.ToDouble(data1.b[11, ic])); }
                    //if (data1.b[12, ic] == "-") { b12 = 0; } else { b12 = Math.Round(Convert.ToDouble(data1.b[12, ic])); }

                    if (names3[ic].massSR == "0")
                    {
                        if (data1.b[8, ic] == "-") { b8 = 0; } else { b8 = Math.Round(Convert.ToDouble(data1.b[8, ic])); }
                        if (data1.b[9, ic] == "-") { b9 = 0; } else { b9 = Math.Round(Convert.ToDouble(data1.b[9, ic])); }
                        if (data1.b[10, ic] == "-") { b10 = 0; } else { b10 = Math.Round(Convert.ToDouble(data1.b[10, ic])); }
                        if (data1.b[11, ic] == "-") { b11 = 0; } else { b11 = Math.Round(Convert.ToDouble(data1.b[11, ic])); }
                        if (data1.b[12, ic] == "-") { b12 = 0; } else { b12 = Math.Round(Convert.ToDouble(data1.b[12, ic])); }
                        if (Math.Round(Convert.ToDouble(b8) / (Convert.ToDouble(b9)) * 100 - 100, 2) > 0)
                        {
                            names3[ic].massPrev = Convert.ToString(Math.Round(Convert.ToDouble(b8) - Convert.ToDouble(b9), 2));
                            names3[ic].PDKmass = Convert.ToString(b9);
                        }
                        else
                        {
                            names3[ic].massPrev = "0";
                            names3[ic].PDKmass = Convert.ToString(b9);
                        }

                        if (Convert.ToDouble(names3[ic].massPrev) > 3)
                        {
                            names3[ic].massSign = "true";
                            SigAx = "true";
                            if (data1.b[11, ic].ToString() == "-")
                            { PrevNar[ic] = 0; }
                            else
                            {
                                names3[ic].DifferencePDKFact = b11.ToString();
                                PrevNar[ic] = Convert.ToDouble(b11);
                                PrevNar[37] = 1;
                            }
                        }
                        else
                        {
                            names3[ic].massSign = "false";
                            names3[ic].massPrev = "0";
                            PrevNar[ic] = 0;
                        }
                    }
                    else
                    {
                        if (data1.b[8, ic] == "-") { b8 = 0; } else { b8 = Math.Round(Convert.ToDouble(data1.b[8, ic])); }
                        if (data1.b[9, ic] == "-") { b9 = 0; } else { b9 = Math.Round(Convert.ToDouble(data1.b[9, ic])); }
                        if (data1.b[10, ic] == "-") { b10 = 0; } else { b10 = Math.Round(Convert.ToDouble(data1.b[10, ic])); }
                        if (data1.b[11, ic] == "-") { b11 = 0; } else { b11 = Math.Round(Convert.ToDouble(data1.b[11, ic])); }
                        if (data1.b[12, ic] == "-") { b12 = 0; } else { b12 = Math.Round(Convert.ToDouble(data1.b[12, ic])); }
                        if (Math.Round(Convert.ToDouble(b8) / (Convert.ToDouble(b10)) * 100 - 100, 2) > 0)
                        {
                            names3[ic].massPrevSR = Convert.ToString(Math.Round(Convert.ToDouble(b8) - Convert.ToDouble(names3[ic].massSR), 2));
                            names3[ic].PDKmass = Convert.ToString(b9);
                        }
                        else
                        {
                            names3[ic].massPrevSR = "-";
                            names3[ic].PDKmass = Convert.ToString(b9);
                        }
                        names3[ic].massPrevSR = Convert.ToString(Math.Round(Convert.ToDouble(b8) - Convert.ToDouble(names3[ic].massSR), 2));
                        names3[ic].PDKmass = Convert.ToString(b9);
                        if (Convert.ToDouble(names3[ic].massPrevSR) > 2)
                        {
                            names3[ic].massSign = "true";
                            SigAx = "true";
                            if (data1.b[11, ic].ToString() == "-")
                            { PrevNar[ic] = 0; }
                            else
                            {
                                names3[ic].DifferencePDKFact = b11.ToString();
                                PrevNar[ic] = Convert.ToDouble(b11);
                                PrevNar[37] = 1;
                            }
                        }
                        else
                        {
                            names3[ic].massSign = "false";
                            names3[ic].massPrevSR = "0";
                            PrevNar[ic] = 0;
                        }
                    }
                }
                #endregion //////////////////////////
                PPRNAR = PrevNar[0];
                iNar = 0;
                int INr = 0;
                for (int PrNar = 1; PrNar < 25; PrNar++)
                {
                    if (PrevNar[PrNar] > 0)
                    { iNar = iNar + 1; }
                }
                if (iNar > 0)
                { CodNarAN = new CODE[iNar]; }
                iNar = 0;
                MAXiNar = 0;
                for (int PrNar = 1; PrNar <= 25; PrNar++)
                {
                    CodNar = "";
                    iNar = PrNar;
                    if (PrevNar[PrNar] > PPRNAR && PrNar<25)
                    {
                        PPRNAR = PrevNar[PrNar];
                        MAXiNar = MAXiNar+1;
                    }
                    if (PrevNar[PrNar] > 0)
                    {
                        //INr= INr+1;
                        if (iNar > 0 && iNar < 10)
                        {
                            NNarushen = "IsOverweightPartial";
                            UPDDannNarAndKl(NNarushen);
                            PrevNar[31] = iNar + 1;
                            TypNar = 1;
                            TypNarTXT = "Превышение нагрузки на ось";
                            EDIzm = "( т.)";
                            if (data1.b[12, iNar] != "-" && data1.b[12, iNar] != "")
                            {
                                MAXPREV = Convert.ToDouble(data1.b[12, iNar]); ;
                                MAXPREVPROTC = Convert.ToDouble(data1.b[11, iNar]);
                            }
                            else
                            {
                                MAXPREV = 0; ;
                                MAXPREVPROTC = 0;
                            }
                            PrevNar[30] = 1;
                            if (PrevNar[29] == 1)
                            {
                                PrevNar[32] = 1;
                                if (MAXPREVPROTC >= 2 && MAXPREVPROTC <= 10)
                                { PrevNar[34] = 1; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
                                { PrevNar[34] = 2; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
                                { PrevNar[34] = 3; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
                            }
                            else if (PrevNar[29] == 2)
                            {
                                PrevNar[32] = 2;
                                if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
                                { PrevNar[34] = 4; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
                                { PrevNar[34] = 5; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
                            }
                            names3[Convert.ToInt32(PrevNar[31])-1].NomStatei = PrevNar[34].ToString();
                        }
                        
                        else if (iNar >= 10 && iNar < 17)
                        {
                            NNarushen = "IsOverweightGroup"; //IsOverweightGross  IsOverweightPartial IsOversized IsOverspeed 
                            UPDDannNarAndKl(NNarushen);
                            PrevNar[31] = iNar - 9;
                            TypNar = 2;
                            TypNarTXT = "Превышение нагрузки на группу осей";
                            EDIzm = "( т.)";
                            KOGrNar = KNR[1, iNar - 9];
                            if (data1.c[12, iNar - 10] != "-" && data1.c[12, iNar - 10] != "")
                            {
                                MAXPREV = Convert.ToDouble(data1.c[12, iNar - 10]); ;
                                MAXPREVPROTC = Convert.ToDouble(data1.c[11, iNar - 10]);
                            }
                            else
                            {
                                MAXPREV = 0;
                                MAXPREVPROTC = 0;
                            }
                            PrevNar[30] = 2;
                            if (PrevNar[29] == 1)
                            {
                                PrevNar[32] = 1;
                                if (MAXPREVPROTC >= 2 && MAXPREVPROTC <= 10)
                                { PrevNar[34] = 1; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
                                { PrevNar[34] = 2; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
                                { PrevNar[34] = 3; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
                            }
                            else if (PrevNar[29] == 2)
                            {
                                PrevNar[32] = 2;
                                if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
                                { PrevNar[34] = 4; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
                                { PrevNar[34] = 5; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
                            }
                            namesGRUP[Convert.ToInt32(PrevNar[31])-1].NomStatei = PrevNar[34].ToString();
                        }
                        else if (iNar == 17)
                        {
                            NNarushen = "IsOverweightGross"; //  IsOverweightPartial IsOversized IsOverspeed 
                            UPDDannNarAndKl(NNarushen);
                            TypNar = 3;
                            TypNarTXT = "Превышение общей массы АТС";
                            EDIzm = "( т.)";
                            if (data1.a[52] != "-" && data1.a[52] != "")
                            {
                                MAXPREV = Convert.ToDouble(data1.a[52]);
                                MAXPREVPROTC = Convert.ToDouble(data1.a[53]);
                            }
                            else
                            {
                                MAXPREV = 0;
                                MAXPREVPROTC = 0;
                            }
                            PrevNar[30] = 3;
                            if (PrevNar[29] == 1)
                            {
                                PrevNar[32] = 1;
                                if (MAXPREVPROTC >= 2 && MAXPREVPROTC <= 10)
                                { PrevNar[34] = 1; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
                                { PrevNar[34] = 2; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
                                { PrevNar[34] = 3; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
                            }
                            else if (PrevNar[29] == 2)
                            {
                                PrevNar[32] = 2;
                                if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
                                { PrevNar[34] = 4; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
                                { PrevNar[34] = 5; PrevNar[33] = MAXPREVPROTC; }
                                else if (MAXPREVPROTC >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
                            }
                            CodSTAll = PrevNar[34].ToString();
                            SigAll = "true";
                        }
                        else if (iNar >= 18 && iNar < 21)
                        {
                            NNarushen = "IsOversized"; //IsOverweightGross  IsOverweightPartial  IsOverspeed 
                            UPDDannNarAndKl(NNarushen);
                            TypNar = 4;
                            TypNarTXT = "Превышение габаритов АТС";
                            EDIzm = "( м.)";
                            PrevNar[30] = 4;
                            if (PrevNar[29] == 1)
                            {
                                PrevNar[32] = 1;
                                if (PrevDlPr * 100 >= 1 && PrevDlPr * 100 <= 10)
                                {
                                    PrevNar[34] = 1;/* PrevNar[33] = PrevDlPr; *//*MAXPREV = Convert.ToDouble(XDate[9]);*/
                                    if (iNar == 18)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[9])*/; PrevNar[33] = Convert.ToDouble(XDate[9])*100; MAXPREV = Convert.ToDouble(XDate[9]); }
                                    else if (iNar == 19)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[59]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[10]);*/ PrevNar[33] = Convert.ToDouble(XDate[10]) * 100; MAXPREV = Convert.ToDouble(XDate[10]); }
                                    else if (iNar == 20)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[62]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[11]);*/ PrevNar[33] = Convert.ToDouble(XDate[11]) * 100; MAXPREV = Convert.ToDouble(XDate[11]); }
                                }
                                else if (PrevDlPr * 100 >= 11 && PrevDlPr * 100 <= 20)
                                {
                                    PrevNar[34] = 2; /*PrevNar[33] = PrevDlPr;*//* MAXPREV = Convert.ToDouble(XDate[9]);*/
                                    if (iNar == 18)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[9]);*/ PrevNar[33] = Convert.ToDouble(XDate[9]) * 100; MAXPREV = Convert.ToDouble(XDate[9]); }
                                    else if (iNar == 19)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[59]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[10]);*/ PrevNar[33] = Convert.ToDouble(XDate[10]) * 100; MAXPREV = Convert.ToDouble(XDate[10]); }
                                    else if (iNar == 20)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[62]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[11]);*/ PrevNar[33] = Convert.ToDouble(XDate[11]) * 100; MAXPREV = Convert.ToDouble(XDate[11]); }
                                }
                                else if (PrevDlPr * 100 >= 21 && PrevDlPr * 100 <= 50)
                                {
                                    PrevNar[34] = 3; /*PrevNar[33] = PrevDlPr;*//* MAXPREV = Convert.ToDouble(XDate[9]);*/
                                    if (iNar == 18)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[9]);*/ PrevNar[33] = Convert.ToDouble(XDate[9]) * 100; MAXPREV = Convert.ToDouble(XDate[9]); }
                                    else if (iNar == 19)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[59]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[10]);*/ PrevNar[33] = Convert.ToDouble(XDate[10]) * 100; MAXPREV = Convert.ToDouble(XDate[10]); }
                                    else if (iNar == 20)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[62]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[11]);*/ PrevNar[33] = Convert.ToDouble(XDate[11]) * 100; MAXPREV = Convert.ToDouble(XDate[11]); }
                                }
                                else if (PrevDlPr * 100 >= 51)
                                {
                                    PrevNar[34] = 6; /*PrevNar[33] = PrevDlPr;*/ /*MAXPREV = Convert.ToDouble(XDate[9]);*/
                                    if (iNar == 18)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[9]);*/ PrevNar[33] = Convert.ToDouble(XDate[9]) * 100; MAXPREV = Convert.ToDouble(XDate[9]); }
                                    else if (iNar == 19)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[59]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[10]);*/ PrevNar[33] = Convert.ToDouble(XDate[10]) * 100; MAXPREV = Convert.ToDouble(XDate[10]); }
                                    else if (iNar == 20)
                                    { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[62]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[11]);*/ PrevNar[33] = Convert.ToDouble(XDate[11]) * 100; MAXPREV = Convert.ToDouble(XDate[11]); }
                                }
                            }
                            else if (PrevNar[29] == 2)
                            {
                                PrevNar[32] = 2;
                                if (PrevDlPr * 100 >= 11 && PrevDlPr * 100 <= 20)
                                { PrevNar[34] = 4; /*PrevNar[33] = PrevDlPr;*/ /*MAXPREV = Convert.ToDouble(XDate[22]);*/
                                        if (iNar == 18)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[22]); */PrevNar[33] = Convert.ToDouble(XDate[22]) * 100; MAXPREV = Convert.ToDouble(XDate[22]); }
                                        else if (iNar == 19)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[20]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[23]);*/ PrevNar[33] = Convert.ToDouble(XDate[23]) * 100; MAXPREV = Convert.ToDouble(XDate[23]); }
                                        else if (iNar == 20)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[21]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[24]); */PrevNar[33] = Convert.ToDouble(XDate[24]) * 100; MAXPREV = Convert.ToDouble(XDate[24]); }
                                    }
                                else if (PrevDlPr * 100 >= 21 && PrevDlPr * 100 <= 50)
                                { PrevNar[34] = 5; /*PrevNar[33] = PrevDlPr;*//* MAXPREV = Convert.ToDouble(XDate[22]);*/
                                        if (iNar == 18)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[22]);*/ PrevNar[33] = Convert.ToDouble(XDate[22]) * 100; MAXPREV = Convert.ToDouble(XDate[22]); }
                                        else if (iNar == 19)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[20]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[23]);*/ PrevNar[33] = Convert.ToDouble(XDate[23]) * 100; MAXPREV = Convert.ToDouble(XDate[23]); }
                                        else if (iNar == 20)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[21]) / Convert.ToDouble(data1.a[61]) * 100), 0)); /*Convert.ToDouble(XDate[24]);*/ PrevNar[33] = Convert.ToDouble(XDate[24]) * 100; MAXPREV = Convert.ToDouble(XDate[24]); }
                                    }
                                else if (PrevDlPr * 100 >= 51)
                                { PrevNar[34] = 6; PrevNar[33] = PrevDlPr; 
                                        if (iNar == 18)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[22]);*/ PrevNar[33] = Convert.ToDouble(XDate[22]) * 100; MAXPREV = Convert.ToDouble(XDate[22]); }
                                        else if (iNar == 19)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[20]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*4/Convert.ToDouble(XDate[23])*100-100;*/ PrevNar[33] = Convert.ToDouble(XDate[23]) * 100; MAXPREV = Convert.ToDouble(XDate[23]); }
                                        else if (iNar == 20)
                                        { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[21]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[24]);*/ PrevNar[33] = Convert.ToDouble(XDate[24]) * 100; MAXPREV = Convert.ToDouble(XDate[24]); }
                                    }
                            }

                            if (iNar == 18) { CodSTGabarL = PrevNar[34].ToString(); } //else { CodSTGabarL = "0"; }
                            if (iNar == 19) { CodSTGabarW = PrevNar[34].ToString(); }// else { CodSTGabarW = "0"; }
                            if (iNar == 20) { CodSTGabarH = PrevNar[34].ToString(); }// else { CodSTGabarH = "0"; }
                            //CodSTGabar = PrevNar[34].ToString();
                        }
                        else if (iNar > 20 && iNar < 25)
                        {
                            NNarushen = "IsOverspeed"; //IsOverweightGross  IsOverweightPartial IsOversized  
                            UPDDannNarAndKl(NNarushen);
                            TypNar = 5;
                            TypNarTXT = "Превышение скорости движения АТС";
                            EDIzm = "(км/ч)";
                        }
                        if (PrevNar[37] == 1 && PrevNar[38] == 0)
                        { PrevNar[28] = 1; }
                        else if (PrevNar[37] == 0 && PrevNar[38] == 1)
                        { PrevNar[28] = 2; }
                        else if (PrevNar[37] == 1 && PrevNar[38] == 1)
                        { PrevNar[28] = 3; }

                        if (PrevNar[30] > 0 && PrevNar[30] <= 4)
                        {
                            if (PrevNar[33] < 1000)
                            {
                                if (PrevNar[33] < 100)
                                {
                                    if (PrevNar[33] < 10)
                                    {
                                        PNarSTEPEN = "000" + PrevNar[33].ToString();
                                    }
                                    else { PNarSTEPEN = "00" + PrevNar[33].ToString(); }
                                }
                                else { PNarSTEPEN = "0" + PrevNar[33].ToString(); }
                            }
                            else { PNarSTEPEN = PrevNar[33].ToString(); }
                        }
                        else if (PrevNar[30] > 4 && PrevNar[30] < 7)
                        {
                            if (PrevNar[39] < 1000)
                            {
                                if (PrevNar[39] < 100)
                                {
                                    if (PrevNar[39] < 10)
                                    {
                                        PNarSTEPEN = "000" + PrevNar[39].ToString();
                                    }
                                    else { PNarSTEPEN = "00" + PrevNar[39].ToString(); }
                                }
                                else { PNarSTEPEN = "0" + PrevNar[39].ToString(); }
                            }
                            else { PNarSTEPEN = PrevNar[39].ToString(); }
                        }
                        else { PNarSTEPEN = "0000"; }



                        if (KolOs < 10)
                        {
                            if (PrevNar[34] < 10) { CodNar = PrevNar[25].ToString() + "0" + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + "0" + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + "0" + PrevNar[34].ToString() + "00"; }

                            else { CodNar = PrevNar[25].ToString() + "0" + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + "0" + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + PrevNar[34].ToString() + "00"; }
                        }
                        else
                        {
                            if (PrevNar[34] < 10) { CodNar = PrevNar[25].ToString() + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + "0" + PrevNar[34].ToString() + "00"; }

                            else { CodNar = PrevNar[25].ToString() + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + PrevNar[34].ToString() + "00"; }
                        }
                        //names3[ic].massFact
                        if (/*KOGrNar > 1 && */iNar<25)
                        {
                            CodNarAN[INr].CodNarANg = CodNar;
                            CodNarAN[INr].TypNarTXTA = TypNarTXT;
                            CodNarAN[INr].EDIzmA = EDIzm;
                            CodNarAN[INr].MAXPREVA = MAXPREV;
                            CodNarAN[INr].MAXPREVPROTCA = MAXPREVPROTC;
                            CodNarAN[INr].KNRA = KOGrNar;
                        INr = INr + 1;
                        }
                        KOGrNar = 0;
                    }
                }
                if ( MAXiNar>0 && CodNarAN[MAXiNar - 1].KNRA != 1)
                {
                    CodNarM = "";
                    TypNarTXTM = "";
                    EDIzmM = "";
                    MAXPREVM = "";
                    MAXPREVPROTCM = "";

                    CodNarM = CodNarAN[MAXiNar-1].CodNarANg.ToString();
                    TypNarTXTM = CodNarAN[MAXiNar - 1].TypNarTXTA.ToString();
                    EDIzmM = CodNarAN[MAXiNar - 1].EDIzmA.ToString();
                    MAXPREVM = CodNarAN[MAXiNar - 1].MAXPREVA.ToString();
                    MAXPREVPROTCM = CodNarAN[MAXiNar - 1].MAXPREVPROTCA.ToString();
                    //CodNarAN[MAXiNar - 1].KNRA = KOGrNar;
                    VNTN = "выявлено нарушение (" + TypNarTXTM + ")";
                }

                int i1 = 0;
                int i2 = 0;
                int cnt = 0;
                tipoS = "";
                for (i1 = 0; i1 < 9; i1++)
                {
                    if (KN[1, i1] > 0)
                    {
                        tipoS = tipoS + KN[1, i1].ToString() + "+";
                    }
                }
                if (tipoS != "")
                {
                    tipoS = tipoS.Remove(tipoS.Length - 1, 1);
                }
                data1.a[46] = tipoS;
            }
            catch (MySqlException ex)
            { return; }
            finally
            { int w = 1; }
        }
        #endregion ///////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        #region/////////////////////////////////////////////   Кл. запрос класса Левый
        public void ZKL()
        {

            MySqlCommand command2 = new MySqlCommand();
            ConnectStr conStr2 = new ConnectStr();
            conStr2.ConStr(1);
            Zapros zapros2 = new Zapros();
            string connectionString2;//, commandString;
            connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection2 = new MySqlConnection(connectionString2);
            zapros2.KlassTS(D111, D1_2, D2_3, D3_4, D4_5, D5_6, D6_7, D7_8, KolOs, ObshMass);
            string z2 = zapros2.commandStringTest;
            command2.CommandText = z2;
            command2.Connection = connection2;
            MySqlDataReader reader2;
            try
            {
                command2.Connection.Open();
                reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    data1.a[2] = reader2["Kategory"].ToString();
                    SubKKl= Convert.ToInt32(reader2["SubCategory"].ToString());
                    //data1.a[2] = reader2["Klass"].ToString();
                    IDKLLeft = Convert.ToInt32(reader2["idklassts"].ToString());
                    data1.a[47] = reader2["naimklassts"].ToString();
                    if (data1.a[47].Length > 11)
                    {
                        if (data1.a[47].Substring(0, 9).ToString() == ("Автопоезд") || data1.a[47].Substring(data1.a[47].Length - 11, 11).ToString() == (" с прицепом"))
                        { FFFT = "Автопоезд"; PrevNar[27] = 2; }
                        else { FFFT = "Одиночное"; PrevNar[27] = 1; }
                    }
                    else { FFFT = "Одиночное"; PrevNar[27] = 1; }
                    if (PrevNar[27] == 1 || PrevNar[27] == 0)//reader2["tipschema"].ToString().Length == 1)
                    { TTS = 1; }
                    else if (PrevNar[27] == 2)//reader2["tipschema"].ToString().Length > 1)
                    { TTS = 2; }
                }
                reader2.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command2.Connection.Close();
                if (PrevNar[27] == 0)
                {
                    if (data1.a[2].ToString() != "6" && data1.a[2].ToString() != "9" && data1.a[2].ToString() != "8" && data1.a[2].ToString() != "7")
                    //if (data1.a[2].ToString() != "13" && data1.a[2].ToString() != "11" && data1.a[2].ToString() != "10" && data1.a[2].ToString() != "9" && data1.a[2].ToString() != "8" && data1.a[2].ToString() != "7")
                    { FFFT = "Одиночное"; PrevNar[27] = 1; TTS = 1; FFF = "Одиночное ТС"; }
                    else
                    { FFFT = "Автопоезд"; PrevNar[27] = 2; TTS = 2; FFF = "Автопоезд"; }
                }
            }
            //ZPHOTOPR();
            MySqlCommand command1 = new MySqlCommand();
            ConnectStr conStr1 = new ConnectStr();
            conStr1.ConStr(1);
            string connectionString1;
            connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection1 = new MySqlConnection(connectionString1);
            string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
  + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 4, 'вычислен класс ТС', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")"; ;
            //MySqlCommand command = new MySqlCommand(z);
            command1.CommandText = z1;// commandString;
            command1.Connection = connection1;
            connection1.Open();
            command1.ExecuteNonQuery();
            command1.Connection.Close();

            UPDDannNarAndKl("");

//            MySqlCommand command = new MySqlCommand();
//            ConnectStr conStr = new ConnectStr();
//            //Zapros zapros = new Zapros();
//            conStr.ConStr(1);

//            //zapros.ZaprObrSpRazrLoc(IDT, NamU, 1);
//            MySqlConnection connection = new MySqlConnection(conStr.StP);
//            string z = "UPDATE vehiclecontainer_r"
//+ " SET IDKlassN = " + data1.a[2]+""
//+ " WHERE ID_wim = '" + IDpish + "'";
//            command.CommandText = z;
//            command.Connection = connection;
//            try
//            {
//                command.Connection.Open();
//                command.ExecuteNonQuery();
//                command.Connection.Close();
//            }
//            catch (MySqlException exy)
//            { Console.WriteLine("Error: \r\n{0}", exy.ToString()); }
//            finally
//            { command.Connection.Close(); }
        }
        #endregion///////////////////////////////////////////// 

        #region/////////////////////////////////////////////   Общ.масса запрос ПДК 
        public void ZObPDK()
        {
            int KO1 = 0;
            MySqlCommand command2 = new MySqlCommand();
            ConnectStr conStr2 = new ConnectStr();
            conStr2.ConStr(1);
            Zapros zapros2 = new Zapros();
            string connectionString2;//, commandString;
            connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection2 = new MySqlConnection(connectionString2);
            if (TTS == 1 && KolOs > 5)
            { KO1 = 5; }
            else if (TTS == 2 && KolOs > 6)
            { KO1 = 6; }
            else { KO1 = KolOs; }
            zapros2.PDObshMass(KO1, TTS);
            //zapros2.PDObshMass(KolOs, TTS);
            string z2 = zapros2.commandStringTest;
            command2.CommandText = z2;
            command2.Connection = connection2;
            MySqlDataReader reader2;
            try
            {
                command2.Connection.Open();
                reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    data1.a[48] = Convert.ToString(Math.Round(ObshMass / 1000, 3));
                    data1.a[49] = Convert.ToString(Math.Round((ObshMass / 1000) - ((ObshMass / 1000) / 100) * 5, 3));
                    data1.a[50] = Convert.ToString(Math.Round(Convert.ToDouble(reader2["pdmassts"].ToString()), 3));
                    if (XDate[12] == "False")
                    {
                        if (Convert.ToDouble(data1.a[49]) <= Convert.ToDouble(data1.a[50]))
                        { data1.a[51] = "Не выявлено"; }
                        else if (Convert.ToDouble(data1.a[49]) > Convert.ToDouble(data1.a[50]))
                        {
                            data1.a[51] = "Превышение";
                            data1.a[52] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]) - Convert.ToDouble(data1.a[50]), 3));
                            data1.a[53] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]) / (Convert.ToDouble(data1.a[50]) / 100) - 100, 0));
                            if (Convert.ToDouble(data1.a[53]) >= 3)
                            {
                                XDate[30] = "True"; PrevNar[17] = Convert.ToDouble(data1.a[53]);
                                PrevNar[37] = 1;
                            }
                            else
                            {
                                XDate[30] = "False";
                            }
                        }
                        if ((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(data1.a[50])) <= 0)
                        {
                            XDate[27] = "0";
                        }
                        else
                        {
                            XDate[27] = Convert.ToString(Math.Round((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(data1.a[50])),2));
                        }
                        XDate[28] = Convert.ToString(Math.Round(Convert.ToDouble(XDate[25]) - Convert.ToDouble(XDate[26]),2));
                        if (Convert.ToDouble(XDate[28]) <= 0)
                        {
                            XDate[28] = "0";
                        }
                        else if (XDate[12] == "False")
                        { XDate[28] = "0"; }
                    }
                    else
                    {
                        if (XDate[26] != "0")
                        { data1.a[245] = XDate[26]; }
                        else { data1.a[245] = "-"; }
                        if ((Convert.ToDouble(data1.a[49])) <= (Convert.ToDouble(XDate[26])))
                        {
                            data1.a[51] = "Не выявлено";
                            XDate[27] = "0";
                        }
                        ///////////////                      
                        else if ((Convert.ToDouble(data1.a[49])) > (Convert.ToDouble(XDate[26])))
                        {
                            XDate[27] = Convert.ToString((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(XDate[26])));
                            data1.a[51] = "Превышение";
                            data1.a[52] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]) - Convert.ToDouble(XDate[26]), 3));
                            data1.a[53] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]) / (Convert.ToDouble(XDate[26]) / 100) - 100, 0));
                            if (Convert.ToDouble(data1.a[53]) >= 3)
                            {
                                XDate[30] = "True"; PrevNar[17] = Convert.ToDouble(data1.a[53]);
                                PrevNar[37] = 1;
                            }
                            else
                            {
                                XDate[30] = "False";
                            }                           
                        }
                        if ((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(data1.a[26])) <= 0)
                        {
                            XDate[27] = "0";
                        }
                        else
                        {
                            XDate[27] = Convert.ToString((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(data1.a[26])));
                        }
                        XDate[28] = Convert.ToString(Convert.ToDouble(XDate[25]) - Convert.ToDouble(XDate[26]));
                        if (Convert.ToDouble(XDate[28]) <= 0)
                        {
                            XDate[28] = "0";
                        }
                        else if (XDate[12] == "False")
                        { XDate[28] = "0"; }
                        /////////////////////////
                    }
                }
                reader2.Close();
                //if(XDate[26]!="0")
                //{
                //    data1.a[245] = XDate[26];
                //    if((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(XDate[26]))<=0)
                //    {
                //        data1.a[51] = "Не выявлено";
                //        XDate[27] = "0";
                //    }
                //    else
                //    {
                //        XDate[27] = Convert.ToString((Convert.ToDouble(data1.a[49])) - (Convert.ToDouble(XDate[26])));
                //        data1.a[51] = "Превышение";
                //        data1.a[52] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]) - Convert.ToDouble(XDate[26]), 3));
                //        data1.a[53] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[49]) / (Convert.ToDouble(XDate[26]) / 100) - 100, 0));
                //    }
                //    XDate[28] = Convert.ToString(Convert.ToDouble(XDate[25]) - Convert.ToDouble(XDate[26]));
                //    if (Convert.ToDouble(XDate[28]) <= 0)
                //    {
                //        XDate[28] = "0";
                //    }
                //    else if (XDate[12] == "False")
                //    { XDate[28] = "0"; }
                //}
                //else
                //{ data1.a[245] ="-"; }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command2.Connection.Close();
            }

            MySqlCommand command1 = new MySqlCommand();
            ConnectStr conStr1 = new ConnectStr();
            conStr1.ConStr(1);
            string connectionString1;
            connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection1 = new MySqlConnection(connectionString1);
            string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
  + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 5, 'вычислен общий вес ТС', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")"; 
            //MySqlCommand command = new MySqlCommand(z);
            command1.CommandText = z1;// commandString;
            command1.Connection = connection1;
            connection1.Open();
            command1.ExecuteNonQuery();
            command1.Connection.Close();
        }
        #endregion///////////////////////////////////////////// 
        #region/////////////////////////////////////////////   Габариты запрос ПДК 
        public void ZGabarPDK()
        {
            data1.a[246] = "-"; data1.a[247] = "-"; data1.a[248] = "-";
            data1.a[54] = Convert.ToString(Math.Round(DLINATS / 100, 2));
            data1.a[55] = Convert.ToString(Math.Round(DLINATS / 100, 2) - 0.6);//длина
            if (TTS == 1) { data1.a[56] = Convert.ToString(12.00); }
            else if (TTS == 2) { data1.a[56] = Convert.ToString(20.00); }
            //if (XDate[19]!="" && XDate[19] != "0" && XDate[19] != null)
            //{ data1.a[246] = XDate[19].ToString();
            //    if (Convert.ToDouble(data1.a[246])-Convert.ToDouble(data1.a[55]) > 0)
            //    {
            //        XDate[9] = Convert.ToString(Math.Round( Convert.ToDouble(data1.a[246])-Convert.ToDouble(data1.a[55]), 2));
            //        PrevNar[38] = 1;
            //        PrevDlPr = Convert.ToDouble(Math.Round(100 - ( Convert.ToDouble(data1.a[55])/Convert.ToDouble(data1.a[246]) * 100), 0));
            //        PrevNar[18] = PrevDlPr;
            //    }
            //    if (Convert.ToDouble(data1.a[246])-Convert.ToDouble(data1.a[55]) <= 0)
            //    {
            //        XDate[9] = "0";
            //    }

            //}
            //else
            //{
            //    data1.a[246] = "-";
            //    if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]) > 0)
            //    {
            //        XDate[9] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2));
            //        PrevNar[38] = 1;
            //        PrevDlPr = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));
            //        PrevNar[18] = PrevDlPr;
            //    }
            //    if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]) <= 0)
            //    {
            //        XDate[9] = "0";
            //    }
            //}
            data1.a[57] = Convert.ToString(Math.Round(SHIRTS / 100, 2));
            if ((Math.Round(SHIRTS / 100, 2) - 0.1) > 0)
            {
                data1.a[58] = Convert.ToString((Math.Round(SHIRTS / 100, 2)) - 0.1);//ширина
            }//ширина
            else { data1.a[58] = "0"; }
            data1.a[59] = Convert.ToString(2.60);

            data1.a[60] = Convert.ToString(Math.Round(VISTS / 100, 2));
            if ((Math.Round(VISTS / 100, 2) - 0.06) > 0)
            {
                data1.a[61] = Convert.ToString((Math.Round(VISTS / 100, 2)) - 0.06);//высота
            }
            else { data1.a[61] = "0"; }//высота
            data1.a[62] = Convert.ToString(4.00);
            data1.a[63] = "Не проверялось";

            if (XDate[12] != "False")
            {
                data1.a[246] = Convert.ToString(Math.Round(Convert.ToDecimal(XDate[19].ToString()), 2));
                data1.a[247] = Convert.ToString(Math.Round(Convert.ToDecimal(XDate[20].ToString()), 2));
                data1.a[248] = Convert.ToString(Math.Round(Convert.ToDecimal(XDate[21].ToString()), 2));
            }
            else
            {
                data1.a[246] ="-";
                data1.a[247] = "-";
                data1.a[248] = "-";
            }

            ///////////////////// Длина превыш
            if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]) > 0)
            {
                XDate[9] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2));
                data1.a[64] = XDate[9];
                PrevNar[38] = 1;
                PrevNar[39] = Math.Round(Convert.ToDouble(XDate[9]) * 100, 0);
                PrevDlPr = Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2);//Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));
                PrevNar[18] = PrevDlPr;
            }
            if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]) <= 0)
            {
                XDate[9] = "0";
                data1.a[64] = "-";
            }
            ////////////////// Ширина превыш
            if (data1.a[247] != "-")
            {
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]) > 0)
                {
                    XDate[10] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]), 2));
                    //XDate[9] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2));
                    data1.a[66] = XDate[10];
                    PrevNar[38] = 1;
                    PrevNar[39] = Math.Round(Convert.ToDouble(XDate[10]) * 100, 0);
                    PrevDlPr = Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]), 2);// Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[247]) / Convert.ToDouble(data1.a[58]) * 100), 0));
                    PrevNar[19] = PrevDlPr;
                }
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]) <= 0)
                {
                    XDate[10] = "0";
                    data1.a[66] = "-";
                }
            }
            else
            {
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]) > 0)
                {
                    XDate[10] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]), 2));
                    //XDate[9] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2));
                    data1.a[66] = XDate[10];
                    PrevNar[38] = 1;
                    PrevNar[39] = Math.Round(Convert.ToDouble(XDate[10]) * 100, 0);
                    PrevDlPr =Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]), 2);// Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[59]) / Convert.ToDouble(data1.a[58]) * 100), 0));
                    PrevNar[19] = PrevDlPr;
                }
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]) <= 0)
                {
                    XDate[10] = "0";
                    data1.a[66] = "-";
                }
            }
            ///////////////// Высота превыш
            //if (data1.a[247] != "-")
            //{

            //}
            //else
            //{
                if (Convert.ToDouble(data1.a[61]) - Convert.ToDouble(data1.a[62]) > 0)
                {
                    XDate[11] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[61]) - Convert.ToDouble(data1.a[62]), 2));
                //XDate[9] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]), 2));
                data1.a[68] = XDate[11];
                PrevNar[38] = 1;
                PrevNar[39] = Math.Round(Convert.ToDouble(XDate[11]) * 100, 0);
                PrevDlPr = Math.Round(Convert.ToDouble(data1.a[61]) - Convert.ToDouble(data1.a[62]), 2);// Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[62]) / Convert.ToDouble(data1.a[61]) * 100), 0));
                PrevNar[20] = PrevDlPr;
            }
                if (Convert.ToDouble(data1.a[61]) - Convert.ToDouble(data1.a[62]) <= 0)
                {
                    XDate[11] = "0";
                data1.a[68] = "-";
            }
            //}
            ////////////////////////// И по СР
            ///////////////////// Длина превыш
            if (XDate[12].ToString() != "False")
            {
                if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()) > 0)
                {
                    XDate[22] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()),2));
                    data1.a[64] = XDate[22];
                    PrevNar[38] = 1;
                    PrevNar[39] = Math.Round(Convert.ToDouble(XDate[22]) * 100, 0);

                    //PrevDlPr = Convert.ToDouble(Math.Floor(Math.Round(Convert.ToDouble(data1.a[55]) / Convert.ToDouble(data1.a[56]) / 100 - 100, 2)));
                    PrevDlPr = Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()), 2);// Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));
                    PrevNar[18] = PrevDlPr;
                }
                if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()) <= 0)
                {
                    XDate[22] = "0";
                    data1.a[64] = "-";
                }
                ////////////////// Ширина превыш
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()) > 0)
                {
                    XDate[23] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()),2));
                    //XDate[22] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()), 2));
                    data1.a[66] = XDate[23];
                    PrevNar[38] = 1;
                    PrevNar[39] = Math.Round(Convert.ToDouble(XDate[23]) * 100, 0);

                    //PrevDlPr = Convert.ToDouble(Math.Floor(Math.Round(Convert.ToDouble(data1.a[55]) / Convert.ToDouble(data1.a[56]) / 100 - 100, 2)));
                    PrevDlPr = Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()), 2);// Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[20]) / Convert.ToDouble(data1.a[58]) * 100), 0));
                    PrevNar[19] = PrevDlPr;
                }
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()) <= 0)
                {
                    XDate[23] = "0";
                    data1.a[66] = "-";
                }
                ///////////////// Высота превыш
                if (Convert.ToDouble(data1.a[61]) - Convert.ToDouble(XDate[21].ToString()) > 0)
                {
                    XDate[24] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[61]) - Convert.ToDouble(XDate[21].ToString()),2));
                    //XDate[22] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()), 2));
                    data1.a[68] = XDate[24];
                    PrevNar[38] = 1;
                    PrevNar[39] = Math.Round(Convert.ToDouble(XDate[24]) * 100, 0);

                    //PrevDlPr = Convert.ToDouble(Math.Floor(Math.Round(Convert.ToDouble(data1.a[55]) / Convert.ToDouble(data1.a[56]) / 100 - 100, 2)));
                    PrevDlPr = Math.Round(Convert.ToDouble(data1.a[61]) - Convert.ToDouble(XDate[21].ToString()), 2);// Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[21]) / Convert.ToDouble(data1.a[61]) * 100), 0));
                    PrevNar[20] = PrevDlPr;
                }
                if (Convert.ToDouble(data1.a[61]) - Convert.ToDouble(XDate[21].ToString()) <= 0)
                {
                    XDate[24] = "0";
                    data1.a[68] = "-";
                }
            }
            else
            {
                XDate[22] = "0";
                XDate[23] = "0";
                XDate[24] = "0";
            }

            MySqlCommand command1 = new MySqlCommand();
            ConnectStr conStr1 = new ConnectStr();
            conStr1.ConStr(1);
            string connectionString1;
            connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection1 = new MySqlConnection(connectionString1);
            string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
  + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 8, 'вычислены габариты ТС', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")"; ;
            //MySqlCommand command = new MySqlCommand(z);
            command1.CommandText = z1;// commandString;
            command1.Connection = connection1;
            connection1.Open();
            command1.ExecuteNonQuery();
            command1.Connection.Close();
        }
        #endregion///////////////////////////////////////////// 
        #region/////////////////////////////////////////////   Осевая масса запрос ПДК 
        //////////public void ZOsPDK()
        //////////{
        //////////    try {
        //////////        for (ic = 1; ic < KolOs + 1; ic++)
        //////////        {
        //////////            if (ic < 9)
        //////////            {
        //////////                MySqlCommand command2 = new MySqlCommand();
        //////////                ConnectStr conStr2 = new ConnectStr();
        //////////                conStr2.ConStr(1);
        //////////                Zapros zapros2 = new Zapros();
        //////////                string connectionString2;//, commandString;
        //////////                connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
        //////////                MySqlConnection connection2 = new MySqlConnection(connectionString2);
        //////////                if (D[ic] > 0)
        //////////                {
        //////////                    if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] == 0)
        //////////                    {
        //////////                        zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));

        //////////                    }
        //////////                    else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic])
        //////////                    {
        //////////                        if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))
        //////////                        {
        //////////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
        //////////                        }
        //////////                        else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }

        //////////                    }
        //////////                    else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic] != 0)
        //////////                    {
        //////////                        if (D[ic] < 2.5)
        //////////                        {
        //////////                            if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic + 1]))
        //////////                            {
        //////////                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic + 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));
        //////////                            }
        //////////                            else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100)); }
        //////////                        }
        //////////                    }
        //////////                    else if (Convert.ToInt32(TypO[ic]) == 1)
        //////////                    {
        //////////                        if (D[ic] == 2.5)
        //////////                        {
        //////////                            D[ic] = 2.51;
        //////////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));
        //////////                            D[ic] = 2.5;
        //////////                        }
        //////////                        else
        //////////                        { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100)); }

        //////////                    }
        //////////                }
        //////////                else
        //////////                {
        //////////                    if (D[ic - 1] < 2.5)
        //////////                    {
        //////////                        if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))
        //////////                        {
        //////////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
        //////////                        }
        //////////                        else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }
        //////////                    }
        //////////                    else
        //////////                    {
        //////////                        if (D[ic-1] == 2.5)
        //////////                        {
        //////////                            D[ic-1] = 2.51;
        //////////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic-1] * 100));
        //////////                            D[ic-1] = 2.5;
        //////////                        }
        //////////                        else
        //////////                        { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic-1] * 100)); }
        //////////                        //zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
        //////////                    }
        //////////                }
        //////////                string z2 = zapros2.commandStringTest;
        //////////                command2.CommandText = z2;
        //////////                command2.Connection = connection2;
        //////////                MySqlDataReader reader2;
        //////////                try
        //////////                {
        //////////                    command2.Connection.Open();
        //////////                    reader2 = command2.ExecuteReader();
        //////////                    while (reader2.Read())
        //////////                    {
        //////////                        PDKO[ic] = Convert.ToDouble(reader2["pdo"].ToString());
        //////////                        PDKTel[ic] = Convert.ToDouble(reader2["pdt"].ToString());

        //////////                    }
        //////////                    reader2.Close();
        //////////                }
        //////////                catch (MySqlException ex)
        //////////                {
        //////////                    Console.WriteLine("Error: \r\n{0}", ex.ToString());
        //////////                }
        //////////                finally
        //////////                {
        //////////                    command2.Connection.Close();
        //////////                }
        //////////            }
        //////////        }

        #region/////////////////////////////////////////////   Осевая масса запрос ПДК 
        public void ZOsPDK()
        {
            int ig = 0;
            int io = 0;
            int ipr = 0;
            double[] SRdist = new double[10];
            double[] massGR = new double[10];
            double[] SRdistO = new double[10];

            try
            {
            //    for (ic = 1; ic < KolOs + 1; ic++)
            //{
            //    if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic] && D[ic - 2] >= 2.5)
            //    {
            //        NagrTel = 0; // - общая масса группы 
            //        for (int iTel = ic - 1; iTel < ic - 1 + TypO[ic]; iTel++)
            //        { massGR[ic] = massGR[ic] + (BetOs[13, iTel - 1]/*- BetOs[13, iTel]/100*10*/); }
            //    }

            //}

            //while (ig < KolGr + 1)
            //{
            //    if (D[ig] == 0)
            //    { SRdist[ig] = 0; }
            //    else
            //    {
            //        while ((D[io + 1] > 0 && D[io + 1] < 2.50) || io == 0)
            //        {
            //            if (io != 0)
            //            {
            //                SRdist[ig] = (SRdist[ig] + D[io]);
            //                //massGR[ig] = massGR[ig] + BetOs[13, io];
            //            }
            //            io++;
            //        }
            //    }
            //    SRdist[ig] = SRdist[ig] / (io - ipr);
            //    ipr = io;
            //    ig++;
            //}
            //ig = 0;
            //io = 0;
            //while (ig < KolGr + 1)
            //{
            //    while ((D[io + 1] > 0 && D[io + 1] < 2.50) || io == 0)
            //    {
            //        if (io != 0)
            //        {
            //            SRdistO[io] = SRdist[ig];
            //        }
            //        io++;
            //    }
            //    ig++;
            //}

            //if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic - 1] > D[ic - 2] && D[ic] != 0)
            //{
            //    SrednRTel = 0; // среднее расстояние
            //    for (int iRTel = ic; iRTel < ic - 1 + TypO[ic]; iRTel++)
            //    {

            //        SrednRTel = SrednRTel + D[iRTel]; /*}*/
            //    }

            //проходим по осям и делаем выборку по группам
            for (ic = 1; ic < KolOs + 1; ic++)
            {
                if (ic <= 9)
                {
                    MySqlCommand command2 = new MySqlCommand();
                    ConnectStr conStr2 = new ConnectStr();
                    conStr2.ConStr(1);
                    Zapros zapros2 = new Zapros();
                    string connectionString2;//, commandString;
                    connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                    MySqlConnection connection2 = new MySqlConnection(connectionString2);
                    if (D[ic] > 0)
                    {
                        if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] == 0)// если сдвоенная/строенная но первая т.е. перед ней нет ни одной оси
                        {
                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));

                        }
                        else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic] && D[ic] >= 2.5)// если сдвоенная/строенная предидущее расстояние меньше настоящего (напр: 1+2... а это 3)
                        {

                            if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))// если текущая скатность больше предидущей в гр.
                            {
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); //(D[ic - 1] * 100));
                            }
                            else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); } //(D[ic - 1] * 100)); }
                            //////}
                            //////else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }

                        }
                        else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic])// если сдвоенная/строенная предидущее расстояние меньше настоящего (напр: 1+2... а это 3)
                        {

                            if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))// если текущая скатность больше предидущей в гр.
                            {
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));}//(SrednRTel / (TypO[ic] - 1) * 100)); //(D[ic - 1] * 100));}
                            else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr,  (D[ic - 1] * 100)); }//(SrednRTel / (TypO[ic] - 1) * 100)); } //(D[ic - 1] * 100)); }
                                                                                                                                                //////}
                                                                                                                                                //////else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }

                            }
                        else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic] != 0)// если сдвоенная/строенная предидущее расстояние больше настоящего (напр: 1+2... а это 2)
                        {

                            if (D[ic] < 2.5)
                            {
                                if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic - 1] > D[ic - 2] && D[ic] != 0 && D[ic - 1] >= 2.5)
                                {
                                    SrednRTel = 0;
                                    for (int iRTel = ic; iRTel < ic - 1 + TypO[ic]; iRTel++)
                                    {
                                        //if (TypO[ic] == 2)
                                        //{ SrednRTel = SrednRTel + D[ic] + D[ic]; }
                                        //else
                                        /*{*/
                                        SrednRTel = SrednRTel + D[iRTel]; /*}*/
                                    }
                                }
                                if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic + 1]))
                                {
                                    zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic + 1]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); //(D[ic] * 100));
                                }
                                else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); } //(D[ic] * 100)); }
                            }
                        }

                        else if (Convert.ToInt32(TypO[ic]) == 1)
                        {
                            if (D[ic] == 2.5)
                            {
                                D[ic] = 2.51;
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));
                                D[ic] = 2.5;
                            }
                            else
                            { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100)); }

                        }
                    }
                    else
                    {
                        if (D[ic - 1] < 2.5)
                        {
                            if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))
                            {
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
                            }
                            else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }
                        }
                        else
                        {
                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
                        }
                    }

                    string z2 = zapros2.commandStringTest;
                    command2.CommandText = z2;
                    command2.Connection = connection2;
                    MySqlDataReader reader2;
                    try
                    {
                        command2.Connection.Open();
                        reader2 = command2.ExecuteReader();
                        while (reader2.Read())
                        {
                            //PDKO[ic] = Convert.ToDouble(reader2["pdo"].ToString());
                            PDKTel[ic] = Convert.ToDouble(reader2["pdt"].ToString());
                        }
                        reader2.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error: \r\n{0}", ex.ToString());
                    }
                    finally
                    {
                        command2.Connection.Close();
                    }
                }
            }

            for (ic = 1; ic < KolOs + 1; ic++) //// ПДК по осям
            {
                if (ic <= 9)
                {
                    MySqlCommand command2 = new MySqlCommand();
                    ConnectStr conStr2 = new ConnectStr();
                    conStr2.ConStr(1);
                    Zapros zapros2 = new Zapros();
                    string connectionString2;//, commandString;
                    connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                    MySqlConnection connection2 = new MySqlConnection(connectionString2);
                    if (D[ic] > 0)
                    {
                        if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] == 0)// если сдвоенная/строенная но первая т.е. перед ней нет ни одной оси
                        {
                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));

                        }
                        else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic])// если сдвоенная/строенная предидущее расстояние меньше настоящего (напр: 1+2... а это 3)
                        {
                            //////if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic] && D[ic - 2] > D[ic-1])
                            //////{ NagrTel = 0;
                            //////    for (int iTel = ic-1; iTel < ic - 1 +TypO[ic]; iTel++)
                            //////    { NagrTel = NagrTel + (BetOs[13, iTel-1]/*- BetOs[13, iTel]/100*10*/); }
                            //////}
                            if (NagrTel / 1000 - PDKTel[ic - 1] > 0)//если суммарная масса по группе выше ПДК группы
                            {
                                //PDKO[ic] = PDKO[ic-1];
                                //PDKTel[ic] = PDKTel[ic-1];
                                if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))// если текущая скатность больше предидущей в гр.
                                {
                                    zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); //(D[ic - 1] * 100));
                                }
                                else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); } //(D[ic - 1] * 100)); }
                            }
                            else
                            {
                                //if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))// если текущая скатность больше предидущей в гр.
                                //{
                                //    zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); //(D[ic - 1] * 100));
                                //}
                                /*else { */
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));/* }*/
                                //zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); 
                            }

                        }
                        else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic] != 0)// если сдвоенная/строенная предидущее расстояние больше настоящего (напр: 1+2... а это 2)
                        {

                            if (D[ic] < 2.5)
                            {
                                if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic - 1] >= 2.5 && D[ic] != 0)
                                {
                                    SrednRTel = 0;
                                    for (int iRTel = ic; iRTel < ic - 1 + TypO[ic]; iRTel++)
                                    {
                                        //if (TypO[ic] == 2)
                                        //{ SrednRTel = SrednRTel + D[ic] + D[ic]; }
                                        //else
                                        /*{*/
                                        SrednRTel = SrednRTel + D[iRTel]; /*}*/
                                    }
                                    NagrTel = 0;
                                    for (int iTel = ic; iTel < ic - 1 + TypO[ic]; iTel++)
                                    { NagrTel = NagrTel + (BetOs[13, iTel - 1]/*- BetOs[13, iTel]/100*10*/); }
                                }
                                if (NagrTel / 1000 - PDKTel[ic - 1] > 0)//если суммарная масса по группе выше ПДК группы
                                {
                                    if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic + 1]))
                                    {
                                        zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic + 1]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); //(D[ic] * 100));
                                    }
                                    else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); } //(D[ic] * 100)); }
                                }
                                else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); }
                            }
                        }

                        else if (Convert.ToInt32(TypO[ic]) == 1)
                        {
                            if (D[ic] == 2.5)
                            {
                                D[ic] = 2.51;
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));
                                D[ic] = 2.5;
                            }
                            else
                            { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100)); }

                        }
                    }
                    else
                    {
                        if (D[ic - 1] < 2.5)
                        {
                            if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))
                            {
                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
                            }
                            else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }
                        }
                        else
                        {
                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
                        }
                    }

                    string z2 = zapros2.commandStringTest;
                    command2.CommandText = z2;
                    command2.Connection = connection2;
                    MySqlDataReader reader2;
                    try
                    {
                        command2.Connection.Open();
                        reader2 = command2.ExecuteReader();
                        while (reader2.Read())
                        {
                            PDKO[ic] = Convert.ToDouble(reader2["pdo"].ToString());
                            //PDKTel[ic] = Convert.ToDouble(reader2["pdt"].ToString());
                        }
                        reader2.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error: \r\n{0}", ex.ToString());
                    }
                    finally
                    {
                        command2.Connection.Close();
                    }
                }
            }
        //////}
        #endregion///////////////////////////////////////////// 

        MySqlCommand command1 = new MySqlCommand();
                ConnectStr conStr1 = new ConnectStr();
                conStr1.ConStr(1);
                string connectionString1;
                connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                MySqlConnection connection1 = new MySqlConnection(connectionString1);
                string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
      + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 6, 'вычислена нагрузка на оси', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                //MySqlCommand command = new MySqlCommand(z);
                command1.CommandText = z1;// commandString;
                command1.Connection = connection1;
                connection1.Open();
                command1.ExecuteNonQuery();
                command1.Connection.Close();
                MySqlCommand command3 = new MySqlCommand();
                ConnectStr conStr3 = new ConnectStr();
                conStr3.ConStr(1);
                string connectionString3;
                connectionString3 = conStr3.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
                MySqlConnection connection3 = new MySqlConnection(connectionString3);
                string z3 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
      + "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 7, 'вычислена нагрузка на группы осей', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
                //MySqlCommand command = new MySqlCommand(z);
                command3.CommandText = z3;// commandString;
                command3.Connection = connection3;
                connection3.Open();
                command3.ExecuteNonQuery();
                command3.Connection.Close();
            }
            catch (MySqlException ex)
            {
                return;
                //Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                int w = 1;
            }
        }
        #endregion///////////////////////////////////////////// 

        #region /////////////////////////////////////////// УЗНАЕМ МАКСИМАЛЬНЫЙ НОМЕР АКТА
        public void MNAKT()
        {
            MySqlCommand command = new MySqlCommand();
            ConnectStr conStr = new ConnectStr();
            conStr.ConStr(1);
            Zapros zapros = new Zapros();
            string connectionString;
            connectionString = conStr.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            zapros.MaxAktNum();
            string z = zapros.commandStringTest;

            command.CommandText = z;// commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    A1[0] = Convert.ToString(Convert.ToInt32(reader["MNA"].ToString()) + 1);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }

        }
        #endregion///////////////////////////////////////////// 

        private void soap2()
        {
            WCPSoapClientForm.Class1 a = new WCPSoapClientForm.Class1();
            if (Nzapr != "" && Nzapr != null &&  StatAng > 1)
            {
                //WCPSoapClientForm.Class1 a = new WCPSoapClientForm.Class1();
                a.ACc = AC; a.AIc = AI; a.ALc = AL; a.DTc = DT; a.CPCc = CPC;
                a.Dc = Dc; a.TWc = TW; a.GRZc = GRZ; a.Hc = H; a.Lc = L; a.Wc = W; a.NZapr = Nzapr;
                a.IdPr = IDTSIsh; a.prevnar = PrevNar; a.NZapr = ChastNZapr.ToString();
                a.button1_Click();
            }
            else
            {
                //WCPSoapClientForm.Class1 a = new WCPSoapClientForm.Class1();
                a.ACc = AC; a.AIc = AI; a.ALc = AL; a.DTc = DT; a.CPCc = CPC;
                a.Dc = Dc; a.TWc = TW; a.GRZc = GRZ; a.Hc = H; a.Lc = L; a.Wc = W; a.NZapr = "";
                a.IdPr = IDTSIsh; a.prevnar = PrevNar; a.NZapr = ChastNZapr.ToString();
                a.button1_Click();
            }
            //          MySqlCommand command3 = new MySqlCommand();
            //          ConnectStr conStr3 = new ConnectStr();
            //          conStr3.ConStr(1);
            //          string connectionString3;
            //          connectionString3 = conStr3.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            //          MySqlConnection connection3 = new MySqlConnection(connectionString3);
            //          string z3 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
            //+ "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 1, 'направлен запрос СР', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
            //          //MySqlCommand command = new MySqlCommand(z);
            //          command3.CommandText = z3;// commandString;
            //          command3.Connection = connection3;
            //          connection3.Open();
            //          command3.ExecuteNonQuery();
            //          command3.Connection.Close();

            //          MySqlCommand command2 = new MySqlCommand();
            //          ConnectStr conStr2 = new ConnectStr();
            //          conStr2.ConStr(1);
            //          string connectionString2;
            //          connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
            //          MySqlConnection connection2 = new MySqlConnection(connectionString3);
            //          string z2 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
            //+ "VALUES(" + IDpish + ", '" + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + "', 2, 'получен ответ СР', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
            //          //MySqlCommand command = new MySqlCommand(z);
            //          command2.CommandText = z2;// commandString;
            //          command2.Connection = connection2;
            //          connection2.Open();
            //          command2.ExecuteNonQuery();
            //          command2.Connection.Close();
            if (StatAng > 0 && (data1.a[241] != data1.a[244]))
            { a.button2_Click(Nzapr, IDpish, data1.a[6], data1.a[7], PLN , ChastNZapr.ToString()); }
            else { a.button2_Click("", IDpish, data1.a[6], data1.a[7], PLN, ChastNZapr.ToString()); }

            dateSR = Convert.ToString(Convert.ToDateTime(a.DTN).ToString("dd.MM.yyyy HH:mm:ss"));// ;

            numberSR = Convert.ToString(a.IdPrSTR);
            NZaprF = a.NZaprFalse.ToString();
        }


        ////////#endregion///////////////////////////////////////////// 
        #endregion //////////////////////////
        public Image StrToImg(string StrImg)
        {
            byte[] arrayimg = Convert.FromBase64String(StrImg);
            Image imageStr = Image.FromStream(new MemoryStream(arrayimg));

            return imageStr;
        }
        //функция преобразования изображения в строку

        public void UPDDannNarAndKl (string NNarush)
        {
            MySqlCommand command = new MySqlCommand();
            ConnectStr conStr = new ConnectStr();
            //Zapros zapros = new Zapros();
            conStr.ConStr(1);

            MySqlConnection connection = new MySqlConnection(conStr.StP);
            if (NNarush == "")
            {
                z = "UPDATE vehiclecontainer_r"
+ " SET IDKlassN = " + data1.a[2] + ", "
+ " KlNew = " + Convert.ToInt32(data1.a[2]) + ", "
+ " SubKateg = " + SubKKl + ""
+ " WHERE ID_wim = '" + IDpish + "'";
            }
            else
            {
               z = "UPDATE vehiclecontainer_r"
+ " SET IDKlassN = " + data1.a[2] + ", "
+ " KlNew = " + Convert.ToInt32(data1.a[2]) + ", "
+ " SubKateg = " + SubKKl + ", "
+ " " + NNarush + " = 1 "
+ " WHERE ID_wim = '" + IDpish + "'";
            }
            command.CommandText = z;
            command.Connection = connection;
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                KLISPR = Convert.ToInt32(data1.a[2]);
            }
            catch (MySqlException exy)
            { Console.WriteLine("Error: \r\n{0}", exy.ToString()); }
            finally
            { command.Connection.Close(); }
        }

        ///////////////////                              Подпись документа:
        //private static BouncyCastle.Crypto.ISigner signer = new Gost3410DigestSigner(new Gost3410Signer(), new GOST3411_2012_512Digest());
        //private static AsymmetricKeyEntry PrivKey;

        //public static Pkcs12Store LoadKeyAndGenerateSetificate(out Gost3410PublicKeyParameters publicKey)
        //{

        //    Gost3410PrivateKeyParameters privateKey = (Gost3410PrivateKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(File.ReadAllText(PathPrivateFile)));
        //    publicKey = (Gost3410PublicKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(File.ReadAllText(PathPublicKey)));
        //    Pkcs12StoreBuilder ksBuilder = new Pkcs12StoreBuilder();
        //    Pkcs12Store ks = ksBuilder.Build();
        //    AsymmetricCipherKeyPair new_p = new AsymmetricCipherKeyPair(publicKey, privateKey);
        //    X509V3CertificateGenerator certGen = new X509V3CertificateGenerator();
        //    certGen.SetSerialNumber(BigInteger.One);
        //    certGen.SetIssuerDN(new X509Name("CN=VimSistemi"));
        //    certGen.SetNotBefore(DateTime.UtcNow.AddSeconds(-360));
        //    certGen.SetNotAfter(DateTime.UtcNow.AddYears(2));
        //    certGen.SetSubjectDN(new X509Name("CN=Test"));
        //    certGen.SetPublicKey(publicKey);
        //    //certGen.SetSignatureAlgorithm("GOST3411withGOST3410");
        //    //certGen.SetSignatureAlgorithm("GOST3411-2012-512withGOST3410");
        //    //certGen.SetSignatureAlgorithm("GOST3411withECGOST3410");
        //    certGen.SetSignatureAlgorithm("GOST3411withGOST3410");
        //    X509Certificate cert = certGen.Generate(privateKey);
        //    X509CertificateEntry certEntry = new X509CertificateEntry(cert);

        //    ks.SetKeyEntry("gost", new AsymmetricKeyEntry(privateKey), new X509CertificateEntry[] { certEntry });

        //    MemoryStream bOut = new MemoryStream();

        //    ks.Save(bOut, "gost".ToCharArray(), new SecureRandom());

        //    //ks = ksBuilder.Build();

        //    return ks;
        //}


        //public static void GenerateAndSaveCertificate()
        //{
        //    IAsymmetricCipherKeyPairGenerator g = GeneratorUtilities.GetKeyPairGenerator("GOST3410");
        //    g.Init(
        //     new Gost3410KeyGenerationParameters(
        //         new SecureRandom(),
        //         CryptoProObjectIdentifiers.GostR3410x94CryptoProA));

        //    AsymmetricCipherKeyPair p = g.GenerateKeyPair();

        //    AsymmetricKeyParameter sKey = p.Private;
        //    AsymmetricKeyParameter vKey = p.Public;

        //    PrivateKeyInfo privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(sKey);
        //    byte[] serializedPrivateBytes = privateKeyInfo.ToAsn1Object().GetDerEncoded();
        //    string serializedPrivate = Convert.ToBase64String(serializedPrivateBytes);

        //    File.WriteAllText(PathPrivateFile, serializedPrivate);

        //    SubjectPublicKeyInfo publicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(vKey);
        //    byte[] serializedPublicBytes = publicKeyInfo.ToAsn1Object().GetDerEncoded();
        //    string serializedPublic = Convert.ToBase64String(serializedPublicBytes);
        //    File.WriteAllText(PathPublicKey, serializedPublic);
        //}


        //public static string SignData(byte[] msg, AsymmetricKeyParameter PrivKey)
        //{
        //    try
        //    {
        //        signer.Init(true, PrivKey);
        //        signer.BlockUpdate(msg, 0, msg.Length);
        //        var sigBytes = signer.GenerateSignature();
        //        return Convert.ToBase64String(sigBytes);
        //    }
        //    catch (Exception exc)
        //    {
        //        Console.WriteLine(" Signing Failed: " + exc.ToString());
        //        return null;
        //    }
        //}

    }
}

