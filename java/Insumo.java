enum unidadMed{kg,lt,cajas,unid};
public class Insumo{
	private int idInsumo;
	private String descripcion;
	private unidadMed unidMed;
	
	public Almacen(int idInsumo,String descripcion,unidMed unidadMed){
		this.idInsumo=idInsumo;
		this.descripcion=descripcion;
		this.unidadMed=unidadMed;
	}
	
	public void setidInsumo(int idInsumo){
		this.idInsumo=idInsumo;
	}
	public int getidInsumo(){
		return this.idInsumo;
	}
	
	public void setdescripcionm(String descripcion){
		this.descripcion=descripcion;
	}
	public String getdescripcion(){
		return this.descripcion;
	}
	
	public void setunidMed(unidadMed unidMed){
		this.unidMed=unidMed;
	}
	public unidadMed getunidMed(){
		return this.unidMed;
	}
	
}