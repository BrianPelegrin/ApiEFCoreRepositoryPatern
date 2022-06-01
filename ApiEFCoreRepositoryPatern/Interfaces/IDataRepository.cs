namespace ApiEFCoreRepositoryPatern.Interfaces
{
    //Creacion de la interfaz repositorio

    //La interfaz es generica por lo tanto dentro de "<>" es que se declara el tipo
    //de entidad o Modelo y luego va el DTO o ViewModel
    public interface IDataRepository<TEntity, TDto>
    {

        //NOTA:  Crear Las Clases que Implementaran esta Interfaz
        //llamadas (Nombre del DTO o Entidad) + DataManager
       //para que luego la hereden los controladores 

        // Creacion de los metodos de la interfaz

        //Metodo para devolver todos los Autores
        IEnumerable<TEntity> GetAll();
        //Meto para obtener un Autor
        TEntity Get(long id);

        TDto GetDto(long id);

        //Metodo para agregar un Autor
        void Add(TEntity entity);
        //Metodo que elimina un autor
        void Delete(TEntity entity);
        //Metodo que Actualiza un Autor
        void Update(TEntity entity);
        
    }
}
