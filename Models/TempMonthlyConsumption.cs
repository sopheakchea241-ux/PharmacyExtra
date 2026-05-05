using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption")]
public partial class TempMonthlyConsumption
{
    [Column("CommID")]
    [StringLength(15)]
    public string? CommId { get; set; }

    [StringLength(150)]
    public string? CommName { get; set; }

    [StringLength(50)]
    public string? Form { get; set; }

    [StringLength(50)]
    public string? Dose { get; set; }

    public int Consumption { get; set; }

    [StringLength(10)]
    public string? ConsDay { get; set; }

    public int Total { get; set; }
}
