
public class apples {
	public static void main(String[] args){
		int bucky[] = {21, 16, 86, 21, 8};
		int sum = 0;
		
		for(int counter = 0; counter < bucky.length; counter++)
			sum+=bucky[counter];
		
		System.out.println(sum);
	}
}
