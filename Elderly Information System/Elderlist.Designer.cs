﻿namespace Elderly_Information_System
{
    partial class Elderlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVElderlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVElderlist)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVElderlist
            // 
            this.DGVElderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVElderlist.Location = new System.Drawing.Point(58, 57);
            this.DGVElderlist.Name = "DGVElderlist";
            this.DGVElderlist.Size = new System.Drawing.Size(669, 406);
            this.DGVElderlist.TabIndex = 0;
            // 
            // Elderlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Elderly_Information_System.Properties.Resources.back2;
            this.Controls.Add(this.DGVElderlist);
            this.Name = "Elderlist";
            this.Size = new System.Drawing.Size(784, 563);
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVElderlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVElderlist;
    }
}
