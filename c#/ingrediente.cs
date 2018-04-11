public class ingrediente{
	private float _cantidad;
	private insumo _Insumo;

	public ingrediente(){}

	public ingrediente(float _cantidad, insumo _Insumo){
		this._cantidad = _cantidad;
		this._Insumo = _Insumo;
	}

	public float Catnidad{
		get{
			return _cantidad;
		}
		set{
			_cantidad = value;
		}
	}

	public insumo Insumo{
		get{
			return _Insumo;
		}
		set{
			_Insumo = value;
		}
	}
}