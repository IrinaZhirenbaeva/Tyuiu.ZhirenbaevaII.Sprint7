
namespace Tyuiu.ZhirenbaevaII.Sprint7.Project.V12
{
    partial class FormFirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirm));
            this.groupBoxData_ZII = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_ZII = new System.Windows.Forms.DataGridView();
            this.buttonGetMatrix_ZII = new System.Windows.Forms.Button();
            this.groupBoxNote_ZII = new System.Windows.Forms.GroupBox();
            this.labelID_ZII = new System.Windows.Forms.Label();
            this.textBoxID_ZII = new System.Windows.Forms.TextBox();
            this.buttonAddNote_ZII = new System.Windows.Forms.Button();
            this.textBoxNote_ZII = new System.Windows.Forms.TextBox();
            this.openFileDialogData_ZII = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogData_ZII = new System.Windows.Forms.SaveFileDialog();
            this.toolTipInfo_ZII = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxData_ZII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_ZII)).BeginInit();
            this.groupBoxNote_ZII.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData_ZII
            // 
            this.groupBoxData_ZII.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_ZII.Controls.Add(this.dataGridViewData_ZII);
            this.groupBoxData_ZII.Location = new System.Drawing.Point(9, 63);
            this.groupBoxData_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxData_ZII.Name = "groupBoxData_ZII";
            this.groupBoxData_ZII.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxData_ZII.Size = new System.Drawing.Size(546, 375);
            this.groupBoxData_ZII.TabIndex = 3;
            this.groupBoxData_ZII.TabStop = false;
            this.groupBoxData_ZII.Text = "Фирмы-реализаторы";
            // 
            // dataGridViewData_ZII
            // 
            this.dataGridViewData_ZII.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData_ZII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_ZII.ColumnHeadersVisible = false;
            this.dataGridViewData_ZII.Location = new System.Drawing.Point(4, 15);
            this.dataGridViewData_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData_ZII.Name = "dataGridViewData_ZII";
            this.dataGridViewData_ZII.RowHeadersVisible = false;
            this.dataGridViewData_ZII.RowHeadersWidth = 51;
            this.dataGridViewData_ZII.RowTemplate.Height = 24;
            this.dataGridViewData_ZII.Size = new System.Drawing.Size(537, 355);
            this.dataGridViewData_ZII.TabIndex = 0;
            this.dataGridViewData_ZII.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_ZII_CellContentClick);
            // 
            // buttonGetMatrix_ZII
            // 
            this.buttonGetMatrix_ZII.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetMatrix_ZII.Image = ((System.Drawing.Image)(resources.GetObject("buttonGetMatrix_ZII.Image")));
            this.buttonGetMatrix_ZII.Location = new System.Drawing.Point(9, 10);
            this.buttonGetMatrix_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetMatrix_ZII.Name = "buttonGetMatrix_ZII";
            this.buttonGetMatrix_ZII.Size = new System.Drawing.Size(772, 49);
            this.buttonGetMatrix_ZII.TabIndex = 2;
            this.toolTipInfo_ZII.SetToolTip(this.buttonGetMatrix_ZII, "Выгрузить базу данных");
            this.buttonGetMatrix_ZII.UseVisualStyleBackColor = true;
            this.buttonGetMatrix_ZII.Click += new System.EventHandler(this.buttonGetMatrix_ZII_Click);
            // 
            // groupBoxNote_ZII
            // 
            this.groupBoxNote_ZII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNote_ZII.Controls.Add(this.labelID_ZII);
            this.groupBoxNote_ZII.Controls.Add(this.textBoxID_ZII);
            this.groupBoxNote_ZII.Controls.Add(this.buttonAddNote_ZII);
            this.groupBoxNote_ZII.Controls.Add(this.textBoxNote_ZII);
            this.groupBoxNote_ZII.Location = new System.Drawing.Point(560, 63);
            this.groupBoxNote_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNote_ZII.Name = "groupBoxNote_ZII";
            this.groupBoxNote_ZII.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNote_ZII.Size = new System.Drawing.Size(222, 375);
            this.groupBoxNote_ZII.TabIndex = 4;
            this.groupBoxNote_ZII.TabStop = false;
            this.groupBoxNote_ZII.Text = "Примечание";
            // 
            // labelID_ZII
            // 
            this.labelID_ZII.AutoSize = true;
            this.labelID_ZII.Location = new System.Drawing.Point(4, 233);
            this.labelID_ZII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID_ZII.Name = "labelID_ZII";
            this.labelID_ZII.Size = new System.Drawing.Size(72, 13);
            this.labelID_ZII.TabIndex = 3;
            this.labelID_ZII.Text = "Напишите ID";
            // 
            // textBoxID_ZII
            // 
            this.textBoxID_ZII.Location = new System.Drawing.Point(4, 249);
            this.textBoxID_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID_ZII.Name = "textBoxID_ZII";
            this.textBoxID_ZII.Size = new System.Drawing.Size(214, 20);
            this.textBoxID_ZII.TabIndex = 2;
            // 
            // buttonAddNote_ZII
            // 
            this.buttonAddNote_ZII.Location = new System.Drawing.Point(4, 310);
            this.buttonAddNote_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNote_ZII.Name = "buttonAddNote_ZII";
            this.buttonAddNote_ZII.Size = new System.Drawing.Size(213, 60);
            this.buttonAddNote_ZII.TabIndex = 1;
            this.buttonAddNote_ZII.Text = "Добавить примечание";
            this.buttonAddNote_ZII.UseVisualStyleBackColor = true;
            this.buttonAddNote_ZII.Click += new System.EventHandler(this.buttonAddNote_ZII_Click);
            // 
            // textBoxNote_ZII
            // 
            this.textBoxNote_ZII.Location = new System.Drawing.Point(4, 15);
            this.textBoxNote_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNote_ZII.Multiline = true;
            this.textBoxNote_ZII.Name = "textBoxNote_ZII";
            this.textBoxNote_ZII.Size = new System.Drawing.Size(214, 210);
            this.textBoxNote_ZII.TabIndex = 0;
            // 
            // openFileDialogData_ZII
            // 
            this.openFileDialogData_ZII.FileName = "openFileDialog1";
            // 
            // toolTipInfo_ZII
            // 
            this.toolTipInfo_ZII.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_ZII.ToolTipTitle = "Подсказка";
            // 
            // FormFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 448);
            this.Controls.Add(this.groupBoxData_ZII);
            this.Controls.Add(this.buttonGetMatrix_ZII);
            this.Controls.Add(this.groupBoxNote_ZII);
            this.Name = "FormFirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы-реализаторы";
            this.groupBoxData_ZII.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_ZII)).EndInit();
            this.groupBoxNote_ZII.ResumeLayout(false);
            this.groupBoxNote_ZII.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData_ZII;
        private System.Windows.Forms.DataGridView dataGridViewData_ZII;
        private System.Windows.Forms.Button buttonGetMatrix_ZII;
        private System.Windows.Forms.ToolTip toolTipInfo_ZII;
        private System.Windows.Forms.GroupBox groupBoxNote_ZII;
        private System.Windows.Forms.Label labelID_ZII;
        private System.Windows.Forms.TextBox textBoxID_ZII;
        private System.Windows.Forms.Button buttonAddNote_ZII;
        private System.Windows.Forms.TextBox textBoxNote_ZII;
        private System.Windows.Forms.OpenFileDialog openFileDialogData_ZII;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData_ZII;
    }
}