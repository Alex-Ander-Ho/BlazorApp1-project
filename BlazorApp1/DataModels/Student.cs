namespace BlazorApp1.DataModels
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual Teather? Teather { get; set; }


    }
}