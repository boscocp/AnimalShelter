using System;

class Program
{
    private static AnimalFactory animalFactory;
    public static AnimalShelter larFeliz;
    static void Main(string[] args)
    {
        animalFactory = new ShelterAnimalFactory();
        larFeliz = new AnimalShelter();
        InicializeData();
        Animal testAnimal = Program.larFeliz.PickOne("cat");
        Console.WriteLine(testAnimal.Name);
        Console.WriteLine(Program.larFeliz.PickOne("cat").Name);
        Console.WriteLine(Program.larFeliz.PickOne("cat").Name);
        Program.larFeliz.PickOne("cat");
    }

    
    public static void InicializeData()
    {       
        Dog newDog1 = animalFactory.CreateDog("lulu");
        Dog newDog2 = animalFactory.CreateDog("fofo");
        Cat newCat1 = animalFactory.CreateCat("Abu");
        Cat newCat2 = animalFactory.CreateCat("Lele");
        Cat newCat3 = animalFactory.CreateCat("lolo");
        
        larFeliz.AddAnimal(newDog1);
        larFeliz.AddAnimal(newDog2);
        larFeliz.AddAnimal(newCat1);
        larFeliz.AddAnimal(newCat2);
        larFeliz.AddAnimal(newCat3);
    }
}

