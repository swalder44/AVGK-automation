using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using Ionic.Zip;


namespace AVGK
{
    public partial class Form2 : Form
    {
        public int FlStup; public decimal IDStup;
        public int CoZKR; public int CoZKL; public int CoZKROF;
        public int RC; public int RCR; public int RCL; public int RCRO;
        public Int64 NPicMon; public Int64 NPicKR; public Int64 NPicKL; public Int64 NPicKRO;
        public int ColPicMon; public int ColPicKR; public int ColPicKL; public int ColPicKRO;
        public int nM = 0; public int nKR = 0; public int nKl = 0; public int nKRO = 0;
        public int IDPDKO = 0;
        public TabPage PreviousTab;
        public TabPage CurrentTab;
        public Int64 IDpish;
        public Int64 IDW;
        public string PLN;
        public int ss;
        public int IDUB = 1;
        public Bitmap iimgg;
        public bool flag = false;
        int IDLF = 0;
        int IDRF = 0;
        Stream ms = null;
        Stream nz = null;
        Stream onz = null;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public static double widh;
        public static int location;
        public static int locOpisOs;
        public double[] l = new double[9];
        public string TSh;
        public string TSh11;
        public string TipoS;
        public string TipoS11;
        private string[] strus = new string[20];
        public string ChValid = "";
        public string PF = "";
        public string SP = "";
        public string MOb = "";
        public string fGRZ = "";
        public int IndFiltrLeft = 0;
        public int currentRowLeft;
        public int kol;
        public int kolR;
        public int kolRR;
        public int kol2;
        public int rowIndex = 0;
        public int rowIndexM = 0;
        public int rowIndexR = 0;
        public int rowIndex2 = 0;
        public string NUs;
        public int V = 0;

        public DataView dv;
        public int FM = 0;
        public DataSet DS = new DataSet(); public DataSet DSL = new DataSet(); public DataSet DSR = new DataSet();
        public DataSet DSAD = new DataSet(); public DataSet DSPDKO = new DataSet(); public DataSet DSPDK = new DataSet(); public DataSet DSMD = new DataSet(); public DataSet DSU = new DataSet();
        public DataSet DSKL = new DataSet(); public DataSet DSRUB = new DataSet(); public DataSet DSNAPR = new DataSet(); public DataSet DSNAR = new DataSet();
        public DataSet DSLO = new DataSet(); public DataSet DSSR = new DataSet(); public DataSet DSROF = new DataSet();
        public string NarOb;
        public string NarObMS;
        public double NarObM;
        public double NarObMPr;
        public string NarOs;
        public double NarOsM;
        public double NarGRM;
        public double NarOsMPr;
        public int KGr = 1;

