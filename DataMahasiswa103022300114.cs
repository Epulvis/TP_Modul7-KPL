using System.Text.Json;

class DataMahasiswa103022300114
{
    public long nim { get; set; }
    public String fakultas { get; set; }
    public Nama nama { get; set; }

    public static void ReadJSON()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "tp7_1_103022300114.json");
        string jsonString = File.ReadAllText(filePath);

        DataMahasiswa103022300114 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022300114>(jsonString);

        Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
    }
}

class Nama
{
    public String depan { get; set; }
    public String belakang { get; set; }
}