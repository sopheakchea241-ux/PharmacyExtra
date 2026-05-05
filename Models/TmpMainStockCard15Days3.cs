using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpMainStockCard15Days3")]
public partial class TmpMainStockCard15Days3
{
    [Column("CommodityID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CommodityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CommodityName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Form { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Strength { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransName { get; set; }

    [Column("SD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sd { get; set; }

    public int? Quantity { get; set; }

    public int? SubBalance { get; set; }

    public int? StockOnHand { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Note { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpiredDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransYear { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BudgetSource { get; set; }

    [Column("MainTransactionID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MainTransactionId { get; set; }
}
