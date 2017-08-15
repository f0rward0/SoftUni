/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hw_sofuni;

import java.text.DecimalFormat;
import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class GetAverage {
    public static void main(String[] args) {
        double a,b,c;
        
        Scanner scanner=new Scanner(System.in);
        System.out.println("Enter first: ");
        a=scanner.nextDouble();
        System.out.println("Enter second: ");
        b=scanner.nextDouble();
        System.out.println("Enter third: ");
        c=scanner.nextDouble();
        
        double average=Average(a, b, c);
        DecimalFormat df = new DecimalFormat("####0.00");
        System.out.println("value:"+df.format(average));
        
        //System.out.println(Average();
        
    }
    public static double Average(double a,double b,double c){
        
        double average=(a+b+c)/3;

        return average;
    }
    
    
}
