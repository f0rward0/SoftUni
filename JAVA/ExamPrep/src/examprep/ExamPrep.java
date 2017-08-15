
package examprep;

import java.util.Scanner;


public class ExamPrep {

    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);
        String input=Console.nextLine();
        
        int helth=5800;
        int glowcaps=0;
        int hasdied=0;
        
        
        char arr[];
        
        while(!input.equals("Sporeggar")){
            
            arr=input.toCharArray();
            
            for (int i = 0; i < arr.length-1; i++) {
                if(arr[i]!='L'){
                    helth-=(int)arr[i];
                }else{
                    helth+=200;
                }

            }
            if (helth<=0) {
                hasdied=1;
                break;
            }else{
                glowcaps+=Integer.parseInt(arr[arr.length-1]+"");
            }
            
            
            
            input=Console.nextLine();
        }
        
        if(hasdied==1){
            System.out.println("Died. Glowcaps: "+glowcaps);
        }else{
            if (glowcaps>=30) {
                System.out.printf("Health left: %d\nBought the sporebat. Glowcaps left: %d",helth,glowcaps-30); 
            }else{
                System.out.printf("Health left: %d\nSafe in Sporeggar, but another %d Glowcaps needed.",helth,30-glowcaps); 
            }
        }
        
        
    }
    
}
