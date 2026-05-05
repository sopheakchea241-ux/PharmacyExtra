using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSubIssueNotYetUpdate
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    public int? Supply { get; set; }

    [Column("SourSubPhaID")]
    [StringLength(10)]
    public string? SourSubPhaId { get; set; }
}
