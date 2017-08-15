

package HW_SOFTUNI_COLLECTIONS;

import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Velkata
 */
public class Problem8ExtractEmails {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        String str = scan.nextLine();
        String finalstr="";
        
        while (!str.equals("")){
            
            finalstr+=str;
            str=scan.nextLine();
        }
        
        Pattern p = Pattern.compile("\\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}\\b",
        Pattern.CASE_INSENSITIVE);
        Matcher m=p.matcher(finalstr);
        
        Set<String> emails = new HashSet<>();
        while(m.find()) {
        emails.add(m.group());
        }
        System.out.printf("%s \n",emails.toString());

    }
}
