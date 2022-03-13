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

namespace Airis {
    public partial class AIAddNewWindow : Form {

        Methods methods = new Methods();

        string filePath = string.Empty;
        string fileName = string.Empty;

        public AIAddNewWindow() {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                filePath = openFileDialog.FileName;

            }
            txtBoxPath.Text = filePath;
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            Dictionary<string, string> list = methods.programmList();
            fileName = txtBoxProgrammName.Text;

            list.Add(fileName, filePath);

            File.WriteAllText(Environment.CurrentDirectory + "/resources/Programms.txt", "");
            foreach (KeyValuePair<string, string> kv in list) {
                File.AppendAllText(Environment.CurrentDirectory + "/resources/Programms.txt", kv.Key + "|" + kv.Value + "\n");
            }
            DialogResult result = MessageBox.Show("Programm Added", "Task Done, Please Restart", MessageBoxButtons.OK);
        }
    }

}
