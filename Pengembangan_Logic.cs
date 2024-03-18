using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;
using Microsoft.VisualBasic;

namespace Pengembangan_Logic
{
    class Pengembangan_Logic_Basic_cls
    {
        /*
            todo > Toko Buah
            !koko jual tanah
        */

        public interface Toko_Buah
        {
            //bilangan
            public static int[] Banyaknya_Jenis_Buah = new int[2] { 9, 0 }; public static int i, j;
            public static double[,,,] Harga_Buah, Totl_Harga_Buah;
            /*  
                * -> 0] -> 0 = beli , 1 = jual , 2 = Selisih Harga Beli Dan Jual/ Kg or Total 3 = Selisih Persen Harga Beli Dan Jual/ Kg
                *->  1] -> i = Jenis_Buah/Banyaknya_Jenis_Buah[0]
            */
            public static double[,] Penjualan;

            public static double[] Laba;
            //* Laba : 0 = Kotor , 1 = Bersih
            public static double[,,,] Besaran_Berat;//* -> 0 = Kg ,  
            //enum Jenis_Buah {pl = 0};
            public static string[,] Jenis_Buah, Jenis_Buah_1;
            public interface Input
            {
                public static void Input_Produk()
                {
                    do
                    {
                        System.Console.WriteLine("Jumlah Jenis Buah");
                        System.Console.WriteLine("-------------------------------");
                        System.Console.Write("Masukkan Banyaknya Jenis Buah : ");
                        Banyaknya_Jenis_Buah[0] = Convert.ToInt32(Console.ReadLine());
                    } while (Banyaknya_Jenis_Buah[0] == null);

                    System.Console.WriteLine("-------------------------------");
                    Jenis_Buah = new string[1, Banyaknya_Jenis_Buah[0]]; Jenis_Buah_1 = new string[Banyaknya_Jenis_Buah[0], Banyaknya_Jenis_Buah[1]];
                    //int[] itemem = new int[Banyaknya_Jenis_Buah];

                    for (i = Jenis_Buah.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine();
                        System.Console.WriteLine("Jenis Buah");
                        Console.WriteLine("-------------------------------");
                        System.Console.Write("Masukkan Jenis Buah : ");
                        Jenis_Buah[0, i] = Console.ReadLine();
                        System.Console.WriteLine($"Jenis_Buah : " + Jenis_Buah[0, i] + i);
                        Console.WriteLine("-------------------------------");
                        Console.Write($"Masukkan Banyaknya Jenis {Jenis_Buah[0, i]} : ");
                        Banyaknya_Jenis_Buah[1] = Convert.ToInt32(Console.ReadLine());
                        //System.Console.WriteLine( Jenis_Buah_1[i,Banyaknya_Jenis_Buah[1] - 1]);

                    }
                    Jenis_Buah_1 = new string[Banyaknya_Jenis_Buah[0], Banyaknya_Jenis_Buah[1]];
                    Penjualan = new double[2, Banyaknya_Jenis_Buah[0]];
                    Harga_Buah = new double[4, Banyaknya_Jenis_Buah[0], Banyaknya_Jenis_Buah[1], Banyaknya_Jenis_Buah[1]];
                    Totl_Harga_Buah = new double[3, Banyaknya_Jenis_Buah[0], Banyaknya_Jenis_Buah[1], Banyaknya_Jenis_Buah[1]];
                    
                    Besaran_Berat = new double[2, Banyaknya_Jenis_Buah[0], Banyaknya_Jenis_Buah[1], Banyaknya_Jenis_Buah[1]];
                    for (i = Banyaknya_Jenis_Buah[0] - 1; i >= 0; i--)
                    {
                        System.Console.WriteLine();
                        Console.WriteLine($"Jenis {Jenis_Buah[0, i]}");
                        for (j = Banyaknya_Jenis_Buah[1] - 1; j >= 0; j--)
                        {
                            Console.WriteLine("-------------------------------");
                            Console.Write($"Masukkan Jenis {Jenis_Buah[0, i]} : ");
                            Jenis_Buah_1[i, j] = Console.ReadLine();
                            Console.WriteLine($"Jenis {Jenis_Buah[0, i]} : {Jenis_Buah_1[i, j]}");
                            Console.WriteLine("-------------------------------");
                            Console.Write($"Masukkan Banyaknya Kg {Jenis_Buah[0, i]} {Jenis_Buah_1[i, j]} : ");

                            Besaran_Berat[0, i, j, j] = Convert.ToDouble(Console.ReadLine());
                            Console.Write($"Masukkan Harga Beli {Jenis_Buah[0, i]} {Jenis_Buah_1[i, j]}/Kg : ");
                            Harga_Buah[0, i, j, j] = Convert.ToDouble(Console.ReadLine());

                            Console.Write($"Masukkan Harga Jual {Jenis_Buah[0, i]} {Jenis_Buah_1[i, j]}/Kg : ");
                            Harga_Buah[1, i, j, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    System.Console.Write("");
                }
            }

            public interface Proses
            {
                public static void Proses_Produk()
                {
                    //
                    for (i = Banyaknya_Jenis_Buah[0] - 1; i >= 0; i--)
                    {
                        for (j = Banyaknya_Jenis_Buah[1] - 1; j >= 0; j--)
                        {
                            Harga_Buah[2, i, j, j] = Harga_Buah[0, i, j, j] - Harga_Buah[1, i, j, j];
                            Harga_Buah[3, i, j, j] = Harga_Buah[1, i, j, j] - Harga_Buah[0, i, j, j];
                            Totl_Harga_Buah[0, i, j, j] = Harga_Buah[0, i, j, j] * Besaran_Berat[0, i, j, j];
                            Totl_Harga_Buah[1, i, j, j] = Harga_Buah[1, i, j, j] * Besaran_Berat[0, i, j, j];
                            Penjualan[0, i] = Penjualan[0, i] + Totl_Harga_Buah[1, i, j, j];
                        }
                        System.Console.WriteLine($"Keseluruhan uang yang didapat jika terjual semua : {Penjualan[0, i]}");
                    }
                }
                public static double[] Proses_Laba_Kotor(params double[] kebutuhan)
                {
                    
                    double[] o = new double[1];
                    for (i = Banyaknya_Jenis_Buah[0] - 1; i >= 0; i--)
                    {
                        Console.Write("Masukkan nilai keuntungan dalam 1 bulan : ");
                        Penjualan[0, i] = Convert.ToDouble(Console.ReadLine());

                        foreach (var item in kebutuhan)// = item = kebutuhan
                        {
                            Penjualan[0, i] -= item;
                            o[0] = Penjualan[0, i];
                        }
                    }
                    return o.ToArray();
                }
                public static double[] Proses_Laba_Bersih(params double[] Biaya_Operasional)//1. *Biaya Operasional  2. *Biaya Depresiasi dan Amortisasi 3.Pajak
                {
                    double[] o = new double[1];
                    
                    for (i = Banyaknya_Jenis_Buah[0] - 1; i >= 0; i--)
                    {
                        Console.Write("Masukkan nilai keuntungan dalam 1 bulan : ");
                        Penjualan[0, i] = Convert.ToDouble(Console.ReadLine());

                        foreach (var item in Biaya_Operasional)// = item = kebutuhan
                        {
                            Penjualan[0, i] -= item;
                            o[0] = Penjualan[0, i];
                        }
                    }
                    return new double[2]{2,o[0]};
                    //return o.ToArray().ToArray();
                   

                    /*
                        Biaya Depresiasi dan Amortisasi:

                        Biaya depresiasi (pengurangan nilai aset tetap seperti gedung, peralatan, kendaraan).
                        Biaya amortisasi (pengurangan nilai aset tak berwujud seperti hak paten, merek dagang).
                        Biaya Bunga:

                        Biaya bunga atas hutang yang harus dibayarkan kepada pihak lain.

                        1. *Biaya Operasional:*
                        - Biaya gaji karyawan.
                        - Biaya sewa tempat usaha atau fasilitas.
                        - Biaya utilitas (listrik, air, gas).
                        - Biaya bahan atau produk yang dijual.
                        - Biaya transportasi.
                        - Biaya pemasaran dan promosi.
                        - Biaya administrasi.
                        - Biaya asuransi.

                        2. *Biaya Depresiasi dan Amortisasi:*
                        - Biaya depresiasi (pengurangan nilai aset tetap seperti gedung, peralatan, kendaraan).
                        - Biaya amortisasi (pengurangan nilai aset tak berwujud seperti hak paten, merek dagang).

                        3. *Biaya Bunga:*
                        - Biaya bunga atas hutang yang harus dibayarkan kepada pihak lain
                    */
                }
            }
        }

    }
    class Pengembangan_Logic_ctor_cls
    {

        public Pengembangan_Logic_ctor_cls()
        {

        }
    }

    interface Pengembangan_Logic
    {

    }

}