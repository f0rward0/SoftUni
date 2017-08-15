package com.company;

import java.util.Scanner;

/**
 * Created by Velkata on 12.11.2015 г..
 */
public class main {
    public static void main(String[] args) {
        rational x=null;
        rational y=null;
        rational z=null;

        int n=0,d=1;

        boolean valid;

        Scanner scn= new Scanner(System.in);

        valid=false;

        while (!valid){
            try{
                int xx=0;
                System.out.printf("res= "+(5/xx));
            }catch (Exception ex){
                System.out.println("Error"+ex);
            }
        }


    }
}
