namespace TicTacToe
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void xChoice_button_Click(object sender, EventArgs e)
        {
            if (firstPlayerChoice_label.Text == "")
            {
                firstPlayerChoice_label.Text = "Символ первого игрока: Х";
                symbolChoice_label.Text = "Второй игрок, выберите символ";
            }
            else if (firstPlayerChoice_label.Text == "Символ первого игрока: Х")
                MessageBox.Show("Этот символ уже занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "Символ первого игрока: Х")
            {
                secondPlayerChoice_label.Text = "Символ второго игрока: Х";
                symbolChoice_panel.Visible = false;
            }
        }

        private void oChoice_button_Click(object sender, EventArgs e)
        {
            if (firstPlayerChoice_label.Text == "")
            {
                firstPlayerChoice_label.Text = "Символ первого игрока: О";
                symbolChoice_label.Text = "Второй игрок, выберите символ";
            }
            else if (firstPlayerChoice_label.Text == "Символ первого игрока: О")
                MessageBox.Show("Этот символ уже занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "Символ первого игрока: O")
            {
                secondPlayerChoice_label.Text = "Символ второго игрока: О";
                symbolChoice_panel.Visible = false;
            }
        }
    }
}