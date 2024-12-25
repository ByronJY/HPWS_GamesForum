using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string TagName { get; set; } = null!;

    public string? TagDescription { get; set; }
}
