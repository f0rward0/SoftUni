import java.util.Scanner;

/**
 * Created by Velkata on 15/11/2015.
 */
public class letterChangeNumbers {
    public static void main(String[] args) {
        Scanner scn=new Scanner(System.in);

        String input[]=scn.nextLine().split("\\s+");
        double digit;
        double sum=0.0;

        for (int i = 0; i < input.length; i++) {
            String s = input[i];
            digit=Integer.parseInt(s.substring(1,s.length()-1));
            char c=s.charAt(0);
            char l=s.charAt(s.length()-1);
            if(c>=65&&c<=90)
            {
                digit/=c-'A'+1;
            }else{
                digit*=c-'a'+1;
            }

            if(l>=65&&l<=90)
            {
                digit-=l-'A'+1;
            }else{
                digit+=l-'a'+1;
            }

            sum+=digit;


        }

        System.out.printf("%.2f",sum);





    }
}
