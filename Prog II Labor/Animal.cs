namespace Prog_II_Labor;

public class Animal
{
    public string Name;
    public int Age;

    public virtual void MakeSound()
    {
        Console.WriteLine("n/a");
    }

    public static void test()
    {
        var cat = new Cat();
        cat.MakeSound();
        var dog = new Dog();
        dog.MakeSound();
    }
}