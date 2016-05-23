namespace KeyboardTranslator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQwerty = new System.Windows.Forms.TextBox();
            this.txtAzerty = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQwerty
            // 
            this.txtQwerty.Location = new System.Drawing.Point(55, 51);
            this.txtQwerty.Name = "txtQwerty";
            this.txtQwerty.Size = new System.Drawing.Size(181, 20);
            this.txtQwerty.TabIndex = 0;
            // 
            // txtAzerty
            // 
            this.txtAzerty.Location = new System.Drawing.Point(415, 50);
            this.txtAzerty.Name = "txtAzerty";
            this.txtAzerty.ReadOnly = true;
            this.txtAzerty.Size = new System.Drawing.Size(172, 20);
            this.txtAzerty.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(278, 50);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 244);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAzerty);
            this.Controls.Add(this.txtQwerty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQwerty;
        private System.Windows.Forms.TextBox txtAzerty;
        private System.Windows.Forms.Button btnConvert;
    }
}

