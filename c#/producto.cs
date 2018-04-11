using System.Collections.Generic;
public class producto{
	private int _idProducto;
	private string _nombreProducto;
	private List<ingrediente> _receta;
	private float _precio;

	public producto(){}

	public producto(int _idProducto, string _nombreProducto, List<ingrediente> _receta, float _precio){
		this._idProducto = _idProducto;
		this._nombreProducto = _nombreProducto;
		this._receta = _receta;
		this._precio = _precio;
	}

	public int IdProducto{
		get{
			return _idProducto;
		}
		set{
			_idProducto = value;
		}
	}

	public string NombreProducto{
		get{
			return _nombreProducto;
		}
		set{
			_nombreProducto = value;
		}
	}

	public List<ingrediente> Receta{
		get{
			return _receta;
		}
		set{
			_receta = value;
		}
	}

	public float Precio{
		get{
			return _precio;
		}
		set{
			_precio = value;
		}
	}
}