
namespace WindowsFormsExercise1
{
    partial class ViewCartForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.removeAll = new System.Windows.Forms.Button();
            this.deleteContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            this.deleteContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(418, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 35);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Proceed To Payment";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.ContextMenuStrip = this.deleteContextMenuStrip;
            this.CartDataGridView.Location = new System.Drawing.Point(12, 12);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.Size = new System.Drawing.Size(583, 280);
            this.CartDataGridView.TabIndex = 11;
            this.CartDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CartDataGridView_CellMouseUp);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(272, 321);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(45, 16);
            this.Total.TabIndex = 12;
            this.Total.Text = "Total :";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(348, 321);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(40, 16);
            this.totalValueLabel.TabIndex = 13;
            this.totalValueLabel.Text = "- - - - -";
            // 
            // removeAll
            // 
            this.removeAll.BackColor = System.Drawing.Color.LightCoral;
            this.removeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAll.Location = new System.Drawing.Point(12, 312);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(109, 35);
            this.removeAll.TabIndex = 14;
            this.removeAll.Text = "Remove All";
            this.removeAll.UseVisualStyleBackColor = false;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // deleteContextMenuStrip
            // 
            this.deleteContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.deleteContextMenuStrip.Name = "deleteContextMenuStrip";
            this.deleteContextMenuStrip.Size = new System.Drawing.Size(134, 26);
            this.deleteContextMenuStrip.Click += new System.EventHandler(this.deleteContextMenuStrip_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "₱";
            // 
            // ViewCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 359);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.deleteContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.ContextMenuStrip deleteContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Label label12;
    }
}