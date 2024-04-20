using System;
using System.Collections.Generic;

namespace CaiHoangLong_120123_DBFirst.Models;

public partial class Post
{
    public string Id { get; set; } = null!;

    public string? PName { get; set; }

    public string? PDescription { get; set; }
}
