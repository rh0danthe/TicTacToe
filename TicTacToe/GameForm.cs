namespace TicTacToe
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            gameField_panel.Visible = false;
        }

        private char firstPlayerSymbol = '\0';
        private char secondPlayerSymbol = '\0';
        private char currentPlayerSymbol;
        private GameLogic gameLogic = new GameLogic();

        private void Choice_button_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            char symbol = senderButton.Text[0];
            if (firstPlayerChoice_label.Text == "")
            {
                firstPlayerChoice_label.Text = "������ ������� ������: " + symbol;
                symbolChoice_label.Text = "������ �����, �������� ������";
                firstPlayerSymbol = symbol;
                currentPlayerSymbol = firstPlayerSymbol;
            }
            else if (firstPlayerChoice_label.Text == "������ ������� ������: " + symbol)
                MessageBox.Show("���� ������ ��� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "������ ������� ������: " + symbol)
            {
                secondPlayerChoice_label.Text = "������ ������� ������: " + symbol;
                symbolChoice_panel.Visible = false;
                gameField_panel.Visible = true;
                secondPlayerSymbol = symbol;
            }
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.Text = currentPlayerSymbol.ToString();
            int senderTag = Convert.ToInt32(senderButton.Tag);
            if (gameLogic.makeMove(senderTag, currentPlayerSymbol))
            {
                gameField_panel.Visible = false;
                if (currentPlayerSymbol == firstPlayerSymbol)
                    message_label.Text = "������� ������ �����!";
                else message_label.Text = "������� ������ �����!";
            }
            senderButton.Enabled = false;
            if (currentPlayerSymbol == firstPlayerSymbol)
                currentPlayerSymbol = secondPlayerSymbol;
            else
                currentPlayerSymbol = firstPlayerSymbol;
        }
    }
}