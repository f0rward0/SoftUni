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
public class Problem12CharacterMultipiler {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String firstString = scan.next();
        String secondString = scan.next();
        Long totalSumOfCharactersMultiplication = multiplyingTheCharacters(firstString, secondString);
        System.out.print(totalSumOfCharactersMultiplication);

    }

    private static Long multiplyingTheCharacters(String firstString, String secondString) {
        Long totalSum =0L;
        for (int i = 0; i < firstString.length() ; i++) {
            totalSum += firstString.charAt(i) * secondString.charAt(i);
        }
        totalSum += calculatingTheRemainder(firstString, secondString);

        return totalSum;
    }

    private static Long calculatingTheRemainder(String firstString, String secondString) {
        Long totalSumOfRemainder = 0L;
        if(firstString.length() > secondString.length()) {
            String remainder = firstString.substring(secondString.length());
            for (int i = 0; i < remainder.length(); i++) {
                totalSumOfRemainder += remainder.charAt(i);
            }
        } else  if(secondString.length() > firstString.length()) {
            String remainder = secondString.substring(firstString.length());
            for (int i = 0; i < remainder.length(); i++) {
                totalSumOfRemainder += remainder.charAt(i);
            }
        }
        return totalSumOfRemainder;
    }
}