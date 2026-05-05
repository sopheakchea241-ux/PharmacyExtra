using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpStockStatusSummary")]
public partial class TmpStockStatusSummary
{
    [Column("OS")]
    public int? Os { get; set; }

    [Column("SO")]
    public int? So { get; set; }

    [Column("PSO")]
    public int? Pso { get; set; }

    [Column("SS")]
    public int? Ss { get; set; }

    [Column("OSPer")]
    public double? Osper { get; set; }

    [Column("SOPer")]
    public double? Soper { get; set; }

    [Column("PSOPer")]
    public double? Psoper { get; set; }

    [Column("SSPer")]
    public double? Ssper { get; set; }

    public int? Nº { get; set; }
}
