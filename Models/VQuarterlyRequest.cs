using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VQuarterlyRequest
{
    [Column("RequestID")]
    public int RequestId { get; set; }

    [StringLength(30)]
    public string ProvinceName { get; set; } = null!;

    [Column("ProvinceNameKH")]
    [StringLength(60)]
    public string? ProvinceNameKh { get; set; }

    [StringLength(50)]
    public string? HosName { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime EndDate { get; set; }

    public int InPatient { get; set; }

    public int OutPatient { get; set; }

    public int SurgicalPatient { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public int? InitialStock { get; set; }

    public int? Incoming { get; set; }

    public int? Total { get; set; }

    public int? Outgoing { get; set; }

    public int? Balance { get; set; }

    [Column("SOD")]
    public int? Sod { get; set; }

    public int? Request { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [StringLength(50)]
    public string CommGrpName { get; set; } = null!;

    [StringLength(60)]
    public string CommTypeName { get; set; } = null!;
}
