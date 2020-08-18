import java.awt.FlowLayout;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import javax.swing.JOptionPane;

public class tuna extends JFrame{

	private JTextField item1;
	private JTextField item2;
	private JTextField item3;
	private JPasswordField passwordField;
	
	public tuna(){
		super("The title");
		setLayout(new FlowLayout());
		
		item1 = new JTextField(10); // length 10
		add(item1);
		
		item2 = new JTextField("enter text here");
		add(item2);
		
		item3 = new JTextField("uneditable", 20);
		item3.setEditable(false); // cannot edit
		add(item3);
		
		passwordField = new JPasswordField("mypass");
		add(passwordField);
		
		thehandler handler = new thehandler();
		item1.addActionListener(handler);
		item2.addActionListener(handler);
		item3.addActionListener(handler);
		passwordField.addActionListener(handler);
	}
	
	private class thehandler implements ActionListener{ // the class to handle the events, used above
		
		public void actionPerformed(ActionEvent event){ // built in method for enter, event as arg which is pressing of enter
			
			String string = "";
			
			if(event.getSource() == item1) // source of enter
				string = String.format("field 1: %s", event.getActionCommand()); // get the text from that location
			else if(event.getSource() == item2)
				string = String.format("field 2: %s", event.getActionCommand());
			else if(event.getSource() == item3)
				string = String.format("field 3: %s", event.getActionCommand());
			else if(event.getSource() == passwordField)
				string = String.format("password field is: %s", event.getActionCommand());
			
			JOptionPane.showMessageDialog(null, string); // pos null = middle, 
			
		}
	}
	
}
