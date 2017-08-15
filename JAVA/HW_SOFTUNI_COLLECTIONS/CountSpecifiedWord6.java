

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class CountSpecifiedWord6 {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String[] arr=scan.nextLine().split("[^A-z]+");
        String word=scan.nextLine();
        int count=0;
        
        for (int i = 0; i < arr.length; i++) {
            if(arr[i].toUpperCase().equals(word.toUpperCase()))
                count++;
        }
        
        System.out.println(count);
    }

}
//"(?i)\\"b+word+"\\b"