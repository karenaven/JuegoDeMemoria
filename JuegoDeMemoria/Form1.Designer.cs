namespace JuegoDeMemoria
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
            this.components = new System.ComponentModel.Container();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label1Record = new System.Windows.Forms.Label();
            this.label2Num = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.Location = new System.Drawing.Point(24, 23);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(756, 713);
            this.panelJuego.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReiniciar.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btnReiniciar.Location = new System.Drawing.Point(884, 622);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(135, 70);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "REINICIAR JUEGO";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label1Record
            // 
            this.label1Record.AutoSize = true;
            this.label1Record.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1Record.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1Record.ForeColor = System.Drawing.Color.Black;
            this.label1Record.Location = new System.Drawing.Point(884, 44);
            this.label1Record.Name = "label1Record";
            this.label1Record.Size = new System.Drawing.Size(129, 23);
            this.label1Record.TabIndex = 2;
            this.label1Record.Text = "Movimientos";
            // 
            // label2Num
            // 
            this.label2Num.AutoSize = true;
            this.label2Num.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2Num.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2Num.ForeColor = System.Drawing.Color.Black;
            this.label2Num.Location = new System.Drawing.Point(932, 90);
            this.label2Num.Name = "label2Num";
            this.label2Num.Size = new System.Drawing.Size(31, 32);
            this.label2Num.TabIndex = 3;
            this.label2Num.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::JuegoDeMemoria.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 768);
            this.Controls.Add(this.label2Num);
            this.Controls.Add(this.label1Record);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panelJuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelJuego;
        private Button btnReiniciar;
        private Label label1Record;
        private Label label2Num;
        private System.Windows.Forms.Timer timer1;
    }
}