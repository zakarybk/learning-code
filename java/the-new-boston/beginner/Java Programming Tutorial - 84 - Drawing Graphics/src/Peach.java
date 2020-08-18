import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Peach extends JFrame{
	
	/*
	public void paintComponent(Graphics g){
		super.paintComponent(g);
		this.setBackground(Color.WHITE);
		
		g.setColor(Color.BLUE);
		g.fillRect(25,  25,  100,  30);
		
		g.setColor(new Color(190, 81, 215));
		g.fillRect(25,  65,  100,  30);
		
		g.setColor(Color.RED);
		g.drawString("This is some text", 25, 120);
	}
	*/
	
	private JButton b;
	private Color color = Color.WHITE;
	private JPanel panel;
	
	public Peach(){
		super("The title");
		panel = new JPanel();
		panel.setBackground(color);
		
		b = new JButton("Chose a colour");
		b.addActionListener(
				new ActionListener(){
					public void actionPerformed(ActionEvent event){
						color = JColorChooser.showDialog(null, "Pick your colour", color);
						if(color==null)
							color = Color.WHITE;
						
						panel.setBackground(color);
					}
				}
		);
		
		add(panel, BorderLayout.CENTER);
		add(b, BorderLayout.SOUTH);
		setSize(425, 150);
		setVisible(true);
	}
	
}
