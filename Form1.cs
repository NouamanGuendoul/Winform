namespace WINForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void unhideTesktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Visible = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Undo();
        }

        private void reduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Cut();
        }

        private void copeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Copy();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RTBcontect.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RTBcontect.ForeColor = colorDialog1.Color;
            }
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RTBcontect.Font = fontDialog1.Font;
            }
        }

        private void hideTesktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Visible = false;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RTBcontect.Text = "ffffffff";
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBcontect.Text = "Call 6786576576";
        }
    }
}
 