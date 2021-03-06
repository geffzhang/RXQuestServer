﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using IronOcr;
using NPOI;
using NPOI.Util;
using NPOI.XWPF;
using NPOI.XWPF.UserModel;
using NPOI.OpenXmlFormats.Wordprocessing;
using System.IO;
using System.Web;
using Baidu.Aip.Ocr;
using WindowsAPI_Interface;
using NPOI.SS.Formula.Functions;

namespace OcrCenter
{
    public partial class OCR : Form
    {
        XWPFDocument Globaldoc = new XWPFDocument();
        public OCR()
        {
            InitializeComponent();
            timer.Enabled = true;
            this.TopMost = true;
            CheckNetWork checkNet = new CheckNetWork();
            if (checkNet.IsConnectNetwork())
            {
                ByBaiduEngner.Checked = true;
                ByInnerEngner.Checked = false;
            }
            else
            {
                ByBaiduEngner.Checked = false;
                ByInnerEngner.Checked = true;
            }
        }
        private void ReadTarget_Click(object sender, EventArgs e)
        {
            if (!ByBaiduEngner.Checked && !ByInnerEngner.Checked)
            {
                MessageBox.Show("未选中任意OCR引擎，无法执行当前操作！");
                return;
            }
            FilePath.Text = string.Empty;
            ResultTest.Text = string.Empty;
            PBOCR.Value = 0;
            PBOCR.Step = 1;
            System.Threading.Thread importThread = new System.Threading.Thread(new ThreadStart(GetFileDocument));
            importThread.SetApartmentState(ApartmentState.STA); //重点
            importThread.Start();
            PBOCR.Value = 10;
        }
        private void GetFileDocument()
        {
            if (string.IsNullOrEmpty(FilePath.Text))
            {
                CheckForIllegalCrossThreadCalls = false;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "图片 文件(*.BMP;*.JPG;*.GIF;PNG)|*.BMP;*.JPG;*.GIF;*PNG|PDF文件(*.PDF)|*.PDF|All files (*.*)|*.*";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//获取桌面位置
                var result = openFileDialog.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        FilePath.Text = openFileDialog.FileName;
                        PBOCR.Value = 20;
                        if (ByBaiduEngner.Checked)
                        {
                            TranslateFileBaiduEngener();
                        }
                        else if (ByInnerEngner.Checked)
                        {
                            TranslateFileInnerEngener();
                        }
                        else
                        {
                            ResultTest.Text = "读取失败！你未选中任何OCR引擎，无法执行分析！";
                        }
                        break;
                    default:
                        ResultTest.Text = "读取失败！你已放弃文件选择！";
                        break;
                }
            }
            else
            {
                PBOCR.Value = 20;
                if (ByBaiduEngner.Checked)
                {
                    TranslateFileBaiduEngener();
                }
                else if (ByInnerEngner.Checked)
                {
                    TranslateFileInnerEngener();
                }
                else
                {
                    ResultTest.Text = "读取失败！你未选中任何OCR引擎，无法执行分析！";
                }
            }

