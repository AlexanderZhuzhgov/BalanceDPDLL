using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceDP
{
    public partial class frmMain : Form
    {
        BalanceDPDll.MathLib bdp = new BalanceDPDll.MathLib();

        private string strTempCancel;   // строковая переменная для хранения временного значения

        private const string strMsgErrCaption = "Ошибка";
        private const string strMsgErrAttention = "Внимание!" + "\n";
        private const string strMsgErrAttentionNull = "Поле не должно оставаться пустым." + "\n";
        private const string strMsgErrRepeat = "Повторите ввод!";
        private const string _strErrorLog = "errorLog.txt";  // файл для протоколирования ошибок


        // Создать объект для формирования отчета
        public OTCHET frmRpt;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                BalanceDPDll.MathLib bdpp = new BalanceDPDll.MathLib();
                this.bdp = bdpp.LoadData(fileDefaultUserAppDataPath.ToString());
            }
            else  // если файла нет, то сформировать его и сериализовать в указанный каталог для последующего вызова
            {
                #region -- Загрузка первоначальных значений
                bdp.SoderjElementinChugunSi = 0.53;
                bdp.SoderjElementinChugunMn = 0.19;
                bdp.SoderjElementinChugunS = 0.014;
                bdp.SoderjElementinChugunP = 0.043;
                bdp.SoderjElementinChugunTi = 0.068;
                bdp.SoderjElementinChugunCr = 0.021;
                bdp.SoderjElementinChugunV = 0.0;
                bdp.SoderjElementinChugunC = 5.13;
                bdp.TmpChugun = 1405;
                bdp.TeploEmkChugun = 0.9;
                bdp.StepenPryamVosstanov = 0.35;
                bdp.UdelnRashodKoksa = 420;
                bdp.SeraKoksa = 0.5;
                bdp.ZolaKoksa = 11.9;
                bdp.LetuchKoksa = 0.6;
                bdp.VlagaKoksa = 4.2;
                bdp.TempGorDutia = 1140;
                bdp.SodKislorodinDutia = 24.1;
                bdp.VlajnostiDutia = 6.36;
                bdp.UdelnRashodPrirodGaza = 115;
                bdp.SostavCH4 =100;
                bdp.SostavC2H6 =0;
                bdp.SostavCO2 =0;
                bdp.SoderjCinPrirodGaza = 1;
                bdp.SoderjH2inPrirodGaza = 2;
                bdp.UdelnRaschIzvest = 0;
                bdp.SoderjVlagiIzvest = 0;
                bdp.PoteryaMasPriProkal = 42;
                bdp.UdelnVychodShlaka = 260;
                bdp.SoderjSinShlak = 1.03;
                bdp.TeploemkostShlaka = 1.26;
                bdp.TempKoloshnikGAz = 328;
                bdp.SoderjCO2KoloshGaz = 17.5;
                bdp.SoderjCOKoloshGaz = 24.1;
                bdp.SoderjN2KoloshGaz = 7;
                bdp.SoderjH2KoloshGaz = 51.4;
                bdp.UdelnyJRM = 1713;
                bdp.UdelnyRaschodMetalldobavok = 0;
                bdp.SoderjVlagiinJRM = 0;


                #endregion -- Загрузка первоначальных значений

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                bdp.SaveData(bdp, fileDefaultUserAppDataPath.ToString());
            }

            txtSoderjElementinChugunSi.Text = bdp.SoderjElementinChugunSi.ToString();
            txtSoderjElementinChugunMn.Text = bdp.SoderjElementinChugunMn.ToString();
            txtSoderjElementinChugunS.Text = bdp.SoderjElementinChugunS.ToString();
            txtSoderjElementinChugunP.Text = bdp.SoderjElementinChugunP.ToString();
            txtSoderjElementinChugunTi.Text = bdp.SoderjElementinChugunTi.ToString();
            txtSoderjElementinChugunCr.Text = bdp.SoderjElementinChugunCr.ToString();
            txtSoderjElementinChugunV.Text = bdp.SoderjElementinChugunV.ToString();
            txtSoderjElementinChugunC.Text = bdp.SoderjElementinChugunC.ToString();
            txtTmpChugun.Text = bdp.TmpChugun.ToString();
            txtTeploEmkChugun.Text = bdp.TeploEmkChugun.ToString();
            txtStepenPryamVosstanov.Text = bdp.StepenPryamVosstanov.ToString();
            txtUdelnRashodKoksa.Text = bdp.UdelnRashodKoksa.ToString();
            txtSeraKoksa.Text = bdp.SeraKoksa.ToString();
            txtLetuchKoksa.Text = bdp.LetuchKoksa.ToString();
            txtVlagaKoksa.Text = bdp.VlagaKoksa.ToString();
            txtTempGorDutia.Text = bdp.TempGorDutia.ToString();
            txtSodKislorodinDutia.Text = bdp.SodKislorodinDutia.ToString();
            txtVlajnostiDutia.Text = bdp.VlajnostiDutia.ToString();
            txtUdelnRashodPrirodGaza.Text = bdp.UdelnRashodPrirodGaza.ToString();
            txtSostavCH4.Text = bdp.SostavCH4.ToString();
            txtSostavC2H6.Text = bdp.SostavC2H6.ToString();
            txtSostavCO2.Text = bdp.SostavCO2.ToString();
            txtSoderjCinPrirodGaza.Text = bdp.SoderjCinPrirodGaza.ToString();
            txtSoderjH2inPrirodGaza.Text = bdp.SoderjH2inPrirodGaza.ToString();
            txtUdelnRaschIzvest.Text = bdp.UdelnRaschIzvest.ToString();
            txtSoderjVlagiIzvest.Text = bdp.SoderjVlagiIzvest.ToString();
            txtPoteryaMasPriProkal.Text = bdp.PoteryaMasPriProkal.ToString();
            txtUdelnVychodShlaka.Text = bdp.UdelnVychodShlaka.ToString();
            txtSoderjSinShlak.Text = bdp.SoderjSinShlak.ToString();
            txtTeploemkostShlaka.Text = bdp.TeploemkostShlaka.ToString();////
            txtTempKoloshnikGAz.Text = bdp.TempKoloshnikGAz.ToString();
            txtSoderjCO2KoloshGaz.Text = bdp.SoderjCO2KoloshGaz.ToString();
            txtSoderjCOKoloshGaz.Text = bdp.SoderjCOKoloshGaz.ToString();
            txtSoderjN2KoloshGaz.Text = bdp.SoderjN2KoloshGaz.ToString();
            txtSoderjH2KoloshGaz.Text = bdp.SoderjH2KoloshGaz.ToString();
            txtUdelnyJRM.Text = bdp.UdelnyJRM.ToString();
            txtUdelnyRaschodMetalldobavok.Text = bdp.UdelnyRaschodMetalldobavok.ToString();
            txtSoderjVlagiinJRM.Text = bdp.SoderjVlagiinJRM.ToString();
            
        }
   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramExit();
        }



        /// <summary>
        /// Корректно завершить программу
        /// </summary>  
        private void ProgramExit()
        {
            ReadInputDataFromForm();
            
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");
            // Сохранить параметры доступа к базе данных на диск для последующего вызова
            bdp.SaveData(bdp, fileDefaultUserAppDataPath.ToString());

            //string path = Application.UserAppDataPath.ToString();

            //// Сохранить данные объекта на диск для последующего вызова
            //s.SaveData(s, path + @"\\default.xml");

            //#region -- сохранить параметры отчета в файле: исходные данные в отчет
            //XmlSerializer xmls = new XmlSerializer(typeof(List<NumberSum.Param>));
            //FileStream fs = null;
            //try
            //{
            //    fs = new FileStream("cfgInputToRep.xml", FileMode.Create);
            //    xmls.Serialize(fs, _allParamsInput);
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    if (fs != null) fs.Close();
            //}
            //#endregion

            //#region -- сохранить параметры отчета в файле: результаты в отчет
            //XmlSerializer xmlsOut = new XmlSerializer(typeof(List<NumberSum.Param>));
            //FileStream fsOut = null;
            //try
            //{
            //    fsOut = new FileStream("cfgOutputToRep.xml", FileMode.Create);
            //    xmlsOut.Serialize(fsOut, _allParamsOutput);
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    if (fsOut != null) fsOut.Close();
            //}
            //#endregion

            Application.Exit();
        }

        #region -- что-то странное
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoderjElementinChugunSi_TextChanged(object sender, EventArgs e)
        {
            txtSoderjElementinChugunSi.Enabled = true;
        }

        private void txtSoderjElementinChugunMn_TextChanged(object sender, EventArgs e)
        {
            txtSoderjElementinChugunMn.Enabled = true;
        }

        private void txtSoderjElementinChugunS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoderjElementinChugunP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoderjElementinChugunTi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoderjElementinChugunCr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoderjElementinChugunV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoderjElementinChugunC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTmpChugun_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramExit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void пвапв_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnRezult_Click(object sender, EventArgs e)
        {
        #endregion -- что-то странное

            ReadInputDataFromForm();

            #region -- Промежуточные данные

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Содержание Fe в чугуне", "[Fe]", Math.Round(bdp.get_Fe(),4), "%");
            dataGridView1.Rows.Add("Расход С на прямое восстановление Fe", "Спр=", Math.Round(bdp.get_Спр(),4), "кг/т чугуна");
            dataGridView1.Rows.Add("Расход С на прямое восстановление примесей чугуна: Mn,P,Si,S,V,Ti,Cr", "Сприм=",Math.Round(bdp.get_Сприм(), 4), "кг/т");
            dataGridView1.Rows.Add("Количество нелетучих элементов в коксе", "Снел", Math.Round(bdp.get_Снел(), 4), "%");
            dataGridView1.Rows.Add("Количество углерода (С), пришедшего в печь с коксом", "Сприш=", Math.Round(bdp.get_Сприш(), 4), "кг/т");
            dataGridView1.Rows.Add("Расход С на образование метана", "CСН4=", Math.Round(bdp.get_CСН4(), 4), "кг/т чугуна");
            dataGridView1.Rows.Add("Растворяется углерода в чугуне", "Сч=", Math.Round(bdp.get_Сч(), 4), "кг/т чугуна");
            dataGridView1.Rows.Add("Количество С, сгорающего у фурм", "Сф=", Math.Round(bdp.get_Сф(), 4), "кг/т чугуна");
            dataGridView1.Rows.Add("Расход сухого дутья на 1 кг С кокса", "Vд'=", Math.Round(bdp.get_VдC(), 4), "м3/кг Сф");
            dataGridView1.Rows.Add("Расход сухого дутья для конверсии 1 м3 природного газа", "Vд''=", Math.Round(bdp.get_VдPG(), 4), "м3/м3");
            dataGridView1.Rows.Add("Расход природного газа в расчете на 1 кг углерода кокса, сгорающего у фурм", "0", Math.Round(bdp.get_VдXX(), 4), "м3/кг Сф");
            dataGridView1.Rows.Add("Суммарный расход сухого дутья", "Vд=", Math.Round(bdp.get_Vд(), 4), "м3/кг Сф");
            dataGridView1.Rows.Add("Расчетный удельный расход дутья ", "Qд=", Math.Round(bdp.get_Qд(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Состав фурменного (горнового) газа: CO", "Vсо", Math.Round(bdp.get_Vсо(), 4), "м3/кг Сф");
            dataGridView1.Rows.Add("Состав фурменного (горнового) газа: H2", "VН2=", Math.Round(bdp.get_VН2(), 4), "м3/кг Сф");
            dataGridView1.Rows.Add("Состав фурменного (горнового) газа: N2", "VN2", Math.Round(bdp.get_VN2(), 4), "м3/кг Сф");
            dataGridView1.Rows.Add("CO, образующийся при восстановлении оксидов Fe, Mn, Si, P, а также при десульфурации", "Vпвco=", Math.Round(bdp.get_Vпвco(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Степень использования CO в печи", "nCO=", Math.Round(bdp.get_nCO(), 4), "0");
            dataGridView1.Rows.Add("Степень использования водорода в печи", "nH2=", Math.Round(bdp.get_nH2(), 4), "0");
            dataGridView1.Rows.Add("Объём Vсо при t=1000", "Vt=1000co=", Math.Round(bdp.get_Vte1000co(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём Н2 при t=1000", "Vt=1000Н2=", Math.Round(bdp.get_Vte1000H2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём N2 при t=1000", "Vt=1000N2=", Math.Round(bdp.get_Vtt1000N2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём СО2 при разложении известняка", "VИСО2=", Math.Round(bdp.get_VИСО2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём СО2 при косвенном восстановлении оксидов железа", "VКВСО2=", Math.Round(bdp.get_VКВСО2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём СО2 в колошниковом газе", "VКГСО2=", Math.Round(bdp.get_VКГСО2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём СО в колошниковом газе", "VКГСО=", Math.Round(bdp.get_VКГСО(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём СН4 в колошниковом газе", "VКГСН4=", Math.Round(bdp.get_VКГСН4(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём N2 в колошниковом газе", "VКГN2=", Math.Round(bdp.get_VКГN2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Объём Н2 в колошниковом газе", "VКГН2=", Math.Round(bdp.get_VКГН2(), 4), "м3/т чугуна");
            dataGridView1.Rows.Add("Удельный выход колошникового газа при  н.у.", "VКГ=", Math.Round(bdp.get_VКГ(), 4), "м3/т чугуна");
            #endregion -- Промежуточные данные

            #region -- Тепловой баланс

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("Приходная часть теплового баланса");
            dataGridView2.Rows.Add("1. Количество тепла, получающегося при горении углерода кокса", "", Math.Round(bdp.get_ktpgorkoks(),4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("1. Количество тепла, получающегося при горении углерода кокса (процент)", "", Math.Round(bdp.get_ktpgorkoksprocent(), 4), "%");
            dataGridView2.Rows.Add("Теплоемкость O2 в дутье при температуре дутья", "", Math.Round(bdp.get_TeplO2Dutia(), 4), "кДж/(м3*°С)");
            dataGridView2.Rows.Add("Теплоемкость N2 в дутье при температуре дутья", "", Math.Round(bdp.get_TeplN2Dutia(), 4), "кДж/(м3*°С)");
            dataGridView2.Rows.Add("Теплоемкость H2O в дутье при температуре дутья", "", Math.Round(bdp.get_TeplH2OinDutia(), 4), "кДж/(м3*°С)");
            dataGridView2.Rows.Add("2. Количество тепла от нагретого дутья", "", Math.Round(bdp.get_KolTeplotaotNagretDutia(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("2. Количество тепла от нагретого дутья (процент)", "", Math.Round(bdp.get_KolTeplotaotNagretDutiaprocent(), 4), "%");
            dataGridView2.Rows.Add("3. Количество тепла от конверсии природного газа", "", Math.Round(bdp.get_KolTeplotaotKonvers(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("3. Количество тепла от конверсии природного газа (процент)", "", Math.Round(bdp.get_KolTeplotaotKonversprocent(), 4), "%");
            dataGridView2.Rows.Add("4. Количество тепла от шлакообразования", "", Math.Round(bdp.get_KolTeplotaotSHLAKA(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("4. Количество тепла от шлакообразования (процент)", "", Math.Round(bdp.get_KolTeplotaotSHLAKAprocent(), 4), "%");
            dataGridView2.Rows.Add("Сумма приходных статей теплового баланса", "", Math.Round(bdp.get_SummaPrihodStatei(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Сумма приходных статей теплового баланса (процент)", "", Math.Round(bdp.get_SummaPrihodStateiprocent(), 4), "%");

            dataGridView2.Rows.Add("Расходная часть теплового баланса");
            dataGridView2.Rows.Add("1. Расход тепла на прямое восстановление оксидов железа", "", Math.Round(bdp.get_RashodTeplanaPryamoeVosstFeO(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("1. Расход тепла на прямое восстановление оксидов железа (процент)", "", Math.Round(bdp.get_RashodTeplanaPryamoeVosstFeOprocent(), 4), "%");
            dataGridView2.Rows.Add("2. Расход тепла на прямое восстановление примесей чугуна", "", Math.Round(bdp.get_RashodTeplanaPryamoeVosstChugun(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("2. Расход тепла на прямое восстановление примесей чугуна (процент)", "", Math.Round(bdp.get_RashodTeplanaPryamoeVosstChugunprocent(), 4), "%");
            dataGridView2.Rows.Add("3. Расход тепла на процесс десульфурации чугуна", "", Math.Round(bdp.get_RashodTeplanaDesfularaz(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("3. Расход тепла на процесс десульфурации чугуна (процент)", "", Math.Round(bdp.get_RashodTeplanaDesfularazprocent(), 4), "%");
            dataGridView2.Rows.Add("4. Расход тепла на восстановление оксидов железа водородом", "", Math.Round(bdp.get_RashodTeplanaVosstVodorodom(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("4. Расход тепла на восстановление оксидов железа водородом (процент)", "", Math.Round(bdp.get_RashodTeplanaVosstVodorodomprocent(), 4), "%");
            dataGridView2.Rows.Add("5. Расход тепла на нагрев жидкого чугуна", "", Math.Round(bdp.get_RashodTeplananAGREVjIDCHUGUN(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("5. Расход тепла на нагрев жидкого чугуна (процент)", "", Math.Round(bdp.get_RashodTeplananAGREVjIDCHUGUNprocent(), 4), "%");
            dataGridView2.Rows.Add("6. Расход тепла на нагрев жидкого шлака", "", Math.Round(bdp.get_RashodTeplananAGREVjIDSHLAKA(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("6. Расход тепла на нагрев жидкого шлака (процент)", "", Math.Round(bdp.get_RashodTeplananAGREVjIDSHLAKAprocent(), 4), "%");
            dataGridView2.Rows.Add("7. Расход тепла на разложение влаги дутья", "", Math.Round(bdp.get_RashodTeplanaRazlojenieVlAGIDUTIA(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("7. Расход тепла на разложение влаги дутья (процент)", "", Math.Round(bdp.get_RashodTeplanaRazlojenieVlAGIDUTIAprocent(), 4), "%");
            dataGridView2.Rows.Add("8. Расход тепла на разложение известняка", "", Math.Round(bdp.get_RashodTeplanaRazlojenieIZVEST(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("8. Расход тепла на разложение известняка (процент)", "", Math.Round(bdp.get_RashodTeplanaRazlojenieIZVESTprocent(), 4), "%");
            dataGridView2.Rows.Add("9. Расход тепла на разложение влаги шихты", "", Math.Round(bdp.get_RashodTeplanaRazlojenieVLAGISHICHTY(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("9. Расход тепла на разложение влаги шихты (процент)", "", Math.Round(bdp.get_RashodTeplanaRazlojenieVLAGISHICHTYprocent(), 4), "%");
            dataGridView2.Rows.Add("Теплоемкость CO при температуре колошникового газа ", "", Math.Round(bdp.get_TeploemCOpriTempKoloshGAZA(), 4), " кДж/(м3*К)");
            dataGridView2.Rows.Add("Теплоемкость CO2 при температуре колошникового газа", "", Math.Round(bdp.get_TeploemCO2priTempKoloshGAZA(), 4), " кДж/(м3*К)");
            dataGridView2.Rows.Add("Теплоемкость H2O при температуре колошникового газа", "", Math.Round(bdp.get_TeploemH2OpriTempKoloshGAZA(), 4), " кДж/(м3*К)");
            dataGridView2.Rows.Add("Теплоемкость N2 при температуре колошникового газа", "", Math.Round(bdp.get_TeploemN2priTempKoloshGAZA(), 4), " кДж/(м3*К)");
            dataGridView2.Rows.Add("Теплоемкость H2 при температуре колошникового газа", "", Math.Round(bdp.get_TeploemH2priTempKoloshGAZA(), 4), " кДж/(м3*К)");
            dataGridView2.Rows.Add("10. Расход тепла, уносимое колошниковым газом", "", Math.Round(bdp.get_RashodTeplaUnosimyiKoloshnikovymGazom(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("10. Расход тепла, уносимое колошниковым газом (процент)", "", Math.Round(bdp.get_RashodTeplaUnosimyiKoloshnikovymGazomprocent(), 4), "%");
            dataGridView2.Rows.Add("11. Тепловые потери доменной печи", "", Math.Round(bdp.get_TeploPoteriDomenn(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("11. Тепловые потери доменной печи (процент)", "", Math.Round(bdp.get_TeploPoteriDomennprocent(), 4), "%");
            dataGridView2.Rows.Add("Сумма расходных статей теплового баланса", "", Math.Round(bdp.get_SUMMARASHODSTATEI(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Сумма расходных статей теплового баланса (процент)", "", Math.Round(bdp.get_SUMMARASHODSTATEIprocent(), 4), "%");  
       
            dataGridView2.Rows.Add("Влияние различных факторов на статьи ТБ и удельный расход кокса");
            dataGridView2.Rows.Add("Приход тепла от горения кокса у фурм и горячего дутья за вычетом тепла, уносимого колошниковым газом", "Qпромежут", Math.Round(bdp.get_Qпромежут(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Qпромежут, отнесенное к количеству углерода, сгорающего у фурм", "", Math.Round(bdp.get_QпромежутkkolC(), 4), "кДж/кг Сф");
            dataGridView2.Rows.Add("Содержание углерода в коксе", "Ck", Math.Round(bdp.get_Ck(), 4), "%");
            dataGridView2.Rows.Add("1.Влияние степени прямого восстановления на расход кокса");
            dataGridView2.Rows.Add("Снижение статьи расхода тепла на прямое восстановление при уменьшении rd на 0,01 ", "", Math.Round(bdp.get_SNiJENIESTATIIRASHODATEPLAPRIUMENrd(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Эквивалентное снижение расхода кокса", "∆k", Math.Round(bdp.get_EKVIVALENTSNIJ1(), 4), "кг/т чугуна");
            dataGridView2.Rows.Add("2.Влияние ввода в печь сырого известняка на расход кокса");
            dataGridView2.Rows.Add("3.Влияние температуры горячего дутья на расход кокса");
            dataGridView2.Rows.Add("Прирост статьи притока тепла горячего дутья при повышении его температуры на 10 °C", "", Math.Round(bdp.get_PRIROSTSTATIIPRITOKATEPLA(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Экономия кокса при повышении температуры дутья на 10 °C", "∆k", Math.Round(bdp.get_ECONOMYKOKSPRIPOVYSH(), 4), "кг/т чугуна");
            dataGridView2.Rows.Add("4.Влияние состава комбинированного дутья на расход кокса");
            dataGridView2.Rows.Add("Прирост статьи притока тепла от конверсии природного газа при повышении его расхода на 10 м3/т", "∆k", Math.Round(bdp.get_PRIROSTOTKONVERSPG(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Экономия кокса при повышении расхода природного газа на 10 м3/т", "∆k", Math.Round(bdp.get_ECONOMYKOKSPRIPOVYSHNA10(), 4), "кг/т чугуна");
            dataGridView2.Rows.Add("5.Влияние влажности комбинированного дутья на расход кокса");
            dataGridView2.Rows.Add("Снижение статьи расхода тепла на разложение влаги дутья при уменьшении влажности дутья на 1 г/м3", "∆k", Math.Round(bdp.get_RAZLOJVLAGIDUTIA(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Экономия кокса при снижении влажности дутья на 1 г/м3", "∆k", Math.Round(bdp.get_ECONOMYKOKSPRIPOVYSHNA1(), 4), "кг/т чугуна");
            dataGridView2.Rows.Add("6.Влияние выхода шлака на расход кокса");
            dataGridView2.Rows.Add("Экономия тепла при снижении выхода шлака на 10 кг", "∆k", Math.Round(bdp.get_economyteplaprisnijvyhodashlaka(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Экономия кокса при снижении выхода шлака на 10 кг", "∆k", Math.Round(bdp.get_economykoksaprisnijvyhodashlaka(), 4), "кг/т чугуна");
            dataGridView2.Rows.Add("7.Влияние тепловых потерь доменной печи на расход кокса");
            dataGridView2.Rows.Add("Экономия тепла при снижении тепловых потерь печи на 1 %", "∆k", Math.Round(bdp.get_economyteplapriteplopoteri(), 4), "кДж/кг чугуна");
            dataGridView2.Rows.Add("Экономия кокса при снижении тепловых потерь печи на 1 %", "∆k", Math.Round(bdp.get_ECONOMYKOKSPRIPOVYSHNA2(), 4), "кг/т чугуна");





            #endregion -- Тепловой баланс



        }


        /// <summary>
        /// Прочитать исходные данные с формы и присвоить экземпляру объекта
        /// </summary>  


        
        private void ReadInputDataFromForm()
        {
            bdp.SoderjElementinChugunSi = double.Parse(txtSoderjElementinChugunSi.Text.ToString());
            bdp.SoderjElementinChugunSi = double.Parse(txtSoderjElementinChugunSi.Text.ToString());
            bdp.SoderjElementinChugunSi = double.Parse(txtSoderjElementinChugunSi.Text.ToString());
            bdp.SoderjElementinChugunSi = double.Parse(txtSoderjElementinChugunSi.Text.ToString());
            bdp.SoderjElementinChugunSi = double.Parse(txtSoderjElementinChugunSi.Text.ToString());
            bdp.SoderjElementinChugunMn = double.Parse(txtSoderjElementinChugunMn.Text.ToString());
            bdp.SoderjElementinChugunS = double.Parse(txtSoderjElementinChugunS.Text.ToString());
            bdp.SoderjElementinChugunP = double.Parse(txtSoderjElementinChugunP.Text.ToString());
            bdp.SoderjElementinChugunTi = double.Parse(txtSoderjElementinChugunTi.Text.ToString());
            bdp.SoderjElementinChugunCr = double.Parse(txtSoderjElementinChugunCr.Text.ToString());
            bdp.SoderjElementinChugunV = double.Parse(txtSoderjElementinChugunV.Text.ToString());
            bdp.SoderjElementinChugunC = double.Parse(txtSoderjElementinChugunC.Text.ToString());
            bdp.TmpChugun = double.Parse(txtTmpChugun.Text.ToString());
            bdp.TeploEmkChugun = double.Parse(txtTeploEmkChugun.Text.ToString());
            bdp.StepenPryamVosstanov = double.Parse(txtStepenPryamVosstanov.Text.ToString());
            bdp.UdelnRashodKoksa = double.Parse(txtUdelnRashodKoksa.Text.ToString());
            bdp.SeraKoksa = double.Parse(txtSeraKoksa.Text.ToString());
            bdp.LetuchKoksa = double.Parse(txtLetuchKoksa.Text.ToString());
            bdp.VlagaKoksa = double.Parse(txtVlagaKoksa.Text.ToString());
            bdp.TempGorDutia = double.Parse(txtTempGorDutia.Text.ToString());
            bdp.SodKislorodinDutia = double.Parse(txtSodKislorodinDutia.Text.ToString());
            bdp.VlajnostiDutia = double.Parse(txtVlajnostiDutia.Text.ToString());
            bdp.UdelnRashodPrirodGaza = double.Parse(txtUdelnRashodPrirodGaza.Text.ToString());
            bdp.SostavCH4 = double.Parse(txtSostavCH4.Text.ToString());
            bdp.SostavC2H6 = double.Parse(txtSostavC2H6.Text.ToString());
            bdp.SostavCO2 = double.Parse(txtSostavCO2.Text.ToString());
            bdp.SoderjCinPrirodGaza = double.Parse(txtSoderjCinPrirodGaza.Text.ToString());
            bdp.SoderjH2inPrirodGaza = double.Parse(txtSoderjH2inPrirodGaza.Text.ToString());
            bdp.UdelnRaschIzvest = double.Parse(txtUdelnRaschIzvest.Text.ToString());
            bdp.SoderjVlagiIzvest = double.Parse(txtSoderjVlagiIzvest.Text.ToString());
            bdp.PoteryaMasPriProkal = double.Parse(txtPoteryaMasPriProkal.Text.ToString());
            bdp.SoderjSinShlak = double.Parse(txtSoderjSinShlak.Text.ToString());
            bdp.TeploemkostShlaka = double.Parse(txtTeploemkostShlaka.Text.ToString());
            bdp.TempKoloshnikGAz = double.Parse(txtTempKoloshnikGAz.Text.ToString());
            bdp.SoderjCO2KoloshGaz = double.Parse(txtSoderjCO2KoloshGaz.Text.ToString());
            bdp.SoderjCOKoloshGaz = double.Parse(txtSoderjCOKoloshGaz.Text.ToString());
            bdp.SoderjN2KoloshGaz = double.Parse(txtSoderjN2KoloshGaz.Text.ToString());
            bdp.SoderjH2KoloshGaz = double.Parse(txtSoderjH2KoloshGaz.Text.ToString());
            bdp.UdelnyJRM = double.Parse(txtUdelnyJRM.Text.ToString());
            bdp.UdelnyRaschodMetalldobavok = double.Parse(txtUdelnyRaschodMetalldobavok.Text.ToString());
            bdp.SoderjVlagiinJRM = double.Parse(txtSoderjVlagiinJRM.Text.ToString());
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            
            
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Проверки

        /// <summary>
        /// Проверить текстовое поле на null и непустоту. 
        /// </summary>  
        /// <param name="TxtB">Поле для проверки</param>
        private bool CheckPoint(TextBox TxtB)
        {
            if (TxtB == null || TxtB.Text == "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// Проверить введенные в текстовое поле данные. 
        /// </summary>  
        /// <param name="strTxtB">Введенное в поле значение</param>
        private bool CheckPoint(string strTxtB)
        {
            float fl;
            if (!float.TryParse(strTxtB, out fl))
                return false;
            else
                return true;
        }

        #endregion Проверки



        private void txtSoderjElementinChugunSi_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtSoderjElementinChugunSi))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtSoderjElementinChugunSi.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtSoderjElementinChugunSi.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина должна иметь числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtSoderjElementinChugunSi.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void txtSoderjElementinChugunSi_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtSoderjElementinChugunSi.Text; 
        }

        private void txtSoderjElementinChugunMn_Enter(object sender, EventArgs e)
        {
            strTempCancel = txtSoderjElementinChugunMn.Text;
        }

        private void txtSoderjElementinChugunMn_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckPoint(txtSoderjElementinChugunMn))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + strMsgErrAttentionNull + strMsgErrRepeat, strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtSoderjElementinChugunMn.Text = strTempCancel;
                e.Cancel = true;
            }
            else if (!CheckPoint(txtSoderjElementinChugunMn.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(strMsgErrAttention + "Вы ввели текст, а величина должна иметь числовой тип." + "\n" + strMsgErrRepeat,
                        strMsgErrCaption, buttons, MessageBoxIcon.Error);
                txtSoderjElementinChugunMn.Text = strTempCancel;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void txtSoderjElementinChugunS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjElementinChugunP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjElementinChugunTi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjElementinChugunCr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjElementinChugunV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjElementinChugunC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtTmpChugun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtTeploEmkChugun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnRashodKoksa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtUdelnRashodKoksa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtZolaKoksa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSeraKoksa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtLetuchKoksa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtVlagaKoksa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtStepenPryamVosstanov_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStepenPryamVosstanov_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtTempGorDutia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtVlajnostiDutia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSodKislorodinDutia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnRashodPrirodGaza_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSostavCH4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSostavC2H6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSostavCO2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjCinPrirodGaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjH2inPrirodGaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnVychodShlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjSinShlak_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtTeploemkostShlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnRaschIzvest_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

      
        private void txtSoderjVlagiIzvest_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtPoteryaMasPriProkal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtTempKoloshnikGAz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjCO2KoloshGaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjCOKoloshGaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjN2KoloshGaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjH2KoloshGaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnyJRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnyRaschodMetalldobavok_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtSoderjVlagiinJRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtUdelnRashodPrirodGaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 46 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void btnOtchet_Click(object sender, EventArgs e)
        {
            CreateReportViewer();
        }

        /// <summary>
        /// Создать отчет ReportViewer
        /// </summary>         
        private void CreateReportViewer()
        {
            frmRpt = new OTCHET();

            #region Подготовить данные для вывода в отчет

            // Исходные данные в отчет только те, которые отметил пользователь (IsReport=true)
            List<cReportList> RepListInput = new List<cReportList>();
            RepListInput.Add(new cReportList("Температура чугуна", bdp.TmpChugun.ToString()));
            RepListInput.Add(new cReportList("Теплоёмкость чугуна", bdp.TeploEmkChugun.ToString()));
            RepListInput.Add(new cReportList("Степень прямого восстановления", bdp.StepenPryamVosstanov.ToString()));
            RepListInput.Add(new cReportList("Удельный расход кокса", bdp.UdelnRashodKoksa.ToString()));
            RepListInput.Add(new cReportList("Температура горячего дутья", bdp.TempGorDutia.ToString()));
            RepListInput.Add(new cReportList("Содержание кислорода в дутье", bdp.SodKislorodinDutia.ToString()));
            RepListInput.Add(new cReportList("Удельный выход шлака", bdp.UdelnVychodShlaka.ToString()));
            RepListInput.Add(new cReportList("Теплоёмкость шлака", bdp.TeploemkostShlaka.ToString()));
            RepListInput.Add(new cReportList("Температура колошникового газа", bdp.TempKoloshnikGAz.ToString()));
            RepListInput.Add(new cReportList("Удельный расход железнорудного материала", bdp.UdelnyJRM.ToString()));
            RepListInput.Add(new cReportList("Удельный расход металлодобавок", bdp.UdelnyRaschodMetalldobavok.ToString()));




            //foreach (NumberSum.Param par in _allParamsInput)
            //{
            //    if (par.IsReport)
            //    {
            //        double d = Math.Round(Convert.ToDouble(
            //            propertyGrid.SelectedObject.GetType().GetProperty(par.PropertyName).GetValue(
            //            propertyGrid.SelectedObject, null)), 3);
            //        RepListInput.Add(new NumberSum.cReportList(par.Description, d.ToString()));
            //    }
            //}
            // Результаты расчета в отчет только те, которые отметил пользователь (IsReport=true)
            //DataOutput _dataOutput = new DataOutput(s);
            List<cReportList> RepListOutput = new List<cReportList>();
            RepListOutput.Add(new cReportList("Количество тепла, получающегося при горении углерода кокса", Math.Round(bdp.get_ktpgorkoks(), 2).ToString()));
            RepListOutput.Add(new cReportList("Количество тепла от нагретого дутья", Math.Round(bdp.get_KolTeplotaotNagretDutia(), 2).ToString()));
            RepListOutput.Add(new cReportList("Количество тепла от конверсии природного газа", Math.Round(bdp.get_KolTeplotaotKonvers(), 2).ToString()));
            RepListOutput.Add(new cReportList("Количество тепла от шлакообразования", Math.Round(bdp.get_KolTeplotaotSHLAKA(), 2).ToString()));
            RepListOutput.Add(new cReportList("Сумма приходных статей теплового баланса", Math.Round(bdp.get_SummaPrihodStatei(), 2).ToString()));
            RepListOutput.Add(new cReportList("Расход тепла на прямое восстановление оксидов железа", Math.Round(bdp.get_RashodTeplanaPryamoeVosstFeO(), 2).ToString()));
            RepListOutput.Add(new cReportList("Расход тепла на процесс десульфурации чугуна", Math.Round(bdp.get_RashodTeplanaDesfularaz(), 2).ToString()));
            RepListOutput.Add(new cReportList(" Расход тепла на нагрев жидкого чугуна", Math.Round(bdp.get_RashodTeplananAGREVjIDCHUGUN(), 2).ToString()));
            RepListOutput.Add(new cReportList("Расход тепла на разложение влаги шихты", Math.Round(bdp.get_RashodTeplanaRazlojenieVLAGISHICHTY(), 2).ToString()));
            RepListOutput.Add(new cReportList("Расход тепла, уносимое колошниковым газом", Math.Round(bdp.get_RashodTeplaUnosimyiKoloshnikovymGazom(), 2).ToString()));
            RepListOutput.Add(new cReportList("Тепловые потери доменной печи", Math.Round(bdp.get_TeploPoteriDomenn(), 2).ToString()));
            RepListOutput.Add(new cReportList("Сумма расходных статей теплового баланса", Math.Round(bdp.get_SUMMARASHODSTATEI(), 2).ToString()));




            //foreach (NumberSum.Param par in _allParamsOutput)
            //{
            //    if (par.IsReport)
            //    {
            //        double d = Math.Round(Convert.ToDouble(
            //            _dataOutput.GetType().GetProperty(par.PropertyName).GetValue(_dataOutput, null)), 3);
            //        RepListOutput.Add(new NumberSum.cReportList(par.Description, d.ToString()));
            //    }
            //}
            #endregion

            // Указать отчету источники данных                
            frmRpt.cReportInputBindingSource.DataSource = RepListInput;
            frmRpt.cReportOutputBindingSource.DataSource = RepListOutput;

            // Показать окно отчета на весь экран
            frmRpt.WindowState = FormWindowState.Maximized;
            frmRpt.ShowDialog(this);
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            frmDiagramma D = new frmDiagramma (bdp);
            D.ShowDialog();
        }
    }
}
