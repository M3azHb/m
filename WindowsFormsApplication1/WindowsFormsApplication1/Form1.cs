using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool m = true;
        int m_count = 0;

        private void bins_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (m)
                b.Text = "X";
            else
                b.Text = "O";
            m = !m;
            b.Enabled = false;
            m_count++;
            checkwinner();
        }
private void checkwinner()
{
    bool i = false;

    if((a1.Text==a2.Text)&&(a2.Text==a3.Text)&&(!a1.Enabled))
{
    i = true;
}
    
    else if((b1.Text==b2.Text)&&(b2.Text==b3.Text)&&(!b1.Enabled))
{
       i = true;
}

    else if((c1.Text==c2.Text)&&(c2.Text==c3.Text)&&(!c1.Enabled))
{
       i = true;
}
    else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
    {
        i = true;
    }
    else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
    {
        i = true;
    }
    else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
    {
        i = true;
    }
    else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
    {
        i = true;
    }
    else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
    {
        i = true;
    } if (i)
    {
        string s;
        if (m)
        {
            int a = Convert.ToInt32(O.Text);
            a++;
            O.Text = a.ToString();
            s = player2.Text;
            enabledbuttons();
        }
        else
        {
            int a = Convert.ToInt32(X.Text);
            a++;
            X.Text = a.ToString();
            s = player1.Text;
            enabledbuttons();
        }
        MessageBox.Show(s + " win ");
        m_count = 0;
    }
        if (m_count == 9) 
          {
              MessageBox.Show(" TA3ADOOOL ");
              m_count = 0;
              enabledbuttons();
              int a = Convert.ToInt32(T.Text);
              a++;
              T.Text = a.ToString();
          }

} 
        private void enabledbuttons()
       {
           foreach (Control c in Controls)
           {
               try
               {
                   Button b = (Button)c;
                   b.Enabled = true;
                   b.Text = "";

               }
               catch { }
           } 
       }

        private void button1_Click(object sender, EventArgs e)
        {
            enabledbuttons();
            O.Text = "0";
            X.Text = "0";
            T.Text = "0";
            m_count = 0;
        }


    }
}
