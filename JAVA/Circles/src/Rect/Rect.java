

package Rect;

import java.awt.geom.Area;
import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class Rect {
    public static double a;
    public static double b;
    
    public Rect(int a, int b) {
        Rect.a = a;
        Rect.b = b;
    }

    
    
    public static double area(){
        return a*b;
        
    }
    
    public static double perimeter(){
        return a+a+b+b;
    }
    
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);
        a=scan.nextDouble();
        b=scan.nextDouble();
        
        System.out.printf("area= %f\nperimeter= %f",Rect.area(),Rect.perimeter());
        
    }
}
