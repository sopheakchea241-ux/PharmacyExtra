using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubStockCardDaily")]
public partial class TmpSubStockCardDaily
{
    [Column("CommodityID")]
    [StringLength(20)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string? CommodityName { get; set; }

    [StringLength(20)]
    public string? Form { get; set; }

    [StringLength(20)]
    public string? Strength { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [StringLength(5)]
    public string? TransGroup { get; set; }

    [StringLength(100)]
    public string? TransName { get; set; }

    [StringLength(100)]
    public string? SourceDestination { get; set; }

    public int? StockOnHand { get; set; }

    [Column("MaxSOH")]
    public int? MaxSoh { get; set; }

    [StringLength(100)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(5)]
    public string? TransYear { get; set; }

    [StringLength(100)]
    public string? TransDes { get; set; }

    [Column("SubTransactionID")]
    public long? SubTransactionId { get; set; }

    [Column("TransTypeID")]
    [StringLength(5)]
    public string? TransTypeId { get; set; }

    [Column("SubPhaID")]
    [StringLength(5)]
    public string? SubPhaId { get; set; }

    [StringLength(50)]
    public string? WardName { get; set; }
}
