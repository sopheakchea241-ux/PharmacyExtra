using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubConsumption_Detail")]
[Index("SubConsId", "CommodityId", Name = "IX_SubConsumption_Detail", IsUnique = true)]
public partial class SubConsumptionDetail
{
    /// <summary>
    /// IPDConsumptionDetailID
    /// </summary>
    [Key]
    [Column("SubConsDetailID")]
    public long SubConsDetailId { get; set; }

    /// <summary>
    /// Link to SubConsumption
    /// </summary>
    [Column("SubConsID")]
    public long? SubConsId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    public int? Request { get; set; }

    public int? Supply { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(50)]
    public string? Notes { get; set; }

    public int? StockAvailable { get; set; }

    [ForeignKey("SubConsId")]
    [InverseProperty("SubConsumptionDetails")]
    public virtual SubConsumption? SubCons { get; set; }
}
