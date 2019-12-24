using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using LevenstationDistance;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> WordList { get; set; }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            WordList = new List<string>();
            // open file dialog
            var fileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Текстовые файлы (*.txt)|*.txt"
            };
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "")
            {
                MessageBox.Show("Выберите файл");
                return;
            }

            var time = new Stopwatch();
            time.Start();
            // reading
            using (var sr = new StreamReader(fileDialog.FileName, Encoding.UTF8))
            {
                var text = sr.ReadToEnd();
                foreach (var word in text.Split())
                {
                    if (!WordList.Contains(word))
                    {
                        WordList.Add(word);
                    }
                }
            }
            time.Stop();

            // send result time to textbox
            var result = time.Elapsed.TotalMilliseconds;
            labelRead.Text = result.ToString();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int maxDistance;
            if (!int.TryParse(textBoxLength.Text.Trim(), out maxDistance))
            {
                MessageBox.Show("Неккоректные данные");
            }
            else
            {
                var time = new Stopwatch();
                time.Start();
                foreach(var item in WordList)
                {
                    if (Levenstain.Distance(item.ToLower(), textBox2.Text.ToLower()) < maxDistance)
                    {
                        listBox.BeginUpdate();
                        listBox.Items.Add(item);
                        listBox.EndUpdate();
                    }
                }
                time.Stop();

                var result = time.Elapsed.TotalMilliseconds;
                labelFind.Text = result.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
