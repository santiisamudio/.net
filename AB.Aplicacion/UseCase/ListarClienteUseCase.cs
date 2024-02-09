using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Aplicacion.UseCase;

public class ListarClientesUseCase : ClienteUseCase
{
    public ListarClientesUseCase(IRepositorioCliente repositorio) : base(repositorio)
    {

    }

    public List<Cliente> Ejecutar()
    {
        return Repositorio.GetClientes();
    }
}