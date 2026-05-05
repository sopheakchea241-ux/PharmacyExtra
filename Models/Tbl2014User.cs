using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tbl2014_User")]
public partial class Tbl2014User
{
    [Key]
    [Column("User_ID")]
    [StringLength(50)]
    public string UserId { get; set; } = null!;

    [Column("User_Password")]
    [StringLength(128)]
    public string UserPassword { get; set; } = null!;

    [Column("UserPermission_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserPermissionCode { get; set; } = null!;

    [Column("User_IsActived")]
    public bool UserIsActived { get; set; }

    [Column("User_Description")]
    [StringLength(1000)]
    public string? UserDescription { get; set; }

    [Column("User_IsLocked")]
    public bool UserIsLocked { get; set; }

    public bool? AllowAccess { get; set; }

    public bool? AllowDelete { get; set; }

    public bool? AllowPreview { get; set; }

    public bool? AllowApprove { get; set; }

    public bool? AllowUpdate { get; set; }
}
