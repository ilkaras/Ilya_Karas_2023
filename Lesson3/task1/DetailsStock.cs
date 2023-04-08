using task1.Classes;
using task1.Classes.Details;

namespace task1
{
    public class DetailsStock
    {
        public List<Motherboard> Motherboards { get; } = new List<Motherboard>
        {
            new Motherboard(3500, "Asus", "USA", "TUF B560M-Plus", "s1200", 4, "DDR4", new Dictionary<string, int> { {"SATA3", 6}, {"M.2", 2} }),
            new Motherboard(32000, "Asus", "USA", "ROG Maximus Z690 Extreme", "s1700", 8, "DDR5", new Dictionary<string, int> { {"SATA3", 8}, {"M.2", 6} }),
            new Motherboard(5200, "MSI", "USA", "MAG B550 Tomahawk", "sAM4", 4, "DDR4", new Dictionary<string, int> { {"SATA3", 6}, {"M.2", 2} }),
            new Motherboard(7500, "Gigabyte", "USA", "A520 AORUS Elite", "sAM4", 4, "DDR4", new Dictionary<string, int> { {"SATA3", 6}, {"M.2", 1} }),
            new Motherboard(10000, "ASRock", "USA", "B550 Phantom Gaming 4", "sAM4", 4, "DDR4", new Dictionary<string, int> { {"SATA3", 6}, {"M.2", 2} }),
            new Motherboard(16500, "EVGA", "USA", "Z590 FTW WiFi", "s1200", 4, "DDR4", new Dictionary<string, int> { {"SATA3", 6}, {"M.2", 2} }),
        };

        public List<Ram> Rams { get; } = new List<Ram>
        {
            new Ram(12000, "Corsair", "USA", "Vengeance RGB Pro 32GB", "DDR5", "32768MB"),
            new Ram(1350, "Crucial", "USA", "Ballistix 8GB", "DDR4", "8192MB"),
            new Ram(5500, "G.Skill", "USA", "Ripjaws V 16GB", "DDR4", "16384MB"),
            new Ram(6800, "Kingston", "USA", "HyperX Fury 16GB", "DDR4", "16384MB"),
            new Ram(2500, "Adata", "USA", "XPG Spectrix D60G 8GB", "DDR4", "8192MB"),
            new Ram(20000, "Patriot", "USA", "Viper Steel 64GB", "DDR4", "65536MB"),
        };

        public List<Cpu> Cpus { get; } = new List<Cpu>
        {
            new Cpu(5900, "Intel", "USA", "i5-12400", "s1700", "6/12", "2.8GHz - 4.6GHz"),
            new Cpu(4500, "AMD", "USA", "Ryzen 5 5600", "sAM4", "6/12", "3.7GHz - 4.4GHz"),
            new Cpu(24000, "Intel", "USA", "i9-13900K", "s1700", "16/32", "3.5GHz - 5.5GHz"),
            new Cpu(10000, "AMD", "USA", "Ryzen 7 5800X", "sAM4", "8/16", "3.8GHz - 4.7GHz"),
            new Cpu(16500, "Intel", "USA", "i7-12700K", "s1700", "12/20", "3.6GHz - 5.0GHz"),
            new Cpu(3000, "AMD", "USA", "Ryzen 3 3300", "sAM4", "4/8", "3.2GHz - 4.0GHz"),
        };

        public List<Gpu> Gpus { get; } = new List<Gpu>
        {
            new Gpu(18000, "ASUS", "USA", "GeForce RTX 3060 TUF Gaming OC", "12GB", "1900MHz"),
            new Gpu(2500, "MSI", "USA", "GeForce GT 730", "2GB", "1000MHz"),
            new Gpu(13000, "Gigabyte", "USA", "GeForce GTX 1660 Ti Gaming OC", "6GB", "1845MHz"),
            new Gpu(60000, "ASUS", "USA", "GeForce RTX 4080 ROG Strix OC Edition", "16GB", "2800MHz"),
            new Gpu(9000, "Zotac", "USA", "GeForce GTX 1650 Super", "4GB", "1725MHz"),
            new Gpu(38000, "EVGA", "USA", "GeForce RTX 3070 XC3 Black", "8GB", "2200MHz"),
            new Gpu(72000, "MSI", "USA", "GeForce RTX 4090 Gaming X Trio", "24GB", "3000MHz"),
        };

        public List<Drive> Drives { get; } = new List<Drive>
        {
            new Drive(1350, "Kingston", "USA", "A2000 NVMe", "SSD", "500GB", "2200MB/s - 2000MB/s", "M.2", "130,1 years"),
            new Drive(1900, "Samsung", "USA", "SSD 970 EVO", "SSD", "500GB", "3400MB/s - 2300MB/s", "M.2", "180,2 years"),
            new Drive(2300, "Seagate", "USA", "Barracuda Pro", "HDD", "2TB", "220MB/s - 220MB/s", "SATA3", null),
            new Drive(2500, "WD", "USA", "Western Digital Blue WD20EZAZ", "HDD", "2TB", "5400RPM", "SATA3", null),
            new Drive(4500, "Samsung", "USA", "870 QVO-Series", "SSD", "1TB", "560MB/s - 530MB/s", "SATA3", "180,2 years"),
            new Drive(11000, "Corsair", "USA", "MP600 Pro XT", "SSD", "2TB", "7100MB/s - 6800MB/s", "M.2", "220,4 years"),
            new Drive(3000, "Crucial", "USA", "P3 NVMe", "SSD", "1TB", "3400MB/s - 3000MB/s", "M.2", "150,3 years"),
            new Drive(800, "Toshiba", "USA", "P300", "HDD", "1TB", "7200RPM", "SATA3", null),
        };
    }
}
