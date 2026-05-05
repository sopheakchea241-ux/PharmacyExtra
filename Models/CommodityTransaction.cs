using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("CommodityTransaction")]
public partial class CommodityTransaction
{
    [Key]
    [Column("CommTransID")]
    public int CommTransId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(50)]
    public string? Belonging { get; set; }

    public bool? IsBySource { get; set; }

    [InverseProperty("CommTrans")]
    public virtual ICollection<CommodityTransactionDetail> CommodityTransactionDetails { get; set; } = new List<CommodityTransactionDetail>();
}
