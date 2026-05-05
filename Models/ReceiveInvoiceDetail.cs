using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("ReceiveInvoice_Detail")]
[Index("ReceiveInvoiceId", "CommodityId", "BudgetSourceId", "ExpDate", Name = "IX_ReceiveInvoice_Detail", IsUnique = true)]
public partial class ReceiveInvoiceDetail
{
    /// <summary>
    /// Link to ReceiveInvoice
    /// </summary>
    [Column("InvoiceID")]
    [StringLength(30)]
    public string? InvoiceId { get; set; }

    [Key]
    [Column("ReceiveDetailID")]
    public long ReceiveDetailId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column("BudgetSourceID")]
    [StringLength(10)]
    public string? BudgetSourceId { get; set; }

    public long? Amount { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column("ReceiveInvoice_ID")]
    public long? ReceiveInvoiceId { get; set; }
}
