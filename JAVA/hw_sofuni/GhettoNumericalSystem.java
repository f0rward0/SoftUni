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
public class GhettoNumericalSystem {
    public static void main(String[] args) {
        String n;
        char digits[];
        System.out.println("Enter n");
        
        Scanner scan=new Scanner(System.in);
        n=scan.nextLine();
        digits=n.toCharArray();
        
        
        
        for (char digit : digits) {
            switch (digit) {
                case '0' :
                    System.out.print("Gee");
                    break;
                case '1':
                    System.out.print("Bro");
                    break;
                case '2':
                    System.out.print("Zuz");
                    break;
                case '3':
                    System.out.print("Ma");
                    break;
                case '4':
                    System.out.print("Duh");
                    break;
                case '5':
                    System.out.print("Yo");
                    break;
                case '6':
                    System.out.print("Dis");
                    break;
                case '7':
                    System.out.print("Hood");
                    break;
                case '8':
                    System.out.print("Jam");
                    break;
                default:
                    System.out.print("Mack");
                    break;
            }
        }
        System.out.println("");
        
        
        
    }
    
}
