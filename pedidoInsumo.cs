using System.Collections.Generic;
using System;
public class pedidoInsumo : pedido{
	private List<ingrediente> _listaInsumos;
	private almacen _almacenOrigen;
	private almacen _almacenFin;

	public pedidoInsumo(){}

	public pedidoInsumo(almacen _almacenOrigen, almacen _almacenFin){
		this._listaInsumos = new List<ingrediente>();
		this._almacenOrigen = _almacenFin;
		this._almacenFin = _almacenFin;
	}

	public pedidoInsumo(int _idPedido, estado _estadoPedido, CuentaUsuario _cuentaUsuario, DateTime _registroPedido, DateTime _entregaPedido, almacen _almacenOrigen, almacen _almacenFin) : base(_idPedido, _estadoPedido, _cuentaUsuario, _registroPedido, _entregaPedido){ 
		this._listaInsumos = new List<ingrediente>();
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
	
	public void realizarPedidoInsumo(int codInsumo,int cant){
	}
}