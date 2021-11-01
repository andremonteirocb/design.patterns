using System;

namespace Fundamentos.Design.Patterns.Criacional.Prototype
{
    public class Pessoa : ICloneable
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Pessoa(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public object Clone()
        {
            return (Pessoa)this.MemberwiseClone();
        }
    }
}
