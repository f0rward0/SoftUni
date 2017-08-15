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
public class problem5ConvertToBase7 {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String str=scan.nextLine();
        int n=Integer.parseInt(str);
        
        String b7=Integer.toString(n,7);
        
        System.out.println(b7);
        
        
    }
    
}
