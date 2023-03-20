using HW3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Models
{
    public class Computer : ComputerBase, IDisposable
    {
        private List<RAM> RAMs { get; set; }
        private List<HardDisc> HardDiscs { get; set; }
        private Processor processor { get; set; }
        private int TotalRAM;
        private int TotalHardDiscMemory;


        public Computer(string brand, string color, int ramQuantity, int hardDiscQuantity) : base(brand, color, ramQuantity, hardDiscQuantity)
        {
            this.RAMs = new List<RAM>();
            this.HardDiscs = new List<HardDisc>();
        }

        public void Eject(RAM item)
        {
            if (RAMs.Count == 0)
            {
                Console.WriteLine("No RAM at this computer");
            }
            else
            {
                if (RAMs.Contains(item))
                {
                    RAMs.Remove(item);
                    TotalRAM -= item.Value;
                    item.Eject();
                    Console.WriteLine($"{item.Name} ejected from computer. Total RAM is {TotalRAM} GB");
                }
                else
                {
                    Console.WriteLine("No this RAM item in this computer");
                }
            }

        }

        public void Remove(HardDisc item)
        {
            if (HardDiscs.Count == 0)
            {
                Console.WriteLine("No hard disc at this computer");
            }
            else
            {
                if (HardDiscs.Contains(item))
                {
                    HardDiscs.Remove(item);
                    TotalHardDiscMemory -= item.Storage;
                    item.Remove();
                    Console.WriteLine($"{item.Name} removed from computer. Total memory is {TotalRAM} GB");
                }
                else
                {
                    Console.WriteLine("No more empty slots for hard disc");
                }
            }
        }

        public void Unplug(Processor item)
        {
            if (processor == null)
            {
                Console.WriteLine("There is no processor in this computer");
            }
            else if (processor == item)
            {
                item.Unplug();
                Console.WriteLine($"Unpluged processor {processor.Name} from this computer");
                processor = null;

            }
            else
            {
                Console.WriteLine("There is another processor in this computer");
            }
        }

        public void AddRAM(RAM item)
        {
            if (RAMs.Count() < RamQuantity)
            {
                RAMs.Add(item);
                TotalRAM += item.Value;
                Console.WriteLine($"{item.Name} added to computer. Total RAM is {TotalRAM} GB");
            }
            else
            {
                Console.WriteLine("No more empty slots for RAM");
            }
        }

        private void AddHardDisc(HardDisc item)
        {
            if (HardDiscs.Count() < HardDiscQuantity)
            {
                HardDiscs.Add(item);
                TotalHardDiscMemory += item.Storage;
                Console.WriteLine($"{item.Name} added to computer. Total memory is {TotalHardDiscMemory} GB");
            }
            else
            {
                Console.WriteLine("No more empty slots for hard disc");
            }
        }

        private void AddProcessor(Processor item)
        {
            if (processor != null)
            {
                Console.WriteLine("Processor is already installed on the computer");
            }
            else
            {
                processor = item;
                Console.WriteLine($"Added processor {processor.Name} to this computer");
            }
        }

        public void AddSomething(IAddable item)
        {
            if (item is RAM)
            {
                AddRAM(item as RAM);
            }
            else if(item is HardDisc)
            {
                AddHardDisc(item as HardDisc);
            }
            else if(item is Processor)
            {
                AddProcessor(item as Processor);
            }
            else
            {
                Console.WriteLine("Please send me anything else");
            }
        }

        public override string ToString()
        {

            Console.WriteLine();
            Console.WriteLine("Computer configuration:");
            if (processor != null)
                Console.WriteLine($"Processor: {processor.Name}");
            if (TotalRAM != 0)
            {
                Console.WriteLine($"RAM {TotalRAM} with RAMs:");
                RAMs.ForEach(x => Console.WriteLine(x.Name));
            }
            if (TotalHardDiscMemory != 0)
            {
                Console.WriteLine($"Hard discs memory {TotalHardDiscMemory} GB with hard discs:");
                HardDiscs.ForEach(x => Console.WriteLine(x.Name));
            }
            
            Console.WriteLine();
            Console.WriteLine("Other information:");
            return $"{this.Brand} {this.Color}";

            
        }

        public void Dispose()
        {
            this.processor.Unplug();
            this.processor = null;
            this.RAMs.ForEach(x => x.Eject());
            this.RAMs = new List<RAM>();
            this.TotalRAM = 0;
            this.HardDiscs.ForEach(x => x.Remove());
            this.HardDiscs = new List<HardDisc>();
            this.TotalHardDiscMemory = 0;
            Console.WriteLine("All devices are disconnected");

        }
    }
}
