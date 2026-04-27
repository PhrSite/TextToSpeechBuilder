namespace TextToSpeechBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            PrependSilenceMilliSecondsTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SpeechTextTb = new TextBox();
            label4 = new Label();
            AppendSilenceMilliSecondsTb = new TextBox();
            label5 = new Label();
            CloseBtn = new Button();
            CreateBtn = new Button();
            label6 = new Label();
            FileTb = new TextBox();
            Browse = new Button();
            label7 = new Label();
            SampleRateCombo = new ComboBox();
            label8 = new Label();
            VoiceCombo = new ComboBox();
            HelpBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 0;
            label1.Text = "Prepend Silence";
            // 
            // PrependSilenceMilliSecondsTb
            // 
            PrependSilenceMilliSecondsTb.Location = new Point(217, 32);
            PrependSilenceMilliSecondsTb.Name = "PrependSilenceMilliSecondsTb";
            PrependSilenceMilliSecondsTb.Size = new Size(125, 38);
            PrependSilenceMilliSecondsTb.TabIndex = 1;
            PrependSilenceMilliSecondsTb.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 32);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 2;
            label2.Text = "Milliseconds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(55, 31);
            label3.TabIndex = 3;
            label3.Text = "Text";
            // 
            // SpeechTextTb
            // 
            SpeechTextTb.Location = new Point(99, 99);
            SpeechTextTb.Multiline = true;
            SpeechTextTb.Name = "SpeechTextTb";
            SpeechTextTb.ScrollBars = ScrollBars.Vertical;
            SpeechTextTb.Size = new Size(618, 151);
            SpeechTextTb.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 5;
            label4.Text = "Append Silence";
            // 
            // AppendSilenceMilliSecondsTb
            // 
            AppendSilenceMilliSecondsTb.Location = new Point(217, 276);
            AppendSilenceMilliSecondsTb.Name = "AppendSilenceMilliSecondsTb";
            AppendSilenceMilliSecondsTb.Size = new Size(125, 38);
            AppendSilenceMilliSecondsTb.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 276);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 7;
            label5.Text = "Milliseconds";
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Location = new Point(612, 564);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(105, 41);
            CloseBtn.TabIndex = 9;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.AutoSize = true;
            CreateBtn.Location = new Point(502, 564);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(94, 41);
            CreateBtn.TabIndex = 8;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 483);
            label6.Name = "label6";
            label6.Size = new Size(49, 31);
            label6.TabIndex = 10;
            label6.Text = "File";
            // 
            // FileTb
            // 
            FileTb.Location = new Point(99, 483);
            FileTb.Name = "FileTb";
            FileTb.Size = new Size(618, 38);
            FileTb.TabIndex = 6;
            // 
            // Browse
            // 
            Browse.AutoSize = true;
            Browse.Location = new Point(99, 538);
            Browse.Name = "Browse";
            Browse.Size = new Size(105, 41);
            Browse.TabIndex = 7;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 343);
            label7.Name = "label7";
            label7.Size = new Size(142, 31);
            label7.TabIndex = 13;
            label7.Text = "Sample Rate";
            // 
            // SampleRateCombo
            // 
            SampleRateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            SampleRateCombo.FormattingEnabled = true;
            SampleRateCombo.Items.AddRange(new object[] { "8000", "16000" });
            SampleRateCombo.Location = new Point(217, 343);
            SampleRateCombo.Name = "SampleRateCombo";
            SampleRateCombo.Size = new Size(125, 39);
            SampleRateCombo.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 406);
            label8.Name = "label8";
            label8.Size = new Size(69, 31);
            label8.TabIndex = 15;
            label8.Text = "Voice";
            // 
            // VoiceCombo
            // 
            VoiceCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            VoiceCombo.FormattingEnabled = true;
            VoiceCombo.Items.AddRange(new object[] { "Female", "Male" });
            VoiceCombo.Location = new Point(217, 406);
            VoiceCombo.Name = "VoiceCombo";
            VoiceCombo.Size = new Size(125, 39);
            VoiceCombo.TabIndex = 5;
            // 
            // HelpBtn
            // 
            HelpBtn.AutoSize = true;
            HelpBtn.Location = new Point(372, 564);
            HelpBtn.Name = "HelpBtn";
            HelpBtn.Size = new Size(105, 41);
            HelpBtn.TabIndex = 16;
            HelpBtn.Text = "Help";
            HelpBtn.UseVisualStyleBackColor = true;
            HelpBtn.Click += HelpBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(750, 617);
            Controls.Add(HelpBtn);
            Controls.Add(VoiceCombo);
            Controls.Add(label8);
            Controls.Add(SampleRateCombo);
            Controls.Add(label7);
            Controls.Add(Browse);
            Controls.Add(FileTb);
            Controls.Add(label6);
            Controls.Add(CreateBtn);
            Controls.Add(CloseBtn);
            Controls.Add(label5);
            Controls.Add(AppendSilenceMilliSecondsTb);
            Controls.Add(label4);
            Controls.Add(SpeechTextTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PrependSilenceMilliSecondsTb);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextToSpeechBuilder";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PrependSilenceMilliSecondsTb;
        private Label label2;
        private Label label3;
        private TextBox SpeechTextTb;
        private Label label4;
        private TextBox AppendSilenceMilliSecondsTb;
        private Label label5;
        private Button CloseBtn;
        private Button CreateBtn;
        private Label label6;
        private TextBox FileTb;
        private Button Browse;
        private Label label7;
        private ComboBox SampleRateCombo;
        private Label label8;
        private ComboBox VoiceCombo;
        private Button HelpBtn;
    }
}
