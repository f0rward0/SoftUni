

package Rect;

import java.awt.Color;
import java.awt.Graphics;
import java.text.DecimalFormat;
import javafx.scene.shape.Circle;
import javax.swing.JApplet;
import javax.swing.JOptionPane;

/**
 *
 * @author Velkata
 */
public class RectApplet extends JApplet{
    int a=30;
    int b=40;
    String s;
    
   
    
    public void init(){
         JOptionPane panel=new JOptionPane();
         s=panel.showInputDialog("Въведете а в пиксели");
         a=Integer.parseInt(s);
         s=panel.showInputDialog("Въведете b в пиксели");
         b=Integer.parseInt(s);
        
    }
    public void paint(Graphics g){
         Rect r=new Rect(a, b);
         DecimalFormat fmt=new DecimalFormat("#.##");
         
         g.fillRect(100, 100, a, b);
         g.drawString("Площ"+fmt.format(r.area()), 150, 150);
         g.drawString("Периметър"+fmt.format(r.perimeter()), 150, 150);
         Color color=new Color((int)(Math.random()*0xFFFFFF));
         g.setColor(color);
         
    }

}
