using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_3
{
    class DataMahasiswa103022300093
    {
        public long nim { get; set; }
        public string fakultas { get; set; }
        public Nama nama { get; set; }

        public static void ReadJSON()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_1_10302200093.json");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File tidak ditemukan: " + filePath);
                return;
            }

            string jsonString = File.ReadAllText(filePath);

            DataMahasiswa103022300093 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022300093>(jsonString);

            if (mahasiswa != null && mahasiswa.nama != null)
            {
                Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
            }
            else
            {
                Console.WriteLine("Gagal membaca data mahasiswa dari JSON.");
            }
        }
    }

    class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
}
