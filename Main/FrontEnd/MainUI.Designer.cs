namespace ColorSelector
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.ClassicTab = new System.Windows.Forms.TabPage();
            this.CloseAppC_Btn = new System.Windows.Forms.Button();
            this.ColorSelectC_GB = new System.Windows.Forms.GroupBox();
            this.SelectedScreenC_Panel = new System.Windows.Forms.Panel();
            this.BC_TB = new System.Windows.Forms.TextBox();
            this.BC_Label = new System.Windows.Forms.Label();
            this.GC_TB = new System.Windows.Forms.TextBox();
            this.GC_Label = new System.Windows.Forms.Label();
            this.RC_TB = new System.Windows.Forms.TextBox();
            this.RC_Label = new System.Windows.Forms.Label();
            this.SmallScreenC_Label = new System.Windows.Forms.Label();
            this.RGBCV_Read = new System.Windows.Forms.Label();
            this.SelectColorC_Header = new System.Windows.Forms.Label();
            this.RGBC_PB = new System.Windows.Forms.PictureBox();
            this.MainUI_TabControl = new System.Windows.Forms.TabControl();
            this.HexagonalTab = new System.Windows.Forms.TabPage();
            this.CloseH_Btn = new System.Windows.Forms.Button();
            this.ColorSelectH_GB = new System.Windows.Forms.GroupBox();
            this.SelectedScreenH_Panel = new System.Windows.Forms.Panel();
            this.BH_TB = new System.Windows.Forms.TextBox();
            this.BH_Label = new System.Windows.Forms.Label();
            this.GH_TB = new System.Windows.Forms.TextBox();
            this.GH_Label = new System.Windows.Forms.Label();
            this.RH_TB = new System.Windows.Forms.TextBox();
            this.RH_Label = new System.Windows.Forms.Label();
            this.SmallScreenH_Label = new System.Windows.Forms.Label();
            this.RGBHV_Read = new System.Windows.Forms.Label();
            this.SelectColorH_Header = new System.Windows.Forms.Label();
            this.RGBH_PB = new System.Windows.Forms.PictureBox();
            this.ClassicTab.SuspendLayout();
            this.ColorSelectC_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBC_PB)).BeginInit();
            this.MainUI_TabControl.SuspendLayout();
            this.HexagonalTab.SuspendLayout();
            this.ColorSelectH_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBH_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassicTab
            // 
            this.ClassicTab.Controls.Add(this.CloseAppC_Btn);
            this.ClassicTab.Controls.Add(this.ColorSelectC_GB);
            this.ClassicTab.Controls.Add(this.SmallScreenC_Label);
            this.ClassicTab.Controls.Add(this.RGBCV_Read);
            this.ClassicTab.Controls.Add(this.SelectColorC_Header);
            this.ClassicTab.Controls.Add(this.RGBC_PB);
            this.ClassicTab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicTab.Location = new System.Drawing.Point(4, 26);
            this.ClassicTab.Name = "ClassicTab";
            this.ClassicTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClassicTab.Size = new System.Drawing.Size(267, 381);
            this.ClassicTab.TabIndex = 0;
            this.ClassicTab.Text = "Classic";
            this.ClassicTab.UseVisualStyleBackColor = true;
            // 
            // CloseAppC_Btn
            // 
            this.CloseAppC_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAppC_Btn.Location = new System.Drawing.Point(17, 345);
            this.CloseAppC_Btn.Name = "CloseAppC_Btn";
            this.CloseAppC_Btn.Size = new System.Drawing.Size(242, 30);
            this.CloseAppC_Btn.TabIndex = 11;
            this.CloseAppC_Btn.Text = "Close App";
            this.CloseAppC_Btn.UseVisualStyleBackColor = true;
            this.CloseAppC_Btn.Click += new System.EventHandler(this.CloseApp_Btn_Click);
            // 
            // ColorSelectC_GB
            // 
            this.ColorSelectC_GB.Controls.Add(this.SelectedScreenC_Panel);
            this.ColorSelectC_GB.Controls.Add(this.BC_TB);
            this.ColorSelectC_GB.Controls.Add(this.BC_Label);
            this.ColorSelectC_GB.Controls.Add(this.GC_TB);
            this.ColorSelectC_GB.Controls.Add(this.GC_Label);
            this.ColorSelectC_GB.Controls.Add(this.RC_TB);
            this.ColorSelectC_GB.Controls.Add(this.RC_Label);
            this.ColorSelectC_GB.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSelectC_GB.Location = new System.Drawing.Point(17, 212);
            this.ColorSelectC_GB.Name = "ColorSelectC_GB";
            this.ColorSelectC_GB.Size = new System.Drawing.Size(242, 127);
            this.ColorSelectC_GB.TabIndex = 10;
            this.ColorSelectC_GB.TabStop = false;
            this.ColorSelectC_GB.Text = "Color Selected";
            // 
            // SelectedScreenC_Panel
            // 
            this.SelectedScreenC_Panel.Location = new System.Drawing.Point(138, 23);
            this.SelectedScreenC_Panel.Name = "SelectedScreenC_Panel";
            this.SelectedScreenC_Panel.Size = new System.Drawing.Size(102, 93);
            this.SelectedScreenC_Panel.TabIndex = 6;
            // 
            // BC_TB
            // 
            this.BC_TB.Location = new System.Drawing.Point(34, 89);
            this.BC_TB.Name = "BC_TB";
            this.BC_TB.ReadOnly = true;
            this.BC_TB.Size = new System.Drawing.Size(100, 27);
            this.BC_TB.TabIndex = 5;
            // 
            // BC_Label
            // 
            this.BC_Label.AutoSize = true;
            this.BC_Label.Location = new System.Drawing.Point(6, 92);
            this.BC_Label.Name = "BC_Label";
            this.BC_Label.Size = new System.Drawing.Size(22, 20);
            this.BC_Label.TabIndex = 4;
            this.BC_Label.Text = "B:";
            // 
            // GC_TB
            // 
            this.GC_TB.Location = new System.Drawing.Point(34, 56);
            this.GC_TB.Name = "GC_TB";
            this.GC_TB.ReadOnly = true;
            this.GC_TB.Size = new System.Drawing.Size(100, 27);
            this.GC_TB.TabIndex = 3;
            // 
            // GC_Label
            // 
            this.GC_Label.AutoSize = true;
            this.GC_Label.Location = new System.Drawing.Point(6, 59);
            this.GC_Label.Name = "GC_Label";
            this.GC_Label.Size = new System.Drawing.Size(23, 20);
            this.GC_Label.TabIndex = 2;
            this.GC_Label.Text = "G:";
            // 
            // RC_TB
            // 
            this.RC_TB.Location = new System.Drawing.Point(34, 23);
            this.RC_TB.Name = "RC_TB";
            this.RC_TB.ReadOnly = true;
            this.RC_TB.Size = new System.Drawing.Size(100, 27);
            this.RC_TB.TabIndex = 1;
            // 
            // RC_Label
            // 
            this.RC_Label.AutoSize = true;
            this.RC_Label.Location = new System.Drawing.Point(6, 26);
            this.RC_Label.Name = "RC_Label";
            this.RC_Label.Size = new System.Drawing.Size(22, 20);
            this.RC_Label.TabIndex = 0;
            this.RC_Label.Text = "R:";
            // 
            // SmallScreenC_Label
            // 
            this.SmallScreenC_Label.BackColor = System.Drawing.Color.Black;
            this.SmallScreenC_Label.Location = new System.Drawing.Point(211, 186);
            this.SmallScreenC_Label.Name = "SmallScreenC_Label";
            this.SmallScreenC_Label.Size = new System.Drawing.Size(48, 23);
            this.SmallScreenC_Label.TabIndex = 9;
            // 
            // RGBCV_Read
            // 
            this.RGBCV_Read.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBCV_Read.Location = new System.Drawing.Point(17, 186);
            this.RGBCV_Read.Name = "RGBCV_Read";
            this.RGBCV_Read.Size = new System.Drawing.Size(188, 23);
            this.RGBCV_Read.TabIndex = 8;
            this.RGBCV_Read.Text = "RGB: ";
            this.RGBCV_Read.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectColorC_Header
            // 
            this.SelectColorC_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectColorC_Header.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectColorC_Header.Location = new System.Drawing.Point(3, 3);
            this.SelectColorC_Header.Name = "SelectColorC_Header";
            this.SelectColorC_Header.Size = new System.Drawing.Size(261, 23);
            this.SelectColorC_Header.TabIndex = 7;
            this.SelectColorC_Header.Text = "Choose Color Below";
            this.SelectColorC_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RGBC_PB
            // 
            this.RGBC_PB.Image = global::ColorPicker.Properties.Resources.rgbSpectrum;
            this.RGBC_PB.Location = new System.Drawing.Point(21, 27);
            this.RGBC_PB.Name = "RGBC_PB";
            this.RGBC_PB.Size = new System.Drawing.Size(226, 156);
            this.RGBC_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RGBC_PB.TabIndex = 6;
            this.RGBC_PB.TabStop = false;
            this.RGBC_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RGBC_PB_MouseDown);
            this.RGBC_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RGBC_PB_MouseMove);
            // 
            // MainUI_TabControl
            // 
            this.MainUI_TabControl.Controls.Add(this.ClassicTab);
            this.MainUI_TabControl.Controls.Add(this.HexagonalTab);
            this.MainUI_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainUI_TabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainUI_TabControl.Location = new System.Drawing.Point(0, 0);
            this.MainUI_TabControl.Name = "MainUI_TabControl";
            this.MainUI_TabControl.SelectedIndex = 0;
            this.MainUI_TabControl.Size = new System.Drawing.Size(275, 474);
            this.MainUI_TabControl.TabIndex = 6;
            this.MainUI_TabControl.SelectedIndexChanged += new System.EventHandler(this.MainUI_TabControl_SelectedIndexChanged);
            // 
            // HexagonalTab
            // 
            this.HexagonalTab.Controls.Add(this.CloseH_Btn);
            this.HexagonalTab.Controls.Add(this.ColorSelectH_GB);
            this.HexagonalTab.Controls.Add(this.SmallScreenH_Label);
            this.HexagonalTab.Controls.Add(this.RGBHV_Read);
            this.HexagonalTab.Controls.Add(this.SelectColorH_Header);
            this.HexagonalTab.Controls.Add(this.RGBH_PB);
            this.HexagonalTab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexagonalTab.Location = new System.Drawing.Point(4, 26);
            this.HexagonalTab.Name = "HexagonalTab";
            this.HexagonalTab.Padding = new System.Windows.Forms.Padding(3);
            this.HexagonalTab.Size = new System.Drawing.Size(267, 444);
            this.HexagonalTab.TabIndex = 1;
            this.HexagonalTab.Text = "Hexagon";
            this.HexagonalTab.UseVisualStyleBackColor = true;
            // 
            // CloseH_Btn
            // 
            this.CloseH_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseH_Btn.Location = new System.Drawing.Point(17, 388);
            this.CloseH_Btn.Name = "CloseH_Btn";
            this.CloseH_Btn.Size = new System.Drawing.Size(242, 30);
            this.CloseH_Btn.TabIndex = 17;
            this.CloseH_Btn.Text = "Close App";
            this.CloseH_Btn.UseVisualStyleBackColor = true;
            this.CloseH_Btn.Click += new System.EventHandler(this.CloseH_Btn_Click);
            // 
            // ColorSelectH_GB
            // 
            this.ColorSelectH_GB.Controls.Add(this.SelectedScreenH_Panel);
            this.ColorSelectH_GB.Controls.Add(this.BH_TB);
            this.ColorSelectH_GB.Controls.Add(this.BH_Label);
            this.ColorSelectH_GB.Controls.Add(this.GH_TB);
            this.ColorSelectH_GB.Controls.Add(this.GH_Label);
            this.ColorSelectH_GB.Controls.Add(this.RH_TB);
            this.ColorSelectH_GB.Controls.Add(this.RH_Label);
            this.ColorSelectH_GB.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSelectH_GB.Location = new System.Drawing.Point(14, 255);
            this.ColorSelectH_GB.Name = "ColorSelectH_GB";
            this.ColorSelectH_GB.Size = new System.Drawing.Size(242, 127);
            this.ColorSelectH_GB.TabIndex = 16;
            this.ColorSelectH_GB.TabStop = false;
            this.ColorSelectH_GB.Text = "Color Selected";
            // 
            // SelectedScreenH_Panel
            // 
            this.SelectedScreenH_Panel.Location = new System.Drawing.Point(138, 23);
            this.SelectedScreenH_Panel.Name = "SelectedScreenH_Panel";
            this.SelectedScreenH_Panel.Size = new System.Drawing.Size(102, 93);
            this.SelectedScreenH_Panel.TabIndex = 6;
            // 
            // BH_TB
            // 
            this.BH_TB.Location = new System.Drawing.Point(34, 89);
            this.BH_TB.Name = "BH_TB";
            this.BH_TB.ReadOnly = true;
            this.BH_TB.Size = new System.Drawing.Size(100, 27);
            this.BH_TB.TabIndex = 5;
            // 
            // BH_Label
            // 
            this.BH_Label.AutoSize = true;
            this.BH_Label.Location = new System.Drawing.Point(6, 92);
            this.BH_Label.Name = "BH_Label";
            this.BH_Label.Size = new System.Drawing.Size(22, 20);
            this.BH_Label.TabIndex = 4;
            this.BH_Label.Text = "B:";
            // 
            // GH_TB
            // 
            this.GH_TB.Location = new System.Drawing.Point(34, 56);
            this.GH_TB.Name = "GH_TB";
            this.GH_TB.ReadOnly = true;
            this.GH_TB.Size = new System.Drawing.Size(100, 27);
            this.GH_TB.TabIndex = 3;
            // 
            // GH_Label
            // 
            this.GH_Label.AutoSize = true;
            this.GH_Label.Location = new System.Drawing.Point(6, 59);
            this.GH_Label.Name = "GH_Label";
            this.GH_Label.Size = new System.Drawing.Size(23, 20);
            this.GH_Label.TabIndex = 2;
            this.GH_Label.Text = "G:";
            // 
            // RH_TB
            // 
            this.RH_TB.Location = new System.Drawing.Point(34, 23);
            this.RH_TB.Name = "RH_TB";
            this.RH_TB.ReadOnly = true;
            this.RH_TB.Size = new System.Drawing.Size(100, 27);
            this.RH_TB.TabIndex = 1;
            // 
            // RH_Label
            // 
            this.RH_Label.AutoSize = true;
            this.RH_Label.Location = new System.Drawing.Point(6, 26);
            this.RH_Label.Name = "RH_Label";
            this.RH_Label.Size = new System.Drawing.Size(22, 20);
            this.RH_Label.TabIndex = 0;
            this.RH_Label.Text = "R:";
            // 
            // SmallScreenH_Label
            // 
            this.SmallScreenH_Label.BackColor = System.Drawing.Color.Black;
            this.SmallScreenH_Label.Location = new System.Drawing.Point(208, 229);
            this.SmallScreenH_Label.Name = "SmallScreenH_Label";
            this.SmallScreenH_Label.Size = new System.Drawing.Size(48, 23);
            this.SmallScreenH_Label.TabIndex = 15;
            // 
            // RGBHV_Read
            // 
            this.RGBHV_Read.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBHV_Read.Location = new System.Drawing.Point(14, 229);
            this.RGBHV_Read.Name = "RGBHV_Read";
            this.RGBHV_Read.Size = new System.Drawing.Size(188, 23);
            this.RGBHV_Read.TabIndex = 14;
            this.RGBHV_Read.Text = "RGB: ";
            this.RGBHV_Read.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectColorH_Header
            // 
            this.SelectColorH_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectColorH_Header.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectColorH_Header.Location = new System.Drawing.Point(3, 3);
            this.SelectColorH_Header.Name = "SelectColorH_Header";
            this.SelectColorH_Header.Size = new System.Drawing.Size(261, 23);
            this.SelectColorH_Header.TabIndex = 13;
            this.SelectColorH_Header.Text = "Choose Color Below";
            this.SelectColorH_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RGBH_PB
            // 
            this.RGBH_PB.Image = global::ColorPicker.Properties.Resources.Hex_RGB_1;
            this.RGBH_PB.Location = new System.Drawing.Point(18, 25);
            this.RGBH_PB.Name = "RGBH_PB";
            this.RGBH_PB.Size = new System.Drawing.Size(234, 199);
            this.RGBH_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RGBH_PB.TabIndex = 12;
            this.RGBH_PB.TabStop = false;
            this.RGBH_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RGBH_PB_MouseDown);
            this.RGBH_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RGBH_PB_MouseMove);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 474);
            this.Controls.Add(this.MainUI_TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "KC™️ Color Picker";
            this.ClassicTab.ResumeLayout(false);
            this.ClassicTab.PerformLayout();
            this.ColorSelectC_GB.ResumeLayout(false);
            this.ColorSelectC_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBC_PB)).EndInit();
            this.MainUI_TabControl.ResumeLayout(false);
            this.HexagonalTab.ResumeLayout(false);
            this.HexagonalTab.PerformLayout();
            this.ColorSelectH_GB.ResumeLayout(false);
            this.ColorSelectH_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBH_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ClassicTab;
        private System.Windows.Forms.Button CloseAppC_Btn;
        private System.Windows.Forms.GroupBox ColorSelectC_GB;
        private System.Windows.Forms.Panel SelectedScreenC_Panel;
        private System.Windows.Forms.TextBox BC_TB;
        private System.Windows.Forms.Label BC_Label;
        private System.Windows.Forms.TextBox GC_TB;
        private System.Windows.Forms.Label GC_Label;
        private System.Windows.Forms.TextBox RC_TB;
        private System.Windows.Forms.Label RC_Label;
        private System.Windows.Forms.Label SmallScreenC_Label;
        private System.Windows.Forms.Label RGBCV_Read;
        private System.Windows.Forms.Label SelectColorC_Header;
        private System.Windows.Forms.PictureBox RGBC_PB;
        private System.Windows.Forms.TabControl MainUI_TabControl;
        private System.Windows.Forms.TabPage HexagonalTab;
        private System.Windows.Forms.Button CloseH_Btn;
        private System.Windows.Forms.GroupBox ColorSelectH_GB;
        private System.Windows.Forms.Panel SelectedScreenH_Panel;
        private System.Windows.Forms.TextBox BH_TB;
        private System.Windows.Forms.Label BH_Label;
        private System.Windows.Forms.TextBox GH_TB;
        private System.Windows.Forms.Label GH_Label;
        private System.Windows.Forms.TextBox RH_TB;
        private System.Windows.Forms.Label RH_Label;
        private System.Windows.Forms.Label SmallScreenH_Label;
        private System.Windows.Forms.Label RGBHV_Read;
        private System.Windows.Forms.Label SelectColorH_Header;
        private System.Windows.Forms.PictureBox RGBH_PB;
    }
}

