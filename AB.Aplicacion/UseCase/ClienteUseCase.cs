using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Aplicacion.UseCase;

public abstract class ClienteUseCase
{
    protected IRepositorioCliente Repositorio { get; private set; }

    public ClienteUseCase(IRepositorioCliente repositorio)
    {
        this.Repositorio = repositorio;
    }
}