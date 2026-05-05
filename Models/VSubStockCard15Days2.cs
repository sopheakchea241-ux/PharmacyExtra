using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSubStockCard15Days2
{
    [Column("CommodityID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CommodityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CommodityName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Form { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Strength { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SourceDestination { get; set; }

    public int? MaxStockOnHand { get; set; }

    public int? MinStockOnHand { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransYear { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransDes { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    [StringLength(50)]
    public string? WardName { get; set; }

    [Column("SubTransactionID")]
    public int? SubTransactionId { get; set; }
}
