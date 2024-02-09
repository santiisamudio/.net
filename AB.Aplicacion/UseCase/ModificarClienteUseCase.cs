using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Aplicacion.UseCase;

public class ModificarClienteUseCase : ClienteUseCase
{
    public ModificarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
    {

    }

    public void Ejecutar(Cliente cliente)
    {
        Repositorio.ModificarCliente(cliente);
    }
}