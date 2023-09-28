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
            leftUpper = new Button();
            middleMiddle = new Button();
            rightLower = new Button();
            middleUpper = new Button();
            rightUpper = new Button();
            rightMiddle = new Button();
            leftMiddle = new Button();
            leftLower = new Button();
            middleLower = new Button();
            gameField_panel.SuspendLayout();
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
            gameField_panel.Location = new Point(281, 114);
            gameField_panel.Name = "gameField_panel";
            gameField_panel.Size = new Size(281, 266);
            gameField_panel.TabIndex = 0;
            // 
            // leftUpper
            // 
            leftUpper.Location = new Point(20, 22);
            leftUpper.Name = "leftUpper";
            leftUpper.Size = new Size(64, 61);
            leftUpper.TabIndex = 0;
            leftUpper.UseVisualStyleBackColor = true;
            // 
            // middleMiddle
            // 
            middleMiddle.Location = new Point(108, 103);
            middleMiddle.Name = "middleMiddle";
            middleMiddle.Size = new Size(64, 61);
            middleMiddle.TabIndex = 1;
            middleMiddle.UseVisualStyleBackColor = true;
            // 
            // rightLower
            // 
            rightLower.Location = new Point(197, 180);
            rightLower.Name = "rightLower";
            rightLower.Size = new Size(64, 61);
            rightLower.TabIndex = 2;
            rightLower.UseVisualStyleBackColor = true;
            // 
            // middleUpper
            // 
            middleUpper.Location = new Point(108, 22);
            middleUpper.Name = "middleUpper";
            middleUpper.Size = new Size(64, 61);
            middleUpper.TabIndex = 3;
            middleUpper.UseVisualStyleBackColor = true;
            // 
            // rightUpper
            // 
            rightUpper.Location = new Point(197, 22);
            rightUpper.Name = "rightUpper";
            rightUpper.Size = new Size(64, 61);
            rightUpper.TabIndex = 4;
            rightUpper.UseVisualStyleBackColor = true;
            // 
            // rightMiddle
            // 
            rightMiddle.Location = new Point(197, 103);
            rightMiddle.Name = "rightMiddle";
            rightMiddle.Size = new Size(64, 61);
            rightMiddle.TabIndex = 5;
            rightMiddle.UseVisualStyleBackColor = true;
            // 
            // leftMiddle
            // 
            leftMiddle.Location = new Point(20, 103);
            leftMiddle.Name = "leftMiddle";
            leftMiddle.Size = new Size(64, 61);
            leftMiddle.TabIndex = 6;
            leftMiddle.UseVisualStyleBackColor = true;
            // 
            // leftLower
            // 
            leftLower.Location = new Point(20, 180);
            leftLower.Name = "leftLower";
            leftLower.Size = new Size(64, 61);
            leftLower.TabIndex = 7;
            leftLower.UseVisualStyleBackColor = true;
            // 
            // middleLower
            // 
            middleLower.Location = new Point(108, 180);
            middleLower.Name = "middleLower";
            middleLower.Size = new Size(64, 61);
            middleLower.TabIndex = 8;
            middleLower.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gameField_panel);
            Name = "GameForm";
            Text = "TicTacGame";
            gameField_panel.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}