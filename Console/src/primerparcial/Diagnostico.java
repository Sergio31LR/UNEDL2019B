package primerparcial;

import java.util.Scanner;

public class Diagnostico {
	int a[][];
	int tamaño=0;
	int di=0;
	int di2=0;
	Scanner sc = new Scanner(System.in);
	public void matriz() {
		System.out.print("Ingrese el tamaño de la matriz ");
		tamaño=sc.nextInt();
		a=new int[tamaño][tamaño];
		
		for(int p=0;p<tamaño;p++) {
			for(int i=0;i<tamaño;i++) {
				System.out.print("Ingrese el valor de la posicion "+p+","+i+" ");
				a[p][i]=sc.nextInt();
			}
		}
		
		for(int p=0;p<tamaño;p++) {
			for(int i=0;i<tamaño;i++) {
				System.out.print(a[p][i]);
			}
			System.out.println();
		}
		//suma de la diagonal principal
		for (int i=0; i<tamaño; i++)
            for (int j=0; j<tamaño; j++){
                if (i == j) {
            di+=a[i][j];
                }
                }
		//suma diagonal secundaria
		 System.out.println();
		 for (int i=tamaño-1; i>=0; i--) {
	            for (int j=0; j<tamaño; j++)
	                if (tamaño-1-i == j) {
	                	di2+=a[i][j];
	                }
	}
		 int result=di-di2;
		 /*if(result<0) {
			 result=result*(-1);
			 System.out.println(result);
		 }else {
			 System.out.println(result);
		 }
		//& System.out.println(di+" "+di2);
	       */
		 System.out.println(Math.abs(result));
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Diagnostico ma = new Diagnostico();
		ma.matriz();
	}

}
