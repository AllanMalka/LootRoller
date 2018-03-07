namespace LootRoller
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtIndicator = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbCr = new System.Windows.Forms.RadioButton();
            this.rbGoods = new System.Windows.Forms.RadioButton();
            this.rbItems = new System.Windows.Forms.RadioButton();
            this.rbCoins = new System.Windows.Forms.RadioButton();
            this.rbProtection = new System.Windows.Forms.RadioButton();
            this.rbWeapons = new System.Windows.Forms.RadioButton();
            this.ddbProtection = new System.Windows.Forms.ComboBox();
            this.ddbWeapons = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 343);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Bla bla status";
            // 
            // txtIndicator
            // 
            this.txtIndicator.Location = new System.Drawing.Point(12, 401);
            this.txtIndicator.Name = "txtIndicator";
            this.txtIndicator.Size = new System.Drawing.Size(93, 20);
            this.txtIndicator.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 427);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalculate.Size = new System.Drawing.Size(93, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Do some magic!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResult.Location = new System.Drawing.Point(316, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(359, 438);
            this.txtResult.TabIndex = 3;
            this.txtResult.Visible = false;
            // 
            // rbCr
            // 
            this.rbCr.AutoSize = true;
            this.rbCr.BackColor = System.Drawing.SystemColors.Control;
            this.rbCr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCr.Location = new System.Drawing.Point(16, 13);
            this.rbCr.Name = "rbCr";
            this.rbCr.Size = new System.Drawing.Size(106, 17);
            this.rbCr.TabIndex = 4;
            this.rbCr.TabStop = true;
            this.rbCr.Text = "Challenge Rating";
            this.rbCr.UseVisualStyleBackColor = false;
            this.rbCr.CheckedChanged += new System.EventHandler(this.rbCr_CheckedChanged);
            // 
            // rbGoods
            // 
            this.rbGoods.AutoSize = true;
            this.rbGoods.Location = new System.Drawing.Point(16, 37);
            this.rbGoods.Name = "rbGoods";
            this.rbGoods.Size = new System.Drawing.Size(59, 17);
            this.rbGoods.TabIndex = 5;
            this.rbGoods.TabStop = true;
            this.rbGoods.Text = "Goods.";
            this.rbGoods.UseVisualStyleBackColor = true;
            this.rbGoods.CheckedChanged += new System.EventHandler(this.rbGoods_CheckedChanged);
            // 
            // rbItems
            // 
            this.rbItems.AutoSize = true;
            this.rbItems.Location = new System.Drawing.Point(16, 61);
            this.rbItems.Name = "rbItems";
            this.rbItems.Size = new System.Drawing.Size(56, 17);
            this.rbItems.TabIndex = 6;
            this.rbItems.TabStop = true;
            this.rbItems.Text = "Items. ";
            this.rbItems.UseVisualStyleBackColor = true;
            this.rbItems.CheckedChanged += new System.EventHandler(this.rbItems_CheckedChanged);
            // 
            // rbCoins
            // 
            this.rbCoins.AutoSize = true;
            this.rbCoins.Location = new System.Drawing.Point(16, 85);
            this.rbCoins.Name = "rbCoins";
            this.rbCoins.Size = new System.Drawing.Size(54, 17);
            this.rbCoins.TabIndex = 7;
            this.rbCoins.TabStop = true;
            this.rbCoins.Text = "Coins.";
            this.rbCoins.UseVisualStyleBackColor = true;
            this.rbCoins.CheckedChanged += new System.EventHandler(this.rbCoins_CheckedChanged);
            // 
            // rbProtection
            // 
            this.rbProtection.AutoSize = true;
            this.rbProtection.Location = new System.Drawing.Point(16, 109);
            this.rbProtection.Name = "rbProtection";
            this.rbProtection.Size = new System.Drawing.Size(126, 17);
            this.rbProtection.TabIndex = 8;
            this.rbProtection.TabStop = true;
            this.rbProtection.Text = "Magic Armor/Shields.";
            this.rbProtection.UseVisualStyleBackColor = true;
            this.rbProtection.CheckedChanged += new System.EventHandler(this.rbProtection_CheckedChanged);
            // 
            // rbWeapons
            // 
            this.rbWeapons.AutoSize = true;
            this.rbWeapons.Location = new System.Drawing.Point(16, 133);
            this.rbWeapons.Name = "rbWeapons";
            this.rbWeapons.Size = new System.Drawing.Size(103, 17);
            this.rbWeapons.TabIndex = 9;
            this.rbWeapons.TabStop = true;
            this.rbWeapons.Text = "Magic Weapons";
            this.rbWeapons.UseVisualStyleBackColor = true;
            this.rbWeapons.CheckedChanged += new System.EventHandler(this.rbWeapons_CheckedChanged);
            // 
            // ddbProtection
            // 
            this.ddbProtection.FormattingEnabled = true;
            this.ddbProtection.Location = new System.Drawing.Point(149, 109);
            this.ddbProtection.Name = "ddbProtection";
            this.ddbProtection.Size = new System.Drawing.Size(161, 21);
            this.ddbProtection.TabIndex = 10;
            this.ddbProtection.SelectedIndexChanged += new System.EventHandler(this.ddbProtection_SelectedIndexChanged);
            // 
            // ddbWeapons
            // 
            this.ddbWeapons.FormattingEnabled = true;
            this.ddbWeapons.Location = new System.Drawing.Point(149, 133);
            this.ddbWeapons.Name = "ddbWeapons";
            this.ddbWeapons.Size = new System.Drawing.Size(161, 21);
            this.ddbWeapons.TabIndex = 11;
            this.ddbWeapons.SelectedIndexChanged += new System.EventHandler(this.ddbWeapons_SelectedIndexChanged);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.ddbWeapons);
            this.Controls.Add(this.ddbProtection);
            this.Controls.Add(this.rbWeapons);
            this.Controls.Add(this.rbProtection);
            this.Controls.Add(this.rbCoins);
            this.Controls.Add(this.rbItems);
            this.Controls.Add(this.rbGoods);
            this.Controls.Add(this.rbCr);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIndicator);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Default";
            this.Text = "Loot Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtIndicator;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbCr;
        private System.Windows.Forms.RadioButton rbGoods;
        private System.Windows.Forms.RadioButton rbItems;
        private System.Windows.Forms.RadioButton rbCoins;
        private System.Windows.Forms.RadioButton rbProtection;
        private System.Windows.Forms.RadioButton rbWeapons;
        private System.Windows.Forms.ComboBox ddbProtection;
        private System.Windows.Forms.ComboBox ddbWeapons;
    }
}

