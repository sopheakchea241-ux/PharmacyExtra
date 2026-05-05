using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubRequest_Detail")]
[Index("ReqPresNº", "CommodityId", Name = "IX_SubRequest_Detail", IsUnique = true)]
public partial class SubRequestDetail
{
    [Key]
    public int Nº { get; set; }

    public int ReqPresNº { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    public int? Quantity { get; set; }

    public int? StockAvailable { get; set; }

    [ForeignKey("ReqPresNº")]
    [InverseProperty("SubRequestDetails")]
    public virtual SubPrescription ReqPresNºNavigation { get; set; } = null!;
}
