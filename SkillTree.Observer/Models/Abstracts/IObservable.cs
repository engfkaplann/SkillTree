namespace SkillTree.Observer.Models.Abstracts
{
    public interface IObservable
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }
}
