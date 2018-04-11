using System.Collections.Generic;
public class pedidoProducto : pedido{
	private cliente _Cliente;
	private List<ingrediente> _listaProductos;
	private documentoPago _docPago;

	public pedidoProducto(){}

	public pedidoProducto(cliente _Cliente, List<ingrediente> _listaProductos, documentoPago _docPago){
		this._Cliente = _Cliente;
		this._listaProductos = _listaProductos;
		this._docPago = _docPago;
	}

	public pedidoProducto(int _idPedido, estado _estadoPedido, usuario _cuentaUsuario, DateTime _registroPedido, DateTime _entregaPedido, cliente _Cliente, List<ingrediente> _listaProductos, documentoPago _docPago) : base(_idPedido, _estadoPedido, _cuentaUsuario, _registroPedido, _entregaPedido){
		this._Cliente = _Cliente;
		this._listaProductos = _listaProductos;
		this._docPago = _docPago;	
	}

	public cliente Cliente{
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
}