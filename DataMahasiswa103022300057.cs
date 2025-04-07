using System.Text.Json;

namespace tpmodul7_kelompok_3
{
    class DataMahasiswa103022300057
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public String fakultas { get; set; }
        public class Nama
        {
            public String depan { get; set; }
            public String belakang { get; set; }
        }

        public static void ReadJSON(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            string jsonString = File.ReadAllText(filePath); DataMahasiswa103022300057 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022300057>(jsonString);
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }

}