

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class CountAllWords5 {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String[] arr=scan.nextLine().split("[^A-z]+");
        
        System.out.println(arr.length);
    }
    
   

}
