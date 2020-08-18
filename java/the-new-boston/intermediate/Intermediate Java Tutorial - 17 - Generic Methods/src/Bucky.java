import java.util.*;

public class Bucky {
	public static void main(String[] args){
		
		Integer[] iray = {1, 2, 3, 4};
		Character[] cray = {'b', 'u', 'c', 'y'};
		
		printMe(iray);
		printMe(cray);
		
	}
	
	// overloaded methods
	public static void printMe(Integer[] i){
		for(Integer x : i)
			System.out.printf("%s ", x);
		System.out.println();
	}
	
	public static void printMe(Character[] i){
		for(Character x : i)
			System.out.printf("%s ", x);
		System.out.println();
	}
}
