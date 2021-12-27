using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer() {Code=1,Brand="Acer",CPU="i3",CpuFreguency=3600,RAM=8,SSD=512,MemoryGPU=4,Price=50,Available=40},
                new Computer() {Code=2,Brand="YP",CPU="Ryzen3",CpuFreguency=4000,RAM=8,SSD=512,MemoryGPU=4,Price=99,Available=6},
                new Computer() {Code=3,Brand="ASUS",CPU="i6",CpuFreguency=2600,RAM=16,SSD=512,MemoryGPU=12,Price=120,Available=6},
                new Computer() {Code=4,Brand="Lenovo",CPU="i3",CpuFreguency=3600,RAM=8,SSD=512,MemoryGPU=4,Price=48,Available=3},
                new Computer() {Code=5,Brand="Dell",CPU="i6",CpuFreguency=2600,RAM=16,SSD=1032,MemoryGPU=16,Price=320,Available=3},
                new Computer() {Code=6,Brand="MSI",CPU="i6",CpuFreguency=2600,RAM=16,SSD=256,MemoryGPU=4,Price=360,Available=1},
            };

            // все компьютеры с указанным процессором
            Console.WriteLine("Название процессора:");
            string cpuInput = Console.ReadLine();
            List<Computer> computers = listComputer
                .Where(c => c.CPU == cpuInput)
                .ToList();
            foreach (Computer c in computers)
                Console.WriteLine($"{c.Code}{c.Brand}");
            Console.WriteLine();

            // все компьтеры с объемом ОЗУ не ниже, чем указано
            Console.WriteLine("Объем ОЗУ от:");
            int RamInput = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = listComputer
                .Where(c => c.RAM >= RamInput)
                .ToList();
            foreach (Computer c in computers2)
                Console.WriteLine($"{c.Code}{c.Brand}");
            Console.WriteLine();

            // список, отсортированный по увеличению стоимости
            Console.WriteLine("Список, отсортированный по увеличению стоимости");
            List<Computer> computers3 = listComputer
                .OrderBy(c => c.Price)
                .ToList();
            foreach (Computer c in computers3)
                Console.WriteLine($"{c.Code}{c.Brand}{c.Price}");
            Console.WriteLine();

            // список, сгруппированный по типу процессора
            Console.WriteLine("Список, сгруппированный по типу процессора");
            var computers4 = listComputer.GroupBy(c => c.CPU);
                foreach (IGrouping<string, Computer> g in computers4)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine();
            }


            // самый дорогой и самый бюджетный компьютер
            Computer computers5 = listComputer
            .OrderByDescending(c => c.Price)
            .First();
            Console.WriteLine($"Самый дорогой компьютер{computers5.Code}{computers5.Brand}{computers5.Price}");
            Console.WriteLine();

            Computer computers6 = listComputer
            .OrderByDescending(c => c.Price)
            .First();
            Console.WriteLine($"Самый бюджетный компьютер{computers6.Code}{computers6.Brand}{computers6.Price}");
            Console.WriteLine();

            // один компьютер в количестве не менее 30 штук
            bool result1 = computers3.Any(c => c.Available >= 30);
            if (result1)
            {
                Console.WriteLine("Есть хотя бы один компьютер в кол-ве не менее 30 шт.");
            }
            else
            {
                Console.WriteLine("Нет ни одного компьютер в кол-ве не менее 30 шт.");
            }

            Console.ReadKey();
        }
    }

    class Computer
    {
        public int Code { get; set; }
        public string Brand { get; set; }
        public string CPU { get; set; }
        public int CpuFreguency { get; set; }
        public int RAM { get; set; }
        public int SSD { get; set; }
        public int MemoryGPU { get; set; }
        public int Price { get; set; }
        public int Available { get; set; }
        public bool Key { get; set; }
    }
}
