using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("Facility")]
public partial class Facility
{
    [Key]
    [Column("FacilityID")]
    [StringLength(10)]
    public string FacilityId { get; set; } = null!;

    [StringLength(30)]
    public string FacilityName { get; set; } = null!;

    [Column("FacilityNameKH")]
    [StringLength(60)]
    public string? FacilityNameKh { get; set; }

    [Column("FacilityTypeID")]
    [StringLength(5)]
    public string FacilityTypeId { get; set; } = null!;

    [Column("OrgID")]
    [StringLength(5)]
    public string? OrgId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CommDate { get; set; }

    [StringLength(200)]
    public string? Address1 { get; set; }

    [StringLength(50)]
    public string? Address2 { get; set; }

    [Column("DistrictID")]
    [StringLength(6)]
    public string? DistrictId { get; set; }

    [StringLength(15)]
    public string? FacPhone1 { get; set; }

    [StringLength(15)]
    public string? FacPhone2 { get; set; }

    [StringLength(15)]
    public string? FacPhone3 { get; set; }

    [StringLength(15)]
    public string? FacFax { get; set; }

    [StringLength(30)]
    public string? FacEmail { get; set; }

    [StringLength(30)]
    public string? ConName { get; set; }

    [StringLength(15)]
    public string? ConPhone { get; set; }

    [StringLength(30)]
    public string? ConEmail { get; set; }

    [StringLength(30)]
    public string? SupName { get; set; }

    [StringLength(15)]
    public string? SupPhone { get; set; }

    [StringLength(30)]
    public string? SupEmail { get; set; }

    [StringLength(1)]
    public string? Markup { get; set; }

    [StringLength(5)]
    public string? DelRouteNo { get; set; }

    [StringLength(3)]
    public string? PointNo { get; set; }

    public bool IsSupplier { get; set; }

    [Column("SupplierID")]
    [StringLength(10)]
    public string? SupplierId { get; set; }

    [Column("BranchID")]
    [StringLength(5)]
    public string? BranchId { get; set; }

    [Column("LevelID")]
    [StringLength(5)]
    public string? LevelId { get; set; }

    public short? MaxMoS { get; set; }

    public short? ForPer { get; set; }

    public short? ProPer { get; set; }

    [Column(TypeName = "ntext")]
    public string? FacMemo { get; set; }

    [Column("IsMPA")]
    public bool IsMpa { get; set; }

    [Column("MPAMulti")]
    public float? Mpamulti { get; set; }

    [Column("IsCPA")]
    public bool IsCpa { get; set; }

    [Column("CPAMulti")]
    public float? Cpamulti { get; set; }

    [Column("IsCPAS")]
    public bool IsCpas { get; set; }

    [Column("CPASMulti")]
    public float? Cpasmulti { get; set; }

    [StringLength(15)]
    public string? InsertedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InsertedDate { get; set; }

    [StringLength(15)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column("UniqueID")]
    [MaxLength(8)]
    public byte[] UniqueId { get; set; } = null!;

    [ForeignKey("DistrictId")]
    [InverseProperty("Facilities")]
    public virtual District? District { get; set; }

    [ForeignKey("FacilityTypeId")]
    [InverseProperty("Facilities")]
    public virtual FacilityType FacilityType { get; set; } = null!;
}
