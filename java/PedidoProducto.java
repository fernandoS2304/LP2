public class PedidoProducto extends Pedido{
	private Cliente cliente;
	private ProductoPedido prodPed;
	private DocumentoPago documPago;
	
	public PedidoProducto(Cliente cliente,ProductoPedido prodPed,DocumentoPago documPago){
		this.cliente=cliente;
		this.prodPed=prodPed;
		this.documPago=documPago;
	}
	
	public void setcliente(Cliente cliente){
		this.cliente=cliente;
	}
	public Cliente getcliente(){
		return this.cliente;		
	}
	
	public void setprodPed(ProductoPedido prodPed){
		this.prodPed=prodPed;
	}
	public ProductoPedido getprodPed(){
		return this.prodPed;		
	}
	
	public void setdocumPago(DocumentoPago documPago){
		this.documPago=documPago;
	}
	public DocumentoPago getdocumPago(){
		return this.documPago;		
	}
	
	
}