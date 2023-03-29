
namespace Szyfr_cezara
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Tekst = new System.Windows.Forms.TextBox();
            this.Przesuniecie = new System.Windows.Forms.NumericUpDown();
            this.male = new System.Windows.Forms.CheckBox();
            this.wielkie = new System.Windows.Forms.CheckBox();
            this.cyfry = new System.Windows.Forms.CheckBox();
            this.Szyfruj = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Przesuniecie)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "&Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tekst do zaszyfrowania:";
            // 
            // Tekst
            // 
            this.Tekst.Location = new System.Drawing.Point(284, 91);
            this.Tekst.Name = "Tekst";
            this.Tekst.Size = new System.Drawing.Size(282, 20);
            this.Tekst.TabIndex = 5;
            // 
            // Przesuniecie
            // 
            this.Przesuniecie.Location = new System.Drawing.Point(86, 147);
            this.Przesuniecie.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Przesuniecie.Name = "Przesuniecie";
            this.Przesuniecie.Size = new System.Drawing.Size(36, 20);
            this.Przesuniecie.TabIndex = 6;
            this.Przesuniecie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.CheckState = System.Windows.Forms.CheckState.Checked;
            this.male.Location = new System.Drawing.Point(167, 150);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(40, 17);
            this.male.TabIndex = 7;
            this.male.Text = "a-z";
            this.male.UseVisualStyleBackColor = true;
            // 
            // wielkie
            // 
            this.wielkie.AutoSize = true;
            this.wielkie.Location = new System.Drawing.Point(284, 150);
            this.wielkie.Name = "wielkie";
            this.wielkie.Size = new System.Drawing.Size(43, 17);
            this.wielkie.TabIndex = 8;
            this.wielkie.Text = "A-Z";
            this.wielkie.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            this.cyfry.AutoSize = true;
            this.cyfry.Location = new System.Drawing.Point(386, 150);
            this.cyfry.Name = "cyfry";
            this.cyfry.Size = new System.Drawing.Size(41, 17);
            this.cyfry.TabIndex = 9;
            this.cyfry.Text = "0-9";
            this.cyfry.UseVisualStyleBackColor = true;
            // 
            // Szyfruj
            // 
            this.Szyfruj.Location = new System.Drawing.Point(471, 147);
            this.Szyfruj.Name = "Szyfruj";
            this.Szyfruj.Size = new System.Drawing.Size(75, 23);
            this.Szyfruj.TabIndex = 10;
            this.Szyfruj.Text = "Szyfruj";
            this.Szyfruj.UseVisualStyleBackColor = true;
            this.Szyfruj.Click += new System.EventHandler(this.Szyfruj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 198);
            this.Controls.Add(this.Szyfruj);
            this.Controls.Add(this.cyfry);
            this.Controls.Add(this.wielkie);
            this.Controls.Add(this.male);
            this.Controls.Add(this.Przesuniecie);
            this.Controls.Add(this.Tekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Szyfr cezara";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Przesuniecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tekst;
        private System.Windows.Forms.NumericUpDown Przesuniecie;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox wielkie;
        private System.Windows.Forms.CheckBox cyfry;
        private System.Windows.Forms.Button Szyfruj;
    }
}

