public abstract class Cliente{
	private int id_cliente;
	private int telefono;
	private String direccion;
	private String cuentaBancaria;

	public Cliente(int id_cliente, int telefono, String direccion, String cuentaBancaria){
		setId_cliente(id_cliente);
		setTelefono(telefono);
		setDireccion(direccion);
		setCuentaBancaria(cuentaBancaria);
	}

	public Cliente(){
	}

	public void setId_cliente(int id_cliente){
		this.id_cliente=id_cliente;
	}

	public int getId_cliente(){
	    return id_cliente;
	}
	
	public void setTelefono(int telefono){
	    this.telefono=telefono;
	}

	public int getTelefono(){
	    return telefono;
	}
	
	public void setDireccion(String direccion){
	    this.direccion=direccion;
	}
	
	public String getDireccion(){
	    return direccion;
	}

	public void setCuentaBancaria(String cuentaBancaria){
	    this.cuentaBancaria=cuentaBancaria;
	}
	
	public String getCuentaBancaria(){
	    return cuentaBancaria;
	}
	
}