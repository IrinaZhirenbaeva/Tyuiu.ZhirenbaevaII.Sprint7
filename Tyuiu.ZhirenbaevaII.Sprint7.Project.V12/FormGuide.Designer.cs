
namespace Tyuiu.ZhirenbaevaII.Sprint7.Project.V12
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.labelGuide_ZII = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGuide_ZII
            // 
            this.labelGuide_ZII.AutoSize = true;
            this.labelGuide_ZII.Location = new System.Drawing.Point(11, 18);
            this.labelGuide_ZII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGuide_ZII.Name = "labelGuide_ZII";
            this.labelGuide_ZII.Size = new System.Drawing.Size(550, 182);
            this.labelGuide_ZII.TabIndex = 1;
            this.labelGuide_ZII.Text = resources.GetString("labelGuide_ZII.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 244);
            this.Controls.Add(this.labelGuide_ZII);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGuide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGuide_ZII;
    }
}