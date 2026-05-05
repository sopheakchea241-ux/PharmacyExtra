using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class View2
{
    [StringLength(30)]
    public string FacilityName { get; set; } = null!;

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
}
