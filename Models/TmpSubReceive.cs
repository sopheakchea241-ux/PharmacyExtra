using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubReceive")]
public partial class TmpSubReceive
{
    [Column("MainConsID")]
    public long MainConsId { get; set; }

    [Column("UniqueID")]
    [StringLength(20)]
    public string UniqueId { get; set; } = null!;

    [Column("SDID")]
    [StringLength(10)]
    public string Sdid { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime ConsumpDate { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string TransTypeId { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool? IsUpdated { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    public bool? IsSaved { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    public int? Cycle { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public bool? IsExported { get; set; }

    [Column("InvoiceID")]
    public long? InvoiceId { get; set; }
}
