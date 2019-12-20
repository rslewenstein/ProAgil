using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;

         Task<bool> SaveChangesAsync();

        //EVENTOS
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrante);
         Task<Evento[]> GetAllEventoAsync(bool includePalestrante);
         Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrante);

        //PALESTRANTES
          Task<Palestrante[]> GetAllPalestranteAsyncByName(string name, bool includeEvento);
           Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEvento);
    }
}