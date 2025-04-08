using System.Text.Json;

namespace tpmodul7_kelompok_3
{
    class KuliahMahasiswa103022300057
    {
        public List<Course> courses { get; set; }
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public static void ReadJSON(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            string jsonString = File.ReadAllText(filePath);

            KuliahMahasiswa103022300057 kuliahData = JsonSerializer.Deserialize<KuliahMahasiswa103022300057>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < kuliahData.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {kuliahData.courses[i].code} - {kuliahData.courses[i].name}");
            }
        }
    }
}