public class CuentaUsuario{
	private int idUsuario;
	private String nombreUsuario;
	private String contrasenha;
	private Permiso permise;
	
	public CuentaUsuario(int idUsuario,String nombreUsuario,String contrasenha,Permiso permise){
		this.idUsuario=idUsuario;
		this.nombreUsuario=nombreUsuario;
		this.contrasenha=contrasenha;
		this.permise=permise;
	}
	
	public void setidProducto(int idUsuario){
		this.idUsuario=idUsuario;
	}
	public int getidUsuario(){
		return this.idUsuario;
	}
	
	public void setnombreUsuario(String nombreUsuario){
		this.nombreUsuario=nombreUsuario;
	}
	public String getnombreUsuario(){
		return this.nombreUsuario;
	}
	
	public void setcontrasenha(String contrasenha){
		this.contrasenha=contrasenha;
	}
	public String getcontrasenha(){
		return this.contrasenha;
	}
	
	public void setpermise(Permiso permise){
		this.permise=permise;
	}
	public Permiso getpermise(){
		return this.permise;
	}
	
} 