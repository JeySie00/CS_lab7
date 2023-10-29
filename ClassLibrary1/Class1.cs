namespace ClassLibrary1;
[Comment("Abstract class for creating animals")] 

abstract public class Animal
{
    public string Country { get; set; }
    public string HideFromOtherAnimals { get; set; }
    public string Name { get; set; }
    public string WhatAnimal{ get; set; }
    eClassificationAnimal Classification {  get; set; }
    protected eFavoriteFood FavoriteFood { get; set; }

    public Animal(string country, string hideFromOtherAnimals, string name, string whatAnimal)
    {
        Country = country;
        HideFromOtherAnimals = hideFromOtherAnimals;
        Name = name;
        WhatAnimal = whatAnimal;
    }

    public void Deconstruct(out string country, out string hideFromOtherAnimals, out string name, out string whatAnimal)
    {
        country = Country;
        hideFromOtherAnimals = HideFromOtherAnimals;
        name = Name;
        whatAnimal = WhatAnimal;
    }

    public eClassificationAnimal GetClassificationAnimal
    {
        get { return Classification; }
    }

    public virtual eFavoriteFood GetFavoriteFood
    {
        get { return FavoriteFood; }
    }

    public virtual void SayHello()
    {
        Console.WriteLine($"Hello, i'm {Name}");
    }
}

[Comment("Class for cow")]
public class Cow : Animal
{
    public Cow(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country, hideFromOtherAnimals, name, whatAnimal)
    {
        Country = country; 
        HideFromOtherAnimals= hideFromOtherAnimals;
        Name = name;
        WhatAnimal = whatAnimal;
    }

    public override eFavoriteFood GetFavoriteFood
    {
        get { return FavoriteFood; }
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hello, i'm cow {Name}");
    }
}

[Comment("Class for lion")]
public class Lion : Animal
{
    public Lion(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country, hideFromOtherAnimals, name, whatAnimal)
    {
        Country = country;
        HideFromOtherAnimals = hideFromOtherAnimals;
        Name = name;
        WhatAnimal = whatAnimal;
    }

    public override eFavoriteFood GetFavoriteFood
    {
        get { return FavoriteFood; }
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hello, i'm lion {Name}");
    }
}

[Comment("Class for pig")]
public class Pig : Animal
{
    public Pig(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country, hideFromOtherAnimals, name, whatAnimal)
    {
        Country = country;
        HideFromOtherAnimals = hideFromOtherAnimals;
        Name = name;
        WhatAnimal = whatAnimal;
    }

    public override eFavoriteFood GetFavoriteFood
    {
        get { return FavoriteFood; }
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hello, i'm pig {Name}");
    }
}

[Comment("Types of animals enumeration")]
public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}

[Comment("Favorite food enumeration")]
public enum eFavoriteFood
{
    Meat,
    Plants,
    Everything
}
