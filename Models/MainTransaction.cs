using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("MainTransaction")]
[Index("TransDate", "InvoiceId", "CommodityId", "BudgetSourceId", "ExpDate", "TransTypeId", "Sdid", Name = "IX_MainTransaction", IsUnique = true)]
public partial class MainTransaction
{
    [Key]
    [Column("MainTransactionID")]
    public int MainTransactionId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string LotNo { get; set; } = null!;

    [Column("BudgetSourceID")]
    [StringLength(10)]
    [Unicode(false)]
    public string BudgetSourceId { get; set; } = null!;

    public DateOnly? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(30)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdid { get; set; }

    [Column("FacilityID")]
    [StringLength(10)]
    public string? FacilityId { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    public long? SubBalance { get; set; }

    public long StockonHand { get; set; }

    [StringLength(200)]
    public string? TransNote { get; set; }

    public DateOnly? ExpDate { get; set; }

    public bool? IsUpdated { get; set; }

    public int? Cycle { get; set; }
}
