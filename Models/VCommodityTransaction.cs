using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VCommodityTransaction
{
    [Column("DTDID")]
    public int Dtdid { get; set; }

    [Column("CommTransID")]
    public int? CommTransId { get; set; }

    [Column("CommID")]
    [StringLength(15)]
    public string? CommId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    public int? InitStock { get; set; }

    public int? Incoming { get; set; }

    public double? Total { get; set; }

    public int? Outgoing { get; set; }

    public double? Adjustment { get; set; }

    public double? Balance { get; set; }

    [StringLength(255)]
    public string? TransNote { get; set; }

    [StringLength(60)]
    public string CommTypeName { get; set; } = null!;

    [StringLength(152)]
    public string? CommGrpName { get; set; }

    [Column("CommTypeID")]
    [StringLength(5)]
    public string? CommTypeId { get; set; }

    [Column("CommGrpID")]
    [StringLength(5)]
    public string CommGrpId { get; set; } = null!;

    [StringLength(50)]
    public string? Belonging { get; set; }
}
