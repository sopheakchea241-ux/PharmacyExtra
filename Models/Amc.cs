using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("AMC")]
public partial class Amc
{
    [Column("CommodityID")]
    [StringLength(10)]
    public string? CommodityId { get; set; }

    [Column("AMC")]
    public double? Amc1 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExportDate { get; set; }
}
