using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tbl2014_UserPermission")]
public partial class Tbl2014UserPermission
{
    [Column("UserPermission_ID")]
    public int UserPermissionId { get; set; }

    [Key]
    [Column("UserPermission_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserPermissionCode { get; set; } = null!;

    [Column("UserPermission_English")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserPermissionEnglish { get; set; } = null!;

    [Column("UserPermission_Khmer")]
    [StringLength(50)]
    public string UserPermissionKhmer { get; set; } = null!;

    [Column("UserPermission_IsActived")]
    public bool UserPermissionIsActived { get; set; }

    [Column("UserPermission_Description")]
    [StringLength(1000)]
    public string? UserPermissionDescription { get; set; }
}
