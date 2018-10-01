using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cits_Base_Center.Migrations
{
    public partial class First_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_APPs",
                columns: table => new
                {
                    APP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    APP_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    APP_DOMAIN_NAME = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    APP_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    APP_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    APP_SKIN_CSS = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_APPs", x => x.APP_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_BANKACCTs",
                columns: table => new
                {
                    BANKACCT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    BANK_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BANKACCT_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BANKACCT_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    BANKACCT_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    BANKACCT_NO = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BRANCH_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(getdate())"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BANKACCTs", x => x.BANKACCT_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_BANKs",
                columns: table => new
                {
                    BANK_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BANK_BOTCODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BANK_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BANK_COLOR_RGB = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BANK_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    BANK_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    TEXT_COLOR_RGB = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BANKs", x => x.BANK_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_BILL_STATUS",
                columns: table => new
                {
                    BILL_STATUS_ID = table.Column<int>(nullable: false),
                    BILL_STATUS_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETE_STATUS = table.Column<int>(nullable: true),
                    REVISION = table.Column<int>(nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BILL_STATUS", x => x.BILL_STATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_BOOKs",
                columns: table => new
                {
                    BOOK_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    BOOK_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BOOK_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    BOOK_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    BRANCH_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_01 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_02 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_03 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_04 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_05 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_06 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_07 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_08 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_09 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID_10 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REFTYPE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BOOKs", x => x.BOOK_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_BRANCHs",
                columns: table => new
                {
                    BRANCH_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    BRANCH_ADDRESS_TH_1 = table.Column<string>(unicode: false, maxLength: 125, nullable: false, defaultValueSql: "((0))"),
                    BRANCH_ADDRESS_TH_2 = table.Column<string>(unicode: false, maxLength: 125, nullable: false, defaultValueSql: "((0))"),
                    BRANCH_ADDRESS_TH_3 = table.Column<string>(unicode: false, maxLength: 125, nullable: false, defaultValueSql: "((0))"),
                    BRANCH_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BRANCH_FAX_NO = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    BRANCH_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    BRANCH_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    BRANCH_TEL_NO = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    VATBRANCHCODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    VATISOUT = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    VATTYPE_ID = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BRANCHs", x => x.BRANCH_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_CHARGE_TYPEs",
                columns: table => new
                {
                    CHARGE_TYPE_ID = table.Column<int>(nullable: false),
                    CHARGE_TYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CHARGE_TYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CHARGE_TYPEs", x => x.CHARGE_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_CIM_ROLE_TYPEs",
                columns: table => new
                {
                    ROLE_TYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STAT = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ROLE_TYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "('')"),
                    ROLE_TYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CIM_ROLE_TYPEs", x => x.ROLE_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_CORPs",
                columns: table => new
                {
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    CORP_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CORP_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    CORP_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CORP_TAX_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CURRENCY_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('THB')"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CORPs", x => x.CORP_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_CURRENCYs",
                columns: table => new
                {
                    CURRENCY_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CURRENCY_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CURRENCY_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CURRENCYs", x => x.CURRENCY_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_CUSTOMERs",
                columns: table => new
                {
                    CUSTOMER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('19000101')"),
                    ADDRESS_TH_1 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    ADDRESS_TH_2 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    ADDRESS_TH_3 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('19000101')"),
                    CUSTOMER_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CUSTOMER_NAME_EN = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    CUSTOMER_NAME_TH = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    FAX_NO = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    ISCUST = table.Column<int>(nullable: false),
                    ISSUPP = table.Column<int>(nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    TAX_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    TEL_NO = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('19000101')"),
                    VATBRANCHCODE = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    VATBRANCHNAME = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    ZIP = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CUSTOMERs", x => x.CUSTOMER_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_DEPTs",
                columns: table => new
                {
                    DEPT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    DEPT_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    DEPT_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    DEPT_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DEPTs", x => x.DEPT_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_FORM_PRINTs",
                columns: table => new
                {
                    FORM_PRINT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    BARCODE_1_SQL_STRING_FILE = table.Column<string>(unicode: false, maxLength: 150, nullable: false, defaultValueSql: "((0))"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    FORM_PRINT_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PAPERLESS_REPORT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_FORM_PRINTs", x => x.FORM_PRINT_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_INVOICE_STATUS",
                columns: table => new
                {
                    INVOICE_STATUS_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    INVOICE_STATUS_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    INVOICE_STATUS_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    INVOICE_STATUS_TYPE = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_INVOICE_STATUS", x => x.INVOICE_STATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_JOBs",
                columns: table => new
                {
                    JOB_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    JOB_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    JOB_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    JOB_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PROJ_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_JOBs", x => x.JOB_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_MAIL_TYPEs",
                columns: table => new
                {
                    MAIL_TYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETE_STATUS = table.Column<int>(nullable: true),
                    MAIL_TYPE_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: true),
                    MAIL_TYPE_SUBJECT = table.Column<string>(unicode: false, maxLength: 70, nullable: true),
                    REVISION = table.Column<int>(nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_MAIL_TYPEs", x => x.MAIL_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_MENUs",
                columns: table => new
                {
                    MENU_ID = table.Column<string>(unicode: false, maxLength: 36, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 36, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    MENU_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    MENU_GROUP = table.Column<int>(nullable: true),
                    MENU_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: true),
                    REVISION = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 36, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_MENUs", x => x.MENU_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PACKING_ITEMs",
                columns: table => new
                {
                    PACKING_ITEM_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    PACKING_ITEM_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PACKING_ITEM_DESCRIPTION = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    PACKING_ITEM_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UM_NAME_QTY1 = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    UM_NAME_QTY2 = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    UM_NAME_QTY3 = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PACKING_ITEMs", x => x.PACKING_ITEM_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PAY_IN_STATUS",
                columns: table => new
                {
                    PAY_IN_STATUS_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    PAY_IN_STATUS_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PAY_IN_STATUS", x => x.PAY_IN_STATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PAYBATCH_STATUS",
                columns: table => new
                {
                    PAYBATCH_STATUS_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    PAYBATCH_STATUS_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PAYBATCH_STATUS_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PAYBATCH_STATUS_TYPE = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PAYBATCH_STATUS", x => x.PAYBATCH_STATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PAYMENTBATCH_STATUS",
                columns: table => new
                {
                    PAYMENTBATCH_STATUS_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    PAYMENTBATCH_STATUS_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PAYMENTBATCH_STATUS_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PAYMENTBATCH_STATUS_TYPE = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PAYMENTBATCH_STATUS", x => x.PAYMENTBATCH_STATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDBRANDs",
                columns: table => new
                {
                    PDBRAND_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    PDBRAND_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PDBRAND_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    PDBRAND_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDBRANDs", x => x.PDBRAND_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDCOLORs",
                columns: table => new
                {
                    PDCOLOR_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ACTIVE_STATUS = table.Column<int>(nullable: false),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    PDCOLOR_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PDCOLOR_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PDCOLOR_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDCOLORs", x => x.PDCOLOR_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDMODELs",
                columns: table => new
                {
                    PDMODEL_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ACTIVE_STATUS = table.Column<int>(nullable: false),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    PDMODEL_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PDMODEL_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PDMODEL_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDMODELs", x => x.PDMODEL_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDSIZEs",
                columns: table => new
                {
                    PDSIZE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ACTIVE_STATUS = table.Column<int>(nullable: false),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    PDSIZE_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PDSIZE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PDSIZE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDSIZEs", x => x.PDSIZE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PRODUCTs",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    PDBRAND_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    PDCOLOR_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    PDMODEL_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    PDSIZE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    PRODUCT_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PRODUCT_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PRODUCT_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PRODUCT_SNAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PRODUCT_SNAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UM_NAME = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UM_NAME_SALES = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UMQTY_SALES = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((1))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PRODUCTs", x => x.PRODUCT_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_PROJs",
                columns: table => new
                {
                    PROJ_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    PROJ_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PROJ_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    PROJ_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PROJs", x => x.PROJ_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_REFTYPE",
                columns: table => new
                {
                    REFTYPE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REFTYPE_GROUP = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REFTYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REFTYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_REFTYPE", x => x.REFTYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_REMARK_KEYs",
                columns: table => new
                {
                    REMARK_KEY_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_REMARK_KEYs", x => x.REMARK_KEY_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_ROLEs",
                columns: table => new
                {
                    ROLE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    ROLE_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ROLE_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ROLEs", x => x.ROLE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_SALESREPs",
                columns: table => new
                {
                    SALESREP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SALESREP_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SALESREP_NAME_EN = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    SALESREP_NAME_TH = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    SALESZONE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SALESREPs", x => x.SALESREP_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_SALESZONEs",
                columns: table => new
                {
                    SALESZONE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SALESZONE_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SALESZONE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    SALESZONE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SALESZONEs", x => x.SALESZONE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_SECTs",
                columns: table => new
                {
                    SECT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    DEPT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SECT_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SECT_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    SECT_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SECTs", x => x.SECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_SENT_MAIL_CONF",
                columns: table => new
                {
                    SENT_MAIL_CONF_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETE_STATUS = table.Column<int>(nullable: true),
                    MAIL_TYPE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    REVISION = table.Column<int>(nullable: true),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SENT_MAIL_CONF", x => x.SENT_MAIL_CONF_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_SERVICE_TYPEs",
                columns: table => new
                {
                    SERVICE_TYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SERVICE_TYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    SERVICE_TYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SERVICE_TYPEs", x => x.SERVICE_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_SITEs",
                columns: table => new
                {
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SITE_DOMAIN_NAME = table.Column<string>(unicode: false, maxLength: 120, nullable: false, defaultValueSql: "((0))"),
                    SITE_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    SITE_SKIN_CSS = table.Column<string>(unicode: false, maxLength: 120, nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SITEs", x => x.SITE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_USERs",
                columns: table => new
                {
                    USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CURRENCY_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "('THB')"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    DISPLAY_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    EMAIL = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    FIREBASE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    MFA_CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    MFA_KEY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    MFA_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    ROLE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_USERs", x => x.USER_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_VATTYPE",
                columns: table => new
                {
                    VATTYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    VAT_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: true),
                    VAT_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: true),
                    VAT_RATE = table.Column<decimal>(type: "decimal(16, 4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_VATTYPE", x => x.VATTYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_WHOUSEs",
                columns: table => new
                {
                    WHOUSE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    BRANCH_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    WHOUSE_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    WHOUSE_NAME = table.Column<string>(unicode: false, maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_WHOUSEs", x => x.WHOUSE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_WHT_DELIVERY_TYPEs",
                columns: table => new
                {
                    WHT_DELIVERY_TYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    WHT_DELIVERY_TYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    WHT_DELIVERY_TYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_WHT_DELIVERY_TYPEs", x => x.WHT_DELIVERY_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_WHT_INCOME_TYPEs",
                columns: table => new
                {
                    WHT_INCOME_TYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    WHT_INCOME_TYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    WHT_INCOME_TYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    WHT_RATE = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_WHT_INCOME_TYPEs", x => x.WHT_INCOME_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_WHT_TYPEs",
                columns: table => new
                {
                    WHT_TYPE_ID = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    WHT_GROUP_TYPE = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_INCOME_TYPE_ID_1 = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_INCOME_TYPE_ID_2 = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_INCOME_TYPE_ID_3 = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_RATE_1 = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))"),
                    WHT_RATE_2 = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))"),
                    WHT_RATE_3 = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))"),
                    WHT_TYPE_NAME_EN = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    WHT_TYPE_NAME_TH = table.Column<string>(unicode: false, maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_WHT_TYPEs", x => x.WHT_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "R_ROLE_MENUs",
                columns: table => new
                {
                    ROLE_MENU_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CAN_ADD = table.Column<int>(nullable: false),
                    CAN_DELETE = table.Column<int>(nullable: false),
                    CAN_EDIT = table.Column<int>(nullable: false),
                    CAN_VIEW = table.Column<int>(nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    DELETE_STATUS = table.Column<int>(nullable: false),
                    MENU_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    REVISION = table.Column<int>(nullable: false),
                    ROLE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_ROLE_MENUs", x => x.ROLE_MENU_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ACTION_LOGs",
                columns: table => new
                {
                    ACTION_LOG_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ACTION = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETE_STATUS = table.Column<int>(nullable: true),
                    MENU_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    REVISION = table.Column<int>(nullable: true),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ACTION_LOGs", x => x.ACTION_LOG_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_CUSTOMER_UPDATE_LOGs",
                columns: table => new
                {
                    CUSTOMER_UPDATE_LOG_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETE_STATUS = table.Column<int>(nullable: true),
                    NEW_DATA = table.Column<string>(unicode: false, maxLength: 125, nullable: true),
                    OLD_DATA = table.Column<string>(unicode: false, maxLength: 125, nullable: true),
                    REVISION = table.Column<int>(nullable: true),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATE_FIELD = table.Column<string>(unicode: false, maxLength: 125, nullable: true),
                    USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CUSTOMER_UPDATE_LOGs", x => x.CUSTOMER_UPDATE_LOG_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PRINT_LOGs",
                columns: table => new
                {
                    PRINT_LOG_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    APP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    BARCODE_1 = table.Column<string>(unicode: false, maxLength: 150, nullable: false, defaultValueSql: "((0))"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    FORM_PRINT_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    MASTER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    NUMBER_OF_PRINTING = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    TOTALAMT_TEXT_EN = table.Column<string>(unicode: false, maxLength: 150, nullable: false, defaultValueSql: "((0))"),
                    TOTALAMT_TEXT_TH = table.Column<string>(unicode: false, maxLength: 150, nullable: false, defaultValueSql: "((0))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PRINT_LOGs", x => x.PRINT_LOG_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_SENT_MAIL_LOGs",
                columns: table => new
                {
                    SENT_MAIL_LOG_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETE_STATUS = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    EXPIRE_STATUS = table.Column<int>(nullable: true),
                    MAIL_TYPE_ID = table.Column<int>(nullable: true),
                    REVISION = table.Column<int>(nullable: true),
                    SENT_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SENT_MAIL_LOGs", x => x.SENT_MAIL_LOG_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_STOCK",
                columns: table => new
                {
                    STOCK_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    BRANCH_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    ITEM_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    LOT = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    QTY = table.Column<decimal>(type: "decimal(16, 4)", nullable: true),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    REVISION = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    WHOUSE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_STOCK", x => x.STOCK_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_VENDORs",
                columns: table => new
                {
                    VENDOR_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    APPROVED_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    ATTENTION_MESSAGE = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    ATTENTION_TO = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    BANK_ACCOUNT_NO = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    BANK_ACCOUNT_NO_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    BANK_BRANCH_CODE = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    BANK_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    CHARGE_TYPE_ID = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    EMAIL = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    FAX_NO = table.Column<string>(unicode: false, maxLength: 70, nullable: false, defaultValueSql: "((0))"),
                    REFER_ID_1 = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SERVICE_TYPE_ID = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    SITE_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    TAX_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "((0))"),
                    TRANSFER_LIMIT = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0.00))"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    VENDOR_CODE = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    VENDOR_NAME_EN = table.Column<string>(unicode: false, maxLength: 150, nullable: false, defaultValueSql: "((0))"),
                    VENDOR_NAME_TH = table.Column<string>(unicode: false, maxLength: 150, nullable: false, defaultValueSql: "((0))"),
                    WHT_DELIVERY_TYPE_ID = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_INCOME_TYPE_ID_1 = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_INCOME_TYPE_ID_2 = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_INCOME_TYPE_ID_3 = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    WHT_RATE_1 = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))"),
                    WHT_RATE_2 = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))"),
                    WHT_RATE_3 = table.Column<decimal>(type: "decimal(16, 4)", nullable: false, defaultValueSql: "((0))"),
                    WHT_TYPE_ID = table.Column<int>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_VENDORs", x => x.VENDOR_ID);
                    table.ForeignKey(
                        name: "FK_M_VENDORs_M_CORPs_CORP_ID",
                        column: x => x.CORP_ID,
                        principalTable: "M_CORPs",
                        principalColumn: "CORP_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_CORP_USERs",
                columns: table => new
                {
                    CORP_USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "(newid())"),
                    ACTIVE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ACTIVE_STATUS_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    CORP_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    CREATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DELETE_STATUS = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    END_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    REVISION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    START_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    UPDATE_BY = table.Column<string>(unicode: false, maxLength: 40, nullable: false, defaultValueSql: "('SYSTEM')"),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('19000101')"),
                    USER_ID = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CORP_USERs", x => x.CORP_USER_ID);
                    table.ForeignKey(
                        name: "FK_T_CORP_USERs_M_CORPs_CORP_ID",
                        column: x => x.CORP_ID,
                        principalTable: "M_CORPs",
                        principalColumn: "CORP_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_CORP_USERs_M_USERs_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "M_USERs",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_VENDORs_CORP_ID",
                table: "M_VENDORs",
                column: "CORP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CORP_USERs_CORP_ID",
                table: "T_CORP_USERs",
                column: "CORP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CORP_USERs_USER_ID",
                table: "T_CORP_USERs",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_APPs");

            migrationBuilder.DropTable(
                name: "M_BANKACCTs");

            migrationBuilder.DropTable(
                name: "M_BANKs");

            migrationBuilder.DropTable(
                name: "M_BILL_STATUS");

            migrationBuilder.DropTable(
                name: "M_BOOKs");

            migrationBuilder.DropTable(
                name: "M_BRANCHs");

            migrationBuilder.DropTable(
                name: "M_CHARGE_TYPEs");

            migrationBuilder.DropTable(
                name: "M_CIM_ROLE_TYPEs");

            migrationBuilder.DropTable(
                name: "M_CURRENCYs");

            migrationBuilder.DropTable(
                name: "M_CUSTOMERs");

            migrationBuilder.DropTable(
                name: "M_DEPTs");

            migrationBuilder.DropTable(
                name: "M_FORM_PRINTs");

            migrationBuilder.DropTable(
                name: "M_INVOICE_STATUS");

            migrationBuilder.DropTable(
                name: "M_JOBs");

            migrationBuilder.DropTable(
                name: "M_MAIL_TYPEs");

            migrationBuilder.DropTable(
                name: "M_MENUs");

            migrationBuilder.DropTable(
                name: "M_PACKING_ITEMs");

            migrationBuilder.DropTable(
                name: "M_PAY_IN_STATUS");

            migrationBuilder.DropTable(
                name: "M_PAYBATCH_STATUS");

            migrationBuilder.DropTable(
                name: "M_PAYMENTBATCH_STATUS");

            migrationBuilder.DropTable(
                name: "M_PDBRANDs");

            migrationBuilder.DropTable(
                name: "M_PDCOLORs");

            migrationBuilder.DropTable(
                name: "M_PDMODELs");

            migrationBuilder.DropTable(
                name: "M_PDSIZEs");

            migrationBuilder.DropTable(
                name: "M_PRODUCTs");

            migrationBuilder.DropTable(
                name: "M_PROJs");

            migrationBuilder.DropTable(
                name: "M_REFTYPE");

            migrationBuilder.DropTable(
                name: "M_REMARK_KEYs");

            migrationBuilder.DropTable(
                name: "M_ROLEs");

            migrationBuilder.DropTable(
                name: "M_SALESREPs");

            migrationBuilder.DropTable(
                name: "M_SALESZONEs");

            migrationBuilder.DropTable(
                name: "M_SECTs");

            migrationBuilder.DropTable(
                name: "M_SENT_MAIL_CONF");

            migrationBuilder.DropTable(
                name: "M_SERVICE_TYPEs");

            migrationBuilder.DropTable(
                name: "M_SITEs");

            migrationBuilder.DropTable(
                name: "M_VATTYPE");

            migrationBuilder.DropTable(
                name: "M_VENDORs");

            migrationBuilder.DropTable(
                name: "M_WHOUSEs");

            migrationBuilder.DropTable(
                name: "M_WHT_DELIVERY_TYPEs");

            migrationBuilder.DropTable(
                name: "M_WHT_INCOME_TYPEs");

            migrationBuilder.DropTable(
                name: "M_WHT_TYPEs");

            migrationBuilder.DropTable(
                name: "R_ROLE_MENUs");

            migrationBuilder.DropTable(
                name: "T_ACTION_LOGs");

            migrationBuilder.DropTable(
                name: "T_CORP_USERs");

            migrationBuilder.DropTable(
                name: "T_CUSTOMER_UPDATE_LOGs");

            migrationBuilder.DropTable(
                name: "T_PRINT_LOGs");

            migrationBuilder.DropTable(
                name: "T_SENT_MAIL_LOGs");

            migrationBuilder.DropTable(
                name: "T_STOCK");

            migrationBuilder.DropTable(
                name: "M_CORPs");

            migrationBuilder.DropTable(
                name: "M_USERs");
        }
    }
}
