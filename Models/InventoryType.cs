using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("InventoryType")]
public partial class InventoryType
{
    [Column("InvTypeID")]
    [StringLength(5)]
    public string? InvTypeId { get; set; }

    [StringLength(60)]
    public string? InvTypeName { get; set; }

    [Column("InvTypeNameKH")]
    [StringLength(60)]
    public string? InvTypeNameKh { get; set; }

    public float? Value { get; set; }

    [Column("InvCateID")]
    [StringLength(5)]
    public string? InvCateId { get; set; }

    [Column("HCOrder")]
    public float? Hcorder { get; set; }

    [Column("NonHCOrder")]
    public float? NonHcorder { get; set; }
}
