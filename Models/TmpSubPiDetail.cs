using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubPI_Detail")]
public partial class TmpSubPiDetail
{
    [Column("PIDetailID")]
    public long PidetailId { get; set; }

    [Column("PIID")]
    public int? Piid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastStockDate { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    public long? CurrentStock { get; set; }

    public long? StockCount { get; set; }

    public long? AdjQty { get; set; }

    [StringLength(100)]
    public string? TransNote { get; set; }
}
