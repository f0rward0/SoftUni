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
public class Problem11StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        Pattern regex = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b|\\b[A-Z]\\b");
        Matcher match = regex.matcher(line);

        while (match.find()){
            System.out.print(match.group(0) + " ");
        }
        
        
        
    }
    
}
