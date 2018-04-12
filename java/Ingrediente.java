public class Ingrediente{
	private int cantidad;
	private Insumo insumo;
	
	public Almacen(int cantidad,Insumo insumo){
		this.cantidad=cantidad;
		this.insumo=insumo;
	}
	
	public void setcantidad(int cantidad){
		this.cantidad=cantidad;
	}
	public int getcantidad(){
		return this.cantidad;
	}
		
	public void setinsumo(Insumo insumo){
		this.insumo=insumo;
	}
	public Insumo getinsumo(){
		return this.insumo;
	}
	
}