﻿namespace FirstDesktopApp
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
            cbProfession = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbProfession
            // 
            cbProfession.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProfession.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProfession.FormattingEnabled = true;
            cbProfession.Items.AddRange(new object[] { "Öğretmen", "Öğrenci", "Veli" });
            cbProfession.Location = new Point(158, 136);
            cbProfession.Name = "cbProfession";
            cbProfession.Size = new Size(121, 23);
            cbProfession.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(158, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cbProfession);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbProfession;
        private Button btnSave;
    }
}