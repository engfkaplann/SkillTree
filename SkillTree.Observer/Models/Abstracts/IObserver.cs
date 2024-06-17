using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Observer.Models.Abstracts
{
    public interface IObserver
    {
        public void Update(string message);
    }
}
