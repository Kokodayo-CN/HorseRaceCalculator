namespace HorseRaceCalculator
{
    partial class HorseSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorseSelection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.horseDropBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.horseTag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.horseTier = new System.Windows.Forms.TextBox();
            this.horseOdd = new System.Windows.Forms.TextBox();
            this.comfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comfirm);
            this.panel1.Controls.Add(this.horseOdd);
            this.panel1.Controls.Add(this.horseTier);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.horseTag);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.horseDropBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 491);
            this.panel1.TabIndex = 0;
            // 
            // horseDropBox
            // 
            this.horseDropBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseDropBox.FormattingEnabled = true;
            this.horseDropBox.Location = new System.Drawing.Point(33, 105);
            this.horseDropBox.Name = "horseDropBox";
            this.horseDropBox.Size = new System.Drawing.Size(735, 50);
            this.horseDropBox.TabIndex = 0;
            this.horseDropBox.SelectedIndexChanged += new System.EventHandler(this.selected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Horse for ";
            // 
            // horseTag
            // 
            this.horseTag.AutoSize = true;
            this.horseTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseTag.Location = new System.Drawing.Point(467, 25);
            this.horseTag.Name = "horseTag";
            this.horseTag.Size = new System.Drawing.Size(172, 51);
            this.horseTag.TabIndex = 2;
            this.horseTag.Text = "Horse 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Horse\'s Stats:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chance of Winning:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Horse Tier:";
            // 
            // horseTier
            // 
            this.horseTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseTier.Location = new System.Drawing.Point(119, 291);
            this.horseTier.Name = "horseTier";
            this.horseTier.ReadOnly = true;
            this.horseTier.Size = new System.Drawing.Size(195, 49);
            this.horseTier.TabIndex = 6;
            this.horseTier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // horseOdd
            // 
            this.horseOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseOdd.Location = new System.Drawing.Point(498, 291);
            this.horseOdd.Name = "horseOdd";
            this.horseOdd.ReadOnly = true;
            this.horseOdd.Size = new System.Drawing.Size(195, 49);
            this.horseOdd.TabIndex = 7;
            this.horseOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comfirm
            // 
            this.comfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirm.Location = new System.Drawing.Point(212, 378);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(376, 90);
            this.comfirm.TabIndex = 8;
            this.comfirm.Text = "Save && Return";
            this.comfirm.UseVisualStyleBackColor = true;
            // 
            // HorseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HorseSelection";
            this.Text = "Select Horse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox horseDropBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label horseTag;
        private System.Windows.Forms.TextBox horseOdd;
        private System.Windows.Forms.TextBox horseTier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button comfirm;
    }
}