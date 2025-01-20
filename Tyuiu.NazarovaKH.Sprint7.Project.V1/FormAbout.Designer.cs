namespace Tyuiu.NazarovaKH.Sprint7.Project.V1
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
            labelInfo_NKH = new Label();
            buttonBack_NKH = new Button();
            SuspendLayout();
            // 
            // labelInfo_NKH
            // 
            labelInfo_NKH.AutoSize = true;
            labelInfo_NKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_NKH.Location = new Point(12, 11);
            labelInfo_NKH.Name = "labelInfo_NKH";
            labelInfo_NKH.Size = new Size(893, 375);
            labelInfo_NKH.TabIndex = 0;
            labelInfo_NKH.Text = resources.GetString("labelInfo_NKH.Text");
            labelInfo_NKH.Click += labelInfo_NKH_Click;
            // 
            // buttonBack_NKH
            // 
            buttonBack_NKH.Location = new Point(753, 335);
            buttonBack_NKH.Margin = new Padding(3, 4, 3, 4);
            buttonBack_NKH.Name = "buttonBack_NKH";
            buttonBack_NKH.Size = new Size(150, 51);
            buttonBack_NKH.TabIndex = 2;
            buttonBack_NKH.Text = "Вернуться назад";
            buttonBack_NKH.UseVisualStyleBackColor = true;
            buttonBack_NKH.Click += buttonBack_NKH_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 407);
            Controls.Add(buttonBack_NKH);
            Controls.Add(labelInfo_NKH);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(940, 454);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О приложении";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInfo_NKH;
        private System.Windows.Forms.Button buttonBack_NKH;
    }
}