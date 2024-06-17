using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Bridge.Models.Abstracts
{
    public interface IDevice
    {
        public bool IsEnabled();
        public void Enable();
        public void Disable();
        public int GetVolume();
        public void SetVolume(int percent);
    }
}
