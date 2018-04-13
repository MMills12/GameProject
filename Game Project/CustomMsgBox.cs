using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project
{
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }

        static CustomMsgBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnRetry, string btnCancel)
        {
            MsgBox = new CustomMsgBox();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnRetry;
            MsgBox.button2.Text = btnCancel;
            MsgBox.ShowDialog();
            return result;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            //MsgBox.Close();
            Application.Restart();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Application.Exit();
        }
    }
}
