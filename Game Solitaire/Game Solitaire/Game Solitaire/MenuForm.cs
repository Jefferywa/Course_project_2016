using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Game_Solitaire
{
    public partial class MenuForm : Form
    {
        int TogMove;
        int MValX;
        int MValY;
        const string Path = @"data\Cash.ini";
        string ScoreGlobal = null;
        private string LoginString;
        bool hasEnteredLogin = false;

        
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Change_UsersBox();
            
            /*if (!File.Exists(Path))
            {
                Change_UsersBox();
            }
            else
            {
                File.Create(Path);
                
            }*/

            CheckBox.Checked = Properties.Settings.Default.IsRemember;
            if (CheckBox.Checked)
            {
                LoginString = Properties.Settings.Default.Login.ToString();

                LoginBox.Text = LoginString;
                LoginBox.ForeColor = Color.White;
                hasEnteredLogin = true;
            }
            EasyLevelBtn.Visible = false;
            NormalLevelBtn.Visible = false;
            GreetingLable.Visible = false;
            PlayBtn.Visible = false;
            StatisticBtn.Visible = false;
            ExitBtn.Visible = false;
            BackBtn.Visible = false;
        }

        //stable function()
        bool CheckName(string text)
        {
            if (text.Length > 24 || text.Length < 6)
            {
                return false;
            }
            foreach (char ch in text)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public void FileCreate()
        {
            File.Create(Path);
        }

        public void Exit()
        {
            LoginBox.Visible = true;
            LoginBtn.Visible = true;
            CheckBox.Visible = true;
            UsersBox.Visible = true;

            PlayBtn.Visible = false;
            StatisticBtn.Visible = false;
            ExitBtn.Visible = false;
            GreetingLable.Visible = false;
        }

        public void LoginSuccessful()
        {
            LoginBox.Visible = false;
            LoginBtn.Visible = false;
            CheckBox.Visible = false;
            UsersBox.Visible = false;

            GreetingLable.Text = "Добро пожаловать, " + LoginBox.Text + "!";

            PlayBtn.Visible = true;
            StatisticBtn.Visible = true;
            ExitBtn.Visible = true;
            GreetingLable.Visible = true;
        }

        public void StatisticForm()
        {
            PlayBtn.Visible = false;
            ExitBtn.Visible = false;
            StatisticBtn.Visible = false;
            GreetingLable.Visible = false;

            BackBtn.Visible = true;
            StatisticList_1.Visible = true;
        }

        public void CashName()
        {
            string lines = File.ReadAllText(Path); //@"Cash.ini"
            if (lines.Contains(LoginBox.Text))
            {

            }
            else
            {
                using (StreamWriter sw = File.AppendText(Path)) //@"Cash.ini"
                {
                    sw.WriteLine(LoginBox.Text + " 0");
                }
            }
        }

        public void Change_UsersBox()
        {
            using (StreamReader sReader = new StreamReader(Path))//@"Cash.ini"
            {
                string line;
                UsersBox.BeginUpdate();
                while ((line = sReader.ReadLine()) != null)
                {
                    UsersBox.Items.Add(line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                }
                sReader.Close();
                UsersBox.EndUpdate();
            }
        }

        public void StatisticAdd()
        {
            using (StreamReader sReader = new StreamReader(Path)) //@"Cash.ini'
            {
                string line;

                while ((line = sReader.ReadLine()) != null)
                {
                    string[] values = line.Split(' ');

                    StatisticList_1.Items.Add(new ListViewItem(values));
                }
            }
        }


        //=================================================================//

        //Drag_Area
        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;  
        }

        private void MenuForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void MenuForm_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        //Minimize&close Btn

        //MinimizeBtn
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //CloseBtn
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //LoginBox
        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (!hasEnteredLogin)
            {
                LoginBox.ForeColor = Color.White;
                LoginBox.Text = "";
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (!hasEnteredLogin)
            {
                LoginBox.ForeColor = Color.Silver;
                LoginBox.Text = "Имя";
                hasEnteredLogin = false;
            }
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            hasEnteredLogin = LoginBox.Text.Length > 0;
        }

        //Event KeyDown(Press LoginBtn)
        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
        //CheckBox Seve Name
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRemember = CheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        //Event BtnLogin
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!CheckName(LoginBox.Text))
            {
                MessageBox.Show("Имя должно соответствовать следующим требованиям: Не должно быть меньше 6 или больше 24, Не должно содержать спец. символы.");
                LoginBox.Focus();

                return;
            }
            else
            {
                string LoginString = LoginBox.Text;

                if (CheckBox.Checked)
                {
                    Properties.Settings.Default["Login"] = LoginString;
                }

                Properties.Settings.Default.Save();

                CashName();
                LoginSuccessful();
            }         
        }
        //User's Saved
        private void UsersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginBox.Text = (UsersBox.SelectedItem).ToString();
        }
        //MenuBtn's

        //PlayBtn
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            EasyLevelBtn.Visible = true;
            NormalLevelBtn.Visible = true;

            GreetingLable.Visible = false;
            PlayBtn.Visible = false;
            StatisticBtn.Visible = false;
            ExitBtn.Visible = false;
            BackBtn.Visible = true;
        }

        private void EasyLevelBtn_Click(object sender, EventArgs e)
        {
            int Time = 600;
            int Score = 0;

            string ScoreGlobal = Score.ToString();
            MessageBox.Show(ScoreGlobal);

            ProcessStartInfo Start = new ProcessStartInfo();
            Start.FileName = @"soliter.exe";
            Start.Arguments = string.Format("{0} {1} {2}" , LoginBox.Text, Score, Time);
            Process.Start(Start);
        }

        private void NormalLevelBtn_Click(object sender, EventArgs e)
        {
            int Time = 10;
            int Score = 0;

            ProcessStartInfo Start = new ProcessStartInfo();
            Start.FileName = @"soliter.exe";
            Start.Arguments = string.Format("{0} {1} {2}", LoginBox.Text, Score, Time);
            Process.Start(Start);
        }

        //StatisticBtn
        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            StatisticForm();
            StatisticAdd();
        }
        //Exitbtn
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit();
        }

        //StatisticForm
        private void BackBtn_Click(object sender, EventArgs e)
        {
            StatisticList_1.Items.Clear();

            PlayBtn.Visible = true;
            ExitBtn.Visible = true;
            StatisticBtn.Visible = true;
            GreetingLable.Visible = true;

            BackBtn.Visible = false;
            StatisticList_1.Visible = false;
            EasyLevelBtn.Visible = false;
            NormalLevelBtn.Visible = false;
        }

        
    }
}
