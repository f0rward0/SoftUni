/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Softuni_HW_2;

import static java.lang.Math.abs;
import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class TriangleArea2 {
    public static void main(String[] args) {
        int[] arr=new int[6];
        Scanner scan=new Scanner(System.in);
        
        for (int i = 0; i < arr.length; i++) {
            arr[i]=scan.nextInt();
        }
        
        int area=abs(arr[0]*(arr[3]-arr[5])+arr[2]*(arr[5]-arr[1])+arr[4]*(arr[1]-arr[3]))/2;
        System.out.println(area);
    }
}
