using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("AutoBackup")]
public partial class AutoBackup
{
    [StringLength(100)]
    public string? FeatureName { get; set; }

    public bool? IsAutoBackup { get; set; }
}
