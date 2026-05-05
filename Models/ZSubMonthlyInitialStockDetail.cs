using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class ZSubMonthlyInitialStockDetail
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    public int? TransQty { get; set; }

    public int? StockonHand { get; set; }

    public int? InitialStock { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    [Column("SubTransactionID")]
    public int SubTransactionId { get; set; }
}
