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
            symbolChoice_label = new Label();
            xChoice_button = new Button();
            oChoice_button = new Button();
            firstPlayerChoice_label = new Label();
            secondPlayerChoice_label = new Label();
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
            gameField_panel.Location = new Point(261, 114);
            gameField_panel.Name = "gameField_panel";
            gameField_panel.Size = new Size(281, 266);
            gameField_panel.TabIndex = 0;
            // 
            // middleLower
            // 
            middleLower.Location = new Point(108, 180);
            middleLower.Name = "middleLower";
            middleLower.Size = new Size(64, 61);
            middleLower.TabIndex = 8;
            middleLower.UseVisualStyleBackColor = true;
            // 
            // leftLower
            // 
            leftLower.Location = new Point(20, 180);
            leftLower.Name = "leftLower";
            leftLower.Size = new Size(64, 61);
            leftLower.TabIndex = 7;
            leftLower.UseVisualStyleBackColor = true;
            // 
            // leftMiddle
            // 
            leftMiddle.Location = new Point(20, 103);
            leftMiddle.Name = "leftMiddle";
            leftMiddle.Size = new Size(64, 61);
            leftMiddle.TabIndex = 6;
            leftMiddle.UseVisualStyleBackColor = true;
            // 
            // rightMiddle
            // 
            rightMiddle.Location = new Point(197, 103);
            rightMiddle.Name = "rightMiddle";
            rightMiddle.Size = new Size(64, 61);
            rightMiddle.TabIndex = 5;
            rightMiddle.UseVisualStyleBackColor = true;
            // 
            // rightUpper
            // 
            rightUpper.Location = new Point(197, 22);
            rightUpper.Name = "rightUpper";
            rightUpper.Size = new Size(64, 61);
            rightUpper.TabIndex = 4;
            rightUpper.UseVisualStyleBackColor = true;
            // 
            // middleUpper
            // 
            middleUpper.Location = new Point(108, 22);
            middleUpper.Name = "middleUpper";
            middleUpper.Size = new Size(64, 61);
            middleUpper.TabIndex = 3;
            middleUpper.UseVisualStyleBackColor = true;
            // 
            // rightLower
            // 
            rightLower.Location = new Point(197, 180);
            rightLower.Name = "rightLower";
            rightLower.Size = new Size(64, 61);
            rightLower.TabIndex = 2;
            rightLower.UseVisualStyleBackColor = true;
            // 
            // middleMiddle
            // 
            middleMiddle.Location = new Point(108, 103);
            middleMiddle.Name = "middleMiddle";
            middleMiddle.Size = new Size(64, 61);
            middleMiddle.TabIndex = 1;
            middleMiddle.UseVisualStyleBackColor = true;
            // 
            // leftUpper
            // 
            leftUpper.Location = new Point(20, 22);
            leftUpper.Name = "leftUpper";
            leftUpper.Size = new Size(64, 61);
            leftUpper.TabIndex = 0;
            leftUpper.UseVisualStyleBackColor = true;
            // 
            // symbolChoice_panel
            // 
            symbolChoice_panel.Controls.Add(oChoice_button);
            symbolChoice_panel.Controls.Add(xChoice_button);
            symbolChoice_panel.Controls.Add(symbolChoice_label);
            symbolChoice_panel.Location = new Point(0, 0);
            symbolChoice_panel.Name = "symbolChoice_panel";
            symbolChoice_panel.Size = new Size(330, 108);
            symbolChoice_panel.TabIndex = 1;
            // 
            // symbolChoice_label
            // 
            symbolChoice_label.AutoSize = true;
            symbolChoice_label.Location = new Point(12, 9);
            symbolChoice_label.Name = "symbolChoice_label";
            symbolChoice_label.Size = new Size(289, 25);
            symbolChoice_label.TabIndex = 2;
            symbolChoice_label.Text = "Первый игрок, выберите символ:";
            // 
            // xChoice_button
            // 
            xChoice_button.Location = new Point(75, 37);
            xChoice_button.Name = "xChoice_button";
            xChoice_button.Size = new Size(56, 51);
            xChoice_button.TabIndex = 9;
            xChoice_button.Text = "Х";
            xChoice_button.UseVisualStyleBackColor = true;
            // 
            // oChoice_button
            // 
            oChoice_button.Location = new Point(158, 37);
            oChoice_button.Name = "oChoice_button";
            oChoice_button.Size = new Size(56, 51);
            oChoice_button.TabIndex = 10;
            oChoice_button.Text = "О";
            oChoice_button.UseVisualStyleBackColor = true;
            // 
            // firstPlayerChoice_label
            // 
            firstPlayerChoice_label.AutoSize = true;
            firstPlayerChoice_label.Location = new Point(12, 128);
            firstPlayerChoice_label.Name = "firstPlayerChoice_label";
            firstPlayerChoice_label.Size = new Size(0, 25);
            firstPlayerChoice_label.TabIndex = 2;
            // 
            // secondPlayerChoice_label
            // 
            secondPlayerChoice_label.AutoSize = true;
            secondPlayerChoice_label.Location = new Point(576, 114);
            secondPlayerChoice_label.Name = "secondPlayerChoice_label";
            secondPlayerChoice_label.Size = new Size(0, 25);
            secondPlayerChoice_label.TabIndex = 3;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(secondPlayerChoice_label);
            Controls.Add(firstPlayerChoice_label);
            Controls.Add(symbolChoice_panel);
            Controls.Add(gameField_panel);
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
    }
}