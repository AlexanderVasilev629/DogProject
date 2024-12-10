using DogsApp.Infrastructure.Data.Domain;

namespace DogsApp.Core.Contracts
{
    public interface IBreedService
    {
        List<Breed> GetAllBreeds();
        Breed GetBreedById(int breedId);
        List<Dog> GetDogsByBreed(int breedId);
    }
}