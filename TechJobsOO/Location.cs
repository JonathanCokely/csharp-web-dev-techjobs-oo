﻿using System;
namespace TechJobsOO
{
    public class Location:JobField
    {
        public int Id { get; }
        private static int nextId = 1;

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
        public Location(string value):this()
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
