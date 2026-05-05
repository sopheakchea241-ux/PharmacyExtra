using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VBudgetSource
{
    [Column("BudgetSourceID")]
    [StringLength(20)]
    public string BudgetSourceId { get; set; } = null!;

    [StringLength(50)]
    public string? BudgetSource { get; set; }
}
