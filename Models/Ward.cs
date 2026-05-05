using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("Ward")]
public partial class Ward
{
    [Key]
    [Column("WardID")]
    [StringLength(10)]
    public string WardId { get; set; } = null!;

    [StringLength(100)]
    public string? WardNameEng { get; set; }

    [StringLength(100)]
    public string? WardNameFr { get; set; }

    [StringLength(10)]
    public string? Abbr { get; set; }

    public bool? IsActive { get; set; }
}