            PBOCR.Value = 100;
        }
        private void TranslateFileBaiduEngener()
        {
            this.TopMost = false;
            string file = FilePath.Text; // ☜ jpg, gif, tif, pdf, etc.
            string api_key = null, secret_key = null;
            api_key = Properties.Resources.apikey;
            secret_key = Properties.Resources.SecretKey;
            PBOCR.Value = 30;
            try
            {
                var client = new Ocr(api_key, secret_key);
                client.Timeout = 10000;
                var image = File.ReadAllBytes(file);
                var result = client.GeneralBasic(image).ToString();
                PBOCR.Value = 90;
                ResultTest.Text = TranslateBaiduResult(result);
            }
            catch (Exception)
            {
                ResultTest.Text = "链接超时！本程序采用百度OCR引擎，需要联网应用，请检查网络是否正常！";
            }
            PBOCR.Value = 100;
        }
        private void TranslateFileInnerEngener()
        {
            string file = FilePath.Text; // ☜ jpg, gif, tif, pdf, etc.
            PBOCR.Value = 30;
            //var Ocr = new IronOcr.AdvancedOcr();
            try
            {
                //Ocr.CleanBackgroundNoise = true;
                //Ocr.EnhanceContrast = true;
                //Ocr.EnhanceResolution = true;
                //Ocr.Language = IronOcr.o OcrLanguagePack(
                //    Languages.ChineseSimplified.OcrLanguagePack,
                //    Languages.English.OcrLanguagePack
                //);
                //PBOCR.Value = 40;
                //Ocr.Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced;
                //Ocr.ColorSpace = AdvancedOcr.OcrColorSpace.Color;
                //Ocr.DetectWhiteTextOnDarkBackgrounds = true;
                //Ocr.InputImageType = AdvancedOcr.InputTypes.AutoDetect;
                //Ocr.RotateAndStraighten = true;
                //Ocr.ReadBarCodes = true;
                //Ocr.ColorDepth = 4;
                //var testDocument = file;
                //PBOCR.Value = 45;
                //var Results = Ocr.Read(testDocument);
                //PBOCR.Value = 80;
                //ResultTest.Text = Results.Text;
                //PBOCR.Value = 90;
                var Ocr = new IronTesseract();
                using (var Input = new OcrInput(file))
                {
                    Ocr.Language = OcrLanguage.EnglishBest;
                    //Ocr.AddSecondaryLanguage(OcrLanguage.ChineseSimplified);
                    // Input.Deskew();  // use if image not straight
                    //Input.DeNoise(); // use if image contains digital noise
                    var Result = Ocr.Read(Input);
                    //Console.WriteLine(Result.Text);
                    ResultTest.Text = Result.Text;
                }
            }
            catch (Exception)
            {
                ResultTest.Text = "本地引擎在分析是出错，请联系管理员！";
            }
            PBOCR.Value = 100;
        }
        private void OCR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            System.Environment.Exit(0);
        }
        private void savetoword_Click(object sender, EventArgs e)
        {
            PBOCR.Value = 0;
            if (Globaldoc==null)
            {
                return;
            }
            //XWPFDocument doc = new XWPFDocument();
            //string[] Plist = ResultTest.Text.Split(Environment.NewLine.ToCharArray());
            //Plist = Plist.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            //for (int i = 0; i < Plist.Length; i++)
            //{
            //    if (!Plist[i].Contains("words") || Plist[i].Contains("words_result_num") || Plist[i].Contains("words_result"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        string value = Plist[i];
            //        value = value.Replace("words", "").Replace("''", "").Replace(":", "");
            //    }
            //    XWPFParagraph P1 = doc.CreateParagraph();
            //    P1.Alignment = ParagraphAlignment.LEFT;
            //    XWPFRun P1Text = P1.CreateRun();
            //    P1Text.SetText(Plist[i]);
            //}
            PBOCR.Value = 50;
            string Path = "C:\\Users\\Administrator\\Desktop\\瑞祥OCR转译系统_" + System.DateTime.Now.ToString("yyyymmddHHmmssffff") + ".doc";
            FileStream newfile = new FileStream(Path, FileMode.Create);
            Globaldoc.Write(newfile);
            newfile.Close();
            PBOCR.Value = 100;
        }
        private string TranslateBaiduResult(string ResultTest)
        {
            if (string.IsNullOrEmpty(ResultTest))
            {
                return null;
            }
            string ResultStr = string.Empty;
            XWPFDocument doc = new XWPFDocument();
            string[] Plist = ResultTest.Split(Environment.NewLine.ToCharArray());
            Plist = Plist.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            string value = string.Empty;
            for (int i = 0; i < Plist.Length; i++)
            {
                if (!Plist[i].Contains("words") || Plist[i].Contains("words_result_num") || Plist[i].Contains("words_result"))
                {
                    continue;
                }
                else
                {
                    value = Plist[i];
                    value = value.Replace("words", "").Replace("\"", "").Replace(":", "");
                    value = value.Replace("\"words\": \"", "").Trim();
                }
                XWPFParagraph P1 = doc.CreateParagraph();
                P1.Alignment = ParagraphAlignment.LEFT;
                XWPFRun P1Text = P1.CreateRun();
                P1Text.SetText(value);
            }
            Globaldoc = doc;
            foreach (XWPFParagraph xWPF in doc.Paragraphs)
            {
                ResultStr += xWPF.Text;
                ResultStr += "\r\n";
            }
            return ResultStr;
        }
        private void GetScreenOprator_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetScreen _GetScreen = new GetScreen();
            _GetScreen.GetWholeScreen(this);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = "Rx_OCR_System_本技术由瑞祥工业数字化_叶朝成提供|SystemTime:" + DateTime.Now;
        }
        public void TranslateOCRByScreenImage(string ImagePath)
        {
            CheckForIllegalCrossThreadCalls = false;
            FilePath.Text = ImagePath;
            GetFileDocument();
        }
    }
}
