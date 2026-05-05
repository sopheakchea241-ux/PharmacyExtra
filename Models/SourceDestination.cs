using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SourceDestination")]
public partial class SourceDestination
{
    [Key]
    [Column("SDID")]
    [StringLength(10)]
    public string Sdid { get; set; } = null!;

    [Column("SourceDestination")]
    [StringLength(50)]
    public string? SourceDestination1 { get; set; }

    public bool? IsClass1 { get; set; }

    public bool? IsMain { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    public bool? IsSource { get; set; }
}
