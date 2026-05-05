using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Amc> Amcs { get; set; }

    public virtual DbSet<AutoBackup> AutoBackups { get; set; }

    public virtual DbSet<BudgetSource> BudgetSources { get; set; }

    public virtual DbSet<CampaignList> CampaignLists { get; set; }

    public virtual DbSet<Committee> Committees { get; set; }

    public virtual DbSet<Commodity> Commodities { get; set; }

    public virtual DbSet<CommodityCategory> CommodityCategories { get; set; }

    public virtual DbSet<CommodityGroup> CommodityGroups { get; set; }

    public virtual DbSet<CommodityStandard> CommodityStandards { get; set; }

    public virtual DbSet<CommodityTransaction> CommodityTransactions { get; set; }

    public virtual DbSet<CommodityTransactionDetail> CommodityTransactionDetails { get; set; }

    public virtual DbSet<CommodityType> CommodityTypes { get; set; }

    public virtual DbSet<ConsumptionNote> ConsumptionNotes { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Facility> Facilities { get; set; }

    public virtual DbSet<FacilityType> FacilityTypes { get; set; }

    public virtual DbSet<HosAdditional> HosAdditionals { get; set; }

    public virtual DbSet<HosAdditionalDetail> HosAdditionalDetails { get; set; }

    public virtual DbSet<HosDirector> HosDirectors { get; set; }

    public virtual DbSet<HosOrder> HosOrders { get; set; }

    public virtual DbSet<HosOrderApproval> HosOrderApprovals { get; set; }

    public virtual DbSet<HosOrderDetail> HosOrderDetails { get; set; }

    public virtual DbSet<InventoryType> InventoryTypes { get; set; }

    public virtual DbSet<LoadPi> LoadPis { get; set; }

    public virtual DbSet<MainConsumption> MainConsumptions { get; set; }

    public virtual DbSet<MainConsumptionDetail> MainConsumptionDetails { get; set; }

    public virtual DbSet<MainTransaction> MainTransactions { get; set; }

    public virtual DbSet<MainTransfer> MainTransfers { get; set; }

    public virtual DbSet<MainTransferDetail> MainTransferDetails { get; set; }

    public virtual DbSet<ManualSelectCommodity> ManualSelectCommodities { get; set; }

    public virtual DbSet<NoteLookUp> NoteLookUps { get; set; }

    public virtual DbSet<Oiarvparam> Oiarvparams { get; set; }

    public virtual DbSet<Pi> Pis { get; set; }

    public virtual DbSet<PiDetail> PiDetails { get; set; }

    public virtual DbSet<ProcessLog> ProcessLogs { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<ReceiveInvoice> ReceiveInvoices { get; set; }

    public virtual DbSet<ReceiveInvoiceDetail> ReceiveInvoiceDetails { get; set; }

    public virtual DbSet<ReceiveInvoiceReport> ReceiveInvoiceReports { get; set; }

    public virtual DbSet<ReceiveInvoiceReportAdjNote> ReceiveInvoiceReportAdjNotes { get; set; }

    public virtual DbSet<ReceiveInvoiceReportDetail> ReceiveInvoiceReportDetails { get; set; }

    public virtual DbSet<ReceiveInvoiceReportNote> ReceiveInvoiceReportNotes { get; set; }

    public virtual DbSet<Rircommittee> Rircommittees { get; set; }

    public virtual DbSet<SelectedCommodity> SelectedCommodities { get; set; }

    public virtual DbSet<SelectedCommodityLot> SelectedCommodityLots { get; set; }

    public virtual DbSet<SourceDestination> SourceDestinations { get; set; }

    public virtual DbSet<SubAdditional> SubAdditionals { get; set; }

    public virtual DbSet<SubAdditionalDetail> SubAdditionalDetails { get; set; }

    public virtual DbSet<SubConsumption> SubConsumptions { get; set; }

    public virtual DbSet<SubConsumptionDetail> SubConsumptionDetails { get; set; }

    public virtual DbSet<SubIssue> SubIssues { get; set; }

    public virtual DbSet<SubIssueDetail> SubIssueDetails { get; set; }

    public virtual DbSet<SubOrder> SubOrders { get; set; }

    public virtual DbSet<SubOrderDetail> SubOrderDetails { get; set; }

    public virtual DbSet<SubPi> SubPis { get; set; }

    public virtual DbSet<SubPiDetail> SubPiDetails { get; set; }

    public virtual DbSet<SubPrescription> SubPrescriptions { get; set; }

    public virtual DbSet<SubReceive> SubReceives { get; set; }

    public virtual DbSet<SubReceiveDetail> SubReceiveDetails { get; set; }

    public virtual DbSet<SubRequest> SubRequests { get; set; }

    public virtual DbSet<SubRequestDetail> SubRequestDetails { get; set; }

    public virtual DbSet<SubTransaction> SubTransactions { get; set; }

    public virtual DbSet<SubTransferOut> SubTransferOuts { get; set; }

    public virtual DbSet<SubTransferOutDetail> SubTransferOutDetails { get; set; }

    public virtual DbSet<SysParam> SysParams { get; set; }

    public virtual DbSet<Tbl2014HosReportTransaction> Tbl2014HosReportTransactions { get; set; }

    public virtual DbSet<Tbl2014HosReportTransactionDetail> Tbl2014HosReportTransactionDetails { get; set; }

    public virtual DbSet<Tbl2014MainReportTransaction> Tbl2014MainReportTransactions { get; set; }

    public virtual DbSet<Tbl2014MainReportTransactionDetail> Tbl2014MainReportTransactionDetails { get; set; }

    public virtual DbSet<Tbl2014MainReportTransactionSource> Tbl2014MainReportTransactionSources { get; set; }

    public virtual DbSet<Tbl2014MainReportTransactionSourceDetail> Tbl2014MainReportTransactionSourceDetails { get; set; }

    public virtual DbSet<Tbl2014SubReportTransaction> Tbl2014SubReportTransactions { get; set; }

    public virtual DbSet<Tbl2014SubReportTransactionDetail> Tbl2014SubReportTransactionDetails { get; set; }

    public virtual DbSet<Tbl2014User> Tbl2014Users { get; set; }

    public virtual DbSet<Tbl2014UserPermission> Tbl2014UserPermissions { get; set; }

    public virtual DbSet<Tbl2014UserPharmacy> Tbl2014UserPharmacies { get; set; }

    public virtual DbSet<TblCnmHosReportTransaction> TblCnmHosReportTransactions { get; set; }

    public virtual DbSet<TblCnmHosReportTransactionDetail> TblCnmHosReportTransactionDetails { get; set; }

    public virtual DbSet<TblConsumption> TblConsumptions { get; set; }

    public virtual DbSet<TblConsumptionDetail> TblConsumptionDetails { get; set; }

    public virtual DbSet<TblErrorDetail> TblErrorDetails { get; set; }

    public virtual DbSet<TblHosRequest> TblHosRequests { get; set; }

    public virtual DbSet<TblHosRequestDetail> TblHosRequestDetails { get; set; }

    public virtual DbSet<TblMainMonthlyTransaction> TblMainMonthlyTransactions { get; set; }

    public virtual DbSet<TblMainMonthlyTransactionDetail> TblMainMonthlyTransactionDetails { get; set; }

    public virtual DbSet<TblMainTransferIn> TblMainTransferIns { get; set; }

    public virtual DbSet<TblMainTransferInDetail> TblMainTransferInDetails { get; set; }

    public virtual DbSet<TblNote> TblNotes { get; set; }

    public virtual DbSet<TblParameter> TblParameters { get; set; }

    public virtual DbSet<TblPharmacyWard> TblPharmacyWards { get; set; }

    public virtual DbSet<TblReportNote> TblReportNotes { get; set; }

    public virtual DbSet<TblSubPharmacy> TblSubPharmacies { get; set; }

    public virtual DbSet<TblTempInvoiceInvGroup> TblTempInvoiceInvGroups { get; set; }

    public virtual DbSet<TblTempInvoiceInvType> TblTempInvoiceInvTypes { get; set; }

    public virtual DbSet<TblTempInvoiceInventory> TblTempInvoiceInventories { get; set; }

    public virtual DbSet<TblTempInvoiceInvoice> TblTempInvoiceInvoices { get; set; }

    public virtual DbSet<TblTempInvoiceInvoiceDetail> TblTempInvoiceInvoiceDetails { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TempHospitalStockOnhand> TempHospitalStockOnhands { get; set; }

    public virtual DbSet<TempHospitalStockOnhand1> TempHospitalStockOnhands1 { get; set; }

    public virtual DbSet<TempHospitalStockOnhand2> TempHospitalStockOnhands2 { get; set; }

    public virtual DbSet<TempHospitalStockOnhand3> TempHospitalStockOnhands3 { get; set; }

    public virtual DbSet<TempMonthlyConsumption> TempMonthlyConsumptions { get; set; }

    public virtual DbSet<TempMonthlyConsumptionByDayAdmin1c24d7503> TempMonthlyConsumptionByDayAdmin1c24d7503s { get; set; }

    public virtual DbSet<TempMonthlyConsumptionByDayHosdid02> TempMonthlyConsumptionByDayHosdid02s { get; set; }

    public virtual DbSet<TempMonthlyConsumptionByDayHosdid03> TempMonthlyConsumptionByDayHosdid03s { get; set; }

    public virtual DbSet<TempMonthlyConsumptionByDayHosdidMain> TempMonthlyConsumptionByDayHosdidMains { get; set; }

    public virtual DbSet<TempMonthlyConsumptionByDayNhKosamak> TempMonthlyConsumptionByDayNhKosamaks { get; set; }

    public virtual DbSet<TempMonthlyConsumptionByDayPharmacyPc> TempMonthlyConsumptionByDayPharmacyPcs { get; set; }

    public virtual DbSet<TmpCommodity> TmpCommodities { get; set; }

    public virtual DbSet<TmpCommodityCategory> TmpCommodityCategories { get; set; }

    public virtual DbSet<TmpCommodityGroup> TmpCommodityGroups { get; set; }

    public virtual DbSet<TmpCommodityType> TmpCommodityTypes { get; set; }

    public virtual DbSet<TmpMainStockCard15Days1> TmpMainStockCard15Days1s { get; set; }

    public virtual DbSet<TmpMainStockCard15Days2> TmpMainStockCard15Days2s { get; set; }

    public virtual DbSet<TmpMainStockCard15Days3> TmpMainStockCard15Days3s { get; set; }

    public virtual DbSet<TmpMainStockCardEveryDay> TmpMainStockCardEveryDays { get; set; }

    public virtual DbSet<TmpReceiveInvoice> TmpReceiveInvoices { get; set; }

    public virtual DbSet<TmpStockBalancing> TmpStockBalancings { get; set; }

    public virtual DbSet<TmpStockBalancingDetail> TmpStockBalancingDetails { get; set; }

    public virtual DbSet<TmpStockCard> TmpStockCards { get; set; }

    public virtual DbSet<TmpStockCardAll> TmpStockCardAlls { get; set; }

    public virtual DbSet<TmpStockOnhand> TmpStockOnhands { get; set; }

    public virtual DbSet<TmpStockStatus> TmpStockStatuses { get; set; }

    public virtual DbSet<TmpStockStatusSummary> TmpStockStatusSummaries { get; set; }

    public virtual DbSet<TmpSubConsumption> TmpSubConsumptions { get; set; }

    public virtual DbSet<TmpSubConsumptionDetail> TmpSubConsumptionDetails { get; set; }

    public virtual DbSet<TmpSubPi> TmpSubPis { get; set; }

    public virtual DbSet<TmpSubPiDetail> TmpSubPiDetails { get; set; }

    public virtual DbSet<TmpSubPrescription> TmpSubPrescriptions { get; set; }

    public virtual DbSet<TmpSubReceive> TmpSubReceives { get; set; }

    public virtual DbSet<TmpSubReceiveDetail> TmpSubReceiveDetails { get; set; }

    public virtual DbSet<TmpSubRequest> TmpSubRequests { get; set; }

    public virtual DbSet<TmpSubRequestDetail> TmpSubRequestDetails { get; set; }

    public virtual DbSet<TmpSubStockCard15Days1> TmpSubStockCard15Days1s { get; set; }

    public virtual DbSet<TmpSubStockCard15Days2> TmpSubStockCard15Days2s { get; set; }

    public virtual DbSet<TmpSubStockCard15Days3> TmpSubStockCard15Days3s { get; set; }

    public virtual DbSet<TmpSubStockCardDaily> TmpSubStockCardDailies { get; set; }

    public virtual DbSet<TmpSubTransaction> TmpSubTransactions { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<VAdditionalRequesDeatail> VAdditionalRequesDeatails { get; set; }

    public virtual DbSet<VBudgetSource> VBudgetSources { get; set; }

    public virtual DbSet<VCommodity> VCommodities { get; set; }

    public virtual DbSet<VCommodityByService> VCommodityByServices { get; set; }

    public virtual DbSet<VCommodityByServiceSub> VCommodityByServiceSubs { get; set; }

    public virtual DbSet<VCommodityTransaction> VCommodityTransactions { get; set; }

    public virtual DbSet<VExpireStatus> VExpireStatuses { get; set; }

    public virtual DbSet<VHosNote> VHosNotes { get; set; }

    public virtual DbSet<VHosOrder> VHosOrders { get; set; }

    public virtual DbSet<VHosOrderDetail> VHosOrderDetails { get; set; }

    public virtual DbSet<VHospitalStockOnHand> VHospitalStockOnHands { get; set; }

    public virtual DbSet<VHospitalStockOnHandEnd> VHospitalStockOnHandEnds { get; set; }

    public virtual DbSet<VInvoice> VInvoices { get; set; }

    public virtual DbSet<VInvoiceReport> VInvoiceReports { get; set; }

    public virtual DbSet<VLotNoBsource> VLotNoBsources { get; set; }

    public virtual DbSet<VMainDispense> VMainDispenses { get; set; }

    public virtual DbSet<VMainMonthlyTransaction> VMainMonthlyTransactions { get; set; }

    public virtual DbSet<VMainSourceDestination> VMainSourceDestinations { get; set; }

    public virtual DbSet<VMainStockCardDaily> VMainStockCardDailies { get; set; }

    public virtual DbSet<VMainStockCardDailyByLotEnd> VMainStockCardDailyByLotEnds { get; set; }

    public virtual DbSet<VMainStockCardDailyByLotIn> VMainStockCardDailyByLotIns { get; set; }

    public virtual DbSet<VMainStockCardDailyByLotIn2> VMainStockCardDailyByLotIn2s { get; set; }

    public virtual DbSet<VMainStockCardDailyByLotOut> VMainStockCardDailyByLotOuts { get; set; }

    public virtual DbSet<VMainStockCardDailyByLotOut2> VMainStockCardDailyByLotOut2s { get; set; }

    public virtual DbSet<VMainStockCardDailyCommodity> VMainStockCardDailyCommodities { get; set; }

    public virtual DbSet<VMainStockCardDailyCommodityByLot> VMainStockCardDailyCommodityByLots { get; set; }

    public virtual DbSet<VMainStockCardDailyEnd> VMainStockCardDailyEnds { get; set; }

    public virtual DbSet<VMainStockCardDailyIn> VMainStockCardDailyIns { get; set; }

    public virtual DbSet<VMainStockCardDailyIn2> VMainStockCardDailyIn2s { get; set; }

    public virtual DbSet<VMainStockCardDailyOut> VMainStockCardDailyOuts { get; set; }

    public virtual DbSet<VMainStockCardDailyOut2> VMainStockCardDailyOut2s { get; set; }

    public virtual DbSet<VMainStockCardDailyStockonHand> VMainStockCardDailyStockonHands { get; set; }

    public virtual DbSet<VMainStockCardDailyStockonHandByGroup> VMainStockCardDailyStockonHandByGroups { get; set; }

    public virtual DbSet<VMainStockCardDailyStockonHandByGroupByLot> VMainStockCardDailyStockonHandByGroupByLots { get; set; }

    public virtual DbSet<VMainStockCardDailyStockonHandByLot> VMainStockCardDailyStockonHandByLots { get; set; }

    public virtual DbSet<VMainStockCardDailyStockonHandDetail> VMainStockCardDailyStockonHandDetails { get; set; }

    public virtual DbSet<VMainStockCardDailyStockonHandDetailByLot> VMainStockCardDailyStockonHandDetailByLots { get; set; }

    public virtual DbSet<VMainStockNotYetUpdate> VMainStockNotYetUpdates { get; set; }

    public virtual DbSet<VMainStockNotYetUpdateAvailable> VMainStockNotYetUpdateAvailables { get; set; }

    public virtual DbSet<VMonthlyAdjustment> VMonthlyAdjustments { get; set; }

    public virtual DbSet<VMonthlyStockOnHand> VMonthlyStockOnHands { get; set; }

    public virtual DbSet<VPiall> VPialls { get; set; }

    public virtual DbSet<VPibyGroup> VPibyGroups { get; set; }

    public virtual DbSet<VPichangeExpiryDate> VPichangeExpiryDates { get; set; }

    public virtual DbSet<VPichangeExpiryDateSelectedLot> VPichangeExpiryDateSelectedLots { get; set; }

    public virtual DbSet<VQuarterlyRequest> VQuarterlyRequests { get; set; }

    public virtual DbSet<VQuaterlyRequestReport> VQuaterlyRequestReports { get; set; }

    public virtual DbSet<VReceiveInvoiceReportAdj> VReceiveInvoiceReportAdjs { get; set; }

    public virtual DbSet<VReceiveInvoiceReportBrok> VReceiveInvoiceReportBroks { get; set; }

    public virtual DbSet<VReceiveInvoiceReportDef> VReceiveInvoiceReportDefs { get; set; }

    public virtual DbSet<VReceiveInvoiceReportInsu> VReceiveInvoiceReportInsus { get; set; }

    public virtual DbSet<VSdtransfer> VSdtransfers { get; set; }

    public virtual DbSet<VSdtransferIn> VSdtransferIns { get; set; }

    public virtual DbSet<VSohofSubPhamacy> VSohofSubPhamacies { get; set; }

    public virtual DbSet<VSource> VSources { get; set; }

    public virtual DbSet<VSourceCm> VSourceCms { get; set; }

    public virtual DbSet<VSourceNonCm> VSourceNonCms { get; set; }

    public virtual DbSet<VStockCard15Day> VStockCard15Days { get; set; }

    public virtual DbSet<VStockCardByLot15Day> VStockCardByLot15Days { get; set; }

    public virtual DbSet<VStockCardByLot15Days1> VStockCardByLot15Days1s { get; set; }

    public virtual DbSet<VStockCardByLot15Days3> VStockCardByLot15Days3s { get; set; }

    public virtual DbSet<VStockCardByLotEveryday> VStockCardByLotEverydays { get; set; }

    public virtual DbSet<VStockCardDetail> VStockCardDetails { get; set; }

    public virtual DbSet<VStockCardEveryDay> VStockCardEveryDays { get; set; }

    public virtual DbSet<VStockCardEveryDayEnd> VStockCardEveryDayEnds { get; set; }

    public virtual DbSet<VStockOnHand> VStockOnHands { get; set; }

    public virtual DbSet<VStockOutCommodity> VStockOutCommodities { get; set; }

    public virtual DbSet<VStockStatus> VStockStatuses { get; set; }

    public virtual DbSet<VStockonHandByLotById> VStockonHandByLotByIds { get; set; }

    public virtual DbSet<VStockonHandDetail> VStockonHandDetails { get; set; }

    public virtual DbSet<VSubDispense> VSubDispenses { get; set; }

    public virtual DbSet<VSubIssueNotYetUpdate> VSubIssueNotYetUpdates { get; set; }

    public virtual DbSet<VSubPharmacy> VSubPharmacies { get; set; }

    public virtual DbSet<VSubPi> VSubPis { get; set; }

    public virtual DbSet<VSubPibyGroup> VSubPibyGroups { get; set; }

    public virtual DbSet<VSubReceive> VSubReceives { get; set; }

    public virtual DbSet<VSubRequest> VSubRequests { get; set; }

    public virtual DbSet<VSubRequestNotYetUpdate> VSubRequestNotYetUpdates { get; set; }

    public virtual DbSet<VSubRequestReport> VSubRequestReports { get; set; }

    public virtual DbSet<VSubRequestReportSum> VSubRequestReportSums { get; set; }

    public virtual DbSet<VSubRequestSearch> VSubRequestSearches { get; set; }

    public virtual DbSet<VSubSourceDestination> VSubSourceDestinations { get; set; }

    public virtual DbSet<VSubStockCard15Day> VSubStockCard15Days { get; set; }

    public virtual DbSet<VSubStockCard15Days2> VSubStockCard15Days2s { get; set; }

    public virtual DbSet<VSubStockCardDaily> VSubStockCardDailies { get; set; }

    public virtual DbSet<VSubStockCardDailyCommodity> VSubStockCardDailyCommodities { get; set; }

    public virtual DbSet<VSubStockCardDailyEnd> VSubStockCardDailyEnds { get; set; }

    public virtual DbSet<VSubStockCardDailyIn> VSubStockCardDailyIns { get; set; }

    public virtual DbSet<VSubStockCardDailyIn2> VSubStockCardDailyIn2s { get; set; }

    public virtual DbSet<VSubStockCardDailyOut> VSubStockCardDailyOuts { get; set; }

    public virtual DbSet<VSubStockCardDailyOut2> VSubStockCardDailyOut2s { get; set; }

    public virtual DbSet<VSubStockCardDailyStockonHand> VSubStockCardDailyStockonHands { get; set; }

    public virtual DbSet<VSubStockCardDailyStockonHandByGroup> VSubStockCardDailyStockonHandByGroups { get; set; }

    public virtual DbSet<VSubStockCardDailyStockonHandDetail> VSubStockCardDailyStockonHandDetails { get; set; }

    public virtual DbSet<VSubStockCardDetail> VSubStockCardDetails { get; set; }

    public virtual DbSet<VSubStockCardEveryDay> VSubStockCardEveryDays { get; set; }

    public virtual DbSet<VSubStockNotYetUpdate> VSubStockNotYetUpdates { get; set; }

    public virtual DbSet<VSubStockNotYetUpdateAvailable> VSubStockNotYetUpdateAvailables { get; set; }

    public virtual DbSet<VTransfer> VTransfers { get; set; }

    public virtual DbSet<VTransferCommodity> VTransferCommodities { get; set; }

    public virtual DbSet<VTransferIn> VTransferIns { get; set; }

    public virtual DbSet<VTransferNotYetUpdate> VTransferNotYetUpdates { get; set; }

    public virtual DbSet<VWardActive> VWardActives { get; set; }

    public virtual DbSet<VYearlyEstimate> VYearlyEstimates { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<YearlyEstimate> YearlyEstimates { get; set; }

    public virtual DbSet<YearlyEstimateDetail> YearlyEstimateDetails { get; set; }

    public virtual DbSet<ZMonthlyAdjustment> ZMonthlyAdjustments { get; set; }

    public virtual DbSet<ZMonthlyAdjustmentSub> ZMonthlyAdjustmentSubs { get; set; }

    public virtual DbSet<ZMonthlyExternalSupply> ZMonthlyExternalSupplies { get; set; }

    public virtual DbSet<ZMonthlyIncoming> ZMonthlyIncomings { get; set; }

    public virtual DbSet<ZMonthlyInitialStockDetail> ZMonthlyInitialStockDetails { get; set; }

    public virtual DbSet<ZMonthlyOutgoing> ZMonthlyOutgoings { get; set; }

    public virtual DbSet<ZMonthlySubConsumption> ZMonthlySubConsumptions { get; set; }

    public virtual DbSet<ZSubMonthlyInitialStockDetail> ZSubMonthlyInitialStockDetails { get; set; }

    public virtual DbSet<Zzzzz> Zzzzzs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=PharmacyExtra;User Id=sa;Password=123456;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Committee>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Commodity>(entity =>
        {
            entity.ToTable("Commodity", tb => tb.HasTrigger("Trig1"));

            entity.HasOne(d => d.CommType).WithMany(p => p.Commodities).HasConstraintName("FK_Commodity_CommodityType");
        });

        modelBuilder.Entity<CommodityCategory>(entity =>
        {
            entity.Property(e => e.CommGrpId).HasComment("Link to CommodityGroup");

            entity.HasOne(d => d.CommGrp).WithMany(p => p.CommodityCategories).HasConstraintName("FK_CommodityCategory_CommodityGroup");
        });

        modelBuilder.Entity<CommodityTransactionDetail>(entity =>
        {
            entity.HasOne(d => d.Comm).WithMany(p => p.CommodityTransactionDetails).HasConstraintName("FK_CommodityTransaction_Detail_Commodity");

            entity.HasOne(d => d.CommTrans).WithMany(p => p.CommodityTransactionDetails).HasConstraintName("FK_CommodityTransaction_Detail_CommodityTransaction");
        });

        modelBuilder.Entity<CommodityType>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.CommodityTypes).HasConstraintName("FK_CommodityType_CommodityCategory");

            entity.HasOne(d => d.CommGrp).WithMany(p => p.CommodityTypes).HasConstraintName("FK_CommodityType_CommodityGroup");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.Property(e => e.ProvinceId).HasComment("Link to Province");

            entity.HasOne(d => d.Province).WithMany(p => p.Districts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_District_Province");
        });

        modelBuilder.Entity<Facility>(entity =>
        {
            entity.HasOne(d => d.District).WithMany(p => p.Facilities).HasConstraintName("FK_Facility_District");

            entity.HasOne(d => d.FacilityType).WithMany(p => p.Facilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Facility_FacilityType");
        });

        modelBuilder.Entity<HosOrderApproval>(entity =>
        {
            entity.Property(e => e.ApprovedId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HosOrderDetail>(entity =>
        {
            entity.Property(e => e.HosOrderDetailId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LoadPi>(entity =>
        {
            entity.ToView("LoadPI");
        });

        modelBuilder.Entity<MainConsumption>(entity =>
        {
            entity.Property(e => e.MainConsId).HasComment("Link to MainConsumption_Detail");
            entity.Property(e => e.IsUpdated).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).IsFixedLength();
        });

        modelBuilder.Entity<MainConsumptionDetail>(entity =>
        {
            entity.Property(e => e.MainConsId).HasComment("Link to MainConsuption");
            entity.Property(e => e.StockAvailable).HasDefaultValue(0);

            entity.HasOne(d => d.MainCons).WithMany(p => p.MainConsumptionDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MainConsumption_Detail_MainConsumption");
        });

        modelBuilder.Entity<MainTransaction>(entity =>
        {
            entity.HasKey(e => e.MainTransactionId).HasName("PK_Transaction");
        });

        modelBuilder.Entity<MainTransferDetail>(entity =>
        {
            entity.Property(e => e.Qty).HasComment("Transfer Quantity");

            entity.HasOne(d => d.Transfer).WithMany(p => p.MainTransferDetails).HasConstraintName("FK_MainTransfer_Detail_MainTransfer");
        });

        modelBuilder.Entity<ManualSelectCommodity>(entity =>
        {
            entity.HasOne(d => d.Commodity).WithOne(p => p.ManualSelectCommodity).HasConstraintName("FK_ManualSelectCommodity_Commodity");
        });

        modelBuilder.Entity<Pi>(entity =>
        {
            entity.Property(e => e.IsUpdated).HasDefaultValue(false);
        });

        modelBuilder.Entity<PiDetail>(entity =>
        {
            entity.Property(e => e.Piid).HasComment("Link to PI");

            entity.HasOne(d => d.Pi).WithMany(p => p.PiDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PI_Detail_PI");
        });

        modelBuilder.Entity<ProcessLog>(entity =>
        {
            entity.Property(e => e.RecordId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReceiveInvoiceDetail>(entity =>
        {
            entity.Property(e => e.InvoiceId).HasComment("Link to ReceiveInvoice");
        });

        modelBuilder.Entity<ReceiveInvoiceReport>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Rircommittee>(entity =>
        {
            entity.Property(e => e.CommitteeUnicode).UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nº).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Invoice).WithMany().HasConstraintName("FK_RIRCommittee_ReceiveInvoiceReport");
        });

        modelBuilder.Entity<SelectedCommodityLot>(entity =>
        {
            entity.Property(e => e.Nº).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SubAdditionalDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Add).WithMany(p => p.SubAdditionalDetails).HasConstraintName("FK_SubAdditionalDetails_SubAdditional");
        });

        modelBuilder.Entity<SubConsumption>(entity =>
        {
            entity.HasKey(e => e.SubConsId).HasName("PK_IPDConsumption");

            entity.Property(e => e.SubConsId).HasComment("Link to IPDConsumption_Detail");
        });

        modelBuilder.Entity<SubConsumptionDetail>(entity =>
        {
            entity.Property(e => e.SubConsDetailId).HasComment("IPDConsumptionDetailID");
            entity.Property(e => e.StockAvailable).HasDefaultValue(0);
            entity.Property(e => e.SubConsId).HasComment("Link to SubConsumption");

            entity.HasOne(d => d.SubCons).WithMany(p => p.SubConsumptionDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubConsumption_Detail_SubConsumption");
        });

        modelBuilder.Entity<SubIssueDetail>(entity =>
        {
            entity.HasOne(d => d.SubIssue).WithMany(p => p.SubIssueDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubIssue_Detail_SubIssue");
        });

        modelBuilder.Entity<SubOrderDetail>(entity =>
        {
            entity.Property(e => e.HosOrderDetailId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.HosOrder).WithMany(p => p.SubOrderDetails).HasConstraintName("FK_SubOrderDetail_SubOrder");
        });

        modelBuilder.Entity<SubPiDetail>(entity =>
        {
            entity.HasOne(d => d.Pi).WithMany(p => p.SubPiDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubPI_Detail_SubPI");
        });

        modelBuilder.Entity<SubPrescription>(entity =>
        {
            entity.HasOne(d => d.RequestNºNavigation).WithMany(p => p.SubPrescriptions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubPrescription_SubRequest");
        });

        modelBuilder.Entity<SubReceive>(entity =>
        {
            entity.Property(e => e.IsUpdated).HasDefaultValue(false);
        });

        modelBuilder.Entity<SubReceiveDetail>(entity =>
        {
            entity.HasOne(d => d.Commodity).WithMany(p => p.SubReceiveDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubReceive_Detail_Commodity");

            entity.HasOne(d => d.MainCons).WithMany(p => p.SubReceiveDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubReceive_Detail_SubReceive");
        });

        modelBuilder.Entity<SubRequest>(entity =>
        {
            entity.Property(e => e.IsImported).HasDefaultValue(false);
        });

        modelBuilder.Entity<SubRequestDetail>(entity =>
        {
            entity.HasOne(d => d.ReqPresNºNavigation).WithMany(p => p.SubRequestDetails).HasConstraintName("FK_SubRequest_Detail_SubPrescription");
        });

        modelBuilder.Entity<SubTransaction>(entity =>
        {
            entity.HasKey(e => e.SubTransactionId).HasName("PK_IPDTransaction");
        });

        modelBuilder.Entity<SubTransferOutDetail>(entity =>
        {
            entity.HasOne(d => d.SubTransOut).WithMany(p => p.SubTransferOutDetails).HasConstraintName("FK_SubTransferOutDetail_SubTransferOut");
        });

        modelBuilder.Entity<SysParam>(entity =>
        {
            entity.Property(e => e.Expire).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ShowStockOut).HasDefaultValue(0);
        });

        modelBuilder.Entity<Tbl2014User>(entity =>
        {
            entity.Property(e => e.AllowAccess).HasDefaultValue(true);
            entity.Property(e => e.AllowApprove).HasDefaultValue(true);
            entity.Property(e => e.AllowDelete).HasDefaultValue(true);
            entity.Property(e => e.AllowPreview).HasDefaultValue(true);
            entity.Property(e => e.AllowUpdate).HasDefaultValue(true);
        });

        modelBuilder.Entity<Tbl2014UserPermission>(entity =>
        {
            entity.Property(e => e.UserPermissionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblHosRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK_tblHosOrder");
        });

        modelBuilder.Entity<TblHosRequestDetail>(entity =>
        {
            entity.HasOne(d => d.Commodity).WithMany(p => p.TblHosRequestDetails).HasConstraintName("FK_tblHosRequestDetail_Commodity");

            entity.HasOne(d => d.RequestNavigation).WithMany(p => p.TblHosRequestDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblHosRequestDetail_tblHosRequest");
        });

        modelBuilder.Entity<TblMainMonthlyTransactionDetail>(entity =>
        {
            entity.HasOne(d => d.Commodity).WithMany(p => p.TblMainMonthlyTransactionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMainMonthlyTransactionDetail_Commodity");

            entity.HasOne(d => d.Report).WithMany(p => p.TblMainMonthlyTransactionDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblMainMonthlyTransactionDetail_tblMainMonthlyTransaction");
        });

        modelBuilder.Entity<TblMainTransferInDetail>(entity =>
        {
            entity.HasOne(d => d.Commodity).WithMany(p => p.TblMainTransferInDetails).HasConstraintName("FK_tblMainTransferInDetail_Commodity");

            entity.HasOne(d => d.TransferIn).WithMany(p => p.TblMainTransferInDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblMainTransferInDetail_tblMainTransferIn");
        });

        modelBuilder.Entity<TblNote>(entity =>
        {
            entity.Property(e => e.IsActived).HasDefaultValue(true);
        });

        modelBuilder.Entity<TmpMainStockCard15Days1>(entity =>
        {
            entity.Property(e => e.BudgetSource).IsFixedLength();
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.LotNo).IsFixedLength();
            entity.Property(e => e.MainTransactionId).IsFixedLength();
            entity.Property(e => e.SourceDestination).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransDes).IsFixedLength();
            entity.Property(e => e.TransGroup).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransNote).IsFixedLength();
            entity.Property(e => e.TransTypeId).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<TmpMainStockCard15Days2>(entity =>
        {
            entity.Property(e => e.BudgetSource).IsFixedLength();
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.LotNo).IsFixedLength();
            entity.Property(e => e.MainTransactionId).IsFixedLength();
            entity.Property(e => e.Note).IsFixedLength();
            entity.Property(e => e.Sd).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<TmpMainStockCard15Days3>(entity =>
        {
            entity.Property(e => e.BudgetSource).IsFixedLength();
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.LotNo).IsFixedLength();
            entity.Property(e => e.MainTransactionId).IsFixedLength();
            entity.Property(e => e.Note).IsFixedLength();
            entity.Property(e => e.Sd).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<TmpStockStatus>(entity =>
        {
            entity.Property(e => e.Nº).HasDefaultValue(1);
        });

        modelBuilder.Entity<TmpStockStatusSummary>(entity =>
        {
            entity.Property(e => e.Nº).HasDefaultValue(1);
        });

        modelBuilder.Entity<TmpSubConsumptionDetail>(entity =>
        {
            entity.Property(e => e.SubConsDetailId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TmpSubPi>(entity =>
        {
            entity.Property(e => e.IsUpdated).HasDefaultValue(false);
            entity.Property(e => e.Pitype).HasDefaultValue(false);
        });

        modelBuilder.Entity<TmpSubPiDetail>(entity =>
        {
            entity.Property(e => e.PidetailId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TmpSubReceive>(entity =>
        {
            entity.Property(e => e.IsExported).HasDefaultValue(false);
            entity.Property(e => e.IsUpdated).HasDefaultValue(false);
        });

        modelBuilder.Entity<TmpSubRequest>(entity =>
        {
            entity.Property(e => e.IsImported).HasDefaultValue(false);
            entity.Property(e => e.IsUpdated).HasDefaultValue(false);
        });

        modelBuilder.Entity<TmpSubRequestDetail>(entity =>
        {
            entity.Property(e => e.Nº).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TmpSubStockCard15Days1>(entity =>
        {
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.SourceDestination).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransDes).IsFixedLength();
            entity.Property(e => e.TransGroup).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransNote).IsFixedLength();
            entity.Property(e => e.TransTypeId).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<TmpSubStockCard15Days2>(entity =>
        {
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.SourceDestination).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransDes).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<TmpSubStockCard15Days3>(entity =>
        {
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.SourceDestination).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransDes).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<VAdditionalRequesDeatail>(entity =>
        {
            entity.ToView("v_AdditionalRequesDeatails");
        });

        modelBuilder.Entity<VBudgetSource>(entity =>
        {
            entity.ToView("vBudgetSource");
        });

        modelBuilder.Entity<VCommodity>(entity =>
        {
            entity.ToView("vCommodity");
        });

        modelBuilder.Entity<VCommodityByService>(entity =>
        {
            entity.ToView("vCommodityByService");
        });

        modelBuilder.Entity<VCommodityByServiceSub>(entity =>
        {
            entity.ToView("vCommodityByServiceSub");
        });

        modelBuilder.Entity<VCommodityTransaction>(entity =>
        {
            entity.ToView("v_CommodityTransaction");
        });

        modelBuilder.Entity<VExpireStatus>(entity =>
        {
            entity.ToView("vExpireStatus");
        });

        modelBuilder.Entity<VHosNote>(entity =>
        {
            entity.ToView("V_HosNote");
        });

        modelBuilder.Entity<VHosOrder>(entity =>
        {
            entity.ToView("v_HosOrder");
        });

        modelBuilder.Entity<VHosOrderDetail>(entity =>
        {
            entity.ToView("V_HosOrderDetail");
        });

        modelBuilder.Entity<VHospitalStockOnHand>(entity =>
        {
            entity.ToView("vHospitalStockOnHand");
        });

        modelBuilder.Entity<VHospitalStockOnHandEnd>(entity =>
        {
            entity.ToView("vHospitalStockOnHandEnd");
        });

        modelBuilder.Entity<VInvoice>(entity =>
        {
            entity.ToView("vInvoice");
        });

        modelBuilder.Entity<VInvoiceReport>(entity =>
        {
            entity.ToView("vInvoiceReport");
        });

        modelBuilder.Entity<VLotNoBsource>(entity =>
        {
            entity.ToView("vLotNoBSource");
        });

        modelBuilder.Entity<VMainDispense>(entity =>
        {
            entity.ToView("vMainDispense");
        });

        modelBuilder.Entity<VMainMonthlyTransaction>(entity =>
        {
            entity.ToView("vMainMonthlyTransaction");
        });

        modelBuilder.Entity<VMainSourceDestination>(entity =>
        {
            entity.ToView("vMainSourceDestination");
        });

        modelBuilder.Entity<VMainStockCardDaily>(entity =>
        {
            entity.ToView("vMainStockCardDaily");
        });

        modelBuilder.Entity<VMainStockCardDailyByLotEnd>(entity =>
        {
            entity.ToView("vMainStockCardDailyByLotEnd");
        });

        modelBuilder.Entity<VMainStockCardDailyByLotIn>(entity =>
        {
            entity.ToView("vMainStockCardDailyByLotIn");
        });

        modelBuilder.Entity<VMainStockCardDailyByLotIn2>(entity =>
        {
            entity.ToView("vMainStockCardDailyByLotIn_2");
        });

        modelBuilder.Entity<VMainStockCardDailyByLotOut>(entity =>
        {
            entity.ToView("vMainStockCardDailyByLotOut");
        });

        modelBuilder.Entity<VMainStockCardDailyByLotOut2>(entity =>
        {
            entity.ToView("vMainStockCardDailyByLotOut_2");
        });

        modelBuilder.Entity<VMainStockCardDailyCommodity>(entity =>
        {
            entity.ToView("vMainStockCardDailyCommodity");
        });

        modelBuilder.Entity<VMainStockCardDailyCommodityByLot>(entity =>
        {
            entity.ToView("vMainStockCardDailyCommodityByLot");
        });

        modelBuilder.Entity<VMainStockCardDailyEnd>(entity =>
        {
            entity.ToView("vMainStockCardDailyEnd");
        });

        modelBuilder.Entity<VMainStockCardDailyIn>(entity =>
        {
            entity.ToView("vMainStockCardDailyIn");

            entity.Property(e => e.MainTransactionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VMainStockCardDailyIn2>(entity =>
        {
            entity.ToView("vMainStockCardDailyIn_2");
        });

        modelBuilder.Entity<VMainStockCardDailyOut>(entity =>
        {
            entity.ToView("vMainStockCardDailyOut");
        });

        modelBuilder.Entity<VMainStockCardDailyOut2>(entity =>
        {
            entity.ToView("vMainStockCardDailyOut_2");
        });

        modelBuilder.Entity<VMainStockCardDailyStockonHand>(entity =>
        {
            entity.ToView("vMainStockCardDailyStockonHand");
        });

        modelBuilder.Entity<VMainStockCardDailyStockonHandByGroup>(entity =>
        {
            entity.ToView("vMainStockCardDailyStockonHandByGroup");
        });

        modelBuilder.Entity<VMainStockCardDailyStockonHandByGroupByLot>(entity =>
        {
            entity.ToView("vMainStockCardDailyStockonHandByGroupByLot");
        });

        modelBuilder.Entity<VMainStockCardDailyStockonHandByLot>(entity =>
        {
            entity.ToView("vMainStockCardDailyStockonHandByLot");
        });

        modelBuilder.Entity<VMainStockCardDailyStockonHandDetail>(entity =>
        {
            entity.ToView("vMainStockCardDailyStockonHandDetail");
        });

        modelBuilder.Entity<VMainStockCardDailyStockonHandDetailByLot>(entity =>
        {
            entity.ToView("vMainStockCardDailyStockonHandDetailByLot");
        });

        modelBuilder.Entity<VMainStockNotYetUpdate>(entity =>
        {
            entity.ToView("vMainStockNotYetUpdate");
        });

        modelBuilder.Entity<VMainStockNotYetUpdateAvailable>(entity =>
        {
            entity.ToView("vMainStockNotYetUpdateAvailable");
        });

        modelBuilder.Entity<VMonthlyAdjustment>(entity =>
        {
            entity.ToView("v_MonthlyAdjustment");
        });

        modelBuilder.Entity<VMonthlyStockOnHand>(entity =>
        {
            entity.ToView("vMonthlyStockOnHand");
        });

        modelBuilder.Entity<VPiall>(entity =>
        {
            entity.ToView("vPIAll");
        });

        modelBuilder.Entity<VPibyGroup>(entity =>
        {
            entity.ToView("vPIByGroup");
        });

        modelBuilder.Entity<VPichangeExpiryDate>(entity =>
        {
            entity.ToView("vPIChangeExpiryDate");
        });

        modelBuilder.Entity<VPichangeExpiryDateSelectedLot>(entity =>
        {
            entity.ToView("vPIChangeExpiryDateSelectedLot");
        });

        modelBuilder.Entity<VQuarterlyRequest>(entity =>
        {
            entity.ToView("vQuarterlyRequest");
        });

        modelBuilder.Entity<VQuaterlyRequestReport>(entity =>
        {
            entity.ToView("v_QuaterlyRequestReport");
        });

        modelBuilder.Entity<VReceiveInvoiceReportAdj>(entity =>
        {
            entity.ToView("vReceiveInvoiceReportAdj");
        });

        modelBuilder.Entity<VReceiveInvoiceReportBrok>(entity =>
        {
            entity.ToView("vReceiveInvoiceReportBrok");
        });

        modelBuilder.Entity<VReceiveInvoiceReportDef>(entity =>
        {
            entity.ToView("vReceiveInvoiceReportDef");
        });

        modelBuilder.Entity<VReceiveInvoiceReportInsu>(entity =>
        {
            entity.ToView("vReceiveInvoiceReportInsu");
        });

        modelBuilder.Entity<VSdtransfer>(entity =>
        {
            entity.ToView("vSDTransfer");
        });

        modelBuilder.Entity<VSdtransferIn>(entity =>
        {
            entity.ToView("vSDTransferIn");
        });

        modelBuilder.Entity<VSohofSubPhamacy>(entity =>
        {
            entity.ToView("v_SOHOfSubPhamacy");
        });

        modelBuilder.Entity<VSource>(entity =>
        {
            entity.ToView("vSource");
        });

        modelBuilder.Entity<VSourceCm>(entity =>
        {
            entity.ToView("vSourceCMS");
        });

        modelBuilder.Entity<VSourceNonCm>(entity =>
        {
            entity.ToView("vSourceNonCMS");
        });

        modelBuilder.Entity<VStockCard15Day>(entity =>
        {
            entity.ToView("vStockCard15Days");
        });

        modelBuilder.Entity<VStockCardByLot15Day>(entity =>
        {
            entity.ToView("vStockCardByLot15Days");
        });

        modelBuilder.Entity<VStockCardByLot15Days1>(entity =>
        {
            entity.ToView("vStockCardByLot15Days1");

            entity.Property(e => e.BudgetSource).IsFixedLength();
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.LotNo).IsFixedLength();
            entity.Property(e => e.MainTransactionId).IsFixedLength();
            entity.Property(e => e.Note).IsFixedLength();
            entity.Property(e => e.Sd).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<VStockCardByLot15Days3>(entity =>
        {
            entity.ToView("vStockCardByLot15Days3");

            entity.Property(e => e.BudgetSource).IsFixedLength();
            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.LotNo).IsFixedLength();
            entity.Property(e => e.MainTransactionId).IsFixedLength();
            entity.Property(e => e.Note).IsFixedLength();
            entity.Property(e => e.Sd).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<VStockCardByLotEveryday>(entity =>
        {
            entity.ToView("vStockCardByLotEveryday");
        });

        modelBuilder.Entity<VStockCardDetail>(entity =>
        {
            entity.ToView("vStockCardDetail");
        });

        modelBuilder.Entity<VStockCardEveryDay>(entity =>
        {
            entity.ToView("vStockCardEveryDay");
        });

        modelBuilder.Entity<VStockCardEveryDayEnd>(entity =>
        {
            entity.ToView("vStockCardEveryDayEnd");
        });

        modelBuilder.Entity<VStockOnHand>(entity =>
        {
            entity.ToView("vStockOnHand");
        });

        modelBuilder.Entity<VStockOutCommodity>(entity =>
        {
            entity.ToView("vStockOutCommodity");

            entity.Property(e => e.MainTransactionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VStockStatus>(entity =>
        {
            entity.ToView("vStockStatus");
        });

        modelBuilder.Entity<VStockonHandByLotById>(entity =>
        {
            entity.ToView("vStockonHandByLotByID");
        });

        modelBuilder.Entity<VStockonHandDetail>(entity =>
        {
            entity.ToView("vStockonHandDetail");
        });

        modelBuilder.Entity<VSubDispense>(entity =>
        {
            entity.ToView("vSubDispense");
        });

        modelBuilder.Entity<VSubIssueNotYetUpdate>(entity =>
        {
            entity.ToView("vSubIssueNotYetUpdate");
        });

        modelBuilder.Entity<VSubPharmacy>(entity =>
        {
            entity.ToView("vSubPharmacy");
        });

        modelBuilder.Entity<VSubPi>(entity =>
        {
            entity.ToView("vSubPI");
        });

        modelBuilder.Entity<VSubPibyGroup>(entity =>
        {
            entity.ToView("vSubPIByGroup");
        });

        modelBuilder.Entity<VSubReceive>(entity =>
        {
            entity.ToView("vSubReceive");
        });

        modelBuilder.Entity<VSubRequest>(entity =>
        {
            entity.ToView("vSubRequest");
        });

        modelBuilder.Entity<VSubRequestNotYetUpdate>(entity =>
        {
            entity.ToView("vSubRequestNotYetUpdate");
        });

        modelBuilder.Entity<VSubRequestReport>(entity =>
        {
            entity.ToView("vSubRequestReport");
        });

        modelBuilder.Entity<VSubRequestReportSum>(entity =>
        {
            entity.ToView("vSubRequestReportSum");
        });

        modelBuilder.Entity<VSubRequestSearch>(entity =>
        {
            entity.ToView("vSubRequestSearch");
        });

        modelBuilder.Entity<VSubSourceDestination>(entity =>
        {
            entity.ToView("vSubSourceDestination");
        });

        modelBuilder.Entity<VSubStockCard15Day>(entity =>
        {
            entity.ToView("vSubStockCard15Days");
        });

        modelBuilder.Entity<VSubStockCard15Days2>(entity =>
        {
            entity.ToView("vSubStockCard15Days2");

            entity.Property(e => e.CommodityId).IsFixedLength();
            entity.Property(e => e.CommodityName).IsFixedLength();
            entity.Property(e => e.Form).IsFixedLength();
            entity.Property(e => e.InvoiceId).IsFixedLength();
            entity.Property(e => e.SourceDestination).IsFixedLength();
            entity.Property(e => e.Strength).IsFixedLength();
            entity.Property(e => e.TransDes).IsFixedLength();
            entity.Property(e => e.TransName).IsFixedLength();
            entity.Property(e => e.TransYear).IsFixedLength();
        });

        modelBuilder.Entity<VSubStockCardDaily>(entity =>
        {
            entity.ToView("vSubStockCardDaily");
        });

        modelBuilder.Entity<VSubStockCardDailyCommodity>(entity =>
        {
            entity.ToView("vSubStockCardDailyCommodity");
        });

        modelBuilder.Entity<VSubStockCardDailyEnd>(entity =>
        {
            entity.ToView("vSubStockCardDailyEnd");
        });

        modelBuilder.Entity<VSubStockCardDailyIn>(entity =>
        {
            entity.ToView("vSubStockCardDailyIn");
        });

        modelBuilder.Entity<VSubStockCardDailyIn2>(entity =>
        {
            entity.ToView("vSubStockCardDailyIn_2");
        });

        modelBuilder.Entity<VSubStockCardDailyOut>(entity =>
        {
            entity.ToView("vSubStockCardDailyOut");
        });

        modelBuilder.Entity<VSubStockCardDailyOut2>(entity =>
        {
            entity.ToView("vSubStockCardDailyOut_2");
        });

        modelBuilder.Entity<VSubStockCardDailyStockonHand>(entity =>
        {
            entity.ToView("vSubStockCardDailyStockonHand");
        });

        modelBuilder.Entity<VSubStockCardDailyStockonHandByGroup>(entity =>
        {
            entity.ToView("vSubStockCardDailyStockonHandByGroup");
        });

        modelBuilder.Entity<VSubStockCardDailyStockonHandDetail>(entity =>
        {
            entity.ToView("vSubStockCardDailyStockonHandDetail");
        });

        modelBuilder.Entity<VSubStockCardDetail>(entity =>
        {
            entity.ToView("vSubStockCardDetail");
        });

        modelBuilder.Entity<VSubStockCardEveryDay>(entity =>
        {
            entity.ToView("vSubStockCardEveryDay");
        });

        modelBuilder.Entity<VSubStockNotYetUpdate>(entity =>
        {
            entity.ToView("vSubStockNotYetUpdate");
        });

        modelBuilder.Entity<VSubStockNotYetUpdateAvailable>(entity =>
        {
            entity.ToView("vSubStockNotYetUpdateAvailable");
        });

        modelBuilder.Entity<VTransfer>(entity =>
        {
            entity.ToView("vTransfer");
        });

        modelBuilder.Entity<VTransferCommodity>(entity =>
        {
            entity.ToView("vTransferCommodity");
        });

        modelBuilder.Entity<VTransferIn>(entity =>
        {
            entity.ToView("vTransferIn");
        });

        modelBuilder.Entity<VTransferNotYetUpdate>(entity =>
        {
            entity.ToView("vTransferNotYetUpdate");
        });

        modelBuilder.Entity<VWardActive>(entity =>
        {
            entity.ToView("vWardActive");
        });

        modelBuilder.Entity<VYearlyEstimate>(entity =>
        {
            entity.ToView("v_YearlyEstimate");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity.ToView("VIEW1");
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity.ToView("VIEW2");
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<YearlyEstimate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<YearlyEstimateDetail>(entity =>
        {
            entity.Property(e => e.MAuto).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ZMonthlyAdjustment>(entity =>
        {
            entity.ToView("zMonthlyAdjustment");
        });

        modelBuilder.Entity<ZMonthlyAdjustmentSub>(entity =>
        {
            entity.ToView("zMonthlyAdjustmentSub");
        });

        modelBuilder.Entity<ZMonthlyExternalSupply>(entity =>
        {
            entity.ToView("zMonthlyExternalSupply");
        });

        modelBuilder.Entity<ZMonthlyIncoming>(entity =>
        {
            entity.ToView("zMonthlyIncoming");
        });

        modelBuilder.Entity<ZMonthlyInitialStockDetail>(entity =>
        {
            entity.ToView("zMonthlyInitialStockDetail");

            entity.Property(e => e.MainTransactionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ZMonthlyOutgoing>(entity =>
        {
            entity.ToView("zMonthlyOutgoing");
        });

        modelBuilder.Entity<ZMonthlySubConsumption>(entity =>
        {
            entity.ToView("zMonthlySubConsumption");
        });

        modelBuilder.Entity<ZSubMonthlyInitialStockDetail>(entity =>
        {
            entity.ToView("zSubMonthlyInitialStockDetail");

            entity.Property(e => e.SubTransactionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Zzzzz>(entity =>
        {
            entity.ToView("ZZZZZ");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
