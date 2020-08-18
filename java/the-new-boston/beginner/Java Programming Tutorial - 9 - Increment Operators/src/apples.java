import java.util.Scanner;

public class apples {
	public static void main(String args[]){
		Scanner bucky = new Scanner(System.in);
		
		int tuna = 5;
		tuna++;
		System.out.println(tuna);
		
		System.out.println(++tuna);
		System.out.println(tuna++); // doesn't change until after
		System.out.println(tuna);
		
		System.out.println(--tuna);
		
		System.out.println(tuna += 8);
		System.out.println(tuna *= 8);
	}
}
