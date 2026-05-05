using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("ReceiveInvoiceReport_Detail")]
[Index("ReceiveInvoiceId", "CommodityId", "ExpDate", Name = "IX_ReceiveInvoiceReport_Detail", IsUnique = true)]
public partial class ReceiveInvoiceReportDetail
{
    [Column("InvoiceID")]
    [StringLength(30)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    [Key]
    [Column("ReceiveDetailID")]
    public long ReceiveDetailId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CommodityId { get; set; }

    public long? Amount { get; set; }

    public long? ReceiveAmount { get; set; }

    public int? AdjQty { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [Column("ReceiveInvoice_ID")]
    public long? ReceiveInvoiceId { get; set; }

    public DateOnly? OriginalExpDate { get; set; }
}
