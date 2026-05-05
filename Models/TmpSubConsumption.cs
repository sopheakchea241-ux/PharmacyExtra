using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubConsumption")]
public partial class TmpSubConsumption
{
    [Column("SubConsID")]
    public long SubConsId { get; set; }

    [Column("UniqueID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UniqueId { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string Sdid { get; set; } = null!;

    [Column("TransTypeID")]
    [StringLength(10)]
    public string TransTypeId { get; set; } = null!;

    [Column("WardID")]
    [StringLength(10)]
    public string? WardId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ConsumpDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ReportDate { get; set; }

    [StringLength(100)]
    public string? ReportNote { get; set; }

    public int? OutPatient { get; set; }

    public int? Inpatient { get; set; }

    public int? SurgicalPatient { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool? IsUpdated { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsImported { get; set; }

    public int? Cycle { get; set; }

    public bool? IsExported { get; set; }
}
