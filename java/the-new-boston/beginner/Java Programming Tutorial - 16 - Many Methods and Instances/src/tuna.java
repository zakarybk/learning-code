
public class tuna {
	private String girlName; // instance variable
	public void setName(String name){
		girlName = name;
	}
	public String getName(){
		return girlName;
	}
	public void saying(){
		System.out.printf("Your first gf was %s", getName());
	}
}
