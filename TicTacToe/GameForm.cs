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
                firstPlayerChoice_label.Text = "������ ������� ������: �";
                symbolChoice_label.Text = "������ �����, �������� ������";
            }
            else if (firstPlayerChoice_label.Text == "������ ������� ������: �")
                MessageBox.Show("���� ������ ��� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "������ ������� ������: �")
            {
                secondPlayerChoice_label.Text = "������ ������� ������: �";
                symbolChoice_panel.Visible = false;
            }
        }

        private void oChoice_button_Click(object sender, EventArgs e)
        {
            if (firstPlayerChoice_label.Text == "")
            {
                firstPlayerChoice_label.Text = "������ ������� ������: �";
                symbolChoice_label.Text = "������ �����, �������� ������";
            }
            else if (firstPlayerChoice_label.Text == "������ ������� ������: �")
                MessageBox.Show("���� ������ ��� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firstPlayerChoice_label.Text != "������ ������� ������: O")
            {
                secondPlayerChoice_label.Text = "������ ������� ������: �";
                symbolChoice_panel.Visible = false;
            }
        }
    }
}