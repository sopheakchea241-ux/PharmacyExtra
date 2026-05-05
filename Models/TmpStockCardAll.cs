using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpStockCardAll")]
public partial class TmpStockCardAll
{
    [Column("TransactionID")]
    public int TransactionId { get; set; }

    [Column("CommodityID")]
    [StringLength(10)]
    public string? CommodityId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(10)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    public int? StockonHand { get; set; }

    [StringLength(10)]
    public string? Note { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(200)]
    public string? CommodityName { get; set; }

    [StringLength(15)]
    public string? CommForm { get; set; }

    [StringLength(15)]
    public string? MedicineStrength { get; set; }

    [StringLength(50)]
    public string? TransName { get; set; }

    [StringLength(50)]
    public string? SourceDestination { get; set; }
}
