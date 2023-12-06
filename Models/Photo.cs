using System;
using System.Collections.Generic;

namespace StudyMVC2.Models;

public partial class Photo
{
    
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PhotoPath { get; set; } = null!;
}
