

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class Problem16CalculateNfact {
    public static void main(String[] args) {
        Scanner scan= new Scanner(System.in);
        
        int N=scan.nextInt();
        int stop=N;
        
        for (int i = 1; i < stop; i++) {
            N=N*i;
        }
        if(N==0)
            System.out.println(1);
        else
            System.out.println(N);
            
    }
        
        
}
