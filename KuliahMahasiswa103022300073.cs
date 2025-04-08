using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
class KuliahMahasiswa103022300073
    {
    public List<Course> courses { get; set; }

    public static void ReadJSON()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_2_103022300073.json");
        string jsonString = File.ReadAllText(filePath);

        KuliahMahasiswa103022300073 kuliahData = JsonSerializer.Deserialize<KuliahMahasiswa103022300073>(jsonString);

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

