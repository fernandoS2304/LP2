using System;

public class pedido{
	private int _idPedido;
	private estado _estadoPedido;
	private CuentaUsuario _cuentaUsuario;
	private DateTime _registroPedido;
	private DateTime _entregaPedido;

	public pedido(){}

	public pedido(int _idPedido, estado _estadoPedido, CuentaUsuario _cuentaUsuario, DateTime _registroPedido, DateTime _entregaPedido){
		this._idPedido = _idPedido;
		this._estadoPedido = _estadoPedido;
		this._cuentaUsuario = _cuentaUsuario;
		this._registroPedido = _registroPedido;
		this._entregaPedido = _entregaPedido;
	}

	public int IdPedido{
		get{
			return _idPedido;
		}
		set{
			_idPedido = value;
		}
	}

	public estado EstadoPedido{
		get{
			return _estadoPedido;
		}
		set{
			_estadoPedido = value;
		}
	}

	public CuentaUsuario CuentaUsuer{
		get{
			return _cuentaUsuario;
		}
		set{
			_cuentaUsuario = value;
		}
	}

	public DateTime RegistroPedido{
		get{
			return _registroPedido;
		}
		set{
			_registroPedido = value;
		}
	}

	public DateTime EntregaPedido{
		get{
			return _entregaPedido;
		}
		set{
			_entregaPedido = value;
		}
	}	
}