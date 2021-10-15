
namespace WindowsFormsExercise1
{
    partial class DashboardForm
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
            this.dashboardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.userListButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.userListPanel = new System.Windows.Forms.Panel();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.AutoSize = true;
            this.dashboardPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.dashboardPanel.Controls.Add(this.label2);
            this.dashboardPanel.Controls.Add(this.homeButton);
            this.dashboardPanel.Controls.Add(this.userListButton);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(206, 581);
            this.dashboardPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(3, 70);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 40);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // userListButton
            // 
            this.userListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListButton.Location = new System.Drawing.Point(3, 113);
            this.userListButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.userListButton.Name = "userListButton";
            this.userListButton.Size = new System.Drawing.Size(200, 40);
            this.userListButton.TabIndex = 6;
            this.userListButton.Text = "Shopping List";
            this.userListButton.UseVisualStyleBackColor = true;
            this.userListButton.Click += new System.EventHandler(this.userListButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePanel.Location = new System.Drawing.Point(205, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(775, 581);
            this.homePanel.TabIndex = 1;
            // 
            // userListPanel
            // 
            this.userListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userListPanel.Location = new System.Drawing.Point(205, 0);
            this.userListPanel.Name = "userListPanel";
            this.userListPanel.Size = new System.Drawing.Size(778, 581);
            this.userListPanel.TabIndex = 2;
            this.userListPanel.Visible = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.userListPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.dashboardPanel);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.dashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dashboardPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button userListButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel userListPanel;
    }
}