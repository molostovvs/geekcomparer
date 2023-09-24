using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekComparer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AntutuBenchmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Cpu = table.Column<int>(type: "integer", nullable: false),
                    Gpu = table.Column<int>(type: "integer", nullable: false),
                    Mem = table.Column<int>(type: "integer", nullable: false),
                    Ux = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntutuBenchmarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autofocuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autofocuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatteryLives",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WebBrowsing = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Video = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Gaming = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Standby = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryLives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatteryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bluetooths",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bluetooths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chargings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WiredChargePower = table.Column<int>(type: "integer", nullable: false),
                    WirelessChargingSupported = table.Column<bool>(type: "boolean", nullable: false),
                    WirelessChargePower = table.Column<int>(type: "integer", nullable: false),
                    ReverseChargingSupported = table.Column<bool>(type: "boolean", nullable: false),
                    ReverseChargePower = table.Column<int>(type: "integer", nullable: false),
                    FullChargingTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    HalfChargingTime = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chargings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Codecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Tdp = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Distributions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DxOMarkBenchmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Photo = table.Column<int>(type: "integer", nullable: false),
                    Video = table.Column<int>(type: "integer", nullable: false),
                    Zoom = table.Column<int>(type: "integer", nullable: false),
                    Bokeh = table.Column<int>(type: "integer", nullable: false),
                    Preview = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DxOMarkBenchmarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FingerprintLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FingerprintLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FiveGBands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiveGBands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FourGBands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FourGBands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeekbenchBenchmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SingleCore = table.Column<int>(type: "integer", nullable: false),
                    MultiCore = table.Column<int>(type: "integer", nullable: false),
                    OpenCL = table.Column<int>(type: "integer", nullable: false),
                    Vulkan = table.Column<int>(type: "integer", nullable: false),
                    Metal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeekbenchBenchmarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    MaxClock = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HdrFormats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HdrFormats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageSensors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Format = table.Column<string>(type: "text", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageSensors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LensTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LensTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultiSimModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiSimModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavigationSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Panels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoCapabilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxWidth = table.Column<int>(type: "integer", nullable: false),
                    MaxHeight = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoCapabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Securities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HasFaceUnlock = table.Column<bool>(type: "boolean", nullable: false),
                    HasFingerprintUnlock = table.Column<bool>(type: "boolean", nullable: false),
                    HasIrisUnlock = table.Column<bool>(type: "boolean", nullable: false),
                    HasCoprocessor = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stabilizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stabilizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StorageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThreeDMarkBenchmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Performance = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreeDMarkBenchmarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThreeGBands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreeGBands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TwoGBands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TwoGBands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsbConnectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbConnectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsbFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCapabilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCapabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WiFis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WiFis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WiFiStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WiFiStandards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batteries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Replaceable = table.Column<bool>(type: "boolean", nullable: false),
                    LifeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batteries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Batteries_BatteryLives_LifeId",
                        column: x => x.LifeId,
                        principalTable: "BatteryLives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Batteries_BatteryTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "BatteryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Clock = table.Column<int>(type: "integer", nullable: false),
                    InstructionSet = table.Column<string>(type: "text", nullable: false),
                    Microarchitecture = table.Column<string>(type: "text", nullable: false),
                    LaunchDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CpuId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cores_Cpus_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoCs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    LaunchDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Litography = table.Column<int>(type: "integer", nullable: false),
                    CpuId = table.Column<Guid>(type: "uuid", nullable: false),
                    GpuId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoCs_Cpus_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoCs_Gpus_GpuId",
                        column: x => x.GpuId,
                        principalTable: "Gpus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bodies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Width = table.Column<double>(type: "double precision", nullable: false),
                    Thickness = table.Column<double>(type: "double precision", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    IpRating = table.Column<string>(type: "text", nullable: false),
                    ScreenProtection = table.Column<string>(type: "text", nullable: false),
                    FrameMaterialId = table.Column<int>(type: "integer", nullable: false),
                    BackMaterialId = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    FingerprintLocationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodies_FingerprintLocations_FingerprintLocationId",
                        column: x => x.FingerprintLocationId,
                        principalTable: "FingerprintLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodies_Materials_BackMaterialId",
                        column: x => x.BackMaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodies_Materials_FrameMaterialId",
                        column: x => x.FrameMaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cellulars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SimCount = table.Column<int>(type: "integer", nullable: false),
                    MultiSimModeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellulars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cellulars_MultiSimModes_MultiSimModeId",
                        column: x => x.MultiSimModeId,
                        principalTable: "MultiSimModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DistributionId = table.Column<int>(type: "integer", nullable: false),
                    OperatingSystemId = table.Column<int>(type: "integer", nullable: false),
                    DistributionVersion = table.Column<int>(type: "integer", nullable: false),
                    OperatingSystemVersion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Softwares_Distributions_DistributionId",
                        column: x => x.DistributionId,
                        principalTable: "Distributions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Softwares_OperatingSystems_OperatingSystemId",
                        column: x => x.OperatingSystemId,
                        principalTable: "OperatingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ScreenMatriceTechnologyId = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<double>(type: "double precision", nullable: false),
                    WidthInPixels = table.Column<int>(type: "integer", nullable: false),
                    HeightInPixels = table.Column<int>(type: "integer", nullable: false),
                    AspectRatio = table.Column<double>(type: "double precision", nullable: false),
                    MinRefreshRatio = table.Column<int>(type: "integer", nullable: false),
                    MaxRefreshRatio = table.Column<int>(type: "integer", nullable: false),
                    MaxBrightness = table.Column<int>(type: "integer", nullable: false),
                    HDRBrightness = table.Column<int>(type: "integer", nullable: false),
                    HDRSupport = table.Column<bool>(type: "boolean", nullable: false),
                    HDRFormatId = table.Column<int>(type: "integer", nullable: false),
                    HasDCDimming = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screens_HdrFormats_HDRFormatId",
                        column: x => x.HDRFormatId,
                        principalTable: "HdrFormats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Screens_Panels_ScreenMatriceTechnologyId",
                        column: x => x.ScreenMatriceTechnologyId,
                        principalTable: "Panels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Clock = table.Column<int>(type: "integer", nullable: false),
                    Channels = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rams_RamTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "RamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeakerTypeId = table.Column<int>(type: "integer", nullable: false),
                    HasHeadphoneJack = table.Column<bool>(type: "boolean", nullable: false),
                    HasFmRadio = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sounds_Speakers_SpeakerTypeId",
                        column: x => x.SpeakerTypeId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    StorageVersion = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storages_StorageTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "StorageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benchmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Geekbench5Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AntutuId = table.Column<Guid>(type: "uuid", nullable: false),
                    ThreeDMarkId = table.Column<Guid>(type: "uuid", nullable: false),
                    DxOMarkId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benchmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benchmarks_AntutuBenchmarks_AntutuId",
                        column: x => x.AntutuId,
                        principalTable: "AntutuBenchmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benchmarks_DxOMarkBenchmarks_DxOMarkId",
                        column: x => x.DxOMarkId,
                        principalTable: "DxOMarkBenchmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benchmarks_GeekbenchBenchmarks_Geekbench5Id",
                        column: x => x.Geekbench5Id,
                        principalTable: "GeekbenchBenchmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benchmarks_ThreeDMarkBenchmarks_ThreeDMarkId",
                        column: x => x.ThreeDMarkId,
                        principalTable: "ThreeDMarkBenchmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usbs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false),
                    ConnectorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usbs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usbs_UsbConnectors_ConnectorId",
                        column: x => x.ConnectorId,
                        principalTable: "UsbConnectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LensTypeId = table.Column<int>(type: "integer", nullable: false),
                    Matrix = table.Column<double>(type: "double precision", nullable: false),
                    Aperture = table.Column<double>(type: "double precision", nullable: false),
                    FocalLength = table.Column<int>(type: "integer", nullable: false),
                    PixelSize = table.Column<double>(type: "double precision", nullable: false),
                    SensorId = table.Column<Guid>(type: "uuid", nullable: false),
                    AutofocusId = table.Column<int>(type: "integer", nullable: false),
                    ImageStabilizationId = table.Column<int>(type: "integer", nullable: false),
                    HasOpticalZoom = table.Column<bool>(type: "boolean", nullable: false),
                    OpticalZoomValue = table.Column<int>(type: "integer", nullable: false),
                    DigitalZoomValue = table.Column<int>(type: "integer", nullable: false),
                    PhotoCapabilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoCapabilitiesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cameras_Autofocuses_AutofocusId",
                        column: x => x.AutofocusId,
                        principalTable: "Autofocuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cameras_ImageSensors_SensorId",
                        column: x => x.SensorId,
                        principalTable: "ImageSensors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cameras_LensTypes_LensTypeId",
                        column: x => x.LensTypeId,
                        principalTable: "LensTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cameras_PhotoCapabilities_PhotoCapabilitiesId",
                        column: x => x.PhotoCapabilitiesId,
                        principalTable: "PhotoCapabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cameras_Stabilizations_ImageStabilizationId",
                        column: x => x.ImageStabilizationId,
                        principalTable: "Stabilizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cameras_VideoCapabilities_VideoCapabilitiesId",
                        column: x => x.VideoCapabilitiesId,
                        principalTable: "VideoCapabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoModes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Resolution = table.Column<string>(type: "text", nullable: false),
                    FrameRate = table.Column<int>(type: "integer", nullable: false),
                    VideoCapabilitiesId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoModes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoModes_VideoCapabilities_VideoCapabilitiesId",
                        column: x => x.VideoCapabilitiesId,
                        principalTable: "VideoCapabilities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WiFiWiFiStandard",
                columns: table => new
                {
                    StandardsId = table.Column<int>(type: "integer", nullable: false),
                    WiFiId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WiFiWiFiStandard", x => new { x.StandardsId, x.WiFiId });
                    table.ForeignKey(
                        name: "FK_WiFiWiFiStandard_WiFiStandards_StandardsId",
                        column: x => x.StandardsId,
                        principalTable: "WiFiStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WiFiWiFiStandard_WiFis_WiFiId",
                        column: x => x.WiFiId,
                        principalTable: "WiFis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellularFiveGBand",
                columns: table => new
                {
                    Bands5GId = table.Column<int>(type: "integer", nullable: false),
                    CellularId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellularFiveGBand", x => new { x.Bands5GId, x.CellularId });
                    table.ForeignKey(
                        name: "FK_CellularFiveGBand_Cellulars_CellularId",
                        column: x => x.CellularId,
                        principalTable: "Cellulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellularFiveGBand_FiveGBands_Bands5GId",
                        column: x => x.Bands5GId,
                        principalTable: "FiveGBands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellularFourGBand",
                columns: table => new
                {
                    Bands4GId = table.Column<int>(type: "integer", nullable: false),
                    CellularId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellularFourGBand", x => new { x.Bands4GId, x.CellularId });
                    table.ForeignKey(
                        name: "FK_CellularFourGBand_Cellulars_CellularId",
                        column: x => x.CellularId,
                        principalTable: "Cellulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellularFourGBand_FourGBands_Bands4GId",
                        column: x => x.Bands4GId,
                        principalTable: "FourGBands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellularSimFormat",
                columns: table => new
                {
                    CellularId = table.Column<Guid>(type: "uuid", nullable: false),
                    SimTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellularSimFormat", x => new { x.CellularId, x.SimTypeId });
                    table.ForeignKey(
                        name: "FK_CellularSimFormat_Cellulars_CellularId",
                        column: x => x.CellularId,
                        principalTable: "Cellulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellularSimFormat_SimTypes_SimTypeId",
                        column: x => x.SimTypeId,
                        principalTable: "SimTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellularThreeGBand",
                columns: table => new
                {
                    Bands3GId = table.Column<int>(type: "integer", nullable: false),
                    CellularId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellularThreeGBand", x => new { x.Bands3GId, x.CellularId });
                    table.ForeignKey(
                        name: "FK_CellularThreeGBand_Cellulars_CellularId",
                        column: x => x.CellularId,
                        principalTable: "Cellulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellularThreeGBand_ThreeGBands_Bands3GId",
                        column: x => x.Bands3GId,
                        principalTable: "ThreeGBands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellularTwoGBand",
                columns: table => new
                {
                    Bands2GId = table.Column<int>(type: "integer", nullable: false),
                    CellularId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellularTwoGBand", x => new { x.Bands2GId, x.CellularId });
                    table.ForeignKey(
                        name: "FK_CellularTwoGBand_Cellulars_CellularId",
                        column: x => x.CellularId,
                        principalTable: "Cellulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellularTwoGBand_TwoGBands_Bands2GId",
                        column: x => x.Bands2GId,
                        principalTable: "TwoGBands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AudioCodecSound",
                columns: table => new
                {
                    CodecsId = table.Column<int>(type: "integer", nullable: false),
                    SoundId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioCodecSound", x => new { x.CodecsId, x.SoundId });
                    table.ForeignKey(
                        name: "FK_AudioCodecSound_Codecs_CodecsId",
                        column: x => x.CodecsId,
                        principalTable: "Codecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AudioCodecSound_Sounds_SoundId",
                        column: x => x.SoundId,
                        principalTable: "Sounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RamId = table.Column<Guid>(type: "uuid", nullable: false),
                    StorageId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemoryCardSupported = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memories_Rams_RamId",
                        column: x => x.RamId,
                        principalTable: "Rams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memories_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Connectivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CellularId = table.Column<Guid>(type: "uuid", nullable: false),
                    WiFiId = table.Column<Guid>(type: "uuid", nullable: false),
                    BluetoothId = table.Column<Guid>(type: "uuid", nullable: false),
                    USBId = table.Column<Guid>(type: "uuid", nullable: false),
                    HasNFC = table.Column<bool>(type: "boolean", nullable: false),
                    HasIR = table.Column<bool>(type: "boolean", nullable: false),
                    HasUWB = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connectivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Connectivities_Bluetooths_BluetoothId",
                        column: x => x.BluetoothId,
                        principalTable: "Bluetooths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Connectivities_Cellulars_CellularId",
                        column: x => x.CellularId,
                        principalTable: "Cellulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Connectivities_Usbs_USBId",
                        column: x => x.USBId,
                        principalTable: "Usbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Connectivities_WiFis_WiFiId",
                        column: x => x.WiFiId,
                        principalTable: "WiFis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsbUsbFeature",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "integer", nullable: false),
                    UsbId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbUsbFeature", x => new { x.FeaturesId, x.UsbId });
                    table.ForeignKey(
                        name: "FK_UsbUsbFeature_UsbFeatures_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "UsbFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsbUsbFeature_Usbs_UsbId",
                        column: x => x.UsbId,
                        principalTable: "Usbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConnectivityNavigationSystem",
                columns: table => new
                {
                    ConnectivityId = table.Column<Guid>(type: "uuid", nullable: false),
                    NavigationSystemsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectivityNavigationSystem", x => new { x.ConnectivityId, x.NavigationSystemsId });
                    table.ForeignKey(
                        name: "FK_ConnectivityNavigationSystem_Connectivities_ConnectivityId",
                        column: x => x.ConnectivityId,
                        principalTable: "Connectivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectivityNavigationSystem_NavigationSystems_NavigationSy~",
                        column: x => x.NavigationSystemsId,
                        principalTable: "NavigationSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Smartphones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    AnnounceDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BatteryId = table.Column<Guid>(type: "uuid", nullable: false),
                    BenchmarkId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConnectivityId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ScreenId = table.Column<Guid>(type: "uuid", nullable: false),
                    SecurityId = table.Column<Guid>(type: "uuid", nullable: false),
                    SoCId = table.Column<Guid>(type: "uuid", nullable: false),
                    SoftwareId = table.Column<Guid>(type: "uuid", nullable: false),
                    SoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarketSegmentId = table.Column<int>(type: "integer", nullable: false),
                    ChargingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smartphones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Smartphones_Batteries_BatteryId",
                        column: x => x.BatteryId,
                        principalTable: "Batteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Benchmarks_BenchmarkId",
                        column: x => x.BenchmarkId,
                        principalTable: "Benchmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Bodies_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Bodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Categories_MarketSegmentId",
                        column: x => x.MarketSegmentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Chargings_ChargingId",
                        column: x => x.ChargingId,
                        principalTable: "Chargings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Connectivities_ConnectivityId",
                        column: x => x.ConnectivityId,
                        principalTable: "Connectivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Screens_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_SoCs_SoCId",
                        column: x => x.SoCId,
                        principalTable: "SoCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Softwares_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Sounds_SoundId",
                        column: x => x.SoundId,
                        principalTable: "Sounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CameraSmartphone",
                columns: table => new
                {
                    CamerasId = table.Column<Guid>(type: "uuid", nullable: false),
                    SmartphoneId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraSmartphone", x => new { x.CamerasId, x.SmartphoneId });
                    table.ForeignKey(
                        name: "FK_CameraSmartphone_Cameras_CamerasId",
                        column: x => x.CamerasId,
                        principalTable: "Cameras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CameraSmartphone_Smartphones_SmartphoneId",
                        column: x => x.SmartphoneId,
                        principalTable: "Smartphones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SensorSmartphone",
                columns: table => new
                {
                    SensorsId = table.Column<int>(type: "integer", nullable: false),
                    SmartphoneId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorSmartphone", x => new { x.SensorsId, x.SmartphoneId });
                    table.ForeignKey(
                        name: "FK_SensorSmartphone_Sensors_SensorsId",
                        column: x => x.SensorsId,
                        principalTable: "Sensors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SensorSmartphone_Smartphones_SmartphoneId",
                        column: x => x.SmartphoneId,
                        principalTable: "Smartphones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Autofocuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Laser" },
                    { 2, "Phase" },
                    { 3, "Contrast" }
                });

            migrationBuilder.InsertData(
                table: "BatteryTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "LiPo" },
                    { 2, "LiIon" },
                    { 3, "NiCd" },
                    { 4, "NiMH" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Flagship" },
                    { 2, "Mid" },
                    { 3, "Budget" }
                });

            migrationBuilder.InsertData(
                table: "Codecs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SBC" },
                    { 2, "aptX" },
                    { 3, "aptX_HD" },
                    { 4, "LDAC" },
                    { 5, "LHDC" },
                    { 6, "LLAC" }
                });

            migrationBuilder.InsertData(
                table: "Distributions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "MIUI" },
                    { 2, "FunTouch" },
                    { 3, "EMUI" },
                    { 4, "FireOS" }
                });

            migrationBuilder.InsertData(
                table: "FingerprintLocations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Screen" },
                    { 2, "Button" },
                    { 3, "Side" },
                    { 4, "Back" }
                });

            migrationBuilder.InsertData(
                table: "FiveGBands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "n1" },
                    { 2, "n2" },
                    { 3, "n3" },
                    { 5, "n5" },
                    { 7, "n7" },
                    { 8, "n8" },
                    { 12, "n12" },
                    { 13, "n13" },
                    { 14, "n14" },
                    { 18, "n18" },
                    { 20, "n20" },
                    { 24, "n24" },
                    { 25, "n25" },
                    { 26, "n26" },
                    { 28, "n28" },
                    { 29, "n29" },
                    { 30, "n30" },
                    { 34, "n34" },
                    { 38, "n38" },
                    { 39, "n39" },
                    { 40, "n40" },
                    { 41, "n41" },
                    { 46, "n46" },
                    { 47, "n47" },
                    { 48, "n48" },
                    { 50, "n50" },
                    { 51, "n51" },
                    { 53, "n53" },
                    { 54, "n54" },
                    { 65, "n65" },
                    { 66, "n66" },
                    { 67, "n67" },
                    { 70, "n70" },
                    { 71, "n71" },
                    { 74, "n74" },
                    { 75, "n75" },
                    { 76, "n76" },
                    { 77, "n77" },
                    { 78, "n78" },
                    { 79, "n79" },
                    { 80, "n80" },
                    { 81, "n81" },
                    { 82, "n82" },
                    { 83, "n83" },
                    { 84, "n84" },
                    { 85, "n85" },
                    { 86, "n86" },
                    { 89, "n89" },
                    { 90, "n90" },
                    { 91, "n91" },
                    { 92, "n92" },
                    { 93, "n93" },
                    { 94, "n94" },
                    { 95, "n95" },
                    { 96, "n96" },
                    { 97, "n97" },
                    { 98, "n98" },
                    { 99, "n99" },
                    { 100, "n100" },
                    { 101, "n101" },
                    { 102, "n102" },
                    { 104, "n104" },
                    { 105, "n105" }
                });

            migrationBuilder.InsertData(
                table: "FourGBands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, "Five" },
                    { 7, "Seven" },
                    { 8, "Eight" },
                    { 11, "Eleven" },
                    { 12, "Twelve" },
                    { 13, "Thirteen" },
                    { 14, "Fourteen" },
                    { 17, "Seventeen" },
                    { 18, "Eighteen" },
                    { 19, "Nineteen" },
                    { 20, "Twenty" },
                    { 21, "TwentyOne" },
                    { 24, "TwentyFour" },
                    { 25, "TwentyFive" },
                    { 26, "TwentySix" },
                    { 28, "TwentyEight" },
                    { 29, "TwentyNine" },
                    { 30, "Thirty" },
                    { 31, "ThirtyOne" },
                    { 32, "ThirtyTwo" },
                    { 34, "ThirtyFour" },
                    { 37, "ThirtySeven" },
                    { 38, "ThirtyEight" },
                    { 39, "ThirtyNine" },
                    { 40, "Forty" },
                    { 41, "FortyOne" },
                    { 42, "FortyTwo" },
                    { 43, "FortyThree" },
                    { 46, "FortySix" },
                    { 47, "FortySeven" },
                    { 48, "FortyEight" },
                    { 50, "Fifty" },
                    { 51, "FiftyOne" },
                    { 53, "FiftyThree" },
                    { 54, "FiftyFour" },
                    { 65, "SixtyFive" },
                    { 66, "SixtySix" },
                    { 67, "SixtySeven" },
                    { 69, "SixtyNine" },
                    { 70, "Seventy" },
                    { 71, "SeventyOne" },
                    { 72, "SeventyTwo" },
                    { 73, "SeventyThree" },
                    { 74, "SeventyFour" },
                    { 75, "SeventyFive" },
                    { 76, "SeventySix" },
                    { 85, "EightyFive" },
                    { 87, "EightySeven" },
                    { 88, "EightyEight" },
                    { 103, "OneHundredThree" },
                    { 106, "OneHundredSix" }
                });

            migrationBuilder.InsertData(
                table: "HdrFormats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HDR10" },
                    { 2, "DolbyVision" },
                    { 3, "HDR10Plus" },
                    { 4, "HLG" }
                });

            migrationBuilder.InsertData(
                table: "LensTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 2, "Wide" },
                    { 3, "UltraWide" },
                    { 4, "Telephoto" },
                    { 5, "Depth" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Metal" },
                    { 2, "Glass" },
                    { 3, "Plastic" },
                    { 4, "Carbon" },
                    { 5, "Ceramic" }
                });

            migrationBuilder.InsertData(
                table: "MultiSimModes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Standby" },
                    { 2, "Active" }
                });

            migrationBuilder.InsertData(
                table: "NavigationSystems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "GPS" },
                    { 2, "GLONASS" },
                    { 3, "Beidou" },
                    { 4, "Galileo" },
                    { 5, "QZSS" },
                    { 6, "NAVIC" }
                });

            migrationBuilder.InsertData(
                table: "OperatingSystems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Android" },
                    { 2, "iOS" },
                    { 3, "Linux" },
                    { 4, "WindowsPhone" },
                    { 5, "HarmonyOS" },
                    { 6, "Symbian" }
                });

            migrationBuilder.InsertData(
                table: "Panels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IPS" },
                    { 2, "OLED" },
                    { 3, "EInk" }
                });

            migrationBuilder.InsertData(
                table: "RamTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "LPDDR1" },
                    { 2, "LPDDR2" },
                    { 3, "LPDDR3" },
                    { 4, "LPDDR3E" },
                    { 5, "LPDDR4" },
                    { 6, "LPDDR4X" },
                    { 7, "LPDDR5" },
                    { 8, "LPDDR5X" },
                    { 9, "LPDDR5T" }
                });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Barometer" },
                    { 2, "Proximity" },
                    { 3, "Gyroscope" },
                    { 4, "Accelerometer" },
                    { 5, "Photo" },
                    { 6, "Magnetometer" },
                    { 7, "LIDAR" }
                });

            migrationBuilder.InsertData(
                table: "SimTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Standard" },
                    { 2, "Mini" },
                    { 3, "Micro" },
                    { 4, "Nano" },
                    { 5, "Embedded" },
                    { 6, "Integrated" }
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mono" },
                    { 2, "Stereo" }
                });

            migrationBuilder.InsertData(
                table: "Stabilizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Optical" },
                    { 2, "Digital" }
                });

            migrationBuilder.InsertData(
                table: "StorageTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "UFS" },
                    { 2, "eMMC" },
                    { 3, "Unspecified" }
                });

            migrationBuilder.InsertData(
                table: "ThreeGBands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, "Five" },
                    { 6, "Six" },
                    { 7, "Seven" },
                    { 8, "Eight" },
                    { 9, "Nine" },
                    { 10, "Ten" },
                    { 11, "Eleven" },
                    { 12, "Twelve" },
                    { 13, "Thirteen" },
                    { 14, "Fourteen" },
                    { 19, "Nineteen" },
                    { 20, "Twenty" },
                    { 21, "TwentyOne" },
                    { 22, "TwentyTwo" },
                    { 25, "TwentyFive" },
                    { 26, "TwentySix" },
                    { 32, "ThirtyTwo" },
                    { 101, "A" },
                    { 102, "B" },
                    { 103, "C" },
                    { 104, "D" },
                    { 105, "E" },
                    { 106, "F" }
                });

            migrationBuilder.InsertData(
                table: "TwoGBands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TGSM380" },
                    { 2, "TGSM410" },
                    { 3, "GSM450" },
                    { 4, "GSM480" },
                    { 5, "GSM710" },
                    { 6, "GSM750" },
                    { 7, "TGSM810" },
                    { 8, "GSM850" },
                    { 9, "EGSM900" },
                    { 10, "RGSM900" },
                    { 11, "TGSM900" },
                    { 12, "DCS1800" },
                    { 13, "PCS1900" }
                });

            migrationBuilder.InsertData(
                table: "UsbConnectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "C" },
                    { 2, "Micro" },
                    { 3, "Lightning" }
                });

            migrationBuilder.InsertData(
                table: "UsbFeatures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Charging" },
                    { 2, "OTG" },
                    { 3, "StorageMode" }
                });

            migrationBuilder.InsertData(
                table: "WiFiStandards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "b" },
                    { 2, "a" },
                    { 3, "g" },
                    { 4, "n" },
                    { 5, "ac" },
                    { 6, "ax" },
                    { 7, "be" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AudioCodecSound_SoundId",
                table: "AudioCodecSound",
                column: "SoundId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_LifeId",
                table: "Batteries",
                column: "LifeId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_TypeId",
                table: "Batteries",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Benchmarks_AntutuId",
                table: "Benchmarks",
                column: "AntutuId");

            migrationBuilder.CreateIndex(
                name: "IX_Benchmarks_DxOMarkId",
                table: "Benchmarks",
                column: "DxOMarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Benchmarks_Geekbench5Id",
                table: "Benchmarks",
                column: "Geekbench5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Benchmarks_ThreeDMarkId",
                table: "Benchmarks",
                column: "ThreeDMarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodies_BackMaterialId",
                table: "Bodies",
                column: "BackMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodies_FingerprintLocationId",
                table: "Bodies",
                column: "FingerprintLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodies_FrameMaterialId",
                table: "Bodies",
                column: "FrameMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_AutofocusId",
                table: "Cameras",
                column: "AutofocusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_ImageStabilizationId",
                table: "Cameras",
                column: "ImageStabilizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_LensTypeId",
                table: "Cameras",
                column: "LensTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_PhotoCapabilitiesId",
                table: "Cameras",
                column: "PhotoCapabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_SensorId",
                table: "Cameras",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_VideoCapabilitiesId",
                table: "Cameras",
                column: "VideoCapabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CameraSmartphone_SmartphoneId",
                table: "CameraSmartphone",
                column: "SmartphoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CellularFiveGBand_CellularId",
                table: "CellularFiveGBand",
                column: "CellularId");

            migrationBuilder.CreateIndex(
                name: "IX_CellularFourGBand_CellularId",
                table: "CellularFourGBand",
                column: "CellularId");

            migrationBuilder.CreateIndex(
                name: "IX_Cellulars_MultiSimModeId",
                table: "Cellulars",
                column: "MultiSimModeId");

            migrationBuilder.CreateIndex(
                name: "IX_CellularSimFormat_SimTypeId",
                table: "CellularSimFormat",
                column: "SimTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CellularThreeGBand_CellularId",
                table: "CellularThreeGBand",
                column: "CellularId");

            migrationBuilder.CreateIndex(
                name: "IX_CellularTwoGBand_CellularId",
                table: "CellularTwoGBand",
                column: "CellularId");

            migrationBuilder.CreateIndex(
                name: "IX_Connectivities_BluetoothId",
                table: "Connectivities",
                column: "BluetoothId");

            migrationBuilder.CreateIndex(
                name: "IX_Connectivities_CellularId",
                table: "Connectivities",
                column: "CellularId");

            migrationBuilder.CreateIndex(
                name: "IX_Connectivities_USBId",
                table: "Connectivities",
                column: "USBId");

            migrationBuilder.CreateIndex(
                name: "IX_Connectivities_WiFiId",
                table: "Connectivities",
                column: "WiFiId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectivityNavigationSystem_NavigationSystemsId",
                table: "ConnectivityNavigationSystem",
                column: "NavigationSystemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cores_CpuId",
                table: "Cores",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Memories_RamId",
                table: "Memories",
                column: "RamId");

            migrationBuilder.CreateIndex(
                name: "IX_Memories_StorageId",
                table: "Memories",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_TypeId",
                table: "Rams",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Screens_HDRFormatId",
                table: "Screens",
                column: "HDRFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Screens_ScreenMatriceTechnologyId",
                table: "Screens",
                column: "ScreenMatriceTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorSmartphone_SmartphoneId",
                table: "SensorSmartphone",
                column: "SmartphoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_BatteryId",
                table: "Smartphones",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_BenchmarkId",
                table: "Smartphones",
                column: "BenchmarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_BodyId",
                table: "Smartphones",
                column: "BodyId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_Brand",
                table: "Smartphones",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_ChargingId",
                table: "Smartphones",
                column: "ChargingId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_ConnectivityId",
                table: "Smartphones",
                column: "ConnectivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_Manufacturer",
                table: "Smartphones",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_MarketSegmentId",
                table: "Smartphones",
                column: "MarketSegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_MemoryId",
                table: "Smartphones",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_Model",
                table: "Smartphones",
                column: "Model");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_ScreenId",
                table: "Smartphones",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_SecurityId",
                table: "Smartphones",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_SoCId",
                table: "Smartphones",
                column: "SoCId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_SoftwareId",
                table: "Smartphones",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_SoundId",
                table: "Smartphones",
                column: "SoundId");

            migrationBuilder.CreateIndex(
                name: "IX_SoCs_CpuId",
                table: "SoCs",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_SoCs_GpuId",
                table: "SoCs",
                column: "GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_DistributionId",
                table: "Softwares",
                column: "DistributionId");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_OperatingSystemId",
                table: "Softwares",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Sounds_SpeakerTypeId",
                table: "Sounds",
                column: "SpeakerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_TypeId",
                table: "Storages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Usbs_ConnectorId",
                table: "Usbs",
                column: "ConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_UsbUsbFeature_UsbId",
                table: "UsbUsbFeature",
                column: "UsbId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoModes_VideoCapabilitiesId",
                table: "VideoModes",
                column: "VideoCapabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_WiFiWiFiStandard_WiFiId",
                table: "WiFiWiFiStandard",
                column: "WiFiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AudioCodecSound");

            migrationBuilder.DropTable(
                name: "CameraSmartphone");

            migrationBuilder.DropTable(
                name: "CellularFiveGBand");

            migrationBuilder.DropTable(
                name: "CellularFourGBand");

            migrationBuilder.DropTable(
                name: "CellularSimFormat");

            migrationBuilder.DropTable(
                name: "CellularThreeGBand");

            migrationBuilder.DropTable(
                name: "CellularTwoGBand");

            migrationBuilder.DropTable(
                name: "ConnectivityNavigationSystem");

            migrationBuilder.DropTable(
                name: "Cores");

            migrationBuilder.DropTable(
                name: "SensorSmartphone");

            migrationBuilder.DropTable(
                name: "UsbUsbFeature");

            migrationBuilder.DropTable(
                name: "VideoModes");

            migrationBuilder.DropTable(
                name: "WiFiWiFiStandard");

            migrationBuilder.DropTable(
                name: "Codecs");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "FiveGBands");

            migrationBuilder.DropTable(
                name: "FourGBands");

            migrationBuilder.DropTable(
                name: "SimTypes");

            migrationBuilder.DropTable(
                name: "ThreeGBands");

            migrationBuilder.DropTable(
                name: "TwoGBands");

            migrationBuilder.DropTable(
                name: "NavigationSystems");

            migrationBuilder.DropTable(
                name: "Sensors");

            migrationBuilder.DropTable(
                name: "Smartphones");

            migrationBuilder.DropTable(
                name: "UsbFeatures");

            migrationBuilder.DropTable(
                name: "WiFiStandards");

            migrationBuilder.DropTable(
                name: "Autofocuses");

            migrationBuilder.DropTable(
                name: "ImageSensors");

            migrationBuilder.DropTable(
                name: "LensTypes");

            migrationBuilder.DropTable(
                name: "PhotoCapabilities");

            migrationBuilder.DropTable(
                name: "Stabilizations");

            migrationBuilder.DropTable(
                name: "VideoCapabilities");

            migrationBuilder.DropTable(
                name: "Batteries");

            migrationBuilder.DropTable(
                name: "Benchmarks");

            migrationBuilder.DropTable(
                name: "Bodies");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Chargings");

            migrationBuilder.DropTable(
                name: "Connectivities");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropTable(
                name: "Securities");

            migrationBuilder.DropTable(
                name: "SoCs");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "Sounds");

            migrationBuilder.DropTable(
                name: "BatteryLives");

            migrationBuilder.DropTable(
                name: "BatteryTypes");

            migrationBuilder.DropTable(
                name: "AntutuBenchmarks");

            migrationBuilder.DropTable(
                name: "DxOMarkBenchmarks");

            migrationBuilder.DropTable(
                name: "GeekbenchBenchmarks");

            migrationBuilder.DropTable(
                name: "ThreeDMarkBenchmarks");

            migrationBuilder.DropTable(
                name: "FingerprintLocations");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Bluetooths");

            migrationBuilder.DropTable(
                name: "Cellulars");

            migrationBuilder.DropTable(
                name: "Usbs");

            migrationBuilder.DropTable(
                name: "WiFis");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "HdrFormats");

            migrationBuilder.DropTable(
                name: "Panels");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "Distributions");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "MultiSimModes");

            migrationBuilder.DropTable(
                name: "UsbConnectors");

            migrationBuilder.DropTable(
                name: "RamTypes");

            migrationBuilder.DropTable(
                name: "StorageTypes");
        }
    }
}
