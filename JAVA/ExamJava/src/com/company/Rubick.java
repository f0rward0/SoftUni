package com.company;

import java.util.Scanner;


public class Rubick {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        String[] size = scn.nextLine().split("\\s");
        int rows = Integer.parseInt(size[0]);
        int cols = Integer.parseInt(size[1]);

        int[][] matrix = new int[rows][cols];
        int itar = 1;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i][j] = itar++;
            }

        }

        int ComN = scn.nextInt();
        scn.nextLine();


            for (int i = 0; i < ComN; i++) {
                String[] arg = scn.nextLine().split("\\s");
                int curr = Integer.parseInt(arg[0]);
                String direction = arg[1];
                int times = Integer.parseInt(arg[2]);

            if (direction.equals("up")) {
                for (int j = 0; j < times; j++) {
                    int first = matrix[0][curr];
                    for (int g = 0; g < rows - 1; g++) {
                        matrix[g][curr] = matrix[g + 1][curr];
                    }
                    matrix[rows - 1][curr] = first;
                }
            } else if (direction.equals("down")) {
                for (int j = 0; j < times; j++) {
                    int last = matrix[rows - 1][curr];
                    for (int g = rows - 1; g > 0; g--) {
                        matrix[g][curr] = matrix[g - 1][curr];
                    }
                    matrix[0][curr] = last;
                }
            } else if (direction.equals("right")) {
                for (int j = 0; j < times; j++) {
                    int last = matrix[curr][cols - 1];
                    for (int g = cols - 1; g > 0; g--) {
                        matrix[curr][g] = matrix[curr][g - 1];
                    }
                    matrix[curr][0] = last;
                }
            } else {
                for (int j = 0; j < times; j++) {
                    int first = matrix[curr][0];
                    for (int g = 0; g < cols - 1; g++) {
                        matrix[curr][g] = matrix[curr][g + 1];
                    }
                    matrix[curr][cols - 1] = first;
                }
            }
        }




//            for (int k = 0; k < rows; k++) {
//                for (int j = 0; j < cols; j++) {
//                    System.out.print(matrix[k][j]+" ");
//                }
//                System.out.println();
//            }
//
//
//            System.out.println();


        StringBuilder sb=new StringBuilder();


        int counter = 1;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i][j] != counter) {
                    for (int g = i; g < rows; g++) {
                        for (int k = 0; k < cols; k++) {
                            if (matrix[g][k] == counter) {
                                //System.out.printf("Swap (%d, %d) with (%d, %d)\n", i, j, g, k);
                                sb.append("Swap ("+i+", "+j+") with ("+g+", "+k+")\n" );
                                int temp = matrix[i][j];
                                matrix[i][j] = matrix[g][k];
                                matrix[g][k] = temp;
                                break;
                            }
                        }
                    }
                } else {
                    //System.out.println("No swap required");
                    sb.append("No swap required\n");
                }
                counter++;
            }
        }
        System.out.println(sb.toString());

    }

    //public static void swap(int[][] matrix,int rolls,int cols){


    //}



}
