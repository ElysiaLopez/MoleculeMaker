﻿namespace MoleculeMaker
{
    partial class BondSelectForm
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
            this.SingleButton = new BondsButton(BondTypes.Single);
            this.DoubleButton = new BondsButton(BondTypes.Double);
            this.TripleButton = new BondsButton(BondTypes.Triple);
            this.CancelButton = new BondsButton(BondTypes.None);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingleButton
            // 
            this.SingleButton.Location = new System.Drawing.Point(12, 34);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(75, 23);
            this.SingleButton.TabIndex = 0;
            this.SingleButton.Text = "Single";
            this.SingleButton.UseVisualStyleBackColor = true;
            // 
            // DoubleButton
            // 
            this.DoubleButton.Location = new System.Drawing.Point(93, 34);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(75, 23);
            this.DoubleButton.TabIndex = 1;
            this.DoubleButton.Text = "Double";
            this.DoubleButton.UseVisualStyleBackColor = true;
            // 
            // TripleButton
            // 
            this.TripleButton.Location = new System.Drawing.Point(174, 34);
            this.TripleButton.Name = "TripleButton";
            this.TripleButton.Size = new System.Drawing.Size(75, 23);
            this.TripleButton.TabIndex = 2;
            this.TripleButton.Text = "Triple";
            this.TripleButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(309, 34);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type of bond:";
            // 
            // BondsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 69);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TripleButton);
            this.Controls.Add(this.DoubleButton);
            this.Controls.Add(this.SingleButton);
            this.Name = "BondsForm";
            this.Text = "BondsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BondsButton SingleButton;
        private BondsButton DoubleButton;
        private BondsButton TripleButton;
        private BondsButton CancelButton;
        private System.Windows.Forms.Label label1;
    }
}