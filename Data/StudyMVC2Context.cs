﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyMVC2.Models;

namespace StudyMVC2.Data
{
    public class StudyMVC2Context : DbContext
    {
        public StudyMVC2Context(DbContextOptions<StudyMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<Photo> Photos { get; set; } = default!;
    }//参照先でPhotosを呼び出す
}
