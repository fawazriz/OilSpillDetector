namespace OilSpillDetector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtOilSpillVisual = new System.Windows.Forms.TextBox();
            this.lblOilSpillTitle = new System.Windows.Forms.Label();
            this.lblAreaOfInterest = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblGlobNum = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOilSpillVisual
            // 
            this.txtOilSpillVisual.BackColor = System.Drawing.Color.Black;
            this.txtOilSpillVisual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOilSpillVisual.Font = new System.Drawing.Font("Courier New", 15F);
            this.txtOilSpillVisual.ForeColor = System.Drawing.Color.Lime;
            this.txtOilSpillVisual.Location = new System.Drawing.Point(24, 54);
            this.txtOilSpillVisual.Multiline = true;
            this.txtOilSpillVisual.Name = "txtOilSpillVisual";
            this.txtOilSpillVisual.ReadOnly = true;
            this.txtOilSpillVisual.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOilSpillVisual.Size = new System.Drawing.Size(332, 367);
            this.txtOilSpillVisual.TabIndex = 0;
            this.txtOilSpillVisual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOilSpillVisual.WordWrap = false;
            // 
            // lblOilSpillTitle
            // 
            this.lblOilSpillTitle.AutoSize = true;
            this.lblOilSpillTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOilSpillTitle.Location = new System.Drawing.Point(101, 20);
            this.lblOilSpillTitle.Name = "lblOilSpillTitle";
            this.lblOilSpillTitle.Size = new System.Drawing.Size(157, 26);
            this.lblOilSpillTitle.TabIndex = 1;
            this.lblOilSpillTitle.Text = "Oil Spill Visual:";
            // 
            // lblAreaOfInterest
            // 
            this.lblAreaOfInterest.AutoSize = true;
            this.lblAreaOfInterest.BackColor = System.Drawing.Color.Black;
            this.lblAreaOfInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaOfInterest.ForeColor = System.Drawing.Color.Lime;
            this.lblAreaOfInterest.Location = new System.Drawing.Point(452, 67);
            this.lblAreaOfInterest.Name = "lblAreaOfInterest";
            this.lblAreaOfInterest.Size = new System.Drawing.Size(139, 20);
            this.lblAreaOfInterest.TabIndex = 2;
            this.lblAreaOfInterest.Text = "Area Of Interest";
            this.lblAreaOfInterest.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(488, 287);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(159, 59);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Map";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblGlobNum
            // 
            this.lblGlobNum.AutoSize = true;
            this.lblGlobNum.BackColor = System.Drawing.Color.Black;
            this.lblGlobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobNum.ForeColor = System.Drawing.Color.Lime;
            this.lblGlobNum.Location = new System.Drawing.Point(524, 167);
            this.lblGlobNum.Name = "lblGlobNum";
            this.lblGlobNum.Size = new System.Drawing.Size(147, 20);
            this.lblGlobNum.TabIndex = 4;
            this.lblGlobNum.Text = "Number Of Globs";
            this.lblGlobNum.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(488, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 59);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTable
            // 
            this.picTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTable.BackgroundImage")));
            this.picTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTable.Location = new System.Drawing.Point(420, 20);
            this.picTable.Name = "picTable";
            this.picTable.Size = new System.Drawing.Size(352, 219);
            this.picTable.TabIndex = 6;
            this.picTable.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGlobNum);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblAreaOfInterest);
            this.Controls.Add(this.lblOilSpillTitle);
            this.Controls.Add(this.txtOilSpillVisual);
            this.Controls.Add(this.picTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Oil Spill Detector";
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOilSpillVisual;
        private System.Windows.Forms.Label lblOilSpillTitle;
        private System.Windows.Forms.Label lblAreaOfInterest;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblGlobNum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picTable;
    }
}

