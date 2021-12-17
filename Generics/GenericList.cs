using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class HeroList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    class EvilList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    class Hero
    {
        public String Name { get; set; }
        public int Power { get; set; }
        public int Life { get; set; }
        public string Descrizione { get; set; }
        public Hero()
        {

        }
        public Hero(String name)
        {
            Name = name;
        }
        public Hero(String name, int power, int life, string descrizione)
        {
            Name = name;
            Power = power;
            Life = life;
            Descrizione = descrizione;
        }
    }

    class Evil
    {
        public String Name { get; set; }
        public int Power { get; set; }
        public int Life { get; set; }
        public string Descrizione { get; set; }
        public Evil()
        {

        }
        public Evil(String name)
        {
            Name = name;
        }
        public Evil(String Name, int power, int life, string descrizione)
        {
            Power = power;
            Life = life;
            Descrizione = descrizione;
        }
    }
}
