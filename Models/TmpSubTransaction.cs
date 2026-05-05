using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubTransaction")]
public partial class TmpSubTransaction
{
    [Column("SubTransactionID")]
    public int? SubTransactionId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("WardID")]
    [StringLength(10)]
    public string? WardId { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    public int? StockonHand { get; set; }

    [StringLength(200)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public int? Cycle { get; set; }

    public bool? IsExported { get; set; }
}
