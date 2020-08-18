import java.util.*;

public class Bucky {
	public static void main(String[] args){
		
		// Created array then converted to a list
		String[] things = {"apple", "bob", "ham", "bob", "bacon"};
		List<String> list = Arrays.asList(things);
		
		System.out.printf("%s ", list);
		System.out.println();
		
		// Pass list in as a hashset object to remove duplicates
		Set<String> set = new HashSet<String>(list);
		System.out.printf("%s ", set);
	}
}
