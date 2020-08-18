using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Tutorial___74___Project_1_Email_Sender__pt_1
{
    public partial class Form1 : Form
    {
        // Password character in properties to * or character map!
        // Maximize box false
        // FormBorderStype to stop re-sizing (Fixed Dialog)
        //https://www.iconfinder.com/ free icons
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // If the details are wrong, don't crash!
            {
                if (!textBox3.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("You need to provide a Gmail email");
                    return; // hault code to stop the rest form running
                }
                button1.Enabled = false;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBox4.Text); // Our email
                message.Subject = textBox2.Text;
                message.Body = textBox3.Text;
                foreach (string s in textBox1.Text.Split(';'))
                    message.To.Add(s); // Add everyone
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(textBox4.Text, textBox5.Text);
                // using gmail service so the email has to be for gmail
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true; // have to enable this to send through gmail
                client.Send(message);
            }
            catch { MessageBox.Show("There was an error sending the message. Make sure you type in\r\nyour credentials correctly and that you have an internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { button1.Enabled = true; } // Runs code at the end no matter what!
        }
    }
}
