using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Aplicacion.UseCase;

public class GetClienteUseCase : ClienteUseCase
{
    public GetClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
    {

    }

    public Cliente? Ejecutar(int id)
    {
        return Repositorio.GetCliente(id);
    }
}