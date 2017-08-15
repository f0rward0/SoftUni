import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by Velkata on 15/11/2015.
 */
public class UserLogs {
    public static void main(String[] args) {
        Scanner scn=new Scanner(System.in);

        TreeMap<String,LinkedHashMap<String,Integer>> map=new TreeMap<>();

        String line=scn.nextLine();

        while(!line.equals("end"))
        {
            //IP=192.23.30.40 message='Hello&derps.' user=destroyer
            String[] info=line.split("\\s");

            String ip=info[0];
            ip=new String(ip.replace("IP=",""));
            String msg=info[1];
            msg=new String(msg.replace("message=",""));
            String user=info[2];
            user=new String(user.replace("user=",""));


            if(map.containsKey(user)){
                LinkedHashMap<>
            }







            line=scn.nextLine();

        }






    }
}
