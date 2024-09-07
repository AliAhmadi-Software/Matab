namespace Matab
{
    partial class FrmListMonshi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DataGListMonshi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IDMonshi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMonshi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tozih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnPay = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCodeMonshi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.MaskSalary = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtNameK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGListMonshi)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(895, 393);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.DataGListMonshi);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(3, 60);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(883, 270);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 3;
            // 
            // DataGListMonshi
            // 
            this.DataGListMonshi.AllowUserToAddRows = false;
            this.DataGListMonshi.AllowUserToDeleteRows = false;
            this.DataGListMonshi.BackgroundColor = System.Drawing.Color.Snow;
            this.DataGListMonshi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGListMonshi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMonshi,
            this.NameMonshi,
            this.NameK,
            this.CodeM,
            this.Tel,
            this.DataB,
            this.DateE,
            this.Salary,
            this.DateSalary,
            this.Tozih});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGListMonshi.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGListMonshi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGListMonshi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGListMonshi.Location = new System.Drawing.Point(0, 0);
            this.DataGListMonshi.Name = "DataGListMonshi";
            this.DataGListMonshi.ReadOnly = true;
            this.DataGListMonshi.Size = new System.Drawing.Size(877, 264);
            this.DataGListMonshi.TabIndex = 0;
            // 
            // IDMonshi
            // 
            this.IDMonshi.DataPropertyName = "IDMonshi";
            this.IDMonshi.HeaderText = "کد منشی";
            this.IDMonshi.Name = "IDMonshi";
            this.IDMonshi.ReadOnly = true;
            this.IDMonshi.Width = 60;
            // 
            // NameMonshi
            // 
            this.NameMonshi.DataPropertyName = "NameMonshi";
            this.NameMonshi.HeaderText = "نام ";
            this.NameMonshi.Name = "NameMonshi";
            this.NameMonshi.ReadOnly = true;
            this.NameMonshi.Width = 50;
            // 
            // NameK
            // 
            this.NameK.DataPropertyName = "NameK";
            this.NameK.HeaderText = "نام خانوادگی";
            this.NameK.Name = "NameK";
            this.NameK.ReadOnly = true;
            // 
            // CodeM
            // 
            this.CodeM.DataPropertyName = "CodeM";
            this.CodeM.HeaderText = "کد ملی";
            this.CodeM.Name = "CodeM";
            this.CodeM.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "تلفن";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // DataB
            // 
            this.DataB.DataPropertyName = "DataB";
            this.DataB.HeaderText = "تاریخ تولد";
            this.DataB.Name = "DataB";
            this.DataB.ReadOnly = true;
            this.DataB.Width = 80;
            // 
            // DateE
            // 
            this.DateE.DataPropertyName = "DateE";
            this.DateE.HeaderText = "تاریخ استخدام";
            this.DateE.Name = "DateE";
            this.DateE.ReadOnly = true;
            this.DateE.Width = 80;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "حقوق";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // DateSalary
            // 
            this.DateSalary.DataPropertyName = "DateSalary";
            this.DateSalary.HeaderText = "تاریخ حقوق";
            this.DateSalary.Name = "DateSalary";
            this.DateSalary.ReadOnly = true;
            // 
            // Tozih
            // 
            this.Tozih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tozih.DataPropertyName = "Tozih";
            this.Tozih.HeaderText = "توضیحات";
            this.Tozih.Name = "Tozih";
            this.Tozih.ReadOnly = true;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.BtnPay);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(3, 336);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(883, 51);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            // 
            // BtnPay
            // 
            this.BtnPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPay.Checked = true;
            this.BtnPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnPay.ImageTextSpacing = 20;
            this.BtnPay.Location = new System.Drawing.Point(653, 5);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.BtnPay.Size = new System.Drawing.Size(218, 33);
            this.BtnPay.TabIndex = 11;
            this.BtnPay.Text = "پرداخت حقوق";
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtCodeMonshi);
            this.groupPanel2.Controls.Add(this.label10);
            this.groupPanel2.Controls.Add(this.MaskSalary);
            this.groupPanel2.Controls.Add(this.txtNameK);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(3, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(883, 51);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // txtCodeMonshi
            // 
            // 
            // 
            // 
            this.txtCodeMonshi.Border.Class = "TextBoxBorder";
            this.txtCodeMonshi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodeMonshi.Location = new System.Drawing.Point(533, 12);
            this.txtCodeMonshi.Name = "txtCodeMonshi";
            this.txtCodeMonshi.PreventEnterBeep = true;
            this.txtCodeMonshi.Size = new System.Drawing.Size(105, 22);
            this.txtCodeMonshi.TabIndex = 6;
            this.txtCodeMonshi.WatermarkText = "کد را وارد نمایید";
            this.txtCodeMonshi.TextChanged += new System.EventHandler(this.txtCodeMonshi_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(171, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 5;
            this.label10.Text = "تاریخ حقوق‌ :";
            // 
            // MaskSalary
            // 
            // 
            // 
            // 
            this.MaskSalary.BackgroundStyle.Class = "TextBoxBorder";
            this.MaskSalary.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MaskSalary.ButtonClear.Visible = true;
            this.MaskSalary.Location = new System.Drawing.Point(29, 12);
            this.MaskSalary.Mask = "####/##/##";
            this.MaskSalary.Name = "MaskSalary";
            this.MaskSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaskSalary.Size = new System.Drawing.Size(140, 21);
            this.MaskSalary.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MaskSalary.TabIndex = 4;
            this.MaskSalary.Text = "";
            this.MaskSalary.TextChanged += new System.EventHandler(this.MaskSalary_TextChanged);
            // 
            // txtNameK
            // 
            // 
            // 
            // 
            this.txtNameK.Border.Class = "TextBoxBorder";
            this.txtNameK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameK.Location = new System.Drawing.Point(681, 12);
            this.txtNameK.Name = "txtNameK";
            this.txtNameK.PreventEnterBeep = true;
            this.txtNameK.Size = new System.Drawing.Size(173, 22);
            this.txtNameK.TabIndex = 3;
            this.txtNameK.WatermarkText = "نام خانوادگی را وارد نمایید";
            this.txtNameK.TextChanged += new System.EventHandler(this.txtNameK_TextChanged);
            // 
            // FrmListMonshi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 393);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListMonshi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست منشی ها";
            this.Load += new System.EventHandler(this.FrmListMonshi_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGListMonshi)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MaskSalary;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameK;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGListMonshi;
        private DevComponents.DotNetBar.ButtonX BtnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMonshi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMonshi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tozih;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodeMonshi;
    }
}