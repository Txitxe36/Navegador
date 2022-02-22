
namespace Navegador_C
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.RichTextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bIr = new System.Windows.Forms.Button();
            this.bRojo = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.bAzul = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba";
            // 
            // tBuscar
            // 
            this.tBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscar.Location = new System.Drawing.Point(168, 59);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(577, 48);
            this.tBuscar.TabIndex = 1;
            this.tBuscar.Text = "";
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuscar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.FlatAppearance.BorderSize = 2;
            this.bBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(168, 137);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(169, 68);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar en Google";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bIr
            // 
            this.bIr.BackColor = System.Drawing.Color.DodgerBlue;
            this.bIr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIr.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bIr.FlatAppearance.BorderSize = 2;
            this.bIr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bIr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIr.Location = new System.Drawing.Point(600, 137);
            this.bIr.Name = "bIr";
            this.bIr.Size = new System.Drawing.Size(145, 68);
            this.bIr.TabIndex = 3;
            this.bIr.Text = "Ir a la URL";
            this.bIr.UseVisualStyleBackColor = false;
            this.bIr.Click += new System.EventHandler(this.bIr_Click);
            // 
            // bRojo
            // 
            this.bRojo.BackColor = System.Drawing.Color.Red;
            this.bRojo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRojo.Location = new System.Drawing.Point(823, 12);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(109, 49);
            this.bRojo.TabIndex = 4;
            this.bRojo.Text = "Rojo";
            this.bRojo.UseVisualStyleBackColor = false;
            this.bRojo.Click += new System.EventHandler(this.bRojo_Click);
            // 
            // bVerde
            // 
            this.bVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bVerde.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerde.Location = new System.Drawing.Point(823, 82);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(109, 49);
            this.bVerde.TabIndex = 5;
            this.bVerde.Text = "Verde";
            this.bVerde.UseVisualStyleBackColor = false;
            this.bVerde.Click += new System.EventHandler(this.bVerde_Click);
            // 
            // bAzul
            // 
            this.bAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bAzul.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAzul.Location = new System.Drawing.Point(823, 149);
            this.bAzul.Name = "bAzul";
            this.bAzul.Size = new System.Drawing.Size(109, 49);
            this.bAzul.TabIndex = 6;
            this.bAzul.Text = "Azul";
            this.bAzul.UseVisualStyleBackColor = false;
            this.bAzul.Click += new System.EventHandler(this.bAzul_Click);
            // 
            // bVolver
            // 
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.Location = new System.Drawing.Point(968, 12);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(143, 49);
            this.bVolver.TabIndex = 7;
            this.bVolver.Text = "Predeterminado";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bVer
            // 
            this.bVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVer.Location = new System.Drawing.Point(968, 82);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(109, 49);
            this.bVer.TabIndex = 8;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = false;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(28, 222);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1083, 515);
            this.webBrowser1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1139, 749);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bAzul);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.bIr);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador en C# de MIguel García";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tBuscar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bIr;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Button bAzul;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

