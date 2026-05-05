using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("PI")]
[Index("UpdatedDate", "Pitype", Name = "IX_PI", IsUnique = true)]
public partial class Pi
{
    [Key]
    [Column("PIID")]
    public int Piid { get; set; }

    public DateOnly UpdatedDate { get; set; }

    public bool? IsUpdated { get; set; }

    [Column("PIType")]
    public byte Pitype { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(128)]
    public string? ModifiedBy { get; set; }

    public int? Cycle { get; set; }

    [InverseProperty("Pi")]
    public virtual ICollection<PiDetail> PiDetails { get; set; } = new List<PiDetail>();
}
