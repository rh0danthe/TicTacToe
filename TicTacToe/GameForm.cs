namespace TicTacToe
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void Choice_button_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            string symbol = senderButton.Text;
            if (firstPlayerChoice_label.Text == "")
            {
                firstPlayerChoice_label.Text = "Символ первого игрока: " + symbol;
                symbolChoice_label.Text = "Второй игрок, выберите символ";
            }
            else if (firstPlayerChoice_label.Text == "Символ первого игрока: " + symbol)
                MessageBox.Show("Этот символ уже занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "Символ первого игрока: " + symbol)
            {
                secondPlayerChoice_label.Text = "Символ второго игрока: " + symbol;
                symbolChoice_panel.Visible = false;
            }
        }
    }
}