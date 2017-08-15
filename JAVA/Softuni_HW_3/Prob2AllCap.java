package Softuni_HW_3;

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
public class Prob2AllCap {
    
    public static void main(String[] args) {
        String bld=new String();
        try(
            BufferedReader fileReader = new BufferedReader(
            new FileReader("Prob2.txt"));
        ) {
            
            while (true) {
              String line = fileReader.readLine();
              if (line == null) break;
              
              bld+=(line.toUpperCase()+"\r\n");
              System.out.println(line);
              
            }
            System.out.println(bld);
          } catch (IOException ioex) {
            System.out.println("Cannot read the file ");
          }
        try ( PrintWriter prw=new PrintWriter(
                    new BufferedWriter(
                            new FileWriter("Prob2.txt")));
                ){
            prw.write(bld);
            
        } catch (Exception ioex) {
        }
            System.out.println("Cannot write on file ");
        }

    
}
