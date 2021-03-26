using System.Collections.Generic;
namespace Persik {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.Risovalka = new System.Windows.Forms.GroupBox();
            for (int i = 0; i < 100; i++)
            {
                this.RisPol[i] = new System.Windows.Forms.Panel();
                this.RisPol[i].BackColor = System.Drawing.Color.White;
                this.RisPol[i].Location = new System.Drawing.Point(5 + 30 * (i % 10), 20 + 30 * (i / 10));
                this.RisPol[i].Name = "RisPol";
                this.RisPol[i].Size = new System.Drawing.Size(30, 30);
                this.RisPol[i].TabIndex = i;
                this.RisPol[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.RisPol[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.RisPol_Paint);
                this.Risovalka.Controls.Add(this.RisPol[i]);
            }
            this.ColorBut_10 = new System.Windows.Forms.Button();
            this.ColorBut_08 = new System.Windows.Forms.Button();
            this.ColorBut_06 = new System.Windows.Forms.Button();
            this.ColorBut_04 = new System.Windows.Forms.Button();
            this.ColorBut_02 = new System.Windows.Forms.Button();
            this.ColorBut_00 = new System.Windows.Forms.Button();
            this.pan = new System.Windows.Forms.Panel();
            this.ShowDann = new System.Windows.Forms.Button();
            this.Learn = new System.Windows.Forms.Button();
            this.Sprosit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Droupa2 = new System.Windows.Forms.GroupBox();
            this.AddObject = new System.Windows.Forms.Button();
            this.BaseObject = new System.Windows.Forms.Button();
            this.ShowConsole = new System.Windows.Forms.Button();
            this.WhatIsIt = new System.Windows.Forms.TextBox();
            this.MyMemoryDock = new System.Windows.Forms.GroupBox();
            this.AllPata = new System.Windows.Forms.Panel();
            this.NewPers = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.Droupa2.SuspendLayout();
            this.MyMemoryDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // Risovalka
            // 
            this.Risovalka.BackColor = System.Drawing.Color.Azure;
            this.Risovalka.Location = new System.Drawing.Point(73, 27);
            this.Risovalka.Name = "Risovalka";
            this.Risovalka.Size = new System.Drawing.Size(310, 330);
            this.Risovalka.TabIndex = 0;
            this.Risovalka.TabStop = false;
            this.Risovalka.Text = "Рисуй тут";
            // 
            // ColorBut_10
            // 
            this.ColorBut_10.BackColor = System.Drawing.Color.Black;
            this.ColorBut_10.Location = new System.Drawing.Point(12, 19);
            this.ColorBut_10.Name = "ColorBut_10";
            this.ColorBut_10.Size = new System.Drawing.Size(30, 30);
            this.ColorBut_10.TabIndex = 10;
            this.ColorBut_10.Text = " ";
            this.ColorBut_10.UseVisualStyleBackColor = false;
            this.ColorBut_10.Click += new System.EventHandler(this.ColorBut_Click);
            // 
            // ColorBut_08
            // 
            this.ColorBut_08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColorBut_08.Location = new System.Drawing.Point(12, 55);
            this.ColorBut_08.Name = "ColorBut_08";
            this.ColorBut_08.Size = new System.Drawing.Size(30, 30);
            this.ColorBut_08.TabIndex = 8;
            this.ColorBut_08.Text = " ";
            this.ColorBut_08.UseVisualStyleBackColor = false;
            this.ColorBut_08.Click += new System.EventHandler(this.ColorBut_Click);
            // 
            // ColorBut_06
            // 
            this.ColorBut_06.BackColor = System.Drawing.Color.Gray;
            this.ColorBut_06.Location = new System.Drawing.Point(12, 91);
            this.ColorBut_06.Name = "ColorBut_06";
            this.ColorBut_06.Size = new System.Drawing.Size(30, 30);
            this.ColorBut_06.TabIndex = 6;
            this.ColorBut_06.Text = " ";
            this.ColorBut_06.UseVisualStyleBackColor = false;
            this.ColorBut_06.Click += new System.EventHandler(this.ColorBut_Click);
            // 
            // ColorBut_04
            // 
            this.ColorBut_04.BackColor = System.Drawing.Color.Silver;
            this.ColorBut_04.Location = new System.Drawing.Point(12, 127);
            this.ColorBut_04.Name = "ColorBut_04";
            this.ColorBut_04.Size = new System.Drawing.Size(30, 30);
            this.ColorBut_04.TabIndex = 4;
            this.ColorBut_04.Text = " ";
            this.ColorBut_04.UseVisualStyleBackColor = false;
            this.ColorBut_04.Click += new System.EventHandler(this.ColorBut_Click);
            // 
            // ColorBut_02
            // 
            this.ColorBut_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColorBut_02.Location = new System.Drawing.Point(12, 163);
            this.ColorBut_02.Name = "ColorBut_02";
            this.ColorBut_02.Size = new System.Drawing.Size(30, 30);
            this.ColorBut_02.TabIndex = 2;
            this.ColorBut_02.Text = " ";
            this.ColorBut_02.UseVisualStyleBackColor = false;
            this.ColorBut_02.Click += new System.EventHandler(this.ColorBut_Click);
            // 
            // ColorBut_00
            // 
            this.ColorBut_00.BackColor = System.Drawing.Color.White;
            this.ColorBut_00.Location = new System.Drawing.Point(12, 199);
            this.ColorBut_00.Name = "ColorBut_00";
            this.ColorBut_00.Size = new System.Drawing.Size(30, 30);
            this.ColorBut_00.TabIndex = 0;
            this.ColorBut_00.Text = " ";
            this.ColorBut_00.UseVisualStyleBackColor = false;
            this.ColorBut_00.Click += new System.EventHandler(this.ColorBut_Click);
            // 
            // pan
            // 
            this.pan.Controls.Add(this.ColorBut_10);
            this.pan.Controls.Add(this.ColorBut_08);
            this.pan.Controls.Add(this.ColorBut_06);
            this.pan.Controls.Add(this.ColorBut_00);
            this.pan.Controls.Add(this.ColorBut_04);
            this.pan.Controls.Add(this.ColorBut_02);
            this.pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan.Location = new System.Drawing.Point(0, 24);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(57, 399);
            this.pan.TabIndex = 7;
            // 
            // ShowDann
            // 
            this.ShowDann.Location = new System.Drawing.Point(73, 363);
            this.ShowDann.Name = "ShowDann";
            this.ShowDann.Size = new System.Drawing.Size(90, 54);
            this.ShowDann.TabIndex = 11;
            this.ShowDann.Text = "Показать входные данные";
            this.ShowDann.UseVisualStyleBackColor = true;
            this.ShowDann.Click += new System.EventHandler(this.ShowDann_Click);
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(183, 363);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(90, 54);
            this.Learn.TabIndex = 12;
            this.Learn.Text = "Учить";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // Sprosit
            // 
            this.Sprosit.Location = new System.Drawing.Point(293, 363);
            this.Sprosit.Name = "Sprosit";
            this.Sprosit.Size = new System.Drawing.Size(90, 54);
            this.Sprosit.TabIndex = 13;
            this.Sprosit.Text = "Спросить";
            this.Sprosit.UseVisualStyleBackColor = true;
            this.Sprosit.Click += new System.EventHandler(this.Sprosit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1012, 24);
            this.MainMenu.TabIndex = 14;
            this.MainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьПолеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьПолеToolStripMenuItem
            // 
            this.очиститьПолеToolStripMenuItem.Name = "очиститьПолеToolStripMenuItem";
            this.очиститьПолеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.очиститьПолеToolStripMenuItem.Text = "Очистить поле";
            this.очиститьПолеToolStripMenuItem.Click += new System.EventHandler(this.очиститьПолеToolStripMenuItem_Click);
            // 
            // Droupa2
            // 
            this.Droupa2.Controls.Add(this.AddObject);
            this.Droupa2.Controls.Add(this.WhatIsIt);
            this.Droupa2.Location = new System.Drawing.Point(389, 27);
            this.Droupa2.Name = "Droupa2";
            this.Droupa2.Size = new System.Drawing.Size(279, 92);
            this.Droupa2.TabIndex = 15;
            this.Droupa2.TabStop = false;
            this.Droupa2.Text = "← что это такое?";
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(7, 53);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(266, 23);
            this.AddObject.TabIndex = 1;
            this.AddObject.Text = "Добавить объект";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);

