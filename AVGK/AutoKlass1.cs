using System;
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

namespace AVGK
{
    class AutoKlass1
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
        public names[] names3 = new names[10];
        public namesGR[] namesGRUP;// = new namesGR[10];
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
        public string KNRM; int KolZap; string SigAx = "False"; string SigGr = "False"; string SigAll = "False"; string PlID;
        public string NSPov; string DVPov; string ValidPov; double NagrTel; int KolGr; double SrednRTel;
        public double b8; public double b9; public double b10; public double b11; public double b12;
        public double c8; public double c9; public double c10; public double c11; public double c12;
        public string CodSTAll; public string CodSTGabarL; public string CodSTGabarW; public string CodSTGabarH; public string CodSTSpeed;
        //public MySqlConnection connection3 = new MySqlConnection(cstr);
        public MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
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

        public void LoadPDF(int IDTS, string NUs)//// загрузка формы уже с пользователем и проездом
        {
            NamU = NUs;
            IDTSIsh = IDTS;
            data1.a = new string[251];
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
                    KolZap = KolZap + 1;
                    KolOs = Convert.ToInt32(reader["AxleCount"].ToString());
                    ObshMass = Convert.ToInt32(reader["Weight"].ToString());

                    if (Convert.ToString(reader["UIDAng"].ToString()) != "")
                    {
                        AngStat = 1; GDAng = Convert.ToString(reader["UIDAng"].ToString());
                    }

                    if (Convert.ToInt32(reader["StatAng"].ToString()) == 2)
                    { GRZ = reader["OldGRZ"].ToString(); }
                    else
                    {
                        if (reader["PlateConfidence"].ToString() == "0")
                        { GRZ = reader["PlateRear"].ToString(); }
                        else
                        { GRZ = reader["Plate"].ToString(); }
                    }
                    Gross = reader["IsOverweightGross"].ToString();
                    Part = reader["IsOverweightPartial"].ToString();
                    Group = reader["IsOverweightGroup"].ToString();
                    siz = reader["IsOversized"].ToString();
                    speed = reader["IsOverspeed"].ToString();
                    KLISPR = Convert.ToInt32(reader["KlNew"].ToString());
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
            //////////////////////////////////////////
            //   формируем ГУИД для ангелов если его нет
            if (AngStat == 0)
            {
                try
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
                //MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                string z3 = zapros3.commandStringTest;
                cmd.CommandText = z3;
                cmd.Connection = connection3;
                connection3.Open();
                cmd.ExecuteNonQuery();

                connection3.Close();
                }
                catch (MySqlException ex)
                { return; }
                finally
                {/* connection3.Close(); */int w = 1; }
                //connection3.Close();
            }


