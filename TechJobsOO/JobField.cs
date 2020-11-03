using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {

        }
        public JobField(string value)
        {
            Id = nextId;
            nextId++;
            Value = value;
        }

        public override string ToString()
        {
            if (Value == "" || Value == null)
            {
                return "Data not available";
            }
            return Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }
    }
}
