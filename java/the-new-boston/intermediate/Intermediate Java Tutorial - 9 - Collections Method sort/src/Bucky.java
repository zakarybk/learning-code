import java.util.*;

public class Bucky {
	public static void main(String[] args){
		
		String[] crap = {"apples", "lemons", "geese", "bacon", "youtube"};
		List<String> l1 = Arrays.asList(crap);
		
		Collections.sort(l1); // Sort alphabetically
		System.out.printf("%s\n", l1);
		
		Collections.sort(l1, Collections.reverseOrder()); // What, how
		System.out.printf("%s\n", l1);
		
		
	}
}
