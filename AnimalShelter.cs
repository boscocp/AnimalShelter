using System;
using System.Collections.Generic;

public class AnimalShelter
{
    private const string CAT_STRING = "cat";
    private const string DOG_STRING = "dog";
    private Queue<Animal> _cats = new Queue<Animal>();
    private Queue<Animal> _dogs = new Queue<Animal>();

    public void AddAnimal(Animal animal)
    {
        if (animal.GetType() == typeof(Dog))
        {
            _dogs.Enqueue(animal);
        }
        else if (animal.GetType() == typeof(Cat))
        {
            _cats.Enqueue(animal);
        }
        else
        {
            throw new ArgumentException("Parameter need to be Cat or Dog", nameof(animal));
        }
    }

    public Animal PickOne()
    {
        if (_cats.Count <= 0 && _dogs.Count <= 0)
        {
            throw new ArgumentException("Fila de gatos e cachorros estão vazias"); // com usar corretamente
        }

        Animal oldestCat = _cats.Peek();
        Animal oldestDog = _dogs.Peek();
        int result = DateTime.Compare(oldestCat.ArrivalDate, oldestDog.ArrivalDate);

        string tipo = (_cats.Count > 0 && _dogs.Count <= 0) || result <= 0 ? CAT_STRING : DOG_STRING;
        return Pick(tipo);
    }

    private Animal Pick(string tipo)
    {
        if (tipo.ToLower() == CAT_STRING)
        {
            return DequeueCat();
        }
        else
        {
            return DequeueDog();
        }
    }

    public Animal PickOne(string tipo)
    {
        if (!(tipo == CAT_STRING || tipo == DOG_STRING)) throw new ArgumentException("Tipo must be cat or dog");
        return Pick(tipo);
    }
    private Animal DequeueCat()
    {
        Animal cat;
        if(_cats.TryDequeue(out cat))
        {
            return cat;
        }else
        {
            throw new System.ArgumentOutOfRangeException(null, "fila de gatos vazia");
        }
    }
    private Animal DequeueDog()
    {
        try
        {
            return _dogs.Dequeue();
        }
        catch (System.InvalidOperationException)
        {
            throw new System.ArgumentOutOfRangeException(null, "fila de Cachorro vazia");
        }
    }
}