enum TipoDocPago{Boleta,Factura};
public class DocumentoPago{
	private String idDoc;
	private TipoDocPago tipoDocPago;
	private float total;
	
	private int idPedido;
	
	private Cliente cliente;
	private boolean registrada;
	
	public DocumentoPago(String idDoc,TipoDocPago tipoDocPago,float total,int idPedido,Cliente cliente,boolean registrada){
		this.idDoc=idDoc;
		this.tipoDocPago=tipoDocPago;
		this.total=total;
		this.idPedido=idPedido;
		this.cliente=cliente;
		this.registrada=registrada;
	}
	
	public void setidDoc(String idDoc){
		this.idDoc=idDoc;
	}
	public String getidDoc(){
		return this.idDoc;
	}
	
    public void setEstadoPedido(TipoDocPago tipoDocPago) {
        this.tipoDocPago = tipoDocPago;
    }
	
	public TipoDocPago gettipoDocPago() {
        return tipoDocPago;
    }
	public void settotal(float total){
		this.total=total;
	}
	public float gettotal(){
		return this.total;		
	}
	public void setidPedido(int idPedido){
		//this.idPedido=idPedido;
	}
	public int getidPedido(){
		return this.idPedido;		
	}
	
	public void setcliente(Cliente cliente){
		this.cliente=cliente;
	}
	public Cliente getcliente(){
		return this.cliente;		
	}
	
	public void setregistrada(boolean registrada){
		this.registrada=registrada;
	}
	public boolean getregistrada(){
		return this.registrada;		
	}
	
	public void imprimirDocPago(){

	}

}