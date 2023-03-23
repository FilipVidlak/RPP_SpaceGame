namespace SpaceInvadors_rocnikovyprojekt
{
    partial class Vesmir
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vesmir));
            this.Restart_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Vesmirnalod = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Background_timer = new System.Windows.Forms.Timer(this.components);
            this.Neprmun_timer = new System.Windows.Forms.Timer(this.components);
            this.Neprlode_timer = new System.Windows.Forms.Timer(this.components);
            this.Municehrace_timer = new System.Windows.Forms.Timer(this.components);
            this.Pohybdoleva_timer = new System.Windows.Forms.Timer(this.components);
            this.Pohybdoprava_timer = new System.Windows.Forms.Timer(this.components);
            this.Pohybdolu_timer = new System.Windows.Forms.Timer(this.components);
            this.Pohybnahoru_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Vesmirnalod)).BeginInit();
            this.SuspendLayout();
            // 
            // Restart_button
            // 
            this.Restart_button.Location = new System.Drawing.Point(302, 202);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(144, 74);
            this.Restart_button.TabIndex = 0;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(302, 318);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(144, 67);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Ukončit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Vesmirnalod
            // 
            this.Vesmirnalod.BackColor = System.Drawing.Color.Transparent;
            this.Vesmirnalod.Image = ((System.Drawing.Image)(resources.GetObject("Vesmirnalod.Image")));
            this.Vesmirnalod.Location = new System.Drawing.Point(324, 477);
            this.Vesmirnalod.Name = "Vesmirnalod";
            this.Vesmirnalod.Size = new System.Drawing.Size(81, 73);
            this.Vesmirnalod.TabIndex = 2;
            this.Vesmirnalod.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Úroveň:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(637, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "Skóre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(730, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(211, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 60);
            this.label5.TabIndex = 36;
            this.label5.Text = "KONEC HRY";
            // 
            // Background_timer
            // 
            this.Background_timer.Enabled = true;
            this.Background_timer.Interval = 10;
            this.Background_timer.Tick += new System.EventHandler(this.Background_timer_Tick);
            // 
            // Neprmun_timer
            // 
            this.Neprmun_timer.Enabled = true;
            this.Neprmun_timer.Interval = 60;
            this.Neprmun_timer.Tick += new System.EventHandler(this.Neprmun_timer_Tick);
            // 
            // Neprlode_timer
            // 
            this.Neprlode_timer.Enabled = true;
            this.Neprlode_timer.Tick += new System.EventHandler(this.Neprlode_timer_Tick);
            // 
            // Municehrace_timer
            // 
            this.Municehrace_timer.Enabled = true;
            this.Municehrace_timer.Interval = 25;
            this.Municehrace_timer.Tick += new System.EventHandler(this.Municehrace_timer_Tick);
            // 
            // Pohybdoleva_timer
            // 
            this.Pohybdoleva_timer.Interval = 5;
            this.Pohybdoleva_timer.Tick += new System.EventHandler(this.Pohybdoleva_timer_Tick);
            // 
            // Pohybdoprava_timer
            // 
            this.Pohybdoprava_timer.Interval = 5;
            this.Pohybdoprava_timer.Tick += new System.EventHandler(this.Pohybdoprava_timer_Tick);
            // 
            // Pohybdolu_timer
            // 
            this.Pohybdolu_timer.Interval = 5;
            this.Pohybdolu_timer.Tick += new System.EventHandler(this.Pohybdolu_timer_Tick);
            // 
            // Pohybnahoru_timer
            // 
            this.Pohybnahoru_timer.Interval = 5;
            this.Pohybnahoru_timer.Tick += new System.EventHandler(this.Pohybnahoru_timer_Tick);
            // 
            // Vesmir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vesmirnalod);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Restart_button);
            this.MaximumSize = new System.Drawing.Size(800, 609);
            this.MinimumSize = new System.Drawing.Size(800, 609);
            this.Name = "Vesmir";
            this.Text = "Space Invadors";
            this.Load += new System.EventHandler(this.Vesmir_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vesmir_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Vesmir_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Vesmirnalod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox Vesmirnalod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Background_timer;
        private System.Windows.Forms.Timer Neprmun_timer;
        private System.Windows.Forms.Timer Neprlode_timer;
        private System.Windows.Forms.Timer Municehrace_timer;
        private System.Windows.Forms.Timer Pohybdoleva_timer;
        private System.Windows.Forms.Timer Pohybdoprava_timer;
        private System.Windows.Forms.Timer Pohybdolu_timer;
        private System.Windows.Forms.Timer Pohybnahoru_timer;
    }
}

