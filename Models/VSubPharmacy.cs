using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSubPharmacy
{
    [Column("SubPhaID")]
    [StringLength(10)]
    public string SubPhaId { get; set; } = null!;

    [StringLength(100)]
    public string? SubPhaName { get; set; }

    public bool? RecordSubStock { get; set; }
}
