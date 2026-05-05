using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VLotNoBsource
{
    [StringLength(80)]
    public string? LotNo { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [Column("BudgetSourceID")]
    [StringLength(10)]
    public string? BudgetSourceId { get; set; }
}
