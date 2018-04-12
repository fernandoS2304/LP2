import java.util.ArrayList

public class Panaderia{
	private int idPanaderia;
	private String nombre;
	private String direccion;
	private int telefono;
	private ArrayList<CuentaUsario> usuarios;
	private ArrayList<Almacen> almacenes;
	private ArrayList<Insumo> insumos;
	private ArrayList<cliente> clientes;
	
	public Panaderia(int idPanaderia,String nombre,String direccion,int telefono){
		this.idPanaderia=idPanaderia;
		this.nombre=nombre;
		this.direccion=direccion;
		this.telefono=telefono;
		clientes = new ArrayList<Cliente>();
		usarios = new ArrayList<CuentaUsario>();
		almacenes = new ArrayList<Almacen>();
		insumos = new ArrayList<Insumo>();
	}
	
	public int getidPanaderia(){
		return idPanaderia; 
	}
	
	public void setidPanaderia(int idPanaderia){
		this.idPanaderia=idPanaderia;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public void setNombre(String nombre){
		this.nombre=nombre;
	}
	
	public String getDireccion(){
		return direccion;
	}
	
	public void setDireccion(String direccion){
		this.direccion=direccion;
	}
	
	public int getTelefono(){
		return telefono;
	}
	
	public int setTelefono(int telefono){
		this.telefono=telefono;
	}
	
	
	
}
