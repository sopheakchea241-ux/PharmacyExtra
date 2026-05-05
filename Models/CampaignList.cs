using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("CampaignList")]
public partial class CampaignList
{
    [Key]
    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;
}
