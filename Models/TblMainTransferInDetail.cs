using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblMainTransferInDetail")]
[Index("TransferInId", "CommodityId", "Bsdid", "ExpDate", Name = "IX_tblMainTransferInDetail", IsUnique = true)]
public partial class TblMainTransferInDetail
{
    [Key]
    [Column("TransferInDetailID")]
    public int TransferInDetailId { get; set; }

    [Column("TransferInID")]
    public int? TransferInId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column("BSDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string Bsdid { get; set; } = null!;

    public int? Qty { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(50)]
    public string? Notes { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? LotNo { get; set; }

    [ForeignKey("CommodityId")]
    [InverseProperty("TblMainTransferInDetails")]
    public virtual Commodity? Commodity { get; set; }

    [ForeignKey("TransferInId")]
    [InverseProperty("TblMainTransferInDetails")]
    public virtual TblMainTransferIn? TransferIn { get; set; }
}
