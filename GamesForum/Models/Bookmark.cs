using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Bookmark
{
    public string UserId { get; set; } = null!;

    public int ArticleId { get; set; }
}
