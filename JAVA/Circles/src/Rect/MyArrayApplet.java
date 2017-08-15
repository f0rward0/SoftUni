

package Rect;

import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;
import javax.swing.JApplet;

/**
 *
 * @author Velkata
 */
public class MyArrayApplet extends JApplet {
    Rect[] arr=new Rect[10];
    
    public void paint(Graphics g){
        Random rand=new Random();
        int a,b,place;
        a=(int)rand.nextDouble()*20;
        b=(int)rand.nextDouble()*30;
        place=(int)rand.nextDouble()*25;
        
        for (int i = 0; i < 10; i++) {
           g.fillRect(a, b, place, place);
           g.setColor(Color.red);
        }
    }

}
