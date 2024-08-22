
package javaapplication1;

import java.util.Scanner;

public class NumerosAmigos {
    public static void main(String[] args) {
        //para capturar el tiempo de ejecucion
         long startTime = System.nanoTime();
         
        Scanner scanner = new Scanner(System.in);

        
        System.out.print("Introduce el primer numero: ");
        int numero1 = scanner.nextInt();
        System.out.print("Introduce el segundo numero: ");
        int numero2 = scanner.nextInt();

        
        int sumaDivisores1 = sumaDivisores(numero1);
        int sumaDivisores2 = sumaDivisores(numero2);

        long endTime = System.nanoTime();
        
        long duration = endTime - startTime;
        System.out.println("Tiempo de ejecución: " + duration + " nanosegundos");
        
        if (sumaDivisores1 == numero2 && sumaDivisores2 == numero1) {
            System.out.println(numero1 + " y " + numero2 + " son numeros amigos.");
        } else { 
            System.out.println(numero1 + " y " + numero2 + " no son numeros amigos.");
        }

        System.out.println(sumaDivisores1);
        System.out.println(sumaDivisores2);
    }
    
   
    public static int sumaDivisores(int numero1) {
        int suma = 0;
        for (int i = 1; i <= numero1 / 2 ; i++) {
            if (numero1 % i == 0) {
                suma += i;
            }
        }
        return suma;
        
    }
}