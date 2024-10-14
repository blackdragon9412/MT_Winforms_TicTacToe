namespace C_27_TicTacToe_WPF_TOMA
{


    public partial class Form1 : Form
    {
        bool game_start = false;


        int  Player_Turn;


        int Winner;
        int Plays = 0;

        public Form1()
        {
            InitializeComponent();

        }

        public void Toggle_Buttons()    
        {

            if (t1.Enabled)
            {

                t1.Enabled = false;
                b1.Enabled = false;
                m1.Enabled = false;
                t3.Enabled = false;
                m3.Enabled = false;
                b3.Enabled = false;
                t2.Enabled = false;
                m2.Enabled = false;
                b2.Enabled = false;


            }
            else 
            { 

                

                t1.Enabled = true;
                b1.Enabled = true;
                m1.Enabled = true;
                t3.Enabled = true;
                m3.Enabled = true;
                b3.Enabled = true;
                t2.Enabled = true;
                m2.Enabled = true;
                b2.Enabled = true;

            }

        }

        public void Toggle_Buttons_Text()
        {

            t1.Text = "_";
            b1.Text = "_";
            m1.Text = "_";
            t3.Text = "_";
            m3.Text = "_";
            b3.Text = "_";
            t2.Text = "_";
            m2.Text = "_";
            b2.Text = "_";

        }

        public  void Turns(Button button)
        {
            if (game_start == true && Player_Turn == 1 && Plays < 9)
            {

                button.Text = "X";
                Player_Turn = 2;
                Plays++;
                Player_1.Text = "Player1";
                Player_2.Text = "Player2(Your Turn)";

            }
            else if (game_start == true && Player_Turn == 2 && Plays < 9)
            {
                button.Text = "O";
                Player_Turn = 1;
                Plays++;
                Player_2.Text = "Player2";
                Player_1.Text = "Player1(Your Turn)";
            }
        }

        public int WinCondition()
        {

            if ( (int)Convert.ToChar(t1.Text) == 79 && (int)Convert.ToChar(m1.Text) == 79 && (int)Convert.ToChar(b1.Text) == 79)
            {

                Winner = 1;
                return Winner;
            } // oben unten links , o

            if ((int)Convert.ToChar(t2.Text) == 79 && (int)Convert.ToChar(m2.Text) == 79 && (int)Convert.ToChar(b2.Text) == 79)
            {

                Winner = 1;
                return Winner;
            } // oben unten mitte , o

            if ((int)Convert.ToChar(t3.Text) == 79 && (int)Convert.ToChar(m3.Text) == 79 && (int)Convert.ToChar(b3.Text) == 79)
            {

                Winner = 1;
                return Winner;
            } // oben unten rechts, o

            if ((int)Convert.ToChar(t1.Text) == 79 && (int)Convert.ToChar(t2.Text) == 79 && (int)Convert.ToChar(t3.Text) == 79)
            {

                Winner = 1;
                return Winner;
            } // links rechts oben , o

            if ((int)Convert.ToChar(m1.Text) == 79 && (int)Convert.ToChar(m2.Text) == 79 && (int)Convert.ToChar(m3.Text) == 79) //links rechts mitte, o
            {

                Winner = 1;
                return Winner;
            } // links rechts mitte , o

            if ((int)Convert.ToChar(b1.Text) == 79 && (int)Convert.ToChar(b2.Text) == 79 && (int)Convert.ToChar(b3.Text) == 79) 
            {

                Winner = 1;
                return Winner;
            } // links rechts unten , 0

            if ((int)Convert.ToChar(t1.Text) == 79 && (int)Convert.ToChar(m2.Text) == 79 && (int)Convert.ToChar(b3.Text) == 79) 
            {

                Winner = 1;
                return Winner;
            } // diagonal oben links , o

            if ((int)Convert.ToChar(t3.Text) == 79 && (int)Convert.ToChar(m2.Text) == 79 && (int)Convert.ToChar(b1.Text) == 79) 
            {

                Winner = 1;
                return Winner;
            } // diagonal rechts oben ,o

            if ((int)Convert.ToChar(t1.Text) == 88 && (int)Convert.ToChar(m1.Text) == 88 && (int)Convert.ToChar(b1.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // oben unten links , x

            if ((int)Convert.ToChar(t2.Text) == 88 && (int)Convert.ToChar(m2.Text) == 88 && (int)Convert.ToChar(b2.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // oben unten mitte , x

            if ((int)Convert.ToChar(t3.Text) == 88 && (int)Convert.ToChar(m3.Text) == 88 && (int)Convert.ToChar(b3.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // oben unten rechts , x

            if ((int)Convert.ToChar(t1.Text) == 88 && (int)Convert.ToChar(t2.Text) == 88 && (int)Convert.ToChar(t3.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // links rechts oben , x

            if ((int)Convert.ToChar(m1.Text) == 88 && (int)Convert.ToChar(m2.Text) == 88 && (int)Convert.ToChar(m3.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // links rechts mitte , x

            if ((int)Convert.ToChar(b1.Text) == 88 && (int)Convert.ToChar(b2.Text) == 88 && (int)Convert.ToChar(b3.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // links rechts unten , x

            if ((int)Convert.ToChar(t1.Text) == 88 && (int)Convert.ToChar(m2.Text) == 88 && (int)Convert.ToChar(b3.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // diagonal oben links , x

            if ((int)Convert.ToChar(t3.Text) == 88 && (int)Convert.ToChar(m2.Text) == 88 && (int)Convert.ToChar(b1.Text) == 88)
            {

                Winner = 2;
                return Winner;
            } // diagonal oben rechts , x

            return 0;
        }

        public void WinConditionsChecker()
        {

            if (WinCondition() == 1)
            {
                Toggle_Buttons();
                Info_Box.Text = "Player2 Wins";
                game_start = false;

            }

            if (WinCondition() == 2)
            {
                Toggle_Buttons();
                Info_Box.Text = "Player1 Wins";
                game_start = false;

            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (game_start == false)
            {
                game_start = true;
                Player_Turn = 1;
                Plays = 0;
                Toggle_Buttons();
                Player_1.Text = "Player1(Your Turn)";
                Toggle_Buttons_Text();
            }
            else
            {

                Info_Box.Text = "Ein Spiel läuft bereits";
                Thread.Sleep(5000);
                Info_Box.Text = string.Empty;

            }
            

        }


        private void Left_Top_Click(object sender, EventArgs e)
        {

            Turns(t1);


            WinConditionsChecker();



        }


        private void Middle_Top_Click(object sender, EventArgs e)
        {

            Turns(t2);

            WinConditionsChecker();

        }


        private void Right_Top_Click(object sender, EventArgs e)
        {

            Turns(t3);

            WinConditionsChecker();

        }


        private void Left_Middle_Click(object sender, EventArgs e)
        {

            Turns(m1);

            WinConditionsChecker();

        }


        private void Middle_Middle_Click(object sender, EventArgs e)
        {

            Turns(m2);

            WinConditionsChecker();

        }

        private void Right_Middle_Click(object sender, EventArgs e)
        {

            Turns(m3);

            WinConditionsChecker();
        }



            private void Left_Bottom_Click(object sender, EventArgs e)
            {

                Turns(b1);

                WinConditionsChecker();
            
            }



        private void Middle_Bottom_Click(object sender, EventArgs e)
        {


            Turns(b2);

            WinConditionsChecker();

        }



        private void Right_Bottom_Click(object sender, EventArgs e)
        {

            Turns(b3);

            WinConditionsChecker();

        }





    }
}
