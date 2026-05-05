using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubConsumption_Detail")]
public partial class TmpSubConsumptionDetail
{
    [Column("SubConsDetailID")]
    public long SubConsDetailId { get; set; }

    [Column("SubConsID")]
    public long? SubConsId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    public int? Request { get; set; }

    public int? Supply { get; set; }

    [StringLength(50)]
    public string? ExpDate { get; set; }
}
