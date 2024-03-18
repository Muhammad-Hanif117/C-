using System;
using System.Diagnostics;
using Pengembangan_Logic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using Microsoft.VisualBasic;
using static Pengembangan_Logic.Pengembangan_Logic_Basic_cls.Toko_Buah;

class Proges
{
    public static int Detector = 1, Ok = 5;

    interface interface_
    {
        public static void ios (object ou)
        {
            object okpk;
            System.Console.WriteLine(ou);
           // ou += (int)Convert.ChangeType(ou,typeof(int)); //+  Convert.ChangeType(9,typeof(object));
        }
        
        public static int c;
        public int Fixed(int[] x);
        public static interface_ Maxim(int s)
        {
            var a = s;
            return null;
        }
    }

    class Prog_1 : Pengembangan_Logic_Basic_cls
    {
        public static double[] a = new double[2] { 2, 2 },c,f,f1;
        public static object yo = 1.0;
        /*public static T pppp;
        public static object ppppp;*/

        /*public static T iot <T>(object ou)
        {
            return ou;
        }*/

        public delegate int Sikit_Sikit_Wiko_Sikit_Sikit_Waimo(int Yowaimo);
        
        public static object oi(Action<object> print, int mn,Sikit_Sikit_Wiko_Sikit_Sikit_Waimo Sikit_Sikit_Wiko_Sikit_Sikit_Waimo)
        {
            //Sikit_Sikit_Wiko_Sikit_Sikit_Waimo(9);
            //var ppp = "";
            //object pp;
            print(mn);
            //mn = Sikit_Sikit_Wiko_Sikit_Sikit_Waimo;
            return Sikit_Sikit_Wiko_Sikit_Sikit_Waimo(mn);
            //return 0;
        }

        /*public static object Max_Math<T>(T maxim,params object[] max)
        {   for (int i = 0; i < max.Length; i++)
            {
            if((decimal)Convert.ChangeType(maxim,typeof(decimal)) < (decimal)Convert.ChangeType(max[i],typeof(decimal)))
            {
                
                    maxim = (T)Convert.ChangeType(max[i],typeof(T));
            }
            else
            {
                maxim = maxim;
            }}
            return (T)Convert.ChangeType(maxim,typeof(T));
            
            //? maxim = (T)Convert.ChangeType(max,typeof(decimal)) : max = (object)Convert.ChangeType(max,typeof(decimal)),typeof(object));
        }*/

        public static object Pangkat_Brooo(object nilai,object value)
        {
            for (int i = Convert.ToInt32(value); i >= 1 ; i--)
            {
                nilai = Convert.ToDecimal(nilai) *  Convert.ToDecimal(nilai);
            }
            return Convert.ToDecimal(nilai);
        }

        public static object Max_Math(params object[] max)
        {
            for (int i = 0; i < max.Length; i++)
            {
                if ((decimal)Convert.ChangeType(max[i + 1], typeof(decimal)) > (decimal)Convert.ChangeType(max[i], typeof(decimal)))
                {

                    max[i] = (decimal)Convert.ChangeType(max[i + 1], typeof(decimal));
                    //return (object)Convert.ChangeType(max[i], typeof(decimal));
                }
                else
                {
                    //return (object)Convert.ChangeType(max[i], typeof(decimal));
                }

            }
            return max;

            //? maxim = (T)Convert.ChangeType(max,typeof(decimal)) : max = (object)Convert.ChangeType(max,typeof(decimal)),typeof(object));
        }

        
        public static int squer(int input) => input * input;
        public delegate int juju(int valup);
        //juju jii = 9(9);
        
