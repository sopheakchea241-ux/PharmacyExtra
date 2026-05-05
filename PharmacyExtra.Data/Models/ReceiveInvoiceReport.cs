using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("ReceiveInvoiceReport")]
[Index("InvoiceId", "ReceiveInvoiceId", Name = "IX_ReceiveInvoiceReport", IsUnique = true)]
public partial class ReceiveInvoiceReport
{
    [Column("ID")]
    public long Id { get; set; }

    [Key]
    [Column("InvoiceID")]
    [StringLength(30)]
    public string InvoiceId { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(30)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime EndDate { get; set; }

    public short? Semester { get; set; }

    public double? Amount { get; set; }

    public bool? IsUpdated { get; set; }

    [Column("ReceiveInvoice_ID")]
    public long? ReceiveInvoiceId { get; set; }

    [Column("BudgetSourceID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BudgetSourceId { get; set; }

    [StringLength(30)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }
}
