using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    internal class JuicePackage : PackegeBase
    {
        private string _companyName;
        private bool _isUnpacked = false;
        private bool _isOpen = false;
        public double FilledVolume { get; set; }

        public string CompanyName => _companyName;
        public bool IsUnpacked => _isUnpacked;

        public JuicePackage(string companyName)
        {
            _companyName = companyName;
        }

        public override void Fill(double filledVolume)
        {
            if (_volume >= filledVolume && _isOpen)
            {
                _volume -= filledVolume;
                Console.WriteLine($"Filled {filledVolume} ml. Left {_volume} ml");
            }
            else if (_volume < filledVolume && _isOpen)
            {
                Console.WriteLine($"Filled {_volume} ml.");
                _volume = 0;
            }
            else
            {
                Console.WriteLine("The package is closed");
            }
                
        }
        public override void Pack()
        {
            _isOpen = false;
            Console.WriteLine("Packed");
        }

        public override void Unpack()
        {
            _isOpen = true;
            _isUnpacked = true;
            Console.WriteLine("Unpacked");
        }

        public override void Spoil()
        {
            Console.WriteLine("Vmer");
        }

        ~JuicePackage()
        {
            if (_volume == 0)
            {
                Console.WriteLine("The package is empty. To trash.");
            }
            
        }
    }
}
