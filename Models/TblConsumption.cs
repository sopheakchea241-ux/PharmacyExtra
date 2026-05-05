using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("TblConsumption")]
public partial class TblConsumption
{
    [Column("SubConsID")]
    public int SubConsId { get; set; }

    [Column("UniqueID")]
    [StringLength(50)]
    public string? UniqueId { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("TransTypeID")]
    [StringLength(50)]
    public string? TransTypeId { get; set; }

    [Column("WardID")]
    [StringLength(50)]
    public string? WardId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ConsumpDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReportDate { get; set; }

    [StringLength(100)]
    public string? ReportNote { get; set; }

    public double? OutPatient { get; set; }

    public double? Inpatient { get; set; }

    public double? SurgicalPatient { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool IsUpdated { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [Column("SubPhaID")]
    [StringLength(255)]
    public string? SubPhaId { get; set; }
}
