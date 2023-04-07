using System.Linq;
using Les3pr1.Classes.Details;
using Les3pr1;

namespace Les3pr1.Classes
{
    public class Computer
    {
        private Motherboard? _motherboard;
        private List<Ram?> _rams = new List<Ram?>();
        private List<Cpu?> _cpus = new List<Cpu?>();
        private List<Gpu?> _gpus = new List<Gpu?>();
        private List<Drive?> _drives = new List<Drive?>();

        public string AddElement(string type, string label, DetailsStock stock)
        {
            switch (type)
            {
                case "motherboard":
                    Motherboard? motherboard = stock.Motherboards.Find(m => m.Name == label);
                    _motherboard = motherboard;
                    _rams.Clear();
                    _cpus.Clear();
                    _gpus.Clear();
                    _drives.Clear();
                    break;
                case "Ram":
                    if (_motherboard == null) break;
                    Ram? ram = stock.Rams.Find(r =>
                        r.Name == label && r.Type == _motherboard.RamSlotType &&
                        _rams.Count < _motherboard.RamSlotsCount);
                    _rams.Add(ram);
                    break;
                case "Cpu":
                    if (_motherboard == null) break;
                    Cpu? cpu = stock.Cpus.Find(c => c.Name == label && c.Socket == _motherboard.Socket);
                    _cpus.Add(cpu);
                    break;
                case "Gpu":
                    if (_motherboard == null) break;
                    Gpu? gpu = stock.Gpus.Find(g => g.Name == label);
                    _gpus.Add(gpu);
                    break;
                case "Drive":
                    if (_motherboard == null) break;
                    Drive? drive = stock.Drives.Find(d =>
                        d.Name == label && _motherboard.Interfaces.ContainsKey(d.Interface) &&
                        _drives.Count(drv => drv.Interface == d.Interface) < _motherboard.Interfaces[d.Interface]);
                    _drives.Add(drive);
                    break;
                default:
                    return "This category does not exist!";
            }

            return "";
        }


        public string? RemoveDetail(string detailType, string detailName)
        {
            switch (detailType)
            {
                case "motherboard":
                    _motherboard = null;
                    _rams.Clear();
                    _cpus.Clear();
                    _gpus.Clear();
                    _drives.Clear();
                    break;
                case "ram":
                    Ram? ramToRemove = _rams.FirstOrDefault(ram => ram.Name.ToLower().Contains(detailName));
                    if (ramToRemove != null) _rams.Remove(ramToRemove);
                    break;
                case "cpu":
                    Cpu? cpuToRemove = _cpus.FirstOrDefault(cpu => cpu.Name.ToLower().Contains(detailName));
                    if (cpuToRemove != null) _cpus.Remove(cpuToRemove);
                    break;
                case "gpu":
                    Gpu? gpuToRemove = _gpus.FirstOrDefault(gpu => gpu.Name.ToLower().Contains(detailName));
                    if (gpuToRemove != null) _gpus.Remove(gpuToRemove);
                    break;
                case "drive":
                    Drive? driveToRemove = _drives.FirstOrDefault(drive => drive.Name.ToLower().Contains(detailName));
                    if (driveToRemove != null) _drives.Remove(driveToRemove);
                    break;
                default:
                    return "This category does not exist!";
            }
                        return null;
        }

        public Dictionary<string, object?> GetDetails()
        {
            Dictionary<string, object?> Details = new Dictionary<string, object?>();
            Details["motherboard"] = _motherboard;
            Details["ram"] = new List<Detail>(_rams);
            Details["cpu"] = new List<Detail>(_cpus);
            Details["gpu"] = new List<Detail>(_gpus);
            Details["drive"] = new List<Detail>(_drives);
            return Details;
        }

        public string Build(decimal budget)
        {
            decimal totalPrice = 0;

            if (_motherboard is null) return "Please add the motherboard to basket!";
            if (_rams.Count == 0) return "Please add the ram to basket!";
            if (_cpus.Count == 0) return "Please add the cpu to basket!";
            if (_gpus.Count == 0) return "Please add the gpu to basket!";
            if (_drives.Count == 0) return "Please add the drive to basket!";

            string totalInfo = "Your PC:";
            totalInfo += $"\nMotherboard: {_motherboard.GetInfo()}";
            totalPrice += _motherboard.Price;

            totalInfo += "\nRams: ";
            foreach (Ram detail in _rams)
            {
                totalInfo += $"\n {detail.GetInfo()}";
                totalPrice += detail.Price;
            }

            totalInfo += "\nCpus: ";
            foreach (Cpu detail in _cpus)
            {
                totalInfo += $"\n {detail.GetInfo()}";
                totalPrice += detail.Price;
            }

            totalInfo += "\nGpus: ";
            foreach (Gpu detail in _gpus)
            {
                totalInfo += $"\n {detail.GetInfo()}";
                totalPrice += detail.Price;
            }

            totalInfo += "\nDrives: ";
            foreach (Drive detail in _drives)
            {
                totalInfo += $"\n {detail.GetInfo()}";
                totalPrice += detail.Price;
            }
            totalInfo += $"\nTotal price: {totalPrice}";

            if (totalPrice > budget) return "The price is over budget!";

            return totalInfo;
        }
    }
}