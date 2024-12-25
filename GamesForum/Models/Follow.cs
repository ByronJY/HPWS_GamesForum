using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Follow
{
    public string UserId { get; set; } = null!;

    public string FollowerId { get; set; } = null!;
}
