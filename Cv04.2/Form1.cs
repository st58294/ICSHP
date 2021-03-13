using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv04._2 {
    public partial class Form1 : Form {
        Random Random =  new Random();
        Stats stats = new Stats();
        public Form1() {
            stats.UpdatedStats += UpdatedStatsHandler;
            InitializeComponent();
        }

        public void UpdatedStatsHandler(object sender, EventArgs e) {
            Correct.Text = "Correct: " + stats.Correct.ToString();
            missedLabel.Text = "Missed: " + stats.Missed.ToString();
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            gameListBox.Items.Add((Keys)Random.Next('A', 'Z'));
            if (gameListBox.Items.Count >= 6) {
                timer1.Stop();
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over");
            }
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e) {
            if (gameListBox.Items.Contains(e.KeyCode)) {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();

                if (timer1.Interval > 400) {
                    timer1.Interval -= 60;
                } else if (timer1.Interval > 250) {
                    timer1.Interval -= 15;
                } else if (timer1.Interval > 150) {
                    timer1.Interval -= 8;
                } else {
                    throw new Exception();
                }  stats.Update(true);
            } else {
                stats.Update(false);
            }

            if (timer1.Interval > 0 && timer1.Interval < 800) {
              progressBar.Value = 800 - timer1.Interval;
            } else { 
                progressBar.Value = 0; 
            }
            stats.Update(true);
        }

    }
}
