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
public class SumNumbersFromOneToN {
    public static void main(String[] args) {
         
        int n;
        System.out.println("Enter n");
        Scanner scan=new Scanner(System.in);
        n=scan.nextInt();
        int sum=0;
        
        for (int i = 0; i <= n; i++) {
            sum+=i;
        }
        System.out.println(sum);
        
    }
    
}
