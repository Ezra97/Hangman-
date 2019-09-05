using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hagmandb.hangmandbsDataSetTableAdapters;

namespace hagmandb
{
    public partial class mainform : Form
    {
        wordsTableAdapter mywordstable = new wordsTableAdapter();
        string currentword;
        int count = 0;
        public mainform()
        {
            InitializeComponent();
        }

        private void onclick(object sender, EventArgs e)
        {
            Graphics draw = this.CreateGraphics();
            draw.Clear(Color.White);
            Random rnd = new Random();
            //get random line
            int randomline = rnd.Next(mywordstable.GetData().Count);
            //get current word
            currentword = mywordstable.GetData()[randomline].word;
            //display current word for debug
            label_answer.Text = currentword;
            labelletterschosen.Text = " ";
            count = 0;
            label_errors.Text = "Errors:" + count;
            UpdateWhatToGuessLabel();
            onpaint(null, null);
            foreach (Control ctl in panel1.Controls)
            {
                ctl.Enabled = true;
            }
        }
        private void UpdateWhatToGuessLabel()
        {
            labeluserguesser.Text = string.Empty;
            for (int i = 0; i < currentword.Length; i++)
            {
                char theletter = currentword.ToUpper()[i];
                if (labelletterschosen.Text.Contains(theletter))
                    labeluserguesser.Text += theletter;
                else
                    labeluserguesser.Text += "_ ";
            }
        }

        private void onpaint(object sender, PaintEventArgs e)
        {
            Graphics draw = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 3);
            switch(count)
            {
                case 0:
                //gallows
                draw.DrawLine(myPen, 10, 200, 50, 200);
                draw.DrawLine(myPen, 30, 200, 30, 50);
                draw.DrawLine(myPen, 30, 50, 80, 50);
                draw.DrawLine(myPen, 80, 50, 80, 60);
                    break;
                case 1:
                    draw.DrawEllipse(myPen, 70, 60, 20, 20); //head
                    goto case 0;
                case 2:
                    draw.DrawLine(myPen, 80, 80, 80, 100); //body
                    goto case 1;
                case 3:
                    draw.DrawLine(myPen, 80, 85, 70, 100);// left hand
                    goto case 2;
                case 4:
                    draw.DrawLine(myPen, 80, 85, 90, 100); // right hand
                    goto case 3;
                case 5:
                    draw.DrawLine(myPen, 80, 100, 70, 110); //left leg
                    goto case 4;
                case 6:
                   draw.DrawLine(myPen, 80, 100, 90, 110); //right leg
                   goto case 5;
                default:
                   break;
            }
        }

        private void onselectletter(object sender, EventArgs e)
        {
            var pushedbutton = (Button)sender;
            char letterchosen = pushedbutton.Text[0];
            labelletterschosen.Text += letterchosen;
            UpdateWhatToGuessLabel();
            if (!currentword.ToUpper().Contains(letterchosen))
            {
                count++;
                label_errors.Text = "Errors:" + count;
                Invalidate(true);
                if (count >= 6)
                {
                    DisableGuesses();
                }
            }
 
            //if player won
            if (!labeluserguesser.Text.Contains('_'))
            {
                postwinforms myform = new postwinforms(count);
                myform.ShowDialog();
                DisableGuesses();
            }
            pushedbutton.Enabled = false;
            Invalidate();
        }
        private void DisableGuesses()
        {
            foreach (Control ctl in panel1.Controls)
            {
                if(ctl is Button && ctl.Text.Length==1)
                ctl.Enabled = false;
            }
        }
    }
}
