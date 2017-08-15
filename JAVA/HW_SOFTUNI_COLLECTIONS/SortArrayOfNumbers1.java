package HW_SOFTUNI_COLLECTIONS;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class SortArrayOfNumbers1 {
    public static void main(String[] args) {
        int n;
        Scanner scan=new Scanner(System.in);
        n=scan.nextInt();
        
        
        int[] arr=new int[n];
        
        for (int i = 0; i < n; i++) {
            arr[i]=scan.nextInt();
            
        }
        Arrays.sort(arr);
        
        System.out.println(Arrays.toString(arr));
    }

}
