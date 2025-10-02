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
            this.Categorias = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegistros = new System.Windows.Forms.Button();
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
            this.MenuControl.Controls.Add(this.btnRegistros);
            this.MenuControl.Controls.Add(this.Categorias);
            this.MenuControl.Controls.Add(this.button1);
            this.MenuControl.Location = new System.Drawing.Point(0, 0);
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(1479, 854);
            this.MenuControl.TabIndex = 1;
            // 
            // Categorias
            // 
            this.Categorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Categorias.Location = new System.Drawing.Point(187, 0);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(1285, 849);
            this.Categorias.TabIndex = 3;
            this.Categorias.Paint += new System.Windows.Forms.PaintEventHandler(this.Categorias_Paint);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Location = new System.Drawing.Point(52, 71);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(78, 36);
            this.btnRegistros.TabIndex = 0;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 850);
            this.Controls.Add(this.MenuControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MenuControl;
        private System.Windows.Forms.FlowLayoutPanel Categorias;
        private System.Windows.Forms.Button btnRegistros;
    }
}