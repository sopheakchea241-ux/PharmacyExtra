using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblTemp_Invoice_InvoiceDetail")]
public partial class TblTempInvoiceInvoiceDetail
{
    [StringLength(100)]
    [Unicode(false)]
    public string? LotNo { get; set; }

    [Column("InvoiceID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceId { get; set; }

    [Column("InventoryID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InventoryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InvName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Strength { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Form { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNum { get; set; }

    public int? SuppQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }

    [Column("NB", TypeName = "decimal(18, 4)")]
    public decimal? Nb { get; set; }

    [Column("WBADB", TypeName = "decimal(18, 4)")]
    public decimal? Wbadb { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Other { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Total { get; set; }
}
