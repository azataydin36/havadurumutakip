using System;
using System.Windows.Forms;

namespace HavaDurumuApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.getWeatherButton = new System.Windows.Forms.Button();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(20, 30);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(115, 25);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Şehir Adı:";

            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cityTextBox.ForeColor = System.Drawing.Color.Gray;
            this.cityTextBox.Location = new System.Drawing.Point(140, 30);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(220, 29);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.Text = "Şehir ismi girin";
            this.cityTextBox.Enter += new System.EventHandler(this.cityTextBox_Enter);
            this.cityTextBox.Leave += new System.EventHandler(this.cityTextBox_Leave);
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityTextBox.BackColor = System.Drawing.Color.White;
            this.cityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.getWeatherButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.getWeatherButton.BackColor = System.Drawing.Color.Indigo;
            this.getWeatherButton.ForeColor = System.Drawing.Color.White;
            this.getWeatherButton.Location = new System.Drawing.Point(140, 75);
            this.getWeatherButton.Name = "getWeatherButton";
            this.getWeatherButton.Size = new System.Drawing.Size(220, 45);
            this.getWeatherButton.TabIndex = 2;
            this.getWeatherButton.Text = "Hava Durumunu Getir";
            this.getWeatherButton.UseVisualStyleBackColor = false;
            this.getWeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getWeatherButton.FlatAppearance.BorderSize = 0;
            this.getWeatherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getWeatherButton.MouseEnter += new System.EventHandler(this.getWeatherButton_MouseEnter);
            this.getWeatherButton.MouseLeave += new System.EventHandler(this.getWeatherButton_MouseLeave);
            this.getWeatherButton.Click += new System.EventHandler(this.getWeatherButton_Click);

            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.temperatureLabel.ForeColor = System.Drawing.Color.White;
            this.temperatureLabel.Location = new System.Drawing.Point(20, 140);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(144, 25);
            this.temperatureLabel.TabIndex = 3;
            this.temperatureLabel.Text = "Sıcaklık: --°C";

            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(20, 180);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(103, 25);
            this.conditionLabel.TabIndex = 4;
            this.conditionLabel.Text = "Durum: --";

            this.BackColor = System.Drawing.Color.FromArgb(0, 51, 102);  // Koyu mavi
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.getWeatherButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Name = "Form1";
            this.Text = "Hava Durumu Takip Sistemi";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button getWeatherButton;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label conditionLabel;

       
        private void getWeatherButton_MouseEnter(object sender, EventArgs e)
        {
            getWeatherButton.BackColor = System.Drawing.Color.MediumPurple;
        }

        private void getWeatherButton_MouseLeave(object sender, EventArgs e)
        {
            getWeatherButton.BackColor = System.Drawing.Color.Indigo;
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                System.Drawing.Color.FromArgb(0, 51, 102),   // Koyu mavi
                System.Drawing.Color.FromArgb(102, 204, 255), // Açık mavi
                45F
            );

            e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
        }
    }
}
