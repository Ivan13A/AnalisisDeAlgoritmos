package numbersramdom;

import java.util.Random;
import java.util.Scanner;

public class MatrizAleatoria {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        System.out.println("Introduce el tamaño de la matriz");
        int m = sc.nextInt();
        int[][] matriz = new int[m][m];

        Random random = new Random();

        
        long inicioTiempo = System.currentTimeMillis();

        
        llenarMatriz(matriz, random);

        
        long finTiempo = System.currentTimeMillis();

        
//        System.out.println("Matriz:");
//        imprimirMatriz(matriz);

        
        long tiempoEjecucion = finTiempo - inicioTiempo;
        System.out.println("Tiempo de ejecución: " + tiempoEjecucion + " milisegundos");
    }

    
    
    private static void llenarMatriz(int[][] matriz, Random random) {
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[i].length; j++) {
                matriz[i][j] = random.nextInt(100); 
            }
        }
    }

//    private static void imprimirMatriz(int[][] matriz) {
//        for (int[] fila : matriz) {
//            for (int valor : fila) {
//                System.out.print(valor + "\t" ); 
//            }
//            System.out.println(); 
//        }
//    }
}
