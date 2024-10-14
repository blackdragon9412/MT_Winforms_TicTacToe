namespace C_27_TicTacToe_WPF_TOMA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            t1 = new Button();
            t2 = new Button();
            t3 = new Button();
            m1 = new Button();
            m2 = new Button();
            m3 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            Start_Button = new Button();
            Info_Box = new TextBox();
            player_turn_counter = new TextBox();
            Player_1 = new Label();
            Player_2 = new Label();
            SuspendLayout();
            // 
            // t1
            // 
            t1.Enabled = false;
            t1.Location = new Point(200, 112);
            t1.Name = "t1";
            t1.Size = new Size(89, 43);
            t1.TabIndex = 0;
            t1.Text = "_";
            t1.UseVisualStyleBackColor = true;
            t1.Click += Left_Top_Click;
            // 
            // t2
            // 
            t2.Enabled = false;
            t2.Location = new Point(295, 112);
            t2.Name = "t2";
            t2.Size = new Size(89, 42);
            t2.TabIndex = 1;
            t2.Text = "_";
            t2.UseVisualStyleBackColor = true;
            t2.Click += Middle_Top_Click;
            // 
            // t3
            // 
            t3.Enabled = false;
            t3.Location = new Point(390, 112);
            t3.Name = "t3";
            t3.Size = new Size(89, 42);
            t3.TabIndex = 2;
            t3.Text = "_";
            t3.UseVisualStyleBackColor = true;
            t3.Click += Right_Top_Click;
            // 
            // m1
            // 
            m1.Enabled = false;
            m1.Location = new Point(200, 161);
            m1.Name = "m1";
            m1.Size = new Size(89, 43);
            m1.TabIndex = 3;
            m1.Text = "_";
            m1.UseVisualStyleBackColor = true;
            m1.Click += Left_Middle_Click;
            // 
            // m2
            // 
            m2.Enabled = false;
            m2.Location = new Point(295, 161);
            m2.Name = "m2";
            m2.Size = new Size(89, 43);
            m2.TabIndex = 4;
            m2.Text = "_";
            m2.UseVisualStyleBackColor = true;
            m2.Click += Middle_Middle_Click;
            // 
            // m3
            // 
            m3.Enabled = false;
            m3.Location = new Point(390, 161);
            m3.Name = "m3";
            m3.Size = new Size(89, 43);
            m3.TabIndex = 5;
            m3.Text = "_";
            m3.UseVisualStyleBackColor = true;
            m3.Click += Right_Middle_Click;
            // 
            // b1
            // 
            b1.Enabled = false;
            b1.Location = new Point(200, 210);
            b1.Name = "b1";
            b1.Size = new Size(89, 43);
            b1.TabIndex = 6;
            b1.Text = "_";
            b1.UseVisualStyleBackColor = true;
            b1.Click += Left_Bottom_Click;
            // 
            // b2
            // 
            b2.Enabled = false;
            b2.Location = new Point(295, 210);
            b2.Name = "b2";
            b2.Size = new Size(89, 43);
            b2.TabIndex = 7;
            b2.Text = "_";
            b2.UseVisualStyleBackColor = true;
            b2.Click += Middle_Bottom_Click;
            // 
            // b3
            // 
            b3.Enabled = false;
            b3.Location = new Point(390, 210);
            b3.Name = "b3";
            b3.Size = new Size(89, 43);
            b3.TabIndex = 8;
            b3.Text = "_";
            b3.UseVisualStyleBackColor = true;
            b3.Click += Right_Bottom_Click;
            // 
            // Start_Button
            // 
            Start_Button.Location = new Point(29, 307);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(107, 27);
            Start_Button.TabIndex = 11;
            Start_Button.Text = "Start";
            Start_Button.UseVisualStyleBackColor = true;
            Start_Button.Click += Start_Button_Click;
            // 
            // Info_Box
            // 
            Info_Box.BackColor = SystemColors.Control;
            Info_Box.BorderStyle = BorderStyle.None;
            Info_Box.Location = new Point(196, 310);
            Info_Box.Name = "Info_Box";
            Info_Box.Size = new Size(188, 16);
            Info_Box.TabIndex = 12;
            // 
            // player_turn_counter
            // 
            player_turn_counter.BackColor = SystemColors.Control;
            player_turn_counter.BorderStyle = BorderStyle.None;
            player_turn_counter.Location = new Point(610, 318);
            player_turn_counter.Name = "player_turn_counter";
            player_turn_counter.Size = new Size(48, 16);
            player_turn_counter.TabIndex = 13;
            player_turn_counter.Text = "1";
            player_turn_counter.Visible = false;
            // 
            // Player_1
            // 
            Player_1.Location = new Point(29, 24);
            Player_1.Name = "Player_1";
            Player_1.Size = new Size(144, 19);
            Player_1.TabIndex = 14;
            Player_1.Text = "Player1";
            // 
            // Player_2
            // 
            Player_2.Location = new Point(514, 24);
            Player_2.Name = "Player_2";
            Player_2.Size = new Size(144, 19);
            Player_2.TabIndex = 15;
            Player_2.Text = "Player2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 362);
            Controls.Add(Player_2);
            Controls.Add(Player_1);
            Controls.Add(player_turn_counter);
            Controls.Add(Info_Box);
            Controls.Add(Start_Button);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(m3);
            Controls.Add(m2);
            Controls.Add(m1);
            Controls.Add(t3);
            Controls.Add(t2);
            Controls.Add(t1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button t1;
        private Button t2;
        private Button t3;
        private Button m1;
        private Button m2;
        private Button m3;
        private Button b1;
        private Button b2;
        private Button b3;
        private TextBox SA;
        private Button Start_Button;
        private TextBox Info_Box;
        private TextBox player_turn_counter;
        private Label Player_1;
        private Label Player_2;
    }
}