        public int j;
        public int Fx;
        public string Sk;
        public int[,] KN = new int[2, 9];
        public int[,] KNR = new int[2, 9];
        public string[,] AxelDateKR = new string[4, 10];
        public double[,] PDK = new double[7, 10];
        public double[,] PDKGR = new double[7, 10];
        public double[] D = new double[10]; ///Группа из скольки колес
        public double[] DoubO = new double[10];///Двойные скаты на какой оси
        public double[] TypO = new double[10];///Тип оси
        public double[] PDKO = new double[10];///PDK оси
        public double[] PDKTel = new double[10];///пдк тележки
        public string[] A1 = new string[250];///Для акта
        public double[] D111 = new double[10];
        public double D1_2 = 0; public double D2_3 = 0;
        public double D3_4 = 0; public double D4_5 = 0;
        public double D5_6 = 0; public double D6_7 = 0;
        public double D7_8 = 0; public double ObshMass = 0;
        public int KolOs = 0;
        public int KolOsL = 0;
        public int KolOsR = 0;
        public int TTS = 0;
        public double ADNagr = 0;
        public double RasstOs = 0;
        public double DLINATS = 0;
        public int DO = 0;
        public int TypeO = 0;
        public string FFF;
        public string FF;
        public int COs;
        public int COsL;
        public int COsR; public int COsROF;
        public string D1; public string D2;
        public string D1L; public string D2L;
        public string D1R; public string D2R;
        public int Cl;
        public string WM;
        public string cstr; public string cstrL; public string cstrR; public string cstrAD; public string cstrMD; public string cstrOF;
        public string cstrU; public string cstrKL; public string cstrRUB; public string cstrNAPR; public string cstrNar;
        public string z; public string zL; public string zR; public string zM; public string zAD; public string zPDKO; public string zPDK; public string zLB;
        public string zMD; public string zU; public string zKL; public string zRUB; public string zNAPR; public string zSR; public string zNar; public string zROF;
        public int ic;
        public int icO;
        public int icC;
        public int GrO;
        public string Pl;
        public MySqlConnection connection;
        public MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection connectionL;
        public MySqlDataAdapter mySqlDataAdapterL;
        public MySqlConnection connectionR;
        public MySqlDataAdapter mySqlDataAdapterR;
        public MySqlConnection connectionAD;
        public MySqlDataAdapter mySqlDataAdapterAD;
        public MySqlDataAdapter mySqlDataAdapterPDKO;
        public MySqlDataAdapter mySqlDataAdapterPDK;
        public MySqlConnection connectionMD;
        public MySqlDataAdapter mySqlDataAdapterMD;
        public MySqlConnection connectionU;
        public MySqlDataAdapter mySqlDataAdapterU;
        public MySqlConnection connectionKL;
        public MySqlDataAdapter mySqlDataAdapterKL;
        public MySqlConnection connectionRUB;
        public MySqlDataAdapter mySqlDataAdapterRUB;
        public MySqlConnection connectionNAPR;
        public MySqlDataAdapter mySqlDataAdapterNAPR, mySqlDataAdapterSR;
        public MySqlConnection connectionNar;
        public MySqlDataAdapter mySqlDataAdapterNar;
        public MySqlConnection connectionROF;
        public MySqlDataAdapter mySqlDataAdapterROF;
        public string[] Us = new string[25];///User
        public Int32 ChNZ;
        public struct pictures
        {
            public byte pic1, pic2, pic3, pic4;
        }
        public pictures n1;
        public int iz = 1;
        private int us;
        private DataTable WD = new DataTable();

       
        public Form2()
        {
            InitializeComponent();
            SelfRef = this;
        }
      
        public Form2(int us)
        {
            this.us = us;
            InitializeComponent(); SelfRef = this;
          
             }

        private BindingSource bindingSorce = new BindingSource();

        public static Form2 SelfRef
        {
            get;
            set;
        }
        public object button1 { get; private set; }

        public void izobr()
        {
            if (iz == 0)
                return;
            else return;
        }

       
      
        private void Form2_Load(object sender, EventArgs e)
        {
           
                dateTimePicker10.Value = DateTime.Now;
            dateTimePicker9.Value = dateTimePicker10.Value.AddHours(-48);//.Value.AddSeconds(-2);//.AddDays(-2);//dateTimePicker8.Value.AddHours(-12);
            dateTimePicker5.Value = DateTime.Now;//Convert.ToDateTime("2018.04.13 11:50:00");
                dateTimePicker6.Value = DateTime.Now.AddHours(-1);
            timer2.Enabled = true;
                //ZMonitor();

        }
      
      
      

