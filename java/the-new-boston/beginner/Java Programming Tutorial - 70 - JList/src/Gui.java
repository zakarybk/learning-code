import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

public class Gui extends JFrame{

	private JList<String> list;
	private static String[] colournames = {"black", "blue", "red", "white"};
	private static Color[] colours = {Color.BLACK, Color.BLUE, Color.RED, Color.WHITE};
	
	public Gui(){
		super("The title");
		setLayout(new FlowLayout());
		
		list = new JList<String>(colournames);
		list.setVisibleRowCount(4);
		list.setSelectionMode(ListSelectionModel.SINGLE_SELECTION); // Only one thing
		add(new JScrollPane(list));
		
		list.addListSelectionListener(
				new ListSelectionListener(){ // New anonymous class
					public void valueChanged(ListSelectionEvent event){
						getContentPane().setBackground(colours[list.getSelectedIndex()]);
					}
				}
		);
		
	}
	
	
}
