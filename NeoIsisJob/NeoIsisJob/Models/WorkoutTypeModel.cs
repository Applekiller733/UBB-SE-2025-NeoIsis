﻿namespace NeoIsisJob.Models
{
    public class WorkoutTypeModel
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public WorkoutTypeModel() { }

        public WorkoutTypeModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
