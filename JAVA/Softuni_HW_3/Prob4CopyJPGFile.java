

package Softuni_HW_3;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;

/**
 *
 * @author Velkata
 */
public class Prob4CopyJPGFile {
    public static void main(String[] args) {
        
        try (BufferedInputStream fis=new BufferedInputStream(
                new FileInputStream("picture.jpg"));
                BufferedOutputStream fos=new BufferedOutputStream(
                    new FileOutputStream("my-copied-picture.jpg"));
            ){
            
            int i;
            while((i=fis.read())!=-1){
                fos.write(i);
            }
            
            
        } catch (Exception e) {
        }
    }

}
