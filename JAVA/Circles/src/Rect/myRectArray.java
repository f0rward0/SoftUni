

package Rect;

import java.util.Random;

/**
 *
 * @author Velkata
 */
public class myRectArray {
    public static void main(String[] args) {
        Rect[] arr=new Rect[10];
        Random rand=new Random();
        
        for (int i = 0; i < 10; i++) {
            arr[i].a=rand.nextDouble()*500;
            arr[i].b=rand.nextDouble()*300;
        }
    }


  

}
