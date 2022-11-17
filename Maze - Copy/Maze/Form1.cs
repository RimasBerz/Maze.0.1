using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
        }

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 40;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame() {
            Labirint l = new Labirint(this, 40, 20);
            l.Show();
        }

        

        private void Down(object sender, System.EventArgs e)
        {

        }

        private void Up(object sender, System.EventArgs e)
        {

        }

        private void Left(object sender, System.EventArgs e)
        {

        }

        private void Right(object sender, System.EventArgs e)
        {

        }

       
    }
}
