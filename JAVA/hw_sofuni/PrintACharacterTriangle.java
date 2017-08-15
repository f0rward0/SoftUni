/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hw_sofuni;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class PrintACharacterTriangle {
    public static void main(String[] args) {
        int n;
        System.out.println("Enter n");
        Scanner scan=new Scanner(System.in);
        n=scan.nextInt();
        
        
        
        for (int i = 0; i < n-1; i++) {
            char c='a';
            for (int j = 0; j <= i; j++) {
                System.out.print(c+" ");
                c++;
            }
            System.out.println("");
            
            
            
        }
        for (int i = n-1; i >=0; i--) {
            char c='a';
            for (int j = 0; j <= i; j++) {
                System.out.print(c+" ");
                c++;
            }
            System.out.println("");
            
            
            
        }
        
    }
}
