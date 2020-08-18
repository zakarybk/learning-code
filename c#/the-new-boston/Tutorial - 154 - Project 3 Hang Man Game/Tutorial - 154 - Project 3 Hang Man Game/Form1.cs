using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
// hold alt to move stuff better
namespace Tutorial___154___Project_3_Hang_Man_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           //g = panel1.CreateGraphics();
           //p = new Pen(Color.Blue, 2);
           //s = new SolidBrush(Color.Black);
        }

        string word;
        List<Label> labels = new List<Label>();
        int amount = 0;

        enum BodyParts
        {
            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Right_Arm,
            Left_Arm,
            Body,
            Right_Leg,
            Left_Leg,
        }

        //Graphics g;
        //Pen p;
        //SolidBrush s;
        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130,218), new Point(130,5));
            g.DrawLine(p, new Point(135,5), new Point(65,5));
            g.DrawLine(p, new Point(60,0), new Point(60,50));
            MakeLabels();
        }

        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            SolidBrush s = new SolidBrush(Color.Black);
            switch (bp)
            {
                case BodyParts.Head:
                    g.DrawEllipse(p, 40, 50, 40, 40);
                    break;
                case BodyParts.Left_Eye:
                    g.FillEllipse(s, 50, 60, 5, 5);
                    break;
                case BodyParts.Right_Eye:
                    g.FillEllipse(s, 63, 60, 5, 5);
                    break;
                case BodyParts.Mouth:
                    g.DrawArc(p, 50, 60, 20, 20, 45, 90); // start at 45 degrees and go 90
                    break;
                case BodyParts.Body:
                    g.DrawLine(p, new Point(60, 90), new Point(60, 170));
                    break;
                case BodyParts.Left_Arm:
                    g.DrawLine(p, new Point(60, 100), new Point(30, 85));
                    break;
                case BodyParts.Right_Arm:
                    g.DrawLine(p, new Point(60, 100), new Point(90, 85));
                    break;
                case BodyParts.Left_Leg:
                    g.DrawLine(p, new Point(60, 170), new Point(30, 190));
                    break;
                case BodyParts.Right_Leg:
                    g.DrawLine(p, new Point(60, 170), new Point(90, 190));
                    break;
            }
        }

        void MakeLabels()
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray(); // turns string into char array 'a', 'b' --> last char will be \n
            int between = 330 / chars.Length - 1; // skip n
            for (int i = 0; i < chars.Length - 1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 80); // between = 40, 0 * 40 + 10 = 10, 80 
                labels[i].Text = "_"; // until we guess letter
                labels[i].Parent = groupBox2;
                labels[i].BringToFront(); // make sure we can see it
                labels[i].CreateControl(); // creates the control so that it's visible on the form
            }
            label1.Text = "Word Length: " + (word.Length - 1).ToString(); // -1 again to remove \n

        }

        string GetRandomWord()
        {
            WebClient wc = new WebClient();
            string wordList = wc.DownloadString("https://raw.githubusercontent.com/Tom25/Hangman/master/wordlist.txt");
            string[] words = wordList.Split('\n');
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)]; // since it starts at 0
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter = textBox1.Text.ToLower().ToCharArray()[0]; // only one element, max length 1, all lower case
            if (!char.IsLetter(letter)) // if not a letter
            {
                MessageBox.Show("You have to submit a letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // don't execute any code with this !letter
            }
            if (word.Contains(letter))
            {
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    // If the letter is what they submited, changes if there are multiple as well
                    if (letters[i] == letter)
                        // Use that index to set the text for the right label
                        labels[i].Text = letter.ToString();
                }
                foreach (Label l in labels)
                    if (l.Text == "_") return; // return if not all filled in
                // If it didn't return
                MessageBox.Show("You have WON!", "Well done!");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The letter than you guessed isn't in the word!", "Sorry");
                label2.Text += " " + letter.ToString() + ","; // it's a char so needs converting to string
                DrawBodyPart((BodyParts)amount); // cast the amount of body parts
                amount++;
                if (amount == 9)
                {
                    MessageBox.Show("You lost! The word was " + word, "Better luck next time!");
                    ResetGame();
                }
            }
        }

        void ResetGame()
        {
            // clear panel
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor); // clear to background colour
            GetRandomWord(); // new word
            MakeLabels();
            DrawHangPost();
            label2.Text = "Missed:";
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == word)
            {
                MessageBox.Show("You have WON!,", "Well done!");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The word you guessed is wrong!", "Sorry");
                DrawBodyPart((BodyParts)amount);
                amount++;
                if (amount == 9)
                {
                    MessageBox.Show("You lost! The word was " + word, "Better luck next time!");
                    ResetGame();
                }
            }
        }
    }
}
