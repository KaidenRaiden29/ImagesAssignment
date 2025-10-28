namespace ImagesAssignment
{
    partial class FormAddResourses
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
            this.btnStrawberry = new System.Windows.Forms.Button();
            this.btnBlueberry = new System.Windows.Forms.Button();
            this.btnPineapple = new System.Windows.Forms.Button();
            this.imgstrawberry = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgstrawberry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStrawberry
            // 
            this.btnStrawberry.BackColor = System.Drawing.Color.Cornsilk;
            this.btnStrawberry.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrawberry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStrawberry.Location = new System.Drawing.Point(20, 115);
            this.btnStrawberry.Name = "btnStrawberry";
            this.btnStrawberry.Size = new System.Drawing.Size(133, 64);
            this.btnStrawberry.TabIndex = 0;
            this.btnStrawberry.Text = "Strawberry";
            this.btnStrawberry.UseVisualStyleBackColor = false;
            this.btnStrawberry.Click += new System.EventHandler(this.btnStrawberry_Click);
            this.btnStrawberry.MouseHover += new System.EventHandler(this.btnStrawberry_Click);
            // 
            // btnBlueberry
            // 
            this.btnBlueberry.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBlueberry.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueberry.Location = new System.Drawing.Point(20, 224);
            this.btnBlueberry.Name = "btnBlueberry";
            this.btnBlueberry.Size = new System.Drawing.Size(131, 66);
            this.btnBlueberry.TabIndex = 1;
            this.btnBlueberry.Text = "BlueBerry";
            this.btnBlueberry.UseVisualStyleBackColor = false;
            this.btnBlueberry.Click += new System.EventHandler(this.btnBlueberry_Click);
            this.btnBlueberry.MouseHover += new System.EventHandler(this.btnBlueberry_Click);
            // 
            // btnPineapple
            // 
            this.btnPineapple.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPineapple.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPineapple.Location = new System.Drawing.Point(17, 343);
            this.btnPineapple.Name = "btnPineapple";
            this.btnPineapple.Size = new System.Drawing.Size(134, 68);
            this.btnPineapple.TabIndex = 2;
            this.btnPineapple.Text = "Pineapple";
            this.btnPineapple.UseVisualStyleBackColor = false;
            this.btnPineapple.Click += new System.EventHandler(this.button3_Click);
            this.btnPineapple.MouseHover += new System.EventHandler(this.button3_Click);
            // 
            // imgstrawberry
            // 
            this.imgstrawberry.Image = global::ImagesAssignment.Properties.Resources.Strawberry;
            this.imgstrawberry.Location = new System.Drawing.Point(252, 102);
            this.imgstrawberry.Name = "imgstrawberry";
            this.imgstrawberry.Size = new System.Drawing.Size(461, 320);
            this.imgstrawberry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgstrawberry.TabIndex = 3;
            this.imgstrawberry.TabStop = false;
            this.imgstrawberry.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Select A Fruit";
            // 
            // FormAddResourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgstrawberry);
            this.Controls.Add(this.btnPineapple);
            this.Controls.Add(this.btnBlueberry);
            this.Controls.Add(this.btnStrawberry);
            this.Name = "FormAddResourses";
            this.Text = "Resourses";
            ((System.ComponentModel.ISupportInitialize)(this.imgstrawberry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStrawberry;
        private System.Windows.Forms.Button btnBlueberry;
        private System.Windows.Forms.Button btnPineapple;
        private System.Windows.Forms.PictureBox imgstrawberry;
        private System.Windows.Forms.Label label1;
    }
}

