namespace Entities.Exceptions
{
    // sealed sayesinde BookNotFound classından hic bir şekilde kalıtım alınmayacak
    public sealed class BookNotFoundException : NotFoundException
    {
        public BookNotFoundException(int id) : base($"The book with id : {id} could not found.") {}
    }

}
