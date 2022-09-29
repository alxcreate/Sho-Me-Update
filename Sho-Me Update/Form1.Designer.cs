namespace Sho_Me_Update
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Button_DownloadBase = new System.Windows.Forms.Button();
            this.CBox_DriveLetter = new System.Windows.Forms.ComboBox();
            this.Label_ChoiseCard = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Label_Status = new System.Windows.Forms.Label();
            this.CBox_Model = new System.Windows.Forms.ComboBox();
            this.Button_DownloadFirmware = new System.Windows.Forms.Button();
            this.CheckBox_Clean = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_DownloadBase
            // 
            this.Button_DownloadBase.Location = new System.Drawing.Point(15, 56);
            this.Button_DownloadBase.Name = "Button_DownloadBase";
            this.Button_DownloadBase.Size = new System.Drawing.Size(180, 23);
            this.Button_DownloadBase.TabIndex = 0;
            this.Button_DownloadBase.Text = "Загрузить базу";
            this.Button_DownloadBase.UseVisualStyleBackColor = true;
            this.Button_DownloadBase.Click += new System.EventHandler(this.Button_DownloadBase_Click);
            // 
            // CBox_DriveLetter
            // 
            this.CBox_DriveLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_DriveLetter.FormattingEnabled = true;
            this.CBox_DriveLetter.Location = new System.Drawing.Point(331, 29);
            this.CBox_DriveLetter.Name = "CBox_DriveLetter";
            this.CBox_DriveLetter.Size = new System.Drawing.Size(46, 21);
            this.CBox_DriveLetter.TabIndex = 2;
            this.CBox_DriveLetter.SelectedIndexChanged += new System.EventHandler(this.CBox_DriveLetter_SelectedIndexChanged);
            // 
            // Label_ChoiseCard
            // 
            this.Label_ChoiseCard.AutoSize = true;
            this.Label_ChoiseCard.Location = new System.Drawing.Point(250, 32);
            this.Label_ChoiseCard.Name = "Label_ChoiseCard";
            this.Label_ChoiseCard.Size = new System.Drawing.Size(80, 13);
            this.Label_ChoiseCard.TabIndex = 3;
            this.Label_ChoiseCard.Text = "Карта памяти:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Location = new System.Drawing.Point(14, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(208, 13);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "Обновление радар-детекторов SHO-ME";
            this.Label_Title.Click += new System.EventHandler(this.Label_Title_Click);
            // 
            // Picture_Logo
            // 
            this.Picture_Logo.Image = global::Sho_Me_Update.Properties.Resources.logo;
            this.Picture_Logo.Location = new System.Drawing.Point(217, 79);
            this.Picture_Logo.Name = "Picture_Logo";
            this.Picture_Logo.Size = new System.Drawing.Size(168, 50);
            this.Picture_Logo.TabIndex = 5;
            this.Picture_Logo.TabStop = false;
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Location = new System.Drawing.Point(14, 113);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(0, 13);
            this.Label_Status.TabIndex = 6;
            this.Label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Status.Click += new System.EventHandler(this.Label_Status_Click);
            // 
            // CBox_Model
            // 
            this.CBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Model.FormattingEnabled = true;
            this.CBox_Model.Location = new System.Drawing.Point(16, 29);
            this.CBox_Model.Name = "CBox_Model";
            this.CBox_Model.Size = new System.Drawing.Size(216, 21);
            this.CBox_Model.TabIndex = 7;
            // 
            // Button_DownloadFirmware
            // 
            this.Button_DownloadFirmware.Location = new System.Drawing.Point(15, 84);
            this.Button_DownloadFirmware.Name = "Button_DownloadFirmware";
            this.Button_DownloadFirmware.Size = new System.Drawing.Size(180, 23);
            this.Button_DownloadFirmware.TabIndex = 8;
            this.Button_DownloadFirmware.Text = "Загрузить прошивку";
            this.Button_DownloadFirmware.UseVisualStyleBackColor = true;
            this.Button_DownloadFirmware.Click += new System.EventHandler(this.Button_Download_Firmware_Click);
            // 
            // CheckBox_Clean
            // 
            this.CheckBox_Clean.AutoSize = true;
            this.CheckBox_Clean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox_Clean.Checked = true;
            this.CheckBox_Clean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Clean.Location = new System.Drawing.Point(217, 56);
            this.CheckBox_Clean.Name = "CheckBox_Clean";
            this.CheckBox_Clean.Size = new System.Drawing.Size(161, 17);
            this.CheckBox_Clean.TabIndex = 9;
            this.CheckBox_Clean.Text = "Очистить перед загрузкой";
            this.CheckBox_Clean.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(393, 138);
            this.Controls.Add(this.CheckBox_Clean);
            this.Controls.Add(this.Button_DownloadFirmware);
            this.Controls.Add(this.CBox_Model);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Label_ChoiseCard);
            this.Controls.Add(this.CBox_DriveLetter);
            this.Controls.Add(this.Button_DownloadBase);
            this.Controls.Add(this.Picture_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "SHO-ME Update";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_DownloadBase;
        private System.Windows.Forms.ComboBox CBox_DriveLetter;
        private System.Windows.Forms.Label Label_ChoiseCard;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.PictureBox Picture_Logo;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.ComboBox CBox_Model;
        private System.Windows.Forms.Button Button_DownloadFirmware;
        private System.Windows.Forms.CheckBox CheckBox_Clean;
    }
}