namespace LoadIni
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
            this.openIniFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIniFileName1 = new System.Windows.Forms.TextBox();
            this.btnOpenIniFile1 = new System.Windows.Forms.Button();
            this.confTree1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIniFileName2 = new System.Windows.Forms.TextBox();
            this.btnOpenIniFile2 = new System.Windows.Forms.Button();
            this.confTree2 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openIniFileDialog
            // 
            this.openIniFileDialog.AddExtension = false;
            this.openIniFileDialog.Filter = "Config files (*.ini)|*.ini|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ini File 1:";
            // 
            // txtIniFileName1
            // 
            this.txtIniFileName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIniFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIniFileName1.Location = new System.Drawing.Point(78, 3);
            this.txtIniFileName1.Name = "txtIniFileName1";
            this.txtIniFileName1.Size = new System.Drawing.Size(329, 26);
            this.txtIniFileName1.TabIndex = 1;
            // 
            // btnOpenIniFile1
            // 
            this.btnOpenIniFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenIniFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIniFile1.Location = new System.Drawing.Point(413, 3);
            this.btnOpenIniFile1.Name = "btnOpenIniFile1";
            this.btnOpenIniFile1.Size = new System.Drawing.Size(32, 23);
            this.btnOpenIniFile1.TabIndex = 2;
            this.btnOpenIniFile1.Text = "...";
            this.btnOpenIniFile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenIniFile1.UseVisualStyleBackColor = true;
            this.btnOpenIniFile1.Click += new System.EventHandler(this.btnOpenIniFile_Click);
            // 
            // confTree1
            // 
            this.confTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confTree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confTree1.Location = new System.Drawing.Point(0, 35);
            this.confTree1.Name = "confTree1";
            this.confTree1.Size = new System.Drawing.Size(459, 597);
            this.confTree1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ini File 2:";
            // 
            // txtIniFileName2
            // 
            this.txtIniFileName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIniFileName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIniFileName2.Location = new System.Drawing.Point(80, 0);
            this.txtIniFileName2.Name = "txtIniFileName2";
            this.txtIniFileName2.Size = new System.Drawing.Size(334, 26);
            this.txtIniFileName2.TabIndex = 5;
            // 
            // btnOpenIniFile2
            // 
            this.btnOpenIniFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenIniFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIniFile2.Location = new System.Drawing.Point(420, 2);
            this.btnOpenIniFile2.Name = "btnOpenIniFile2";
            this.btnOpenIniFile2.Size = new System.Drawing.Size(32, 23);
            this.btnOpenIniFile2.TabIndex = 6;
            this.btnOpenIniFile2.Text = "...";
            this.btnOpenIniFile2.UseVisualStyleBackColor = true;
            this.btnOpenIniFile2.Click += new System.EventHandler(this.btnOpenIniFile_Click);
            // 
            // confTree2
            // 
            this.confTree2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confTree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confTree2.Location = new System.Drawing.Point(3, 35);
            this.confTree2.Name = "confTree2";
            this.confTree2.Size = new System.Drawing.Size(449, 597);
            this.confTree2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.confTree1);
            this.splitContainer1.Panel1.Controls.Add(this.txtIniFileName1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenIniFile1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.confTree2);
            this.splitContainer1.Panel2.Controls.Add(this.btnOpenIniFile2);
            this.splitContainer1.Panel2.Controls.Add(this.txtIniFileName2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(917, 632);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 651);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openIniFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIniFileName1;
        private System.Windows.Forms.Button btnOpenIniFile1;
        private System.Windows.Forms.TreeView confTree1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIniFileName2;
        private System.Windows.Forms.Button btnOpenIniFile2;
        private System.Windows.Forms.TreeView confTree2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

