using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Aplicacion.UseCase;

public class AgregarClienteUseCase : ClienteUseCase
{
    public AgregarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio)
    {

    }

    public void Ejecutar(Cliente cliente)
    {
        Console.WriteLine("agregarcliente use case");
        Repositorio.AgregarCliente(cliente);
    }
}