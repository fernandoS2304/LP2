using System.Collections.Generic;
public class Panaderia{
	private int idPanaderia;
	private string nombre;
	private string direccion;
	private int telefono;
	private List<CuentaUsuario> _usuarios;
	private List<almacen> _almacenes;
	private List<pedido> _pedidos;
	private List<Cliente> _clientes;
	private List<producto> _productos;
	
	public Panaderia(int idPanaderia, string nombre, string direccion, int telefono){
		this.IdPanaderia = idPanaderia;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
		_usuarios = new List<CuentaUsuario>();
		_almacenes = new List<almacen>();
		_pedidos = new List<pedido>();
		_clientes = new List<Cliente>();
		_productos = new List<Producto>();
	}	
	
	public int IdPanaderia { get => idPanaderia; set => idPanaderia = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<CuentaUsuario> Usuarios { get => _usuarios; set => _usuarios = value; }
    public List<almacen> Almacenes { get => _almacenes; set => _almacenes = value; }
    public List<pedido> Pedidos { get => _pedidos; set => _pedidos = value; }
    public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }
    public List<producto> Productos { get => _productos; set => _productos = value; }
    }
}