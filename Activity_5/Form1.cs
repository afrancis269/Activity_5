using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Activity_5
{
    public partial class Form1 : Form
    {
        public string fileName;
        public string readFile;
        string[] words;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            NameFileTxb.Text = fileName;
           
            
                    
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
                readFile = File.ReadAllText(fileName);
                readFile = readFile.ToLower();
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(readFile);
                }
            words = readFile.Split(' ');

        }

        private void FirstWordBtn_Click(object sender, EventArgs e)
        {
            FirstTxb.Text = words.First();
        }

        private void LastWordBtn_Click(object sender, EventArgs e)
        {
            LastTxb.Text = words.Last();
        }

        private void LongestWordBtn_Click(object sender, EventArgs e)
        {
            string longString = words[0];

            foreach(string word in words)
            {
                if (word.Length > longString.Length) {
                    longString = word;
                }
            }

            LongTxb.Text = longString;
        }

        private void MostVowelsBtn_Click(object sender, EventArgs e)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int mostVowels = 0;

            string vowelString = words[0];

            foreach(var vowel in vowels)
            {
                if (vowelString.Contains(vowel)) mostVowels += 1;
            }

            foreach(string word in words)
            {
                int numberOfVowels = 0;
                foreach (var vowel in vowels)
                {
                    if (word.Contains(vowel)) numberOfVowels += 1;
                }

                if (mostVowels < numberOfVowels)
                {
                    mostVowels = numberOfVowels;
                    vowelString = word;
                    
                }
            }

            VowelTxb.Text = vowelString;
        }
    }
}
