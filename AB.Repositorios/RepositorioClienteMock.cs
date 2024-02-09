using AB.Aplicacion.Entidades;
using AB.Aplicacion.Interfaces;

namespace AB.Repositorios;

public class RepositorioClienteMock : IRepositorioCliente
{

    List<Cliente> _listaClietes = new List<Cliente>();


    static int s_proximoId = 0;

    private Cliente Clonar(Cliente c) //se van a devolver copias de los cliente guardados
    {
        return new Cliente()
        {
            Id = c.Id,
            Nombre = c.Nombre,
            Apellido = c.Apellido
        };
    }
    public void AgregarCliente(Cliente cliente)
    {
        Console.WriteLine("agregar cliente mock");
        cliente.Id = s_proximoId++;
        _listaClietes.Add(cliente);
        Console.WriteLine(_listaClietes.Count() + "cantidad de clientes al agregar ");
    }

    public void EliminarCliente(int id)
    {
        var cliente = _listaClietes.SingleOrDefault(c => c.Id == id);
        if (cliente != null)
        {
            _listaClietes.Remove(cliente);
        }
    }
    public List<Cliente> GetClientes()
    {
        Console.WriteLine("ide prox" + s_proximoId);
        Console.WriteLine("get clientes mock");
        Console.WriteLine(_listaClietes.Count());
        foreach (Cliente c in _listaClietes)
        {
            Console.WriteLine(c.Id);
        }
        return _listaClietes;
    }

    public Cliente? GetCliente(int id)
    {
        Cliente? c = _listaClietes.SingleOrDefault(c => c.Id == id);
        if (c != null)
        {
            return Clonar(c);
        }
        return null;
    }
    public void ModificarCliente(Cliente cliente)
    {
        var cli = _listaClietes.SingleOrDefault(c => c.Id == cliente.Id);
        if (cli != null)
        {
            cli.Apellido = cliente.Apellido;
            cli.Nombre = cliente.Nombre;
        }
    }
}