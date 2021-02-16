using System;
public abstract class Animal
{
    private string _name;
    public string Name { get => _name; }
    public DateTime ArrivalDate { get; private set; }
    public Animal(string nome)
    {
        _name = nome;
        ArrivalDate = new DateTime();
    }
}