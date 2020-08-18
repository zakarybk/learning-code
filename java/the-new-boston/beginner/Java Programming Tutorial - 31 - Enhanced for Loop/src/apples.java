
public class apples {
	public static void main(String[] args){
		int bucky[] = {3, 4, 5, 6, 7};
		int total = 0;
		
		for(int x: bucky){ // enhanced for statement, type/identifier then array
			total += x;
		}
		System.out.println(total);
	}
}
