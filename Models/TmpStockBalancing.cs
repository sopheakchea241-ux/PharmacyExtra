using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpStockBalancing")]
public partial class TmpStockBalancing
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? LastStockDate { get; set; }

    [Column("CommodityID")]
    [StringLength(7)]
    public string? CommodityId { get; set; }

    [Column("SOH")]
    public int? Soh { get; set; }

    [Column("AMCReal")]
    public int? Amcreal { get; set; }

    [Column("MOS")]
    public int? Mos { get; set; }

    [Column("AMCReal_HF")]
    public int? AmcrealHf { get; set; }

    [Column("AMCStd")]
    public int? Amcstd { get; set; }
}
