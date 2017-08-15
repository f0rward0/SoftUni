package Softuni_HW_3;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

/**
 *
 * @author Velkata
 */
public class Prob1SumLines {
    public static void main(String[] args) {
        try(
  BufferedReader fileReader = new BufferedReader(
    new FileReader("somefile.txt"));
        ) {
            
            
            while (true) {
              int sum=0;
              String line = fileReader.readLine();
              if (line == null) break;
              char lineArr[]=line.toCharArray();
                for (int i = 0; i < lineArr.length; i++) {
                    sum+=(int)lineArr[i];
                    
                }
              
              System.err.println(sum);
            }
          } catch (IOException ioex) {
            System.out.println("Cannot read the file ");
          }

        }

    
}
