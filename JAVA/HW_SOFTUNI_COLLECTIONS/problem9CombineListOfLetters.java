

package HW_SOFTUNI_COLLECTIONS;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Velkata
 */
public class problem9CombineListOfLetters {
   public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	ArrayList<Character> firstList = new ArrayList<>();
	ArrayList<Character> secondList = new ArrayList<>();
	for (char character : scanner.nextLine().toCharArray()) {
	    firstList.add(character);
	}
	for (char character : scanner.nextLine().toCharArray()) {
	    secondList.add(character);
	}
	ArrayList<Character> output = new ArrayList<>();
	output.addAll(firstList);
	for (int i = 0; i < secondList.size(); i++) {
	    if (!firstList.contains(secondList.get(i))) {
		output.add(' ');
		output.add(secondList.get(i));
	    }
	}
	for (char character : output) {
	    System.out.print(character);
	}
        System.out.println("");
    }

}