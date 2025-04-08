using System.Text.Json;

class KuliahMahasiswa1030223300114
{
    public List<Course> courses { get; set; }

    public static void ReadJSON()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "tp7_2_103022300114.json");
        string jsonString = File.ReadAllText(filePath);

        KuliahMahasiswa1030223300114 kuliahData = JsonSerializer.Deserialize<KuliahMahasiswa1030223300114>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < kuliahData.courses.Count; i++)
        {
            Console.WriteLine($"MK {i + 1} {kuliahData.courses[i].code} - {kuliahData.courses[i].name}");
        }
    }
}

class Course
{
    public string code { get; set; }
    public string name { get; set; }
}