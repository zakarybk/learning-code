
public class bucky {
	
	// main
	public static void main(String args[]){
		System.out.println(fact(5)); // 5!
	}
	
	/*
	 * 	5! - 120
	 * 	 5*4 - 120
	 *    4*3 - 24
	 *     3*2 - 6
	 *      2*1 - 2
	 *       1!=1
	 */
	
	// fact
	public static long fact(long n){
		if(n <= 1)
			return 1; // base case
		else
			return n * fact(n - 1);
	}
	
}
