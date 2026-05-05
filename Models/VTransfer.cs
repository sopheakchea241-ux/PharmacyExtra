using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VTransfer
{
    [Column("MainConsID")]
    public int MainConsId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    public int? Supply { get; set; }

    [StringLength(50)]
    public string? HosName { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime ConsumpDate { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    [StringLength(50)]
    public string? ExpDate { get; set; }
}
