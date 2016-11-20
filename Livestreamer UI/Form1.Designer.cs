namespace Livestreamer_UI
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Quality_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stream_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayStream_Button = new System.Windows.Forms.Button();
            this.Favorites_ListView = new System.Windows.Forms.ListView();
            this.Stream = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveStream_Button = new System.Windows.Forms.Button();
            this.DeleteSaved_Button = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Help_Button = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Source_TextBox = new System.Windows.Forms.TextBox();
            this.Main_NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // Quality_ComboBox
            // 
            this.Quality_ComboBox.FormattingEnabled = true;
            this.Quality_ComboBox.Items.AddRange(new object[] {
            "Mobile",
            "Low",
            "Medium",
            "High",
            "Source"});
            this.Quality_ComboBox.Location = new System.Drawing.Point(408, 30);
            this.Quality_ComboBox.Name = "Quality_ComboBox";
            this.Quality_ComboBox.Size = new System.Drawing.Size(88, 24);
            this.Quality_ComboBox.TabIndex = 5;
            this.Quality_ComboBox.Text = "Quality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quality";
            // 
            // Stream_TextBox
            // 
            this.Stream_TextBox.Location = new System.Drawing.Point(167, 29);
            this.Stream_TextBox.Name = "Stream_TextBox";
            this.Stream_TextBox.Size = new System.Drawing.Size(235, 23);
            this.Stream_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stream";
            // 
            // PlayStream_Button
            // 
            this.PlayStream_Button.Location = new System.Drawing.Point(10, 68);
            this.PlayStream_Button.Name = "PlayStream_Button";
            this.PlayStream_Button.Size = new System.Drawing.Size(100, 25);
            this.PlayStream_Button.TabIndex = 6;
            this.PlayStream_Button.Text = "Play Stream";
            this.PlayStream_Button.UseVisualStyleBackColor = true;
            this.PlayStream_Button.Click += new System.EventHandler(this.PlayStream_Clicked);
            // 
            // Favorites_ListView
            // 
            this.Favorites_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stream,
            this.Source,
            this.Quality,
            this.IsOn});
            this.Favorites_ListView.Location = new System.Drawing.Point(12, 110);
            this.Favorites_ListView.MultiSelect = false;
            this.Favorites_ListView.Name = "Favorites_ListView";
            this.Favorites_ListView.Size = new System.Drawing.Size(484, 272);
            this.Favorites_ListView.TabIndex = 11;
            this.Favorites_ListView.UseCompatibleStateImageBehavior = false;
            this.Favorites_ListView.View = System.Windows.Forms.View.Details;
            this.Favorites_ListView.ItemActivate += new System.EventHandler(this.Favorites_ListView_ItemActivate);
            // 
            // Stream
            // 
            this.Stream.Text = "Stream";
            // 
            // Source
            // 
            this.Source.Text = "Source";
            this.Source.Width = 55;
            // 
            // Quality
            // 
            this.Quality.Text = "Quality";
            this.Quality.Width = 70;
            // 
            // IsOn
            // 
            this.IsOn.Text = "Is on?";
            this.IsOn.Width = 47;
            // 
            // SaveStream_Button
            // 
            this.SaveStream_Button.Location = new System.Drawing.Point(116, 68);
            this.SaveStream_Button.Name = "SaveStream_Button";
            this.SaveStream_Button.Size = new System.Drawing.Size(98, 25);
            this.SaveStream_Button.TabIndex = 7;
            this.SaveStream_Button.Text = "Save Stream";
            this.SaveStream_Button.UseVisualStyleBackColor = true;
            this.SaveStream_Button.Click += new System.EventHandler(this.SaveStream_Clicked);
            // 
            // DeleteSaved_Button
            // 
            this.DeleteSaved_Button.Location = new System.Drawing.Point(220, 68);
            this.DeleteSaved_Button.Name = "DeleteSaved_Button";
            this.DeleteSaved_Button.Size = new System.Drawing.Size(108, 25);
            this.DeleteSaved_Button.TabIndex = 8;
            this.DeleteSaved_Button.Text = "Delete Saved";
            this.DeleteSaved_Button.UseVisualStyleBackColor = true;
            this.DeleteSaved_Button.Click += new System.EventHandler(this.DeleteSaved_Clicked);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(423, 68);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(70, 25);
            this.About.TabIndex = 10;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Clicked);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(334, 68);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(83, 25);
            this.Help_Button.TabIndex = 9;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Clicked);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 60000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source";
            // 
            // Source_TextBox
            // 
            this.Source_TextBox.Location = new System.Drawing.Point(10, 29);
            this.Source_TextBox.Name = "Source_TextBox";
            this.Source_TextBox.Size = new System.Drawing.Size(151, 23);
            this.Source_TextBox.TabIndex = 3;
            this.Source_TextBox.Text = "Twitch.tv";
            // 
            // Main_NotifyIcon
            // 
            this.Main_NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("Main_NotifyIcon.Icon")));
            this.Main_NotifyIcon.Text = "Main_NotifyIcon";
            this.Main_NotifyIcon.Visible = true;
            this.Main_NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mynotifyicon_doubleclick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 394);
            this.Controls.Add(this.Source_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.About);
            this.Controls.Add(this.DeleteSaved_Button);
            this.Controls.Add(this.SaveStream_Button);
            this.Controls.Add(this.Favorites_ListView);
            this.Controls.Add(this.PlayStream_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stream_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quality_ComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Livestreamer UI";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Quality_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stream_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlayStream_Button;
        private System.Windows.Forms.ListView Favorites_ListView;
        private System.Windows.Forms.Button SaveStream_Button;
        private System.Windows.Forms.Button DeleteSaved_Button;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.ColumnHeader Stream;
        private System.Windows.Forms.ColumnHeader Quality;
        private System.Windows.Forms.ColumnHeader IsOn;
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Source_TextBox;
        private System.Windows.Forms.NotifyIcon Main_NotifyIcon;
    }
}

