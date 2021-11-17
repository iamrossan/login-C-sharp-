
namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openMenu
            // 
            this.openMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuForm2,
            this.MenuForm3,
            this.MenuForm4});
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(48, 20);
            this.openMenu.Text = "Open";
            // 
            // MenuForm2
            // 
            this.MenuForm2.Name = "MenuForm2";
            this.MenuForm2.Size = new System.Drawing.Size(180, 22);
            this.MenuForm2.Text = "Form2";
            this.MenuForm2.Click += new System.EventHandler(this.MenuForm2_Click);
            // 
            // MenuForm3
            // 
            this.MenuForm3.Name = "MenuForm3";
            this.MenuForm3.Size = new System.Drawing.Size(180, 22);
            this.MenuForm3.Text = "Form3";
            // 
            // MenuForm4
            // 
            this.MenuForm4.Name = "MenuForm4";
            this.MenuForm4.Size = new System.Drawing.Size(180, 22);
            this.MenuForm4.Text = "Form4";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuForm2;
        private System.Windows.Forms.ToolStripMenuItem MenuForm3;
        private System.Windows.Forms.ToolStripMenuItem MenuForm4;
    }
}