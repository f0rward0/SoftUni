/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Softuni_HW_2;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Velkata
 */
public class Problem10ExtractWords {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String str=scan.nextLine();
        
        Pattern regex = Pattern.compile("[a-zA-Z]+");
        Matcher match = regex.matcher(str);

        while (match.find()){
            System.out.print(match.group(0) + " ");
        }
    }
    
}
