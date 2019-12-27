using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace BalanceDPDll
{
    [Serializable]
    public class MathLib
    {

        #region Сериализация 
        /// <summary>
        /// Загрузить исходные данные в экземпляр объекта расчета 
        /// </summary>  
        /// <param name="NameFile">Имя файла для извлечения данных</param>
        public MathLib LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            MathLib _s = (MathLib)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _s;
        }

        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="hc">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(MathLib s, string NameFile)
        {
            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, s);
            myStream.Close();
        }
        #endregion Сериализация 


                                                         //ИСХОДНЫЕ ДАННЫЕ
                                                  //ЖИДКИЕ ПРОДУКТЫ ДОМЕННОЙ ПЛАВКИ 


        /// <summary>
        /// Свойство для первой переменной
        /// </summary> 
        private double _SoderjElementinChugunSi;    // закрытая переменная класса 
        public double SoderjElementinChugunSi
        {
            get { return _SoderjElementinChugunSi; }
            set { _SoderjElementinChugunSi = value; }
        }
       
        private double _SoderjElementinChugunMn;     
        public double SoderjElementinChugunMn
        {
            get { return _SoderjElementinChugunMn; }
            set { _SoderjElementinChugunMn = value; }
        }
        
        private double _SoderjElementinChugunS;    
        public double SoderjElementinChugunS
        {
            get { return _SoderjElementinChugunS; }
            set { _SoderjElementinChugunS = value; }
        }
           
        private double _SoderjElementinChugunP;     
        public double SoderjElementinChugunP
        {
            get { return _SoderjElementinChugunP; }
            set { _SoderjElementinChugunP = value; }
        }
        
        private double _SoderjElementinChugunTi;     
        public double SoderjElementinChugunTi
        {
            get { return _SoderjElementinChugunTi; }
            set { _SoderjElementinChugunTi = value; }
        }
        
        private double _SoderjElementinChugunCr;     
        public double SoderjElementinChugunCr
        {
            get { return _SoderjElementinChugunCr; }
            set { _SoderjElementinChugunCr = value; }
        }
         
        private double _SoderjElementinChugunV;     
        public double SoderjElementinChugunV
        {
            get { return _SoderjElementinChugunV; }
            set { _SoderjElementinChugunV = value; }
        }

        private double _SoderjElementinChugunC;    
        public double SoderjElementinChugunC
        {
            get { return _SoderjElementinChugunC; }
            set { _SoderjElementinChugunC = value; }
        }
                                   
        private double _TmpChugun;    
        public double TmpChugun
        {
            get { return _TmpChugun; }
            set { _TmpChugun = value; }
        }
        
        private double _TeploEmkChugun;    
        public double TeploEmkChugun
        {
            get { return _TeploEmkChugun; }
            set { _TeploEmkChugun = value; }
        }
        

                   //РЕЖИМНЫЕ ПАРАМЕТРЫ

        private double _StepenPryamVosstanov;    
        public double StepenPryamVosstanov
        {
            get { return _StepenPryamVosstanov; }
            set { _StepenPryamVosstanov = value; }
        }
        
                  //ОПРЕДЕЛЕНИЕ ХАРАКТЕРИСТИК КОКСА

        private double _UdelnRashodKoksa;     
        public double UdelnRashodKoksa
        {
            get { return _UdelnRashodKoksa; }
            set { _UdelnRashodKoksa = value; }
        }
        
        private double _ZolaKoksa;    
        public double ZolaKoksa
        {
            get { return _ZolaKoksa; }
            set { _ZolaKoksa = value; }
        }
        
        private double _SeraKoksa;    
        public double SeraKoksa
        {
            get { return _SeraKoksa; }
            set { _SeraKoksa = value; }
        }
        
        private double _LetuchKoksa;     
        public double LetuchKoksa
        {
            get { return _LetuchKoksa; }
            set { _LetuchKoksa = value; }
        }
        
        private double _VlagaKoksa;    
        public double VlagaKoksa
        {
            get { return _VlagaKoksa; }
            set { _VlagaKoksa = value; }
        }


                           //ПАРАМЕТРЫ ДУТЬЯ


        private double _TempGorDutia;     
        public double TempGorDutia
        {
            get { return _TempGorDutia; }
            set { _TempGorDutia = value; }
        }
 
        private double _SodKislorodinDutia;     
        public double SodKislorodinDutia
        {
            get { return _SodKislorodinDutia; }
            set { _SodKislorodinDutia = value; }
        }

        private double _VlajnostiDutia;     
        public double VlajnostiDutia
        {
            get { return _VlajnostiDutia; }
            set { _VlajnostiDutia = value; }
        }

        
        private double _UdelnRashodPrirodGaza;     
        public double UdelnRashodPrirodGaza
        {
            get { return _UdelnRashodPrirodGaza; }
            set { _UdelnRashodPrirodGaza = value; }
        }
        
        private double _SostavCH4;     
        public double SostavCH4
        {
            get { return _SostavCH4; }
            set { _SostavCH4 = value; }
        }
       
        private double _SostavC2H6;     
        public double SostavC2H6
        {
            get { return _SostavC2H6; }
            set { _SostavC2H6 = value; }
        }
        
        private double _SostavCO2;     
        public double SostavCO2
        {
            get { return _SostavCO2; }
            set { _SostavCO2 = value; }
        }

       
        private double _SoderjCinPrirodGaza;     
        public double SoderjCinPrirodGaza
        {
            get { return _SoderjCinPrirodGaza; }
            set { _SoderjCinPrirodGaza = value; }
        }

         
        private double _SoderjH2inPrirodGaza;    
        public double SoderjH2inPrirodGaza
        {
            get { return _SoderjH2inPrirodGaza; }
            set { _SoderjH2inPrirodGaza = value; }
        }

        //ПАРАМЕТРЫ ИЗВЕСТНЯКА
       
        private double _UdelnRaschIzvest;     
        public double UdelnRaschIzvest
        {
            get { return _UdelnRaschIzvest; }
            set { _UdelnRaschIzvest = value; }
        }
 
        private double _SoderjVlagiIzvest;    
        public double SoderjVlagiIzvest
        {
            get { return _SoderjVlagiIzvest; }
            set { _SoderjVlagiIzvest = value; }
        }

        private double _PoteryaMasPriProkal;     
        public double PoteryaMasPriProkal
        {
            get { return _PoteryaMasPriProkal; }
            set { _PoteryaMasPriProkal = value; }
        }

                         //ПАРАМЕТРЫ ШЛАКА

        private double _UdelnVychodShlaka;    
        public double UdelnVychodShlaka
        {
            get { return _UdelnVychodShlaka; }
            set { _UdelnVychodShlaka = value; }
        }
 
        private double _SoderjSinShlak;     
        public double SoderjSinShlak
        {
            get { return _SoderjSinShlak; }
            set { _SoderjSinShlak = value; }
        }
        
        private double _TeploemkostShlaka;     
        public double TeploemkostShlaka
        {
            get { return _TeploemkostShlaka; }
            set { _TeploemkostShlaka = value; }
        }
 
                          //КОЛОШНИКОВЫЙ ГАЗ

        private double _TempKoloshnikGAz;   
        public double TempKoloshnikGAz
        {
            get { return _TempKoloshnikGAz; }
            set { _TempKoloshnikGAz = value; }
        }
        
        private double _SoderjCO2KoloshGaz;    
        public double SoderjCO2KoloshGaz
        {
            get { return _SoderjCO2KoloshGaz; }
            set { _SoderjCO2KoloshGaz = value; }
        }
        
        private double _SoderjCOKoloshGaz;   
        public double SoderjCOKoloshGaz
        {
            get { return _SoderjCOKoloshGaz; }
            set { _SoderjCOKoloshGaz = value; }
        }
        
        private double _SoderjN2KoloshGaz;     
        public double SoderjN2KoloshGaz
        {
            get { return _SoderjN2KoloshGaz; }
            set { _SoderjN2KoloshGaz = value; }
        }
        
        private double _SoderjH2KoloshGaz;     
        public double SoderjH2KoloshGaz
        {
            get { return _SoderjH2KoloshGaz; }
            set { _SoderjH2KoloshGaz = value; }
        }
 
                                 //ХАРАКТЕРИСТИКИ ЖРМ

        private double _UdelnyJRM;    
        public double UdelnyJRM
        {
            get { return _UdelnyJRM; }
            set { _UdelnyJRM = value; }
        }
        
        private double _UdelnyRaschodMetalldobavok;     
        public double UdelnyRaschodMetalldobavok
        {
            get { return _UdelnyRaschodMetalldobavok; }
            set { _UdelnyRaschodMetalldobavok = value; }
        }
        
        private double _SoderjVlagiinJRM;    
        public double SoderjVlagiinJRM
        {
            get { return _SoderjVlagiinJRM; }
            set { _SoderjVlagiinJRM = value; }
        }
        
                                                      ////ПРОМЕЖУТОЧНЫЙ РАСЧЁТ

        private double _Fe;     
        public double get_Fe()
        {
            return _Fe = 100 - _SoderjElementinChugunSi - _SoderjElementinChugunMn - _SoderjElementinChugunS - _SoderjElementinChugunP - _SoderjElementinChugunTi - _SoderjElementinChugunCr - _SoderjElementinChugunV - _SoderjElementinChugunC;
            
        }
        
        private double _Спр;    // закрытая переменная класса 
        public double get_Спр()
        {
            return _Спр = (_Fe * 10 * _StepenPryamVosstanov*12/56);

        }

        
        private double _Сприм;    
        public double get_Сприм()
        {
            return _Сприм = 10*((_SoderjElementinChugunMn * 12 / 55) + (_SoderjElementinChugunP * 60 / 62) + (_SoderjElementinChugunSi * 24 / 28) + (_SoderjElementinChugunS * 12 / 32) + (_SoderjElementinChugunV * 60 / 110) + (_SoderjElementinChugunTi * 12 / 48) + (_SoderjElementinChugunCr * 48/104));

        }
         
        private double _Снел;     
        public double get_Снел()
        {
            return _Снел = 100 - (_ZolaKoksa + _SeraKoksa + _LetuchKoksa);

        }
       
        private double _Сприш;     
        public double get_Сприш()
        {
            return _Сприш = 0.01 * _UdelnRashodKoksa * _Снел;
        }
       
        private double _CСН4;     
        public double get_CСН4()
        {
            return _CСН4 = 0.008 * _Сприш;
        }
        
        private double _Сч;    
        public double get_Сч()
        {
            return _Сч = 10* _SoderjElementinChugunC;
        }

        private double _Сф;     
        public double get_Сф()
        {
            return _Сф = _Сприш-(_Сч+ _Спр+_Сприм+ _CСН4);
        }
        
        private double _VдC;     
        public double get_VдC()
        {
            return _VдC = 0.9333/(0.01* _SodKislorodinDutia+0.00062*_VlajnostiDutia);
        }
        
        private double _VдPG;    
        public double get_VдPG()
        {
            return _VдPG = 0.5 / (0.01 * _SodKislorodinDutia + 0.00062 * _VlajnostiDutia);
        }

        
        private double _VдXX;    
        public double get_VдXX()
        {
            return _VдXX = (_UdelnRashodPrirodGaza/ _Сф);
        }

         
        private double _Vд;    
        public double get_Vд()
        {
            return _Vд = (_VдC+ _VдPG* _VдXX);
        }

        private double _Qд;     
        public double get_Qд()
        {
            return _Qд =(_Сф* _Vд);
        }
        
        private double _Vсо;    
        public double get_Vсо()
        {
            return _Vсо = 1.8667+_UdelnRashodPrirodGaza/_Сф* _SoderjCinPrirodGaza;
        }
 
        private double _VН2;    
        public double get_VН2()
        {
            return _VН2 =(0.9333+0.5* _UdelnRashodPrirodGaza /_Сф)/(0.01* _SodKislorodinDutia+0.00124* _VlajnostiDutia)*0.00124* _VlajnostiDutia+ _UdelnRashodPrirodGaza / _Сф* _SoderjH2inPrirodGaza;
        }
 
        private double _VN2;     
        public double get_VN2()
        {
            return _VN2 = (0.9333 + 0.5 * _UdelnRashodPrirodGaza / _Сф) / (0.01 * _SodKislorodinDutia + 0.00124 * _VlajnostiDutia) * (1-0.01* _SodKislorodinDutia);
        }
 
        private double _Vпвco;    
        public double get_Vпвco()
        {
            return _Vпвco = 10*22.4*(_Fe* _StepenPryamVosstanov/56+ _SoderjElementinChugunMn/55+2* _SoderjElementinChugunSi/28+ _SoderjSinShlak/32);
        }
 
        private double _nCO;     
        public double get_nCO()
        {
            return _nCO = _SoderjCO2KoloshGaz/(_SoderjCO2KoloshGaz +_SoderjCOKoloshGaz);
        }
        
        private double _nH2;     
        public double get_nH2()
        {
            return _nH2 =(0.88* _nCO) + 0.1;
        }
        
        private double _Vte1000co;     

        public double get_Vte1000co()
        {
            return _Vte1000co = _Vсо*_Сф+_Vпвco;
        }
 
        private double _Vte1000H2;     
        public double get_Vte1000H2()
        {
            return _Vte1000H2 = (_VН2*_Сф*(1 -_nH2));
        }
        
        private double _Vtt1000N2;     
        public double get_Vtt1000N2()
        {
            return _Vtt1000N2 = _VN2* _Сф;
        }
        
        private double _VИСО2;     
        public double get_VИСО2()
        {
            return _VИСО2 = 0.01* _UdelnRaschIzvest*22.4/44*_PoteryaMasPriProkal;
        }
        
        private double _VКВСО2;     
        public double get_VКВСО2()
        {
            return _VКВСО2 = _nCO*_Vte1000co;
        }
        
        private double _VКГСО2;    
        public double get_VКГСО2()
        {
            return _VКГСО2 = _VИСО2+_VКВСО2;
        }
        
        private double _VКГСО;    
        public double get_VКГСО()
        {
            return _VКГСО = _Vte1000co -_VКВСО2;
        }
        
        private double _VКГСН4;     
        public double get_VКГСН4()
        {
            return _VКГСН4 = _CСН4*22.4/12;
        }
        
        private double _VКГN2;     
        public double get_VКГN2()
        {
            return _VКГN2 = _Vtt1000N2;
        }
        
        private double _VКГН2;    
        public double get_VКГН2()
        {
            return _VКГН2 = _Vte1000H2;
        }

         
        private double _VКГ;    
        public double get_VКГ()
        {
            return _VКГ = _VКГСО2+ _VКГСО+ _VКГСН4+ _VКГN2+ _VКГН2;
        }

        
                                                 ////ПРИХОДНЫЕ ЧАСТЬ ТЕПЛОВОГО БАЛАНСА
    
        private double _ktpgorkoks;    
        public double get_ktpgorkoks()
        {
            return _ktpgorkoks = _Сф * 9800 * 0.001;
        }

        
        private double _ktpgorkoksprocent;     
        public double get_ktpgorkoksprocent()
        {
            return _ktpgorkoksprocent = 100*(_ktpgorkoks/_SummaPrihodStatei);
        }

        
        private double _TeplO2Dutia;     
        public double get_TeplO2Dutia()
        {
            return _TeplO2Dutia = 1.2897+0.000121* _TempGorDutia;
        }

        
        private double _TeplN2Dutia;     
        public double get_TeplN2Dutia()
        {
            return _TeplN2Dutia = 1.2897 + 0.000121 * _TempGorDutia;
        }
        
        private double _TeplH2OinDutia;    
        public double get_TeplH2OinDutia()
        {
            return _TeplH2OinDutia = 1.456 + 0.000282 *_TempGorDutia;
        }
 
        private double _KolTeplotaotNagretDutia;     
        public double get_KolTeplotaotNagretDutia()
        {
            return _KolTeplotaotNagretDutia = (0.001* _Qд)*((0.01 *_SodKislorodinDutia* _TeplO2Dutia+(1-0.01 * _SodKislorodinDutia)* _TeplN2Dutia)*(1-0.00124* _VlajnostiDutia)+0.00124* _VlajnostiDutia* _TeplH2OinDutia)* _TempGorDutia;
        }

         
        private double _KolTeplotaotNagretDutiaprocent;     
        public double get_KolTeplotaotNagretDutiaprocent()
        {
            return _KolTeplotaotNagretDutiaprocent = 100*(_KolTeplotaotNagretDutia/ _SummaPrihodStatei);
        }
        
        private double _KolTeplotaotKonvers;     
        public double get_KolTeplotaotKonvers()
        {
            return _KolTeplotaotKonvers = 0.001* _UdelnRashodPrirodGaza*(0.01*(1657* _SostavCH4+6046* _SostavC2H6-12644*_SostavCO2));
        }

        
        private double _KolTeplotaotKonversprocent;     
        public double get_KolTeplotaotKonversprocent()
        {
            return _KolTeplotaotKonversprocent = 100*(_KolTeplotaotKonvers/_SummaPrihodStatei);
        }

        
        private double _KolTeplotaotSHLAKA;    
        public double get_KolTeplotaotSHLAKA()
        {
            return _KolTeplotaotSHLAKA = 1128*0.00001* _UdelnRaschIzvest*_PoteryaMasPriProkal;
        }

        
        private double _KolTeplotaotSHLAKAprocent;     
        public double get_KolTeplotaotSHLAKAprocent()
        {
            return _KolTeplotaotSHLAKAprocent = 100*(_KolTeplotaotSHLAKA/_SummaPrihodStatei);
        }
 
        private double _SummaPrihodStatei;     
        public double get_SummaPrihodStatei()
        {
            return _SummaPrihodStatei = _ktpgorkoks+ _KolTeplotaotNagretDutia+ _KolTeplotaotKonvers+ _KolTeplotaotSHLAKA;
        }
        
        private double _SummaPrihodStateiprocent;     
        public double get_SummaPrihodStateiprocent()
        {
            return _SummaPrihodStateiprocent = _ktpgorkoksprocent+ _KolTeplotaotNagretDutiaprocent+ _KolTeplotaotKonversprocent+ _KolTeplotaotSHLAKAprocent;
        }

                                       //РАСХОДНЫЕ СТАТЬИ ТЕПЛОВОГО БАЛАНСА  
   
        private double _RashodTeplanaPryamoeVosstFeO;
        public double get_RashodTeplanaPryamoeVosstFeO()
        {
            return _RashodTeplanaPryamoeVosstFeO = 0.01* _Fe* _StepenPryamVosstanov*2716;
        }

        private double _RashodTeplanaPryamoeVosstFeOprocent;
        public double get_RashodTeplanaPryamoeVosstFeOprocent()
        {
            return _RashodTeplanaPryamoeVosstFeOprocent =100*( _RashodTeplanaPryamoeVosstFeO / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplanaPryamoeVosstChugun;
        public double get_RashodTeplanaPryamoeVosstChugun()
        {
            return _RashodTeplanaPryamoeVosstChugun = 0.01*(5220* _SoderjElementinChugunMn+22600*_SoderjElementinChugunSi+15490* _SoderjElementinChugunP+36167* _SoderjElementinChugunTi+7982* SoderjElementinChugunV);
        }

        private double _RashodTeplanaPryamoeVosstChugunprocent;
        public double get_RashodTeplanaPryamoeVosstChugunprocent()
        {
            return _RashodTeplanaPryamoeVosstChugunprocent = 100*(_RashodTeplanaPryamoeVosstChugun / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplanaDesfularaz;
        public double get_RashodTeplanaDesfularaz()
        {
            return _RashodTeplanaDesfularaz = 1734*0.00001* _UdelnVychodShlaka* _SoderjSinShlak;
        }

        private double _RashodTeplanaDesfularazprocent;
        public double get_RashodTeplanaDesfularazprocent()
        {
            return _RashodTeplanaDesfularazprocent =100*(_RashodTeplanaDesfularaz / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplanaVosstVodorodom;
        public double get_RashodTeplanaVosstVodorodom()
        {
            return _RashodTeplanaVosstVodorodom = 1731 * 0.0001*(0.00124* _VlajnostiDutia*_Qд+0.01* _UdelnRashodPrirodGaza*(2* _SostavCH4+3* _SostavC2H6))* _nH2;
        }

        private double _RashodTeplanaVosstVodorodomprocent;
        public double get_RashodTeplanaVosstVodorodomprocent()
        {
            return _RashodTeplanaVosstVodorodomprocent = 100*(_RashodTeplanaVosstVodorodom / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplananAGREVjIDCHUGUN;
        public double get_RashodTeplananAGREVjIDCHUGUN()
        {
            return _RashodTeplananAGREVjIDCHUGUN = _TmpChugun* _TeploEmkChugun;
        }

        private double _RashodTeplananAGREVjIDCHUGUNprocent;
        public double get_RashodTeplananAGREVjIDCHUGUNprocent()
        {
            return _RashodTeplananAGREVjIDCHUGUNprocent = 100*(_RashodTeplananAGREVjIDCHUGUN / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplananAGREVjIDSHLAKA;
        public double get_RashodTeplananAGREVjIDSHLAKA()
        {
            return _RashodTeplananAGREVjIDSHLAKA = 0.001* _UdelnVychodShlaka* _TeploemkostShlaka*(_TmpChugun+50);     
        }

        private double _RashodTeplananAGREVjIDSHLAKAprocent;
        public double get_RashodTeplananAGREVjIDSHLAKAprocent()
        {
            return _RashodTeplananAGREVjIDSHLAKAprocent =100*( _RashodTeplananAGREVjIDSHLAKA / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplanaRazlojenieVlAGIDUTIA;
        public double get_RashodTeplanaRazlojenieVlAGIDUTIA()
        {
            return _RashodTeplanaRazlojenieVlAGIDUTIA = 1.24 * 0.0000001*6912* _Qд* _VlajnostiDutia;
        }

        private double _RashodTeplanaRazlojenieVlAGIDUTIAprocent;
        public double get_RashodTeplanaRazlojenieVlAGIDUTIAprocent()
        {
            return _RashodTeplanaRazlojenieVlAGIDUTIAprocent =100*( _RashodTeplanaRazlojenieVlAGIDUTIA / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplanaRazlojenieIZVEST;
        public double get_RashodTeplanaRazlojenieIZVEST()
        {
            return _RashodTeplanaRazlojenieIZVEST = 4042 * 0.000001* _UdelnRaschIzvest* _PoteryaMasPriProkal;
        }

        private double _RashodTeplanaRazlojenieIZVESTprocent;
        public double get_RashodTeplanaRazlojenieIZVESTprocent()
        {
            return _RashodTeplanaRazlojenieIZVESTprocent =100*( _RashodTeplanaRazlojenieIZVEST / _SUMMARASHODSTATEI);
        }

        private double _RashodTeplanaRazlojenieVLAGISHICHTY;
        public double get_RashodTeplanaRazlojenieVLAGISHICHTY()
        {
            return _RashodTeplanaRazlojenieVLAGISHICHTY =2452*0.00001* ((_UdelnyJRM* _SoderjVlagiinJRM)+ (_UdelnRaschIzvest* _SoderjVlagiIzvest)+ (_UdelnRashodKoksa* _VlagaKoksa));
        }

        private double _RashodTeplanaRazlojenieVLAGISHICHTYprocent;
        public double get_RashodTeplanaRazlojenieVLAGISHICHTYprocent()
        {
            return _RashodTeplanaRazlojenieVLAGISHICHTYprocent =100*( _RashodTeplanaRazlojenieVLAGISHICHTY / _SUMMARASHODSTATEI);
        }

        private double _TeploemCOpriTempKoloshGAZA;
        public double get_TeploemCOpriTempKoloshGAZA()
        {
            return _TeploemCOpriTempKoloshGAZA = 1.2938 + 0.0000895 * _TempKoloshnikGAz;
        }

        private double _TeploemCO2priTempKoloshGAZA;
        public double get_TeploemCO2priTempKoloshGAZA()
        {
            return _TeploemCO2priTempKoloshGAZA = 1.6448 + 0.0007065 * _TempKoloshnikGAz;
        }

        private double _TeploemH2OpriTempKoloshGAZA;
        public double get_TeploemH2OpriTempKoloshGAZA()
        {
            return _TeploemH2OpriTempKoloshGAZA = 1.4743 + 0.0002205 * _TempKoloshnikGAz;
        }

        private double _TeploemN2priTempKoloshGAZA;
        public double get_TeploemN2priTempKoloshGAZA()
        {
            return _TeploemN2priTempKoloshGAZA = 1.308 ;
        }

        private double _TeploemH2priTempKoloshGAZA;
        public double get_TeploemH2priTempKoloshGAZA()
        {
            return _TeploemH2priTempKoloshGAZA = 1.3012 ;
        }

        private double _RashodTeplaUnosimyiKoloshnikovymGazom;
        public double get_RashodTeplaUnosimyiKoloshnikovymGazom()
        {
            return _RashodTeplaUnosimyiKoloshnikovymGazom = 0.00001 * ((_SoderjCO2KoloshGaz* _TeploemCO2priTempKoloshGAZA+ _SoderjCOKoloshGaz* _TeploemCOpriTempKoloshGAZA+ _SoderjN2KoloshGaz* _TeploemN2priTempKoloshGAZA+ _TeploemH2priTempKoloshGAZA* _SoderjH2KoloshGaz)*_VКГ+(_UdelnyJRM* _SoderjVlagiinJRM+ _UdelnRaschIzvest* _SoderjVlagiIzvest+ _UdelnRashodKoksa* _VlagaKoksa+ _VКГ* _SoderjH2KoloshGaz* _nH2/(1- _nH2))* _TeploemH2OpriTempKoloshGAZA)* _TempKoloshnikGAz;
        }

        private double _RashodTeplaUnosimyiKoloshnikovymGazomprocent;
        public double get_RashodTeplaUnosimyiKoloshnikovymGazomprocent()
        {
            return _RashodTeplaUnosimyiKoloshnikovymGazomprocent =100*( _RashodTeplaUnosimyiKoloshnikovymGazom / _SUMMARASHODSTATEI);
        }

        private double _TeploPoteriDomenn;
        public double get_TeploPoteriDomenn()
        {
            return _TeploPoteriDomenn = _SummaPrihodStatei-(_RashodTeplanaPryamoeVosstFeO + _RashodTeplaUnosimyiKoloshnikovymGazom+ _RashodTeplanaRazlojenieIZVEST + _RashodTeplanaRazlojenieVLAGISHICHTY+ _RashodTeplanaRazlojenieVlAGIDUTIA + _RashodTeplananAGREVjIDSHLAKA + _RashodTeplananAGREVjIDCHUGUN + _RashodTeplanaPryamoeVosstChugun + _RashodTeplanaDesfularaz+ _RashodTeplanaVosstVodorodom);
        }

        private double _TeploPoteriDomennprocent;
        public double get_TeploPoteriDomennprocent()
        {
            return _TeploPoteriDomennprocent = 100*(_TeploPoteriDomenn / _SUMMARASHODSTATEI);
        }

        private double _SUMMARASHODSTATEI;
        public double get_SUMMARASHODSTATEI()
        {
            return _SUMMARASHODSTATEI = _TeploPoteriDomenn+_RashodTeplanaPryamoeVosstFeO + _RashodTeplaUnosimyiKoloshnikovymGazom + _RashodTeplanaRazlojenieIZVEST + _RashodTeplanaRazlojenieVLAGISHICHTY + _RashodTeplanaRazlojenieVlAGIDUTIA + _RashodTeplananAGREVjIDSHLAKA + _RashodTeplananAGREVjIDCHUGUN + _RashodTeplanaPryamoeVosstChugun + _RashodTeplanaDesfularaz + _RashodTeplanaVosstVodorodom;
        }

        private double _SUMMARASHODSTATEIprocent;
        public double get_SUMMARASHODSTATEIprocent()
        {
            return _SUMMARASHODSTATEIprocent =_RashodTeplananAGREVjIDCHUGUNprocent+_RashodTeplanaVosstVodorodomprocent + _RashodTeplanaDesfularazprocent + _TeploPoteriDomennprocent + _RashodTeplaUnosimyiKoloshnikovymGazomprocent + _RashodTeplanaRazlojenieVLAGISHICHTYprocent + _RashodTeplanaRazlojenieIZVESTprocent + _RashodTeplanaRazlojenieVlAGIDUTIAprocent + _RashodTeplananAGREVjIDSHLAKAprocent + _RashodTeplanaPryamoeVosstChugunprocent + _RashodTeplanaPryamoeVosstFeOprocent;
        }


                                       ////ВЛИЯНИЕ РАЗЛИЧНЫХ ФАКТОРОВ НА СТАТЬИ ТЕПЛОВОГО БАЛАНСА


        private double _Qпромежут;
        public double get_Qпромежут()
        {
            return _Qпромежут = _ktpgorkoks+ _KolTeplotaotNagretDutia- _RashodTeplaUnosimyiKoloshnikovymGazom;
        }

        private double _QпромежутkkolC;
        public double get_QпромежутkkolC()
        {
            return _QпромежутkkolC =_Qпромежут/(_Сф*0.001);
        }

        private double _Ck;
        public double get_Ck()
        {
            return _Ck = 100- _ZolaKoksa- _SeraKoksa- _LetuchKoksa- _VlagaKoksa;
        }

        private double _SNiJENIESTATIIRASHODATEPLAPRIUMENrd;
        public double get_SNiJENIESTATIIRASHODATEPLAPRIUMENrd()
        {
            return _SNiJENIESTATIIRASHODATEPLAPRIUMENrd =0.01*_RashodTeplanaPryamoeVosstFeO/ _StepenPryamVosstanov;
        }

        private double _EKVIVALENTSNIJ1;
        public double get_EKVIVALENTSNIJ1()
        {
            return _EKVIVALENTSNIJ1 =(_SNiJENIESTATIIRASHODATEPLAPRIUMENrd*1000)/(0.01* _Ck* _QпромежутkkolC);
        }

        private double _PRIROSTSTATIIPRITOKATEPLA;
        public double get_PRIROSTSTATIIPRITOKATEPLA()
        {
            return _PRIROSTSTATIIPRITOKATEPLA = _KolTeplotaotNagretDutia/_TempGorDutia*10;
        }

        private double _ECONOMYKOKSPRIPOVYSH;
        public double get_ECONOMYKOKSPRIPOVYSH()
        {
            return _ECONOMYKOKSPRIPOVYSH = (_PRIROSTSTATIIPRITOKATEPLA * 1000) / (0.01 * _Ck * _QпромежутkkolC);
        }

        private double _PRIROSTOTKONVERSPG;
        public double get_PRIROSTOTKONVERSPG()
        {
            return _PRIROSTOTKONVERSPG = _KolTeplotaotKonvers /_UdelnRashodPrirodGaza*10;
        }

        private double _ECONOMYKOKSPRIPOVYSHNA10;
        public double get_ECONOMYKOKSPRIPOVYSHNA10()
        {
            return _ECONOMYKOKSPRIPOVYSHNA10 = (_PRIROSTOTKONVERSPG * 1000) / (0.01 * _Ck * _QпромежутkkolC);
        }

        private double _RAZLOJVLAGIDUTIA;
        public double get_RAZLOJVLAGIDUTIA()
        {
            return _RAZLOJVLAGIDUTIA = _RashodTeplanaRazlojenieVlAGIDUTIA/ _VlajnostiDutia;
        }

        private double _ECONOMYKOKSPRIPOVYSHNA1;
        public double get_ECONOMYKOKSPRIPOVYSHNA1()
        {
            return _ECONOMYKOKSPRIPOVYSHNA1 = (_RAZLOJVLAGIDUTIA * 1000) / (0.01 * _Ck * _QпромежутkkolC);
        }

        private double _economyteplaprisnijvyhodashlaka;
        public double get_economyteplaprisnijvyhodashlaka()
        {
            return _economyteplaprisnijvyhodashlaka = _RashodTeplananAGREVjIDSHLAKA /_UdelnVychodShlaka*10;
        }

        private double _economykoksaprisnijvyhodashlaka;
        public double get_economykoksaprisnijvyhodashlaka()
        {
            return _economykoksaprisnijvyhodashlaka = (_economyteplaprisnijvyhodashlaka * 1000) / (0.01 * _Ck * _QпромежутkkolC);
        }

        private double _economyteplapriteplopoteri;
        public double get_economyteplapriteplopoteri()
        {
            return _economyteplapriteplopoteri = _SummaPrihodStatei / 100;
        }

        private double _ECONOMYKOKSPRIPOVYSHNA2;
        public double get_ECONOMYKOKSPRIPOVYSHNA2()
        {
            return _ECONOMYKOKSPRIPOVYSHNA2 = (_economyteplapriteplopoteri * 1000) / (0.01 * _Ck * _QпромежутkkolC);
        }






    }












}
