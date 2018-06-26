using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_260618
{
    class Program
    {
        static string emex = "{'Details':[{'GroupId':-479,'PriceGroup':5,'MakeLogo':'94','MakeName':'autoSFEC','DetailNum':'AK001876','NewDetailNum':null,'DetailNameRus':'Опора  амортизатора','PriceLogo':'LONS','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':50,'DDPercent':42.0,'ADDays':11,'DeliverTimeGuaranteed':11,'ResultPrice':456.070000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'*Ч','MakeName':'Profit','DetailNum':'23140021','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТ. AUDI 100 AVANT 90-94 FRONT (L/R) БЕЗ','PriceLogo':'SMAR','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':2,'DDPercent':98.0,'ADDays':6,'DeliverTimeGuaranteed':6,'ResultPrice':474.360000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'FB','MakeName':'FEBI','DetailNum':'01876','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'SMAR','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':3,'DDPercent':98.0,'ADDays':6,'DeliverTimeGuaranteed':6,'ResultPrice':484.390000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'RU','MakeName':'Ruville','DetailNum':'825711','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'AMTS','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':1,'DDPercent':91.0,'ADDays':11,'DeliverTimeGuaranteed':11,'ResultPrice':1166.430000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'RU','MakeName':'Ruville','DetailNum':'825711','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1319.830000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'FB','MakeName':'FEBI','DetailNum':'01366','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':75.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1702.740000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'18','MakeName':'Vaico','DetailNum':'101209','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':564.630000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'ML','MakeName':'Meyle','DetailNum':'1004120007','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':29.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1204.780000},"
            + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'09','MakeName':'SWAG','DetailNum':'30540009','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1102.120000},"
            + "{'GroupId':-1220,'PriceGroup':5,'MakeLogo':'ML','MakeName':'Meyle','DetailNum':'1004120007','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':29.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1204.780000}"
            + "],'IsSuccess':true,'ErrorMessage':null,'BlockDateEnd':null}";
        static void Main(string[] args)
        {
            emex = emex.Substring(emex.IndexOf('[') + 1, emex.IndexOf(']') - emex.IndexOf('[') - 1);
            string[] Data = emex.TrimEnd('}').Split('}');

            for(int i=0;i<Data.Length;i++)
            {
                string[] Data2 = Data[i].Split(',');
                Console.WriteLine(Data2[4].Trim('\'').Replace("':'",":"));
            }
          

        }

        static void task13()
        {
            // 13.Дано натуральное число n(1 <= n <= 1188), определяющее возраст человека(в месяцах).Выразить возраст в годах и месяцах,
            //например, 21 год 10 месяцев, 52 года 1 месяц, 46 лет ровно и т. п
            Console.WriteLine("Введите год рождения: ");
            int y = 0;
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите корректный год рождения");
            }
            Console.WriteLine("Введите месяц рождения: ");
            int m = 0;
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Введите корректный месяц рождения");
            }
            Console.WriteLine("Введите день рождения: ");
            int d = 0;
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Введите корректный день рождения");
            }
            DateTime dob = new DateTime(y, m, d);
            DateTime now = DateTime.Now;

            double difY = (now.Year - dob.Year);
            double difM = (now.Month - dob.Month);
            double difD = (now.Day - dob.Day);
            Console.WriteLine("{0} год {1} месяцев и {2}", difY, Math.Abs(difM), difD);

            Console.WriteLine("Введите количество месяцев: ");
            int cm = Int32.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddMonths(-cm));
        }

        static void task9(int m = 1, int n = 1)
        {
            /*9.	Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и n (число). По заданным n и m определить:
            a.	дату предыдущего дня (принять, что n и m не характеризуют 1 января);
            b.	дату следующего дня (принять, что n и m не характеризуют 31 декабря).
            */
            DateTime D = new DateTime(DateTime.Now.Year, m, n);
            Console.WriteLine(D);
            Console.WriteLine(D.AddDays(-1));
            Console.WriteLine(D.AddDays(+1));

        }

        static void task8(int n = 1)
        {
            /*8.	С начала 1990 года по некоторый день прошло n месяцев и 2 дня. Определить название месяца (январь, февраль и т. п.) этого дня*/
            DateTime D = new DateTime(1990, 1, 1);
            D = D.AddDays(2).AddMonths(n);
            Console.WriteLine(D);
        }

        enum Weight
        {
            Light = 60,
            Pre_normal = 64,
            Normal
        }
        static void task6()
        {
            /*6.	Известен вес боксера-любителя. Известно, что вес таков, что боксер может быть отнесен к одной из трех весовых категорий: 
                        a.	легкий вес — до 60 кг; 
                        b.	первый полусредний вес — до 64 кг; 
                        c.	полусредний вес — до 69 кг. 
                        */

            int w;
            int.TryParse(Console.ReadLine(), out w);
            if (w <= 60)
            {
                w = 0;
                // Console.WriteLine((Weight)w);//weight[0]
                Console.WriteLine(Weight.Light.ToString());
                Console.WriteLine((int)Weight.Light);//chislo

            }
            else if (w <= 64)
            {
                Console.WriteLine(Weight.Pre_normal.ToString());
                Console.WriteLine("весовая категория до " + (int)Weight.Pre_normal);//chislo

            }
            else if (w <= 69)
            {
                Console.WriteLine(Weight.Normal.ToString());

            }


        }

        static void task1()

        {
            string str = "test";
            if (str == "test")
            {

            }
            else if (str.CompareTo("test") == 0)
            {

            }
            else if (string.CompareOrdinal(str, "test") == 0)
            {

            }

            string str2 = string.Concat("01", "02", "03", str);
            str = "01" + "02" + "03" + str;
        }

    }
}
