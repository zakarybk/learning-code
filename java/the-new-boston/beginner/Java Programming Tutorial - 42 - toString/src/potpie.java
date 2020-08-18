
public class potpie {
	private int month, day, year;
	
	public potpie(int m, int d, int y){
		month = m;
		day = d;
		year = y;
		
		System.out.printf("The constructor is %s\n", this); // this is the object, looks to toString as it needs string rep
	}
	
	public String toString(){ // HAVE TO TOSTRING
		return String.format("%d/%d/%d", month, day, year);
	}
}
