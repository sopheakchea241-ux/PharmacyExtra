using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubReceive_Detail")]
public partial class TmpSubReceiveDetail
{
    [Column("MainConsID")]
    public long? MainConsId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    public int? Amount { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }
}
