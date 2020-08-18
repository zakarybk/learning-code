
public class apples {
	public static void main(String[] args){
		tuna member1 = new tuna("Megan", "Fox");
		tuna member2 = new tuna("Natalie", "Portman");
		tuna member3 = new tuna("Taylor", "Swift"); // all share the same static variable, members
		
		System.out.println();
		System.out.println(member1.getFirst());
		System.out.println(member1.getLast());
		System.out.println(member1.getMembers());
		
		// because it's static, same as c#
		System.out.println(tuna.getMembers());
		
	}
}
