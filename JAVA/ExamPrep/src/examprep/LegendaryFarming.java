

package examprep;

import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

/**
 *
 * @author Velkata
 */
public class LegendaryFarming {
    public static void main(String[] args) {
        Scanner scn=new Scanner(System.in);
        
        int sshard=0;
        int smotes=0;
        int sfrag=0;
        
        int keyItem=0;
        
        TreeMap<String,Integer> keys=new TreeMap<>();
        keys.put("shards", sshard);
        keys.put("motes", smotes);
        keys.put("fragments", sfrag);
        
        TreeMap<String,Integer> junk=new TreeMap<>();
        
        String[] line=scn.nextLine().toLowerCase().split("\\s");
        
        while(true){
            for (int i = 1; i < line.length; i+=2) {
                if(line[i].toLowerCase().equals("shards")){
                   keys.put("shards",sshard+=Integer.parseInt(line[i-1]));
                   if(sshard>=250)
                       break;
                }else if(line[i].toLowerCase().equals("motes")){
                    keys.put("motes",smotes+=Integer.parseInt(line[i-1]));
                    if(smotes>=250)
                       break;
                }else if(line[i].toLowerCase().equals("fragments")){
                    keys.put("fragments",sfrag+=Integer.parseInt(line[i-1]));
                    if(sfrag>=250)
                       break;
                }else{
                    if(junk.containsKey(line[i].toLowerCase())){
                        junk.put(line[i],junk.get(line[i])+Integer.parseInt(line[i-1]));
                    }else{
                        junk.put(line[i].toLowerCase(),Integer.parseInt(line[i-1]));
                    }
                }
            }
            
            if(sshard>=250){
                keys.put("shards",keys.get("shards")-250);
                keyItem=1;
                break;
            }else if(sfrag>=250){
                keys.put("fragments",keys.get("fragments")-250);
                keyItem=2;
                break;
            }else if(smotes>=250){
                keys.put("motes",keys.get("motes")-250);
                keyItem=3;
                break;
            }
            
            
            
            
            
            
            line=scn.nextLine().toLowerCase().split("\\s");
        }
        
        
        if(keyItem==1){
            System.out.println("Shadowmourne obtained!");
        }else if(keyItem==2){
            System.out.println("Valanyr obtained!");
        }else if(keyItem==3){
            System.out.println("Dragonwrath obtained!");
        }
        
        keys.entrySet().stream()
                .sorted((k1, k2) -> k2.getValue().compareTo(k1.getValue()))
                .forEach(k -> System.out.println(k.getKey() + ": " + k.getValue()));
        
        junk.entrySet().forEach(j -> System.out.println(j.getKey() + ": " + j.getValue()));
        
        
      
        
        
    }

}
