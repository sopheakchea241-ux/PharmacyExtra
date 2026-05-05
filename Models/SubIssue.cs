using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubIssue")]
[Index("IssueDate", "SourSubPhaId", "DestSubPhaId", Name = "IX_SubIssue", IsUnique = true)]
public partial class SubIssue
{
    [Key]
    [Column("SubIssueID")]
    public long SubIssueId { get; set; }

    public DateOnly IssueDate { get; set; }

    [Column("SourSubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string SourSubPhaId { get; set; } = null!;

    [Column("DestSubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string DestSubPhaId { get; set; } = null!;

    [StringLength(50)]
    public string? Note { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool? IsUpdated { get; set; }

    public int? Cycle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdatedDate { get; set; }

    [InverseProperty("SubIssue")]
    public virtual ICollection<SubIssueDetail> SubIssueDetails { get; set; } = new List<SubIssueDetail>();
}
