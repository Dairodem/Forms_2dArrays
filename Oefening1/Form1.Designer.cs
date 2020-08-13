namespace Oefening1
{
    partial class Form1
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
            this.txtmaandag = new System.Windows.Forms.TextBox();
            this.txtdinsdag = new System.Windows.Forms.TextBox();
            this.txtwoensdag = new System.Windows.Forms.TextBox();
            this.txtdonderdag = new System.Windows.Forms.TextBox();
            this.txtzaterdag = new System.Windows.Forms.TextBox();
            this.txtzondag = new System.Windows.Forms.TextBox();
            this.txtvrijdag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmaandag
            // 
            this.txtmaandag.Enabled = false;
            this.txtmaandag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaandag.Location = new System.Drawing.Point(83, 10);
            this.txtmaandag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaandag.Name = "txtmaandag";
            this.txtmaandag.Size = new System.Drawing.Size(80, 20);
            this.txtmaandag.TabIndex = 0;
            this.txtmaandag.Tag = "";
            this.txtmaandag.Text = "maandag";
            this.txtmaandag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdinsdag
            // 
            this.txtdinsdag.Enabled = false;
            this.txtdinsdag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinsdag.Location = new System.Drawing.Point(167, 10);
            this.txtdinsdag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdinsdag.Name = "txtdinsdag";
            this.txtdinsdag.Size = new System.Drawing.Size(80, 20);
            this.txtdinsdag.TabIndex = 1;
            this.txtdinsdag.Text = "dinsdag";
            this.txtdinsdag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdinsdag.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtwoensdag
            // 
            this.txtwoensdag.Enabled = false;
            this.txtwoensdag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwoensdag.Location = new System.Drawing.Point(251, 10);
            this.txtwoensdag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtwoensdag.Name = "txtwoensdag";
            this.txtwoensdag.Size = new System.Drawing.Size(80, 20);
            this.txtwoensdag.TabIndex = 3;
            this.txtwoensdag.Text = "woensdag";
            this.txtwoensdag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdonderdag
            // 
            this.txtdonderdag.Enabled = false;
            this.txtdonderdag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonderdag.Location = new System.Drawing.Point(335, 11);
            this.txtdonderdag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdonderdag.Name = "txtdonderdag";
            this.txtdonderdag.Size = new System.Drawing.Size(80, 20);
            this.txtdonderdag.TabIndex = 2;
            this.txtdonderdag.Text = "donderdag";
            this.txtdonderdag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdonderdag.TextChanged += new System.EventHandler(this.txtdonderdag_TextChanged);
            // 
            // txtzaterdag
            // 
            this.txtzaterdag.Enabled = false;
            this.txtzaterdag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzaterdag.Location = new System.Drawing.Point(505, 11);
            this.txtzaterdag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtzaterdag.Name = "txtzaterdag";
            this.txtzaterdag.Size = new System.Drawing.Size(80, 20);
            this.txtzaterdag.TabIndex = 6;
            this.txtzaterdag.Text = "zaterdag";
            this.txtzaterdag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtzondag
            // 
            this.txtzondag.Enabled = false;
            this.txtzondag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzondag.Location = new System.Drawing.Point(589, 10);
            this.txtzondag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtzondag.Name = "txtzondag";
            this.txtzondag.Size = new System.Drawing.Size(80, 20);
            this.txtzondag.TabIndex = 5;
            this.txtzondag.Text = "zondag";
            this.txtzondag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtzondag.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtvrijdag
            // 
            this.txtvrijdag.Enabled = false;
            this.txtvrijdag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvrijdag.Location = new System.Drawing.Point(421, 10);
            this.txtvrijdag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvrijdag.Name = "txtvrijdag";
            this.txtvrijdag.Size = new System.Drawing.Size(80, 20);
            this.txtvrijdag.TabIndex = 4;
            this.txtvrijdag.Text = "vrijdag";
            this.txtvrijdag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 532);
            this.Controls.Add(this.txtzaterdag);
            this.Controls.Add(this.txtzondag);
            this.Controls.Add(this.txtvrijdag);
            this.Controls.Add(this.txtwoensdag);
            this.Controls.Add(this.txtdonderdag);
            this.Controls.Add(this.txtdinsdag);
            this.Controls.Add(this.txtmaandag);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaandag;
        private System.Windows.Forms.TextBox txtdinsdag;
        private System.Windows.Forms.TextBox txtwoensdag;
        private System.Windows.Forms.TextBox txtdonderdag;
        private System.Windows.Forms.TextBox txtzaterdag;
        private System.Windows.Forms.TextBox txtzondag;
        private System.Windows.Forms.TextBox txtvrijdag;
    }
}

