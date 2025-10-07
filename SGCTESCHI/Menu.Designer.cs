namespace SGCTESCHI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.MenuControl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLobby = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.Panel();
            this.MenuControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuControl
            // 
            this.MenuControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuControl.Controls.Add(this.Categorias);
            this.MenuControl.Controls.Add(this.button2);
            this.MenuControl.Controls.Add(this.btnLobby);
            this.MenuControl.Controls.Add(this.btnCerrarSesion);
            this.MenuControl.Controls.Add(this.btnRegistros);
            this.MenuControl.Controls.Add(this.button1);
            this.MenuControl.Location = new System.Drawing.Point(0, 0);
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(1479, 949);
            this.MenuControl.TabIndex = 1;
            this.MenuControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuControl_Paint_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLobby
            // 
            this.btnLobby.Location = new System.Drawing.Point(55, 74);
            this.btnLobby.Name = "btnLobby";
            this.btnLobby.Size = new System.Drawing.Size(75, 23);
            this.btnLobby.TabIndex = 0;
            this.btnLobby.Text = "Lobby";
            this.btnLobby.UseVisualStyleBackColor = true;
            this.btnLobby.Click += new System.EventHandler(this.btnLobby_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1428, -1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(50, 50);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Location = new System.Drawing.Point(52, 127);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(78, 36);
            this.btnRegistros.TabIndex = 0;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // Categorias
            // 
            this.Categorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Categorias.Location = new System.Drawing.Point(131, 55);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(1347, 893);
            this.Categorias.TabIndex = 5;
            this.Categorias.Paint += new System.Windows.Forms.PaintEventHandler(this.Categorias_Paint_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.MenuControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MenuControl;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnLobby;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Categorias;
    }
}