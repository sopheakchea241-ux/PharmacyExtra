using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("ReceiveInvoiceReportNote")]
public partial class ReceiveInvoiceReportNote
{
    [StringLength(50)]
    public string? Note { get; set; }
}
