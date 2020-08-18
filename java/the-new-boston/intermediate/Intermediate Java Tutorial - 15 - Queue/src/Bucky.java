import java.util.*;

public class Bucky {
	public static void main(String[] args){
		
		PriorityQueue<String> q = new PriorityQueue<String>();
		
		q.offer("first");
		q.offer("second");
		q.offer("third");
		
		System.out.printf("%s ", q);
		System.out.println();
		
		System.out.printf("%s ", q.peek()); // Peek, highest priority element
		System.out.println();
		
		q.poll(); // Remove element with highest priority
		System.out.printf("%s ", q);
		System.out.println();
		
	}
}
