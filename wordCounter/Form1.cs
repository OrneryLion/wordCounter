using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_createWordList_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            string[] wordsArray = allWords.Split(' ', ',', '.', '-', '!');

            foreach(string word in wordsArray)
            {
                if (!listBox1.Items.Contains(word))
                    listBox1.Items.Add(word);
            }
            
        }

        private void btn_sortWords_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btn_wordCount_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            string[] wordsArray = allWords.Split(' ', ',', '.', '-', '!');

            List<wordCounter> wordCounters = new List<wordCounter>();

            foreach (string w in wordsArray)
            {
                wordCounter foundWord = wordCounters.Find(x => x.word == w);
                if (foundWord == null)
                {
                    wordCounters.Add(new wordCounter(w, 1));
                }
                else
                {
                    foundWord.frequency++;
                }
            }
            listView1.Columns.Add("word", 100);
            listView1.Columns.Add("Frequency", 70);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            

            foreach(wordCounter word in wordCounters)
            {
                string[] rowItem = new string[] { word.word, word.frequency.ToString() };
                listView1.Items.Add(new ListViewItem(rowItem));
            }
            
        }

        private void btn_countSorted_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }
    }
}
