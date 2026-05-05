using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyExtra.Web.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "kea");

            migrationBuilder.EnsureSchema(
                name: "kostar");

            migrationBuilder.EnsureSchema(
                name: "SreypovMain");

            migrationBuilder.CreateTable(
                name: "AMC",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AMC = table.Column<double>(type: "float", nullable: true),
                    ExportDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AutoBackup",
                columns: table => new
                {
                    FeatureName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsAutoBackup = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BudgetSource",
                columns: table => new
                {
                    BudgetSourceID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BudgetSource = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BudgetSourceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetSource", x => x.BudgetSourceID);
                });

            migrationBuilder.CreateTable(
                name: "CampaignList",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignList", x => x.CommodityID);
                });

            migrationBuilder.CreateTable(
                name: "Committee",
                columns: table => new
                {
                    Title = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleKhmer = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TitleEnglish = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Commodity Standard",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CommTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CommAbbrev = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CommForm = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MedicineStrength = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UsedINCPASpecial = table.Column<bool>(type: "bit", nullable: false),
                    UsedINCPA = table.Column<bool>(type: "bit", nullable: false),
                    UsedINMPA = table.Column<bool>(type: "bit", nullable: false),
                    UsedINKhum = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Multiplier = table.Column<int>(type: "int", nullable: true),
                    MPAMultiplier = table.Column<double>(type: "float", nullable: true),
                    CPAMultiplier = table.Column<double>(type: "float", nullable: true),
                    CPASMultiplier = table.Column<double>(type: "float", nullable: true),
                    CommodityNote = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    HC_Order = table.Column<double>(type: "float", nullable: true),
                    NonHC_Order = table.Column<double>(type: "float", nullable: true),
                    AnnDisp_Order = table.Column<double>(type: "float", nullable: true),
                    upsize_ts = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ExpRequire = table.Column<bool>(type: "bit", nullable: false),
                    KhumMult = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CommodityGroup",
                columns: table => new
                {
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CommGrpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommGrpNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityGroup", x => x.CommGrpID);
                });

            migrationBuilder.CreateTable(
                name: "CommodityTransaction",
                columns: table => new
                {
                    CommTransID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Belonging = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsBySource = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityTransaction", x => x.CommTransID);
                });

            migrationBuilder.CreateTable(
                name: "Consumption_Note",
                columns: table => new
                {
                    Nid = table.Column<int>(type: "int", nullable: false),
                    Noteabbr = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Notetype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FacilityType",
                columns: table => new
                {
                    FacilityTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FacilityTypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FacilityTypeNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FacilityTypeAbbrev = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FacilityTypeAbbrevKH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Tier = table.Column<short>(type: "smallint", nullable: true),
                    ReviewPeriod = table.Column<short>(type: "smallint", nullable: true),
                    FacilityTypeTotal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityType", x => x.FacilityTypeID);
                });

            migrationBuilder.CreateTable(
                name: "HosAdditional",
                columns: table => new
                {
                    ADDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOS_Need = table.Column<double>(type: "float", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    LastTransDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    ApprovedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CratedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HosAdditional", x => x.ADDID);
                });

            migrationBuilder.CreateTable(
                name: "HosAdditionalDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADDID = table.Column<int>(type: "int", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    InitialStock = table.Column<int>(type: "int", nullable: true),
                    Incoming = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Outgoing = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    AMC = table.Column<int>(type: "int", nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    MOS = table.Column<double>(type: "float", nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pharmacy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastReceivedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    StockOutDay = table.Column<int>(type: "int", nullable: true),
                    IsLock = table.Column<bool>(type: "bit", nullable: true),
                    IsOIARV = table.Column<bool>(type: "bit", nullable: true),
                    IsPrint = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HosAdditionalDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HosDirector",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HDName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsViceChief = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HosOrder",
                columns: table => new
                {
                    HosOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrevOrdDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    HosOrderDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ProvinceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HosID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Inpatient = table.Column<double>(type: "float", nullable: false),
                    OutPatient = table.Column<double>(type: "float", nullable: false),
                    SurgicalPatient = table.Column<double>(type: "float", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    SPiID = table.Column<double>(type: "float", nullable: true),
                    EPiID = table.Column<double>(type: "float", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HosOrder", x => x.HosOrderID);
                });

            migrationBuilder.CreateTable(
                name: "HosOrderApproval",
                columns: table => new
                {
                    HosOrderID = table.Column<double>(type: "float", nullable: true),
                    ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApproveDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ReportType = table.Column<int>(type: "int", nullable: true),
                    ApprovedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HosOrderDetail",
                columns: table => new
                {
                    HosOrderID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HosOrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginStock = table.Column<double>(type: "float", nullable: true),
                    ExtReceive = table.Column<double>(type: "float", nullable: true),
                    CMSReceive = table.Column<double>(type: "float", nullable: true),
                    Receive = table.Column<double>(type: "float", nullable: true),
                    AdjIncome = table.Column<double>(type: "float", nullable: true),
                    Available = table.Column<double>(type: "float", nullable: true),
                    ExtIssue = table.Column<double>(type: "float", nullable: true),
                    Issue = table.Column<double>(type: "float", nullable: true),
                    AdjustTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Adjust = table.Column<double>(type: "float", nullable: true),
                    EndStock = table.Column<double>(type: "float", nullable: true),
                    Request = table.Column<double>(type: "float", nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StockOutDay = table.Column<int>(type: "int", nullable: true),
                    Adjustment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RealAMC = table.Column<double>(type: "float", nullable: true),
                    AMCStandard = table.Column<double>(type: "float", nullable: true),
                    Pharmacy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsLock = table.Column<bool>(type: "bit", nullable: true),
                    IsOIARV = table.Column<bool>(type: "bit", nullable: true),
                    IsPrint = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HosOrderDetail", x => new { x.HosOrderID, x.CommodityID });
                });

            migrationBuilder.CreateTable(
                name: "InventoryType",
                columns: table => new
                {
                    InvTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    InvTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    InvTypeNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Value = table.Column<float>(type: "real", nullable: true),
                    InvCateID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    HCOrder = table.Column<float>(type: "real", nullable: true),
                    NonHCOrder = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MainConsumption",
                columns: table => new
                {
                    MainConsID = table.Column<int>(type: "int", nullable: false, comment: "Link to MainConsumption_Detail")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ConsumpDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainConsumption", x => x.MainConsID);
                });

            migrationBuilder.CreateTable(
                name: "MainTransaction",
                columns: table => new
                {
                    MainTransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    LotNo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    BudgetSourceID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TransDate = table.Column<DateOnly>(type: "date", nullable: true),
                    InvoiceID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FacilityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SubBalance = table.Column<long>(type: "bigint", nullable: true),
                    StockonHand = table.Column<long>(type: "bigint", nullable: false),
                    TransNote = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.MainTransactionID);
                });

            migrationBuilder.CreateTable(
                name: "MainTransfer",
                columns: table => new
                {
                    TransferID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TransferDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainTransfer", x => x.TransferID);
                });

            migrationBuilder.CreateTable(
                name: "NoteLookUp",
                columns: table => new
                {
                    NoteID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NoteAbbr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OIARVParam",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QRRSheetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QRRStartRow = table.Column<short>(type: "smallint", nullable: true),
                    QRRCommIDCol = table.Column<short>(type: "smallint", nullable: true),
                    QRRReqAmtCol = table.Column<short>(type: "smallint", nullable: true),
                    ARRSheetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ARRStartRow = table.Column<short>(type: "smallint", nullable: true),
                    ARRCommIDCol = table.Column<short>(type: "smallint", nullable: true),
                    ARRReqAmtCol = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OIARVParam", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PI",
                columns: table => new
                {
                    PIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    PIType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PI", x => x.PIID);
                });

            migrationBuilder.CreateTable(
                name: "ProcessLog",
                columns: table => new
                {
                    RecordID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProvinceNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveInvoice",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    BudgetSourceID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ArriveDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IssueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveInvoice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveInvoice_Detail",
                columns: table => new
                {
                    ReceiveDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "Link to ReceiveInvoice"),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BudgetSourceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ReceiveInvoice_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveInvoice_Detail", x => x.ReceiveDetailID);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveInvoiceReport",
                columns: table => new
                {
                    InvoiceID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Semester = table.Column<short>(type: "smallint", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    ReceiveInvoice_ID = table.Column<long>(type: "bigint", nullable: true),
                    BudgetSourceID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveInvoiceReport", x => x.InvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveInvoiceReport_Detail",
                columns: table => new
                {
                    ReceiveDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: true),
                    ReceiveAmount = table.Column<long>(type: "bigint", nullable: true),
                    AdjQty = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceiveInvoice_ID = table.Column<long>(type: "bigint", nullable: true),
                    OriginalExpDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveInvoiceReport_Detail", x => x.ReceiveDetailID);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveInvoiceReportAdjNote",
                columns: table => new
                {
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveInvoiceReportAdjNote", x => x.Note);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveInvoiceReportNote",
                columns: table => new
                {
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SelectedCommodity",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedCommodity", x => x.CommodityID);
                });

            migrationBuilder.CreateTable(
                name: "SelectedCommodityLot",
                columns: table => new
                {
                    Nº = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotNo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SourceDestination",
                columns: table => new
                {
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SourceDestination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsClass1 = table.Column<bool>(type: "bit", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSource = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceDestination", x => x.SDID);
                });

            migrationBuilder.CreateTable(
                name: "SubAdditional",
                columns: table => new
                {
                    ADDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOS_Need = table.Column<short>(type: "smallint", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    IsImported = table.Column<bool>(type: "bit", nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAdditional", x => x.ADDID);
                });

            migrationBuilder.CreateTable(
                name: "SubConsumption",
                columns: table => new
                {
                    SubConsID = table.Column<long>(type: "bigint", nullable: false, comment: "Link to IPDConsumption_Detail")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    WardID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ConsumpDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReportDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReportNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OutPatient = table.Column<int>(type: "int", nullable: true),
                    Inpatient = table.Column<int>(type: "int", nullable: true),
                    SurgicalPatient = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDConsumption", x => x.SubConsID);
                });

            migrationBuilder.CreateTable(
                name: "SubIssue",
                columns: table => new
                {
                    SubIssueID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SourSubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DestSubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubIssue", x => x.SubIssueID);
                });

            migrationBuilder.CreateTable(
                name: "SubOrder",
                columns: table => new
                {
                    HosOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrevOrdDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    HosOrderDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ProvinceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HosID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifiedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Inpatient = table.Column<double>(type: "float", nullable: true),
                    OutPatient = table.Column<double>(type: "float", nullable: true),
                    SurgicalPatient = table.Column<double>(type: "float", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    SPiID = table.Column<double>(type: "float", nullable: true),
                    EPiID = table.Column<double>(type: "float", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    IsImported = table.Column<bool>(type: "bit", nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOrder", x => x.HosOrderID);
                });

            migrationBuilder.CreateTable(
                name: "SubPI",
                columns: table => new
                {
                    PIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    PIType = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    SubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPI", x => x.PIID);
                });

            migrationBuilder.CreateTable(
                name: "SubReceive",
                columns: table => new
                {
                    MainConsID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ConsumpDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    SubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    InvoiceID = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReceive", x => x.MainConsID);
                });

            migrationBuilder.CreateTable(
                name: "SubRequest",
                columns: table => new
                {
                    RequestNº = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    WardID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IsImported = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    SubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    UniqueID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRequest", x => x.RequestNº);
                });

            migrationBuilder.CreateTable(
                name: "SubTransaction",
                columns: table => new
                {
                    SubTransactionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    WardID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    StockonHand = table.Column<long>(type: "bigint", nullable: false),
                    TransNote = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDTransaction", x => x.SubTransactionID);
                });

            migrationBuilder.CreateTable(
                name: "SubTransferOut",
                columns: table => new
                {
                    SubTransOutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TransferDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTransferOut", x => x.SubTransOutID);
                });

            migrationBuilder.CreateTable(
                name: "SysParam",
                columns: table => new
                {
                    SysID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FacilityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SysName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SysNameKh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HosName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HosNameKh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SysPeriod = table.Column<int>(type: "int", nullable: true),
                    SysBeginDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ProvinceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DefStortType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HosAMC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaxMOS = table.Column<int>(type: "int", nullable: false),
                    ReviewPeriod = table.Column<int>(type: "int", nullable: true),
                    YearlyMultiplier = table.Column<int>(type: "int", nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    ShowStockOut = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    HosLevel = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Replenish = table.Column<int>(type: "int", nullable: true),
                    FacilityType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SupervisedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FacilityTypeEN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SupervisedByEN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HosKhmerUnicode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    Expire = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysParam", x => x.SysID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_HosReport_Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransactionOption = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    FilterOption = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CommTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_HosReport_Transaction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_HosReport_TransactionDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BeginStock = table.Column<int>(type: "int", nullable: false),
                    Incoming = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Outgoing = table.Column<int>(type: "int", nullable: false),
                    Adjustment = table.Column<int>(type: "int", nullable: false),
                    EndStock = table.Column<int>(type: "int", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_HosReport_TransactionDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_MainReport_Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_MainReport_Transaction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_MainReport_Transaction_Source",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_MainReport_Transaction_Source", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_MainReport_Transaction_SourceDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BudgetSourceID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    BeginStock = table.Column<int>(type: "int", nullable: false),
                    Incoming = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Outgoing = table.Column<int>(type: "int", nullable: false),
                    Adjustment = table.Column<int>(type: "int", nullable: false),
                    EndStock = table.Column<int>(type: "int", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_MainReport_Transaction_SourceDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_MainReport_TransactionDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BeginStock = table.Column<int>(type: "int", nullable: false),
                    Incoming = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Outgoing = table.Column<int>(type: "int", nullable: false),
                    Adjustment = table.Column<int>(type: "int", nullable: false),
                    EndStock = table.Column<int>(type: "int", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_MainReport_TransactionDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_SubReport_Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SubPhaID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_SubReport_Transaction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_SubReport_TransactionDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BeginStock = table.Column<int>(type: "int", nullable: false),
                    Incoming = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Outgoing = table.Column<int>(type: "int", nullable: false),
                    Adjustment = table.Column<int>(type: "int", nullable: false),
                    EndStock = table.Column<int>(type: "int", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_SubReport_TransactionDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_User",
                columns: table => new
                {
                    User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserPermission_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    User_IsActived = table.Column<bool>(type: "bit", nullable: false),
                    User_Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    User_IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    AllowAccess = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    AllowDelete = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    AllowPreview = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    AllowApprove = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    AllowUpdate = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_User", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_UserPermission",
                columns: table => new
                {
                    UserPermission_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserPermission_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPermission_English = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserPermission_Khmer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserPermission_IsActived = table.Column<bool>(type: "bit", nullable: false),
                    UserPermission_Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_UserPermission", x => x.UserPermission_Code);
                });

            migrationBuilder.CreateTable(
                name: "tbl2014_UserPharmacy",
                columns: table => new
                {
                    UserPharmacy_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pharmacy_Code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl2014_UserPharmacy", x => x.UserPharmacy_ID);
                });

            migrationBuilder.CreateTable(
                name: "tblCNM_HosReport_Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ForMonth = table.Column<int>(type: "int", nullable: false),
                    ForYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCNM_HosReport_Transaction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblCNM_HosReport_TransactionDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BeginStock = table.Column<int>(type: "int", nullable: false),
                    Incoming = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Outgoing = table.Column<int>(type: "int", nullable: false),
                    Adjustment = table.Column<int>(type: "int", nullable: false),
                    EndStock = table.Column<int>(type: "int", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCNM_HosReport_TransactionDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "TblConsumption",
                columns: table => new
                {
                    SubConsID = table.Column<int>(type: "int", nullable: false),
                    UniqueID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WardID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConsumpDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReportNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OutPatient = table.Column<double>(type: "float", nullable: true),
                    Inpatient = table.Column<double>(type: "float", nullable: true),
                    SurgicalPatient = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TblConsumption_Detail",
                columns: table => new
                {
                    ConCommID = table.Column<int>(type: "int", nullable: false),
                    ConsumpID = table.Column<int>(type: "int", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    Supply = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TblErrorDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    ErrDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Fixed = table.Column<bool>(type: "bit", nullable: false),
                    ErrType = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblHosRequest",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    InPatient = table.Column<int>(type: "int", nullable: false),
                    OutPatient = table.Column<int>(type: "int", nullable: false),
                    SurgicalPatient = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHosOrder", x => x.RequestID);
                });

            migrationBuilder.CreateTable(
                name: "tblMainMonthlyTransaction",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    InPatient = table.Column<int>(type: "int", nullable: false),
                    OutPatient = table.Column<int>(type: "int", nullable: false),
                    SurgicalPatient = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataMode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMainMonthlyTransaction", x => x.ReportID);
                });

            migrationBuilder.CreateTable(
                name: "tblMainTransferIn",
                columns: table => new
                {
                    TransferInID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    IssueDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMainTransferIn", x => x.TransferInID);
                });

            migrationBuilder.CreateTable(
                name: "tblNote",
                columns: table => new
                {
                    Nid = table.Column<int>(type: "int", nullable: false),
                    Noteabbr = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Notetype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdjSign = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    IsActived = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TblParameter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    HosOrderDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateStockUpdate = table.Column<DateOnly>(type: "date", nullable: true),
                    InvoiceID = table.Column<double>(type: "float", nullable: true),
                    Pharmacy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblPharmacyWard",
                columns: table => new
                {
                    PWID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WardID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPharmacyWard", x => x.PWID);
                });

            migrationBuilder.CreateTable(
                name: "tblReportNote",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ReportNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblSubPharmacy",
                columns: table => new
                {
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SubPhaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsSeparateRequest = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubPharmacy", x => x.SubPhaID);
                });

            migrationBuilder.CreateTable(
                name: "tblTemp_Invoice_Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    InvName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AddName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    InvAbbrev = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Strength = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FormID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RouteID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvTypeID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvStandardTypeID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CategoryID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Memo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Memo1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IUID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IssueSize = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MinStockE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaxStockE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ForPer = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ProPer = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CatalogRef = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StrTemp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WHO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LevUseID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VitalID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ABCClass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TheraClassID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ATCClass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DDD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DDDUnit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NatFormul = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RegFormul = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DutyRate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ColCont = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Controlled = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Schedule = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FacOFr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StoOFr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Forex = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nature = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ExcStockOut = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AdjFactor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    UsedInMPA = table.Column<bool>(type: "bit", nullable: true),
                    MPAMulti = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    UsedInCPA = table.Column<bool>(type: "bit", nullable: true),
                    CPAMulti = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    UsedInCPAS = table.Column<bool>(type: "bit", nullable: true),
                    CPASMulti = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    NonHCOrder = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    HCOrder = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ExpDate = table.Column<bool>(type: "bit", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InsertedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblTemp_Invoice_InvGroup",
                columns: table => new
                {
                    InvGroupID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvGroupName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvGroupNameKH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblTemp_Invoice_Invoice",
                columns: table => new
                {
                    InvoiceID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvoiceName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FacilityID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FacName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProvinceID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OrdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NB = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    WBADB = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Other = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblTemp_Invoice_InvoiceDetail",
                columns: table => new
                {
                    LotNo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    InvoiceID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InventoryID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Strength = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LotNum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SuppQty = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    NB = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    WBADB = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Other = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblTemp_Invoice_InvType",
                columns: table => new
                {
                    InvTypeID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InvTypeNameKH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Value = table.Column<int>(type: "int", nullable: true),
                    InvGroupID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HCOrder = table.Column<int>(type: "int", nullable: true),
                    NonHCOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Section = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubPhaID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "tempHospitalStockOnhand",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Main = table.Column<double>(type: "float", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempHospitalStockOnhand",
                schema: "kea",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Main = table.Column<double>(type: "float", nullable: true),
                    SPH01 = table.Column<double>(type: "float", nullable: true),
                    SPH02 = table.Column<double>(type: "float", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempHospitalStockOnhand",
                schema: "kostar",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Main = table.Column<double>(type: "float", nullable: true),
                    SPH01 = table.Column<double>(type: "float", nullable: true),
                    SPH02 = table.Column<double>(type: "float", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempHospitalStockOnhand",
                schema: "SreypovMain",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Main = table.Column<double>(type: "float", nullable: true),
                    SPH01 = table.Column<double>(type: "float", nullable: true),
                    SPH02 = table.Column<double>(type: "float", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption",
                columns: table => new
                {
                    CommID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Consumption = table.Column<int>(type: "int", nullable: false),
                    ConsDay = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption_By_DayADMIN-1C24D7503",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    _101 = table.Column<int>(name: "1/01", type: "int", nullable: true),
                    _201 = table.Column<int>(name: "2/01", type: "int", nullable: true),
                    _301 = table.Column<int>(name: "3/01", type: "int", nullable: true),
                    _401 = table.Column<int>(name: "4/01", type: "int", nullable: true),
                    _501 = table.Column<int>(name: "5/01", type: "int", nullable: true),
                    _601 = table.Column<int>(name: "6/01", type: "int", nullable: true),
                    _701 = table.Column<int>(name: "7/01", type: "int", nullable: true),
                    _801 = table.Column<int>(name: "8/01", type: "int", nullable: true),
                    _901 = table.Column<int>(name: "9/01", type: "int", nullable: true),
                    _1001 = table.Column<int>(name: "10/01", type: "int", nullable: true),
                    _1101 = table.Column<int>(name: "11/01", type: "int", nullable: true),
                    _1201 = table.Column<int>(name: "12/01", type: "int", nullable: true),
                    _1301 = table.Column<int>(name: "13/01", type: "int", nullable: true),
                    _1401 = table.Column<int>(name: "14/01", type: "int", nullable: true),
                    _1501 = table.Column<int>(name: "15/01", type: "int", nullable: true),
                    _1601 = table.Column<int>(name: "16/01", type: "int", nullable: true),
                    _1701 = table.Column<int>(name: "17/01", type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption_By_DayHOSDID-MAIN",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    _106 = table.Column<int>(name: "1/06", type: "int", nullable: true),
                    _206 = table.Column<int>(name: "2/06", type: "int", nullable: true),
                    _306 = table.Column<int>(name: "3/06", type: "int", nullable: true),
                    _406 = table.Column<int>(name: "4/06", type: "int", nullable: true),
                    _506 = table.Column<int>(name: "5/06", type: "int", nullable: true),
                    _606 = table.Column<int>(name: "6/06", type: "int", nullable: true),
                    _706 = table.Column<int>(name: "7/06", type: "int", nullable: true),
                    _806 = table.Column<int>(name: "8/06", type: "int", nullable: true),
                    _906 = table.Column<int>(name: "9/06", type: "int", nullable: true),
                    _1006 = table.Column<int>(name: "10/06", type: "int", nullable: true),
                    _1106 = table.Column<int>(name: "11/06", type: "int", nullable: true),
                    _1206 = table.Column<int>(name: "12/06", type: "int", nullable: true),
                    _1306 = table.Column<int>(name: "13/06", type: "int", nullable: true),
                    _1406 = table.Column<int>(name: "14/06", type: "int", nullable: true),
                    _1506 = table.Column<int>(name: "15/06", type: "int", nullable: true),
                    _1606 = table.Column<int>(name: "16/06", type: "int", nullable: true),
                    _1706 = table.Column<int>(name: "17/06", type: "int", nullable: true),
                    _1806 = table.Column<int>(name: "18/06", type: "int", nullable: true),
                    _1906 = table.Column<int>(name: "19/06", type: "int", nullable: true),
                    _2006 = table.Column<int>(name: "20/06", type: "int", nullable: true),
                    _2106 = table.Column<int>(name: "21/06", type: "int", nullable: true),
                    _2206 = table.Column<int>(name: "22/06", type: "int", nullable: true),
                    _2306 = table.Column<int>(name: "23/06", type: "int", nullable: true),
                    _2406 = table.Column<int>(name: "24/06", type: "int", nullable: true),
                    _2506 = table.Column<int>(name: "25/06", type: "int", nullable: true),
                    _2606 = table.Column<int>(name: "26/06", type: "int", nullable: true),
                    _2706 = table.Column<int>(name: "27/06", type: "int", nullable: true),
                    _2806 = table.Column<int>(name: "28/06", type: "int", nullable: true),
                    _2906 = table.Column<int>(name: "29/06", type: "int", nullable: true),
                    _3006 = table.Column<int>(name: "30/06", type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption_By_DayHOSDID02",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    _107 = table.Column<int>(name: "1/07", type: "int", nullable: true),
                    _207 = table.Column<int>(name: "2/07", type: "int", nullable: true),
                    _307 = table.Column<int>(name: "3/07", type: "int", nullable: true),
                    _407 = table.Column<int>(name: "4/07", type: "int", nullable: true),
                    _507 = table.Column<int>(name: "5/07", type: "int", nullable: true),
                    _607 = table.Column<int>(name: "6/07", type: "int", nullable: true),
                    _707 = table.Column<int>(name: "7/07", type: "int", nullable: true),
                    _807 = table.Column<int>(name: "8/07", type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption_By_DayHOSDID03",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    _107 = table.Column<int>(name: "1/07", type: "int", nullable: true),
                    _207 = table.Column<int>(name: "2/07", type: "int", nullable: true),
                    _307 = table.Column<int>(name: "3/07", type: "int", nullable: true),
                    _407 = table.Column<int>(name: "4/07", type: "int", nullable: true),
                    _507 = table.Column<int>(name: "5/07", type: "int", nullable: true),
                    _607 = table.Column<int>(name: "6/07", type: "int", nullable: true),
                    _707 = table.Column<int>(name: "7/07", type: "int", nullable: true),
                    _807 = table.Column<int>(name: "8/07", type: "int", nullable: true),
                    _907 = table.Column<int>(name: "9/07", type: "int", nullable: true),
                    _1007 = table.Column<int>(name: "10/07", type: "int", nullable: true),
                    _1107 = table.Column<int>(name: "11/07", type: "int", nullable: true),
                    _1207 = table.Column<int>(name: "12/07", type: "int", nullable: true),
                    _1307 = table.Column<int>(name: "13/07", type: "int", nullable: true),
                    _1407 = table.Column<int>(name: "14/07", type: "int", nullable: true),
                    _1507 = table.Column<int>(name: "15/07", type: "int", nullable: true),
                    _1607 = table.Column<int>(name: "16/07", type: "int", nullable: true),
                    _1707 = table.Column<int>(name: "17/07", type: "int", nullable: true),
                    _1807 = table.Column<int>(name: "18/07", type: "int", nullable: true),
                    _1907 = table.Column<int>(name: "19/07", type: "int", nullable: true),
                    _2007 = table.Column<int>(name: "20/07", type: "int", nullable: true),
                    _2107 = table.Column<int>(name: "21/07", type: "int", nullable: true),
                    _2207 = table.Column<int>(name: "22/07", type: "int", nullable: true),
                    _2307 = table.Column<int>(name: "23/07", type: "int", nullable: true),
                    _2407 = table.Column<int>(name: "24/07", type: "int", nullable: true),
                    _2507 = table.Column<int>(name: "25/07", type: "int", nullable: true),
                    _2607 = table.Column<int>(name: "26/07", type: "int", nullable: true),
                    _2707 = table.Column<int>(name: "27/07", type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption_By_DayNH-KOSAMAK",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    _109 = table.Column<int>(name: "1/09", type: "int", nullable: true),
                    _209 = table.Column<int>(name: "2/09", type: "int", nullable: true),
                    _309 = table.Column<int>(name: "3/09", type: "int", nullable: true),
                    _409 = table.Column<int>(name: "4/09", type: "int", nullable: true),
                    _509 = table.Column<int>(name: "5/09", type: "int", nullable: true),
                    _609 = table.Column<int>(name: "6/09", type: "int", nullable: true),
                    _709 = table.Column<int>(name: "7/09", type: "int", nullable: true),
                    _809 = table.Column<int>(name: "8/09", type: "int", nullable: true),
                    _909 = table.Column<int>(name: "9/09", type: "int", nullable: true),
                    _1009 = table.Column<int>(name: "10/09", type: "int", nullable: true),
                    _1109 = table.Column<int>(name: "11/09", type: "int", nullable: true),
                    _1209 = table.Column<int>(name: "12/09", type: "int", nullable: true),
                    _1309 = table.Column<int>(name: "13/09", type: "int", nullable: true),
                    _1409 = table.Column<int>(name: "14/09", type: "int", nullable: true),
                    _1509 = table.Column<int>(name: "15/09", type: "int", nullable: true),
                    _1609 = table.Column<int>(name: "16/09", type: "int", nullable: true),
                    _1709 = table.Column<int>(name: "17/09", type: "int", nullable: true),
                    _1809 = table.Column<int>(name: "18/09", type: "int", nullable: true),
                    _1909 = table.Column<int>(name: "19/09", type: "int", nullable: true),
                    _2009 = table.Column<int>(name: "20/09", type: "int", nullable: true),
                    _2109 = table.Column<int>(name: "21/09", type: "int", nullable: true),
                    _2209 = table.Column<int>(name: "22/09", type: "int", nullable: true),
                    _2309 = table.Column<int>(name: "23/09", type: "int", nullable: true),
                    _2409 = table.Column<int>(name: "24/09", type: "int", nullable: true),
                    _2509 = table.Column<int>(name: "25/09", type: "int", nullable: true),
                    _2609 = table.Column<int>(name: "26/09", type: "int", nullable: true),
                    _2709 = table.Column<int>(name: "27/09", type: "int", nullable: true),
                    _2809 = table.Column<int>(name: "28/09", type: "int", nullable: true),
                    _2909 = table.Column<int>(name: "29/09", type: "int", nullable: true),
                    _3009 = table.Column<int>(name: "30/09", type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempMonthlyConsumption_By_DayPHARMACY-PC",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    _2010 = table.Column<int>(name: "20/10", type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpCommodity",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CommAbbrev = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CommCateID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    UsedInMPA = table.Column<bool>(type: "bit", nullable: true),
                    UsedInCPA1 = table.Column<bool>(type: "bit", nullable: true),
                    UsedInCPA2 = table.Column<bool>(type: "bit", nullable: true),
                    UsedInCPA3 = table.Column<bool>(type: "bit", nullable: true),
                    UsedInCPAS = table.Column<bool>(type: "bit", nullable: true),
                    MPAMultiplier = table.Column<float>(type: "real", nullable: true),
                    CPA1Multiplier = table.Column<float>(type: "real", nullable: true),
                    CPA2Multiplier = table.Column<float>(type: "real", nullable: true),
                    CPA3Multiplier = table.Column<float>(type: "real", nullable: true),
                    CPASMultiplier = table.Column<float>(type: "real", nullable: true),
                    ExpDate = table.Column<bool>(type: "bit", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InsertedBy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    AnnDisp_Order = table.Column<int>(type: "int", nullable: true),
                    Upsize_ts = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExpRequire = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpCommodityCategory",
                columns: table => new
                {
                    CommCateID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CommCateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CommCateNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CommCateDesc = table.Column<string>(type: "ntext", nullable: true),
                    CommCateDescKH = table.Column<string>(type: "ntext", nullable: true),
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpCommodityGroup",
                columns: table => new
                {
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CommGrpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommGrpNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpCommodityType",
                columns: table => new
                {
                    CommTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CommTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CommTypeNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CategoryID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    HaveQuota = table.Column<bool>(type: "bit", nullable: true),
                    Abbr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpMainStockCard15Days1",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    LotNo = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    TransGroup = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransName = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SourceDestination = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SubBalance = table.Column<int>(type: "int", nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    TransNote = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransDes = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    TransYear = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    MainTransactionID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BudgetSource = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpMainStockCard15Days2",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Strength = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    LotNo = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    TransName = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SD = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SubBalance = table.Column<int>(type: "int", nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    ExpiredDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransYear = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BudgetSource = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    MainTransactionID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpMainStockCard15Days3",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    LotNo = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    SD = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SubBalance = table.Column<int>(type: "int", nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    ExpiredDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransYear = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BudgetSource = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    MainTransactionID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpMainStockCardEveryDay",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    TransGroup = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TransName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SourceDestination = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubBalance = table.Column<int>(type: "int", nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    TransNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransDes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TransYear = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MainTransactionID = table.Column<int>(type: "int", nullable: true),
                    BudgetSource = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpReceiveInvoice",
                columns: table => new
                {
                    InvoiceID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BudgetSourceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ArriveDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HosOrderID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockBalancing",
                columns: table => new
                {
                    LastStockDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    SOH = table.Column<int>(type: "int", nullable: true),
                    AMCReal = table.Column<int>(type: "int", nullable: true),
                    MOS = table.Column<int>(type: "int", nullable: true),
                    AMCReal_HF = table.Column<int>(type: "int", nullable: true),
                    AMCStd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockBalancingDetail",
                columns: table => new
                {
                    LastStockDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LotNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SOH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockCard",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StockonHand = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CommForm = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MedicineStrength = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TransName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDestination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockCardAll",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StockonHand = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CommForm = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MedicineStrength = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TransName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDestination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockOnhand",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CommForm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MedicineStrength = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StockOnhand = table.Column<double>(type: "float", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    LastTranDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockStatus",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CommName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Balance = table.Column<long>(type: "bigint", nullable: true),
                    AMC = table.Column<long>(type: "bigint", nullable: true),
                    MOS = table.Column<double>(type: "float", nullable: true),
                    StockStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CommGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CommType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nº = table.Column<int>(type: "int", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpStockStatusSummary",
                columns: table => new
                {
                    OS = table.Column<int>(type: "int", nullable: true),
                    SO = table.Column<int>(type: "int", nullable: true),
                    PSO = table.Column<int>(type: "int", nullable: true),
                    SS = table.Column<int>(type: "int", nullable: true),
                    OSPer = table.Column<double>(type: "float", nullable: true),
                    SOPer = table.Column<double>(type: "float", nullable: true),
                    PSOPer = table.Column<double>(type: "float", nullable: true),
                    SSPer = table.Column<double>(type: "float", nullable: true),
                    Nº = table.Column<int>(type: "int", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubConsumption",
                columns: table => new
                {
                    SubConsID = table.Column<long>(type: "bigint", nullable: false),
                    UniqueID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WardID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ConsumpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ReportNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OutPatient = table.Column<int>(type: "int", nullable: true),
                    Inpatient = table.Column<int>(type: "int", nullable: true),
                    SurgicalPatient = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    IsImported = table.Column<bool>(type: "bit", nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubConsumption_Detail",
                columns: table => new
                {
                    SubConsDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubConsID = table.Column<long>(type: "bigint", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    Supply = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubPI",
                columns: table => new
                {
                    PIID = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    PIType = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubPI_Detail",
                columns: table => new
                {
                    PIDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIID = table.Column<int>(type: "int", nullable: true),
                    LastStockDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CurrentStock = table.Column<long>(type: "bigint", nullable: true),
                    StockCount = table.Column<long>(type: "bigint", nullable: true),
                    AdjQty = table.Column<long>(type: "bigint", nullable: true),
                    TransNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubPrescription",
                columns: table => new
                {
                    ReqPresNº = table.Column<int>(type: "int", nullable: false),
                    RequestNº = table.Column<int>(type: "int", nullable: true),
                    PrescriptionNº = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubReceive",
                columns: table => new
                {
                    MainConsID = table.Column<long>(type: "bigint", nullable: false),
                    UniqueID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ConsumpDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    InvoiceID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubReceive_Detail",
                columns: table => new
                {
                    MainConsID = table.Column<long>(type: "bigint", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubRequest",
                columns: table => new
                {
                    RequestNº = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WardID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsImported = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsSaved = table.Column<bool>(type: "bit", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubRequest_Detail",
                columns: table => new
                {
                    Nº = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReqPresNº = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubStockCard15Days1",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Strength = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    TransGroup = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransName = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SourceDestination = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    TransNote = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransYear = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransDes = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SubTransactionID = table.Column<int>(type: "int", nullable: true),
                    TransTypeID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WardName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubStockCard15Days2",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Strength = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    TransName = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SourceDestination = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransYear = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransDes = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WardName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubTransactionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubStockCard15Days3",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    CommodityName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Strength = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    TransName = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SourceDestination = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransYear = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    TransDes = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WardName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubTransactionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubStockCardDaily",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    TransGroup = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TransName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SourceDestination = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StockOnHand = table.Column<int>(type: "int", nullable: true),
                    MaxSOH = table.Column<int>(type: "int", nullable: true),
                    TransNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    TransYear = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TransDes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubTransactionID = table.Column<long>(type: "bigint", nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    WardName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmpSubTransaction",
                columns: table => new
                {
                    SubTransactionID = table.Column<int>(type: "int", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    TransDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InvoiceID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TransQty = table.Column<int>(type: "int", nullable: true),
                    SDID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WardID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StockonHand = table.Column<int>(type: "int", nullable: true),
                    TransNote = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SubPhaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Cycle = table.Column<int>(type: "int", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TransName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    WardID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WardNameEng = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WardNameFr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Abbr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.WardID);
                });

            migrationBuilder.CreateTable(
                name: "YearlyEstimate",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_From = table.Column<DateOnly>(type: "date", nullable: false),
                    Date_To = table.Column<DateOnly>(type: "date", nullable: false),
                    For_Year = table.Column<int>(type: "int", nullable: false),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    ApprovedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    CratedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "YearlyEstimate_Detail",
                columns: table => new
                {
                    mAuto = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SOH = table.Column<long>(type: "bigint", nullable: true),
                    AMC = table.Column<double>(type: "float", nullable: true),
                    Needs = table.Column<long>(type: "bigint", nullable: true),
                    Recommended = table.Column<long>(type: "bigint", nullable: true),
                    Incoming = table.Column<long>(type: "bigint", nullable: true),
                    Outgoing = table.Column<long>(type: "bigint", nullable: true),
                    IsPrint = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CommodityCategory",
                columns: table => new
                {
                    CommCateID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CommCateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CommCateNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CommCateDesc = table.Column<string>(type: "ntext", nullable: true),
                    CommCateDescKH = table.Column<string>(type: "ntext", nullable: true),
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true, comment: "Link to CommodityGroup")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityCategory", x => x.CommCateID);
                    table.ForeignKey(
                        name: "FK_CommodityCategory_CommodityGroup",
                        column: x => x.CommGrpID,
                        principalTable: "CommodityGroup",
                        principalColumn: "CommGrpID");
                });

            migrationBuilder.CreateTable(
                name: "MainConsumption_Detail",
                columns: table => new
                {
                    MainConsDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainConsID = table.Column<int>(type: "int", nullable: true, comment: "Link to MainConsuption"),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    LotNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BudgetSourceID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SubBalance = table.Column<int>(type: "int", nullable: true),
                    ADC = table.Column<int>(type: "int", nullable: true),
                    DOS = table.Column<double>(type: "float", nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    Supply = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    StockAvailable = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainConsumption_Detail", x => x.MainConsDetailID);
                    table.ForeignKey(
                        name: "FK_MainConsumption_Detail_MainConsumption",
                        column: x => x.MainConsID,
                        principalTable: "MainConsumption",
                        principalColumn: "MainConsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainTransfer_Detail",
                columns: table => new
                {
                    TransferDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    LotNo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    BudgetSourceID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: true, comment: "Transfer Quantity"),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StockAvailable = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainTransfer_Detail", x => x.TransferDetailID);
                    table.ForeignKey(
                        name: "FK_MainTransfer_Detail_MainTransfer",
                        column: x => x.TransferID,
                        principalTable: "MainTransfer",
                        principalColumn: "TransferID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PI_Detail",
                columns: table => new
                {
                    PIDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIID = table.Column<int>(type: "int", nullable: true, comment: "Link to PI"),
                    LastStockDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    LotNo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    BudgetSourceID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    AdjQty = table.Column<int>(type: "int", nullable: false),
                    TransNote = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsLock = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PI_Detail", x => x.PIDetailID);
                    table.ForeignKey(
                        name: "FK_PI_Detail_PI",
                        column: x => x.PIID,
                        principalTable: "PI",
                        principalColumn: "PIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistNameKh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProvinceID = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false, comment: "Link to Province")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_District_Province",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID");
                });

            migrationBuilder.CreateTable(
                name: "RIRCommittee",
                columns: table => new
                {
                    Nº = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Participant = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    ReceiveInvoice_ID = table.Column<long>(type: "bigint", nullable: true),
                    Committee_Unicode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "SQL_Latin1_General_CP437_BIN")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RIRCommittee_ReceiveInvoiceReport",
                        column: x => x.InvoiceID,
                        principalTable: "ReceiveInvoiceReport",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubAdditionalDetails",
                columns: table => new
                {
                    ADDID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitialStock = table.Column<int>(type: "int", nullable: true),
                    Incoming = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Outgoing = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    AMC = table.Column<int>(type: "int", nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    MOS = table.Column<double>(type: "float", nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAdditionalDetails", x => new { x.ADDID, x.CommodityID });
                    table.ForeignKey(
                        name: "FK_SubAdditionalDetails_SubAdditional",
                        column: x => x.ADDID,
                        principalTable: "SubAdditional",
                        principalColumn: "ADDID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubConsumption_Detail",
                columns: table => new
                {
                    SubConsDetailID = table.Column<long>(type: "bigint", nullable: false, comment: "IPDConsumptionDetailID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubConsID = table.Column<long>(type: "bigint", nullable: true, comment: "Link to SubConsumption"),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    Supply = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StockAvailable = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubConsumption_Detail", x => x.SubConsDetailID);
                    table.ForeignKey(
                        name: "FK_SubConsumption_Detail_SubConsumption",
                        column: x => x.SubConsID,
                        principalTable: "SubConsumption",
                        principalColumn: "SubConsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubIssue_Detail",
                columns: table => new
                {
                    SubIssueDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubIssueID = table.Column<long>(type: "bigint", nullable: true),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DestPhaBal = table.Column<int>(type: "int", nullable: false),
                    Request = table.Column<int>(type: "int", nullable: false),
                    Supply = table.Column<int>(type: "int", nullable: false),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StockAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubIssue_Detail", x => x.SubIssueDetailID);
                    table.ForeignKey(
                        name: "FK_SubIssue_Detail_SubIssue",
                        column: x => x.SubIssueID,
                        principalTable: "SubIssue",
                        principalColumn: "SubIssueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubOrderDetail",
                columns: table => new
                {
                    HosOrderID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HosOrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginStock = table.Column<double>(type: "float", nullable: true),
                    ExtReceive = table.Column<double>(type: "float", nullable: true),
                    CMSReceive = table.Column<double>(type: "float", nullable: true),
                    Receive = table.Column<double>(type: "float", nullable: true),
                    AdjIncome = table.Column<double>(type: "float", nullable: true),
                    Available = table.Column<double>(type: "float", nullable: true),
                    ExtIssue = table.Column<double>(type: "float", nullable: true),
                    Issue = table.Column<double>(type: "float", nullable: true),
                    AdjustTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Adjust = table.Column<double>(type: "float", nullable: true),
                    EndStock = table.Column<double>(type: "float", nullable: true),
                    Request = table.Column<double>(type: "float", nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StockOutDay = table.Column<int>(type: "int", nullable: true),
                    Adjustment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RealAMC = table.Column<double>(type: "float", nullable: true),
                    AMCStandard = table.Column<double>(type: "float", nullable: true),
                    IsLock = table.Column<bool>(type: "bit", nullable: true),
                    IsPrint = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOrderDetail", x => new { x.HosOrderID, x.CommodityID });
                    table.ForeignKey(
                        name: "FK_SubOrderDetail_SubOrder",
                        column: x => x.HosOrderID,
                        principalTable: "SubOrder",
                        principalColumn: "HosOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubPI_Detail",
                columns: table => new
                {
                    PIDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIID = table.Column<int>(type: "int", nullable: true),
                    LastStockDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    AdjQty = table.Column<int>(type: "int", nullable: false),
                    TransNote = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsLock = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPI_Detail", x => x.PIDetailID);
                    table.ForeignKey(
                        name: "FK_SubPI_Detail_SubPI",
                        column: x => x.PIID,
                        principalTable: "SubPI",
                        principalColumn: "PIID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubPrescription",
                columns: table => new
                {
                    ReqPresNº = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNº = table.Column<int>(type: "int", nullable: true),
                    PrescriptionNº = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPrescription", x => x.ReqPresNº);
                    table.ForeignKey(
                        name: "FK_SubPrescription_SubRequest",
                        column: x => x.RequestNº,
                        principalTable: "SubRequest",
                        principalColumn: "RequestNº",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTransferOutDetail",
                columns: table => new
                {
                    SubTransOutDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTransOutID = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BSDID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTransferOutDetail", x => x.SubTransOutDetailID);
                    table.ForeignKey(
                        name: "FK_SubTransferOutDetail_SubTransferOut",
                        column: x => x.SubTransOutID,
                        principalTable: "SubTransferOut",
                        principalColumn: "SubTransOutID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommodityType",
                columns: table => new
                {
                    CommTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CommTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CommTypeNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CategoryID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CommGrpID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    HaveQuota = table.Column<bool>(type: "bit", nullable: false),
                    Abbr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityType", x => x.CommTypeID);
                    table.ForeignKey(
                        name: "FK_CommodityType_CommodityCategory",
                        column: x => x.CategoryID,
                        principalTable: "CommodityCategory",
                        principalColumn: "CommCateID");
                    table.ForeignKey(
                        name: "FK_CommodityType_CommodityGroup",
                        column: x => x.CommGrpID,
                        principalTable: "CommodityGroup",
                        principalColumn: "CommGrpID");
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FacilityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FacilityName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FacilityNameKH = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FacilityTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    OrgID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CommDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistrictID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    FacPhone1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FacPhone2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FacPhone3 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FacFax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FacEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ConName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ConPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ConEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SupName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SupPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SupEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Markup = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DelRouteNo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PointNo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    IsSupplier = table.Column<bool>(type: "bit", nullable: false),
                    SupplierID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BranchID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    LevelID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    MaxMoS = table.Column<short>(type: "smallint", nullable: true),
                    ForPer = table.Column<short>(type: "smallint", nullable: true),
                    ProPer = table.Column<short>(type: "smallint", nullable: true),
                    FacMemo = table.Column<string>(type: "ntext", nullable: true),
                    IsMPA = table.Column<bool>(type: "bit", nullable: false),
                    MPAMulti = table.Column<float>(type: "real", nullable: true),
                    IsCPA = table.Column<bool>(type: "bit", nullable: false),
                    CPAMulti = table.Column<float>(type: "real", nullable: true),
                    IsCPAS = table.Column<bool>(type: "bit", nullable: false),
                    CPASMulti = table.Column<float>(type: "real", nullable: true),
                    InsertedBy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UniqueID = table.Column<byte[]>(type: "varbinary(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityID);
                    table.ForeignKey(
                        name: "FK_Facility_District",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID");
                    table.ForeignKey(
                        name: "FK_Facility_FacilityType",
                        column: x => x.FacilityTypeID,
                        principalTable: "FacilityType",
                        principalColumn: "FacilityTypeID");
                });

            migrationBuilder.CreateTable(
                name: "SubRequest_Detail",
                columns: table => new
                {
                    Nº = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReqPresNº = table.Column<int>(type: "int", nullable: false),
                    CommodityID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    StockAvailable = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRequest_Detail", x => x.Nº);
                    table.ForeignKey(
                        name: "FK_SubRequest_Detail_SubPrescription",
                        column: x => x.ReqPresNº,
                        principalTable: "SubPrescription",
                        principalColumn: "ReqPresNº",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CommodityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommTypeID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CommAbbrev = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Form = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CommCateID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    UsedInMPA = table.Column<bool>(type: "bit", nullable: false),
                    UsedInCPA1 = table.Column<bool>(type: "bit", nullable: false),
                    UsedInCPA2 = table.Column<bool>(type: "bit", nullable: false),
                    UsedInCPA3 = table.Column<bool>(type: "bit", nullable: false),
                    UsedInCPAS = table.Column<bool>(type: "bit", nullable: false),
                    MPAMultiplier = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CPA1Multiplier = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CPA2Multiplier = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CPA3Multiplier = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    CPASMultiplier = table.Column<decimal>(type: "decimal(10,3)", nullable: false),
                    ExpDate = table.Column<bool>(type: "bit", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InsertedBy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    AnnDisp_Order = table.Column<int>(type: "int", nullable: true),
                    Upsize_ts = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExpRequire = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsOIARV = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.CommodityID);
                    table.ForeignKey(
                        name: "FK_Commodity_CommodityType",
                        column: x => x.CommTypeID,
                        principalTable: "CommodityType",
                        principalColumn: "CommTypeID");
                });

            migrationBuilder.CreateTable(
                name: "CommodityTransaction_Detail",
                columns: table => new
                {
                    DTDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommTransID = table.Column<int>(type: "int", nullable: true),
                    CommID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    InitStock = table.Column<int>(type: "int", nullable: true),
                    Incoming = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true),
                    Outgoing = table.Column<int>(type: "int", nullable: true),
                    Adjustment = table.Column<double>(type: "float", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    TransNote = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BudgetSource = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityTransaction_Detail", x => x.DTDID);
                    table.ForeignKey(
                        name: "FK_CommodityTransaction_Detail_Commodity",
                        column: x => x.CommID,
                        principalTable: "Commodity",
                        principalColumn: "CommodityID");
                    table.ForeignKey(
                        name: "FK_CommodityTransaction_Detail_CommodityTransaction",
                        column: x => x.CommTransID,
                        principalTable: "CommodityTransaction",
                        principalColumn: "CommTransID");
                });

            migrationBuilder.CreateTable(
                name: "ManualSelectCommodity",
                columns: table => new
                {
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualSelectCommodity", x => x.CommodityID);
                    table.ForeignKey(
                        name: "FK_ManualSelectCommodity_Commodity",
                        column: x => x.CommodityID,
                        principalTable: "Commodity",
                        principalColumn: "CommodityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubReceive_Detail",
                columns: table => new
                {
                    MainConsDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainConsID = table.Column<long>(type: "bigint", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReceive_Detail", x => x.MainConsDetailID);
                    table.ForeignKey(
                        name: "FK_SubReceive_Detail_Commodity",
                        column: x => x.CommodityID,
                        principalTable: "Commodity",
                        principalColumn: "CommodityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubReceive_Detail_SubReceive",
                        column: x => x.MainConsID,
                        principalTable: "SubReceive",
                        principalColumn: "MainConsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblHosRequestDetail",
                columns: table => new
                {
                    RequestDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<int>(type: "int", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    InitialStock = table.Column<int>(type: "int", nullable: true),
                    Incoming = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Outgoing = table.Column<int>(type: "int", nullable: true),
                    Adjustment = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    Request = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AMCReal = table.Column<long>(type: "bigint", nullable: true),
                    AMCStandard = table.Column<long>(type: "bigint", nullable: true),
                    SOD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHosRequestDetail", x => x.RequestDetailID);
                    table.ForeignKey(
                        name: "FK_tblHosRequestDetail_Commodity",
                        column: x => x.CommodityID,
                        principalTable: "Commodity",
                        principalColumn: "CommodityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblHosRequestDetail_tblHosRequest",
                        column: x => x.RequestID,
                        principalTable: "tblHosRequest",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMainMonthlyTransactionDetail",
                columns: table => new
                {
                    ReportDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportID = table.Column<int>(type: "int", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    InitialStock = table.Column<int>(type: "int", nullable: true),
                    Incoming = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Outgoing = table.Column<int>(type: "int", nullable: true),
                    Adjustment = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMainMonthlyTransactionDetail", x => x.ReportDetailID);
                    table.ForeignKey(
                        name: "FK_tblMainMonthlyTransactionDetail_Commodity",
                        column: x => x.CommodityID,
                        principalTable: "Commodity",
                        principalColumn: "CommodityID");
                    table.ForeignKey(
                        name: "FK_tblMainMonthlyTransactionDetail_tblMainMonthlyTransaction",
                        column: x => x.ReportID,
                        principalTable: "tblMainMonthlyTransaction",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMainTransferInDetail",
                columns: table => new
                {
                    TransferInDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferInID = table.Column<int>(type: "int", nullable: true),
                    CommodityID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BSDID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    ExpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LotNo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMainTransferInDetail", x => x.TransferInDetailID);
                    table.ForeignKey(
                        name: "FK_tblMainTransferInDetail_Commodity",
                        column: x => x.CommodityID,
                        principalTable: "Commodity",
                        principalColumn: "CommodityID");
                    table.ForeignKey(
                        name: "FK_tblMainTransferInDetail_tblMainTransferIn",
                        column: x => x.TransferInID,
                        principalTable: "tblMainTransferIn",
                        principalColumn: "TransferInID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CommTypeID",
                table: "Commodity",
                column: "CommTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_CommGrpID",
                table: "CommodityCategory",
                column: "CommGrpID");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityTransaction_Detail_CommID",
                table: "CommodityTransaction_Detail",
                column: "CommID");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityTransaction_Detail_CommTransID",
                table: "CommodityTransaction_Detail",
                column: "CommTransID");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityType_CategoryID",
                table: "CommodityType",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityType_CommGrpID",
                table: "CommodityType",
                column: "CommGrpID");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceID",
                table: "District",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_DistrictID",
                table: "Facility",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_FacilityTypeID",
                table: "Facility",
                column: "FacilityTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_HosAdditional",
                table: "HosAdditional",
                column: "LastTransDate",
                unique: true,
                filter: "[LastTransDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HosAdditionalDetails",
                table: "HosAdditionalDetails",
                columns: new[] { "ADDID", "CommodityID" },
                unique: true,
                filter: "[ADDID] IS NOT NULL AND [CommodityID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HosOrder",
                table: "HosOrder",
                columns: new[] { "PrevOrdDate", "HosOrderDate", "ProvinceID", "HosID" },
                unique: true,
                filter: "[HosID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HosOrderApproval",
                table: "HosOrderApproval",
                columns: new[] { "HosOrderID", "ID", "ReportType" },
                unique: true,
                filter: "[HosOrderID] IS NOT NULL AND [ID] IS NOT NULL AND [ReportType] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MainConsumption",
                table: "MainConsumption",
                columns: new[] { "ConsumpDate", "SDID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainConsumption_Detail",
                table: "MainConsumption_Detail",
                columns: new[] { "MainConsID", "CommodityID", "BudgetSourceID", "ExpDate" },
                unique: true,
                filter: "[MainConsID] IS NOT NULL AND [ExpDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MainTransaction",
                table: "MainTransaction",
                columns: new[] { "TransDate", "InvoiceID", "CommodityID", "BudgetSourceID", "ExpDate", "TransTypeID", "SDID" },
                unique: true,
                filter: "[TransDate] IS NOT NULL AND [InvoiceID] IS NOT NULL AND [ExpDate] IS NOT NULL AND [TransTypeID] IS NOT NULL AND [SDID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MainTransfer",
                table: "MainTransfer",
                columns: new[] { "TransferDate", "SDID" },
                unique: true,
                filter: "[SDID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MainTransfer_Detail",
                table: "MainTransfer_Detail",
                columns: new[] { "TransferID", "CommodityID", "BudgetSourceID", "ExpDate" },
                unique: true,
                filter: "[ExpDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PI",
                table: "PI",
                columns: new[] { "UpdatedDate", "PIType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PI_Detail",
                table: "PI_Detail",
                columns: new[] { "PIID", "CommodityID", "BudgetSourceID", "ExpDate" },
                unique: true,
                filter: "[PIID] IS NOT NULL AND [ExpDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveInvoice",
                table: "ReceiveInvoice",
                columns: new[] { "InvoiceID", "BudgetSourceID", "ArriveDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveInvoice_Detail",
                table: "ReceiveInvoice_Detail",
                columns: new[] { "ReceiveInvoice_ID", "CommodityID", "BudgetSourceID", "ExpDate" },
                unique: true,
                filter: "[ReceiveInvoice_ID] IS NOT NULL AND [CommodityID] IS NOT NULL AND [BudgetSourceID] IS NOT NULL AND [ExpDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveInvoiceReport",
                table: "ReceiveInvoiceReport",
                columns: new[] { "InvoiceID", "ReceiveInvoice_ID" },
                unique: true,
                filter: "[ReceiveInvoice_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveInvoiceReport_Detail",
                table: "ReceiveInvoiceReport_Detail",
                columns: new[] { "ReceiveInvoice_ID", "CommodityID", "ExpDate" },
                unique: true,
                filter: "[ReceiveInvoice_ID] IS NOT NULL AND [CommodityID] IS NOT NULL AND [ExpDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RIRCommittee_InvoiceID",
                table: "RIRCommittee",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_SubConsumption",
                table: "SubConsumption",
                columns: new[] { "SubPhaID", "ConsumpDate", "SDID", "WardID" },
                unique: true,
                filter: "[WardID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubConsumption_Detail",
                table: "SubConsumption_Detail",
                columns: new[] { "SubConsID", "CommodityID" },
                unique: true,
                filter: "[SubConsID] IS NOT NULL AND [CommodityID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubIssue",
                table: "SubIssue",
                columns: new[] { "IssueDate", "SourSubPhaID", "DestSubPhaID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubIssue_Detail",
                table: "SubIssue_Detail",
                columns: new[] { "SubIssueID", "CommodityID" },
                unique: true,
                filter: "[SubIssueID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubPI",
                table: "SubPI",
                columns: new[] { "SubPhaID", "UpdatedDate", "PIType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubPI_Detail",
                table: "SubPI_Detail",
                columns: new[] { "PIID", "CommodityID" },
                unique: true,
                filter: "[PIID] IS NOT NULL AND [CommodityID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubPrescription",
                table: "SubPrescription",
                columns: new[] { "RequestNº", "PrescriptionNº" },
                unique: true,
                filter: "[RequestNº] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubReceive",
                table: "SubReceive",
                columns: new[] { "SubPhaID", "SDID", "ConsumpDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubReceive_Detail",
                table: "SubReceive_Detail",
                columns: new[] { "MainConsID", "CommodityID" },
                unique: true,
                filter: "[MainConsID] IS NOT NULL AND [CommodityID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubReceive_Detail_CommodityID",
                table: "SubReceive_Detail",
                column: "CommodityID");

            migrationBuilder.CreateIndex(
                name: "IX_SubRequest",
                table: "SubRequest",
                columns: new[] { "SubPhaID", "IssueDate", "SDID", "WardID" },
                unique: true,
                filter: "[SubPhaID] IS NOT NULL AND [SDID] IS NOT NULL AND [WardID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubRequest_Detail",
                table: "SubRequest_Detail",
                columns: new[] { "ReqPresNº", "CommodityID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTransaction",
                table: "SubTransaction",
                columns: new[] { "SubPhaID", "TransDate", "TransTypeID", "CommodityID", "SDID", "WardID", "InvoiceID" },
                unique: true,
                filter: "[TransDate] IS NOT NULL AND [SDID] IS NOT NULL AND [WardID] IS NOT NULL AND [InvoiceID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubTransferOutDetail_SubTransOutID",
                table: "SubTransferOutDetail",
                column: "SubTransOutID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl2014_HosReport_Transaction",
                table: "tbl2014_HosReport_Transaction",
                columns: new[] { "StartDate", "EndDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl2014_MainReport_Transaction",
                table: "tbl2014_MainReport_Transaction",
                columns: new[] { "StartDate", "EndDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl2014_MainReport_Transaction_Source",
                table: "tbl2014_MainReport_Transaction_Source",
                columns: new[] { "StartDate", "EndDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl2014_SubReport_Transaction",
                table: "tbl2014_SubReport_Transaction",
                columns: new[] { "StartDate", "EndDate", "SubPhaID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl2014_UserPharmacy",
                table: "tbl2014_UserPharmacy",
                columns: new[] { "User_ID", "Pharmacy_Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblHosRequestDetail_CommodityID",
                table: "tblHosRequestDetail",
                column: "CommodityID");

            migrationBuilder.CreateIndex(
                name: "IX_tblHosRequestDetail_RequestID",
                table: "tblHosRequestDetail",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMainMonthlyTransactionDetail_CommodityID",
                table: "tblMainMonthlyTransactionDetail",
                column: "CommodityID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMainMonthlyTransactionDetail_ReportID",
                table: "tblMainMonthlyTransactionDetail",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMainTransferIn",
                table: "tblMainTransferIn",
                columns: new[] { "SDID", "IssueDate", "TransferDate" },
                unique: true,
                filter: "[IssueDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblMainTransferInDetail",
                table: "tblMainTransferInDetail",
                columns: new[] { "TransferInID", "CommodityID", "BSDID", "ExpDate" },
                unique: true,
                filter: "[TransferInID] IS NOT NULL AND [CommodityID] IS NOT NULL AND [ExpDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblMainTransferInDetail_CommodityID",
                table: "tblMainTransferInDetail",
                column: "CommodityID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPharmacyWard",
                table: "tblPharmacyWard",
                columns: new[] { "SubPhaID", "WardID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_YearlyEstimate",
                table: "YearlyEstimate",
                column: "For_Year",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_YearlyEstimate_Detail",
                table: "YearlyEstimate_Detail",
                columns: new[] { "ID", "CommodityID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AMC");

            migrationBuilder.DropTable(
                name: "AutoBackup");

            migrationBuilder.DropTable(
                name: "BudgetSource");

            migrationBuilder.DropTable(
                name: "CampaignList");

            migrationBuilder.DropTable(
                name: "Committee");

            migrationBuilder.DropTable(
                name: "Commodity Standard");

            migrationBuilder.DropTable(
                name: "CommodityTransaction_Detail");

            migrationBuilder.DropTable(
                name: "Consumption_Note");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "HosAdditional");

            migrationBuilder.DropTable(
                name: "HosAdditionalDetails");

            migrationBuilder.DropTable(
                name: "HosDirector");

            migrationBuilder.DropTable(
                name: "HosOrder");

            migrationBuilder.DropTable(
                name: "HosOrderApproval");

            migrationBuilder.DropTable(
                name: "HosOrderDetail");

            migrationBuilder.DropTable(
                name: "InventoryType");

            migrationBuilder.DropTable(
                name: "MainConsumption_Detail");

            migrationBuilder.DropTable(
                name: "MainTransaction");

            migrationBuilder.DropTable(
                name: "MainTransfer_Detail");

            migrationBuilder.DropTable(
                name: "ManualSelectCommodity");

            migrationBuilder.DropTable(
                name: "NoteLookUp");

            migrationBuilder.DropTable(
                name: "OIARVParam");

            migrationBuilder.DropTable(
                name: "PI_Detail");

            migrationBuilder.DropTable(
                name: "ProcessLog");

            migrationBuilder.DropTable(
                name: "ReceiveInvoice");

            migrationBuilder.DropTable(
                name: "ReceiveInvoice_Detail");

            migrationBuilder.DropTable(
                name: "ReceiveInvoiceReport_Detail");

            migrationBuilder.DropTable(
                name: "ReceiveInvoiceReportAdjNote");

            migrationBuilder.DropTable(
                name: "ReceiveInvoiceReportNote");

            migrationBuilder.DropTable(
                name: "RIRCommittee");

            migrationBuilder.DropTable(
                name: "SelectedCommodity");

            migrationBuilder.DropTable(
                name: "SelectedCommodityLot");

            migrationBuilder.DropTable(
                name: "SourceDestination");

            migrationBuilder.DropTable(
                name: "SubAdditionalDetails");

            migrationBuilder.DropTable(
                name: "SubConsumption_Detail");

            migrationBuilder.DropTable(
                name: "SubIssue_Detail");

            migrationBuilder.DropTable(
                name: "SubOrderDetail");

            migrationBuilder.DropTable(
                name: "SubPI_Detail");

            migrationBuilder.DropTable(
                name: "SubReceive_Detail");

            migrationBuilder.DropTable(
                name: "SubRequest_Detail");

            migrationBuilder.DropTable(
                name: "SubTransaction");

            migrationBuilder.DropTable(
                name: "SubTransferOutDetail");

            migrationBuilder.DropTable(
                name: "SysParam");

            migrationBuilder.DropTable(
                name: "tbl2014_HosReport_Transaction");

            migrationBuilder.DropTable(
                name: "tbl2014_HosReport_TransactionDetail");

            migrationBuilder.DropTable(
                name: "tbl2014_MainReport_Transaction");

            migrationBuilder.DropTable(
                name: "tbl2014_MainReport_Transaction_Source");

            migrationBuilder.DropTable(
                name: "tbl2014_MainReport_Transaction_SourceDetail");

            migrationBuilder.DropTable(
                name: "tbl2014_MainReport_TransactionDetail");

            migrationBuilder.DropTable(
                name: "tbl2014_SubReport_Transaction");

            migrationBuilder.DropTable(
                name: "tbl2014_SubReport_TransactionDetail");

            migrationBuilder.DropTable(
                name: "tbl2014_User");

            migrationBuilder.DropTable(
                name: "tbl2014_UserPermission");

            migrationBuilder.DropTable(
                name: "tbl2014_UserPharmacy");

            migrationBuilder.DropTable(
                name: "tblCNM_HosReport_Transaction");

            migrationBuilder.DropTable(
                name: "tblCNM_HosReport_TransactionDetail");

            migrationBuilder.DropTable(
                name: "TblConsumption");

            migrationBuilder.DropTable(
                name: "TblConsumption_Detail");

            migrationBuilder.DropTable(
                name: "TblErrorDetails");

            migrationBuilder.DropTable(
                name: "tblHosRequestDetail");

            migrationBuilder.DropTable(
                name: "tblMainMonthlyTransactionDetail");

            migrationBuilder.DropTable(
                name: "tblMainTransferInDetail");

            migrationBuilder.DropTable(
                name: "tblNote");

            migrationBuilder.DropTable(
                name: "TblParameter");

            migrationBuilder.DropTable(
                name: "tblPharmacyWard");

            migrationBuilder.DropTable(
                name: "tblReportNote");

            migrationBuilder.DropTable(
                name: "tblSubPharmacy");

            migrationBuilder.DropTable(
                name: "tblTemp_Invoice_Inventory");

            migrationBuilder.DropTable(
                name: "tblTemp_Invoice_InvGroup");

            migrationBuilder.DropTable(
                name: "tblTemp_Invoice_Invoice");

            migrationBuilder.DropTable(
                name: "tblTemp_Invoice_InvoiceDetail");

            migrationBuilder.DropTable(
                name: "tblTemp_Invoice_InvType");

            migrationBuilder.DropTable(
                name: "tblUsers");

            migrationBuilder.DropTable(
                name: "tempHospitalStockOnhand");

            migrationBuilder.DropTable(
                name: "tempHospitalStockOnhand",
                schema: "kea");

            migrationBuilder.DropTable(
                name: "tempHospitalStockOnhand",
                schema: "kostar");

            migrationBuilder.DropTable(
                name: "tempHospitalStockOnhand",
                schema: "SreypovMain");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption_By_DayADMIN-1C24D7503");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption_By_DayHOSDID-MAIN");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption_By_DayHOSDID02");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption_By_DayHOSDID03");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption_By_DayNH-KOSAMAK");

            migrationBuilder.DropTable(
                name: "tempMonthlyConsumption_By_DayPHARMACY-PC");

            migrationBuilder.DropTable(
                name: "tmpCommodity");

            migrationBuilder.DropTable(
                name: "tmpCommodityCategory");

            migrationBuilder.DropTable(
                name: "tmpCommodityGroup");

            migrationBuilder.DropTable(
                name: "tmpCommodityType");

            migrationBuilder.DropTable(
                name: "tmpMainStockCard15Days1");

            migrationBuilder.DropTable(
                name: "tmpMainStockCard15Days2");

            migrationBuilder.DropTable(
                name: "tmpMainStockCard15Days3");

            migrationBuilder.DropTable(
                name: "tmpMainStockCardEveryDay");

            migrationBuilder.DropTable(
                name: "tmpReceiveInvoice");

            migrationBuilder.DropTable(
                name: "tmpStockBalancing");

            migrationBuilder.DropTable(
                name: "tmpStockBalancingDetail");

            migrationBuilder.DropTable(
                name: "tmpStockCard");

            migrationBuilder.DropTable(
                name: "tmpStockCardAll");

            migrationBuilder.DropTable(
                name: "tmpStockOnhand");

            migrationBuilder.DropTable(
                name: "tmpStockStatus");

            migrationBuilder.DropTable(
                name: "tmpStockStatusSummary");

            migrationBuilder.DropTable(
                name: "tmpSubConsumption");

            migrationBuilder.DropTable(
                name: "tmpSubConsumption_Detail");

            migrationBuilder.DropTable(
                name: "tmpSubPI");

            migrationBuilder.DropTable(
                name: "tmpSubPI_Detail");

            migrationBuilder.DropTable(
                name: "tmpSubPrescription");

            migrationBuilder.DropTable(
                name: "tmpSubReceive");

            migrationBuilder.DropTable(
                name: "tmpSubReceive_Detail");

            migrationBuilder.DropTable(
                name: "tmpSubRequest");

            migrationBuilder.DropTable(
                name: "tmpSubRequest_Detail");

            migrationBuilder.DropTable(
                name: "tmpSubStockCard15Days1");

            migrationBuilder.DropTable(
                name: "tmpSubStockCard15Days2");

            migrationBuilder.DropTable(
                name: "tmpSubStockCard15Days3");

            migrationBuilder.DropTable(
                name: "tmpSubStockCardDaily");

            migrationBuilder.DropTable(
                name: "tmpSubTransaction");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "YearlyEstimate");

            migrationBuilder.DropTable(
                name: "YearlyEstimate_Detail");

            migrationBuilder.DropTable(
                name: "CommodityTransaction");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "FacilityType");

            migrationBuilder.DropTable(
                name: "MainConsumption");

            migrationBuilder.DropTable(
                name: "MainTransfer");

            migrationBuilder.DropTable(
                name: "PI");

            migrationBuilder.DropTable(
                name: "ReceiveInvoiceReport");

            migrationBuilder.DropTable(
                name: "SubAdditional");

            migrationBuilder.DropTable(
                name: "SubConsumption");

            migrationBuilder.DropTable(
                name: "SubIssue");

            migrationBuilder.DropTable(
                name: "SubOrder");

            migrationBuilder.DropTable(
                name: "SubPI");

            migrationBuilder.DropTable(
                name: "SubReceive");

            migrationBuilder.DropTable(
                name: "SubPrescription");

            migrationBuilder.DropTable(
                name: "SubTransferOut");

            migrationBuilder.DropTable(
                name: "tblHosRequest");

            migrationBuilder.DropTable(
                name: "tblMainMonthlyTransaction");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "tblMainTransferIn");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "SubRequest");

            migrationBuilder.DropTable(
                name: "CommodityType");

            migrationBuilder.DropTable(
                name: "CommodityCategory");

            migrationBuilder.DropTable(
                name: "CommodityGroup");
        }
    }
}