            this.BaseObject.Location = new System.Drawing.Point(486, 136);
            this.BaseObject.Name = "AddObject";
            this.BaseObject.Size = new System.Drawing.Size(90, 54);
            this.BaseObject.TabIndex = 1;
            this.BaseObject.Text = "Базовые объекты";
            this.BaseObject.UseVisualStyleBackColor = true;
            this.BaseObject.Click += new System.EventHandler(this.AddBaseObject_Click);

            this.ShowConsole.Location = new System.Drawing.Point(576, 136);
            this.ShowConsole.Name = "AddObject";
            this.ShowConsole.Size = new System.Drawing.Size(90, 54);
            this.ShowConsole.TabIndex = 1;
            this.ShowConsole.Text = "Показать персик";
            this.ShowConsole.UseVisualStyleBackColor = true;
            this.ShowConsole.Click += new System.EventHandler(this.ShowConsoleObject_Click);
            // 
            // WhatIsIt
            // 
            this.WhatIsIt.Location = new System.Drawing.Point(6, 26);
            this.WhatIsIt.Name = "WhatIsIt";
            this.WhatIsIt.Size = new System.Drawing.Size(267, 20);
            this.WhatIsIt.TabIndex = 0;
            // 
            // MyMemoryDock
            // 
            this.MyMemoryDock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MyMemoryDock.Controls.Add(this.AllPata);
            this.MyMemoryDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyMemoryDock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyMemoryDock.Location = new System.Drawing.Point(730, 24);
            this.MyMemoryDock.Name = "MyMemoryDock";
            this.MyMemoryDock.Size = new System.Drawing.Size(282, 399);
            this.MyMemoryDock.TabIndex = 16;
            this.MyMemoryDock.TabStop = false;
            this.MyMemoryDock.Text = "Что я вообще знаю";
            // 
            // AllPata
            // 
            this.AllPata.AutoScroll = true;
            this.AllPata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPata.Location = new System.Drawing.Point(3, 16);
            this.AllPata.Margin = new System.Windows.Forms.Padding(0);
            this.AllPata.Name = "AllPata";
            this.AllPata.Size = new System.Drawing.Size(276, 380);
            this.AllPata.TabIndex = 17;
            // 
            // NewPers
            // 
            this.NewPers.Location = new System.Drawing.Point(396, 136);
            this.NewPers.Name = "NewPers";
            this.NewPers.Size = new System.Drawing.Size(90, 54);
            this.NewPers.TabIndex = 17;
            this.NewPers.Text = "Новый персик";
            this.NewPers.UseVisualStyleBackColor = true;
            this.NewPers.Click += new System.EventHandler(this.NewPers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 423);
            this.Controls.Add(this.BaseObject);
            this.Controls.Add(this.ShowConsole);
            this.Controls.Add(this.NewPers);
            this.Controls.Add(this.MyMemoryDock);
            this.Controls.Add(this.Droupa2);
            this.Controls.Add(this.Sprosit);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.ShowDann);
            this.Controls.Add(this.Risovalka);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pan.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Droupa2.ResumeLayout(false);
            this.Droupa2.PerformLayout();
            this.MyMemoryDock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Risovalka;
        private System.Windows.Forms.Button ColorBut_10;
        private System.Windows.Forms.Button ColorBut_08;
        private System.Windows.Forms.Button ColorBut_06;
        private System.Windows.Forms.Button ColorBut_04;
        private System.Windows.Forms.Button ColorBut_02;
        private System.Windows.Forms.Button ColorBut_00;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Panel[] RisPol = new System.Windows.Forms.Panel[100];
        private System.Windows.Forms.Button ShowDann;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Button Sprosit;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеToolStripMenuItem;
        private System.Windows.Forms.GroupBox Droupa2;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Button BaseObject;
        private System.Windows.Forms.Button ShowConsole;
        private System.Windows.Forms.TextBox WhatIsIt;
        private System.Windows.Forms.GroupBox MyMemoryDock;
        private System.Windows.Forms.Panel AllPata;
        private List<Pattern> Paterns = new List<Pattern>();
        private System.Windows.Forms.Button NewPers;
    }
}

