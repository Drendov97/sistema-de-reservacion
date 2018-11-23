namespace SiVeBo
{
    partial class Menu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVentaBoletos = new System.Windows.Forms.Button();
            this.btn_Tema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SiVeBo.Properties.Resources.reportes;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 175);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reportes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SiVeBo.Properties.Resources.usersKey1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 175);
            this.button1.TabIndex = 1;
            this.button1.Text = "Control de Usuarios";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnVentaBoletos
            // 
            this.btnVentaBoletos.AutoSize = true;
            this.btnVentaBoletos.BackColor = System.Drawing.Color.Transparent;
            this.btnVentaBoletos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentaBoletos.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaBoletos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVentaBoletos.Image = global::SiVeBo.Properties.Resources.ticket_bus;
            this.btnVentaBoletos.Location = new System.Drawing.Point(12, 25);
            this.btnVentaBoletos.Name = "btnVentaBoletos";
            this.btnVentaBoletos.Size = new System.Drawing.Size(222, 175);
            this.btnVentaBoletos.TabIndex = 0;
            this.btnVentaBoletos.Text = "Venta de Boletos";
            this.btnVentaBoletos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentaBoletos.UseVisualStyleBackColor = false;
            this.btnVentaBoletos.Click += new System.EventHandler(this.btnVentaBoletos_Click);
            // 
            // btn_Tema
            // 
            this.btn_Tema.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tema.BackgroundImage = global::SiVeBo.Properties.Resources.theme;
            this.btn_Tema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tema.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tema.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Tema.Location = new System.Drawing.Point(783, 504);
            this.btn_Tema.Name = "btn_Tema";
            this.btn_Tema.Size = new System.Drawing.Size(95, 91);
            this.btn_Tema.TabIndex = 3;
            this.btn_Tema.Text = "Tema";
            this.btn_Tema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Tema.UseVisualStyleBackColor = false;
            this.btn_Tema.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::SiVeBo.Properties.Resources.logoFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 607);
            this.Controls.Add(this.btn_Tema);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVentaBoletos);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentaBoletos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Tema;
    }
}