import java.util.*;
public class Principal{
	public static void main(String[] args){
		//Panaderia panaderia = new Panaderia();
		Panaderia p1 = new Panaderia(1,"Rovegno","Calle dona delmira 365",2434234);//Se crea Panaderia
		
		
		Empresa c1 = new Empresa(1,123234,"calle delmira","123","123456789","Empresa Ferraza");
		Natural n1 = new Natural(1,2234234,"Pollard Road","2323423","34234234","Sarai ","Ferraza");
		Natural n2 = new Natural(2,2234235,"HARRINGT Road","23423","34234","Michael ","Ruiz");
		p1.agregarCliente(c1);
		p1.agregarCliente(n1);
		p1.agregarCliente(n2);
		
		//Alumno a1=new Alumno("Diana");
		//Equipo eq = new Equipo();
		// eq.agregarMiembro(p1);
		// eq.agregarMiembro(p2);
		// eq.agregarMiembro(a1);
		// objEquipu.agregarEquipo(eq);
		
		System.out.println(c1.getNombreEmpresa());
		System.out.println(n1.getNombre());
		// String reporte = objEquipu.consultarEquipo(0);
		// System.out.println("reporte2");
		// System.out.println(reporte);
	}
}