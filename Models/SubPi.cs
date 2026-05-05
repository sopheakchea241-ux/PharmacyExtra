using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubPI")]
[Index("SubPhaId", "UpdatedDate", "Pitype", Name = "IX_SubPI", IsUnique = true)]
public partial class SubPi
{
    [Key]
    [Column("PIID")]
    public int Piid { get; set; }

    public DateOnly UpdatedDate { get; set; }

    public bool IsUpdated { get; set; }

    [Column("PIType")]
    public bool Pitype { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    public bool? IsSaved { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string SubPhaId { get; set; } = null!;

    public int? Cycle { get; set; }

    [InverseProperty("Pi")]
    public virtual ICollection<SubPiDetail> SubPiDetails { get; set; } = new List<SubPiDetail>();
}
