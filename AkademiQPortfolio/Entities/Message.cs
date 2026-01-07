using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Message
{
    public string? SenderName { get; set; }

    public string? SenderEmail { get; set; }

    public string? MessageText { get; set; }

    public DateTime? SendDate { get; set; }

    public bool? IsRead { get; set; }

    public string? MessageSubject { get; set; }
}
