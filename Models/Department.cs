namespace sistema_web.Models
{
    public class Department
    {
        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}