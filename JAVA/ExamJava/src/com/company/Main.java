package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scn=new Scanner(System.in);
        int people=scn.nextInt();

        int linesN=scn.nextInt();
        int beds=0;
        int meals=0;
        scn.nextLine();

        String[] input;

        for (int i = 0; i < linesN; i++) {
            input=scn.nextLine().split("\\s");

            if(input[0].equals("tents")){
                if(input[2].equals("normal")){
                    beds+=2*Integer.parseInt(input[1]);
                }else{
                    beds+=3*Integer.parseInt(input[1]);
                }
            }else if(input[0].equals("rooms")) {
                if (input[2].equals("single")) {
                    beds += Integer.parseInt(input[1]);
                } else if (input[2].equals("double")) {
                    beds += 2 * Integer.parseInt(input[1]);
                } else {
                    beds += 3 * Integer.parseInt(input[1]);
                }
            }

            if(input[0].equals("food")){
                if(input[2].equals("musaka")){
                    meals+=2*Integer.parseInt(input[1]);
                }
            }

        }

        if(beds>=people)
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n",beds-people);
        else
            System.out.printf("Some people are freezing cold. Beds needed: %d\n",people-beds);

        if (meals>=people)
            System.out.printf("Nobody left hungry. Meals left: %d\n",meals-people);
        else
            System.out.printf("People are starving. Meals needed: %d\n",people-meals);



    }
}
