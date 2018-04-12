import java.util.ArrayList;

public class Panaderia{
	private int idPanaderia;
	private String nombre;
	private String direccion;
	private int telefono;
	private ArrayList<CuentaUsuario> usuarios;
	private ArrayList<Almacen> almacenes;
	private ArrayList<Insumo> insumos;
	private ArrayList<Cliente> clientes;
	
	public Panaderia(int idPanaderia,String nombre,String direccion,int telefono){
		this.idPanaderia=idPanaderia;
		this.nombre=nombre;
		this.direccion=direccion;
		this.telefono=telefono;
		clientes = new ArrayList<Cliente>();
		usuarios = new ArrayList<CuentaUsuario>();
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
	
	public void setTelefono(int telefono){
		this.telefono=telefono;
	}	
	
	public agregarCliente(Empresa c){
		Cliente t=(Cliente) c;
		clientes.add(t);
	}
	public agregarCliente(Natural c){
		Cliente t=(Cliente) c;
		clientes.add(t);
	}
	public String consultarClientes(int i){
		String cadena="";
		Cliente m;
		ArrayList<Cliente> lClienteAux=lCuenta.get(i).getlCliente();
		System.out.println(lClienteAux.size());
		for (int k=0;k<lClienteAux.size();k++) {
			m = (Cliente) lClienteAux.get(k);
			//System.out.println(m.ConsultarDatos());		
			if (m instanceof PersonaNatural){
					cadena = cadena + ((PersonaNatural)m).ConsultarDatos() + "\n";
				}
			if(m instanceof Empresa){
					cadena = cadena + ((Empresa)m).ConsultarDatos() + "\n";
			}
		}
		return cadena;
	}
	
}
