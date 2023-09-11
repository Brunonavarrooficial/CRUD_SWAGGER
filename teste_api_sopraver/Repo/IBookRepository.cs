using teste_api_sopraver.Model;

namespace teste_api_sopraver.Repo
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Create(Book book);
        Task Update(Book book);
        Task Delete(int id);
    }
}
