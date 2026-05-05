using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("FacilityType")]
public partial class FacilityType
{
    [Key]
    [Column("FacilityTypeID")]
    [StringLength(5)]
    public string FacilityTypeId { get; set; } = null!;

    [StringLength(30)]
    public string FacilityTypeName { get; set; } = null!;

    [Column("FacilityTypeNameKH")]
    [StringLength(60)]
    public string? FacilityTypeNameKh { get; set; }

    [StringLength(10)]
    public string FacilityTypeAbbrev { get; set; } = null!;

    [Column("FacilityTypeAbbrevKH")]
    [StringLength(20)]
    public string? FacilityTypeAbbrevKh { get; set; }

    public short? Tier { get; set; }

    public short? ReviewPeriod { get; set; }

    public int? FacilityTypeTotal { get; set; }

    [InverseProperty("FacilityType")]
    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();
}
