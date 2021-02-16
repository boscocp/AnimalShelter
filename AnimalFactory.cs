using System;
abstract class AnimalFactory
{
    public abstract Dog CreateDog(string name);
    public abstract Cat CreateCat(string name);
}