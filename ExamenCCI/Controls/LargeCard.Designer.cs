namespace ExamenCCI.Controls
{
    partial class LargeCard
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbcountry = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbscene = new System.Windows.Forms.Label();
            this.lbdescription = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxScene = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 230);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbcountry
            // 
            this.lbcountry.AutoSize = true;
            this.lbcountry.Location = new System.Drawing.Point(35, 263);
            this.lbcountry.Name = "lbcountry";
            this.lbcountry.Size = new System.Drawing.Size(43, 16);
            this.lbcountry.TabIndex = 1;
            this.lbcountry.Text = "PAYS";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Location = new System.Drawing.Point(35, 301);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(55, 16);
            this.lbgender.TabIndex = 2;
            this.lbgender.Text = "GENRE";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(35, 334);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(44, 16);
            this.lbdate.TabIndex = 3;
            this.lbdate.Text = "DATE";
            // 
            // lbscene
            // 
            this.lbscene.AutoSize = true;
            this.lbscene.Location = new System.Drawing.Point(35, 364);
            this.lbscene.Name = "lbscene";
            this.lbscene.Size = new System.Drawing.Size(53, 16);
            this.lbscene.TabIndex = 4;
            this.lbscene.Text = "SCENE";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(35, 404);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(98, 16);
            this.lbdescription.TabIndex = 6;
            this.lbdescription.Text = "DESCRIPTION";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(181, 334);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxDate.TabIndex = 7;
            // 
            // textBoxScene
            // 
            this.textBoxScene.Location = new System.Drawing.Point(181, 364);
            this.textBoxScene.Name = "textBoxScene";
            this.textBoxScene.Size = new System.Drawing.Size(100, 22);
            this.textBoxScene.TabIndex = 8;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(181, 301);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 22);
            this.textBoxGenre.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(3, 208);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(181, 260);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountry.TabIndex = 11;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(38, 434);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(325, 22);
            this.textBoxDescription.TabIndex = 12;
            // 
            // LargeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxScene);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.lbdescription);
            this.Controls.Add(this.lbscene);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbcountry);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LargeCard";
            this.Size = new System.Drawing.Size(414, 564);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbcountry;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbscene;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxScene;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}
