namespace TogetherCulture1
{
    partial class HomepageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gotoDashHomePage = new System.Windows.Forms.Label();
            this.gotoMembHomepage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gotoDashHomePage);
            this.panel1.Controls.Add(this.gotoMembHomepage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // gotoDashHomePage
            // 
            this.gotoDashHomePage.AutoSize = true;
            this.gotoDashHomePage.Location = new System.Drawing.Point(487, 222);
            this.gotoDashHomePage.Name = "gotoDashHomePage";
            this.gotoDashHomePage.Size = new System.Drawing.Size(75, 16);
            this.gotoDashHomePage.TabIndex = 2;
            this.gotoDashHomePage.Text = "Dashboard";
            this.gotoDashHomePage.MouseEnter += new System.EventHandler(this.gotoDashHomePage_MouseEnter);
            this.gotoDashHomePage.MouseLeave += new System.EventHandler(this.gotoDashHomePage_MouseLeave);
            // 
            // gotoMembHomepage
            // 
            this.gotoMembHomepage.AutoSize = true;
            this.gotoMembHomepage.Location = new System.Drawing.Point(183, 222);
            this.gotoMembHomepage.Name = "gotoMembHomepage";
            this.gotoMembHomepage.Size = new System.Drawing.Size(82, 16);
            this.gotoMembHomepage.TabIndex = 1;
            this.gotoMembHomepage.Text = "Membership";
            this.gotoMembHomepage.Click += new System.EventHandler(this.gotoMembHomepage_Click);
            this.gotoMembHomepage.MouseEnter += new System.EventHandler(this.gotoMembHomepage_MouseEnter);
            this.gotoMembHomepage.MouseLeave += new System.EventHandler(this.gotoMembHomepage_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comming soon...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Membership form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "HomepageForm";
            this.Text = "HomepageForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gotoMembHomepage;
        private System.Windows.Forms.Label gotoDashHomePage;
        private System.Windows.Forms.Label label2;
    }
}