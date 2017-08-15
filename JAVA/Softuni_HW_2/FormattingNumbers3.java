/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Softuni_HW_2;


import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class FormattingNumbers3 {
    public static void main(String[] args) {
        
       Scanner scan=new Scanner(System.in);
       int a=scan.nextInt();
       double b=scan.nextDouble();
       double c=scan.nextDouble();
       
       String str=String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
       
       
       System.out.printf("|%-10x|%-10s|%10.2f|%-10.3f|", a,str, b,c);
        
        
    }
}
