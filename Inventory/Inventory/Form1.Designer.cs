namespace Inventory
{
    partial class InventoryManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lplate = new System.Windows.Forms.Label();
            this.licensePlate = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(167, 116);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(283, 26);
            this.make.TabIndex = 2;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(167, 163);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(283, 26);
            this.model.TabIndex = 3;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(167, 69);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(283, 26);
            this.id.TabIndex = 1;
            this.id.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lplate
            // 
            this.lplate.AutoSize = true;
            this.lplate.Location = new System.Drawing.Point(30, 210);
            this.lplate.Name = "lplate";
            this.lplate.Size = new System.Drawing.Size(104, 20);
            this.lplate.TabIndex = 7;
            this.lplate.Text = "License Plate";
            // 
            // licensePlate
            // 
            this.licensePlate.Location = new System.Drawing.Point(167, 210);
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.Size = new System.Drawing.Size(283, 26);
            this.licensePlate.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem1});
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.viewInventoryToolStripMenuItem.Text = "Options";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // viewInventoryToolStripMenuItem1
            // 
            this.viewInventoryToolStripMenuItem1.Name = "viewInventoryToolStripMenuItem1";
            this.viewInventoryToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.viewInventoryToolStripMenuItem1.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem1.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(218, 300);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(98, 42);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(352, 299);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(98, 42);
            this.update.TabIndex = 10;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 449);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.licensePlate);
            this.Controls.Add(this.lplate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.model);
            this.Controls.Add(this.make);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InventoryManagement";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lplate;
        private System.Windows.Forms.TextBox licensePlate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button update;
    }
}

