

package HW_SOFTUNI_COLLECTIONS;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class Problem14SortArray {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String[] arr=scan.nextLine().split("\\s+");
        int[] digits=new int[arr.length];
        
        for (int i = 0; i < arr.length; i++) {
            digits[i]=Integer.parseInt(arr[i]);
        }
        
        
        
        if (scan.nextLine().equals("Ascending")) {
            Arrays.sort(digits);
            System.out.println(Arrays.toString(digits));
        }else {
            Arrays.sort(digits);
            for(int i = 0; i < digits.length / 2; i++)
            {
                int temp = digits[i];
                digits[i] = digits[digits.length - i - 1];
                digits[digits.length - i - 1] = temp;
            }
           
            System.out.println(Arrays.toString(digits));
           
        }
    }

}
