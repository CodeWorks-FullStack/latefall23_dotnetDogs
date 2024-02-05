

namespace dotnetDogs.Services;



public class DogsService(DogsRepository repo){

  private readonly DogsRepository repo = repo;

// NOTE we can call it repo cause it is the ONLY repo it should ever talk to.
  // private readonly CatsRepository catRepo;

public readonly bool cool = true;
private bool extraCool = false;


    internal List<Dog> GetDogs()
    {
        List<Dog> dogs = repo.GetDogs();
        return dogs;
    }

    internal Dog GetDogById(string dogId)
    {
        Dog dog = repo.GetDogById(dogId);
        if(dog == null) throw new Exception($"what the dog doing, bad id: {dogId}");
        return dog;
    }

    internal Dog CreateDog(Dog dogData)
    {
      Dog dog = repo.CreateDog(dogData);
      return dog;
    }

    internal string RemoveDog(string dogId)
    {
      Dog dogToRemove = GetDogById(dogId);
      // Typically we verify ownership here too

      repo.RemoveDog(dogId);
      return $"{dogToRemove.Name} was adopted.";
    }
}