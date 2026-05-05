using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("PI_Detail")]
[Index("Piid", "CommodityId", "BudgetSourceId", "ExpDate", Name = "IX_PI_Detail", IsUnique = true)]
public partial class PiDetail
{
    [Key]
    [Column("PIDetailID")]
    public long PidetailId { get; set; }

    /// <summary>
    /// Link to PI
    /// </summary>
    [Column("PIID")]
    public int? Piid { get; set; }

    public DateOnly? LastStockDate { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string LotNo { get; set; } = null!;

    public DateOnly? ExpDate { get; set; }

    [Column("BudgetSourceID")]
    [StringLength(10)]
    [Unicode(false)]
    public string BudgetSourceId { get; set; } = null!;

    public int CurrentStock { get; set; }

    public int StockCount { get; set; }

    public int AdjQty { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransNote { get; set; }

    public bool? IsLock { get; set; }

    [ForeignKey("Piid")]
    [InverseProperty("PiDetails")]
    public virtual Pi? Pi { get; set; }
}
