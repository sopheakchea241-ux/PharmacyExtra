using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tbl2014_UserPharmacy")]
[Index("UserId", "PharmacyCode", Name = "IX_tbl2014_UserPharmacy", IsUnique = true)]
public partial class Tbl2014UserPharmacy
{
    [Key]
    [Column("UserPharmacy_ID")]
    public int UserPharmacyId { get; set; }

    [Column("User_ID")]
    [StringLength(50)]
    public string UserId { get; set; } = null!;

    [Column("Pharmacy_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string PharmacyCode { get; set; } = null!;
}
