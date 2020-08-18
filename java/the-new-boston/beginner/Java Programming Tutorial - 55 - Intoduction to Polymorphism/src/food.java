
abstract public class food { // you can use it but not make any objects on it (abstract) but can be used for inheritance and polymorphism
	
	// abstract method, has to be overridden by classes which inherit from it, the entire calls need to be abstract as well for an abstract method
	public abstract void eat(); // non abstract needs body, doesn't need to be abstract to be in abstract class
	
	// foood is so general that you won't want to create objects on it such as - food fo = new food();
	
	/*
	void eat(){
		System.out.println("This food is great");
	}
	*/
	
}
