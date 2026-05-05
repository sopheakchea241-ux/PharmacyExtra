using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("SelectedCommodityLot")]
public partial class SelectedCommodityLot
{
    public int Nº { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }
}
