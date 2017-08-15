

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class SequenceOfEqualStrings2 {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String[] arr=scan.nextLine().split("\\s+");
        
        for (int i = 0; i < arr.length; i++) {
            if(i==arr.length-1){
                if(arr[i].equals(arr[i-1])){
                    System.out.print(arr[i]);
                    break;
                }else{
                    System.out.println(arr[i]);
                    break;
                }
            }
            
            System.out.printf("%s ",arr[i]);
            if(!arr[i].equals(arr[i+1]))
                System.out.println();
            
        }
        
        
    }

}
