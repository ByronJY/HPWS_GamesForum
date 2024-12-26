using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Article
{
    public int ArticleId { get; set; }

    public string UserId { get; set; } = null!;

    public int? GameId { get; set; }

    public string? ArticlePhoto { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
