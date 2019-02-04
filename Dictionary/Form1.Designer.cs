namespace Dictionary
{
    partial class Form1
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
            this.DictionaryTabControl = new System.Windows.Forms.TabControl();
            this.AddWordsTab = new System.Windows.Forms.TabPage();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.EnterDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EnterDescriptionLabel = new System.Windows.Forms.Label();
            this.EnterWordTextBox = new System.Windows.Forms.TextBox();
            this.EnterWordLabel = new System.Windows.Forms.Label();
            this.SearchDictionaryTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchWordsTextbox = new System.Windows.Forms.TextBox();
            this.SearchwordLabel = new System.Windows.Forms.Label();
            this.DictionaryTabControl.SuspendLayout();
            this.AddWordsTab.SuspendLayout();
            this.SearchDictionaryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictionaryTabControl
            // 
            this.DictionaryTabControl.Controls.Add(this.AddWordsTab);
            this.DictionaryTabControl.Controls.Add(this.SearchDictionaryTab);
            this.DictionaryTabControl.Location = new System.Drawing.Point(14, 27);
            this.DictionaryTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DictionaryTabControl.Name = "DictionaryTabControl";
            this.DictionaryTabControl.SelectedIndex = 0;
            this.DictionaryTabControl.Size = new System.Drawing.Size(1066, 379);
            this.DictionaryTabControl.TabIndex = 0;
            // 
            // AddWordsTab
            // 
            this.AddWordsTab.Controls.Add(this.AddWordButton);
            this.AddWordsTab.Controls.Add(this.EnterDescriptionTextBox);
            this.AddWordsTab.Controls.Add(this.EnterDescriptionLabel);
            this.AddWordsTab.Controls.Add(this.EnterWordTextBox);
            this.AddWordsTab.Controls.Add(this.EnterWordLabel);
            this.AddWordsTab.Location = new System.Drawing.Point(4, 25);
            this.AddWordsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddWordsTab.Name = "AddWordsTab";
            this.AddWordsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddWordsTab.Size = new System.Drawing.Size(1058, 350);
            this.AddWordsTab.TabIndex = 0;
            this.AddWordsTab.Text = "Add Word To Dictionary";
            this.AddWordsTab.UseVisualStyleBackColor = true;
            // 
            // AddWordButton
            // 
            this.AddWordButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWordButton.Location = new System.Drawing.Point(292, 294);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(257, 33);
            this.AddWordButton.TabIndex = 4;
            this.AddWordButton.Text = "Add Word to Dictionary";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.AddWordButton_Click);
            // 
            // EnterDescriptionTextBox
            // 
            this.EnterDescriptionTextBox.Location = new System.Drawing.Point(292, 150);
            this.EnterDescriptionTextBox.Multiline = true;
            this.EnterDescriptionTextBox.Name = "EnterDescriptionTextBox";
            this.EnterDescriptionTextBox.ShortcutsEnabled = false;
            this.EnterDescriptionTextBox.Size = new System.Drawing.Size(439, 125);
            this.EnterDescriptionTextBox.TabIndex = 3;
            this.EnterDescriptionTextBox.TextChanged += new System.EventHandler(this.EnterDescriptionTextBox_TextChanged);
            // 
            // EnterDescriptionLabel
            // 
            this.EnterDescriptionLabel.AutoSize = true;
            this.EnterDescriptionLabel.Location = new System.Drawing.Point(74, 155);
            this.EnterDescriptionLabel.Name = "EnterDescriptionLabel";
            this.EnterDescriptionLabel.Size = new System.Drawing.Size(108, 16);
            this.EnterDescriptionLabel.TabIndex = 2;
            this.EnterDescriptionLabel.Text = "Enter Description";
            // 
            // EnterWordTextBox
            // 
            this.EnterWordTextBox.Location = new System.Drawing.Point(292, 66);
            this.EnterWordTextBox.Name = "EnterWordTextBox";
            this.EnterWordTextBox.ShortcutsEnabled = false;
            this.EnterWordTextBox.Size = new System.Drawing.Size(439, 22);
            this.EnterWordTextBox.TabIndex = 1;
            this.EnterWordTextBox.Tag = "Enter New Word";
            this.EnterWordTextBox.TextChanged += new System.EventHandler(this.EnterWordTextBox_TextChanged);
            // 
            // EnterWordLabel
            // 
            this.EnterWordLabel.AutoSize = true;
            this.EnterWordLabel.Location = new System.Drawing.Point(71, 66);
            this.EnterWordLabel.Name = "EnterWordLabel";
            this.EnterWordLabel.Size = new System.Drawing.Size(103, 16);
            this.EnterWordLabel.TabIndex = 0;
            this.EnterWordLabel.Text = "Enter New Word";
            // 
            // SearchDictionaryTab
            // 
            this.SearchDictionaryTab.Controls.Add(this.listView1);
            this.SearchDictionaryTab.Controls.Add(this.SearchWordsTextbox);
            this.SearchDictionaryTab.Controls.Add(this.SearchwordLabel);
            this.SearchDictionaryTab.Location = new System.Drawing.Point(4, 25);
            this.SearchDictionaryTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchDictionaryTab.Name = "SearchDictionaryTab";
            this.SearchDictionaryTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchDictionaryTab.Size = new System.Drawing.Size(1058, 350);
            this.SearchDictionaryTab.TabIndex = 1;
            this.SearchDictionaryTab.Text = "Search Dictionary";
            this.SearchDictionaryTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.word,
            this.description});
            this.listView1.Location = new System.Drawing.Point(67, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(963, 236);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // word
            // 
            this.word.Text = "Word";
            this.word.Width = 304;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 632;
            // 
            // SearchWordsTextbox
            // 
            this.SearchWordsTextbox.Location = new System.Drawing.Point(256, 44);
            this.SearchWordsTextbox.Name = "SearchWordsTextbox";
            this.SearchWordsTextbox.ShortcutsEnabled = false;
            this.SearchWordsTextbox.Size = new System.Drawing.Size(470, 22);
            this.SearchWordsTextbox.TabIndex = 1;
            this.SearchWordsTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchWordsKeyUp);
            // 
            // SearchwordLabel
            // 
            this.SearchwordLabel.AutoSize = true;
            this.SearchwordLabel.Location = new System.Drawing.Point(64, 44);
            this.SearchwordLabel.Name = "SearchwordLabel";
            this.SearchwordLabel.Size = new System.Drawing.Size(91, 16);
            this.SearchwordLabel.TabIndex = 0;
            this.SearchwordLabel.Text = "Search Words";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 428);
            this.Controls.Add(this.DictionaryTabControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.DictionaryTabControl.ResumeLayout(false);
            this.AddWordsTab.ResumeLayout(false);
            this.AddWordsTab.PerformLayout();
            this.SearchDictionaryTab.ResumeLayout(false);
            this.SearchDictionaryTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DictionaryTabControl;
        private System.Windows.Forms.TabPage AddWordsTab;
        private System.Windows.Forms.TabPage SearchDictionaryTab;
        private System.Windows.Forms.TextBox EnterDescriptionTextBox;
        private System.Windows.Forms.Label EnterDescriptionLabel;
        private System.Windows.Forms.TextBox EnterWordTextBox;
        private System.Windows.Forms.Label EnterWordLabel;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader word;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.TextBox SearchWordsTextbox;
        private System.Windows.Forms.Label SearchwordLabel;
    }
}

