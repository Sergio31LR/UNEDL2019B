package primerparcial;

public class Calculadora {
	Habitacion habitacion1;
	Tapiz tapiz1;
	float costofinal;
	float cantidadM2;
	float metrostotales;
	public void obtenerprecio() {
		 cantidadM2=habitacion1.ancho*habitacion1.largo;
		 costofinal=cantidadM2*tapiz1.costoM2;
	}
	
	public float getcostofinal() {
		return costofinal;
	}

}
