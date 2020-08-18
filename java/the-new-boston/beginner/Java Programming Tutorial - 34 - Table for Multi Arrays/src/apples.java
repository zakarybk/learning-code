
public class apples {
	public static void main(String[] args){
		int firstArray[][] = {
				{1, 2, 3, 4},
				{5},
				{6, 8, 9, 10, 11}
		};
		int secondArray[][] = {
				{10, 66, 60, 11},
				{7, 6, 5, 4}
		};
		
		System.out.println("This is the first array");
		display(firstArray);
		
		System.out.println("This is the second array");
		display(secondArray);
	}
	
	public static void display(int x[][]){
		for(int row = 0; row < x.length; row++){
			for(int column = 0; column < x[row].length; column++){
				System.out.println(x[row][column]+"\t");
			}
			System.out.println();
		}
	}
}
