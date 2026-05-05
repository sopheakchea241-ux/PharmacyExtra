using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpReceiveInvoice")]
public partial class TmpReceiveInvoice
{
    [Column("InvoiceID")]
    [StringLength(20)]
    public string InvoiceId { get; set; } = null!;

    [Column("BudgetSourceID")]
    [StringLength(10)]
    public string? BudgetSourceId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ArriveDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? IssueDate { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("HosOrderID")]
    public int? HosOrderId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(30)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(30)]
    public string? ModifiedBy { get; set; }

    public bool IsUpdated { get; set; }
}
