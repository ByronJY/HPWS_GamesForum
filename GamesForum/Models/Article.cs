using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Article
{
    public int ArticleId { get; set; }

    public int UserId { get; set; }

    public int? GameId { get; set; }

    public string? ArticlePhoto { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
