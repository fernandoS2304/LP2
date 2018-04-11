public class documentoPago{
	private string _idDoc;
	private tipoDocPago _docPago;
	private float _total;
	private int _idPedido;
	private Cliente _Cliente;
	private bool _registrada;

	public documentoPago(){}

	public documentoPago(string _idDoc, tipoDocPago _docPago, float _total, int _idPedido, Cliente _Cliente, bool _registrada){
		this._idDoc = _idDoc;
		this._docPago = _docPago;
		this._total =  _total;
		this._idPedido = _idPedido;
		this._Cliente = _Cliente;
		this._registrada = _registrada;
	}

	public string IdDoc{
		get{
			return _idDoc;
		}
		set{
			_idDoc = value;
		}
	}

	public tipoDocPago DocPago{
		get{
			return _docPago;
		}
		set{
			_docPago = value;
		}
	}

	public float Total{
		get{
			return _total;
		}
		set{
			_total = value;
		}
	}

	public int IdPedido{
		get{
			return _idPedido;
		}
		set{
			_idPedido = value;
		}
	}

	public Cliente Client{
		get{
			return _Cliente;
		}
		set{
			_Cliente = value;
		}
	}

	public bool Registrada{
		get{
			return _registrada;
		}
		set{
			_registrada = value;
		}
	}

}