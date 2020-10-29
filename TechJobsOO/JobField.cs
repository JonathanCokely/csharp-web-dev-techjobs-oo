using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public string Value { get; set; }

        public JobField(string value)
        {
            Value = value;
        }

        public virtual string ToString()
        {
            return Value;
        }

    }
}
