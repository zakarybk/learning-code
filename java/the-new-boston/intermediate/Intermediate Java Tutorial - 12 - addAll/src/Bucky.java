import java.util.*;

public class Bucky {
	public static void main(String[] args){
		
		// Convert stuff array to a list
		String[] stuff = {"apples", "beef", "corn", "ham"};
		List<String> list1 = Arrays.asList(stuff);
		
		ArrayList<String> list2 = new ArrayList<String>();
		list2.add("youtube");
		list2.add("google");
		list2.add("digg");
		
		for(String x : list2)
			System.out.printf("%s ", x);
		
		Collections.addAll(list2, stuff); // Takes all from stuff and adds to list2 (Added array to arraylist)
		
		System.out.println();
		for(String x : list2)
			System.out.printf("%s ", x);
		System.out.println();
		
		System.out.println(Collections.frequency(list2,  "digg")); // How many times "digg" is in list2(arraylist)
		
		// Disjoint
		boolean tof = Collections.disjoint(list1,  list2); // True if no items in common - False they do have common values
		System.out.println(tof);
		
		if(tof)
			System.out.println("These lists do not have stuff in common");
		else
			System.out.println("These lists must have something in common!");
		
	}
}
