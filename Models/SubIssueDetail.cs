using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubIssue_Detail")]
[Index("SubIssueId", "CommodityId", Name = "IX_SubIssue_Detail", IsUnique = true)]
public partial class SubIssueDetail
{
    [Key]
    [Column("SubIssueDetailID")]
    public long SubIssueDetailId { get; set; }

    [Column("SubIssueID")]
    public long? SubIssueId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    public int DestPhaBal { get; set; }

    public int Request { get; set; }

    public int Supply { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(50)]
    public string? Notes { get; set; }

    public int StockAvailable { get; set; }

    [ForeignKey("SubIssueId")]
    [InverseProperty("SubIssueDetails")]
    public virtual SubIssue? SubIssue { get; set; }
}
