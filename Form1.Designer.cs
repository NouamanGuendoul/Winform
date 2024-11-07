namespace WINForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RTBcontect = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            reduToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copeToolStripMenuItem = new ToolStripMenuItem();
            pastToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            prefenrencesToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            styleToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorToolStripMenuItem = new ToolStripMenuItem();
            hideTesktToolStripMenuItem = new ToolStripMenuItem();
            unhideTesktToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            supportToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RTBcontect
            // 
            RTBcontect.Location = new Point(347, 56);
            RTBcontect.Name = "RTBcontect";
            RTBcontect.Size = new Size(148, 503);
            RTBcontect.TabIndex = 0;
            RTBcontect.Text = "";
            RTBcontect.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, infoToolStripMenuItem, prefenrencesToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(940, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(139, 26);
            openToolStripMenuItem.Text = "open";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(139, 26);
            newToolStripMenuItem.Text = "new";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(139, 26);
            saveToolStripMenuItem.Text = "save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(139, 26);
            saveAsToolStripMenuItem.Text = "save as";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(139, 26);
            quitToolStripMenuItem.Text = "quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, reduToolStripMenuItem, cutToolStripMenuItem, copeToolStripMenuItem, pastToolStripMenuItem, selectAllToolStripMenuItem1, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(150, 26);
            undoToolStripMenuItem.Text = "undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // reduToolStripMenuItem
            // 
            reduToolStripMenuItem.Name = "reduToolStripMenuItem";
            reduToolStripMenuItem.Size = new Size(150, 26);
            reduToolStripMenuItem.Text = "redu";
            reduToolStripMenuItem.Click += reduToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(150, 26);
            cutToolStripMenuItem.Text = "cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copeToolStripMenuItem
            // 
            copeToolStripMenuItem.Name = "copeToolStripMenuItem";
            copeToolStripMenuItem.Size = new Size(150, 26);
            copeToolStripMenuItem.Text = "cope";
            copeToolStripMenuItem.Click += copeToolStripMenuItem_Click;
            // 
            // pastToolStripMenuItem
            // 
            pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            pastToolStripMenuItem.Size = new Size(150, 26);
            pastToolStripMenuItem.Text = "past";
            // 
            // selectAllToolStripMenuItem1
            // 
            selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            selectAllToolStripMenuItem1.Size = new Size(150, 26);
            selectAllToolStripMenuItem1.Text = "select all";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(150, 26);
            clearToolStripMenuItem.Text = "clear";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "info";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // prefenrencesToolStripMenuItem
            // 
            prefenrencesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, backgroundColorToolStripMenuItem, hideTesktToolStripMenuItem, unhideTesktToolStripMenuItem });
            prefenrencesToolStripMenuItem.Name = "prefenrencesToolStripMenuItem";
            prefenrencesToolStripMenuItem.Size = new Size(108, 24);
            prefenrencesToolStripMenuItem.Text = "prefenrences";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { styleToolStripMenuItem, colorToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(209, 26);
            fontToolStripMenuItem.Text = "font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // styleToolStripMenuItem
            // 
            styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            styleToolStripMenuItem.Size = new Size(126, 26);
            styleToolStripMenuItem.Text = "style";
            styleToolStripMenuItem.Click += styleToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(126, 26);
            colorToolStripMenuItem.Text = "color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // backgroundColorToolStripMenuItem
            // 
            backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            backgroundColorToolStripMenuItem.Size = new Size(209, 26);
            backgroundColorToolStripMenuItem.Text = "background color";
            backgroundColorToolStripMenuItem.Click += backgroundColorToolStripMenuItem_Click;
            // 
            // hideTesktToolStripMenuItem
            // 
            hideTesktToolStripMenuItem.Name = "hideTesktToolStripMenuItem";
            hideTesktToolStripMenuItem.Size = new Size(209, 26);
            hideTesktToolStripMenuItem.Text = "hide teskt";
            hideTesktToolStripMenuItem.Click += hideTesktToolStripMenuItem_Click;
            // 
            // unhideTesktToolStripMenuItem
            // 
            unhideTesktToolStripMenuItem.Name = "unhideTesktToolStripMenuItem";
            unhideTesktToolStripMenuItem.Size = new Size(209, 26);
            unhideTesktToolStripMenuItem.Text = "unhide teskt";
            unhideTesktToolStripMenuItem.Click += unhideTesktToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1, supportToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(52, 24);
            helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(224, 26);
            aboutToolStripMenuItem1.Text = "about";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new Size(224, 26);
            supportToolStripMenuItem.Text = "support";
            supportToolStripMenuItem.Click += supportToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Schermafbeelding_2022_09_14_094053;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(940, 571);
            Controls.Add(RTBcontect);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "nouaman";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RTBcontect;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem reduToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copeToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem prefenrencesToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem styleToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem hideTesktToolStripMenuItem;
        private ToolStripMenuItem unhideTesktToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem supportToolStripMenuItem;
    }
}
