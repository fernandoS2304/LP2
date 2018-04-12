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
		this.idPanaderia = idPanaderia;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
		_usuarios = new List<CuentaUsuario>();
		_almacenes = new List<almacen>();
		_pedidos = new List<pedido>();
		_clientes = new List<Cliente>();
		_productos = new List<producto>();
	}	
	

	public int IdPanaderia{

		set{
			this.idPanaderia = value;
		}
		get{
			return idPanaderia;
		}
	}
		
    public string Nombre{
		set{
			this.nombre = value;
		}
		get{
			return nombre;
		}
	}
	
	public string Direccion{
		set{
			this.direccion = value;
		}
		get{
			return direccion;
		}
	}
		
	public int Telefono{
		set{
			this.telefono = value;
		}
		get{
			return telefono;
		}
	}
	
	public void registrarUsuario(string nombU,string contra){
		
	}
	public void llenarAlmacen(string nombAlmacen){
				
	}
	public void ingresarPedidoProducto(int codigoProducto,int cantidad){
		
	}
	public void ingresarPedidoInsumos(int insumo,int cantidad){
		
	}
	
	public void imprimirDocPago(){
		
	}
}