using SkillTree.Bridge.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Bridge.Models.Concretes
{
    public class Remote
    {
        protected IDevice _device;
        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled())
                _device.Disable();
            else
                _device.Enable();

            Console.WriteLine($"Power is {_device.IsEnabled()}");
        }

        public void IncreaseVolume()
        {
            _device.SetVolume(_device.GetVolume() + 10);
            Console.WriteLine($"Volume is {_device.GetVolume()}");
        }

        public void DecreaseVolume()
        {
            _device.SetVolume(_device.GetVolume() - 10);
            Console.WriteLine($"Volume is {_device.GetVolume()}");
        }
    }
}
