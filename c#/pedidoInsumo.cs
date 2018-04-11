using System.Collections.Generic;
public class pedidoInsumo : pedido{
	private List<ingrediente> _listaInsumos;
	private almacen _almacenOrigen;
	private almacen _almacenFin;

	public pedidoInsumo(){}

	public pedidoInsumo(Lista<ingrediente> _listaInsumos, almacen _almacenOrigen, almacen _almacenFin){
		this._listaInsumos = _listaInsumos;
		this._almacenOrigen = _almacenFin;
		this._almacenFin = _almacenFin;
	}

	public pedidoInsumo(int _idPedido, estado _estadoPedido, usuario _cuentaUsuario, DateTime _registroPedido, DateTime _entregaPedido, List<ingrediente> _listaInsumos, almacen _almacenOrigen, almacen _almacenFin) : base(_idPedido, _estadoPedido, _cuentaUsuario, _registroPedido, _entregaPedido){ 
		this._listaInsumos = _listaInsumos;
		this._almacenOrigen = _almacenFin;
		this._almacenFin = _almacenFin;	
	}

	public List<ingrediente> ListaInsumos{
		get{
			return _listaInsumos;
		}
		set{
			_listaInsumos = value;
		}
	}

	public almacen AlmacenOrigen{
		get{
			return _almacenOrigen;
		}
		set{
			_almacenOrigen = value;
		}
	}

	public almacen AlmacenFin{
		get{
			return _almacenFin;
		}
		set{
			_almacenFin = value;
		}
	}
}