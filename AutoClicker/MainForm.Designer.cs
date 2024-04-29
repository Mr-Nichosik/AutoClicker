namespace AutoClicker
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            StartStopButton = new Button();
            menuStrip1 = new MenuStrip();
            AboutProgramToolStripMenu = new ToolStripMenuItem();
            Time = new Timer(components);
            StatusLabel = new Label();
            NumUpDown = new NumericUpDown();
            NumericUpDownabel = new Label();
            TopMostWindowButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumUpDown).BeginInit();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            StartStopButton.Location = new System.Drawing.Point(12, 91);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new System.Drawing.Size(165, 32);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Старт";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStop;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { AboutProgramToolStripMenu });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(384, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // AboutProgramToolStripMenu
            // 
            AboutProgramToolStripMenu.Name = "AboutProgramToolStripMenu";
            AboutProgramToolStripMenu.Size = new System.Drawing.Size(94, 20);
            AboutProgramToolStripMenu.Text = "О программе";
            AboutProgramToolStripMenu.Click += AboutProgram;
            // 
            // Time
            // 
            Time.Tick += TimerTick;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            StatusLabel.Location = new System.Drawing.Point(12, 33);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(82, 17);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Остановлен";
            // 
            // NumUpDown
            // 
            NumUpDown.BorderStyle = BorderStyle.FixedSingle;
            NumUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            NumUpDown.Location = new System.Drawing.Point(118, 54);
            NumUpDown.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            NumUpDown.Name = "NumUpDown";
            NumUpDown.Size = new System.Drawing.Size(99, 25);
            NumUpDown.TabIndex = 4;
            NumUpDown.ThousandsSeparator = true;
            // 
            // NumericUpDownabel
            // 
            NumericUpDownabel.AutoSize = true;
            NumericUpDownabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            NumericUpDownabel.Location = new System.Drawing.Point(12, 62);
            NumericUpDownabel.Name = "NumericUpDownabel";
            NumericUpDownabel.Size = new System.Drawing.Size(100, 17);
            NumericUpDownabel.TabIndex = 5;
            NumericUpDownabel.Text = "Задержка (мс):";
            // 
            // TopMostWindowButton
            // 
            TopMostWindowButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            TopMostWindowButton.Location = new System.Drawing.Point(207, 91);
            TopMostWindowButton.Name = "TopMostWindowButton";
            TopMostWindowButton.Size = new System.Drawing.Size(165, 32);
            TopMostWindowButton.TabIndex = 1;
            TopMostWindowButton.Text = "Закрепить окно";
            TopMostWindowButton.UseVisualStyleBackColor = true;
            TopMostWindowButton.Click += SwitchTopMost;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 135);
            Controls.Add(NumericUpDownabel);
            Controls.Add(NumUpDown);
            Controls.Add(StatusLabel);
            Controls.Add(TopMostWindowButton);
            Controls.Add(StartStopButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "AutoClicker";
            Load += MainFormLoad;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AboutProgramToolStripMenu;
        private System.Windows.Forms.Timer Time;
        private Label StatusLabel;
        private NumericUpDown NumUpDown;
        private Label NumericUpDownabel;
        private Button TopMostWindowButton;
    }
}