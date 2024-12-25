using System;
using System.Collections.Generic;

namespace GamesForum.Models;

public partial class Game
{
    public int GameId { get; set; }

    public string GameName { get; set; } = null!;

    public string? GameInfo { get; set; }

    public string? GamePhoto { get; set; }
}
