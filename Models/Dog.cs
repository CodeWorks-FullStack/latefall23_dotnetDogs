namespace dotnetDogs.Models;



public class Dog{

  // public int Id {get; private set;}
  public string Id {get; set;} = Guid.NewGuid().ToString();

  public string Name {get; set;}

  public string Breed {get; set;}

  public string Color {get; set;}

  public bool IsSlobbery {get; set;}

  public double TailWagsPerSecond {get; set;}

 public Dog( string name, string breed, string color, bool isSlobbery, double tailWagsPerSecond){
  Name = name;
  Breed = breed;
  Color = color;
  IsSlobbery = isSlobbery;
  TailWagsPerSecond = tailWagsPerSecond;
 }
}