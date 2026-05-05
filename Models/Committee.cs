using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("Committee")]
public partial class Committee
{
    [StringLength(500)]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    [StringLength(1000)]
    public string? TitleKhmer { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? TitleEnglish { get; set; }
}
