using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        public Location()
        {

        }

        public Location(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }
    }
}
