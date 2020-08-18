import java.util.Random;

public class apples {
	public static void main(String[] args){
		Random dice = new Random();
		int number;
		
		for(int counter = 1; counter <= 10; counter++){
			number = 1 + dice.nextInt(6); // if 6, 0-5 so 1+
			System.out.println(number + " ");
		}
	}
}
