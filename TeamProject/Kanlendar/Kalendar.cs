using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanlendar {
    public partial class Kalendar : Form {
        public Point MousePoint;
        public Size CalenderSize;
        public Kalendar() {
            InitializeComponent();            
            this.Size = new Size(this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height);
            CalenderSize = this.Size;
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e) {
            MousePoint = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                Location = new Point(this.Left - (MousePoint.X - e.X), this.Top - (MousePoint.Y - e.Y));
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnBigger_Click(object sender, EventArgs e) {
            if (CalenderSize == this.Size) {
                this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                            Screen.PrimaryScreen.WorkingArea.Height);
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Size.Width / 2,
                            Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Size.Height / 2);
            }
            else {
                this.Size = CalenderSize;
            }
        }

        private void btnHidding_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
