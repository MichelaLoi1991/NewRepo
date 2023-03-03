namespace Calcolo_Codice_Fiscale
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
            this.rad_bot_mx = new System.Windows.Forms.RadioButton();
            this.rad_bot_sx = new System.Windows.Forms.RadioButton();
            this.bot_CDF = new System.Windows.Forms.Button();
            this.tex_box_nome = new System.Windows.Forms.TextBox();
            this.text_box_cognome = new System.Windows.Forms.TextBox();
            this.combo_box_comune = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rad_bot_mx
            // 
            this.rad_bot_mx.AutoSize = true;
            this.rad_bot_mx.Location = new System.Drawing.Point(62, 186);
            this.rad_bot_mx.Name = "rad_bot_mx";
            this.rad_bot_mx.Size = new System.Drawing.Size(103, 29);
            this.rad_bot_mx.TabIndex = 0;
            this.rad_bot_mx.TabStop = true;
            this.rad_bot_mx.Text = "maschio";
            this.rad_bot_mx.UseVisualStyleBackColor = true;
            this.rad_bot_mx.CheckedChanged += new System.EventHandler(this.rad_bot_mx_CheckedChanged);
            // 
            // rad_bot_sx
            // 
            this.rad_bot_sx.AutoSize = true;
            this.rad_bot_sx.Location = new System.Drawing.Point(62, 240);
            this.rad_bot_sx.Name = "rad_bot_sx";
            this.rad_bot_sx.Size = new System.Drawing.Size(107, 29);
            this.rad_bot_sx.TabIndex = 1;
            this.rad_bot_sx.TabStop = true;
            this.rad_bot_sx.Text = "femmina";
            this.rad_bot_sx.UseVisualStyleBackColor = true;
            this.rad_bot_sx.CheckedChanged += new System.EventHandler(this.rad_bot_sx_CheckedChanged);
            // 
            // bot_CDF
            // 
            this.bot_CDF.Location = new System.Drawing.Point(480, 209);
            this.bot_CDF.Name = "bot_CDF";
            this.bot_CDF.Size = new System.Drawing.Size(317, 105);
            this.bot_CDF.TabIndex = 2;
            this.bot_CDF.Text = "calcola il codice fiscale";
            this.bot_CDF.UseVisualStyleBackColor = true;
            this.bot_CDF.Click += new System.EventHandler(this.bot_CDF_Click);
            // 
            // tex_box_nome
            // 
            this.tex_box_nome.Location = new System.Drawing.Point(117, 24);
            this.tex_box_nome.Name = "tex_box_nome";
            this.tex_box_nome.Size = new System.Drawing.Size(206, 31);
            this.tex_box_nome.TabIndex = 3;
            this.tex_box_nome.TextChanged += new System.EventHandler(this.tex_box_nome_TextChanged);
            // 
            // text_box_cognome
            // 
            this.text_box_cognome.Location = new System.Drawing.Point(117, 87);
            this.text_box_cognome.Name = "text_box_cognome";
            this.text_box_cognome.Size = new System.Drawing.Size(207, 31);
            this.text_box_cognome.TabIndex = 4;
            this.text_box_cognome.TextChanged += new System.EventHandler(this.text_box_cognome_TextChanged);
            // 
            // combo_box_comune
            // 
            this.combo_box_comune.FormattingEnabled = true;
            this.combo_box_comune.Location = new System.Drawing.Point(52, 353);
            this.combo_box_comune.Name = "combo_box_comune";
            this.combo_box_comune.Size = new System.Drawing.Size(210, 33);
            this.combo_box_comune.TabIndex = 5;
            this.combo_box_comune.SelectedIndexChanged += new System.EventHandler(this.combo_box_comune_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "comune";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box_comune);
            this.Controls.Add(this.text_box_cognome);
            this.Controls.Add(this.tex_box_nome);
            this.Controls.Add(this.bot_CDF);
            this.Controls.Add(this.rad_bot_sx);
            this.Controls.Add(this.rad_bot_mx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rad_bot_mx;
        private RadioButton rad_bot_sx;
        private Button bot_CDF;
        private TextBox tex_box_nome;
        private TextBox text_box_cognome;
        private ComboBox combo_box_comune;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}