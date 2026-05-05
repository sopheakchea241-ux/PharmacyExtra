using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSdtransferIn
{
    [Column("SDID")]
    [StringLength(10)]
    public string Sdid { get; set; } = null!;

    [StringLength(50)]
    public string? SourceDestination { get; set; }
}
