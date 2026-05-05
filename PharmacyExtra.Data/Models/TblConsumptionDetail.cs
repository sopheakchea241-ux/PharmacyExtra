using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("TblConsumption_Detail")]
public partial class TblConsumptionDetail
{
    [Column("ConCommID")]
    public int ConCommId { get; set; }

    [Column("ConsumpID")]
    public int? ConsumpId { get; set; }

    [Column("CommodityID")]
    [StringLength(10)]
    public string? CommodityId { get; set; }

    public int? Request { get; set; }

    public int? Supply { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }
}
