using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblTemp_Invoice_Invoice")]
public partial class TblTempInvoiceInvoice
{
    [Column("InvoiceID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceName { get; set; }

    [Column("FacilityID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FacilityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FacName { get; set; }

    [Column("ProvinceID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProvinceId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrdDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("NB", TypeName = "decimal(18, 4)")]
    public decimal? Nb { get; set; }

    [Column("WBADB", TypeName = "decimal(18, 4)")]
    public decimal? Wbadb { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Other { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Total { get; set; }
}
