namespace StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // ✅ Set default value
        public string Course { get; set; } = string.Empty;  // ✅ Set default value
    }
}

