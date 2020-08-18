import java.util.*;

public class Bucky {
	public static void main(String[] args){
		
		String[] stuff = {"babies", "watermelon", "melons", "fudge"}; // Array
		LinkedList<String> thelist = new LinkedList<String>(Arrays.asList(stuff)); // List
		
		thelist.add("pumpkinf");
		thelist.addFirst("firstthing");
		
		// Convert back to an array
		stuff = thelist.toArray(new String[thelist.size()]);
		
		for(String x : stuff)
			System.out.printf("%s ", x);
		
	}
}
