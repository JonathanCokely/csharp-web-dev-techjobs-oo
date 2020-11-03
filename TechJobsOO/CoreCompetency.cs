using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency()
        {

        }

        public CoreCompetency(string v)
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }
    }
}
