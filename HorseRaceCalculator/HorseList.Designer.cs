namespace HorseRaceCalculator
{
    partial class HorseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorseList));
            this.lo = new System.Windows.Forms.TabPage();
            this.lowH = new System.Windows.Forms.DataGridView();
            this.mid = new System.Windows.Forms.TabPage();
            this.midH = new System.Windows.Forms.DataGridView();
            this.hi = new System.Windows.Forms.TabPage();
            this.highH = new System.Windows.Forms.DataGridView();
            this.all = new System.Windows.Forms.TabPage();
            this.full = new System.Windows.Forms.DataGridView();
            this.horses = new System.Windows.Forms.TabControl();
            this.lo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowH)).BeginInit();
            this.mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midH)).BeginInit();
            this.hi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highH)).BeginInit();
            this.all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.full)).BeginInit();
            this.horses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lo
            // 
            this.lo.Controls.Add(this.lowH);
            this.lo.Location = new System.Drawing.Point(8, 39);
            this.lo.Name = "lo";
            this.lo.Padding = new System.Windows.Forms.Padding(3);
            this.lo.Size = new System.Drawing.Size(490, 946);
            this.lo.TabIndex = 3;
            this.lo.Text = "Low-Tier";
            this.lo.UseVisualStyleBackColor = true;
            // 
            // lowH
            // 
            this.lowH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowH.Location = new System.Drawing.Point(3, 3);
            this.lowH.Name = "lowH";
            this.lowH.RowHeadersWidth = 82;
            this.lowH.RowTemplate.Height = 33;
            this.lowH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lowH.Size = new System.Drawing.Size(484, 940);
            this.lowH.TabIndex = 1;
            // 
            // mid
            // 
            this.mid.Controls.Add(this.midH);
            this.mid.Location = new System.Drawing.Point(8, 39);
            this.mid.Name = "mid";
            this.mid.Padding = new System.Windows.Forms.Padding(3);
            this.mid.Size = new System.Drawing.Size(490, 946);
            this.mid.TabIndex = 2;
            this.mid.Text = "Mid-Tier";
            this.mid.UseVisualStyleBackColor = true;
            // 
            // midH
            // 
            this.midH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.midH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midH.Location = new System.Drawing.Point(3, 3);
            this.midH.Name = "midH";
            this.midH.RowHeadersWidth = 82;
            this.midH.RowTemplate.Height = 33;
            this.midH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.midH.Size = new System.Drawing.Size(484, 940);
            this.midH.TabIndex = 1;
            // 
            // hi
            // 
            this.hi.Controls.Add(this.highH);
            this.hi.Location = new System.Drawing.Point(8, 39);
            this.hi.Name = "hi";
            this.hi.Padding = new System.Windows.Forms.Padding(3);
            this.hi.Size = new System.Drawing.Size(490, 946);
            this.hi.TabIndex = 1;
            this.hi.Text = "High-Tier";
            this.hi.UseVisualStyleBackColor = true;
            // 
            // highH
            // 
            this.highH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highH.Location = new System.Drawing.Point(3, 3);
            this.highH.Name = "highH";
            this.highH.RowHeadersWidth = 82;
            this.highH.RowTemplate.Height = 33;
            this.highH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.highH.Size = new System.Drawing.Size(484, 940);
            this.highH.TabIndex = 1;
            // 
            // all
            // 
            this.all.Controls.Add(this.full);
            this.all.Location = new System.Drawing.Point(8, 39);
            this.all.Name = "all";
            this.all.Padding = new System.Windows.Forms.Padding(3);
            this.all.Size = new System.Drawing.Size(490, 946);
            this.all.TabIndex = 0;
            this.all.Text = "Full List";
            this.all.UseVisualStyleBackColor = true;
            // 
            // full
            // 
            this.full.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.full.Location = new System.Drawing.Point(3, 3);
            this.full.Name = "full";
            this.full.RowHeadersWidth = 82;
            this.full.RowTemplate.Height = 33;
            this.full.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.full.Size = new System.Drawing.Size(484, 940);
            this.full.TabIndex = 0;
            // 
            // horses
            // 
            this.horses.Controls.Add(this.all);
            this.horses.Controls.Add(this.hi);
            this.horses.Controls.Add(this.mid);
            this.horses.Controls.Add(this.lo);
            this.horses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horses.Location = new System.Drawing.Point(0, 0);
            this.horses.Name = "horses";
            this.horses.SelectedIndex = 0;
            this.horses.Size = new System.Drawing.Size(506, 993);
            this.horses.TabIndex = 0;
            // 
            // HorseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 993);
            this.Controls.Add(this.horses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HorseList";
            this.Text = "Full Horse List";
            this.lo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowH)).EndInit();
            this.mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.midH)).EndInit();
            this.hi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highH)).EndInit();
            this.all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.full)).EndInit();
            this.horses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage lo;
        private System.Windows.Forms.TabPage mid;
        private System.Windows.Forms.TabPage hi;
        private System.Windows.Forms.TabPage all;
        private System.Windows.Forms.TabControl horses;
        private System.Windows.Forms.DataGridView full;
        private System.Windows.Forms.DataGridView lowH;
        private System.Windows.Forms.DataGridView midH;
        private System.Windows.Forms.DataGridView highH;
    }
}