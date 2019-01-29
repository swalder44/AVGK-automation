using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PZone.Samples;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AVGK
{
    public class AKT_PDF
    {
        //Stream ii1 = null;
        public iTextSharp.text.Image imag;
        public iTextSharp.text.Image imag2;
        public iTextSharp.text.Image imag3;
        public iTextSharp.text.Image imag4;
        public iTextSharp.text.Image imag5;
        public iTextSharp.text.Image imag6;
        public iTextSharp.text.Image imag7;
        public string pf;
        public string[] Puti = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        string pdfFile;
       

        public void FormPDF(Bitmap i1, Bitmap i2, Bitmap i3, string[] args, string NRUB, string GAng, Bitmap i4, Bitmap i5, Bitmap i6, Bitmap i7)//public void FormPDF(System.IO.Stream i1, System.IO.Stream i2, System.IO.Stream i3, string[] args)
        {

            String dir = Environment.CurrentDirectory;//получаем текущую рабочую папку приложения
            String dir1 = Application.StartupPath;//получаем папку из которой произошел запуск приложения
            var pdfTemplate = @"" + dir1 + "\\AKT.pdf";
            pdfFile = @"F:\\archiv\\AKT\\" + GAng + ".pdf";//args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf"; 
            pf = GAng;//args[259] + "_" + DateTime.Now.ToString("ddMMyyyy");
            using (var templateReader = new PdfReader(pdfTemplate))
                
            {
                if (i1 != null)
                {
                    System.Drawing.Bitmap imgg = new System.Drawing.Bitmap(i1);
                    imag = iTextSharp.text.Image.GetInstance(imgg, System.Drawing.Imaging.ImageFormat.Png);
                    imgg.Save(@"F:\\archiv\\AKT\\" + GAng + "_1.Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + "_1.Jpg");
                }
                if (i2 != null)
                {
                    System.Drawing.Bitmap imgg2 = new System.Drawing.Bitmap(i2);
                    imag2 = iTextSharp.text.Image.GetInstance(imgg2, System.Drawing.Imaging.ImageFormat.Png);
                    imgg2.Save(@"F:\\archiv\\AKT\\" + GAng + "_grz.Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + "_grz.Jpg");
                }
                if (i3 != null)
                {
                    System.Drawing.Bitmap imgg3 = new System.Drawing.Bitmap(i3);
                    imag3 = iTextSharp.text.Image.GetInstance(imgg3, System.Drawing.Imaging.ImageFormat.Png);
                    imgg3.Save(@"F:\\archiv\\AKT\\" + GAng + ".Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + ".Jpg");
                }
                if (i4 != null)
                {
                    System.Drawing.Bitmap imgg4 = new System.Drawing.Bitmap(i4);
                    imag4 = iTextSharp.text.Image.GetInstance(imgg4, System.Drawing.Imaging.ImageFormat.Png);
                    imgg4.Save(@"F:\\archiv\\AKT\\" + GAng + "_2.Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + "_2.Jpg");
                }
                if (i5 != null)
                {
                    System.Drawing.Bitmap imgg5 = new System.Drawing.Bitmap(i5);
                    imag5 = iTextSharp.text.Image.GetInstance(imgg5, System.Drawing.Imaging.ImageFormat.Png);
                    imgg5.Save(@"F:\\archiv\\AKT\\" + GAng + "_3.Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + "_2.Jpg");
                }
                if (i6 != null)
                {
                    System.Drawing.Bitmap imgg6 = new System.Drawing.Bitmap(i6);
                    imag6 = iTextSharp.text.Image.GetInstance(imgg6, System.Drawing.Imaging.ImageFormat.Png);
                    imgg6.Save(@"F:\\archiv\\AKT\\" + GAng + "_4.Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + "_2.Jpg");
                }
                if (i7 != null)
                {
                    System.Drawing.Bitmap imgg7 = new System.Drawing.Bitmap(i7);
                    imag7 = iTextSharp.text.Image.GetInstance(imgg7, System.Drawing.Imaging.ImageFormat.Png);
                    imgg7.Save(@"F:\\archiv\\AKT\\" + GAng + "_5.Jpg"); //" + args[259] + "_" + DateTime.Now.ToString("ddMMyyyy") + "_2.Jpg");
                }
                using (var resultStamper = new PdfStamper(templateReader, new FileStream(pdfFile, FileMode.Create)))
                {
                    var pdfcontentbyte = resultStamper.GetOverContent(2);
                    if (i1 != null)
                    {
                        imag.SetAbsolutePosition(55, 695);
                        imag.ScaleAbsoluteWidth(127);
                        imag.ScaleAbsoluteHeight(90);
                        imag.Alignment = Element.ALIGN_CENTER;
                        pdfcontentbyte.AddImage(imag);
                    }
                    if (i2 != null)
                    {
                        imag2.SetAbsolutePosition(230, 745);
                        imag2.ScaleAbsoluteWidth(137);
                        imag2.ScaleAbsoluteHeight(40);
                        imag2.Alignment = Element.ALIGN_CENTER;
                        pdfcontentbyte.AddImage(imag2);
                    }
                    if (i3 != null)
                    {
                        imag3.SetAbsolutePosition(404, 696);
                        imag3.ScaleAbsoluteWidth(146);
                        imag3.ScaleAbsoluteHeight(89);
                        imag3.Alignment = Element.ALIGN_CENTER;
                        pdfcontentbyte.AddImage(imag3);
                    }
                    // Получаем ссылку на форму с полями.
                    var form = resultStamper.AcroFields;
                    // Получаем все шрифты формы.
                    //BaseFont baseFont = BaseFont.CreateFont(@"C:\Users\cherednikov\Desktop\WFPDF\WFPDF\calibri.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    var font = templateReader.GetFormFonts();

                    // Установка значений полей формы.
                    // Установка значений полей формы.
                    form.SetFieldWithFont(templateReader, font, "NAkt", args[0]);
                    form.SetFieldWithFont(templateReader, font, "DAkt", args[1]); form.SetFieldWithFont(templateReader, font, "TAkt", args[2]);
                    form.SetFieldWithFont(templateReader, font, "NPrAkt", args[3]); form.SetFieldWithFont(templateReader, font, "NamKompl", args[4]);
                    form.SetField("A1", args[5]); form.SetField("A2", args[6]); form.SetField("A3", args[7]); form.SetField("A4", args[8]); form.SetField("A5", args[9]);
                    form.SetField("A6", args[10]); form.SetField("A7", args[11]); form.SetField("A8", args[12]); form.SetField("A9", args[13]); form.SetField("A10", args[14]);
                    form.SetField("A11", args[15]); form.SetField("A12", args[16]); form.SetField("A13", args[17]); form.SetField("A14", args[18]); form.SetField("A15", args[19]);
                    form.SetField("A16", args[20]); form.SetField("A17", args[21]); form.SetField("A18", args[22]); form.SetField("A19", args[23]); form.SetField("A20", args[24]);
                    form.SetField("A21", args[25]); form.SetField("A22", args[26]); form.SetField("A23", args[27]); form.SetField("A24", args[28]); form.SetField("A25", args[29]);
                    form.SetField("A26", args[30]); form.SetField("A27", args[31]); form.SetField("A28", args[32]); form.SetField("A29", args[33]); form.SetField("A30", args[34]);
                    form.SetField("A31", args[35]); form.SetField("A32", args[36]); form.SetField("A33", args[37]); form.SetField("A34", args[38]); form.SetField("A35", args[39]);
                    form.SetField("A214", args[218]); form.SetField("A225", args[229]);
                    form.SetField("A36", args[40]); form.SetField("A37", args[41]); form.SetField("A38", args[42]); form.SetField("A39", args[43]); form.SetField("A40", args[44]);
                    form.SetField("A41", args[45]); form.SetField("A42", args[46]); form.SetField("A43", args[47]); form.SetField("A44", args[48]); form.SetField("A45", args[49]);
                    form.SetField("A46", args[50]); form.SetField("A47", args[51]); form.SetField("A48", args[52]); form.SetField("A49", args[53]); form.SetField("A50", args[54]);
                    form.SetField("A51", args[55]); form.SetField("A52", args[56]); form.SetField("A53", args[57]); form.SetField("A54", args[58]); form.SetField("A55", args[59]);
                    form.SetField("A56", args[60]); form.SetField("A57", args[61]); form.SetField("A58", args[62]); form.SetField("A59", args[63]); form.SetField("A60", args[64]);
                    form.SetField("A61", args[65]); form.SetField("A62", args[66]); form.SetField("A63", args[67]); form.SetField("A64", args[68]); form.SetField("A65", args[69]);
                    form.SetField("A66", args[70]); form.SetField("A67", args[71]); form.SetField("A68", args[72]); form.SetField("A69", args[73]); form.SetField("A70", args[74]);
                    form.SetField("A71", args[75]); form.SetField("A72", args[76]); form.SetField("A73", args[77]); form.SetField("A74", args[78]); form.SetField("A75", args[79]);
                    form.SetField("A76", args[80]); form.SetField("A77", args[81]); form.SetField("A78", args[82]); form.SetField("A79", args[83]); form.SetField("A80", args[84]);
                    form.SetField("A81", args[85]); form.SetField("A82", args[86]); form.SetField("A83", args[87]); form.SetField("A84", args[88]); form.SetField("A85", args[89]);
                    form.SetField("A86", args[90]); form.SetField("A87", args[91]); form.SetField("A88", args[92]); form.SetField("A89", args[93]); form.SetField("A90", args[94]);
                    form.SetField("A91", args[95]); form.SetField("A92", args[96]); form.SetField("A93", args[97]); form.SetField("A94", args[98]); form.SetField("A95", args[99]);
                    form.SetField("A96", args[100]); form.SetField("A97", args[101]); form.SetField("A98", args[102]); form.SetField("A99", args[103]); form.SetField("A100", args[104]);
                    form.SetField("A101", args[105]); form.SetField("A102", args[106]); form.SetField("A103", args[107]); form.SetField("A104", args[108]); form.SetField("A105", args[109]);
                    form.SetField("A106", args[110]); form.SetField("A107", args[111]); form.SetField("A108", args[112]); form.SetField("A109", args[113]); form.SetField("A110", args[114]);
                    form.SetField("A111", args[115]); form.SetField("A112", args[116]); form.SetField("A113", args[117]); form.SetField("A114", args[118]); form.SetField("A115", args[119]);
                    form.SetField("A116", args[120]); form.SetField("A117", args[121]); form.SetField("A118", args[122]); form.SetField("A119", args[123]); form.SetField("A120", args[124]);
                    form.SetField("A121", args[125]); form.SetField("A122", args[126]); form.SetField("A123", args[127]); form.SetField("A124", args[128]); form.SetField("A125", args[129]);
                    form.SetField("A126", args[130]); form.SetField("A127", args[131]); form.SetField("A128", args[132]); form.SetField("A129", args[133]); form.SetField("A130", args[134]);
                    form.SetField("A131", args[135]); form.SetField("A132", args[136]); form.SetField("A133", args[137]); form.SetField("A134", args[138]); form.SetField("A135", args[139]);
                    form.SetField("A136", args[140]); form.SetField("A137", args[141]); form.SetField("A138", args[142]); form.SetField("A139", args[143]); form.SetField("A140", args[144]);
                    form.SetField("A141", args[145]); form.SetField("A142", args[146]); form.SetField("A143", args[147]); form.SetField("A144", args[148]); form.SetField("A145", args[149]);
                    form.SetField("A146", args[150]); form.SetField("A147", args[151]); form.SetField("A148", args[152]); form.SetField("A149", args[153]); form.SetField("A150", args[154]);
                    form.SetField("A151", args[155]); form.SetField("A152", args[156]); form.SetField("A153", args[157]); form.SetField("A154", args[158]); form.SetField("A155", args[159]);
                    form.SetField("A156", args[160]); form.SetField("A157", args[161]); form.SetField("A158", args[162]); form.SetField("A159", args[163]); form.SetField("A160", args[164]);
                    form.SetField("A161", args[165]); form.SetField("A162", args[166]); form.SetField("A163", args[167]); form.SetField("A164", args[168]); form.SetField("A165", args[169]);
                    form.SetField("A166", args[170]); form.SetField("A167", args[171]); form.SetField("A168", args[172]); form.SetField("A169", args[173]); form.SetField("A170", args[174]);
                    form.SetField("A171", args[175]); form.SetField("A172", args[176]); form.SetField("A173", args[177]); form.SetField("A174", args[178]); form.SetField("A175", args[179]);
                    form.SetField("A176", args[180]); form.SetField("A177", args[181]); form.SetField("A178", args[182]); form.SetField("A179", args[183]); form.SetField("A180", args[184]);
                    form.SetField("A181", args[185]); form.SetField("A182", args[186]); form.SetField("A183", args[187]); form.SetField("A184", args[188]); form.SetField("A185", args[189]);
                    form.SetField("A186", args[190]); form.SetField("A187", args[191]); form.SetField("A188", args[192]); form.SetField("A189", args[193]); form.SetField("A190", args[194]);
                    form.SetField("A191", args[195]); form.SetField("A192", args[196]); form.SetField("A193", args[197]); form.SetField("A194", args[198]); form.SetField("A195", args[199]);
                    form.SetField("A196", args[200]); form.SetField("A197", args[201]); form.SetField("A198", args[202]); form.SetField("A199", args[203]); form.SetField("A200", args[204]);
                    form.SetField("A201", args[205]); form.SetField("A202", args[206]); form.SetField("A203", args[207]); form.SetField("A204", args[208]); form.SetField("A205", args[209]);
                    form.SetField("A206", args[210]); form.SetField("A207", args[211]); form.SetField("A208", args[212]); form.SetField("A209", args[213]); form.SetField("A210", args[214]);
                    form.SetField("A211", args[215]); form.SetField("A212", args[216]); form.SetField("A213", args[217]); /*form.SetField("A214", args[218]);*/ form.SetField("A215", args[219]);
                    form.SetField("A216", args[220]); form.SetField("A217", args[221]); form.SetField("A218", args[222]); form.SetField("A219", args[223]); form.SetField("A220", args[224]);
                    form.SetField("A221", args[225]); form.SetField("A222", args[226]); form.SetField("A223", args[227]); form.SetField("A224", args[228]); /*form.SetField("A225", args[229]);*/
                    form.SetField("A226", args[230]); form.SetField("A227", args[231]); form.SetField("A228", args[232]); form.SetField("A229", args[233]); form.SetField("A230", args[234]);
                    form.SetField("A231", args[235]); form.SetField("A232", args[236]); form.SetField("A233", args[237]); form.SetField("A234", args[238]); form.SetField("A235", args[239]);
                    form.SetField("A236", args[240]); form.SetField("A237", args[241]); form.SetField("A238", args[242]); form.SetField("A239", args[243]); form.SetField("A240", args[244]);
                    form.SetField("A241", args[245]); form.SetField("A242", args[246]); form.SetField("A243", args[247]); form.SetField("A244", args[248]); form.SetField("A245", args[249]);
                    form.SetField("A246", args[250]); 
                    // Установка запрета на редактирование полей.
                    resultStamper.FormFlattening = true;

                    resultStamper.Close();
                }
                templateReader.Close();
            }
            
            //    File.Delete(@"F:\\archivACT\\act\\" + pf + ".pdf");
            //File.Copy(@"F:\\archiv\\AKT\\" + pf + ".pdf", @"F:\\archivACT\\act\\" + pf + ".pdf");
        }
    }
    }
