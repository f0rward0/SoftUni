import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

/**
 *
 * @author Velkata
 */
public class Prob3CountCharacterTypes {
    
    public static void main(String[] args) {
        int vowels=0;
        int consonants=0;
        int punct=0;
        
        String vowelsSymbols = "aeiou";
        String punctuationSymbols = "!.,?";
        
        try(
            BufferedReader fileReader = new BufferedReader(
            new FileReader("words.txt"));
        ) {
            
            while (true) {
              String line = fileReader.readLine();
              if (line == null) break;
              
                char lineArr[]=line.toCharArray();
                
                for (int i = 0; i < lineArr.length; i++) {
                    if(vowelsSymbols.contains(lineArr[i]+"")){
                        vowels++;  
                    }else if(punctuationSymbols.contains(lineArr[i]+"")){
                        punct++;
                    }else if(Character.isLetter(lineArr[i])){
                        consonants++;
                    }
                    
                }
              
              
              
              
            }
          } catch (IOException ioex) {
            System.out.println("Cannot read the file ");
          }
        try ( PrintWriter prw=new PrintWriter(
                    new BufferedWriter(
                            new FileWriter("count-chars.txt")));
                ){
         String bld="Vowels: "+vowels+"\r\nConsonants: "+consonants+"\r\nPunctuation: "+punct;
         prw.write(bld);
            
        } catch (Exception ioex) {
        }
        }

    
}
