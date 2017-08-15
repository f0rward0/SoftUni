package com.company;

import java.util.Locale;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Locale.setDefault(new Locale("en", "US"));
	    Scanner scn=new Scanner(System.in);
        double D=scn.nextDouble();
        scn.nextLine();
        double heidanHP=3000000d;
        int playerHP=18500;
        String spell="sa";

        int iteractions= heidanHP%D==0?(int)(heidanHP/D):(int)(heidanHP/D)+1;
        int[][] arr=new int[15][15];

        int px=7;
        int py=7;




        for (int i = 0; i <iteractions; i++) {
            heidanHP -= D;
            if (heidanHP <= 0)
                break;

            String[] spells = scn.nextLine().split(" ");
            int x, y;
            x = Integer.parseInt(spells[1]);
            y = Integer.parseInt(spells[2]);




            if(spells[0].equals("Cloud")){
                arr[x][y]=2;
                arr[Math.min((x+1),14)][y]=2;
                arr[Math.max((x-1),0)][y]=2;

                arr[x][Math.max(y-1,0)]=2;
                arr[Math.min((x+1),14)][Math.max(y-1,0)]=2;
                arr[Math.max((x-1),0)][Math.max(y-1,0)]=2;

                arr[x][Math.max(y+1,0)]=2;
                arr[Math.min((x+1),14)][Math.min(y+1,14)]=2;
                arr[Math.max((x-1),0)][Math.max(y+1,14)]=2;



            }else{







                arr[x][y]=-1;
                arr[Math.min((x+1),14)][y]=-1;
                arr[Math.max((x-1),0)][y]=-1;

                arr[x][Math.max(y-1,0)]=-1;
                arr[Math.min((x+1),14)][Math.max(y-1,0)]=-1;
                arr[Math.max((x-1),0)][Math.max(y-1,0)]=-1;

                arr[x][Math.max(y+1,0)]=-1;
                arr[Math.min((x+1),14)][Math.min(y+1,14)]=-1;
                arr[Math.max((x-1),0)][Math.max(y+1,14)]=-1;
            }


            if(arr[px][py]!=0){
                if(py!=0&&arr[px][py-1]==0){
                    py--;
                }else if(px!=14&&arr[px+1][py]==0){
                    px++;
                }else if (py!=14&&arr[px][py+1]==0){
                    py++;
                }else if(px!=0&&arr[px-1][py]==0){
                    px--;
                }else{
                    if(arr[px][py]==-1){
                        playerHP-=6000;
                        if(playerHP<=0) {
                            spell = "Eruption";
                            break;
                        }
                    }else if(arr[px][py]==2){
                        playerHP-=3500;
                        if(playerHP<=0) {
                            spell = "Plague Cloud";
                            break;
                        }
                    }
                }
            }

            cleanMatrix(arr);


        }
        if(heidanHP<=0){
            System.out.println("Heigan: Defeated!");
        }else{
            System.out.printf("Heigan: %.2f\n",heidanHP);
        }

        if(playerHP<=0){
            System.out.println("Player: Killed by "+spell);
        }else
            System.out.printf("Player: %.2f\n",playerHP);

        System.out.println("Final position: "+px+", "+py);

    }


    public static void cleanMatrix(int[][] arr){
        for (int i = 0; i < 15; i++) {
            for (int j = 0; j < 15 ; j++) {
                if(arr[i][j]==2)
                    arr[i][j]=1;
                else
                    arr[i][j]=0;
            }

        }
    }
}
