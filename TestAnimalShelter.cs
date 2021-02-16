using System;
using NUnit.Framework;

[TestFixture]
public class TestAnimalShelter
{
    private AnimalShelter larFeliz = new AnimalShelter();

    [SetUp]
    public void RunBeforeAnyTests()
    {
        
    }

    [Test]
    public void ShouldPickOneCat()
    {   
        //given
        Cat cat = new Cat("Abu");
        larFeliz.AddAnimal(cat);
        //when
        Animal testAnimal = larFeliz.PickOne("cat");
        //then
        Assert.AreEqual("Abu", testAnimal.Name);
    }
    [Test]
    public void ShouldReturnExceptionWhenNoCat()
    { 
        //given
        //when
        var ex = Assert.Throws<ArgumentOutOfRangeException>(()=>larFeliz.PickOne("cat"));
        //then
        Assert.AreEqual("fila de gatos vazia", ex.Message);
    }
    [Test]
    public void ShouldReturnExceptionWhenNoDog()
    { 
        //given
        //when
        var ex = Assert.Throws<ArgumentOutOfRangeException>(()=>larFeliz.PickOne("dog"));
        //then
        Assert.AreEqual("fila de Cachorro vazia", ex.Message);
    }     
}