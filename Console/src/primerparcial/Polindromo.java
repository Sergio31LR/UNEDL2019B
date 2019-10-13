package primerparcial;

import java.util.Scanner;

public class Polindromo {
	
	Scanner sc = new Scanner(System.in);
	String frase;
	String frase2="";
	public void haciendoAlgo() {
		System.out.println("Ingrese una frase ");
		frase=sc.nextLine();
		System.out.println();
		frase=frase.replace(" ", "");
        frase=frase.replace(",", "");
        frase=frase.replace(".", "");
		System.out.println(frase);
		
		for(int p=frase.length()-1;p>=0;p--) {
			System.out.println(frase.charAt(p));
			frase2+=frase.charAt(p);
		}
		if(frase.equals(frase2)) {
			System.out.println("ES polindroma");
		}else {
			System.out.println("No es polindroma");
		}
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Polindromo f = new Polindromo();
		f.haciendoAlgo();
	}

}
