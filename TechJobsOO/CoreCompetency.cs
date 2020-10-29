﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency:JobField
    {
        private int Id { get; set; }
        private static int nextId = 1;

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
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
