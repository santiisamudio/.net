using AB.Aplicacion.Entidades;

namespace AB.Aplicacion.Interfaces;

public interface IRepositorioCliente
{
    List<Cliente> GetClientes();

    Cliente? GetCliente(int id);

    void ModificarCliente(Cliente cliente);

    void AgregarCliente(Cliente cliente);

    void EliminarCliente(int id);
}