            /////////////////////////////////////////////
            if (KolOs > 1 && ObshMass != 0 && Ind != 4 && Ind != 14 && Ind != 17 && Cr11 == 0 /*&& GRZ != ""*/ && StatAng == 0 && IDTS != 3075782 && KolOs==KolZap && KLISPR==0)
            {
                try
                {
                    proc2(IDTS);

                    ////////////////////////////////////////////////////// Запрос класса ТС (левый)   //////////////////////////
                    //if (data1.a[3] != "" && data1.a[150] != "4" && data1.a[150] != "11" && data1.a[150] != "14" && data1.a[150] != "17" && data1.a[145] == "0" && ObshMass != 0 && data1.a[1] != "0")//&& ImPl,ImAlt )
                    //{
                        ZKL();
                        ////////////////////////////////////////////////////////////////////////////////////////////////////

                    //}
          //          else if (data1.a[3] == "")
          //          {
          //              if (data1.a[150] != "14")//&& ImPl,ImAlt )
          //              {
          //                  MySqlCommand command1 = new MySqlCommand();
          //                  ConnectStr conStr1 = new ConnectStr();
          //                  conStr1.ConStr(1);
          //                  string connectionString1;
          //                  connectionString1 = conStr1.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
          //                  MySqlConnection connection1 = new MySqlConnection(connectionString1);
          //                  string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
          //                              + "VALUES(" + IDpish + ", " + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + ", 14, 'проверка закочилась в автоматическом режиме с ошибкой (отсутствует распознанный ГРЗ)', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
          //                  command1.CommandText = z1;
          //                  command1.Connection = connection1;
          //                  connection1.Open();
          //                  command1.ExecuteNonQuery();
          //                  command1.Connection.Close();

          //                  MySqlCommand command3 = new MySqlCommand();
          //                  ConnectStr conStr3 = new ConnectStr();
          //                  Zapros zapros3 = new Zapros();
          //                  conStr3.ConStr(1);
          //                  cstr = conStr3.StP;
          //                  zapros3.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), NamU, 14, "проверка закочилась в автоматическом режиме с ошибкой (отсутствует распознанный ГРЗ)", "0", 0, "", "", "");
          //                  MySqlConnection connection3 = new MySqlConnection(cstr);
          //                  MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
          //                  string z3 = zapros3.commandStringTest;
          //                  cmd.CommandText = z3;
          //                  cmd.Connection = connection3;

          //                  connection3.Open();
          //                  cmd.ExecuteNonQuery();
          //                  connection3.Close();
          //              }

          //          }
          //          else if (data1.a[145] != "0")
          //          {

          //          }
          //          else if (ImOb == null)
          //          {
          //              if (data1.a[150] != "14")
          //              {
          //                  MySqlCommand command1 = new MySqlCommand();
          //                  ConnectStr conStr1 = new ConnectStr();
          //                  conStr1.ConStr(1);
          //                  string connectionString1;
          //                  connectionString1 = conStr1.StP;
          //                  MySqlConnection connection1 = new MySqlConnection(connectionString1);
          //                  string z1 = "INSERT INTO rap_ststus_pr(Id_pr, Date_pr, ID_Status, Name_Status, Date_Chang, NUs, PlatformID)"
          //+ "VALUES(" + IDpish + ", " + (Convert.ToDateTime(data1.a[6] + " " + data1.a[7]).ToString("yyyyMMddHHmmss")) + ", 14, 'проверка закочилась в автоматическом режиме с ошибкой (отсутствует фотофиксация ТС)', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.ffffff") + "', 'AUTO', " + PLN + ")";
          //                  command1.CommandText = z1;
          //                  command1.Connection = connection1;
          //                  connection1.Open();
          //                  command1.ExecuteNonQuery();
          //                  command1.Connection.Close();
          //                  MySqlCommand command3 = new MySqlCommand();
          //                  ConnectStr conStr3 = new ConnectStr();
          //                  Zapros zapros3 = new Zapros();
          //                  conStr3.ConStr(1);
          //                  cstr = conStr3.StP;
          //                  zapros3.ZaprObrOTPRLoc(Convert.ToInt32(data1.a[4]), "AUTO", 14, "проверка закочилась в автоматическом режиме с ошибкой (отсутствует фотофиксация ТС)", "0", 0, "", "", "");
          //                  MySqlConnection connection3 = new MySqlConnection(cstr);
          //                  MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
          //                  string z3 = zapros3.commandStringTest;
          //                  cmd.CommandText = z3;
          //                  cmd.Connection = connection3;
          //                  connection3.Open();
          //                  cmd.ExecuteNonQuery();
          //                  connection3.Close();
          //              }
          //          }
                }
                catch (MySqlException ex)
                { return; }
                finally
                { int w = 1; }
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
                        BetOs[8, 0] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 1] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 2] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 3] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 4] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 5] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 6] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 7] = Convert.ToDouble(reader["wheelcount"]) / 2;
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
                        BetOs[8, 8] = Convert.ToDouble(reader["wheelcount"]) / 2;
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

                    if (reader["Class2"].ToString().Length > 3)
                    { data1.a[2] = reader["Class2"].ToString().Substring(0, 2); }
                    else if (reader["Class2"].ToString().Length == 3)
                    { data1.a[2] = reader["Class2"].ToString().Substring(0, 1); }
                    else { data1.a[2] = "12"; }

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
                    AC[ic - 1] = ic;
                    if (ic <= KolOs)
                    {
                        AI[ic - 1] = Convert.ToDecimal(BetOs[3, ic]);
                    }
                    AL[ic - 1] = Convert.ToDecimal((Math.Round(BetOs[4, ic - 1] - BetOs[4, ic - 1] / 100 * 10 / 1000, 3)));
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
                        names3[ic].groupNumber = Convert.ToString(GrO + 1);
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
             
        #region //////////////////////////////////////////////////////////////// заполняем ПДК по осям и превышения (левая)    ////////////////////////////////

        public void PDKOs() {
            try
            {
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
                namesGRUP[0].PDKmass = data1.c[9, 0];
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
                            namesGRUP[0].DifferencePDKFact = c11.ToString();
                            namesGRUP[0].massPrev = data1.c[12, 0];
                            namesGRUP[0].massPrevSR = "0";
                            namesGRUP[0].massSign = "true";
                            SigGr = "true";
                            namesGRUP[0].factPremission = "false";

                            XDate[31] = "True";
                            PrevNar[10] = Math.Round(Convert.ToDouble(c11), 0);
                            PrevNar[37] = 1;
                        }
                        else
                        {
                            XDate[31] = "False";
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
                        else
                        {
                            XDate[31] = "False";
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
                        data1.c[11, 0] = "-"; data1.c[12, 0] = "-";
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
                        else
                        {
                            XDate[31] = "False";
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
                        else
                        {
                            XDate[31] = "False";
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
                            data1.c[11, ic] = "-"; data1.c[12, ic] = "-";
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
                            data1.c[11, ic] = "-"; data1.c[12, ic] = "-";
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
                            data1.c[11, ic] = "-"; data1.c[12, ic] = "-";
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
                if (PrevNar[PrNar] > PPRNAR && PrNar < 25)
                {
                    PPRNAR = PrevNar[PrNar];
                    MAXiNar = MAXiNar + 1;
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
                        MAXPREV = Convert.ToDouble(data1.b[12, iNar]); ;
                        MAXPREVPROTC = Convert.ToDouble(data1.b[11, iNar]);
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
                        names3[Convert.ToInt32(PrevNar[31]) - 1].NomStatei = PrevNar[34].ToString();
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
                        MAXPREV = Convert.ToDouble(data1.c[12, iNar - 10]); ;
                        MAXPREVPROTC = Convert.ToDouble(data1.c[11, iNar - 10]);
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
                        namesGRUP[Convert.ToInt32(PrevNar[31]) - 1].NomStatei = PrevNar[34].ToString();
                    }
                    else if (iNar == 17)
                    {
                        NNarushen = "IsOverweightGross"; //  IsOverweightPartial IsOversized IsOverspeed 
                        UPDDannNarAndKl(NNarushen);
                        TypNar = 3;
                        TypNarTXT = "Превышение общей массы АТС";
                        EDIzm = "( т.)";
                        MAXPREV = Convert.ToDouble(data1.a[52]);
                        MAXPREVPROTC = Convert.ToDouble(data1.a[53]);
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
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[9])*/; PrevNar[33] = Convert.ToDouble(XDate[9]) * 100; MAXPREV = Convert.ToDouble(XDate[9]); }
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
                            {
                                PrevNar[34] = 4; /*PrevNar[33] = PrevDlPr;*/ /*MAXPREV = Convert.ToDouble(XDate[22]);*/
                                if (iNar == 18)
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[22]); */PrevNar[33] = Convert.ToDouble(XDate[22]) * 100; MAXPREV = Convert.ToDouble(XDate[22]); }
                                else if (iNar == 19)
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[20]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[23]);*/ PrevNar[33] = Convert.ToDouble(XDate[23]) * 100; MAXPREV = Convert.ToDouble(XDate[23]); }
                                else if (iNar == 20)
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[21]) / Convert.ToDouble(data1.a[61]) * 100), 0));/*Convert.ToDouble(XDate[24]); */PrevNar[33] = Convert.ToDouble(XDate[24]) * 100; MAXPREV = Convert.ToDouble(XDate[24]); }
                            }
                            else if (PrevDlPr * 100 >= 21 && PrevDlPr * 100 <= 50)
                            {
                                PrevNar[34] = 5; /*PrevNar[33] = PrevDlPr;*//* MAXPREV = Convert.ToDouble(XDate[22]);*/
                                if (iNar == 18)
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));/*Convert.ToDouble(XDate[22]);*/ PrevNar[33] = Convert.ToDouble(XDate[22]) * 100; MAXPREV = Convert.ToDouble(XDate[22]); }
                                else if (iNar == 19)
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[20]) / Convert.ToDouble(data1.a[58]) * 100), 0));/*Convert.ToDouble(XDate[23]);*/ PrevNar[33] = Convert.ToDouble(XDate[23]) * 100; MAXPREV = Convert.ToDouble(XDate[23]); }
                                else if (iNar == 20)
                                { MAXPREVPROTC = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[21]) / Convert.ToDouble(data1.a[61]) * 100), 0)); /*Convert.ToDouble(XDate[24]);*/ PrevNar[33] = Convert.ToDouble(XDate[24]) * 100; MAXPREV = Convert.ToDouble(XDate[24]); }
                            }
                            else if (PrevDlPr * 100 >= 51)
                            {
                                PrevNar[34] = 6; PrevNar[33] = PrevDlPr;
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
                    if (/*KOGrNar > 1 && */iNar < 25)
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
            if (MAXiNar > 0 && CodNarAN[MAXiNar - 1].KNRA != 1)
            {
                CodNarM = "";
                TypNarTXTM = "";
                EDIzmM = "";
                MAXPREVM = "";
                MAXPREVPROTCM = "";

                CodNarM = CodNarAN[MAXiNar - 1].CodNarANg.ToString();
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
            { int w = 1;
}

          ////////try { 
          ////////      KNR = new int[2, 10];
          ////////      ZOsPDK();

          ////////      #region //////////////////////////////////////////////////////////////// заполняем ПДК по тележкам и превышения (левая)    ////////////////////////////////
          ////////      KNR[1, 0] = Convert.ToInt32(TypO[1]);
          ////////      KNR[0, 0] = 1;
          ////////      ///////////////////////////////////////////       Заполняем первую строку ///////////////////////////////////////////////////
          ////////      if (KNR[1, 0] == 1)
          ////////      {
          ////////          data1.c[9, 0] = Convert.ToString(PDKO[1]);// / Convert.ToInt32(TypO[ic + 1]);
          ////////          if (names3[1].massSR == "0")
          ////////          {
          ////////              data1.c[10, 0] = "-";
          ////////              if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 2) > 0)
          ////////              {
          ////////                  data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 0));
          ////////                  data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) - Convert.ToDouble(data1.c[9, 0]), 2));
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 0) >= 3)
          ////////                  {
          ////////                      XDate[31] = "True";
          ////////                      PrevNar[10] = Math.Round(Convert.ToDouble(data1.c[11, 0]), 0);
          ////////                      PrevNar[37] = 1;
          ////////                  }
          ////////                  else { XDate[31] = "False"; }
          ////////              }
          ////////              else
          ////////              {
          ////////                  data1.c[11, 0] = "-";
          ////////                  data1.c[12, 0] = "-";
          ////////              }
          ////////          }
          ////////          else
          ////////          {
          ////////              data1.c[10, 0] = names3[1].massSR;
          ////////              if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(names3[1].massSR)) * 100 - 100, 2) > 0)
          ////////              {
          ////////                  data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(names3[0].massSR)) * 100 - 100, 0));
          ////////                  data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) - Convert.ToDouble(names3[0].massSR), 2));
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(names3[0].massSR)) * 100 - 100, 0) >= 3)
          ////////                  {
          ////////                      XDate[31] = "True";
          ////////                      PrevNar[10] = Math.Round(Convert.ToDouble(data1.c[11, 0]), 0);
          ////////                      PrevNar[37] = 1;
          ////////                  }
          ////////                  else { XDate[31] = "False"; }
          ////////              }
          ////////              else
          ////////              {
          ////////                  data1.c[11, 0] = "-"; data1.c[12, 0] = "-";
          ////////              }
          ////////          }
          ////////      }
          ////////      else if (KNR[1, 0] > 1 && KNR[1, 0] < 4)
          ////////      {
          ////////          D1_2 = 0;
          ////////          D1S_2S = 0;
          ////////          for (icC = 1; icC <= TypO[1]; icC++)
          ////////          {
          ////////              D1_2 = D1_2 + PDKTel[icC];
          ////////              D1S_2S = D1S_2S + Convert.ToDouble(names3[icC].massSR);////-1].massSR);
          ////////          }
          ////////          data1.c[9, 0] = Convert.ToString(D1_2 / TypO[1]);//icC;// / Convert.ToInt32(TypO[ic + 1]);
          ////////          if (names3[1].massSR == "0")
          ////////          {
          ////////              data1.c[10, 0] = "-";
          ////////              if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 2) > 0)
          ////////              {
          ////////                  data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 0));
          ////////                  data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) - Convert.ToDouble(data1.c[9, 0]), 2));
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[9, 0])) * 100 - 100, 0) >= 3)
          ////////                  {
          ////////                      XDate[31] = "True";
          ////////                      PrevNar[10] = Convert.ToDouble(data1.c[11, 0]);
          ////////                      PrevNar[37] = 1;

          ////////                      for (icC = 1; icC <= TypO[1]; icC++)
          ////////                      {
          ////////                          PDKOsTel[icC] = 1;
          ////////                      }
          ////////                  }
          ////////                  else { XDate[31] = "False"; }
          ////////              }
          ////////              else
          ////////              {
          ////////                  data1.c[11, 0] = "-";
          ////////                  data1.c[12, 0] = "-";
          ////////              }
          ////////          }
          ////////          else
          ////////          {
          ////////              data1.c[10, 0] = Convert.ToString(D1S_2S);// / TypO[1];
          ////////              if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[10, 0])) * 100 - 100, 2) > 0)
          ////////              {
          ////////                  data1.c[11, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[10, 0])) * 100 - 100, 0));
          ////////                  data1.c[12, 0] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, 0]) - Convert.ToDouble(data1.c[10, 0]), 2));
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, 0]) / (Convert.ToDouble(data1.c[10, 0])) * 100 - 100, 0) >= 3)
          ////////                  {
          ////////                      XDate[31] = "True";
          ////////                      PrevNar[10] = Math.Round(Convert.ToDouble(data1.c[11, 0]), 0);
          ////////                      PrevNar[37] = 1;
          ////////                      for (icC = 1; icC <= TypO[1]; icC++)
          ////////                      {
          ////////                          PDKOsTel[icC] = 1;
          ////////                      }

          ////////                  }
          ////////                  else { XDate[31] = "False"; }
          ////////              }
          ////////              else
          ////////              {
          ////////                  data1.c[11, 0] = "-";
          ////////                  data1.c[12, 0] = "-";
          ////////              }
          ////////          }
          ////////      }
          ////////      else if (KNR[1, 0] > 3)
          ////////      {
          ////////          XDate[31] = "False";
          ////////          data1.c[2, 0] = "-";
          ////////          data1.c[9, 0] = "-";
          ////////          data1.c[10, 0] = "-";
          ////////          data1.c[11, 0] = "-";
          ////////          data1.c[12, 0] = "-";
          ////////      }
          ////////      ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          ////////      ////////////////////// Заполняем строки таблицы больше чем первая 
          ////////      Fx = 0;
          ////////      for (ic = 1; ic < GrO; ic++)
          ////////      {
          ////////          Sk = "";
          ////////          for (j = 0; j <= ic; j++)
          ////////          {
          ////////              Sk = Sk + Convert.ToString(KNR[1, j]);
          ////////          }
          ////////          Sk = Sk + "1";
          ////////          Fx = 0;
          ////////          for (j = 0; j < Sk.Length; j++)
          ////////          {
          ////////              Fx = Fx + int.Parse(Convert.ToString(Sk[j]));
          ////////          }
          ////////          KNR[1, ic] = Convert.ToInt32(TypO[Fx]);//Количество
          ////////          KNR[0, ic] = Fx; //Позиция
          ////////      }
          ////////      ////////////////////////////////////////////////////////////////////
          ////////      for (ic = 1; ic < GrO; ic++)
          ////////      {
          ////////          if (KNR[1, ic] == 1)
          ////////          {
          ////////              data1.c[9, ic] = Convert.ToString(PDKO[KNR[0, ic]]);// / Convert.ToInt32(TypO[ic + 1]);
          ////////                                                                  //data1.c[10, ic] = names3[ic].massSR;
          ////////                                                                  //if ((data1.c[10, ic] == null) || data1.c[10, ic] == "") {
          ////////              if (names3[ic].massSR == "0")
          ////////              {
          ////////                  data1.c[10, ic] = "-";
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 2) > 0)
          ////////                  {
          ////////                      data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0));
          ////////                      data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[9, ic]), 2));
          ////////                      if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0) >= 3)
          ////////                      {
          ////////                          XDate[31] = "True";
          ////////                          PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
          ////////                          PrevNar[37] = 1;
          ////////                      }
          ////////                      else { XDate[31] = "False"; }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.c[11, ic] = "-"; data1.c[12, ic] = "-";
          ////////                  }
          ////////              }
          ////////              else
          ////////              {
          ////////                  data1.c[10, ic] = names3[ic].massSR;
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 2) > 0)
          ////////                  {
          ////////                      data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0));
          ////////                      data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[10, ic]), 2));
          ////////                      if (/*Math.Floor(*/Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0)/*)*/ >= 3)
          ////////                      {
          ////////                          XDate[31] = "True";
          ////////                          PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
          ////////                          PrevNar[37] = 1;
          ////////                      }
          ////////                      else { XDate[31] = "False"; }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.c[11, ic] = "-"; data1.c[12, ic] = "-";
          ////////                  }
          ////////              }
          ////////          }
          ////////          else if (KNR[1, ic] > 1 && KNR[1, ic] < 4)
          ////////          {
          ////////              D1_2 = 0;
          ////////              D1S_2S = 0;
          ////////              for (icC = KNR[0, ic]; icC < (KNR[0, ic] - 1 + KNR[1, ic]); icC++)
          ////////              {
          ////////                  D1S_2S = D1S_2S + Convert.ToDouble(names3[icC].massSR); ////-1].massSR);
          ////////                  if (icC < 8)
          ////////                  {
          ////////                      D1_2 = PDKTel[icC + 1];
          ////////                  }
          ////////              }
          ////////              data1.c[9, ic] = Convert.ToString(D1_2);// / Convert.ToInt32(TypO[ic + 1]);
          ////////              if (names3[ic].massSR == "0")
          ////////              {
          ////////                  data1.c[10, 0] = "-";
          ////////                  //data1.c[10, 0] = Convert.ToString(Convert.ToDouble(names3[0].massSR));
          ////////                  //data1.c[10, ic] = Convert.ToString(Convert.ToDouble(names3[ic].massSR) * KNR[1, ic]);
          ////////                  //if ((data1.c[10, ic] == null) || data1.c[10, ic] == "") { data1.c[10, ic] = "0"; }
          ////////                  //if ((data1.c[10, 0] == null) || data1.c[10, 0] == "") { data1.c[10, 0] = "0"; }
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 2) > 0)
          ////////                  {
          ////////                      data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0));
          ////////                      data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[9, ic]), 2));
          ////////                      if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[9, ic])) * 100 - 100, 0) >= 3)
          ////////                      {
          ////////                          XDate[31] = "True";
          ////////                          PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
          ////////                          PrevNar[37] = 1;
          ////////                          for (icC = KNR[0, ic]; icC <= (KNR[0, ic] - 1 + KNR[1, ic]); icC++)
          ////////                          {
          ////////                              if (icC < 8)
          ////////                              {
          ////////                                  PDKOsTel[icC] = 2;
          ////////                              }
          ////////                          }
          ////////                      }
          ////////                      else { XDate[31] = "False"; }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.c[11, ic] = "-";
          ////////                      data1.c[12, ic] = "-";
          ////////                      //}
          ////////                  }
          ////////              }
          ////////              else
          ////////              {
          ////////                  //dataGridView2[10, 0].Value = Convert.ToString(Convert.ToDouble(names3[0].massSR));
          ////////                  data1.c[10, ic] = Convert.ToString(Convert.ToDouble(names3[ic].massSR) * KNR[1, ic]);
          ////////                  if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 2) > 0)
          ////////                  {
          ////////                      data1.c[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0));
          ////////                      data1.c[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.c[8, ic]) - Convert.ToDouble(data1.c[10, ic]), 2));
          ////////                      if (Math.Round(Convert.ToDouble(data1.c[8, ic]) / (Convert.ToDouble(data1.c[10, ic])) * 100 - 100, 0) >= 3)
          ////////                      {
          ////////                          XDate[31] = "True";
          ////////                          PrevNar[ic + 10] = Convert.ToDouble(data1.c[11, ic]);
          ////////                          PrevNar[37] = 1;
          ////////                          for (icC = KNR[0, ic]; icC <= (KNR[0, ic] - 1 + KNR[1, ic]); icC++)
          ////////                          {
          ////////                              if (icC < 8)
          ////////                              {
          ////////                                  PDKOsTel[icC] = 2;

          ////////                              }
          ////////                          }
          ////////                      }
          ////////                      else { XDate[31] = "False"; }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.c[11, ic] = "-"; data1.c[12, ic] = "-";
          ////////                      //}
          ////////                  }
          ////////              }
          ////////          }
          ////////          else if (KNR[1, ic] > 3)
          ////////          {
          ////////              XDate[31] = "False";
          ////////              data1.c[2, ic] = "-";
          ////////              data1.c[9, ic] = "-";
          ////////              data1.c[10, ic] = "-";
          ////////              data1.c[11, ic] = "-";
          ////////              data1.c[12, ic] = "-";
          ////////          }
          ////////          ////////////////////////////////////////////////////////////////////////
          ////////      }
          ////////      #endregion ///////////////////////////////////////////

          ////////      #region //////////////////////////////////////////////////////////////// заполняем ПДК по осям и превышения (левая)    ////////////////////////////////
          ////////      for (ic = 0; ic < (KolOs); ic++) //Convert.ToInt32(alphaBlendTextBox13.Text)); ic++)
          ////////      {
          ////////          if (ic < 9)
          ////////          {
          ////////              if (PDKOsTel[ic + 1] == 0 && Convert.ToInt32(TypO[ic + 1]) < 4)
          ////////              //if (PDKO[ic + 1] != 0)
          ////////              {
          ////////                  data1.b[9, ic] = Convert.ToString(PDKO[ic + 1]);
          ////////                  //data1.b[10, ic] = names3[ic].massSR;
          ////////                  if (names3[ic].massSR == "0")
          ////////                  //if ((data1.b[10, ic] == null) || data1.b[10, ic] == "" || data1.b[10, ic] == "0")
          ////////                  {
          ////////                      data1.b[10, ic] = "-"; /*}*/
          ////////                      if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (PDKO[ic + 1]) * 100 - 100, 2) > 0)
          ////////                      {
          ////////                          data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (PDKO[ic + 1]) * 100 - 100, 0));
          ////////                          data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - PDKO[ic + 1], 2));
          ////////                          if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (PDKO[ic + 1]) * 100 - 100, 0) >= 3)
          ////////                          {
          ////////                              XDate[31] = "True";
          ////////                              PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
          ////////                              PrevNar[37] = 1;
          ////////                          }
          ////////                          else { XDate[31] = "False"; }
          ////////                      }
          ////////                      else
          ////////                      {
          ////////                          data1.b[11, ic] = "-";
          ////////                          data1.b[12, ic] = "-";
          ////////                      }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.b[10, ic] = names3[ic].massSR;
          ////////                      if (Math.Round((Convert.ToDouble(data1.b[8, ic]) / Convert.ToDouble(names3[ic].massSR) * 100 - 100), 2) > 0)
          ////////                      {
          ////////                          data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / Convert.ToDouble(names3[ic].massSR) * 100 - 100, 0));
          ////////                          data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
          ////////                          if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / Convert.ToDouble(names3[ic].massSR) * 100 - 100, 0) > 2)
          ////////                          {
          ////////                              XDate[31] = "True";
          ////////                              PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
          ////////                              PrevNar[37] = 1;
          ////////                          }
          ////////                          else { XDate[31] = "False"; }
          ////////                          //dataGridView1.Rows[ic].DefaultCellStyle.BackColor = Color.LightPink;//.Red;
          ////////                      }
          ////////                      else
          ////////                      {
          ////////                          data1.b[11, ic] = "-";
          ////////                          //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
          ////////                          data1.b[12, ic] = "-";
          ////////                      }
          ////////                  }
          ////////              }
          ////////              else if (Convert.ToInt32(TypO[ic + 1]) < 4)
          ////////              {
          ////////                  data1.b[9, ic] = Convert.ToString(PDKTel[ic + 1] / Convert.ToInt32(TypO[ic + 1]));
          ////////                  //data1.b[10, ic] = names3[ic].massSR;
          ////////                  //if ((data1.b[10,ic] == null) || data1.b[10, ic] =="")
          ////////                  if (names3[ic].massSR == "0")
          ////////                  {
          ////////                      data1.b[10, ic] = "-";
          ////////                      if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 2) > 0)
          ////////                      {
          ////////                          data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 0));
          ////////                          data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(data1.b[9, ic]), 2));
          ////////                          if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 0) >= 3)
          ////////                          {
          ////////                              XDate[31] = "True";
          ////////                              PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
          ////////                              PrevNar[37] = 1;
          ////////                          }
          ////////                          else { XDate[31] = "False"; }
          ////////                      }
          ////////                      else
          ////////                      {
          ////////                          data1.b[11, ic] = "-";
          ////////                          data1.b[12, ic] = "-";
          ////////                      }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.b[10, ic] = names3[ic].massSR;
          ////////                      if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 2) > 0)
          ////////                      {
          ////////                          data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0));
          ////////                          data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
          ////////                          if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0) > 2)
          ////////                          { XDate[31] = "True"; PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]); PrevNar[37] = 1; }
          ////////                          else { XDate[31] = "False"; }
          ////////                          //dataGridView1.Rows[ic].DefaultCellStyle.BackColor = Color.LightPink;//.Red;
          ////////                      }
          ////////                      else
          ////////                      { data1.b[11, ic] = "-"; data1.b[12, ic] = "-"; }
          ////////                  }
          ////////              }
          ////////              else if (Convert.ToInt32(TypO[ic + 1]) > 3)
          ////////              {
          ////////                  data1.b[9, ic] = Convert.ToString(PDKO[ic + 1]);
          ////////                  //data1.b[10, ic] = names3[ic].massSR;
          ////////                  //if ((data1.b[10, ic] == null) || data1.b[10, ic] == "")
          ////////                  if (names3[ic].massSR == "0")
          ////////                  {
          ////////                      data1.b[10, ic] = "-";
          ////////                      if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 2) > 0)
          ////////                      {
          ////////                          data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 0));
          ////////                          data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(data1.b[9, ic]), 2));
          ////////                          if (Math.Floor(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(data1.b[9, ic])) * 100 - 100, 2)) >= 3)
          ////////                          {
          ////////                              XDate[31] = "True";
          ////////                              PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
          ////////                              PrevNar[37] = 1;
          ////////                          }
          ////////                          else { XDate[31] = "False"; }
          ////////                      }
          ////////                      else
          ////////                      {
          ////////                          data1.b[11, ic] = "-";
          ////////                          data1.b[12, ic] = "-";
          ////////                      }
          ////////                  }
          ////////                  else
          ////////                  {
          ////////                      data1.b[10, ic] = names3[ic].massSR;
          ////////                      if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 2) > 0)
          ////////                      {
          ////////                          data1.b[11, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0));
          ////////                          data1.b[12, ic] = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
          ////////                          if (Math.Round(Convert.ToDouble(data1.b[8, ic]) / (Convert.ToDouble(names3[ic].massSR)) * 100 - 100, 0) > 2)
          ////////                          { XDate[31] = "True"; PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]); PrevNar[37] = 1; }
          ////////                          else { XDate[31] = "False"; }
          ////////                      }
          ////////                      else
          ////////                      { data1.b[11, ic] = "-"; data1.b[12, ic] = "-"; }
          ////////                  }
          ////////              }
          ////////          }
          ////////          if (names3[ic].massSR == "0")
          ////////          {
          ////////              names3[ic].massPrev = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(data1.b[9, ic]), 2));
          ////////              names3[ic].PDKmass = Convert.ToString(data1.b[9, ic]);
          ////////              if (Convert.ToDouble(names3[ic].massPrev) > 3)
          ////////              {
          ////////                  names3[ic].massSign = "true";
          ////////                  if (data1.b[11, ic].ToString() == "-")
          ////////                  { PrevNar[ic] = 0; }
          ////////                  else
          ////////                  {
          ////////                      PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
          ////////                      PrevNar[37] = 1;
          ////////                  }
          ////////              }
          ////////              else
          ////////              {
          ////////                  names3[ic].massSign = "false";
          ////////                  names3[ic].massPrev = "0";
          ////////              }
          ////////          }
          ////////          else
          ////////          {
          ////////              names3[ic].massPrevSR = Convert.ToString(Math.Round(Convert.ToDouble(data1.b[8, ic]) - Convert.ToDouble(names3[ic].massSR), 2));
          ////////              names3[ic].PDKmass = Convert.ToString(data1.b[9, ic]);
          ////////              if (Convert.ToDouble(names3[ic].massPrevSR) > 2)
          ////////              {
          ////////                  names3[ic].massSign = "true";
          ////////                  if (data1.b[11, ic].ToString() == "-")
          ////////                  { PrevNar[ic] = 0; }
          ////////                  else
          ////////                  {
          ////////                      PrevNar[ic] = Convert.ToDouble(data1.b[11, ic]);
          ////////                      PrevNar[37] = 1;
          ////////                  }
          ////////              }
          ////////              else
          ////////              {
          ////////                  names3[ic].massSign = "false";
          ////////                  names3[ic].massPrevSR = "0";
          ////////              }
          ////////          }
          ////////      }
          ////////      #endregion //////////////////////////
          ////////      PPRNAR = PrevNar[0];
          ////////      iNar = 0;
          ////////      int INr = 0;
          ////////      for (int PrNar = 1; PrNar < 25; PrNar++)
          ////////      {
          ////////          if (PrevNar[PrNar] > 0)
          ////////          { iNar = iNar + 1; }
          ////////      }
          ////////      if (iNar > 0)
          ////////      { CodNarAN = new CODE[iNar]; }
          ////////      iNar = 0;
          ////////      MAXiNar = 0;
          ////////      for (int PrNar = 1; PrNar <= 25; PrNar++)
          ////////      {
          ////////          CodNar = "";
          ////////          iNar = PrNar;
          ////////          if (PrevNar[PrNar] > PPRNAR && PrNar<25)
          ////////          {
          ////////              PPRNAR = PrevNar[PrNar];
          ////////              MAXiNar = MAXiNar+1;
          ////////          }
          ////////          if (PrevNar[PrNar] > 0)
          ////////          {
          ////////              //INr= INr+1;
          ////////              if (iNar > 0 && iNar < 10)
          ////////              {
          ////////                  NNarushen = "IsOverweightPartial";
          ////////                  UPDDannNarAndKl(NNarushen);
          ////////                  PrevNar[31] = iNar + 1;
          ////////                  TypNar = 1;
          ////////                  TypNarTXT = "Превышение нагрузки на ось";
          ////////                  EDIzm = "( т.)";
          ////////                  MAXPREV = Convert.ToDouble(data1.b[12, iNar]); ;
          ////////                  MAXPREVPROTC = Convert.ToDouble(data1.b[11, iNar]);
          ////////                  PrevNar[30] = 1;
          ////////                  if (PrevNar[29] == 1)
          ////////                  {
          ////////                      PrevNar[32] = 1;
          ////////                      if (MAXPREVPROTC >= 2 && MAXPREVPROTC <= 10)
          ////////                      { PrevNar[34] = 1; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
          ////////                      { PrevNar[34] = 2; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
          ////////                      { PrevNar[34] = 3; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
          ////////                  }
          ////////                  else if (PrevNar[29] == 2)
          ////////                  {
          ////////                      PrevNar[32] = 2;
          ////////                      if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
          ////////                      { PrevNar[34] = 4; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
          ////////                      { PrevNar[34] = 5; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
          ////////                  }
          ////////              }
                        
          ////////              else if (iNar >= 10 && iNar < 17)
          ////////              {
          ////////                  NNarushen = "IsOverweightGroup"; //IsOverweightGross  IsOverweightPartial IsOversized IsOverspeed 
          ////////                  UPDDannNarAndKl(NNarushen);
          ////////                  PrevNar[31] = iNar - 9;
          ////////                  TypNar = 2;
          ////////                  TypNarTXT = "Превышение нагрузки на группу осей";
          ////////                  EDIzm = "( т.)";
          ////////                  KOGrNar = KNR[1, iNar - 9];
          ////////                  MAXPREV = Convert.ToDouble(data1.c[12, iNar - 10]); ;
          ////////                  MAXPREVPROTC = Convert.ToDouble(data1.c[11, iNar - 10]);
          ////////                  PrevNar[30] = 2;
          ////////                  if (PrevNar[29] == 1)
          ////////                  {
          ////////                      PrevNar[32] = 1;
          ////////                      if (MAXPREVPROTC >= 2 && MAXPREVPROTC <= 10)
          ////////                      { PrevNar[34] = 1; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
          ////////                      { PrevNar[34] = 2; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
          ////////                      { PrevNar[34] = 3; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
          ////////                  }
          ////////                  else if (PrevNar[29] == 2)
          ////////                  {
          ////////                      PrevNar[32] = 2;
          ////////                      if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
          ////////                      { PrevNar[34] = 4; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
          ////////                      { PrevNar[34] = 5; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
          ////////                  }
          ////////              }
          ////////              else if (iNar == 17)
          ////////              {
          ////////                  NNarushen = "IsOverweightGross"; //  IsOverweightPartial IsOversized IsOverspeed 
          ////////                  UPDDannNarAndKl(NNarushen);
          ////////                  TypNar = 3;
          ////////                  TypNarTXT = "Превышение общей массы АТС";
          ////////                  EDIzm = "( т.)";
          ////////                  MAXPREV = Convert.ToDouble(data1.a[52]);
          ////////                  MAXPREVPROTC = Convert.ToDouble(data1.a[53]);
          ////////                  PrevNar[30] = 3;
          ////////                  if (PrevNar[29] == 1)
          ////////                  {
          ////////                      PrevNar[32] = 1;
          ////////                      if (MAXPREVPROTC >= 2 && MAXPREVPROTC <= 10)
          ////////                      { PrevNar[34] = 1; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
          ////////                      { PrevNar[34] = 2; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
          ////////                      { PrevNar[34] = 3; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
          ////////                  }
          ////////                  else if (PrevNar[29] == 2)
          ////////                  {
          ////////                      PrevNar[32] = 2;
          ////////                      if (MAXPREVPROTC >= 11 && MAXPREVPROTC <= 20)
          ////////                      { PrevNar[34] = 4; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 21 && MAXPREVPROTC <= 50)
          ////////                      { PrevNar[34] = 5; PrevNar[33] = MAXPREVPROTC; }
          ////////                      else if (MAXPREVPROTC >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = MAXPREVPROTC; }
          ////////                  }
          ////////              }
          ////////              else if (iNar >= 18 && iNar < 21)
          ////////              {
          ////////                  NNarushen = "IsOversized"; //IsOverweightGross  IsOverweightPartial  IsOverspeed 
          ////////                  UPDDannNarAndKl(NNarushen);
          ////////                  TypNar = 4;
          ////////                  TypNarTXT = "Превышение габаритов АТС";
          ////////                  EDIzm = "( м.)";
          ////////                  PrevNar[30] = 4;
          ////////                  if (PrevNar[29] == 1)
          ////////                  {
          ////////                      PrevNar[32] = 1;
          ////////                      if (PrevDlPr >= 1 && PrevDlPr <= 10)
          ////////                      { PrevNar[34] = 1; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[9]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                      else if (PrevDlPr >= 11 && PrevDlPr <= 20)
          ////////                      { PrevNar[34] = 2; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[9]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                      else if (PrevDlPr >= 21 && PrevDlPr <= 50)
          ////////                      { PrevNar[34] = 3; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[9]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                      else if (PrevDlPr >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[9]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                  }
          ////////                  else if (PrevNar[29] == 2)
          ////////                  {
          ////////                      PrevNar[32] = 2;
          ////////                      if (PrevDlPr >= 11 && PrevDlPr <= 20)
          ////////                      { PrevNar[34] = 4; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[22]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                      else if (PrevDlPr >= 21 && PrevDlPr <= 50)
          ////////                      { PrevNar[34] = 5; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[22]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                      else if (PrevDlPr >= 51)
          ////////                      { PrevNar[34] = 6; PrevNar[33] = PrevDlPr; MAXPREV = Convert.ToDouble(XDate[22]); MAXPREVPROTC = Convert.ToDouble(PrevDlPr); }
          ////////                  }
          ////////              }
          ////////              else if (iNar > 20 && iNar < 25)
          ////////              {
          ////////                  NNarushen = "IsOverspeed"; //IsOverweightGross  IsOverweightPartial IsOversized  
          ////////                  UPDDannNarAndKl(NNarushen);
          ////////                  TypNar = 5;
          ////////                  TypNarTXT = "Превышение скорости движения АТС";
          ////////                  EDIzm = "(км/ч)";
          ////////              }
          ////////              if (PrevNar[37] == 1 && PrevNar[38] == 0)
          ////////              { PrevNar[28] = 1; }
          ////////              else if (PrevNar[37] == 0 && PrevNar[38] == 1)
          ////////              { PrevNar[28] = 2; }
          ////////              else if (PrevNar[37] == 1 && PrevNar[38] == 1)
          ////////              { PrevNar[28] = 3; }

          ////////              if (PrevNar[30] > 0 && PrevNar[30] < 4)
          ////////              {
          ////////                  if (PrevNar[33] < 1000)
          ////////                  {
          ////////                      if (PrevNar[33] < 100)
          ////////                      {
          ////////                          if (PrevNar[33] < 10)
          ////////                          {
          ////////                              PNarSTEPEN = "000" + PrevNar[33].ToString();
          ////////                          }
          ////////                          else { PNarSTEPEN = "00" + PrevNar[33].ToString(); }
          ////////                      }
          ////////                      else { PNarSTEPEN = "0" + PrevNar[33].ToString(); }
          ////////                  }
          ////////                  else { PNarSTEPEN = PrevNar[33].ToString(); }
          ////////              }
          ////////              else if (PrevNar[30] > 3 && PrevNar[30] < 7)
          ////////              {
          ////////                  if (PrevNar[39] < 1000)
          ////////                  {
          ////////                      if (PrevNar[39] < 100)
          ////////                      {
          ////////                          if (PrevNar[39] < 10)
          ////////                          {
          ////////                              PNarSTEPEN = "000" + PrevNar[39].ToString();
          ////////                          }
          ////////                          else { PNarSTEPEN = "00" + PrevNar[39].ToString(); }
          ////////                      }
          ////////                      else { PNarSTEPEN = "0" + PrevNar[39].ToString(); }
          ////////                  }
          ////////                  else { PNarSTEPEN = PrevNar[39].ToString(); }
          ////////              }
          ////////              else { PNarSTEPEN = "0000"; }



          ////////              if (KolOs < 10)
          ////////              {
          ////////                  if (PrevNar[34] < 10) { CodNar = PrevNar[25].ToString() + "0" + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + "0" + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + "0" + PrevNar[34].ToString() + "00"; }

          ////////                  else { CodNar = PrevNar[25].ToString() + "0" + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + "0" + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + PrevNar[34].ToString() + "00"; }
          ////////              }
          ////////              else
          ////////              {
          ////////                  if (PrevNar[34] < 10) { CodNar = PrevNar[25].ToString() + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + "0" + PrevNar[34].ToString() + "00"; }

          ////////                  else { CodNar = PrevNar[25].ToString() + PrevNar[26].ToString() + PrevNar[27].ToString() + PrevNar[28].ToString() + PrevNar[29].ToString() + PrevNar[30].ToString() + PrevNar[31].ToString() + PrevNar[32].ToString() + PNarSTEPEN.ToString() + PrevNar[34].ToString() + "00"; }
          ////////              }
          ////////              //names3[ic].massFact
          ////////              if (/*KOGrNar > 1 && */iNar<25)
          ////////              {
          ////////                  CodNarAN[INr].CodNarANg = CodNar;
          ////////                  CodNarAN[INr].TypNarTXTA = TypNarTXT;
          ////////                  CodNarAN[INr].EDIzmA = EDIzm;
          ////////                  CodNarAN[INr].MAXPREVA = MAXPREV;
          ////////                  CodNarAN[INr].MAXPREVPROTCA = MAXPREVPROTC;
          ////////                  CodNarAN[INr].KNRA = KOGrNar;
          ////////              INr = INr + 1;
          ////////              }
          ////////              KOGrNar = 0;
          ////////          }
          ////////      }
          ////////      if ( MAXiNar>0 && CodNarAN[MAXiNar - 1].KNRA != 1)
          ////////      {
          ////////          CodNarM = "";
          ////////          TypNarTXTM = "";
          ////////          EDIzmM = "";
          ////////          MAXPREVM = "";
          ////////          MAXPREVPROTCM = "";

          ////////          CodNarM = CodNarAN[MAXiNar-1].CodNarANg.ToString();
          ////////          TypNarTXTM = CodNarAN[MAXiNar - 1].TypNarTXTA.ToString();
          ////////          EDIzmM = CodNarAN[MAXiNar - 1].EDIzmA.ToString();
          ////////          MAXPREVM = CodNarAN[MAXiNar - 1].MAXPREVA.ToString();
          ////////          MAXPREVPROTCM = CodNarAN[MAXiNar - 1].MAXPREVPROTCA.ToString();
          ////////          //CodNarAN[MAXiNar - 1].KNRA = KOGrNar;
          ////////          VNTN = "выявлено нарушение (" + TypNarTXTM + ")";
          ////////      }

          ////////      int i1 = 0;
          ////////      int i2 = 0;
          ////////      int cnt = 0;
          ////////      tipoS = "";
          ////////      for (i1 = 0; i1 < 9; i1++)
          ////////      {
          ////////          if (KN[1, i1] > 0)
          ////////          {
          ////////              tipoS = tipoS + KN[1, i1].ToString() + "+";
          ////////          }
          ////////      }
          ////////      if (tipoS != "")
          ////////      {
          ////////          tipoS = tipoS.Remove(tipoS.Length - 1, 1);
          ////////      }
          ////////      data1.a[46] = tipoS;
          ////////  }
          ////////  catch (MySqlException ex)
          ////////  { return; }
          ////////  finally
          ////////  { int w = 1; }
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
                PrevNar[38] = 1;
                PrevNar[39] = Math.Round(Convert.ToDouble(XDate[9]) * 100, 0);
                PrevDlPr = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(data1.a[56]) / Convert.ToDouble(data1.a[55]) * 100), 0));
                PrevNar[18] = PrevDlPr;
            }
            if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(data1.a[56]) <= 0)
            {
                XDate[9] = "0";
            }
            ////////////////// Ширина превыш
            if (data1.a[247] != "-")
            {
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]) > 0)
                {
                    XDate[10] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]), 2));
                }
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[247]) <= 0)
                {
                    XDate[10] = "0";
                }
            }
            else
            {
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]) > 0)
                {
                    XDate[10] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]), 2));
                }
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(data1.a[59]) <= 0)
                {
                    XDate[10] = "0";
                }
            }
            ///////////////// Высота превыш
            //if (data1.a[247] != "-")
            //{

            //}
            //else
            //{
                if (Convert.ToDouble(data1.a[60]) - Convert.ToDouble(data1.a[62]) > 0)
                {
                    XDate[11] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[60]) - Convert.ToDouble(data1.a[62]), 2));
                }
                if (Convert.ToDouble(data1.a[60]) - Convert.ToDouble(data1.a[62]) <= 0)
                {
                    XDate[11] = "0";
                }
            //}
            ////////////////////////// И по СР
            ///////////////////// Длина превыш
            if (XDate[12].ToString() != "False")
            {
                if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()) > 0)
                {
                    XDate[22] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()),2));
                    PrevNar[38] = 1;
                    PrevNar[39] = Math.Round(Convert.ToDouble(XDate[22]) * 100, 0);
                    
                    //PrevDlPr = Convert.ToDouble(Math.Floor(Math.Round(Convert.ToDouble(data1.a[55]) / Convert.ToDouble(data1.a[56]) / 100 - 100, 2)));
                    PrevDlPr = Convert.ToDouble(Math.Round(100 - (Convert.ToDouble(XDate[19]) / Convert.ToDouble(data1.a[55]) * 100), 0));
                    PrevNar[18] = PrevDlPr;
                }
                if (Convert.ToDouble(data1.a[55]) - Convert.ToDouble(XDate[19].ToString()) <= 0)
                {
                    XDate[22] = "0";
                }
                ////////////////// Ширина превыш
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()) > 0)
                {
                    XDate[23] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()),2));
                }
                if (Convert.ToDouble(data1.a[58]) - Convert.ToDouble(XDate[20].ToString()) <= 0)
                {
                    XDate[23] = "0";
                }
                ///////////////// Высота превыш
                if (Convert.ToDouble(data1.a[60]) - Convert.ToDouble(XDate[21].ToString()) > 0)
                {
                    XDate[24] = Convert.ToString(Math.Round(Convert.ToDouble(data1.a[60]) - Convert.ToDouble(XDate[21].ToString()),2));
                }
                if (Convert.ToDouble(data1.a[60]) - Convert.ToDouble(XDate[21].ToString()) <= 0)
                {
                    XDate[24] = "0";
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
        //////public void ZOsPDK()
        //////{
        //////    try {
        //////        for (ic = 1; ic < KolOs + 1; ic++)
        //////        {
        //////            if (ic < 9)
        //////            {
        //////                MySqlCommand command2 = new MySqlCommand();
        //////                ConnectStr conStr2 = new ConnectStr();
        //////                conStr2.ConStr(1);
        //////                Zapros zapros2 = new Zapros();
        //////                string connectionString2;//, commandString;
        //////                connectionString2 = conStr2.StP;//"Data source=localhost;UserId=root;Password=1q2w3e$R;database=camloc;";
        //////                MySqlConnection connection2 = new MySqlConnection(connectionString2);
        //////                if (D[ic] > 0)
        //////                {
        //////                    if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] == 0)
        //////                    {
        //////                        zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));

        //////                    }
        //////                    else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic])
        //////                    {
        //////                        if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))
        //////                        {
        //////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
        //////                        }
        //////                        else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }

        //////                    }
        //////                    else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic] != 0)
        //////                    {
        //////                        if (D[ic] < 2.5)
        //////                        {
        //////                            if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic + 1]))
        //////                            {
        //////                                zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic + 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));
        //////                            }
        //////                            else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100)); }
        //////                        }
        //////                    }
        //////                    else if (Convert.ToInt32(TypO[ic]) == 1)
        //////                    {
        //////                        if (D[ic] == 2.5)
        //////                        {
        //////                            D[ic] = 2.51;
        //////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100));
        //////                            D[ic] = 2.5;
        //////                        }
        //////                        else
        //////                        { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic] * 100)); }

        //////                    }
        //////                }
        //////                else
        //////                {
        //////                    if (D[ic - 1] < 2.5)
        //////                    {
        //////                        if (Convert.ToInt32(DoubO[ic]) > Convert.ToInt32(DoubO[ic - 1]))
        //////                        {
        //////                            zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
        //////                        }
        //////                        else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }
        //////                    }
        //////                    else
        //////                    {
        //////                        zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100));
        //////                    }
        //////                }
        //////                string z2 = zapros2.commandStringTest;
        //////                command2.CommandText = z2;
        //////                command2.Connection = connection2;
        //////                MySqlDataReader reader2;
        //////                try
        //////                {
        //////                    command2.Connection.Open();
        //////                    reader2 = command2.ExecuteReader();
        //////                    while (reader2.Read())
        //////                    {
        //////                        PDKO[ic] = Convert.ToDouble(reader2["pdo"].ToString());
        //////                        PDKTel[ic] = Convert.ToDouble(reader2["pdt"].ToString());

        //////                    }
        //////                    reader2.Close();
        //////                }
        //////                catch (MySqlException ex)
        //////                {
        //////                    Console.WriteLine("Error: \r\n{0}", ex.ToString());
        //////                }
        //////                finally
        //////                {
        //////                    command2.Connection.Close();
        //////                }
        //////            }
        //////        }

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
                for (ic = 1; ic < KolOs + 1; ic++)
                {
                    if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic] && D[ic - 2] > D[ic - 1])
                    {
                        NagrTel = 0; // - общая масса группы 
                        for (int iTel = ic - 1; iTel < ic - 1 + TypO[ic]; iTel++)
                        { massGR[ic] = massGR[ic] + (BetOs[13, iTel - 1]/*- BetOs[13, iTel]/100*10*/); }
                    }

                }

                while (ig < KolGr + 1)
                {
                    if (D[ig] == 0)
                    { SRdist[ig] = 0; }
                    else
                    {
                        while ((D[io + 1] > 0 && D[io + 1] < 2.50) || io == 0)
                        {
                            if (io != 0)
                            {
                                SRdist[ig] = (SRdist[ig] + D[io]);
                                //massGR[ig] = massGR[ig] + BetOs[13, io];
                            }
                            io++;
                        }
                    }
                    SRdist[ig] = SRdist[ig] / (io - ipr);
                    ipr = io;
                    ig++;
                }
                ig = 0;
                io = 0;
                while (ig < KolGr + 1)
                {
                    while ((D[io + 1] > 0 && D[io + 1] < 2.50) || io == 0)
                    {
                        if (io != 0)
                        {
                            SRdistO[io] = SRdist[ig];
                        }
                        io++;
                    }
                    ig++;
                }

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
                            else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] <= D[ic] && D[ic] > 2.5)// если сдвоенная/строенная предидущее расстояние меньше настоящего (напр: 1+2... а это 3)
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
                                    zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic - 1]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); //(D[ic - 1] * 100));
                                }
                                else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (SrednRTel / (TypO[ic] - 1) * 100)); } //(D[ic - 1] * 100)); }
                                                                                                                                                              //////}
                                                                                                                                                              //////else { zapros2.PDOsNagr(Convert.ToInt32(DoubO[ic]), Convert.ToInt32(TypO[ic]), ADNagr, (D[ic - 1] * 100)); }

                            }
                            else if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic] != 0)// если сдвоенная/строенная предидущее расстояние больше настоящего (напр: 1+2... а это 2)
                            {

                                if (D[ic] < 2.5)
                                {
                                    if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic - 1] > D[ic - 2] && D[ic] != 0 && D[ic - 1] > 2.5)
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
                                    if (Convert.ToInt32(TypO[ic]) > 1 && D[ic - 1] > D[ic] && D[ic - 1] > D[ic - 2] && D[ic] != 0)
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
      
        #endregion///////////////////////////////////////////// 
       
        #endregion //////////////////////////
      
        public void UPDDannNarAndKl (string NNarush)
        {
            MySqlCommand command = new MySqlCommand();
            ConnectStr conStr = new ConnectStr();
            //Zapros zapros = new Zapros();
            conStr.ConStr(1);

            MySqlConnection connection = new MySqlConnection(conStr.StP);
           z = "UPDATE vehiclecontainer_r"
+ " SET IDKlassN = " + data1.a[2] + ", "
+ " KlNew = " + Convert.ToInt32(data1.a[2]) + ", "
+ " SubKateg = " + SubKKl + ""
+ " WHERE ID_wim = '" + IDpish + "'";
                     
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
    }
}

