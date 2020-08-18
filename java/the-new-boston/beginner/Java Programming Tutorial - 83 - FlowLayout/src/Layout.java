import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Layout extends JFrame{

	private JButton lb, cb, rb;
	private FlowLayout layout;
	private Container container;
	
	public Layout(){
		super("Title");
		layout = new FlowLayout();
		container = getContentPane();
		setLayout(layout);
		
		// Left
		lb = new JButton("left");
		add(lb);
		lb.addActionListener(
				 new ActionListener(){
					 public void actionPerformed(ActionEvent event){
						 layout.setAlignment(FlowLayout.LEFT);
						 layout.layoutContainer(container); // re-arrange
					 }
				 }
		);
		
		// Center
		cb = new JButton("center");
		add(cb);
		cb.addActionListener(
				 new ActionListener(){
					 public void actionPerformed(ActionEvent event){
						 layout.setAlignment(FlowLayout.CENTER);
						 layout.layoutContainer(container); // re-arrange
					 }
				 }
		);
		
		// Right
		rb = new JButton("right");
		add(rb);
		rb.addActionListener(
				 new ActionListener(){
					 public void actionPerformed(ActionEvent event){
						 layout.setAlignment(FlowLayout.RIGHT);
						 layout.layoutContainer(container); // re-arrange
					 }
				 }
		);
		
	}
	
}
