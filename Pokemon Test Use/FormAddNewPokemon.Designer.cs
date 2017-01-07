namespace Pokemon_Test_Use
{
    partial class FormAddNewPokemon
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
            this.picNewImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameAmount = new System.Windows.Forms.TextBox();
            this.txtDescriptionAmount = new System.Windows.Forms.TextBox();
            this.btnAddPokemon = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.lsbType = new System.Windows.Forms.ListBox();
            this.lsbMoves = new System.Windows.Forms.ListBox();
            this.lsbRegion = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picNewImage
            // 
            this.picNewImage.Location = new System.Drawing.Point(17, 20);
            this.picNewImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picNewImage.Name = "picNewImage";
            this.picNewImage.Size = new System.Drawing.Size(120, 138);
            this.picNewImage.TabIndex = 0;
            this.picNewImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moves:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Region:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description:";
            // 
            // txtNameAmount
            // 
            this.txtNameAmount.Location = new System.Drawing.Point(206, 19);
            this.txtNameAmount.Name = "txtNameAmount";
            this.txtNameAmount.Size = new System.Drawing.Size(100, 27);
            this.txtNameAmount.TabIndex = 6;
            // 
            // txtDescriptionAmount
            // 
            this.txtDescriptionAmount.Location = new System.Drawing.Point(408, 19);
            this.txtDescriptionAmount.Name = "txtDescriptionAmount";
            this.txtDescriptionAmount.Size = new System.Drawing.Size(100, 27);
            this.txtDescriptionAmount.TabIndex = 10;
            // 
            // btnAddPokemon
            // 
            this.btnAddPokemon.Location = new System.Drawing.Point(622, 179);
            this.btnAddPokemon.Name = "btnAddPokemon";
            this.btnAddPokemon.Size = new System.Drawing.Size(26, 26);
            this.btnAddPokemon.TabIndex = 11;
            this.btnAddPokemon.Text = "+";
            this.btnAddPokemon.UseVisualStyleBackColor = true;
            this.btnAddPokemon.Click += new System.EventHandler(this.btnAddPokemon_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(17, 167);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(120, 38);
            this.btnAddPic.TabIndex = 12;
            this.btnAddPic.Text = "Add Picture";
            this.btnAddPic.UseVisualStyleBackColor = true;
            // 
            // lsbType
            // 
            this.lsbType.FormattingEnabled = true;
            this.lsbType.ItemHeight = 20;
            this.lsbType.Location = new System.Drawing.Point(197, 73);
            this.lsbType.Name = "lsbType";
            this.lsbType.Size = new System.Drawing.Size(100, 84);
            this.lsbType.TabIndex = 13;
            // 
            // lsbMoves
            // 
            this.lsbMoves.FormattingEnabled = true;
            this.lsbMoves.ItemHeight = 20;
            this.lsbMoves.Location = new System.Drawing.Point(375, 73);
            this.lsbMoves.Name = "lsbMoves";
            this.lsbMoves.Size = new System.Drawing.Size(100, 84);
            this.lsbMoves.TabIndex = 14;
            // 
            // lsbRegion
            // 
            this.lsbRegion.FormattingEnabled = true;
            this.lsbRegion.ItemHeight = 20;
            this.lsbRegion.Location = new System.Drawing.Point(548, 74);
            this.lsbRegion.Name = "lsbRegion";
            this.lsbRegion.Size = new System.Drawing.Size(100, 84);
            this.lsbRegion.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID:";
            // 
            // txtIDAmount
            // 
            this.txtIDAmount.Location = new System.Drawing.Point(549, 22);
            this.txtIDAmount.Name = "txtIDAmount";
            this.txtIDAmount.Size = new System.Drawing.Size(98, 27);
            this.txtIDAmount.TabIndex = 17;
            // 
            // FormAddNewPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 215);
            this.Controls.Add(this.txtIDAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lsbRegion);
            this.Controls.Add(this.lsbMoves);
            this.Controls.Add(this.lsbType);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.btnAddPokemon);
            this.Controls.Add(this.txtDescriptionAmount);
            this.Controls.Add(this.txtNameAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNewImage);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddNewPokemon";
            this.Text = "FormAddNewPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.picNewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNewImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameAmount;
        private System.Windows.Forms.TextBox txtDescriptionAmount;
        private System.Windows.Forms.Button btnAddPokemon;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.ListBox lsbType;
        private System.Windows.Forms.ListBox lsbMoves;
        private System.Windows.Forms.ListBox lsbRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDAmount;
    }
}