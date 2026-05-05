using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblUsers")]
public partial class TblUser
{
    [Key]
    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [StringLength(50)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string Section { get; set; } = null!;

    [Column("SubPhaID")]
    [StringLength(50)]
    public string? SubPhaId { get; set; }

    [StringLength(50)]
    public string Permission { get; set; } = null!;
}
