/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Softuni_HW_2;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class Problem13GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        List<Integer> numbers = new ArrayList<>();
        fillingTheListWithNumbers(scan, numbers);
        String[] commands = scan.nextLine().split(" ");
        executingCommand(commands, numbers);
    }

    private static void executingCommand(String[] commands, List<Integer> numbers) {
        String evenOrOdd = commands[2];
        int amountOfNumbers = Integer.parseInt(commands[1]);
        switch (evenOrOdd) {
            case "even": gettingFirstEvenNumbers(amountOfNumbers, numbers);
                break;
            case "odd": gettingFirstOddNumbers(amountOfNumbers, numbers);
                break;
            default: System.out.println("Invalid command");
                break;

        }
    }
    private static void gettingFirstOddNumbers(int amountOfNumbers, List<Integer> numbers) {
        int counter =0;
        for (int i = 0; i < numbers.size(); i++) {
            if(numbers.get(i) % 2 == 1) {
                System.out.print(numbers.get(i) + " ");
                counter++;
            }
            if(counter >= amountOfNumbers) {
                break;
            }
        }
    }

    private static void gettingFirstEvenNumbers(int amountOfNumbers, List<Integer> numbers) {
        int counter =0;
        for (int i = 0; i < numbers.size(); i++) {
            if(numbers.get(i) % 2 == 0) {
                System.out.print(numbers.get(i) + " ");
                counter++;
            }
            if(counter >= amountOfNumbers) {
                break;
            }
        }
    }


    private static void fillingTheListWithNumbers(Scanner scanner, List<Integer> numbers) {
        String[] input = scanner.nextLine().split(" ");
        for (int i = 0; i < input.length; i++) {
            numbers.add(Integer.parseInt(input[i]));
        }
    }
}