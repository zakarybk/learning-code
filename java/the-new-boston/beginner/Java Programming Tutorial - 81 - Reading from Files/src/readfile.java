import java.io.*;
import java.util.*;

public class readfile {
	
	private Scanner x;
	
	public void openFile(){
		try{
			x = new Scanner(new File("chinese.txt"));
		}
		catch(Exception e){
			System.out.println("Could not find file.");
		}
	}
	
	public void readFile(){
		while(x.hasNext()){ // Keeps going until it reaches the end of the file!
			String a = x.next();
			String b = x.next();
			String c = x.next();
			
			System.out.printf("%s %s %s\n", a, b, c);
		}
	}
	
	public void closeFile(){
		x.close();
	}

}
