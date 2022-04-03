using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.Generics
{
    // Обобщенные типы
    // Для тех полей объекта, наилучший тип для которых мы не придумали
    // или не знаем, каким он будет при инициализации,
    // разумно было бы использовать тип object. Но! - упаковка / распаковка - затратно.

    // Поэтому добавлены обобщенные типы.
    class Person<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
    // В данном случае Т - универсальный параметр, т.к.
    // мы еще не знаем, какой это будет тип.

    // Мы можем представить универсальный параметр обобщенным типом,
    // т.е. <T> - generic.
    class Company<P>
    {
        public P CEO { get; set; }
        public Company(P ceo)
        {
            CEO = ceo;
        }
        public override string ToString()
        {
            return $"This company CEO: {CEO}";
        }
    }

    // Можно создать отдельные статические поля для разных типов,
    // например, для int и string.
    class Man<T>
    {
        public static T code;
        public T Id { get; set; }
        public string Name { get; set; }
        public Man(T id, string name)
        {
            Name = name;
            Id = id;
        }
        public override string ToString()
        {
            return $"{code} {Id} {Name}";
        }
    }

    // Также мы можем использовать несколько универсальных параметров.
    class Women<P, T>
    {
        public P Id { get; }
        public T Password { get; set; }
        public string WomenName { get; }
        public Women(P id, T password, string womenName)
        {
            Id = id;
            Password = password;
            WomenName = womenName;
        }
        public override string ToString()
        {
            return $"{Id} {Password} {WomenName}";
        }
    }
}
