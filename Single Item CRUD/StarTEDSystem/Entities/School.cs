﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace StarTEDSystem.Entities
{
    public partial class School
    {
        public School()
        {
            Programs = new HashSet<Program>();
        }

        public string SchoolCode { get; set; }
        public string SchoolName { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
    }
}