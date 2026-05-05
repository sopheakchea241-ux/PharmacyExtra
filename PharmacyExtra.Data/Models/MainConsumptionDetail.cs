using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("MainConsumption_Detail")]
[Index("MainConsId", "CommodityId", "BudgetSourceId", "ExpDate", Name = "IX_MainConsumption_Detail", IsUnique = true)]
public partial class MainConsumptionDetail
{
    [Key]
    [Column("MainConsDetailID")]
    public int MainConsDetailId { get; set; }

    /// <summary>
    /// Link to MainConsuption
    /// </summary>
    [Column("MainConsID")]
    public int? MainConsId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LotNo { get; set; } = null!;

    [Column("BudgetSourceID")]
    [StringLength(10)]
    [Unicode(false)]
    public string BudgetSourceId { get; set; } = null!;

    public int? SubBalance { get; set; }

    [Column("ADC")]
    public int? Adc { get; set; }

    [Column("DOS")]
    public double? Dos { get; set; }

    public int? Request { get; set; }

    public int? Supply { get; set; }

    public DateOnly? ExpDate { get; set; }

    public int? StockAvailable { get; set; }

    [ForeignKey("MainConsId")]
    [InverseProperty("MainConsumptionDetails")]
    public virtual MainConsumption? MainCons { get; set; }
}