        private void toolStripLabel2_TextChanged(object sender, EventArgs e)
        {
            int Sum = 0;
            for (int i = 0; i < dataGridView9.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView9.Rows[i].Cells[10].Value) == true || Convert.ToBoolean(dataGridView9.Rows[i].Cells[11].Value) == true || Convert.ToBoolean(dataGridView9.Rows[i].Cells[12].Value) == true || Convert.ToBoolean(dataGridView9.Rows[i].Cells[13].Value) == true)
                {
                    Sum = Sum + 1;
                }
            }
            toolStripLabel4.Text = "" + (Convert.ToInt32(Sum)).ToString();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {

            if (FM == 0)
            {
                Button btn = sender as Button;
                btn.Text = "Отменить фильтр";
                FM = 1;
                checkBox11.Checked = false;
                timer2.Enabled = false;
                textBox11.Text = "70000";
                StopSearchM();
                //dataGridView9.Refresh();
            }
            else if (FM == 1)
            {
                Button btn = sender as Button;
                btn.Text = "Применить";
                checkBox11.Checked = true;
                FM = 0;
                textBox11.Text = "70000";
                timer2.Enabled = true;
                //dateTimePicker10.Value = Convert.ToDateTime("2018.09.16 5:36:00");//DateTime.Now;
                //dateTimePicker9.Value = Convert.ToDateTime("2018.09.16 5:35:00");//dateTimePicker10.Value.AddDays(-2);//.Value.AddSeconds(-2);//.AddDays(-2);//dateTimePicker8.Value.AddHours(-12);
                dateTimePicker10.Value = DateTime.Now;
                dateTimePicker9.Value = dateTimePicker10.Value.AddSeconds(-nM);
                rowIndex = 0;
                kol = 0;
            }

        }
        private void StopSearchM()  // Делаем фильтр и все ссылк к нему (до строки ////////////////////////)
        {
            dateTimePicker9.Value = dateTimePicker6.Value;//Convert.ToDateTime("28.04.2018 00:00:00");//
            dateTimePicker10.Value = dateTimePicker5.Value;//Convert.ToDateTime("28.04.2018 13:00:00");
            string TXTFLEFT = "";
            TXTFLEFT = "Created >= '" + dateTimePicker9.Value + "' and Created <= '" + dateTimePicker10.Value + "'";
         
            if (DS != null)
                DS.Clear();
            ZMonitor();
            DataView dvM;
            dvM = new DataView(DS.Tables[0], TXTFLEFT, "", DataViewRowState.CurrentRows);
            dataGridView9.DataSource = dvM;
            if (toolStripLabel2.Text != "")
            {
                kol = Convert.ToInt32(toolStripLabel2.Text);
            }
            if (dataGridView9.RowCount > 0)
            {
                rowIndex = dataGridView9.SelectedCells[0].RowIndex;
                if (kol > rowIndex)
                { kol = 0; }
                int Sum = 0;
                for (int i = 0; i < dataGridView9.Rows.Count; i++)
                {
                    Sum = Sum + 1;
                }
                if (Sum - kol < Sum)
                { kol = Sum - kol; }
                dataGridView9.CurrentCell = dataGridView9[0, rowIndex + kol];
                currentRowLeft = rowIndex + kol;
                toolStripLabel2.Text = "" + (Convert.ToInt32(Sum)).ToString();
                Otrisovka();
            }
            else
            {
                if (DS != null)
                    DS.Clear();
                ZMonitor();
                dvM = new DataView(DS.Tables[0], "(Created >= '" + dateTimePicker9.Value + "' and Created <= '" + dateTimePicker10.Value + "') ", "", DataViewRowState.CurrentRows);
                dataGridView9.DataSource = dvM;                
            }
        }
       


