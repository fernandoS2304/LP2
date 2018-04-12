using System.Collections.Generic;
using System;
public class pedidoProducto : pedido{
	private Cliente _Cliente;
	private List<ingrediente> _listaProductos;
	private documentoPago _docPago;

	public pedidoProducto(){}

	public pedidoProducto(Cliente _Cliente, documentoPago _docPago){
		this._Cliente = _Cliente;
		this._listaProductos = new List<ingrediente>();
		this._docPago = _docPago;
	}

	public pedidoProducto(int _idPedido, estado _estadoPedido, CuentaUsuario _cuentaUsuario, DateTime _registroPedido, DateTime _entregaPedido, Cliente _Cliente, documentoPago _docPago) : base(_idPedido, _estadoPedido, _cuentaUsuario, _registroPedido, _entregaPedido){
		this._Cliente = _Cliente;
		this._listaProductos = new List<ingrediente>();
		this._docPago = _docPago;	
	}

	public Cliente Cliente{
		get{
			return _Cliente;
		}
		set{
			_Cliente = value;
		}
	}

	public List<ingrediente> ListaProductos{
		get{
			return _listaProductos;
		}
		set{
			_listaProductos = value;
		}
	}

	public documentoPago DocPago{
		get{
			return _docPago;
		}
		set{
			_docPago = value;
		}
	}
	
	public void RealizarPedidoProducto(int codProd,int cant){
	}
	
	public int subtotal(){
		//solo para que úeda compilar
		return 0;
	}
	
	public void registrarDocPago(){
	}
	
	public void imprimirDocPago(){
		
	}
}