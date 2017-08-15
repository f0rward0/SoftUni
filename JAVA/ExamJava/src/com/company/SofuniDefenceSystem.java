package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SofuniDefenceSystem {
    public static void main(String[] args) {


        Scanner scn = new Scanner(System.in);

        String input = scn.nextLine();
        Pattern pat1=Pattern.compile("([A-Z]{1}[a-z]{1,}).*?([A-Z]{1}[A-z]{0,}[A-Z]).*?([0-9]+L).*?");
        double sum=0.0;



        while(!input.equals("OK KoftiShans")){


            Matcher match=pat1.matcher(input);

            while(match.find()) {


                System.out.printf("%s brought %s liters of %s!\n", match.group(1),
                        match.group(3).substring(0,match.group(3).length()-1),match.group(2).toLowerCase());
                sum+=Double.parseDouble(match.group(3).substring(0,match.group(3).length()-1));
            }



            input=scn.nextLine();

        }
        System.out.printf("%.3f softuni liters\n",sum/1000);
    }
}
