using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("MainTransfer_Detail")]
[Index("TransferId", "CommodityId", "BudgetSourceId", "ExpDate", Name = "IX_MainTransfer_Detail", IsUnique = true)]
public partial class MainTransferDetail
{
    [Key]
    [Column("TransferDetailID")]
    public int TransferDetailId { get; set; }

    [Column("TransferID")]
    public int TransferId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string? LotNo { get; set; }

    [Column("BudgetSourceID")]
    [StringLength(10)]
    [Unicode(false)]
    public string BudgetSourceId { get; set; } = null!;

    /// <summary>
    /// Transfer Quantity
    /// </summary>
    public int? Qty { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(50)]
    public string? Notes { get; set; }

    public int? StockAvailable { get; set; }

    [ForeignKey("TransferId")]
    [InverseProperty("MainTransferDetails")]
    public virtual MainTransfer Transfer { get; set; } = null!;
}
