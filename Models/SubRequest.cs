using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubRequest")]
[Index("SubPhaId", "IssueDate", "Sdid", "WardId", Name = "IX_SubRequest", IsUnique = true)]
public partial class SubRequest
{
    [Key]
    public int RequestNº { get; set; }

    public DateOnly IssueDate { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdid { get; set; }

    [Column("WardID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? WardId { get; set; }

    public bool? IsImported { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SubPhaId { get; set; }

    [Column("UniqueID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UniqueId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [InverseProperty("RequestNºNavigation")]
    public virtual ICollection<SubPrescription> SubPrescriptions { get; set; } = new List<SubPrescription>();
}
