import java.util.*;

public class Bucky {
	
	public static void main(String[] args){
		
		// Create an array and convert to a list
		Character[] ray = {'p', 'w', 'n'};
		List<Character> l = Arrays.asList(ray);
		System.out.println("List is: ");
		output(l);
		
		// Reverse and print out the list, l is list(collection)
		Collections.reverse(l);
		System.out.println("After reverse: ");
		output(l);
		
		// Create a new array and a new list
		Character[] newRay = new Character[3];
		List<Character> listCopy = Arrays.asList(newRay);
		
		// Copy contents of list to listCopy
		Collections.copy(listCopy, l);
		System.out.println("Copy of list: ");
		output(listCopy);
		
		// Fill collections with stuff
		Collections.fill(l, 'X');
		System.out.println("After filling the list: ");
		output(l);
		
		
	}
	
	private static void output(List<Character> thelist){
		for(Character thing : thelist)
			System.out.printf("%s ", thing);
			
		System.out.println();
	}
	
}
