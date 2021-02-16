using System;
class ShelterAnimalFactory : AnimalFactory
{
    public override Cat CreateCat(string name)
    {
        return new Cat(name);
    }
    public override Dog CreateDog(string name)
    {
        return new Dog(name);
    }
}