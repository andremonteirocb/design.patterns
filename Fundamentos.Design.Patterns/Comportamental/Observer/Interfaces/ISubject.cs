namespace Fundamentos.Design.Patterns.Observer.Interfaces
{
    public interface ISubject
    {
        void ChangeName(string newName);
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
