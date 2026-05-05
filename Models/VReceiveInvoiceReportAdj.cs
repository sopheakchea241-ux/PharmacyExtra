using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VReceiveInvoiceReportAdj
{
    [Column("InvoiceID")]
    [StringLength(30)]
    public string InvoiceId { get; set; } = null!;

    public int? AdjComm { get; set; }
}
