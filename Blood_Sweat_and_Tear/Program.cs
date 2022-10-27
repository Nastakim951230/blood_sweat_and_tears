using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public double Sinus(double x)
        {
            Program program = new Program();
            double sin2 = ((1 - Math.Cos(2 * x)) / 2);
            //double sin2 = program.ZaglushkaCos();
            if (x <= 90)
            {
                return -Math.Sqrt(sin2);
            }
            else if (x > 90 && x <= 180)
            {
                return Math.Sqrt(sin2);
            }
            else if (x > 180 && x <= 270)
            {
                return -Math.Sqrt(sin2);
            }
            else if (x > 270 && x <= 360)
            {
                return Math.Sqrt(sin2);
            }
            else
            {
                return 0;
            }
        }
        public double Cosinus(double x)
        {
            Program program = new Program();
            double cos2 = 1 - Math.Pow(Sinus(x), 2);
            //double cos2 = program.ZaglushkaCos();
            if (x <= 90)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 90 && x <= 180)
            {
                return -Math.Sqrt(cos2);
            }
            else if (x > 180 && x <= 270)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 270 && x <= 360)
            {
                return -Math.Sqrt(cos2);
            }
            else
            {
                return 0;
            }

        }

        public double Logarifm_Natural(double x)
        {
            Program program = new Program();
            double ln2 = Math.Log(x) / Math.Log(Math.E);
            //double ln2 = program.ZaglushkaLn();
            return ln2;
        }
        public double Logorifm(double ocn, double x)
        {
            {
                Program program = new Program();
                double stepen = 0.1;
                while (Math.Pow(ocn, stepen) <= x)
                    stepen += 0.001;
                //double stepen = program.ZaglushkaLon();
                return stepen;
            }
        }

        public double SinCos(double x)
        {
            Program program = new Program();
            double rez;
            rez = (Math.Pow(((program.Sinus(x) + program.Cosinus(x)) + program.Cosinus(x)), 2));
            //rez = (Math.Pow(((program.ZaglushkaSin() + program.ZaglushkaCos()) + program.ZaglushkaCos()), 2));
            return rez;

        }
        public int ZaglushkaCosSin()
        {
            return 1;
        }
        public int ZaglushkaLnLog()
        {
            return 0;
        }
        public int ZaglushkaSin()
        {
            return 0;
        }
        public int ZaglushkaCos()
        {
            return 1;
        }
        public int ZaglushkaLon()
        {
            return 0;
        }
        public int ZaglushkaLn()
        {
            return 1;
        }
        public double LogLn(double x)
        {
            Program program = new Program();
            double rez;
            rez = (program.Logarifm_Natural(x) * program.Logorifm(5, x));
            //rez = (program.ZaglushkaLn() * program.ZaglushkaLon());
            return rez;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Program program = new Program();
                double rez = 0;

                //Можно удалить, сделано для проверки
                //Console.WriteLine($"Cos={program.Cosinus(x)}, Sin={program.Sinus(x)}, ln={program.Logarifm_Natural(x)}, log5={program.Logorifm(5,x)}");

                if (x <= 0)
                {
                    rez = program.SinCos(x);
                    //rez = program.ZaglushkaCosSin();
                    Console.WriteLine("(((sin({0})+cos({0}))+cos({0}))^2) = {1}", x, rez);
                }
                else
                {
                    rez = program.LogLn(x);
                    //rez = program.ZaglushkaLnLog();
                    Console.WriteLine("(ln({0})*log5({0})) = {1}", x, rez);
                }

            }
            catch
            {
                Console.WriteLine("Ошибка, введите значение занова");
            }
        }
    }
}

