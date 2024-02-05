namespace dotnetDogs.Repositories;


public class DogsRepository{

  private readonly List<Dog> FAKEDB = [
    new Dog( "Phil", "border collie", "black and white", false, 3),
    new Dog( "Harley", "Great Dane", "black", true, .75),
    new Dog( "Walter", "Malamute", "Timber wolf grey", false, 1.1)
  ];
    //NOTE internal is PUBLIC, to this top level namespace.
    internal Dog CreateDog(Dog dogData)
    {
      FAKEDB.Add(dogData);
      return dogData;
    }

    internal Dog GetDogById(string dogId)
    {
        // Dog dog = FAKEDB.Find(dog => dog.Id == dogId);
        Dog dog = FAKEDB.Find(dog => dog.Id == dogId);
        return dog;
    }

    internal List<Dog> GetDogs(){
    // return "Got the Dogs 🐕🐕‍🦺🐩🐶";
    return FAKEDB;
  }

    internal void RemoveDog(string dogId)
    {
      int indexToRemove = FAKEDB.FindIndex(dog => dog.Id == dogId);
      FAKEDB.RemoveAt(indexToRemove);
      // return null; the void, means there is no return for this function
    }
}