//HbTDkA85FifRvD8JN2nFTZtgNUp2M5wbX2s
using System;
class Perusahaan_Manfactur
{
    public static void learn_why(Action<int, string> print)
        {
            Console.Write("Masukkan jumlah murid : ");
            int m = Convert.ToInt32(Console.ReadLine());
            print(9, "");//---
            if (9 == 9)
            {

            }
            //String(Teks)
            string[] no_ujian = new string[m], nama = new string[m], kls = new string[m], jurusan = new string[m];

            int[] min_max = new int[2];
            // max = min_max[0]
            // min = min_max[1]
            string[] nama_min_max = { "[0]", "[1]" };
            // nama_max = nama_min_max[0]
            // nama_min = nama_min_max[1]
            string[] jurusan_min_max = { "[0]", "[1]" };
            // jurusan_max = jurusan_min_max[0]
            // jurusan_min = jurusan_min_max[1]

            //Angka Bilangan bulat ukuran data 32 bit
            int[] n_ul = new int[m], n_uts = new int[m], n_semester = new int[m], n_raport = new int[m];
            /*Jenis-Jenis Bilangan bulat
             *dll
             *Int 32 bit -> Int
             *Int 64 bit -> Long
               |   |
               |    -------- > ukuran data
               ----->Bilangan Bulat
                Convert.Int32 = Ubah ke Int(Bilangan bulat 32bit)
            */

            for (int i = 0; i < m; i++)
            {
                /*Kode_No ujian :  ms01
                                   |  |
                   kode jurusan----    ------ Kode Kelas 01/02/dll
                    /inisial       |  |
                    (m/r/r/dll)    rs02
                                   dll

                */
                Console.WriteLine("=======================================================================================");
                do
                {
                    Console.Write($"Masukan No Ujian[{i + 1}] : ");
                    no_ujian[i] = Console.ReadLine();
                } while (no_ujian[i] == "");

                kls[i] = no_ujian[i].Substring(2, 2) == "01" ? kls[i] = "X" :
                kls[i] = no_ujian[i].Substring(2, 2) == "02" ? kls[i] = "XI" :
                kls[i] = "XII";
                /*  Operator kondisi
                    kls[i] = no_ujian[i].Substring(2,2) == 01 ? kls[i] = "X" :
                    kls[i] = "XI";
                */
                //Switch langsung
                jurusan[i] = no_ujian[i].Substring(0, 1) switch
                {
                    "kl"=> "Mesin",
                    "L" => "Listrik",
                    "R" => "RPL",
                    "S" => "Sipil",
                    _ => "tidak jurusan"
                };
                //Switch biasa
                /*
                    jurusan[i] = no_ujian[i].Substring(1, 2);
                    switch (jurusan[i])
                    {
                        case "01": jurusan[i] = "Mesin";
                        break;
                        case "02" : jurusan[i] = "Listrik";
                        break;
                        case "03" : jurusan[i] = "RPL";
                        break;
                        case "04" : jurusan[i] = "Sipil";
                        brak;
                        default : jurusan[i] = "tidak ada jurusan";
                        break;
                    };
                */

                do
                {
                    Console.Write($"Masukan Nama[{i + 1}] : ");
                    nama[i] = Console.ReadLine();
                } while (nama[i] == "");

                do
                {
                    Console.Write($"Masukan Nilai Ulangan[{i + 1}] : ");
                    n_ul[i] = Convert.ToInt32(Console.ReadLine());
                } while (n_ul[i] == null);

                do
                {
                    Console.Write($"Masukan Nilai UTS[{i + 1}] : ");
                    n_uts[i] = Convert.ToInt32(Console.ReadLine());
                } while (n_uts[i] == null);//null = 0 / tidak terdekteksi 

                do
                {
                    Console.Write($"Masukan Nilai Semester[{i + 1}] : ");
                    n_semester[i] = Convert.ToInt32(Console.ReadLine());
                } while (n_semester[i] == null);

                n_raport[i] = (n_semester[i] + n_ul[i] + n_uts[i]) / 3;

                if (i > 0)
                {
                    if (n_raport[i] > min_max[0])
                    {
                        min_max[0] = n_raport[i];
                        nama_min_max[0] = nama[i];
                        jurusan_min_max[0] = jurusan[i];
                    }
                    if (n_raport[i] < min_max[1])
                    {
                        min_max[1] = n_raport[i];
                        nama_min_max[1] = nama[i];
                        jurusan_min_max[1] = jurusan[i];
                    }
                }
                else
                {
                    if (n_raport[0] > min_max[0])
                    {
                        min_max[0] = n_raport[0];
                        nama_min_max[0] = nama[0];
                        jurusan_min_max[0] = jurusan[0];
                    }
                    if (n_raport[0] < min_max[1])
                    {
                        min_max[1] = n_raport[0];
                        nama_min_max[1] = nama[0];
                        jurusan_min_max[1] = jurusan[0];
                    }
                }
            }



            Console.WriteLine("\nDaftar Nilai Siswa\n");//\n = enter \t = tabs jadi klw write \n lakukan enter pada console ketika dijalankan
            Console.WriteLine("No\tNama\tJurusan\tKelas\tNilai Raport");
            Console.WriteLine("=======================================================================================");

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"{i + 1}\t{nama[i]}\t{jurusan[i]}\t{kls[i]}\t{n_raport[i]}");
            }

            Console.WriteLine("=======================================================================================");
            Console.WriteLine($"Nilai terbesar : {min_max[0]} Nama {nama_min_max[0]} Jurusan {jurusan_min_max[0]}");
            Console.WriteLine($"Nilai terkecil : {min_max[1]} Nama {nama_min_max[1]} Jurusan {jurusan_min_max[1]}");

        }
}
