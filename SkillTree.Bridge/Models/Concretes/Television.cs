using SkillTree.Bridge.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Bridge.Models.Concretes
{
    internal class Television : IDevice
    {
        private bool _isEnabled;
        private int _volume;

        public void Disable() => _isEnabled = false;

        public void Enable() => _isEnabled = true;

        public int GetVolume() => _volume;

        public bool IsEnabled() => _isEnabled;

        public void SetVolume(int percent) => _volume = percent;
    }
}
