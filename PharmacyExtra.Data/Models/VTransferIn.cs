using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VTransferIn
{
    [Column("TransferInID")]
    public int TransferInId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime TransferDate { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    public int? Qty { get; set; }

    [StringLength(100)]
    public string? SourceDestination { get; set; }
}
