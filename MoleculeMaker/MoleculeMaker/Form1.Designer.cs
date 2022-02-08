namespace MoleculeMaker
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
            this.components = new System.ComponentModel.Container();
            this.AddMolButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MolsComboBox = new System.Windows.Forms.ComboBox();
            this.MolInfoPanel = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MolsPanel = new System.Windows.Forms.Panel();
            this.dragInterval = new System.Windows.Forms.Timer(this.components);
            this.atomColorDialog = new System.Windows.Forms.ColorDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.MolInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMolButton
            // 
            this.AddMolButton.Location = new System.Drawing.Point(83, 55);
            this.AddMolButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMolButton.Name = "AddMolButton";
            this.AddMolButton.Size = new System.Drawing.Size(113, 30);
            this.AddMolButton.TabIndex = 0;
            this.AddMolButton.Text = "Add Molecule";
            this.AddMolButton.UseVisualStyleBackColor = true;
            this.AddMolButton.Click += new System.EventHandler(this.AddMolButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuPanel.Controls.Add(this.MolsComboBox);
            this.MenuPanel.Controls.Add(this.AddMolButton);
            this.MenuPanel.Location = new System.Drawing.Point(796, 1);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(269, 102);
            this.MenuPanel.TabIndex = 5;
            // 
            // MolsComboBox
            // 
            this.MolsComboBox.FormattingEnabled = true;
            this.MolsComboBox.Location = new System.Drawing.Point(65, 14);
            this.MolsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MolsComboBox.Name = "MolsComboBox";
            this.MolsComboBox.Size = new System.Drawing.Size(160, 24);
            this.MolsComboBox.TabIndex = 5;
            // 
            // MolInfoPanel
            // 
            this.MolInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MolInfoPanel.Controls.Add(this.InfoLabel);
            this.MolInfoPanel.Location = new System.Drawing.Point(796, 111);
            this.MolInfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MolInfoPanel.Name = "MolInfoPanel";
            this.MolInfoPanel.Size = new System.Drawing.Size(269, 446);
            this.MolInfoPanel.TabIndex = 6;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(9, 11);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(30, 17);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "text";
            // 
            // MolsPanel
            // 
            this.MolsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MolsPanel.Location = new System.Drawing.Point(1, 2);
            this.MolsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MolsPanel.Name = "MolsPanel";
            this.MolsPanel.Size = new System.Drawing.Size(795, 513);
            this.MolsPanel.TabIndex = 7;
            this.MolsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MolsPanelClicked);
            // 
            // dragInterval
            // 
            this.dragInterval.Tick += new System.EventHandler(this.dragInterval_Tick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(16, 523);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 28);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MolsPanel);
            this.Controls.Add(this.MolInfoPanel);
            this.Controls.Add(this.MenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.MenuPanel.ResumeLayout(false);
            this.MolInfoPanel.ResumeLayout(false);
            this.MolInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMolButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MolInfoPanel;
        private System.Windows.Forms.Panel MolsPanel;
        private System.Windows.Forms.Timer dragInterval;
        private System.Windows.Forms.ColorDialog atomColorDialog;
        private System.Windows.Forms.ComboBox MolsComboBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}

