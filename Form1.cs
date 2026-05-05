using System;
using System.Windows.Forms;
namespace C_Project
{
    //main WinForms window for the dice rolling game
    //This class connects the user interface to the dice logic
    public partial class Form1 : Form
    {
        //object for one die
        private Die die;
        //object for 2 die
        private TwoDice twoDice;
        //object to track stats
        private DiceGame game;

        //constructor runs when form opens
        public Form1()
        {

            InitializeComponent();

            //create the objects for the game
            die = new Die();
            twoDice = new TwoDice();
            game = new DiceGame();

            label1.Text = "Die 1:";
            label2.Text = "Die 2:";
            label3.Text = "Total:";
            label4.Text = "Total Rolls: 0";
            label5.Text = "Average: 0";

            button1.Text = "Roll One Die";
            button2.Text = "Roll Two Dice";
            button3.Text = "Reset";
        }
        //for rolling 1 die
        private void button1_Click(object sender, EventArgs e)
        {
            int roll = die.Roll();

            label1.Text = "Die 1: " + roll;
            label2.Text = "Die 2: N/A";
            label3.Text = "Total: " + roll;

            game.AddRoll(roll, roll.ToString());

            UpdateStats();
        }
        //rolling 2 die
        private void button2_Click(object sender, EventArgs e)
        {
            int total = twoDice.RollTwoDice();

            label1.Text = "Die 1: " + twoDice.Die1;
            label2.Text = "Die 2: " + twoDice.Die2;
            label3.Text = "Total: " + total;

            game.AddRoll(total, twoDice.Die1 + " + " + twoDice.Die2 + " = " + total);

            UpdateStats();
        }
        //reset button
        private void button3_Click(object sender, EventArgs e)
        {
            game.Reset();

            label1.Text = "Die 1:";
            label2.Text = "Die 2:";
            label3.Text = "Total:";
            label4.Text = "Total Rolls: 0";
            label5.Text = "Average: 0";

            listBox1.Items.Clear();
        }
        
        //refresh and update the stats and history of the game
        private void UpdateStats()
        {
            label4.Text = "Total Rolls: " + game.TotalRolls;
            label5.Text = "Average: " + game.AverageRoll.ToString("0.00");

            listBox1.Items.Clear();

            foreach (string item in game.History)
            {
                listBox1.Items.Add(item);
            }
        }

        private void label6_click(object sender, EventArgs e)
        {

        }
    }
}
