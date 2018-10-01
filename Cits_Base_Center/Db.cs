using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cits_Base_Center
{
    public partial class Db : DbContext
    {
        public virtual DbSet<MApps> MApps { get; set; }
        public virtual DbSet<MBankaccts> MBankaccts { get; set; }
        public virtual DbSet<MBanks> MBanks { get; set; }
        public virtual DbSet<MBillStatus> MBillStatus { get; set; }
        public virtual DbSet<MBooks> MBooks { get; set; }
        public virtual DbSet<MBranchs> MBranchs { get; set; }
        public virtual DbSet<MChargeTypes> MChargeTypes { get; set; }
        public virtual DbSet<MCimRoleTypes> MCimRoleTypes { get; set; }
        public virtual DbSet<MCorps> MCorps { get; set; }
        public virtual DbSet<MCurrencys> MCurrencys { get; set; }
        public virtual DbSet<MCustomers> MCustomers { get; set; }
        public virtual DbSet<MDepts> MDepts { get; set; }
        public virtual DbSet<MFormPrints> MFormPrints { get; set; }
        public virtual DbSet<MInvoiceStatus> MInvoiceStatus { get; set; }
        public virtual DbSet<MJobs> MJobs { get; set; }
        public virtual DbSet<MMailTypes> MMailTypes { get; set; }
        public virtual DbSet<MMenus> MMenus { get; set; }
        public virtual DbSet<MPackingItems> MPackingItems { get; set; }
        public virtual DbSet<MPaybatchStatus> MPaybatchStatus { get; set; }
        public virtual DbSet<MPayInStatus> MPayInStatus { get; set; }
        public virtual DbSet<MPaymentbatchStatus> MPaymentbatchStatus { get; set; }
        public virtual DbSet<MPdbrands> MPdbrands { get; set; }
        public virtual DbSet<MPdcolors> MPdcolors { get; set; }
        public virtual DbSet<MPdmodels> MPdmodels { get; set; }
        public virtual DbSet<MPdsizes> MPdsizes { get; set; }
        public virtual DbSet<MProducts> MProducts { get; set; }
        public virtual DbSet<MProjs> MProjs { get; set; }
        public virtual DbSet<MReftype> MReftype { get; set; }
        public virtual DbSet<MRemarkKeys> MRemarkKeys { get; set; }
        public virtual DbSet<MRoles> MRoles { get; set; }
        public virtual DbSet<MSalesreps> MSalesreps { get; set; }
        public virtual DbSet<MSaleszones> MSaleszones { get; set; }
        public virtual DbSet<MSects> MSects { get; set; }
        public virtual DbSet<MSentMailConf> MSentMailConf { get; set; }
        public virtual DbSet<MServiceTypes> MServiceTypes { get; set; }
        public virtual DbSet<MSites> MSites { get; set; }
        public virtual DbSet<MUsers> MUsers { get; set; }
        public virtual DbSet<MVattype> MVattype { get; set; }
        public virtual DbSet<MVendors> MVendors { get; set; }
        public virtual DbSet<MWhouses> MWhouses { get; set; }
        public virtual DbSet<MWhtDeliveryTypes> MWhtDeliveryTypes { get; set; }
        public virtual DbSet<MWhtIncomeTypes> MWhtIncomeTypes { get; set; }
        public virtual DbSet<MWhtTypes> MWhtTypes { get; set; }
        public virtual DbSet<RRoleMenus> RRoleMenus { get; set; }
        public virtual DbSet<TActionLogs> TActionLogs { get; set; }
        public virtual DbSet<TCorpUsers> TCorpUsers { get; set; }
        public virtual DbSet<TCustomerUpdateLogs> TCustomerUpdateLogs { get; set; }
        public virtual DbSet<TPrintLogs> TPrintLogs { get; set; }
        public virtual DbSet<TSentMailLogs> TSentMailLogs { get; set; }
        public virtual DbSet<TStock> TStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=PLEKANGLE\SQLEXPRESS;initial catalog=Ci_BASE_CENTER;persist security info=True;user id=import_user;password=P@ssw0rd;MultipleActiveResultSets=True;");
                //optionsBuilder.UseSqlServer(GetStringSetting("DbT"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MApps>(entity =>
            {
                entity.Property(e => e.AppId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.AppCode).IsUnicode(false);

                entity.Property(e => e.AppDomainName).IsUnicode(false);

                entity.Property(e => e.AppNameEn).IsUnicode(false);

                entity.Property(e => e.AppNameTh).IsUnicode(false);

                entity.Property(e => e.AppSkinCss).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBankaccts>(entity =>
            {
                entity.Property(e => e.BankacctId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.BankId).IsUnicode(false);

                entity.Property(e => e.BankacctCode).IsUnicode(false);

                entity.Property(e => e.BankacctNameEn).IsUnicode(false);

                entity.Property(e => e.BankacctNameTh).IsUnicode(false);

                entity.Property(e => e.BankacctNo).IsUnicode(false);

                entity.Property(e => e.BranchId).IsUnicode(false);

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1).IsUnicode(false);

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBanks>(entity =>
            {
                entity.Property(e => e.BankId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BankBotcode).IsUnicode(false);

                entity.Property(e => e.BankCode).IsUnicode(false);

                entity.Property(e => e.BankColorRgb).IsUnicode(false);

                entity.Property(e => e.BankNameEn).IsUnicode(false);

                entity.Property(e => e.BankNameTh).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.TextColorRgb).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MBillStatus>(entity =>
            {
                entity.Property(e => e.BillStatusId).ValueGeneratedNever();

                entity.Property(e => e.BillStatusName).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MBooks>(entity =>
            {
                entity.Property(e => e.BookId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BookCode).IsUnicode(false);

                entity.Property(e => e.BookNameEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BookNameTh)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).IsUnicode(false);

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId01)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId02)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId03)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId04)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId05)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId06)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId07)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId08)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId09)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReftypeId).IsUnicode(false);

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBranchs>(entity =>
            {
                entity.Property(e => e.BranchId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.BranchAddressTh1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchAddressTh2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchAddressTh3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.BranchFaxNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchNameEn).IsUnicode(false);

                entity.Property(e => e.BranchNameTh).IsUnicode(false);

                entity.Property(e => e.BranchTelNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Vatbranchcode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vatisout).HasDefaultValueSql("((1))");

                entity.Property(e => e.VattypeId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MChargeTypes>(entity =>
            {
                entity.Property(e => e.ChargeTypeId).ValueGeneratedNever();

                entity.Property(e => e.ChargeTypeNameEn).IsUnicode(false);

                entity.Property(e => e.ChargeTypeNameTh).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCimRoleTypes>(entity =>
            {
                entity.Property(e => e.RoleTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleTypeNameEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleTypeNameTh).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCorps>(entity =>
            {
                entity.Property(e => e.CorpId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.CorpCode).IsUnicode(false);

                entity.Property(e => e.CorpNameEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CorpNameTh).IsUnicode(false);

                entity.Property(e => e.CorpTaxId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('THB')");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCurrencys>(entity =>
            {
                entity.Property(e => e.CurrencyId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyNameEn).IsUnicode(false);

                entity.Property(e => e.CurrencyNameTh).IsUnicode(false);

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCustomers>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.AddressTh1).IsUnicode(false);

                entity.Property(e => e.AddressTh2).IsUnicode(false);

                entity.Property(e => e.AddressTh3).IsUnicode(false);

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CustomerCode).IsUnicode(false);

                entity.Property(e => e.CustomerNameEn).IsUnicode(false);

                entity.Property(e => e.CustomerNameTh).IsUnicode(false);

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxNo).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.TaxId).IsUnicode(false);

                entity.Property(e => e.TelNo).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.Vatbranchcode).IsUnicode(false);

                entity.Property(e => e.Vatbranchname).IsUnicode(false);

                entity.Property(e => e.Zip).IsUnicode(false);
            });

            modelBuilder.Entity<MDepts>(entity =>
            {
                entity.Property(e => e.DeptId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.DeptNameEn).IsUnicode(false);

                entity.Property(e => e.DeptNameTh).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MFormPrints>(entity =>
            {
                entity.Property(e => e.FormPrintId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Barcode1SqlStringFile)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CorpId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintCode).IsUnicode(false);

                entity.Property(e => e.FormPrintNameEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintNameTh).IsUnicode(false);

                entity.Property(e => e.PaperlessReportId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MInvoiceStatus>(entity =>
            {
                entity.Property(e => e.InvoiceStatusId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceStatusNameEn).IsUnicode(false);

                entity.Property(e => e.InvoiceStatusNameTh).IsUnicode(false);

                entity.Property(e => e.InvoiceStatusType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MJobs>(entity =>
            {
                entity.Property(e => e.JobId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobCode).IsUnicode(false);

                entity.Property(e => e.JobNameEn).IsUnicode(false);

                entity.Property(e => e.JobNameTh).IsUnicode(false);

                entity.Property(e => e.ProjId).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MMailTypes>(entity =>
            {
                entity.Property(e => e.MailTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.MailTypeName).IsUnicode(false);

                entity.Property(e => e.MailTypeSubject).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MMenus>(entity =>
            {
                entity.Property(e => e.MenuId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.MenuCode).IsUnicode(false);

                entity.Property(e => e.MenuName).IsUnicode(false);

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MPackingItems>(entity =>
            {
                entity.Property(e => e.PackingItemId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.PackingItemCode).IsUnicode(false);

                entity.Property(e => e.PackingItemDescription).IsUnicode(false);

                entity.Property(e => e.PackingItemName).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UmNameQty1).IsUnicode(false);

                entity.Property(e => e.UmNameQty2).IsUnicode(false);

                entity.Property(e => e.UmNameQty3).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MPaybatchStatus>(entity =>
            {
                entity.Property(e => e.PaybatchStatusId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaybatchStatusNameEn).IsUnicode(false);

                entity.Property(e => e.PaybatchStatusNameTh).IsUnicode(false);

                entity.Property(e => e.PaybatchStatusType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MPayInStatus>(entity =>
            {
                entity.Property(e => e.PayInStatusId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.PayInStatusName).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MPaymentbatchStatus>(entity =>
            {
                entity.Property(e => e.PaymentbatchStatusId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentbatchStatusNameEn).IsUnicode(false);

                entity.Property(e => e.PaymentbatchStatusNameTh).IsUnicode(false);

                entity.Property(e => e.PaymentbatchStatusType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MPdbrands>(entity =>
            {
                entity.Property(e => e.PdbrandId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdbrandCode).IsUnicode(false);

                entity.Property(e => e.PdbrandNameEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdbrandNameTh).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('19000101')");
            });

            modelBuilder.Entity<MPdcolors>(entity =>
            {
                entity.Property(e => e.PdcolorId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.PdcolorCode).IsUnicode(false);

                entity.Property(e => e.PdcolorNameEn).IsUnicode(false);

                entity.Property(e => e.PdcolorNameTh).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MPdmodels>(entity =>
            {
                entity.Property(e => e.PdmodelId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.PdmodelCode).IsUnicode(false);

                entity.Property(e => e.PdmodelNameEn).IsUnicode(false);

                entity.Property(e => e.PdmodelNameTh).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.PdbrandId).IsUnicode(false);

                entity.Property(e => e.UmName).IsUnicode(false);

                entity.Property(e => e.UmNameSales).IsUnicode(false);

                entity.Property(e => e.UmqtySales).IsUnicode(false);

                entity.Property(e => e.SalesPrice).IsUnicode(false);

            });

            modelBuilder.Entity<MPdsizes>(entity =>
            {
                entity.Property(e => e.PdsizeId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.PdsizeCode).IsUnicode(false);

                entity.Property(e => e.PdsizeNameEn).IsUnicode(false);

                entity.Property(e => e.PdsizeNameTh).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MProducts>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdbrandId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdcolorId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdmodelId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdsizeId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCode).IsUnicode(false);

                entity.Property(e => e.ProductNameEn).IsUnicode(false);

                entity.Property(e => e.ProductNameTh).IsUnicode(false);

                entity.Property(e => e.ProductSnameEn).IsUnicode(false);

                entity.Property(e => e.ProductSnameTh).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UmName).IsUnicode(false);

                entity.Property(e => e.UmNameSales).IsUnicode(false);

                entity.Property(e => e.UmqtySales).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('19000101')");
            });

            modelBuilder.Entity<MProjs>(entity =>
            {
                entity.Property(e => e.ProjId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjCode).IsUnicode(false);

                entity.Property(e => e.ProjNameEn).IsUnicode(false);

                entity.Property(e => e.ProjNameTh).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MReftype>(entity =>
            {
                entity.Property(e => e.ReftypeId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReftypeGroup).IsUnicode(false);

                entity.Property(e => e.ReftypeNameEn).IsUnicode(false);

                entity.Property(e => e.ReftypeNameTh).IsUnicode(false);

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('19000101')");
            });

            modelBuilder.Entity<MRemarkKeys>(entity =>
            {
                entity.Property(e => e.RemarkKeyId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MRoles>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.RoleCode).IsUnicode(false);

                entity.Property(e => e.RoleName).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MSalesreps>(entity =>
            {
                entity.Property(e => e.SalesrepId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesrepCode).IsUnicode(false);

                entity.Property(e => e.SalesrepNameEn).IsUnicode(false);

                entity.Property(e => e.SalesrepNameTh).IsUnicode(false);

                entity.Property(e => e.SaleszoneId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSaleszones>(entity =>
            {
                entity.Property(e => e.SaleszoneId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaleszoneCode).IsUnicode(false);

                entity.Property(e => e.SaleszoneNameEn).IsUnicode(false);

                entity.Property(e => e.SaleszoneNameTh).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSects>(entity =>
            {
                entity.Property(e => e.SectId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptId).IsUnicode(false);

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SectCode).IsUnicode(false);

                entity.Property(e => e.SectNameEn).IsUnicode(false);

                entity.Property(e => e.SectNameTh).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('19000101')");
            });

            modelBuilder.Entity<MSentMailConf>(entity =>
            {
                entity.Property(e => e.SentMailConfId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.MailTypeId).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<MServiceTypes>(entity =>
            {
                entity.Property(e => e.ServiceTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceTypeNameEn).IsUnicode(false);

                entity.Property(e => e.ServiceTypeNameTh).IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSites>(entity =>
            {
                entity.Property(e => e.SiteId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteCode).IsUnicode(false);

                entity.Property(e => e.SiteDomainName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.SiteSkinCss)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MUsers>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('THB')");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirebaseId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MfaCreateDate).HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.MfaKey)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MfaStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MVattype>(entity =>
            {
                entity.Property(e => e.VattypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.VatNameEn).IsUnicode(false);

                entity.Property(e => e.VatNameTh).IsUnicode(false);
            });

            modelBuilder.Entity<MVendors>(entity =>
            {
                entity.Property(e => e.VendorId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApprovedBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.AttentionMessage)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AttentionTo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAccountNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAccountNoStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.BankBranchCode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CorpId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferId1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransferLimit).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VendorCode).IsUnicode(false);

                entity.Property(e => e.VendorNameEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VendorNameTh)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtDeliveryTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtIncomeTypeId1).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtIncomeTypeId2).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtIncomeTypeId3).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate1).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate2).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate3).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtTypeId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MWhouses>(entity =>
            {
                entity.Property(e => e.WhouseId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId).IsUnicode(false);

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.ReferId1).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.WhouseCode).IsUnicode(false);

                entity.Property(e => e.WhouseName).IsUnicode(false);
            });

            modelBuilder.Entity<MWhtDeliveryTypes>(entity =>
            {
                entity.Property(e => e.WhtDeliveryTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WhtDeliveryTypeNameEn).IsUnicode(false);

                entity.Property(e => e.WhtDeliveryTypeNameTh).IsUnicode(false);
            });

            modelBuilder.Entity<MWhtIncomeTypes>(entity =>
            {
                entity.Property(e => e.WhtIncomeTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WhtIncomeTypeNameEn).IsUnicode(false);

                entity.Property(e => e.WhtIncomeTypeNameTh).IsUnicode(false);

                entity.Property(e => e.WhtRate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MWhtTypes>(entity =>
            {
                entity.Property(e => e.WhtTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WhtGroupType).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtIncomeTypeId1).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtIncomeTypeId2).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtIncomeTypeId3).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate1).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate2).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate3).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtTypeNameEn).IsUnicode(false);

                entity.Property(e => e.WhtTypeNameTh).IsUnicode(false);
            });

            modelBuilder.Entity<RRoleMenus>(entity =>
            {
                entity.Property(e => e.RoleMenuId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.MenuId).IsUnicode(false);

                entity.Property(e => e.RoleId).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);
            });

            modelBuilder.Entity<TActionLogs>(entity =>
            {
                entity.Property(e => e.ActionLogId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.MenuId).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<TCorpUsers>(entity =>
            {
                entity.Property(e => e.CorpUserId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveStatusDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('19000101')");

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<TCustomerUpdateLogs>(entity =>
            {
                entity.Property(e => e.CustomerUpdateLogId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.NewData).IsUnicode(false);

                entity.Property(e => e.OldData).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.UpdateField).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<TPrintLogs>(entity =>
            {
                entity.Property(e => e.PrintLogId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Barcode1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormPrintId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MasterId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumberOfPrinting).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalamtTextEn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalamtTextTh)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TSentMailLogs>(entity =>
            {
                entity.Property(e => e.SentMailLogId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<TStock>(entity =>
            {
                entity.Property(e => e.StockId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId).IsUnicode(false);

                entity.Property(e => e.CorpId).IsUnicode(false);

                entity.Property(e => e.CreateBy).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemId).IsUnicode(false);

                entity.Property(e => e.Lot).IsUnicode(false);

                entity.Property(e => e.ReferId1).IsUnicode(false);

                entity.Property(e => e.Revision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.UpdateBy).IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WhouseId).IsUnicode(false);
            });
        }

        private static Dictionary<string, object> GetSettings(string path)
        {
            Dictionary<string, object> _ret = new Dictionary<string, object>();
            //ShowMyData.Show(path);
            if (File.Exists(path))
            {
                //ShowMyData.Show(1);
                StreamReader reader = new StreamReader
                (
                    new FileStream(
                        path,
                        FileMode.Open,
                        FileAccess.Read,
                        FileShare.Read)
                );

                XmlDocument doc = new XmlDocument();
                string xmlIn = reader.ReadToEnd();
                reader.Close();
                doc.LoadXml(xmlIn);

                foreach (XmlNode item in doc.ChildNodes)
                {
                    if (item.Name.Equals("configuration"))
                    {
                        foreach (XmlNode child in item.ChildNodes)
                        {
                            if (child.Name.Equals("appSettings"))
                                foreach (XmlNode node in child.ChildNodes)
                                {
                                    if (node.Name.Equals("add"))
                                        _ret.Add
                                        (
                                            node.Attributes["key"].Value,
                                            node.Attributes["value"].Value
                                        );
                                }
                        }
                    }
                }


            }
            return (_ret);
        }

        public static string GetStringSetting(string key)
        {
            string resultString = string.Empty;

            var setting = GetSettings(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Connection.xml"));

            try
            {
                resultString = setting[key].ToString();
            }
            catch (Exception e)
            {
            }

            return resultString;
        }

    }
}
