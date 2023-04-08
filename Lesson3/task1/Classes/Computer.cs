using System.Linq;
using task1.Classes.Details;
using task1;

namespace task1.Classes
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
            Detail? detail = FindDetail(type, label, stock);
            if (detail == null) return "Detail not found or incompatible.";

            switch (type)
            {
                case "motherboard":
                    _motherboard = (Motherboard)detail;
                    _rams.Clear();
                    _cpus.Clear();
                    _gpus.Clear();
                    _drives.Clear();
                    break;
                case "ram":
                    _rams.Add((Ram)detail);
                    break;
                case "cpu":
                    _cpus.Add((Cpu)detail);
                    break;
                case "gpu":
                    _gpus.Add((Gpu)detail);
                    break;
                case "drive":
                    _drives.Add((Drive)detail);
                    break;
                default:
                    return "This category does not exist!";
            }

            return "";
        }

        public string? RemoveDetail(string detailType, string detailName)
        {
            List<Detail?>? detailsList = GetDetailListByType(detailType);
            if (detailsList == null) return "This category does not exist!";

            Detail? detailToRemove = detailsList.FirstOrDefault(detail => detail.Name.ToLower().Contains(detailName));
            if (detailToRemove != null) detailsList.Remove(detailToRemove);

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

            if (totalPrice <= budget)
            {
                return $"{totalInfo}\n\nYou have successfully built your PC within the budget!";
            }
            else
            {
                return $"{totalInfo}\n\nYou have exceeded your budget!";
            }
        }

        private Detail? FindDetail(string type, string label, DetailsStock stock)
        {
            if (_motherboard == null && type != "motherboard") return null;

            return type switch
            {
                "motherboard" => stock.Motherboards.Find(m => m.Name == label),
                "ram" => stock.Rams.Find(r => r.Name == label && r.Type == _motherboard.RamSlotType && _rams.Count < _motherboard.RamSlotsCount),
                "cpu" => stock.Cpus.Find(c => c.Name == label && c.Socket == _motherboard.Socket),
                "gpu" => stock.Gpus.Find(g => g.Name == label),
                "drive" => stock.Drives.Find(d => d.Name == label && _motherboard.Interfaces.ContainsKey(d.Interface) && _drives.Count(drive => drive.Interface == d.Interface) < _motherboard.Interfaces[d.Interface]),
                _ => null,
            };
        }

        private List<Detail?>? GetDetailListByType(string type)
        {
            return type switch
            {
                "motherboard" => new List<Detail?> { _motherboard },
                "ram" => _rams.Cast<Detail?>().ToList(),
                "cpu" => _cpus.Cast<Detail?>().ToList(),
                "gpu" => _gpus.Cast<Detail?>().ToList(),
                "drive" => _drives.Cast<Detail?>().ToList(),
                _ => null,
            };
        }
    }
}