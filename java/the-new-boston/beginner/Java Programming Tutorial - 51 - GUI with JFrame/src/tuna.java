import java.awt.FlowLayout; // Default layout
import javax.swing.JFrame; // All basic window features/window
import javax.swing.JLabel; // Output text and images onto the screen

public class tuna extends JFrame{ // inherit all from JFrame
	
	private JLabel item1;
	
	public tuna(){
		super("The title bar"); // Title for window
		setLayout(new FlowLayout()); // Default layout
		
		item1 = new JLabel("This is a sentence");
		item1.setToolTipText("This is going to show on hover"); // when we hover over
		add(item1); // add to the window
	}
	
}
