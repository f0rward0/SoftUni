

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Velkata
 */
public class CountSubstringOcc7 {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String str = scan.nextLine();
        String findStr = scan.nextLine();
        
        Pattern p = Pattern.compile("(?i)"+findStr);
        Matcher m = p.matcher(str);
        int count = 0;
        while (m.find()){
            count +=1;
        }
        System.out.println(count);

        
        
    }
}
