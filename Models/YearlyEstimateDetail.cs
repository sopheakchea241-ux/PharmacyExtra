using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("YearlyEstimate_Detail")]
[Index("Id", "CommodityId", Name = "IX_YearlyEstimate_Detail", IsUnique = true)]
public partial class YearlyEstimateDetail
{
    [Column("mAuto")]
    public long MAuto { get; set; }

    [Column("ID")]
    public long Id { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    [Column("SOH")]
    public long? Soh { get; set; }

    [Column("AMC")]
    public double? Amc { get; set; }

    public long? Needs { get; set; }

    public long? Recommended { get; set; }

    public long? Incoming { get; set; }

    public long? Outgoing { get; set; }

    public bool? IsPrint { get; set; }
}