        public static void Main()
        {   try
            {
            object ooll;
            Sikit_Sikit_Wiko_Sikit_Sikit_Waimo oio = squer;
            var poi = oi(interface_.ios,2,(x) => x*x);//oi(System.Console.WriteLine,9);// Max_Math(0,9,99,999);
            //object kp = Convert.ChangeType(lpl,typeof(object));
            System.Console.WriteLine(poi);
            Console.WriteLine("Penghitungan Laba Kotor\n-------------------------------------");
            Console.WriteLine("Hal - hal umum yang harus dimasukkan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1.Biaya Bahan Baku\n2.Biaya Tenaga Kerja Langsung\n3.Biaya Overhead Langsung\n4.dll");//Masukkan Sendiri
            Console.Write("Masukkan Banyaknya Biaya: ");
            c = new double[Convert.ToInt32(Console.ReadLine())];
           
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write($"Masukkan biaya ke {i+1} : ");
                c[i] = Convert.ToDouble(Console.ReadLine());
            }
            Input.Input_Produk();
            //Proses.Proses_Produk();
            /*foreach (var item in Proses.Proses_Laba_Kotor(c))
            {
                System.Console.WriteLine($"{item}");
            }*/
            Console.WriteLine();
            Console.WriteLine("Penghitungan Laba Bersih\n-------------------------------------");
            Console.WriteLine("Hal - hal umum yang harus dimasukkan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1.Biaya Operasional\n2.Biaya Depresiasi dan Amortisasi\n3.Pajak\n4.dll");//Masukkan Sendiri
            //System.Console.WriteLine("Informasi\nPajak Harus Dimasukkan Dalam Rasio Persen");
            Console.Write("Masukkan Var Banyaknya Biaya: ");
            int op = Convert.ToInt32(Console.ReadLine());
            f = new double[op];
            
            for (int i = 0; i < op; i++)
            {
                Console.Write("Masukkan Banyaknya Biaya: ");
                f1 = new double[Convert.ToInt32(Console.ReadLine())];
                for (int j = 0; j < f1.Length; j++)
                {
                    System.Console.Write(":");
                    f1[j] +=  Convert.ToDouble(Console.ReadLine());
                }
                //f[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine(Proses.Proses_Laba_Bersih(f1));//0. *Biaya Operasional  1. *Biaya Depresiasi dan Amortisasi 2.Pajak


            //interface_.Maxim(9);   
            //int[] kj={0,0};
            //int j = Fixed(kj);
            //var lj = 9;
            //System.Console.WriteLine(j);

            //learn_why(System.Console.Write);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        /*
         !private static void Proses_Produk()
         !{
         !    throw new NotImplementedException();
         !}
         */
        public static int Fixed(int[] x)
        {
            int totl = x[0];
            foreach (int xs in x)
            {
                if (xs == x[0]) { x[0] = x[1]; }
                System.Console.WriteLine(x[1]);
                if (x[0] == x[1]) { totl /= x[0]; }
                else
                {
                    totl /= xs;
                }
            }

            return totl;
        }
    }

    static void kl()
    {
        //int ko = Max(1,2);
        //Data();
        //M();
        /*Random random = new Random();//Random.Shared.NextDouble()
        Prog_1 prog = new Prog_1();
        
        //prog.Fixed(Update());
        Console.Write("Masukkan Nama : ");
        int ss;
        Num_Program num;
        Console.Read(num);
        //num = Console.ReadKey();

        switch (num)
        {
            case Num_Program.Minggu : System.Console.WriteLine("Libur");
            break;
            default: System.Console.WriteLine("Masuk");
            break;
        }*/
    }

    public static void Max<T>(T max, T mx)
    {
        string ik = max.GetType().ToString().Substring(7, 3);
        //if(ik == "Int"){return (Convert.ToInt32(max) > Convert.ToInt32(mx)) ? : max = mx;}
        if (Convert.ToInt32(max) > Convert.ToInt32(mx) && ik == "Int") { mx = max; }
        if (Convert.ToInt32(max) < Convert.ToInt32(mx) && ik == "Int") { max = mx; }
        //System.Console.WriteLine(mx);
    }

    public static void M()
    {
        String[] pilihan = { "Ada", "Dua" }, kosong; int US = 27, Detec = 0;//char chars[] = "Aku";

        String a, Perubahan = "";
        //double duble = (double)ass;
        // Math.Sqrt() -> Akar

        Console.Write("Masukkan Nama : ");
        a = Console.ReadLine();
        kosong = new string[a.Length];

        //kosong[0] = a.Substring(2,3);

        //System.Console.WriteLine(kosong[0]);
        //ass = a.Length;
        for (int i = 0; i < kosong.Length; i++)
        {
            kosong[i] = a.Substring(i, 1);
            /*if(kosong[i] == " ")
            {kosong[i] = kosong[i].Replace(" ","1");
            System.Console.WriteLine(kosong[i]);}
            //System.Console.WriteLine(Detec);*/
        }

        for (int s = 0; s < kosong.Length; s++)
        {
            Detec++;
            if (kosong[s] == " " && kosong[s - 1] == " ")
            { kosong[s] = kosong[s].Replace(" ", " "); kosong[s - 1] = kosong[s - 1].Replace(" ", ""); }

            /*if(kosong[s] != " " && kosong[s-1] != " " &&  kosong[s-2] == " " &&  kosong[s-3] == " " && kosong[s-4] == "" && Detec > 4)
            {kosong[s-2] = kosong[s-2].Replace(" ",""); Detec = 0;}*/
        }

        /*for (int s1 = 0; s1 < kosong.Length; s1++)
        {
            Detec ++;
            if(kosong[s1] == " " && kosong[s1-1] == " " && Detec > 2)
            {kosong[s1] = kosong[s1].Replace(" ",""); kosong[s1-1] = kosong[s1 - 1].Replace(" ",""); kosong[s1-2] = kosong[s1 -2].Replace(" ",""); Detec = 0; }
        }*/

        for (int m = 0; m < kosong.Length; m++)
        {
            Perubahan = Perubahan + kosong[m]; System.Console.Write(kosong[m]);
        }

        if (Perubahan.Length < 12)
        { Console.Write("\nAnda Lolos"); }

        //Console.Write(a);

        //ass = M
        //Console.ReadKey();

        //Num_Program.Senin = Console.Read();

        //do {Console.Write("Plihan Anda : ");ass = Convert.ToInt32(Console.ReadLine());} while(ass == 0);
    }

    enum Num_Program { Senin = 1, Selasa = 2, Rabu = 3, Kamis = 4, Jumat = 5, Sabtu = 6, Minggu = 7 };
}
