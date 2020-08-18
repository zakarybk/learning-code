import java.io.File;


public class apples {
	public static void main(String[] args){
		
		File x = new File("C:\\test\\greg.txt"); // use two so you don't escape string
		
		if(x.exists())
			System.out.println(x.getName() + " exists!");
		else
			System.out.println("This thing doesn't exist!");
		
	}
}
