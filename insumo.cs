public class insumo{
	private int _idInsumo;
	private string _descripcion;
	private unidadMedida _unidad;

	public  insumo(){}

	public insumo(int _idInsumo, string _descripcion, unidadMedida _unidad){
		this._idInsumo = _idInsumo;
		this._descripcion = _descripcion;
		this._unidad = _unidad;
	}

	public int IdInsumo{
		get{
			return _idInsumo;
		}
		set{
			_idInsumo = value;
		}
	}

	public string Descripcion{
		get{
			return _descripcion;
		}
		set{
			_descripcion = value;
		}
	}

	public unidadMedida Unidad{
		get{
			return _unidad;
		}
		set{
			_unidad = value;
		}
	}
}