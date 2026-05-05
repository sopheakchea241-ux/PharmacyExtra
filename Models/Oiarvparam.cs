using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("OIARVParam")]
public partial class Oiarvparam
{
    [Key]
    [Column("ID")]
    public short Id { get; set; }

    [Column("QRRSheetName")]
    [StringLength(100)]
    public string? QrrsheetName { get; set; }

    [Column("QRRStartRow")]
    public short? QrrstartRow { get; set; }

    [Column("QRRCommIDCol")]
    public short? QrrcommIdcol { get; set; }

    [Column("QRRReqAmtCol")]
    public short? QrrreqAmtCol { get; set; }

    [Column("ARRSheetName")]
    [StringLength(100)]
    public string? ArrsheetName { get; set; }

    [Column("ARRStartRow")]
    public short? ArrstartRow { get; set; }

    [Column("ARRCommIDCol")]
    public short? ArrcommIdcol { get; set; }

    [Column("ARRReqAmtCol")]
    public short? ArrreqAmtCol { get; set; }
}
