﻿using System;
using System.Collections.Generic;


namespace StudyMVC2.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string PhotoPath { get; set; }
    }
}