namespace FarmerGUI
{
    partial class frmMain
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
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbGrain = new System.Windows.Forms.CheckBox();
            this.cbFox = new System.Windows.Forms.CheckBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(323, 82);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(65, 17);
            this.cbChicken.TabIndex = 0;
            this.cbChicken.Text = "Chicken";
            this.cbChicken.UseVisualStyleBackColor = true;
            // 
            // cbGrain
            // 
            this.cbGrain.AutoSize = true;
            this.cbGrain.Location = new System.Drawing.Point(217, 82);
            this.cbGrain.Name = "cbGrain";
            this.cbGrain.Size = new System.Drawing.Size(51, 17);
            this.cbGrain.TabIndex = 1;
            this.cbGrain.Text = "Grain";
            this.cbGrain.UseVisualStyleBackColor = true;
            // 
            // cbFox
            // 
            this.cbFox.AutoSize = true;
            this.cbFox.Location = new System.Drawing.Point(469, 82);
            this.cbFox.Name = "cbFox";
            this.cbFox.Size = new System.Drawing.Size(43, 17);
            this.cbFox.TabIndex = 2;
            this.cbFox.Text = "Fox";
            this.cbFox.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(54, 78);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(93, 23);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move Farmer!";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(272, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Water";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.cbFox);
            this.Controls.Add(this.cbGrain);
            this.Controls.Add(this.cbChicken);
            this.Name = "frmMain";
            this.Text = "FamerGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbChicken;
        private System.Windows.Forms.CheckBox cbGrain;
        private System.Windows.Forms.CheckBox cbFox;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label1;
    }
}

