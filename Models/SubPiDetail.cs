using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubPI_Detail")]
[Index("Piid", "CommodityId", Name = "IX_SubPI_Detail", IsUnique = true)]
public partial class SubPiDetail
{
    [Key]
    [Column("PIDetailID")]
    public long PidetailId { get; set; }

    [Column("PIID")]
    public int? Piid { get; set; }

    public DateOnly? LastStockDate { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CommodityId { get; set; }

    public DateOnly? ExpDate { get; set; }

    public int CurrentStock { get; set; }

    public int StockCount { get; set; }

    public int AdjQty { get; set; }

    [StringLength(100)]
    public string? TransNote { get; set; }

    public bool? IsLock { get; set; }

    [ForeignKey("Piid")]
    [InverseProperty("SubPiDetails")]
    public virtual SubPi? Pi { get; set; }
}
