using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VInvoiceReport
{
    [Column("InvoiceID")]
    [StringLength(30)]
    public string InvoiceId { get; set; } = null!;

    public long Nº { get; set; }

    [StringLength(500)]
    public string? Participant { get; set; }

    public int? Amount { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    [Column("ProvinceNameKH")]
    [StringLength(60)]
    public string? ProvinceNameKh { get; set; }

    [StringLength(10)]
    public string? StartTime { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? StartDate { get; set; }

    [StringLength(10)]
    public string? EndTime { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? IssueDate { get; set; }

    public short? Semester { get; set; }

    public double? AmountR { get; set; }

    public int? AdjComm { get; set; }

    public int? AllComm { get; set; }

    [StringLength(200)]
    public string? FacilityType { get; set; }

    [StringLength(200)]
    public string? SupervisedBy { get; set; }

    [Column("FacilityTypeEN")]
    [StringLength(100)]
    public string? FacilityTypeEn { get; set; }

    [Column("SupervisedByEN")]
    [StringLength(100)]
    public string? SupervisedByEn { get; set; }

    [StringLength(500)]
    public string? SupplySource { get; set; }
}
