using System.Collections.Generic;
public class almacen{
	private int _idAlmacen;
	private string _nombre;
	private List<ingrediente> _stock;

	public almacen(){}

	public almacen(int _idAlmacen, string _nombre){
		this._idAlmacen = _idAlmacen;
		this._nombre = _nombre;
		this._stock = new List<ingrediente>();
	}

	public int IdAlmacen{
		get{
			return _idAlmacen;
		}
		set{
			_idAlmacen = value;
		}
	}

	public string Nombre{
		get{
			return _nombre;
		}
		set{
			_nombre = value;
		}
	}

	public List<ingrediente> Stock{
		get{
			return _stock;
		}
		set{
			_stock = value;
		}
	}
	
	public void reporteInventario(){
	}
	
	public void movimientoDeInsumo(int codInsumo){
	}
}