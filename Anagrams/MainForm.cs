using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrams
{
    public partial class MainForm : Form
    {
        private readonly AnagramAnalyzer _anagrams;

        public MainForm()
        {
            InitializeComponent();
            this._anagrams = new AnagramAnalyzer();
            RefreshListBox();
        }


        private void analyseButton_Click(object sender, EventArgs e)
        {
            _anagrams.Analyze();
            RefreshListBox();
        }


        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.AddRange(_anagrams.GetAllStrings().ToArray());
            }
        }

        private void serializeButton_Click(object sender, EventArgs e)
        {

            _anagrams.Serialize(encryptCheckBox.Checked,compressCheckBox.Checked);
           // refreshListBox();
        }

        private void deserializeButton_Click(object sender, EventArgs e)
        {
            _anagrams.Deserialize(encryptCheckBox.Checked, compressCheckBox.Checked);
            RefreshListBox();
        }
        
    }
}
