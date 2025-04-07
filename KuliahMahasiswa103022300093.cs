using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace tpmodul7_kelompok_3
{
    class KuliahMahasiswa103022300093
    {
        public List<Course> courses { get; set; }

        public static void ReadJSON()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_2_103022300093.json");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File tidak ditemukan: " + filePath);
                return;
            }

            string jsonString = File.ReadAllText(filePath);

            KuliahMahasiswa103022300093 kuliahData = JsonSerializer.Deserialize<KuliahMahasiswa103022300093>(jsonString);

            if (kuliahData != null && kuliahData.courses != null)
            {
                Console.WriteLine("Daftar mata kuliah yang diambil:");
                for (int i = 0; i < kuliahData.courses.Count; i++)
                {
                    Console.WriteLine($"MK {i + 1}: {kuliahData.courses[i].code} - {kuliahData.courses[i].name}");
                }
            }
            else
            {
                Console.WriteLine("Gagal membaca data mata kuliah dari JSON.");
            }
        }
    }

    class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
