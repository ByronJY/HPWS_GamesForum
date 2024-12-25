using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Like
{
    public int ArticleId { get; set; }

    public string UserId { get; set; } = null!;
}
