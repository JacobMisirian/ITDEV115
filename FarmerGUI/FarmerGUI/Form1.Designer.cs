namespace FarmerGUI
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
            this.btnMove = new System.Windows.Forms.Button();
            this.cbNorthChicken = new System.Windows.Forms.CheckBox();
            this.cbNorthGrain = new System.Windows.Forms.CheckBox();
            this.cbNorthFox = new System.Windows.Forms.CheckBox();
            this.cbSouthFox = new System.Windows.Forms.CheckBox();
            this.cbSouthGrain = new System.Windows.Forms.CheckBox();
            this.cbSouthChicken = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(245, 167);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // cbNorthChicken
            // 
            this.cbNorthChicken.AutoSize = true;
            this.cbNorthChicken.Location = new System.Drawing.Point(496, 118);
            this.cbNorthChicken.Name = "cbNorthChicken";
            this.cbNorthChicken.Size = new System.Drawing.Size(65, 17);
            this.cbNorthChicken.TabIndex = 3;
            this.cbNorthChicken.Text = "Chicken";
            this.cbNorthChicken.UseVisualStyleBackColor = true;
            // 
            // cbNorthGrain
            // 
            this.cbNorthGrain.AutoSize = true;
            this.cbNorthGrain.Location = new System.Drawing.Point(496, 171);
            this.cbNorthGrain.Name = "cbNorthGrain";
            this.cbNorthGrain.Size = new System.Drawing.Size(51, 17);
            this.cbNorthGrain.TabIndex = 4;
            this.cbNorthGrain.Text = "Grain";
            this.cbNorthGrain.UseVisualStyleBackColor = true;
            // 
            // cbNorthFox
            // 
            this.cbNorthFox.AutoSize = true;
            this.cbNorthFox.Location = new System.Drawing.Point(496, 231);
            this.cbNorthFox.Name = "cbNorthFox";
            this.cbNorthFox.Size = new System.Drawing.Size(43, 17);
            this.cbNorthFox.TabIndex = 5;
            this.cbNorthFox.Text = "Fox";
            this.cbNorthFox.UseVisualStyleBackColor = true;
            // 
            // cbSouthFox
            // 
            this.cbSouthFox.AutoSize = true;
            this.cbSouthFox.Location = new System.Drawing.Point(12, 231);
            this.cbSouthFox.Name = "cbSouthFox";
            this.cbSouthFox.Size = new System.Drawing.Size(43, 17);
            this.cbSouthFox.TabIndex = 8;
            this.cbSouthFox.Text = "Fox";
            this.cbSouthFox.UseVisualStyleBackColor = true;
            this.cbSouthFox.Visible = false;
            // 
            // cbSouthGrain
            // 
            this.cbSouthGrain.AutoSize = true;
            this.cbSouthGrain.Location = new System.Drawing.Point(12, 171);
            this.cbSouthGrain.Name = "cbSouthGrain";
            this.cbSouthGrain.Size = new System.Drawing.Size(51, 17);
            this.cbSouthGrain.TabIndex = 7;
            this.cbSouthGrain.Text = "Grain";
            this.cbSouthGrain.UseVisualStyleBackColor = true;
            this.cbSouthGrain.Visible = false;
            // 
            // cbSouthChicken
            // 
            this.cbSouthChicken.AutoSize = true;
            this.cbSouthChicken.Location = new System.Drawing.Point(12, 118);
            this.cbSouthChicken.Name = "cbSouthChicken";
            this.cbSouthChicken.Size = new System.Drawing.Size(65, 17);
            this.cbSouthChicken.TabIndex = 6;
            this.cbSouthChicken.Text = "Chicken";
            this.cbSouthChicken.UseVisualStyleBackColor = true;
            this.cbSouthChicken.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 429);
            this.Controls.Add(this.cbSouthFox);
            this.Controls.Add(this.cbSouthGrain);
            this.Controls.Add(this.cbSouthChicken);
            this.Controls.Add(this.cbNorthFox);
            this.Controls.Add(this.cbNorthGrain);
            this.Controls.Add(this.cbNorthChicken);
            this.Controls.Add(this.btnMove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.CheckBox cbNorthChicken;
        private System.Windows.Forms.CheckBox cbNorthGrain;
        private System.Windows.Forms.CheckBox cbNorthFox;
        private System.Windows.Forms.CheckBox cbSouthFox;
        private System.Windows.Forms.CheckBox cbSouthGrain;
        private System.Windows.Forms.CheckBox cbSouthChicken;
    }
}

