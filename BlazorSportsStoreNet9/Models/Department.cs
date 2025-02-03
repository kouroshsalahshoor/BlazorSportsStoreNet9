﻿namespace BlazorSportsStoreNet9.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public IEnumerable<Person>? People { get; set; }
    }
}
