using System;
using System.Text.Json;

class DataMahasiswa103022300073
{
    public long nim { get; set; }
    public String fakultas { get; set; }
    public Nama nama { get; set; }

    public static void ReadJson()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_1_103022300073.json");



        string jsonString = File.ReadAllText(filePath);

        DataMahasiswa103022300073 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022300073>(jsonString);

        Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
    }

}

class Nama
{
    public String depan { get; set; }
    public String belakang { get; set; }
}
