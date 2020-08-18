
public class apples {
	public static void main(String[] args){
		System.out.println(average(45, 66, 68, 70, 1, 2, 3));
	}
	
	public static int average(int...numbers){
		int total = 0;
		for(int x: numbers)
			total += x;
		return total/numbers.length;
	}
}
