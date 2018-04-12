public class Empleado (){
	private int ID;
	private String nombre;
	private Turno turno;

	public void setID(int ID){
	    this.ID=ID;
	}
	
	public int getID(){
	    return ID;
	}
	
	public void setNombre(String nombre){
	    this.nombre=nombre;
	}
	
	public String getNombre(){
	    return nombre;
	}

	public void setTurno(Turno turno){
	 	this.turno=turno;   
	}

	public turno getTurno(){
	    return turno;
	}
	
}