using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("TblParameter")]
public partial class TblParameter
{
    [Column("ID")]
    public int? Id { get; set; }

    public DateOnly? HosOrderDate { get; set; }

    public DateOnly? DateStockUpdate { get; set; }

    [Column("InvoiceID")]
    public double? InvoiceId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Pharmacy { get; set; }

    public int? Cycle { get; set; }
}