        private void timer2_Tick(object sender, EventArgs e)
        {
           
            if (DateTime.Now.ToString("HH") == "00" && Convert.ToInt32(DateTime.Now.ToString("mmss")) < 1005 && flag == false)
            {
                ChNZ = 0;
                flag = true;
            }

            if (DateTime.Now.ToString("HH") == "12" && Convert.ToInt32(DateTime.Now.ToString("mmss")) < 1005 && flag == false)
            {
                flag = false;
            }

            textBox11.Text = "700000";
            nM = nM + 6;
            dateTimePicker10.Value = DateTime.Now;
            dateTimePicker9.Value = dateTimePicker10.Value.AddHours(-48);//dateTimePicker10.Value.AddSeconds(-nM);//.AddDays(-2);//dateTimePicker8.Value.AddHours(-12);
            //dateTimePicker5.Value = DateTime.Now;//dateTimePicker10.Value;//Convert.ToDateTime("2018.04.13 11:50:00");
            //dateTimePicker6.Value = DateTime.Now;//dateTimePicker9.Value;//dateTimePicker5.Value.AddSeconds(-5); //dateTimePicker8.Value.AddHours(-12);
            if (dataGridView9.Rows.Count != 0)
            { RC = dataGridView9.CurrentCell.RowIndex; }
            if (DS != null)
                DS.Clear();
            ZMonitor();
            if (dataGridView9.Rows.Count != 0)
            {
                if (toolStripLabel2.Text != "")
                {
                    kol = Convert.ToInt32(toolStripLabel2.Text);
                }

                dataGridView9.CurrentCell = dataGridView9[0, RC];
                rowIndexM = dataGridView9.CurrentCell.RowIndex;
                if (kol > rowIndexM)
                { kol = 0; }
                dateTimePicker10.Value = DateTime.Now;//dateTimePicker10.Value.AddMinutes(+10);
                int SumM = 0;
                for (int i = 0; i < dataGridView9.Rows.Count; i++)
                {
                    SumM = SumM + 1;// (int)dataGridView8.Rows[i].Cells[0].Value;
                }
                if (SumM - kol < SumM)
                { kol = SumM - kol; }

                currentRowLeft = rowIndexM + kol;
                //DataView dvM;
                //dvM = new DataView(DS.Tables[0], "(Created >= '" + dateTimePicker9.Value + "' and Created <= '" + dateTimePicker10.Value + "')", "", DataViewRowState.CurrentRows);
                //dataGridView9.DataSource = dvM;
                dataGridView9.CurrentCell = dataGridView9[0, rowIndexM + kol];
                toolStripLabel2.Text = "" + (Convert.ToInt32(SumM)).ToString();
                if(DateTime.Now.ToString("HH") =="01" && Convert.ToInt32(DateTime.Now.ToString("mmss"))>0000 && Convert.ToInt32(DateTime.Now.ToString("mmss")) < 3059)
                {
                    ArchDann();
                }
                Otrisovka();
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
                ZMonitor();
        }

      
        public void Otrisovka()//раскраска ячеек В МОНИТОРЕ
        {

            foreach (DataGridViewRow row in dataGridView9.Rows) //цикл             
            {
                //     if (Convert.ToInt32(row.Cells[0].Value.ToString()) == 3861393 )
                //    {
                this.Cursor = Cursors.WaitCursor;
                AutoKlass aKl = new AutoKlass();
                aKl.LoadPDF(Convert.ToInt32(row.Cells[0].Value), NUs);
                //   }
            }
            if (DS != null)
                DS.Clear();
            ZMonitor();
            foreach (DataGridViewRow row in dataGridView9.Rows) //цикл     
            {
                    if ((Convert.ToBoolean(row.Cells[10].Value.ToString()) == true)|| (Convert.ToBoolean(row.Cells[11].Value.ToString()) == true)
                    || (Convert.ToBoolean(row.Cells[12].Value.ToString()) == true) || (Convert.ToBoolean(row.Cells[13].Value.ToString()) == true) 
                    || (Convert.ToBoolean(row.Cells[14].Value.ToString()) == true) || (Convert.ToBoolean(row.Cells[15].Value.ToString()) == true) /*&& Convert.ToInt32(row.Cells[0].Value.ToString()) == 3921091*/)//days > 9000)
                {
                    row.Cells[0].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[1].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[2].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[3].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[4].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[5].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[6].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[7].Style.BackColor = System.Drawing.Color.LightPink;
                    row.Cells[8].Style.BackColor = System.Drawing.Color.LightPink;

                    //////////////////////ChNZ = ChNZ + 1;
                    if (Convert.ToInt32(row.Cells[21].Value.ToString()) > 1 &&
                            (Convert.ToInt32(row.Cells[19].Value.ToString()) != 12) && (Convert.ToInt32(row.Cells[19].Value.ToString()) != 14) &&
                            (Convert.ToInt32(row.Cells[19].Value.ToString()) != 17) && (Convert.ToInt32(row.Cells[19].Value.ToString()) != 4) &&
                        (Convert.ToInt32(row.Cells[20].Value.ToString()) != 1) && (Convert.ToInt32(row.Cells[20].Value.ToString()) != 3) /*&& Convert.ToInt32(row.Cells[0].Value.ToString()) == 3937925*/)
                    {
                        ChNZ = ChNZ + 1;
                        AutoPDF aPDF = new AutoPDF();
                        aPDF.LoadPDF(Convert.ToInt32(row.Cells[0].Value), NUs, ChNZ);
                    }
                    else if (/*((Convert.ToInt32(row.Cells[16].Value.ToString()) == 4) || (Convert.ToInt32(row.Cells[16].Value.ToString()) != 12) || (Convert.ToInt32(row.Cells[16].Value.ToString()) != 14) ||*/
                                 //(Convert.ToInt32(row.Cells[16].Value.ToString()) != 17)) &&
                              /*(Convert.ToInt32(row.Cells[17].Value.ToString()) > 1) &&*/ (Convert.ToInt32(row.Cells[20].Value.ToString()) == 2)/*(Convert.ToInt32(row.Cells[20].Value.ToString()) == 3 || Convert.ToInt32(row.Cells[20].Value.ToString()) == 4) && Convert.ToInt32(row.Cells[0].Value.ToString()) == 3937925*/)
                    {
                        ChNZ = ChNZ + 1;
                        AutoPDF aPDF = new AutoPDF();
                        aPDF.LoadPDF(Convert.ToInt32(row.Cells[0].Value), NUs, ChNZ);
                    }
                }
  
                this.Cursor = Cursors.Default;

            }
        }

      
        public Image StrToImg(string StrImg)
        {
            byte[] arrayimg = Convert.FromBase64String(StrImg);
            Image imageStr = Image.FromStream(new MemoryStream(arrayimg));
            return imageStr;
        }

        public void ZMonitor()
        {
            int CoZ = Convert.ToInt32(textBox11.Text);
            ConnectStr conStrM = new ConnectStr();
            conStrM.ConStr(1);
            cstr = conStrM.StP;
            connection = new MySqlConnection(cstr);
            Zapros zapros1 = new Zapros();
            COs = KolOs;
            D1 = dateTimePicker9.Value.ToString("yyyy.MM.dd HH:mm:ss");
            D2 = dateTimePicker10.Value.ToString("yyyy.MM.dd HH:mm:ss");
            zapros1.ZaprLevKontr(0, D1, D2, CoZ);
            z = zapros1.commandStringTest;
            mySqlDataAdapter = new MySqlDataAdapter(z, connection);
            mySqlDataAdapter.Fill(DS);
            dataGridView9.DataSource = DS.Tables[0];
            dataGridView9.Columns[9].Visible = false;
            dataGridView9.Columns[10].Visible = false;
            dataGridView9.Columns[11].Visible = false;
            dataGridView9.Columns[12].Visible = false;
            dataGridView9.Columns[13].Visible = false;
            dataGridView9.Columns[14].Visible = false;
            dataGridView9.Columns[15].Visible = false;
            dataGridView9.Columns[16].Visible = false;
            dataGridView9.Columns[17].Visible = false;
            dataGridView9.Columns[18].Visible = false;
            dataGridView9.Columns[19].Visible = false;
            dataGridView9.Columns[20].Visible = false;
            dataGridView9.Columns[21].Visible = false;

            connection.Close();
        }
      
        public void ArchDann()
        {
            string NArchF = DateTime.Now.AddMonths(-2).ToString("dd_MM_yyyy");
            string NArchX = DateTime.Now.AddMonths(-1).ToString("yyyyMMdd");
            ZipFile zf = new ZipFile();
            zf.ProvisionalAlternateEncoding = Encoding.GetEncoding("cp866");
            zf.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zf.UseZip64WhenSaving = Zip64Option.AsNecessary;
            zf.AddDirectory(@"F:\\archivACT\\Photo\\" + NArchF.ToString());//Добавляем папку
            zf.Save(@"F:\\archivACT\\XML\\" + NArchF.ToString() + "F.zip"); //Сохраняем архив.
            Directory.Delete((@"F:\\archivACT\\Photo\\" + NArchF.ToString()), true);

            ZipFile zfX = new ZipFile();
            zfX.ProvisionalAlternateEncoding = Encoding.GetEncoding("cp866");
            zfX.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zfX.UseZip64WhenSaving = Zip64Option.AsNecessary;
            zfX.AddDirectory(@"F:\\archiv\\XML\\" + NArchX.ToString());//Добавляем папку
            zfX.Save(@"F:\\archivACT\\XML\\" + NArchX.ToString() + "X.zip"); //Сохраняем архив.
            Directory.Delete((@"F:\\archiv\\XML\\" + NArchX.ToString()), true);
        }
    }
    } 
