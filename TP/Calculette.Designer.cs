namespace Calulette
{
    partial class Calculette
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vPlus = new System.Windows.Forms.RadioButton();
            this.vMoins = new System.Windows.Forms.RadioButton();
            this.vFois = new System.Windows.Forms.RadioButton();
            this.vDiv = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculatrice";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre 2";
            // 
            // vPlus
            // 
            this.vPlus.AutoSize = true;
            this.vPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPlus.ForeColor = System.Drawing.Color.DarkBlue;
            this.vPlus.Location = new System.Drawing.Point(52, 309);
            this.vPlus.Name = "vPlus";
            this.vPlus.Size = new System.Drawing.Size(43, 29);
            this.vPlus.TabIndex = 3;
            this.vPlus.TabStop = true;
            this.vPlus.Text = "+";
            this.vPlus.UseVisualStyleBackColor = true;
            // 
            // vMoins
            // 
            this.vMoins.AutoSize = true;
            this.vMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vMoins.ForeColor = System.Drawing.Color.DarkBlue;
            this.vMoins.Location = new System.Drawing.Point(52, 344);
            this.vMoins.Name = "vMoins";
            this.vMoins.Size = new System.Drawing.Size(38, 29);
            this.vMoins.TabIndex = 3;
            this.vMoins.TabStop = true;
            this.vMoins.Text = "-";
            this.vMoins.UseVisualStyleBackColor = true;
            // 
            // vFois
            // 
            this.vFois.AutoSize = true;
            this.vFois.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vFois.ForeColor = System.Drawing.Color.DarkBlue;
            this.vFois.Location = new System.Drawing.Point(52, 379);
            this.vFois.Name = "vFois";
            this.vFois.Size = new System.Drawing.Size(42, 29);
            this.vFois.TabIndex = 3;
            this.vFois.TabStop = true;
            this.vFois.Text = "x";
            this.vFois.UseVisualStyleBackColor = true;
            // 
            // vDiv
            // 
            this.vDiv.AutoSize = true;
            this.vDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vDiv.ForeColor = System.Drawing.Color.DarkBlue;
            this.vDiv.Location = new System.Drawing.Point(53, 414);
            this.vDiv.Name = "vDiv";
            this.vDiv.Size = new System.Drawing.Size(37, 29);
            this.vDiv.TabIndex = 3;
            this.vDiv.TabStop = true;
            this.vDiv.Text = ":";
            this.vDiv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(33, 142);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(199, 20);
            this.txtNombre1.TabIndex = 5;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(33, 245);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(199, 20);
            this.txtNombre2.TabIndex = 5;
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(24, 555);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(199, 20);
            this.txtResultat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Résultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 603);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vDiv);
            this.Controls.Add(this.vFois);
            this.Controls.Add(this.vMoins);
            this.Controls.Add(this.vPlus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton vPlus;
        private System.Windows.Forms.RadioButton vMoins;
        private System.Windows.Forms.RadioButton vFois;
        private System.Windows.Forms.RadioButton vDiv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label label4;
    }
}

