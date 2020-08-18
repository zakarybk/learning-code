import javax.swing.JOptionPane; // gui library

public class apples {
	public static void main(String[] args){
		
		String fn = JOptionPane.showInputDialog("Enter first number");
		String sn = JOptionPane.showInputDialog("Enter second number");
		
		if (fn != null && sn != null){	
			int num1 = Integer.parseInt(fn); // turn anything into int
			int num2 = Integer.parseInt(sn);	
			int sum = num1 + num2;
			
			JOptionPane.showMessageDialog(null, "The answer is " + sum, "The title", JOptionPane.PLAIN_MESSAGE);
		}
		
	}
}
