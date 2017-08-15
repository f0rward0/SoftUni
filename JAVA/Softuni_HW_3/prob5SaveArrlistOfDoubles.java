package Softuni_HW_3;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

/**
 *
 * @author Velkata
 */
public class prob5SaveArrlistOfDoubles {
    public static void main(String[] args) {
        
        try (ObjectOutputStream oos=new ObjectOutputStream(
                new FileOutputStream("doubles.list"));
                ObjectInputStream ois=new ObjectInputStream(
                new FileInputStream("doubles.list"));  
                ){
            ArrayList<Double> doubles=new ArrayList<>();
            doubles.add(5.23);
            doubles.add(5.43);
            doubles.add(6.23);
            doubles.add(9.23);
            
            oos.writeObject(doubles);
            
            System.out.println(ois.readObject());
            
                    
            
        } catch (Exception e) {
        }
    }

}
