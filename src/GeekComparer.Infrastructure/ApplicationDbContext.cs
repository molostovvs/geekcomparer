using CSharpFunctionalExtensions;
using GeekComparer.Domain.Enums;
using GeekComparer.Domain.ValueObjects;
using GeekComparer.Infrastructure.Converters;

namespace GeekComparer.Infrastructure;

public sealed class ApplicationDbContext : DbContext
{
#pragma warning disable CS8618
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618
    {
        // Database.EnsureDeleted();
        // Database.Migrate();
    }

    public DbSet<Benchmark> Benchmarks { get; set; }
    public DbSet<AntutuBenchmark> AntutuBenchmarks { get; set; }
    public DbSet<GeekbenchBenchmark> GeekbenchBenchmarks { get; set; }
    public DbSet<ThreeDMarkBenchmark> ThreeDMarkBenchmarks { get; set; }
    public DbSet<DxOMarkBenchmark> DxOMarkBenchmarks { get; set; }
    public DbSet<BatteryLife> BatteryLives { get; set; }
    public DbSet<Battery> Batteries { get; set; }
    public DbSet<Body> Bodies { get; set; }
    public DbSet<Camera> Cameras { get; set; }
    public DbSet<ImageSensor> ImageSensors { get; set; }
    public DbSet<PhotoCapabilities> PhotoCapabilities { get; set; }
    public DbSet<VideoCapabilities> VideoCapabilities { get; set; }
    public DbSet<VideoMode> VideoModes { get; set; }
    public DbSet<Connectivity> Connectivities { get; set; }
    public DbSet<Cellular> Cellulars { get; set; }
    public DbSet<WiFi> WiFis { get; set; }
    public DbSet<Bluetooth> Bluetooths { get; set; }
    public DbSet<Usb> Usbs { get; set; }
    public DbSet<Memory> Memories { get; set; }
    public DbSet<Ram> Rams { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Screen> Screens { get; set; }
    public DbSet<Security> Securities { get; set; }
    public DbSet<SoC> SoCs { get; set; }
    public DbSet<Gpu> Gpus { get; set; }
    public DbSet<Cpu> Cpus { get; set; }
    public DbSet<Core> Cores { get; set; }
    public DbSet<Software> Softwares { get; set; }
    public DbSet<Sound> Sounds { get; set; }
    public DbSet<Smartphone> Smartphones { get; set; }
    public DbSet<Charging> Chargings { get; set; }
    public DbSet<TwoGBand> TwoGBands { get; set; }
    public DbSet<ThreeGBand> ThreeGBands { get; set; }
    public DbSet<FourGBand> FourGBands { get; set; }
    public DbSet<FiveGBand> FiveGBands { get; set; }
    public DbSet<MarketSegment> Categories { get; set; }
    public DbSet<MultiSimMode> MultiSimModes { get; set; }
    public DbSet<SimFormat> SimTypes { get; set; }
    public DbSet<NavigationSystem> NavigationSystems { get; set; }
    public DbSet<UsbFeature> UsbFeatures { get; set; }
    public DbSet<UsbConnector> UsbConnectors { get; set; }
    public DbSet<WiFiStandard> WiFiStandards { get; set; }
    public DbSet<AudioCodec> Codecs { get; set; }
    public DbSet<SpeakerType> Speakers { get; set; }
    public DbSet<Domain.OperatingSystem> OperatingSystems { get; set; }
    public DbSet<Distribution> Distributions { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<HdrFormat> HdrFormats { get; set; }
    public DbSet<ScreenMatriceTechnology> Panels { get; set; }
    public DbSet<RamType> RamTypes { get; set; }
    public DbSet<StorageType> StorageTypes { get; set; }
    public DbSet<LensType> LensTypes { get; set; }
    public DbSet<ImageStabilization> Stabilizations { get; set; }
    public DbSet<Autofocus> Autofocuses { get; set; }
    public DbSet<FingerprintLocation> FingerprintLocations { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<BatteryType> BatteryTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedEnums();
        modelBuilder.AddIdsToValueObjects();
        modelBuilder.ConfigureManyToMany();
        modelBuilder.ConfigureAutoIncludes();

        modelBuilder.Entity<Smartphone>().HasIndex(s => s.Manufacturer);
        modelBuilder.Entity<Smartphone>().HasIndex(s => s.Brand);
        modelBuilder.Entity<Smartphone>().HasIndex(s => s.Model);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configBuilder)
    {
        configBuilder.Properties<Maybe<TimeSpan>>().HaveConversion<MaybeConverter<TimeSpan>>();
        configBuilder.Properties<Maybe<int>>().HaveConversion<MaybeConverter<int>>();
    }

    public void Seed()
    {
        var fastCore = new Core
        {
            Clock = 3000,
            InstructionSet = "ARMv8.2-a",
            Microarchitecture = "Cortex-A78",
            LaunchDate = new DateOnly(2021, 9, 1),
        };

        var midCore = new Core
        {
            Clock = 2600,
            InstructionSet = "ARMv8.2-A",
            Microarchitecture = "Cortex-A78",
            LaunchDate = new DateOnly(2021, 9, 1),
        };

        var slowCore = new Core
        {
            Clock = 2000,
            InstructionSet = "ARMv8.2-A",
            Microarchitecture = "Cortex-A55",
            LaunchDate = new DateOnly(2021, 9, 1),
        };

        var cores = new List<Core>();
        cores.Add(fastCore);
        for (int i = 0; i < 3; i++)
        {
            var mid = new Core()
            {
                Clock = midCore.Clock,
                InstructionSet = midCore.InstructionSet,
                LaunchDate = midCore.LaunchDate,
                Microarchitecture = midCore.Microarchitecture,
            };
            cores.Add(mid);
        }

        for (int i = 0; i < 4; i++)
        {
            var slow = new Core()
            {
                Clock = slowCore.Clock,
                InstructionSet = slowCore.InstructionSet,
                LaunchDate = slowCore.LaunchDate,
                Microarchitecture = slowCore.Microarchitecture,
            };
            cores.Add(slow);
        }

        var cpu = new Cpu
        {
            Cores = cores,
            Tdp = 5,
        };

        var gpu = new Gpu
        {
            Model = "SomeGPU 666",
        };

        var soc = new SoC
        {
            Cpu = cpu,
            Gpu = gpu,
            LaunchDate = new DateOnly(2023, 9, 9),
            Litography = 5,
            Manufacturer = "MediaTek",
            Model = "Dimensity 8200",
        };

        var sound = new Sound
        {
            Codecs = Codecs.Where(c => c.Id == AudioCodec.aptX.Id).ToList(),
            SpeakerType = Speakers.First(s => s.Id == SpeakerType.Stereo.Id),
            HasFmRadio = false,
            HasHeadphoneJack = false,
        };

        var software = new Software
        {
            Distribution = Distributions.First(d => d.Id == Distribution.EMUI.Id),
            DistributionVersion = 5,
            OperatingSystem = OperatingSystems.First(
                os => os.Id
                    == Domain.OperatingSystem.Android
                       .Id
            ),
            OperatingSystemVersion = 13,
        };

        var security = new Security
        {
            HasFaceUnlock = true,
            HasFingerprintUnlock = true,
            HasIrisUnlock = false,
            HasCoprocessor = false,
        };

        var screen = new Screen
        {
            AspectRatio = 19.3 / 9,
            HasDCDimming = true,
            HDRBrightness = 6666,
            HDRFormat = HdrFormats.First(h => h.Id == HdrFormat.HDR10Plus.Id),
            HDRSupport = true,
            HeightInPixels = 3088,
            MaxBrightness = 1200,
            MaxRefreshRatio = 144,
            MinRefreshRatio = 1,
            ScreenMatriceTechnology = Panels.First(p => p.Id == ScreenMatriceTechnology.OLED.Id),
            WidthInPixels = 1440,
            Size = 6.8,
        };

        var memory = new Memory
        {
            MemoryCardSupported = false,
            Ram = new Ram
            {
                Channels = 4,
                Clock = 2400,
                Size = 8,
                Type = RamTypes.First(r => r.Id == RamType.LPDDR5X.Id),
            },
            Storage = new Storage
            {
                Size = 512,
                StorageVersion = 3,
                Type = StorageTypes.First(st => st.Id == StorageType.UFS.Id),
            },
        };

        var cellular = new Cellular
        {
            Bands2G = TwoGBands.Where(
                    b => b.Id == TwoGBand.TGSM380.Id || b.Id == TwoGBand.TGSM410.Id
                )
               .ToList(),
            Bands3G = ThreeGBands
               .Where(b => b.Id == ThreeGBand.Two.Id || b.Id == ThreeGBand.Twelve.Id)
               .ToList(),
            Bands4G = FourGBands.Where(
                    b => new List<FourGBand>()
                    {
                        FourGBand.TwentyEight,
                        FourGBand.TwentySix,
                        FourGBand.Fifty,
                        FourGBand.One,
                        FourGBand.Eight,
                        FourGBand.EightyFive,
                    }.Contains(b)
                )
               .ToList(),
            Bands5G = FiveGBands.Where(
                    b => new List<FiveGBand>()
                    {
                        FiveGBand.n1,
                        FiveGBand.n2,
                        FiveGBand.n3,
                        FiveGBand.n5,
                        FiveGBand.n7,
                        FiveGBand.n8,
                        FiveGBand.n12,
                        FiveGBand.n18,
                    }.Contains(b)
                )
               .ToList(),
            MultiSimMode = MultiSimModes.First(m => m == MultiSimMode.Standby),
            SimType = SimTypes.Where(
                    s => new List<SimFormat>()
                    {
                        SimFormat.Embedded,
                        SimFormat.Nano,
                    }.Contains(s)
                )
               .ToList(),
            SimCount = 2,
        };

        var connectivity = new Connectivity
        {
            Cellular = cellular,
            WiFi = new WiFi()
            {
                Standards = WiFiStandards.Where(
                        s => new List<WiFiStandard>()
                        {
                            WiFiStandard.b,
                            WiFiStandard.g,
                            WiFiStandard.n,
                            WiFiStandard.ac,
                            WiFiStandard.ax,
                        }.Contains(s)
                    )
                   .ToList(),
            },
            Bluetooth = new Bluetooth
            {
                Version = "5.3",
            },
            HasIR = true,
            HasNFC = true,
            HasUWB = true,
            NavigationSystems = NavigationSystems.Where(
                    ns => new List<NavigationSystem>()
                    {
                        NavigationSystem.GPS,
                        NavigationSystem.GLONASS,
                    }.Contains(ns)
                )
               .ToList(),
            USB = new Usb
            {
                Connector = UsbConnectors.First(c => c == UsbConnector.C),
                Version = "3.1",
                Features = UsbFeatures.Where(
                        f => new List<UsbFeature>()
                        {
                            UsbFeature.OTG,
                            UsbFeature.Charging,
                        }.Contains(f)
                    )
                   .ToList(),
            },
        };

        var batteryLife = new BatteryLife
        {
            Gaming = TimeSpan.FromHours(5),
            Standby = TimeSpan.FromHours(120),
            Video = TimeSpan.FromHours(15),
            WebBrowsing = TimeSpan.FromHours(25),
        };

        var battery = new Battery
        {
            Capacity = 5000,
            Life = batteryLife,
            Replaceable = false,
            Type = BatteryTypes.First(bt => bt == BatteryType.LiPo),
        };

        var body = new Body
        {
            BackMaterial = Materials.First(m => m == Material.Glass),
            FrameMaterial = Materials.First(m => m == Material.Metal),
            Color = "Black",
            FingerprintLocation = FingerprintLocations.First(f => f == FingerprintLocation.Button),
            Height = 180,
            IpRating = "IP68",
            ScreenProtection = "Corning Gorilla Glass Victus",
            Thickness = 9,
            Weight = 210,
            Width = 80,
        };

        var benchmark = new Benchmark
        {
            Antutu = new AntutuBenchmark
            {
                Cpu = 500_000,
                Gpu = 500_000,
                Mem = 500_000,
                Total = 2_000_000,
                Ux = 500_000,
            },
            DxOMark = new DxOMarkBenchmark
            {
                Bokeh = 150,
                Photo = 150,
                Preview = 150,
                Video = 150,
                Zoom = 150,
            },
            Geekbench5 = new GeekbenchBenchmark
            {
                Metal = 0,
                MultiCore = 12000,
                OpenCL = 7800,
                SingleCore = 1800,
                Vulkan = 15000,
            },
            ThreeDMark = new ThreeDMarkBenchmark
            {
                Performance = 3210320,
            },
        };

        var cameras = new List<Camera>()
        {
            new()
            {
                Aperture = 3,
                Autofocus = Autofocuses.First(af => af == Autofocus.Laser),
                DigitalZoomValue = 50,
                FocalLength = 30,
                HasOpticalZoom = true,
                Sensor = new ImageSensor
                {
                    Format = "ImageSensorFormat",
                    Manufacturer = "Sony",
                    Model = "IMX666",
                },
                LensType = LensTypes.First(lt => lt == LensType.Wide),
                Matrix = 200,
                OpticalZoomValue = 5,
                PhotoCapabilities = new PhotoCapabilities
                {
                    MaxHeight = 12000,
                    MaxWidth = 6000,
                },
                ImageStabilization = Stabilizations.First(s => s == ImageStabilization.Optical),
                PixelSize = 1.4,
                VideoCapabilities = new VideoCapabilities
                {
                    Modes = new List<VideoMode>()
                    {
                        new()
                        {
                            FrameRate = 30,
                            Resolution = "4k",
                        },
                        new()
                        {
                            FrameRate = 120,
                            Resolution = "FullHD",
                        },
                    },
                },
            },
            new()
            {
                Aperture = 3,
                Autofocus = Autofocuses.First(af => af == Autofocus.Laser),
                DigitalZoomValue = 50,
                FocalLength = 30,
                HasOpticalZoom = true,
                Sensor = new ImageSensor
                {
                    Format = "ImageSensorFormat",
                    Manufacturer = "Sony",
                    Model = "IMX666",
                },
                LensType = LensTypes.First(lt => lt == LensType.Wide),
                Matrix = 200,
                OpticalZoomValue = 5,
                PhotoCapabilities = new PhotoCapabilities
                {
                    MaxHeight = 12000,
                    MaxWidth = 6000,
                },
                ImageStabilization = Stabilizations.First(s => s == ImageStabilization.Optical),
                PixelSize = 1.4,
                VideoCapabilities = new VideoCapabilities
                {
                    Modes = new List<VideoMode>()
                    {
                        new()
                        {
                            FrameRate = 30,
                            Resolution = "4k",
                        },
                        new()
                        {
                            FrameRate = 120,
                            Resolution = "FullHD",
                        },
                    },
                },
            },
            new()
            {
                Aperture = 3,
                Autofocus = Autofocuses.First(af => af == Autofocus.Laser),
                DigitalZoomValue = 50,
                FocalLength = 30,
                HasOpticalZoom = true,
                Sensor = new ImageSensor
                {
                    Format = "ImageSensorFormat",
                    Manufacturer = "Sony",
                    Model = "IMX666",
                },
                LensType = LensTypes.First(lt => lt == LensType.Wide),
                Matrix = 200,
                OpticalZoomValue = 5,
                PhotoCapabilities = new PhotoCapabilities
                {
                    MaxHeight = 12000,
                    MaxWidth = 6000,
                },
                ImageStabilization = Stabilizations.First(s => s == ImageStabilization.Optical),
                PixelSize = 1.4,
                VideoCapabilities = new VideoCapabilities
                {
                    Modes = new List<VideoMode>()
                    {
                        new()
                        {
                            FrameRate = 30,
                            Resolution = "4k",
                        },
                        new()
                        {
                            FrameRate = 120,
                            Resolution = "FullHD",
                        },
                    },
                },
            },
        };

        var charging = new Charging
        {
            FullChargingTime = TimeSpan.FromHours(1),
            HalfChargingTime = TimeSpan.FromMinutes(30),
            ReverseChargePower = 5,
            ReverseChargingSupported = true,
            WiredChargePower = 30,
            WirelessChargePower = 15,
            WirelessChargingSupported = true,
        };

        var smartphone1 = new Smartphone()
        {
            Charging = charging,
            SoC = soc,
            Sound = sound,
            Software = software,
            Sensors = Sensors.Where(
                    s => new List<Sensor>()
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security,
            Screen = screen,
            Memory = memory,
            Connectivity = connectivity,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "Samsung",
            Manufacturer = "Samsung",
            Model = "Galaxy S22 Ultra",
            MarketSegment = Categories.First(c => c == MarketSegment.Flagship),
            Body = body,
            Benchmark = benchmark,
            Cameras = cameras,
        };

        var fastCore2 = new Core
        {
            Clock = 3050,
            InstructionSet = "ARMv9-A",
            Microarchitecture = "Cortex-X2",
            LaunchDate = new DateOnly(2021, 9, 1),
        };

        var midCore2 = new Core
        {
            Clock = 2850,
            InstructionSet = "ARMv9-A",
            Microarchitecture = "A710",
            LaunchDate = new DateOnly(2021, 9, 1),
        };

        var slowCore2 = new Core
        {
            Clock = 1800,
            InstructionSet = "ARMv9-A",
            Microarchitecture = "A510",
            LaunchDate = new DateOnly(2021, 9, 1),
        };

        var cores2 = new List<Core>();
        cores2.Add(fastCore2);
        for (int i = 0; i < 3; i++)
        {
            var mid = new Core()
            {
                Clock = midCore2.Clock,
                InstructionSet = midCore2.InstructionSet,
                LaunchDate = midCore2.LaunchDate,
                Microarchitecture = midCore2.Microarchitecture,
            };
            cores2.Add(mid);
        }

        for (int i = 0; i < 4; i++)
        {
            var slow = new Core()
            {
                Clock = slowCore2.Clock,
                InstructionSet = slowCore2.InstructionSet,
                LaunchDate = slowCore2.LaunchDate,
                Microarchitecture = slowCore2.Microarchitecture,
            };
            cores2.Add(slow);
        }

        var cpu2 = new Cpu
        {
            Cores = cores2,
            Tdp = 5,
        };

        var gpu2 = new Gpu
        {
            Model = "SomeGPU 666",
        };

        var soc2 = new SoC
        {
            Cpu = cpu2,
            Gpu = gpu2,
            LaunchDate = new DateOnly(2023, 9, 9),
            Litography = 5,
            Manufacturer = "MediaTek",
            Model = "Dimensity 9200 Plus",
        };

        var sound2 = new Sound
        {
            Codecs = Codecs.Where(c => c.Id == AudioCodec.aptX.Id).ToList(),
            SpeakerType = Speakers.First(s => s.Id == SpeakerType.Stereo.Id),
            HasFmRadio = false,
            HasHeadphoneJack = false,
        };

        var software2 = new Software
        {
            Distribution = Distributions.First(d => d == Distribution.EMUI),
            DistributionVersion = 5,
            OperatingSystem = OperatingSystems.First(os => os == Domain.OperatingSystem.Android),
            OperatingSystemVersion = 13,
        };

        var security2 = new Security
        {
            HasFaceUnlock = true,
            HasFingerprintUnlock = true,
            HasIrisUnlock = false,
            HasCoprocessor = false,
        };

        var screen2 = new Screen
        {
            AspectRatio = 19.3 / 9,
            HasDCDimming = true,
            HDRBrightness = 6666,
            HDRFormat = HdrFormats.First(h => h == HdrFormat.HDR10Plus),
            HDRSupport = true,
            HeightInPixels = 3088,
            MaxBrightness = 1200,
            MaxRefreshRatio = 144,
            MinRefreshRatio = 1,
            ScreenMatriceTechnology = Panels.First(p => p == ScreenMatriceTechnology.OLED),
            WidthInPixels = 1440,
            Size = 6.8,
        };

        var memory2 = new Memory
        {
            MemoryCardSupported = false,
            Ram = new Ram
            {
                Channels = 4,
                Clock = 2400,
                Size = 8,
                Type = RamTypes.First(r => r.Id == RamType.LPDDR5X.Id),
            },
            Storage = new Storage
            {
                Size = 512,
                StorageVersion = 3,
                Type = StorageTypes.First(st => st.Id == StorageType.UFS.Id),
            },
        };

        var cellular2 = new Cellular
        {
            Bands2G = TwoGBands.Where(
                    b => b.Id == TwoGBand.TGSM380.Id || b.Id == TwoGBand.TGSM410.Id
                )
               .ToList(),
            Bands3G = ThreeGBands
               .Where(b => b.Id == ThreeGBand.Two.Id || b.Id == ThreeGBand.Twelve.Id)
               .ToList(),
            Bands4G = FourGBands.Where(
                    b => new List<FourGBand>()
                    {
                        FourGBand.TwentyEight,
                        FourGBand.TwentySix,
                        FourGBand.Fifty,
                        FourGBand.One,
                        FourGBand.Eight,
                        FourGBand.EightyFive,
                    }.Contains(b)
                )
               .ToList(),
            Bands5G = FiveGBands.Where(
                    b => new List<FiveGBand>()
                    {
                        FiveGBand.n1,
                        FiveGBand.n2,
                        FiveGBand.n3,
                        FiveGBand.n5,
                        FiveGBand.n7,
                        FiveGBand.n8,
                        FiveGBand.n12,
                        FiveGBand.n18,
                    }.Contains(b)
                )
               .ToList(),
            MultiSimMode = MultiSimModes.First(m => m == MultiSimMode.Standby),
            SimType = SimTypes.Where(
                    s => new List<SimFormat>()
                    {
                        SimFormat.Embedded,
                        SimFormat.Nano,
                    }.Contains(s)
                )
               .ToList(),
            SimCount = 2,
        };

        var connectivity2 = new Connectivity
        {
            Cellular = cellular2,
            WiFi = new WiFi()
            {
                Standards = WiFiStandards.Where(
                        s => new List<WiFiStandard>()
                        {
                            WiFiStandard.b,
                            WiFiStandard.g,
                            WiFiStandard.n,
                            WiFiStandard.ac,
                            WiFiStandard.ax,
                        }.Contains(s)
                    )
                   .ToList(),
            },
            Bluetooth = new Bluetooth
            {
                Version = "5.3",
            },
            HasIR = true,
            HasNFC = true,
            HasUWB = true,
            NavigationSystems = NavigationSystems.Where(
                    ns => new List<NavigationSystem>()
                    {
                        NavigationSystem.GPS,
                        NavigationSystem.GLONASS,
                    }.Contains(ns)
                )
               .ToList(),
            USB = new Usb
            {
                Connector = UsbConnectors.First(c => c == UsbConnector.C),
                Version = "3.1",
                Features = UsbFeatures.Where(
                        f => new List<UsbFeature>()
                        {
                            UsbFeature.OTG,
                            UsbFeature.Charging,
                        }.Contains(f)
                    )
                   .ToList(),
            },
        };

        var batteryLife2 = new BatteryLife
        {
            Gaming = TimeSpan.FromHours(5),
            Standby = TimeSpan.FromHours(120),
            Video = TimeSpan.FromHours(15),
            WebBrowsing = TimeSpan.FromHours(25),
        };

        var battery2 = new Battery
        {
            Capacity = 5000,
            Life = batteryLife2,
            Replaceable = false,
            Type = BatteryTypes.First(bt => bt == BatteryType.LiPo),
        };

        var body2 = new Body
        {
            BackMaterial = Materials.First(m => m == Material.Glass),
            FrameMaterial = Materials.First(m => m == Material.Metal),
            Color = "Black",
            FingerprintLocation = FingerprintLocations.First(f => f == FingerprintLocation.Button),
            Height = 180,
            IpRating = "IP68",
            ScreenProtection = "Corning Gorilla Glass Victus",
            Thickness = 9,
            Weight = 210,
            Width = 80,
        };

        var benchmark2 = new Benchmark
        {
            Antutu = new AntutuBenchmark
            {
                Cpu = 500_000,
                Gpu = 500_000,
                Mem = 500_000,
                Total = 2_000_000,
                Ux = 500_000,
            },
            DxOMark = new DxOMarkBenchmark
            {
                Bokeh = 150,
                Photo = 150,
                Preview = 150,
                Video = 150,
                Zoom = 150,
            },
            Geekbench5 = new GeekbenchBenchmark
            {
                Metal = 0,
                MultiCore = 12000,
                OpenCL = 7800,
                SingleCore = 1800,
                Vulkan = 15000,
            },
            ThreeDMark = new ThreeDMarkBenchmark
            {
                Performance = 3210320,
            },
        };

        var cameras2 = new List<Camera>()
        {
            new()
            {
                Aperture = 3,
                Autofocus = Autofocuses.First(af => af == Autofocus.Laser),
                DigitalZoomValue = 50,
                FocalLength = 30,
                HasOpticalZoom = true,
                Sensor = new ImageSensor
                {
                    Format = "ImageSensorFormat",
                    Manufacturer = "Sony",
                    Model = "IMX666",
                },
                LensType = LensTypes.First(lt => lt == LensType.Wide),
                Matrix = 200,
                OpticalZoomValue = 5,
                PhotoCapabilities = new PhotoCapabilities
                {
                    MaxHeight = 12000,
                    MaxWidth = 6000,
                },
                ImageStabilization = Stabilizations.First(s => s == ImageStabilization.Optical),
                PixelSize = 1.4,
                VideoCapabilities = new VideoCapabilities
                {
                    Modes = new List<VideoMode>()
                    {
                        new()
                        {
                            FrameRate = 30,
                            Resolution = "4k",
                        },
                        new()
                        {
                            FrameRate = 120,
                            Resolution = "FullHD",
                        },
                    },
                },
            },
        };

        var charging2 = new Charging
        {
            FullChargingTime = TimeSpan.FromHours(1),
            HalfChargingTime = TimeSpan.FromMinutes(30),
            ReverseChargePower = 5,
            ReverseChargingSupported = true,
            WiredChargePower = 30,
            WirelessChargePower = 15,
            WirelessChargingSupported = true,
        };

        var smartphone2 = new Smartphone()
        {
            Charging = charging2,
            SoC = soc2,
            Sound = sound2,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory2,
            Connectivity = connectivity2,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "iPhone",
            Manufacturer = "Apple",
            Model = "14 Pro Max",
            MarketSegment = Categories.First(c => c == MarketSegment.Flagship),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras2,
        };

        var smartphone3 = new Smartphone()
        {
            Charging = charging2,
            SoC = soc2,
            Sound = sound2,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory2,
            Connectivity = connectivity2,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "Xiaomi",
            Manufacturer = "Xiaomi",
            Model = "13 Ultra",
            MarketSegment = Categories.First(c => c == MarketSegment.Flagship),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras2,
        };

        var smartphone4 = new Smartphone()
        {
            Charging = charging,
            SoC = soc,
            Sound = sound,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory,
            Connectivity = connectivity,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "OnePlus",
            Manufacturer = "Vivo",
            Model = "Nord 2",
            MarketSegment = Categories.First(c => c == MarketSegment.Mid),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras,
        };

        var smartphone5 = new Smartphone()
        {
            Charging = charging,
            SoC = soc,
            Sound = sound,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory,
            Connectivity = connectivity,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "Pixel",
            Manufacturer = "Google",
            Model = "6a",
            MarketSegment = Categories.First(c => c == MarketSegment.Mid),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras,
        };

        var smartphone6 = new Smartphone()
        {
            Charging = charging,
            SoC = soc,
            Sound = sound,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory,
            Connectivity = connectivity,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "Realme",
            Manufacturer = "Realme",
            Model = "GT Neo 5",
            MarketSegment = Categories.First(c => c == MarketSegment.Mid),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras,
        };

        var smartphone7 = new Smartphone()
        {
            Charging = charging,
            SoC = soc,
            Sound = sound,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory,
            Connectivity = connectivity,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "Tecno",
            Manufacturer = "Tecno",
            Model = "Camon 2",
            MarketSegment = Categories.First(c => c == MarketSegment.Mid),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras,
        };

        var smartphone8 = new Smartphone()
        {
            Charging = charging,
            SoC = soc,
            Sound = sound,
            Software = software2,
            Sensors = Sensors.Where(
                    s => new List<Sensor>
                    {
                        Sensor.Accelerometer,
                        Sensor.Barometer,
                        Sensor.Gyroscope,
                        Sensor.Proximity,
                    }.Contains(s)
                )
               .ToList(),
            Security = security2,
            Screen = screen2,
            Memory = memory,
            Connectivity = connectivity,
            AnnounceDate = new DateOnly(2022, 12, 30),
            Battery = battery2,
            ReleaseDate = new DateOnly(2023, 1, 8),
            Brand = "Alcatel",
            Manufacturer = "Alcatel",
            Model = "One Touch",
            MarketSegment = Categories.First(c => c == MarketSegment.Mid),
            Body = body2,
            Benchmark = benchmark2,
            Cameras = cameras,
        };

        Smartphones.Add(smartphone1);
        Smartphones.Add(smartphone2);
        Smartphones.Add(smartphone3);
        Smartphones.Add(smartphone4);
        Smartphones.Add(smartphone5);
        Smartphones.Add(smartphone6);
        Smartphones.Add(smartphone7);
        Smartphones.Add(smartphone8);
    }
}