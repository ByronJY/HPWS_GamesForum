using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int ArticleId { get; set; }

    public string UserId { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
