using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("ReceiveInvoice")]
[Index("InvoiceId", "BudgetSourceId", "ArriveDate", Name = "IX_ReceiveInvoice", IsUnique = true)]
public partial class ReceiveInvoice
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("InvoiceID")]
    [StringLength(30)]
    [Unicode(false)]
    public string InvoiceId { get; set; } = null!;

    [Column("BudgetSourceID")]
    [StringLength(20)]
    [Unicode(false)]
    public string BudgetSourceId { get; set; } = null!;

    public DateOnly ArriveDate { get; set; }

    public DateOnly IssueDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(30)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(30)]
    public string? ModifiedBy { get; set; }

    public bool? IsUpdated { get; set; }

    public int? Cycle { get; set; }

    [StringLength(200)]
    public string? Note { get; set; }

    public double? Total { get; set; }
}
