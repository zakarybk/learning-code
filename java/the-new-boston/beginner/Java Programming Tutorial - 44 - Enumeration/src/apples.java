import java.util.EnumSet; // for range method

public class apples {
	public static void main(String[] args){
		for(tuna people: tuna.values()){ // tuna.values() - built in array of constants (static method)
			System.out.printf("%s\t%s\t%s\n", people, people.getDesc(), people.getYear());
		}
		
		System.out.println("\nAnd now for the range of constants!!!\n");
		
		for(tuna people: EnumSet.range(tuna.kelsey,  tuna.candy)){
			System.out.printf("%s\t%s\t%s\n", people, people.getDesc(), people.getYear());
		}
	}
}
