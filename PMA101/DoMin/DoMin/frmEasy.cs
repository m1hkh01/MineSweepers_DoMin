using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace DoMin
{
    public partial class frmEasy : Form
    {
        private Button[,] buttons;
        private int gridSize = 10;
        private int[,] mines;
        private bool[,] revealed;
        private SoundPlayer clickSound;
        private string clickSoundPath;

        public frmEasy()
        {
            InitializeComponent();
            InitializeGame();
            DisableTabForAllButtons();
            DisableAnchorForAllControls();
            Hand_MouseEnter();
        }

        private void DisableAnchorForAllControls()
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Anchor = AnchorStyles.None;  // Tắt Anchor cho mọi control
            }
        }

        private void frmEasy_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMedium"] != null)
            {
                Application.OpenForms["frmMedium"].Close();
            }

            if (Application.OpenForms["frmHard"] != null)
            {
                Application.OpenForms["frmHard"].Close();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblTime.Text = FormatTime(elapsedTime);
        }

        // Hàm định dạng lại thời gian để hiển thị theo định dạng MM:ss
        private string FormatTime(int timeInSeconds)
        {
            int minutes = timeInSeconds / 60;
            int seconds = timeInSeconds % 60;
            return string.Format("{0:D2}:{1:D2}", minutes, seconds); // "MM:ss"
        }

        private void DisableAllButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void Hand_MouseEnter()
        {
            foreach (Button button in buttons)
            {
                button.Cursor = Cursors.Hand;
            }
        }

        private void GameOver(bool isWin)
        {
            gameTimer.Stop();
            DisableAllButtons();

            if (isWin)
            {
                MessageBox.Show("You Win! Time: " + lblTime.Text);
            }
            else
            {
                MessageBox.Show("You Lose! Time: " + lblTime.Text);
            }
        }

        private int remainingFlags = 10;
        private Label lblFlags;

        private void SetTimeAfterFirstClick()
        {

        }

        private void InitializeGame()
        {
            lblGridCount.Text = (gridSize * gridSize).ToString();

            FlagCount = 0;
            lblFlag.Text = FlagCount.ToString();
            elapsedTime = 0;
            lblTime.Text = FormatTime(elapsedTime);
            gameStarted = true;

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            buttons = new Button[gridSize, gridSize];
            mines = new int[gridSize, gridSize];
            revealed = new bool[gridSize, gridSize];

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Width = 40,
                        Height = 40,
                        Location = new Point(40 * j, 40 * i),
                        Tag = new Point(i, j),
                        BackColor = Color.YellowGreen,
                    };
                    buttons[i, j].Click += ButtonClick;
                    buttons[i, j].MouseDown += ButtonRightClick;
                    Controls.Add(buttons[i, j]);
                }
            }

            CenterButtons();
            RandomizeMines();
        }


        int FlagCount = 0;
        private void ButtonRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Phát âm thanh khi nhấn chuột phải để gắn cờ
                string filePathClick = @"D:\PTCD_FPT\PMA101\sound\clickSound.wav";
                try
                {
                    SoundPlayer player = new SoundPlayer(filePathClick);
                    player.Play();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể phát âm thanh: " + ex.Message);
                }

                Button clickedButton = sender as Button;
                Point position = (Point)clickedButton.Tag;
                int row = position.X;
                int col = position.Y;

                if (!revealed[row, col])
                {
                    // Nếu chưa có cờ
                    if (clickedButton.Image == null)
                    {
                        clickedButton.Image = Image.FromFile("D:\\PTCD_FPT\\PMA101\\icon\\vietnam.png"); // Đặt hình ảnh lá cờ
                        clickedButton.BackColor = Color.YellowGreen;
                        FlagCount++;
                        lblFlag.Text = FlagCount.ToString();
                    }
                    else // Nếu có cờ thì gỡ cờ
                    {
                        clickedButton.Image = null;
                        clickedButton.BackColor = Color.YellowGreen;
                        FlagCount--;
                        lblFlag.Text = FlagCount.ToString();
                    }
                }
            }
        }




        private void Button_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void CenterButtons()
        {
            int totalWidth = gridSize * 40;
            int totalHeight = gridSize * 40;

            int leftMargin = (ClientSize.Width - totalWidth) / 2;
            int topMargin = (ClientSize.Height - totalHeight) / 2;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    buttons[i, j].Location = new Point(leftMargin + 40 * j, topMargin + 40 * i);
                }
            }
        }

        private void RandomizeMines()
        {
            Random random = new Random();
            int numberOfMines = 10;

            int placedMines = 0;
            while (placedMines < numberOfMines)
            {
                int row = random.Next(gridSize);
                int col = random.Next(gridSize);

                if (mines[row, col] == 0)
                {
                    mines[row, col] = 1;
                    placedMines++;
                }
            }
        }

        private int GetSurroundingMines(int row, int col)
        {
            int mineCount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;

                    if (newRow >= 0 && newRow < gridSize && newCol >= 0 && newCol < gridSize)
                    {
                        if (mines[newRow, newCol] == 1)
                        {
                            mineCount++;
                        }
                    }
                }
            }
            return mineCount;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            // Phát âm thanh khi nhấp chuột trái vào nút
            string filePathClick = @"D:\PTCD_FPT\PMA101\sound\clickSound.wav";
            try
            {
                SoundPlayer player = new SoundPlayer(filePathClick);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể phát âm thanh: " + ex.Message);
            }

            Button clickedButton = sender as Button;
            Point position = (Point)clickedButton.Tag;
            int row = position.X;
            int col = position.Y;
            clickedButton.Font = new Font(clickedButton.Font, FontStyle.Bold);

            if (mines[row, col] == 1)  // Nếu là mìn
            {
                string filePathLose = @"D:\PTCD_FPT\PMA101\sound\loseSound.wav";
                try
                {
                    SoundPlayer player = new SoundPlayer(filePathLose);
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể phát âm thanh: " + ex.Message);
                }
                clickedButton.Image = Image.FromFile("D:\\PTCD_FPT\\PMA101\\icon\\bomb.png");
                clickedButton.BackColor = Color.LightGreen;
                RevealAllButtons();
                GameOver(false);
                return;
            }

            clickedButton.BackColor = Color.LightGreen;
            int surroundingMines = GetSurroundingMines(row, col);
            clickedButton.Text = surroundingMines == 0 ? "" : surroundingMines.ToString();
            clickedButton.Enabled = false;
            revealed[row, col] = true;

            // Giảm số ô còn lại khi người chơi mở một ô
            int remainingGridCount = int.Parse(lblGridCount.Text) - 1; // Giảm 1 ô
            lblGridCount.Text = remainingGridCount.ToString(); // Cập nhật lblGridCount

            if (surroundingMines == 0)
            {
                RevealAdjacentButtons(row, col);
            }

            if (CheckWin())
            {
                string filePathWin = @"D:\PTCD_FPT\PMA101\sound\winSound.wav";
                try
                {
                    SoundPlayer player = new SoundPlayer(filePathWin);
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể phát âm thanh: " + ex.Message);
                }
                GameOver(true);
            }
        }


        private bool CheckWin()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (mines[i, j] != 1 && !revealed[i, j])
                    {
                        return false;
                    }
                    if (mines[i, j] == 1 && revealed[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void RevealAdjacentButtons(int row, int col)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;

                    if (newRow >= 0 && newRow < gridSize && newCol >= 0 && newCol < gridSize && !revealed[newRow, newCol])
                    {
                        Button adjacentButton = buttons[newRow, newCol];
                        adjacentButton.BackColor = Color.LightGreen;
                        adjacentButton.PerformClick();
                    }
                }
            }
        }

        // hàm mở các ô còn lại khi thua
        private void RevealAllButtons()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Button button = buttons[i, j];
                    if (mines[i, j] == 1)
                    {
                        button.BackColor = Color.LightCoral;
                        button.Image = Image.FromFile("D:\\PTCD_FPT\\PMA101\\icon\\bomb.png");
                    }
                    else
                    {
                        button.BackColor = Color.LightGreen;
                        int surroundingMines = GetSurroundingMines(i, j);
                        button.Text = surroundingMines == 0 ? "" : surroundingMines.ToString();
                    }
                    button.Enabled = false;
                }
            }
        }

        // hàm tắt tab control cho form
        private void DisableTabForAllButtons()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.TabStop = false;
                }
            }
        }

        private Timer gameTimer;
        private int elapsedTime;
        private bool gameStarted;



        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnFlagCount_Click(object sender, EventArgs e)
        {

        }

        private void lblBomb_Click(object sender, EventArgs e)
        {

        }

        private void btnSound_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMute_Click(object sender, EventArgs e)
        {
        }

        private void lblGridCount_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            FlagCount = 0;
            lblFlag.Text = FlagCount.ToString();
            elapsedTime = 0;
            lblTime.Text = FormatTime(elapsedTime);
            gameStarted = false;

            if (gameTimer.Enabled)
            {
                gameTimer.Stop();
            }

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    buttons[i, j].Dispose();
                }
            }

            InitializeGame();

            gameTimer.Start();
            Cursor.Current = Cursors.Default;
            Hand_MouseEnter();
        }

        private void lblFlag_Click(object sender, EventArgs e)
        {

        }
    }
}
