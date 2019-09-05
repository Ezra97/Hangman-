using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hagmandb
{
    public partial class postwinforms : Form
    {
        int mscore;
        public postwinforms(int pscore)
        {
            InitializeComponent();
            mscore = pscore;
            label_title.Text = "youve won! you're score:" + mscore;
        }

        private void postwinforms_Load(object sender, EventArgs e)
        {
            
        }

        private void addscore(object sender, EventArgs e)
        {
            highscoresTableAdapter.Insert(mscore, textBox_name.Text);
            //disable player to insert name again
            button_confirm.Visible = false;
            textBox_name.Visible = false;
            label_entername.Visible = false;

            // TODO: This line of code loads data into the 'hangmandbsDataSet.highscores' table. You can move, or remove it, as needed.
            this.highscoresTableAdapter.Fill(this.hangmandbsDataSet.highscores);
            dataGridView1.Visible = true;
        }
    }
}
