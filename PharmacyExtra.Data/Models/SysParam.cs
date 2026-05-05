using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SysParam")]
public partial class SysParam
{
    [Column("FacilityID")]
    [StringLength(10)]
    public string FacilityId { get; set; } = null!;

    [Key]
    [Column("SysID")]
    [StringLength(10)]
    public string SysId { get; set; } = null!;

    [StringLength(100)]
    public string? SysName { get; set; }

    [StringLength(200)]
    public string? SysNameKh { get; set; }

    [StringLength(50)]
    public string? HosName { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    public int? SysPeriod { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? SysBeginDate { get; set; }

    [Column("ProvinceID")]
    [StringLength(10)]
    public string? ProvinceId { get; set; }

    [StringLength(10)]
    public string? DefStortType { get; set; }

    [Column("HosAMC")]
    [StringLength(50)]
    public string? HosAmc { get; set; }

    [Column("MaxMOS")]
    public int MaxMos { get; set; }

    public int? ReviewPeriod { get; set; }

    public int? YearlyMultiplier { get; set; }

    public bool IsLocked { get; set; }

    public int? ShowStockOut { get; set; }

    [StringLength(5)]
    public string? HosLevel { get; set; }

    public int? Replenish { get; set; }

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

    [StringLength(1000)]
    public string? HosKhmerUnicode { get; set; }

    public bool IsPrivate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime Expire { get; set; }
}
