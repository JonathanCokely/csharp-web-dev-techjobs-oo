using System;
namespace TechJobsOO
{
    public class Employer:JobField
    {
        public int Id { get; }
        private static int nextId = 1;

        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value):this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }
    }
}
