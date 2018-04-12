import java.util.Date;
import java.text.SimpleDateFormat;
enum estadoPedido{Aprobado,Pendiente,Listo,Cancelado};
public class Pedido{
	private int idPedido;
	private estadoPedido estadoPed;
	//private usuario cuentaUs;
	private Date fechaRegPed;
	private Date fechaEntrPed;
	
	public Pedido(){
		fechaRegPed=new Date();
		fechaEntrPed=new Date();
	}
	
	public Pedido(int idPedido,estadoPedido estadoPed,String fechaRegPed,String fechaEntrPed){
		this.idPedido=idPedido;
		this.estadoPed=estadoPed;
		//this.cuentaUs=cuentaUs;
		
		fechaRegPed=new Date();
		fechaEntrPed=new Date();
		SimpleDateFormat formt1=new SimpleDateFormat("dd/MM/yyyy");
		this.fechaRegPed=formt1.parse(fechaRegPed);
		SimpleDateFormat formt2=new SimpleDateFormat("dd/MM/yyyy");
		this.fechaEntrPed=formt2.parse(fechaEntrPed);
		
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
	
	// public void setcuentaUsPedo(usuario cuentaUs){
		// this.cuentaUs=cuentaUs;
	// }
	// public usuario getcuentaUs(){
		// return this.cuentaUs;
	// }
	
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