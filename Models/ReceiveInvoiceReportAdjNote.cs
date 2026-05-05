using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("ReceiveInvoiceReportAdjNote")]
public partial class ReceiveInvoiceReportAdjNote
{
    [Key]
    [StringLength(50)]
    public string Note { get; set; } = null!;
}
