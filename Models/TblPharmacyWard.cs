using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblPharmacyWard")]
[Index("SubPhaId", "WardId", Name = "IX_tblPharmacyWard", IsUnique = true)]
public partial class TblPharmacyWard
{
    [Key]
    [Column("PWID")]
    public int Pwid { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string SubPhaId { get; set; } = null!;

    [Column("WardID")]
    [StringLength(10)]
    public string WardId { get; set; } = null!;
}
