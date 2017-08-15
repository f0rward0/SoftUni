

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class Problem13FilterArray {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String[] strar=scan.nextLine().split("\\s");
        
        for (String string : strar) {
            
            if(string.length()>3){
                System.out.printf("%s ", string);
            }
                
        }
        System.out.println("");
        
    }

}
