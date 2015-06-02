namespace PlanetApp
{
    partial class planetPositionUI
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
            this.planetNameLebel = new System.Windows.Forms.Label();
            this.showPlanetButton = new System.Windows.Forms.Button();
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // planetNameLebel
            // 
            this.planetNameLebel.AutoSize = true;
            this.planetNameLebel.Location = new System.Drawing.Point(142, 47);
            this.planetNameLebel.Name = "planetNameLebel";
            this.planetNameLebel.Size = new System.Drawing.Size(68, 13);
            this.planetNameLebel.TabIndex = 1;
            this.planetNameLebel.Text = "Planet Name";
            // 
            // showPlanetButton
            // 
            this.showPlanetButton.Location = new System.Drawing.Point(249, 80);
            this.showPlanetButton.Name = "showPlanetButton";
            this.showPlanetButton.Size = new System.Drawing.Size(160, 21);
            this.showPlanetButton.TabIndex = 2;
            this.showPlanetButton.Text = "Show Planet";
            this.showPlanetButton.UseVisualStyleBackColor = true;
            this.showPlanetButton.Click += new System.EventHandler(this.showPlanetButton_Click);
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Location = new System.Drawing.Point(249, 44);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(160, 21);
            this.planetNameComboBox.TabIndex = 3;
            // 
            // planetPositionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 317);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.showPlanetButton);
            this.Controls.Add(this.planetNameLebel);
            this.Name = "planetPositionUI";
            this.Text = "Planet Position";
            this.Load += new System.EventHandler(this.planetPositionUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planetNameLebel;
        private System.Windows.Forms.Button showPlanetButton;
        private System.Windows.Forms.ComboBox planetNameComboBox;
    }
}

