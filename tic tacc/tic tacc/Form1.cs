using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tacc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;// even x turn;odd=0 turn;
        public int turns = 0;//counting turns;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        //counting wins for both players and draws;

        private void button10_Click(object sender, EventArgs e)
        {
            NewGame();

        }
        bool checkdraw()
        {

            if ((turns == 9) && checkwinner() == false)
                return true;
            else
                return false;
        }
        bool checkwinner()
        {
            //horizontal checks
            if((A00.Text==A01.Text) &&  (A01.Text == A02.Text) && A00.Text !="")
            return true;
            else if((A10.Text==A11.Text) && (A11.Text==A12.Text) && A10.Text !="")
                return true;
          else if ((A20.Text==A21.Text) && (A21.Text==A22.Text) && A20.Text !="")
return true;
            //vertical checks
            if((A00.Text==A10.Text) && (A10.Text==A20.Text) && A00.Text!="")
            return true;
             if((A01.Text==A11.Text) && (A11.Text==A21.Text) && A01.Text !="")
            return true;
        else if((A02.Text==A12.Text) && (A12.Text==A22.Text) && A02.Text !="")
            return true;
            // diagonal checks
            if((A00.Text==A11.Text) && (A11.Text==A22.Text) && A00.Text !="")
                return true;
            else if((A01.Text==A11.Text) && (A11.Text==A21.Text) && A01.Text !="")
                return true;
            else
                return false;
 
    }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "x";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "0";
                    player++;
                    turns++;

                }
    if (checkdraw()==true)
{
   MessageBox.Show("tie game");
    sd ++;
    NewGame();
            }
            }
                if (checkwinner()==true)   
                {
                    if(button.Text=="x")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("0 Win!");
                        s2++;
                        NewGame();
                    }
                            
                            
                }
}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "TIC TAC TOEE";

            XWin.Text = "X:"+s1;
            OWin.Text = "0:" + s2;
            Draws.Text="draws:"+sd;
        }
            void NewGame()
            {
                player = 2;
                turns = 0;
              A00.Text= A11.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
                XWin.Text = "X:"+s1;
            OWin.Text = "o:" + s2;
            Draws.Text="draws:"+sd;
                
            }

        private void rbutton_Click(object sender, EventArgs e)
        {
            s1=s2=sd=0;
            NewGame();
        }






        }
}