using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubTransaction")]
[Index("SubPhaId", "TransDate", "TransTypeId", "CommodityId", "Sdid", "WardId", "InvoiceId", Name = "IX_SubTransaction", IsUnique = true)]
public partial class SubTransaction
{
    [Key]
    [Column("SubTransactionID")]
    public long SubTransactionId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdid { get; set; }

    [Column("WardID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? WardId { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    [Unicode(false)]
    public string TransTypeId { get; set; } = null!;

    public long StockonHand { get; set; }

    [StringLength(200)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string SubPhaId { get; set; } = null!;

    public int? Cycle { get; set; }

    public bool? IsExported { get; set; }
}
