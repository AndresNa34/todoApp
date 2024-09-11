using System;
using System.Collections.Generic;

namespace todoApi.Data.Models;

public partial class Assignment
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool Completed { get; set; }

    public bool Editing { get; set; }
}
