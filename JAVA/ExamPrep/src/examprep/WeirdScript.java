package examprep;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class WeirdScript {
    
    public static void main(String[] args) {


        Scanner scn=new Scanner(System.in);
        int n=scn.nextInt();
        String input=scn.nextLine();

        char ch=0;
        String key="";
        StringBuilder sb=new StringBuilder();
        n=n-1;
        int charCode=n%26;
        
        if((n/26)%2==0){
            ch=(char)('a' + charCode);
        }else{
           ch=Character.toUpperCase((char)('a' + charCode));
            
        }
        key=""+ch+ch;
        while(!input.equals("End")){
            sb.append(input);
            input=scn.nextLine();
        }
        
        String message=sb.toString();
        String pattern = key + "(.*?)" + key;
        Pattern pat = Pattern.compile(pattern);
        Matcher match = pat.matcher(message);
        
        while (match.find()) {
            if (match.group(1).length() > 0) {
                System.out.println(match.group(1));
            }
        }
        
    }
    
    

}
