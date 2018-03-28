namespace Game_Solitaire
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.GreetingLable = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.UsersBox = new System.Windows.Forms.ComboBox();
            this.StatisticBtn = new System.Windows.Forms.Button();
            this.StatisticList_1 = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackBtn = new System.Windows.Forms.Button();
            this.NormalLevelBtn = new System.Windows.Forms.Button();
            this.EasyLevelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.BackgroundImage")));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeBtn.Location = new System.Drawing.Point(742, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MinimizeBtn.TabIndex = 16;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.BackgroundImage")));
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.Location = new System.Drawing.Point(768, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(20, 20);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.Black;
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.ForeColor = System.Drawing.Color.Silver;
            this.LoginBox.Location = new System.Drawing.Point(300, 190);
            this.LoginBox.MaxLength = 28;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginBox.Size = new System.Drawing.Size(200, 35);
            this.LoginBox.TabIndex = 14;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Имя";
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginBox_KeyDown);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.Location = new System.Drawing.Point(300, 259);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(200, 36);
            this.LoginBtn.TabIndex = 13;
            this.LoginBtn.Text = "Подтвердить";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // GreetingLable
            // 
            this.GreetingLable.AutoSize = true;
            this.GreetingLable.BackColor = System.Drawing.Color.Transparent;
            this.GreetingLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GreetingLable.Location = new System.Drawing.Point(12, 19);
            this.GreetingLable.Name = "GreetingLable";
            this.GreetingLable.Size = new System.Drawing.Size(0, 19);
            this.GreetingLable.TabIndex = 18;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.White;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayBtn.Location = new System.Drawing.Point(300, 174);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(200, 36);
            this.PlayBtn.TabIndex = 19;
            this.PlayBtn.Text = "Играть";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Visible = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(300, 258);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(200, 36);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBox.ForeColor = System.Drawing.Color.White;
            this.CheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox.Location = new System.Drawing.Point(318, 227);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(182, 26);
            this.CheckBox.TabIndex = 22;
            this.CheckBox.TabStop = false;
            this.CheckBox.Text = "Запомнить меня?";
            this.CheckBox.UseVisualStyleBackColor = false;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // UsersBox
            // 
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(79, 197);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(215, 21);
            this.UsersBox.TabIndex = 24;
            this.UsersBox.Text = "Уже существующие пользователи:";
            this.UsersBox.SelectedIndexChanged += new System.EventHandler(this.UsersBox_SelectedIndexChanged);
            // 
            // StatisticBtn
            // 
            this.StatisticBtn.BackColor = System.Drawing.Color.White;
            this.StatisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticBtn.Location = new System.Drawing.Point(300, 216);
            this.StatisticBtn.Name = "StatisticBtn";
            this.StatisticBtn.Size = new System.Drawing.Size(200, 36);
            this.StatisticBtn.TabIndex = 25;
            this.StatisticBtn.Text = "Статистика";
            this.StatisticBtn.UseVisualStyleBackColor = false;
            this.StatisticBtn.Visible = false;
            this.StatisticBtn.Click += new System.EventHandler(this.StatisticBtn_Click);
            // 
            // StatisticList_1
            // 
            this.StatisticList_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PointsColumn});
            this.StatisticList_1.GridLines = true;
            this.StatisticList_1.Location = new System.Drawing.Point(506, 38);
            this.StatisticList_1.Name = "StatisticList_1";
            this.StatisticList_1.Size = new System.Drawing.Size(282, 371);
            this.StatisticList_1.TabIndex = 26;
            this.StatisticList_1.UseCompatibleStateImageBehavior = false;
            this.StatisticList_1.View = System.Windows.Forms.View.Details;
            this.StatisticList_1.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Имя";
            this.NameColumn.Width = 141;
            // 
            // PointsColumn
            // 
            this.PointsColumn.Text = "Очки";
            this.PointsColumn.Width = 141;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(16, 402);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(133, 36);
            this.BackBtn.TabIndex = 27;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NormalLevelBtn
            // 
            this.NormalLevelBtn.BackColor = System.Drawing.Color.White;
            this.NormalLevelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalLevelBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalLevelBtn.Location = new System.Drawing.Point(506, 132);
            this.NormalLevelBtn.Name = "NormalLevelBtn";
            this.NormalLevelBtn.Size = new System.Drawing.Size(200, 36);
            this.NormalLevelBtn.TabIndex = 28;
            this.NormalLevelBtn.Text = "Нормальный";
            this.NormalLevelBtn.UseVisualStyleBackColor = false;
            this.NormalLevelBtn.Visible = false;
            this.NormalLevelBtn.Click += new System.EventHandler(this.NormalLevelBtn_Click);
            // 
            // EasyLevelBtn
            // 
            this.EasyLevelBtn.BackColor = System.Drawing.Color.White;
            this.EasyLevelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyLevelBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLevelBtn.Location = new System.Drawing.Point(94, 132);
            this.EasyLevelBtn.Name = "EasyLevelBtn";
            this.EasyLevelBtn.Size = new System.Drawing.Size(200, 36);
            this.EasyLevelBtn.TabIndex = 29;
            this.EasyLevelBtn.Text = "Легкий";
            this.EasyLevelBtn.UseVisualStyleBackColor = false;
            this.EasyLevelBtn.Visible = false;
            this.EasyLevelBtn.Click += new System.EventHandler(this.EasyLevelBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Game_Solitaire.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EasyLevelBtn);
            this.Controls.Add(this.NormalLevelBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StatisticList_1);
            this.Controls.Add(this.StatisticBtn);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.GreetingLable);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label GreetingLable;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.ComboBox UsersBox;
        private System.Windows.Forms.Button StatisticBtn;
        private System.Windows.Forms.ListView StatisticList_1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PointsColumn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NormalLevelBtn;
        private System.Windows.Forms.Button EasyLevelBtn;
    }
}