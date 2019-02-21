namespace Flags
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
            this.finlandPic = new System.Windows.Forms.PictureBox();
            this.francePic = new System.Windows.Forms.PictureBox();
            this.germanPic = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPic)).BeginInit();
            this.SuspendLayout();
            // 
            // finlandPic
            // 
            this.finlandPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finlandPic.Image = global::Flags.Properties.Resources.Finland;
            this.finlandPic.Location = new System.Drawing.Point(33, 105);
            this.finlandPic.Name = "finlandPic";
            this.finlandPic.Size = new System.Drawing.Size(122, 72);
            this.finlandPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finlandPic.TabIndex = 0;
            this.finlandPic.TabStop = false;
            this.finlandPic.Click += new System.EventHandler(this.finlandPic_Click);
            // 
            // francePic
            // 
            this.francePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.francePic.Image = global::Flags.Properties.Resources.France;
            this.francePic.Location = new System.Drawing.Point(235, 105);
            this.francePic.Name = "francePic";
            this.francePic.Size = new System.Drawing.Size(122, 72);
            this.francePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.francePic.TabIndex = 1;
            this.francePic.TabStop = false;
            this.francePic.Click += new System.EventHandler(this.francePic_Click);
            // 
            // germanPic
            // 
            this.germanPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanPic.Image = global::Flags.Properties.Resources.Germany;
            this.germanPic.Location = new System.Drawing.Point(442, 105);
            this.germanPic.Name = "germanPic";
            this.germanPic.Size = new System.Drawing.Size(122, 72);
            this.germanPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.germanPic.TabIndex = 2;
            this.germanPic.TabStop = false;
            this.germanPic.Click += new System.EventHandler(this.germanPic_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(235, 22);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(206, 13);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Click a flag to see the name of the country";
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(238, 45);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(203, 42);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "(The context of the text property has been erased)";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(33, 13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(36, 22);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Quit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 493);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.germanPic);
            this.Controls.Add(this.francePic);
            this.Controls.Add(this.finlandPic);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandPic;
        private System.Windows.Forms.PictureBox francePic;
        private System.Windows.Forms.PictureBox germanPic;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button exitBtn;
    }
}

