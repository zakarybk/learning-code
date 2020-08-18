
public class apples {
	public static void main(String[] args){
		tuna tunaObject = new tuna();
		
		System.out.println(tunaObject.toMilitary());
		
		tunaObject.setTime(21, 36, 20);
		
		System.out.println(tunaObject.toMilitary());
		
		System.out.println(tunaObject.toString());
	}
}
