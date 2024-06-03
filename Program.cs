using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VSCODE;

public class Bunny
{
    // Fields
  protected string Name;
  protected int age;
  protected bool LikesCarrots;
  protected bool LikesHumans;
  
  // Constructor for class
  public Bunny (string n, bool lc, bool lh) {
    Name = n;
    LikesCarrots = lc;
    LikesHumans = lh;
    age = 0;
  }

  // Methods/Behavior
  public void Birthday() {
    age++;
    Console.WriteLine($"Happy birthday {Name}, he just turned {age} years old!");
  }

  public void attackHuman() {
    if (!LikesHumans) {
        Console.WriteLine($"{Name} attacked a nearby human");
    }
    else {
        Console.WriteLine($"Sorry {Name} likes humans.");
    } 
  }
  public void Eat() {
    if(LikesCarrots) {
        Console.WriteLine($"{Name} ate a carrot");
    }
    else {
        Console.WriteLine($"{Name} doesn't like carrots so he will eat something else");
    }
  }

  // Getters
  public string GetName() {
    return Name;
  }
  public int GetAge() {
    return age;
  }
  public bool GetLikesCarrots() {
    return LikesCarrots;
  }
  public bool GetLikesHumans() {
    return LikesHumans;
  }

  // Setters
  public void SetName(string n) {
    Name = n;
  }
  public void SetAge(int a) {
    age = a;
  }
  public void SetLikesCarrots(bool lc) {
    LikesCarrots = lc;
  }
  public void SetLikesHumans(bool lh) {
    LikesHumans = lh;
  }
}

class Program
{
    static void Main(string[] args)
    {
       Bunny bunny1 = new Bunny("Sam", true, true);
       Bunny bunny2 = new Bunny("David", false, true);
       Bunny bunny3 = new Bunny("Rex",false,false);

       bunny1.attackHuman();
       bunny2.attackHuman();
       bunny3.attackHuman();

       bunny1.Birthday();

       bunny1.Eat();
       bunny2.Eat();

       Console.WriteLine($"While {bunny1.GetName} is {bunny1.GetAge}, {bunny2.GetName} is only {bunny2.GetAge}");
       bunny2.SetAge(5);
       Console.Write($"Now {bunny2.GetName} is {bunny2.GetAge} years old.");
    }
}