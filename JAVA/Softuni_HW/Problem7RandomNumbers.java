/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Softuni_HW_2;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.List;

/**
 *
 * @author Velkata
 */
public class Problem7RandomNumbers {
    public static void main(String[] args) {
        int n,m;
        Scanner scan=new Scanner(System.in);
        n=scan.nextInt();
        m=scan.nextInt();
        
        int max,min;
        if(n>m){
            max=n;
            min=m;
        }else{
            max=m;
            min=n;
        }
        
        ArrayList<Integer> list =new ArrayList<Integer>();
        for(int i=min;i<=max;i++){
            list.add(i);
        }
        Collections.shuffle(list);
        
        
        
        System.out.println(list);
        
        
    }
    
}
