using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubTransferOutDetail")]
public partial class SubTransferOutDetail
{
    [Key]
    [Column("SubTransOutDetailID")]
    public int SubTransOutDetailId { get; set; }

    [Column("SubTransOutID")]
    public int SubTransOutId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column("BSDID")]
    [StringLength(20)]
    public string? Bsdid { get; set; }

    public int? Qty { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [ForeignKey("SubTransOutId")]
    [InverseProperty("SubTransferOutDetails")]
    public virtual SubTransferOut SubTransOut { get; set; } = null!;
}
