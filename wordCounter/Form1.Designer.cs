
namespace wordCounter
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
            this.lbl_loadFile = new System.Windows.Forms.Label();
            this.lbl_splitWords = new System.Windows.Forms.Label();
            this.lbl_countWords = new System.Windows.Forms.Label();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_createWordList = new System.Windows.Forms.Button();
            this.btn_sortWords = new System.Windows.Forms.Button();
            this.btn_wordCount = new System.Windows.Forms.Button();
            this.btn_countSorted = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_loadFile
            // 
            this.lbl_loadFile.AutoSize = true;
            this.lbl_loadFile.Location = new System.Drawing.Point(55, 9);
            this.lbl_loadFile.Name = "lbl_loadFile";
            this.lbl_loadFile.Size = new System.Drawing.Size(117, 16);
            this.lbl_loadFile.TabIndex = 0;
            this.lbl_loadFile.Text = "1. Load a Text File";
            // 
            // lbl_splitWords
            // 
            this.lbl_splitWords.AutoSize = true;
            this.lbl_splitWords.Location = new System.Drawing.Point(303, 9);
            this.lbl_splitWords.Name = "lbl_splitWords";
            this.lbl_splitWords.Size = new System.Drawing.Size(151, 16);
            this.lbl_splitWords.TabIndex = 1;
            this.lbl_splitWords.Text = "2. Split the file into words";
            // 
            // lbl_countWords
            // 
            this.lbl_countWords.AutoSize = true;
            this.lbl_countWords.Location = new System.Drawing.Point(553, 9);
            this.lbl_countWords.Name = "lbl_countWords";
            this.lbl_countWords.Size = new System.Drawing.Size(227, 16);
            this.lbl_countWords.TabIndex = 2;
            this.lbl_countWords.Text = "3. Count the Frequency of Each Word";
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(25, 28);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(87, 58);
            this.btn_chooseFile.TabIndex = 3;
            this.btn_chooseFile.Text = "Choose a File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(138, 28);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 58);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_createWordList
            // 
            this.btn_createWordList.Location = new System.Drawing.Point(293, 28);
            this.btn_createWordList.Name = "btn_createWordList";
            this.btn_createWordList.Size = new System.Drawing.Size(87, 58);
            this.btn_createWordList.TabIndex = 5;
            this.btn_createWordList.Text = "Create Word List";
            this.btn_createWordList.UseVisualStyleBackColor = true;
            this.btn_createWordList.Click += new System.EventHandler(this.btn_createWordList_Click);
            // 
            // btn_sortWords
            // 
            this.btn_sortWords.Location = new System.Drawing.Point(404, 28);
            this.btn_sortWords.Name = "btn_sortWords";
            this.btn_sortWords.Size = new System.Drawing.Size(87, 58);
            this.btn_sortWords.TabIndex = 6;
            this.btn_sortWords.Text = "Sort Words";
            this.btn_sortWords.UseVisualStyleBackColor = true;
            this.btn_sortWords.Click += new System.EventHandler(this.btn_sortWords_Click);
            // 
            // btn_wordCount
            // 
            this.btn_wordCount.Location = new System.Drawing.Point(556, 28);
            this.btn_wordCount.Name = "btn_wordCount";
            this.btn_wordCount.Size = new System.Drawing.Size(87, 58);
            this.btn_wordCount.TabIndex = 7;
            this.btn_wordCount.Text = "Count";
            this.btn_wordCount.UseVisualStyleBackColor = true;
            this.btn_wordCount.Click += new System.EventHandler(this.btn_wordCount_Click);
            // 
            // btn_countSorted
            // 
            this.btn_countSorted.Location = new System.Drawing.Point(671, 28);
            this.btn_countSorted.Name = "btn_countSorted";
            this.btn_countSorted.Size = new System.Drawing.Size(87, 58);
            this.btn_countSorted.TabIndex = 8;
            this.btn_countSorted.Text = "Sort";
            this.btn_countSorted.UseVisualStyleBackColor = true;
            this.btn_countSorted.Click += new System.EventHandler(this.btn_countSorted_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 356);
            this.textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(293, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 356);
            this.listBox1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(565, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(193, 356);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_countSorted);
            this.Controls.Add(this.btn_wordCount);
            this.Controls.Add(this.btn_sortWords);
            this.Controls.Add(this.btn_createWordList);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.lbl_countWords);
            this.Controls.Add(this.lbl_splitWords);
            this.Controls.Add(this.lbl_loadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_loadFile;
        private System.Windows.Forms.Label lbl_splitWords;
        private System.Windows.Forms.Label lbl_countWords;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_createWordList;
        private System.Windows.Forms.Button btn_sortWords;
        private System.Windows.Forms.Button btn_wordCount;
        private System.Windows.Forms.Button btn_countSorted;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
    }
}

