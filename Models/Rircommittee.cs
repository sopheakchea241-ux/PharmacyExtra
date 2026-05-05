using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("RIRCommittee")]
public partial class Rircommittee
{
    public long Nº { get; set; }

    [Column("InvoiceID")]
    [StringLength(30)]
    public string InvoiceId { get; set; } = null!;

    [StringLength(500)]
    public string? Participant { get; set; }

    public int? Amount { get; set; }

    [Column("ReceiveInvoice_ID")]
    public long? ReceiveInvoiceId { get; set; }

    [Column("Committee_Unicode")]
    [StringLength(1000)]
    public string? CommitteeUnicode { get; set; }

    [ForeignKey("InvoiceId")]
    public virtual ReceiveInvoiceReport Invoice { get; set; } = null!;
}
