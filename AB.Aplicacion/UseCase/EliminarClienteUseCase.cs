using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Aplicacion.UseCase;

public class EliminarClienteUseCase : ClienteUseCase
{
    public EliminarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
    {

    }

    public void Ejecutar(int id)
    {
        Repositorio.EliminarCliente(id);
    }
}