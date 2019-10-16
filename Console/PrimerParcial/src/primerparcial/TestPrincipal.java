package primerparcial;

import java.util.Scanner;

public class TestPrincipal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		Calculadora calculadora1=new Calculadora();
		Tapiz tapiz1=new Tapiz();
		Habitacion habitacion1 = new Habitacion();
		
		System.out.print("Ingrese el ancho de la habitacion ");
		habitacion1.setancho(sc.nextFloat());
		while(habitacion1.getancho()<0) {
			System.out.print("Ingrese el ancho de la habitacion ");
			habitacion1.setancho(sc.nextFloat());
		}
		System.out.print("Ingrese el largo de la habitacion ");
		habitacion1.setlargo(sc.nextFloat());
		while(habitacion1.getlargo()<0) {
			System.out.print("Ingrese el largo de la habitacion ");
			habitacion1.setlargo(sc.nextFloat());	
		}
		
		System.out.print("Ingrese el costo por metro cuadrado ");
		tapiz1.setcostoM2(sc.nextFloat());
		while(tapiz1.getcostoM2()<0) {
			System.out.print("Ingrese el costo por metro cuadrado ");
			tapiz1.setcostoM2(sc.nextFloat());		
		}
		calculadora1.tapiz1=tapiz1;
		calculadora1.habitacion1=habitacion1;
		calculadora1.obtenerprecio();
		System.out.println("EL costo de la tapizacion por es un total de "+String.format("%.2f",calculadora1.getcostofinal()));
		
		
	
		
	}

}
