namespace _23._06._2023
{
    public class Person
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name} \nSurname: {this.Surname} \nAge: {this.Age}";
        }

    }
}
