using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcousticsNowPlaying {
    public partial class InputBox : Form {
        public InputBox() {
            InitializeComponent();
        }

        public string Password {
            get { return textBox1.Text; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void InputBox_Load(object sender, EventArgs e) {
            textBox1.Focus();
        }
    }
}
