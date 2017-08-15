

package HW_SOFTUNI_COLLECTIONS;

import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

/**
 *
 * @author Velkata
 */
public class problem10ExtractallUniqueWords {
        public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	String[] input = scanner.nextLine().toLowerCase()
		.split("([().,!?:;'\"-]|\\s)+");
	Set<String> words = new TreeSet<>();
	for (String string : input) {
	    words.add(string);
	}
	for (String string : words) {
	    System.out.print(string + " ");
	}
    }

}