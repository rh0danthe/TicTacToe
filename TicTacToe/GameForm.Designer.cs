namespace TicTacToe
{
    partial class GameForm
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
            gameField_panel = new Panel();
            middleLower = new Button();
            leftLower = new Button();
            leftMiddle = new Button();
            rightMiddle = new Button();
            rightUpper = new Button();
            middleUpper = new Button();
            rightLower = new Button();
            middleMiddle = new Button();
            leftUpper = new Button();
            symbolChoice_panel = new Panel();
            oChoice_button = new Button();
            xChoice_button = new Button();
            symbolChoice_label = new Label();
            firstPlayerChoice_label = new Label();
            secondPlayerChoice_label = new Label();
            message_label = new Label();
            gameField_panel.SuspendLayout();
            symbolChoice_panel.SuspendLayout();
            SuspendLayout();
            // 
            // gameField_panel
            // 
            gameField_panel.BorderStyle = BorderStyle.FixedSingle;
            gameField_panel.Controls.Add(middleLower);
            gameField_panel.Controls.Add(leftLower);
            gameField_panel.Controls.Add(leftMiddle);
            gameField_panel.Controls.Add(rightMiddle);
            gameField_panel.Controls.Add(rightUpper);
            gameField_panel.Controls.Add(middleUpper);
            gameField_panel.Controls.Add(rightLower);
            gameField_panel.Controls.Add(middleMiddle);
            gameField_panel.Controls.Add(leftUpper);
            gameField_panel.Location = new Point(209, 91);
            gameField_panel.Margin = new Padding(2);
            gameField_panel.Name = "gameField_panel";
            gameField_panel.Size = new Size(225, 213);
            gameField_panel.TabIndex = 0;
            // 
            // middleLower
            // 
            middleLower.FlatStyle = FlatStyle.Flat;
            middleLower.Location = new Point(86, 144);
            middleLower.Margin = new Padding(2);
            middleLower.Name = "middleLower";
            middleLower.Size = new Size(51, 49);
            middleLower.TabIndex = 8;
            middleLower.Tag = "7";
            middleLower.UseVisualStyleBackColor = true;
            middleLower.Click += Play_button_Click;
            // 
            // leftLower
            // 
            leftLower.FlatStyle = FlatStyle.Flat;
            leftLower.Location = new Point(16, 144);
            leftLower.Margin = new Padding(2);
            leftLower.Name = "leftLower";
            leftLower.Size = new Size(51, 49);
            leftLower.TabIndex = 7;
            leftLower.Tag = "6";
            leftLower.UseVisualStyleBackColor = true;
            leftLower.Click += Play_button_Click;
            // 
            // leftMiddle
            // 
            leftMiddle.FlatStyle = FlatStyle.Flat;
            leftMiddle.Location = new Point(16, 82);
            leftMiddle.Margin = new Padding(2);
            leftMiddle.Name = "leftMiddle";
            leftMiddle.Size = new Size(51, 49);
            leftMiddle.TabIndex = 6;
            leftMiddle.Tag = "3";
            leftMiddle.UseVisualStyleBackColor = true;
            leftMiddle.Click += Play_button_Click;
            // 
            // rightMiddle
            // 
            rightMiddle.FlatStyle = FlatStyle.Flat;
            rightMiddle.Location = new Point(158, 82);
            rightMiddle.Margin = new Padding(2);
            rightMiddle.Name = "rightMiddle";
            rightMiddle.Size = new Size(51, 49);
            rightMiddle.TabIndex = 5;
            rightMiddle.Tag = "5";
            rightMiddle.UseVisualStyleBackColor = true;
            rightMiddle.Click += Play_button_Click;
            // 
            // rightUpper
            // 
            rightUpper.FlatStyle = FlatStyle.Flat;
            rightUpper.Location = new Point(158, 18);
            rightUpper.Margin = new Padding(2);
            rightUpper.Name = "rightUpper";
            rightUpper.Size = new Size(51, 49);
            rightUpper.TabIndex = 4;
            rightUpper.Tag = "2";
            rightUpper.UseVisualStyleBackColor = true;
            rightUpper.Click += Play_button_Click;
            // 
            // middleUpper
            // 
            middleUpper.FlatStyle = FlatStyle.Flat;
            middleUpper.Location = new Point(86, 18);
            middleUpper.Margin = new Padding(2);
            middleUpper.Name = "middleUpper";
            middleUpper.Size = new Size(51, 49);
            middleUpper.TabIndex = 3;
            middleUpper.Tag = "1";
            middleUpper.UseVisualStyleBackColor = true;
            middleUpper.Click += Play_button_Click;
            // 
            // rightLower
            // 
            rightLower.FlatStyle = FlatStyle.Flat;
            rightLower.Location = new Point(158, 144);
            rightLower.Margin = new Padding(2);
            rightLower.Name = "rightLower";
            rightLower.Size = new Size(51, 49);
            rightLower.TabIndex = 2;
            rightLower.Tag = "8";
            rightLower.UseVisualStyleBackColor = true;
            rightLower.Click += Play_button_Click;
            // 
            // middleMiddle
            // 
            middleMiddle.FlatStyle = FlatStyle.Flat;
            middleMiddle.Location = new Point(86, 82);
            middleMiddle.Margin = new Padding(2);
            middleMiddle.Name = "middleMiddle";
            middleMiddle.Size = new Size(51, 49);
            middleMiddle.TabIndex = 1;
            middleMiddle.Tag = "4";
            middleMiddle.UseVisualStyleBackColor = true;
            middleMiddle.Click += Play_button_Click;
            // 
            // leftUpper
            // 
            leftUpper.FlatStyle = FlatStyle.Flat;
            leftUpper.Location = new Point(16, 18);
            leftUpper.Margin = new Padding(2);
            leftUpper.Name = "leftUpper";
            leftUpper.Size = new Size(51, 49);
            leftUpper.TabIndex = 0;
            leftUpper.Tag = "0";
            leftUpper.UseVisualStyleBackColor = false;
            leftUpper.Click += Play_button_Click;
            // 
            // symbolChoice_panel
            // 
            symbolChoice_panel.Controls.Add(oChoice_button);
            symbolChoice_panel.Controls.Add(xChoice_button);
            symbolChoice_panel.Controls.Add(symbolChoice_label);
            symbolChoice_panel.Location = new Point(0, 0);
            symbolChoice_panel.Margin = new Padding(2);
            symbolChoice_panel.Name = "symbolChoice_panel";
            symbolChoice_panel.Size = new Size(264, 86);
            symbolChoice_panel.TabIndex = 1;
            // 
            // oChoice_button
            // 
            oChoice_button.Location = new Point(126, 30);
            oChoice_button.Margin = new Padding(2);
            oChoice_button.Name = "oChoice_button";
            oChoice_button.Size = new Size(45, 41);
            oChoice_button.TabIndex = 10;
            oChoice_button.Text = "О";
            oChoice_button.UseVisualStyleBackColor = true;
            oChoice_button.Click += Choice_button_Click;
            // 
            // xChoice_button
            // 
            xChoice_button.Location = new Point(60, 30);
            xChoice_button.Margin = new Padding(2);
            xChoice_button.Name = "xChoice_button";
            xChoice_button.Size = new Size(45, 41);
            xChoice_button.TabIndex = 9;
            xChoice_button.Text = "Х";
            xChoice_button.UseVisualStyleBackColor = true;
            xChoice_button.Click += Choice_button_Click;
            // 
            // symbolChoice_label
            // 
            symbolChoice_label.AutoSize = true;
            symbolChoice_label.Location = new Point(10, 7);
            symbolChoice_label.Margin = new Padding(2, 0, 2, 0);
            symbolChoice_label.Name = "symbolChoice_label";
            symbolChoice_label.Size = new Size(243, 20);
            symbolChoice_label.TabIndex = 2;
            symbolChoice_label.Text = "Первый игрок, выберите символ:";
            // 
            // firstPlayerChoice_label
            // 
            firstPlayerChoice_label.AutoSize = true;
            firstPlayerChoice_label.Location = new Point(10, 102);
            firstPlayerChoice_label.Margin = new Padding(2, 0, 2, 0);
            firstPlayerChoice_label.Name = "firstPlayerChoice_label";
            firstPlayerChoice_label.Size = new Size(0, 20);
            firstPlayerChoice_label.TabIndex = 2;
            // 
            // secondPlayerChoice_label
            // 
            secondPlayerChoice_label.AutoSize = true;
            secondPlayerChoice_label.Location = new Point(446, 102);
            secondPlayerChoice_label.Margin = new Padding(2, 0, 2, 0);
            secondPlayerChoice_label.Name = "secondPlayerChoice_label";
            secondPlayerChoice_label.Size = new Size(0, 20);
            secondPlayerChoice_label.TabIndex = 3;
            // 
            // message_label
            // 
            message_label.AutoSize = true;
            message_label.Location = new Point(230, 203);
            message_label.Name = "message_label";
            message_label.Size = new Size(0, 20);
            message_label.TabIndex = 9;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(message_label);
            Controls.Add(secondPlayerChoice_label);
            Controls.Add(firstPlayerChoice_label);
            Controls.Add(symbolChoice_panel);
            Controls.Add(gameField_panel);
            Margin = new Padding(2);
            Name = "GameForm";
            Text = "TicTacGame";
            gameField_panel.ResumeLayout(false);
            symbolChoice_panel.ResumeLayout(false);
            symbolChoice_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel gameField_panel;
        private Button middleLower;
        private Button leftLower;
        private Button leftMiddle;
        private Button rightMiddle;
        private Button rightUpper;
        private Button middleUpper;
        private Button rightLower;
        private Button middleMiddle;
        private Button leftUpper;
        private Panel symbolChoice_panel;
        private Label symbolChoice_label;
        private Button oChoice_button;
        private Button xChoice_button;
        private Label firstPlayerChoice_label;
        private Label secondPlayerChoice_label;
        private Label message_label;
    }
}