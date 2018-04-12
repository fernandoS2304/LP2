import java.util.Date;
enum estadoPedido{Aprobado,Pendiente,Listo,Cancelado};
public class Pedido{
	private int idPedido;
	private estadoPedido estadoPed;
	private usuario cuentaUs;
	private Date fechaRegPed;
	private Date fechaEntrPed;
	
	public Pedido(){
		fechaRegPed=new Date();
		fechaEntrPed=new Date();
	}
	
	public Almacen(int idPedido,estadoPedido estadoPed,usuario cuentaUs,Date fechaRegPed,Date fechaEntrPed){
		this.idPedido=idPedido;
		this.estadoPed=estadoPed;
		this.cuentaUs=cuentaUs;
		SimpleDateFormat formt=new SimpleDateFormat("dd/MM/yyyy");
		this.fechaRegPed=formt.parse(fechaRegPed);
		SimpleDateFormat formt=new SimpleDateFormat("dd/MM/yyyy");
		this.fechaEntrPed=formt.parse(fechaEntrPed);
		//this.setfechaRegPed(fechaRegPed);
		//this.setfechaEntrPed(fechaEntrPed);
	}
	
	public void setidPedido(int idPedido){
		this.idPedido=idPedido;
	}
	public int getidPedido(){
		return this.idPedido;
	}
	
	public void setestadoPedo(estadoPedido estadoPed){
		this.idPedido=idPedido;
	}
	public estadoPedido getestadoPed(){
		return this.estadoPed;
	}
	
	public void setcuentaUsPedo(usuario cuentaUs){
		this.cuentaUs=cuentaUs;
	}
	public usuario getcuentaUs(){
		return this.cuentaUs;
	}
	
	public void setfechaRegPed(String fechaRegPed)throws Exception{
		SimpleDateFormat formt=new SimpleDateFormat("dd/MM/yyyy");
		this.fechaRegPed=formt.parse(fechaRegPed);
	}
	public Date getfechaRegPed(){
		return this.fechaRegPed;
	}
	
	public void setfechaEntrPed(String fechaEntrPed)throws Exception{
		SimpleDateFormat formt=new SimpleDateFormat("dd/MM/yyyy");
		this.fechaEntrPed=formt.parse(fechaEntrPed);
	}
	public Date getfechaEntrPed(){
		return this.fechaEntrPed;
	}
	
	
}