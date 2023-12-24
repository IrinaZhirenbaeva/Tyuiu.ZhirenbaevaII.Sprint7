
namespace Tyuiu.ZhirenbaevaII.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_ZII = new System.Windows.Forms.Label();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.buttonClose_ZII = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_ZII
            // 
            this.labelInfo_ZII.AutoSize = true;
            this.labelInfo_ZII.Location = new System.Drawing.Point(182, 32);
            this.labelInfo_ZII.Name = "labelInfo_ZII";
            this.labelInfo_ZII.Size = new System.Drawing.Size(384, 117);
            this.labelInfo_ZII.TabIndex = 0;
            this.labelInfo_ZII.Text = resources.GetString("labelInfo_ZII.Text");
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxName.Image")));
            this.pictureBoxName.Location = new System.Drawing.Point(28, 32);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(121, 162);
            this.pictureBoxName.TabIndex = 1;
            this.pictureBoxName.TabStop = false;
            // 
            // buttonClose_ZII
            // 
            this.buttonClose_ZII.Location = new System.Drawing.Point(491, 162);
            this.buttonClose_ZII.Name = "buttonClose_ZII";
            this.buttonClose_ZII.Size = new System.Drawing.Size(75, 23);
            this.buttonClose_ZII.TabIndex = 2;
            this.buttonClose_ZII.Text = "OK";
            this.buttonClose_ZII.UseVisualStyleBackColor = true;
            this.buttonClose_ZII.Click += new System.EventHandler(this.buttonClose_ZII_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 257);
            this.Controls.Add(this.buttonClose_ZII);
            this.Controls.Add(this.pictureBoxName);
            this.Controls.Add(this.labelInfo_ZII);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_ZII;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.Button buttonClose_ZII;
    }
}