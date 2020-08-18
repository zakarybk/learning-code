import java.awt.FlowLayout; // minimized
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

public class Gui extends JFrame{

	private JButton reg;
	private JButton custom;
	
	public Gui(){
		super("The title"); // super access super class
		setLayout(new FlowLayout()); // Default layout
		
		reg = new JButton("reg button"); // Button + Text on button
		add(reg);
		
		Icon b = new ImageIcon(getClass().getResource("b.png"));
		Icon x = new ImageIcon(getClass().getResource("x.png"));
		custom = new JButton("Custom", b);
		custom.setRolloverIcon(x);
		add(custom);
		
		HandlerClass handler = new HandlerClass();
		reg.addActionListener(handler);
		custom.addActionListener(handler);
		
	}
	
	private class HandlerClass implements ActionListener{ // implements = can use method but have to override all of them
		
		public void actionPerformed(ActionEvent event){
			JOptionPane.showMessageDialog(null, String.format("%s", event.getActionCommand()));
		}
		
	}
	
}
