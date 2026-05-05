using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpMainStockCard15Days1")]
public partial class TmpMainStockCard15Days1
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
    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransGroup { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SourceDestination { get; set; }

    public int? SubBalance { get; set; }

    public int? StockOnHand { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransDes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransYear { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? TransTypeId { get; set; }

    [Column("MainTransactionID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MainTransactionId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BudgetSource { get; set; }
}
