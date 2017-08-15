
package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class LargestSequenceOfEqualStrings3 {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String[] arr=scan.nextLine().split("\\s+");
        int seqStart=0,longestStart=0;
        int seqEnd = 0,longestEnd=0;
        
        for (int i = 0; i < arr.length; i++) {
            if(i==arr.length-1)
                break;
            if(arr[i].equals(arr[i+1])){
                seqStart=i;
                
            
            
            
                for (int j = i; j < arr.length; j++) {
                    if(j==arr.length-1){
                        if(arr[j].equals(arr[j-1])){
                            seqEnd=j;
                            break;
                                    
                        }
                    }
                    if(!arr[j].equals(arr[j+1])){
                        seqEnd=j;
                        break;
                    }
                    
                }
                
                if (seqEnd-seqStart>longestEnd-longestStart) {
                    longestEnd=seqEnd;
                    longestStart=seqStart;
                    
                }
            }
        }
        for (int i = longestStart; i <= longestEnd; i++) {
            System.out.printf("%s ",arr[i]);
        }
        
    }

}
