namespace Pokemon_Test_Use
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNumberOfPokemon = new System.Windows.Forms.Label();
            this.ltbPokemonData = new System.Windows.Forms.ListBox();
            this.lblPokemonSelectedName = new System.Windows.Forms.Label();
            this.lblIDText = new System.Windows.Forms.Label();
            this.lblTypeText = new System.Windows.Forms.Label();
            this.lblFirstAppearedText = new System.Windows.Forms.Label();
            this.lblFirstAppearedAmount = new System.Windows.Forms.Label();
            this.lblTypeAmount = new System.Windows.Forms.Label();
            this.lblIDAmount = new System.Windows.Forms.Label();
            this.lblSpeciesAmount = new System.Windows.Forms.Label();
            this.lblSpeciesText = new System.Windows.Forms.Label();
            this.pcBPokemonPic = new System.Windows.Forms.PictureBox();
            this.btnAddNewPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfPokemon
            // 
            this.lblNumberOfPokemon.AutoSize = true;
            this.lblNumberOfPokemon.Location = new System.Drawing.Point(143, 373);
            this.lblNumberOfPokemon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfPokemon.Name = "lblNumberOfPokemon";
            this.lblNumberOfPokemon.Size = new System.Drawing.Size(157, 20);
            this.lblNumberOfPokemon.TabIndex = 0;
            this.lblNumberOfPokemon.Text = "lblNumberOfPokemon";
            // 
            // ltbPokemonData
            // 
            this.ltbPokemonData.FormattingEnabled = true;
            this.ltbPokemonData.ItemHeight = 20;
            this.ltbPokemonData.Location = new System.Drawing.Point(16, 217);
            this.ltbPokemonData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbPokemonData.Name = "ltbPokemonData";
            this.ltbPokemonData.Size = new System.Drawing.Size(377, 144);
            this.ltbPokemonData.TabIndex = 1;
            this.ltbPokemonData.SelectedIndexChanged += new System.EventHandler(this.ltbPokemonData_SelectedIndexChanged);
            // 
            // lblPokemonSelectedName
            // 
            this.lblPokemonSelectedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPokemonSelectedName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokemonSelectedName.Location = new System.Drawing.Point(16, 14);
            this.lblPokemonSelectedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPokemonSelectedName.Name = "lblPokemonSelectedName";
            this.lblPokemonSelectedName.Size = new System.Drawing.Size(119, 50);
            this.lblPokemonSelectedName.TabIndex = 2;
            this.lblPokemonSelectedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDText
            // 
            this.lblIDText.AutoSize = true;
            this.lblIDText.Location = new System.Drawing.Point(143, 131);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(27, 20);
            this.lblIDText.TabIndex = 4;
            this.lblIDText.Text = "ID:";
            // 
            // lblTypeText
            // 
            this.lblTypeText.AutoSize = true;
            this.lblTypeText.Location = new System.Drawing.Point(143, 100);
            this.lblTypeText.Name = "lblTypeText";
            this.lblTypeText.Size = new System.Drawing.Size(43, 20);
            this.lblTypeText.TabIndex = 5;
            this.lblTypeText.Text = "Type:";
            // 
            // lblFirstAppearedText
            // 
            this.lblFirstAppearedText.AutoSize = true;
            this.lblFirstAppearedText.Location = new System.Drawing.Point(143, 69);
            this.lblFirstAppearedText.Name = "lblFirstAppearedText";
            this.lblFirstAppearedText.Size = new System.Drawing.Size(109, 20);
            this.lblFirstAppearedText.TabIndex = 6;
            this.lblFirstAppearedText.Text = "First Appeared:";
            // 
            // lblFirstAppearedAmount
            // 
            this.lblFirstAppearedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstAppearedAmount.Location = new System.Drawing.Point(276, 69);
            this.lblFirstAppearedAmount.Name = "lblFirstAppearedAmount";
            this.lblFirstAppearedAmount.Size = new System.Drawing.Size(117, 20);
            this.lblFirstAppearedAmount.TabIndex = 7;
            this.lblFirstAppearedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeAmount
            // 
            this.lblTypeAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypeAmount.Location = new System.Drawing.Point(276, 100);
            this.lblTypeAmount.Name = "lblTypeAmount";
            this.lblTypeAmount.Size = new System.Drawing.Size(117, 20);
            this.lblTypeAmount.TabIndex = 8;
            this.lblTypeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDAmount
            // 
            this.lblIDAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDAmount.Location = new System.Drawing.Point(276, 131);
            this.lblIDAmount.Name = "lblIDAmount";
            this.lblIDAmount.Size = new System.Drawing.Size(117, 20);
            this.lblIDAmount.TabIndex = 9;
            this.lblIDAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeciesAmount
            // 
            this.lblSpeciesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpeciesAmount.Location = new System.Drawing.Point(211, 162);
            this.lblSpeciesAmount.Name = "lblSpeciesAmount";
            this.lblSpeciesAmount.Size = new System.Drawing.Size(182, 45);
            this.lblSpeciesAmount.TabIndex = 11;
            this.lblSpeciesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeciesText
            // 
            this.lblSpeciesText.AutoSize = true;
            this.lblSpeciesText.Location = new System.Drawing.Point(143, 162);
            this.lblSpeciesText.Name = "lblSpeciesText";
            this.lblSpeciesText.Size = new System.Drawing.Size(62, 20);
            this.lblSpeciesText.TabIndex = 10;
            this.lblSpeciesText.Text = "Species:";
            // 
            // pcBPokemonPic
            // 
            this.pcBPokemonPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcBPokemonPic.Location = new System.Drawing.Point(16, 69);
            this.pcBPokemonPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcBPokemonPic.Name = "pcBPokemonPic";
            this.pcBPokemonPic.Size = new System.Drawing.Size(120, 138);
            this.pcBPokemonPic.TabIndex = 3;
            this.pcBPokemonPic.TabStop = false;
            // 
            // btnAddNewPokemon
            // 
            this.btnAddNewPokemon.Location = new System.Drawing.Point(16, 366);
            this.btnAddNewPokemon.Name = "btnAddNewPokemon";
            this.btnAddNewPokemon.Size = new System.Drawing.Size(38, 34);
            this.btnAddNewPokemon.TabIndex = 12;
            this.btnAddNewPokemon.Text = "+";
            this.btnAddNewPokemon.UseVisualStyleBackColor = true;
            this.btnAddNewPokemon.Click += new System.EventHandler(this.btnAddNewPokemon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 402);
            this.Controls.Add(this.btnAddNewPokemon);
            this.Controls.Add(this.lblSpeciesAmount);
            this.Controls.Add(this.lblSpeciesText);
            this.Controls.Add(this.lblIDAmount);
            this.Controls.Add(this.lblTypeAmount);
            this.Controls.Add(this.lblFirstAppearedAmount);
            this.Controls.Add(this.lblFirstAppearedText);
            this.Controls.Add(this.lblTypeText);
            this.Controls.Add(this.lblIDText);
            this.Controls.Add(this.pcBPokemonPic);
            this.Controls.Add(this.lblPokemonSelectedName);
            this.Controls.Add(this.ltbPokemonData);
            this.Controls.Add(this.lblNumberOfPokemon);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Pokémon Database";
            ((System.ComponentModel.ISupportInitialize)(this.pcBPokemonPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfPokemon;
        private System.Windows.Forms.ListBox ltbPokemonData;
        private System.Windows.Forms.Label lblPokemonSelectedName;
        private System.Windows.Forms.PictureBox pcBPokemonPic;
        private System.Windows.Forms.Label lblIDText;
        private System.Windows.Forms.Label lblTypeText;
        private System.Windows.Forms.Label lblFirstAppearedText;
        private System.Windows.Forms.Label lblFirstAppearedAmount;
        private System.Windows.Forms.Label lblTypeAmount;
        private System.Windows.Forms.Label lblIDAmount;
        private System.Windows.Forms.Label lblSpeciesAmount;
        private System.Windows.Forms.Label lblSpeciesText;
        private System.Windows.Forms.Button btnAddNewPokemon;
    }
}

