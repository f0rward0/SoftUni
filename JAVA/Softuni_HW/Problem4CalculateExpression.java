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
public class Problem4CalculateExpression {
    
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        double a,b,c;
        a=scan.nextDouble();
        b=scan.nextDouble();
        c=scan.nextDouble();
        
        double formula1=Math.pow((Math.pow(a, 2)+Math.pow(b, 2))/
                (Math.pow(a, 2)-Math.pow(b, 2)),(a+b+c)/Math.sqrt(c));
        
        double formula2=Math.pow((Math.pow(a, 2)+Math.pow(b, 2)-Math.pow(c, 3)),(a-b));
        
        double average=Math.abs(((a+b+c)/3)-((formula1+formula2)/2));
        
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f\n", formula1,formula2,average);
    }
    
}
