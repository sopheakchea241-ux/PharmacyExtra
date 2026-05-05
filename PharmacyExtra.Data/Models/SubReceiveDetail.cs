using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubReceive_Detail")]
[Index("MainConsId", "CommodityId", Name = "IX_SubReceive_Detail", IsUnique = true)]
public partial class SubReceiveDetail
{
    [Key]
    [Column("MainConsDetailID")]
    public int MainConsDetailId { get; set; }

    [Column("MainConsID")]
    public long? MainConsId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    public int? Amount { get; set; }

    public DateOnly? ExpDate { get; set; }

    [ForeignKey("CommodityId")]
    [InverseProperty("SubReceiveDetails")]
    public virtual Commodity? Commodity { get; set; }

    [ForeignKey("MainConsId")]
    [InverseProperty("SubReceiveDetails")]
    public virtual SubReceive? MainCons { get; set; }
}
