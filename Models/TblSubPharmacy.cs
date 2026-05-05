using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblSubPharmacy")]
public partial class TblSubPharmacy
{
    [Key]
    [Column("SubPhaID")]
    [StringLength(10)]
    public string SubPhaId { get; set; } = null!;

    [StringLength(100)]
    public string? SubPhaName { get; set; }

    public bool? IsSeparateRequest { get; set; }
}
