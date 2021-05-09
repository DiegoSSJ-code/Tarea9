
namespace Tarea9
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
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_MySQL = new System.Windows.Forms.Button();
            this.btn_oracle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(302, 241);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 20);
            this.btn_cargar.TabIndex = 0;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_MySQL
            // 
            this.btn_MySQL.Location = new System.Drawing.Point(289, 111);
            this.btn_MySQL.Name = "btn_MySQL";
            this.btn_MySQL.Size = new System.Drawing.Size(104, 23);
            this.btn_MySQL.TabIndex = 1;
            this.btn_MySQL.Text = "Conectar MySQL";
            this.btn_MySQL.UseVisualStyleBackColor = true;
            this.btn_MySQL.Click += new System.EventHandler(this.btn_MySQL_Click);
            // 
            // btn_oracle
            // 
            this.btn_oracle.Location = new System.Drawing.Point(289, 72);
            this.btn_oracle.Name = "btn_oracle";
            this.btn_oracle.Size = new System.Drawing.Size(106, 23);
            this.btn_oracle.TabIndex = 2;
            this.btn_oracle.Text = "Conectar Oracle";
            this.btn_oracle.UseVisualStyleBackColor = true;
            this.btn_oracle.Click += new System.EventHandler(this.btn_oracle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_oracle);
            this.Controls.Add(this.btn_MySQL);
            this.Controls.Add(this.btn_cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_MySQL;
        private System.Windows.Forms.Button btn_oracle;
    }
}

