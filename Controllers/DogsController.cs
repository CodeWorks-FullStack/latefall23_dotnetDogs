namespace dotnetDogs.Controllers;


[ApiController]
[Route("api/dogs")]
public class DogsController : ControllerBase{

private readonly DogsService dogsService;

// NOTE parameters in class constructors are dependencies, and MUST be registered in the Startup.cs file as such.
    public DogsController(DogsService dogsService)
    {
        this.dogsService = dogsService;
    }

    

    [HttpGet]
public ActionResult<List<Dog>> GetDogs(){
  try
  {
    // throw new Exception("oh no!");
    // dogsService.cool = false;
  List<Dog> dogs = dogsService.GetDogs();
  return Ok(dogs);
  }
  catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpGet("{dogId}")]
public ActionResult<Dog> GetDogById(string dogId){
  try
  {
    Dog dog = dogsService.GetDogById(dogId);
    return Ok(dog);
  }
catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpPost]
public ActionResult<Dog> CreateDog([FromBody] Dog dogData){
  try{
    Dog dog = dogsService.CreateDog(dogData);
    return Ok(dog);
  }
  catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpDelete("{dogId}")]
public ActionResult<string> RemoveDog(string dogId){
  try
  {
    string message = dogsService.RemoveDog(dogId);
    return Ok(message);
  }
  catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}


}