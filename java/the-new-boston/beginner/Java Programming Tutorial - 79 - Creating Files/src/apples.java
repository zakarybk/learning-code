/*
import java.util.*;

public class apples {
	public static void main(String[] args){
		
		final Formatter x;
		
		try{
			x = new Formatter("fred.txt"); // like file.append, created in dir of java program
			System.out.println("You created a file");
		}
		catch(Exception e){
			System.out.println("You got an error");
		}
		
	}
}
*/

public class apples {
	public static void main(String[] args){
		
		createfile g = new createfile();
		g.openFile();
		g.addRecords();
		g.closeFile();
		
	}
}
