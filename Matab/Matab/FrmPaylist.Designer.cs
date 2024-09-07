namespace Matab
{
    partial class FrmPaylist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaylist));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DataGPay = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmonshi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tozih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCodeMonshi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.MaskSalary = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtNameK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnSearch = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskDate2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskDate1 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.BtnPrint = new DevComponents.DotNetBar.ButtonX();
            this.BtnDelete = new DevComponents.DotNetBar.ButtonX();
            this.StiReportPay = new Stimulsoft.Report.StiReport();
            this.groupPanel1.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGPay)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(895, 414);
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
            this.groupPanel4.Controls.Add(this.DataGPay);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(3, 62);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(883, 283);
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
            this.groupPanel4.TabIndex = 5;
            // 
            // DataGPay
            // 
            this.DataGPay.AllowUserToAddRows = false;
            this.DataGPay.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpay,
            this.idmonshi,
            this.namek,
            this.salary,
            this.date,
            this.tozih});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGPay.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGPay.EnableHeadersVisualStyles = false;
            this.DataGPay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGPay.Location = new System.Drawing.Point(0, 0);
            this.DataGPay.Name = "DataGPay";
            this.DataGPay.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGPay.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGPay.Size = new System.Drawing.Size(877, 277);
            this.DataGPay.TabIndex = 0;
            // 
            // idpay
            // 
            this.idpay.DataPropertyName = "IDPay";
            this.idpay.HeaderText = "کد پرداخت";
            this.idpay.Name = "idpay";
            this.idpay.ReadOnly = true;
            this.idpay.Visible = false;
            // 
            // idmonshi
            // 
            this.idmonshi.DataPropertyName = "IDMonshi";
            this.idmonshi.HeaderText = "کد منشی";
            this.idmonshi.Name = "idmonshi";
            this.idmonshi.ReadOnly = true;
            this.idmonshi.Width = 150;
            // 
            // namek
            // 
            this.namek.DataPropertyName = "NameK";
            this.namek.HeaderText = "نام خانوادگی";
            this.namek.Name = "namek";
            this.namek.ReadOnly = true;
            this.namek.Width = 150;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "Salary";
            this.salary.HeaderText = "حقوق پرداخت شده";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "DateS";
            this.date.HeaderText = "تاریخ پرداخت";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // tozih
            // 
            this.tozih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tozih.DataPropertyName = "Tozih";
            this.tozih.HeaderText = "توضیحات";
            this.tozih.Name = "tozih";
            this.tozih.ReadOnly = true;
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
            this.groupPanel2.Location = new System.Drawing.Point(3, 5);
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
            this.groupPanel2.TabIndex = 4;
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
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.BtnSearch);
            this.groupPanel3.Controls.Add(this.label2);
            this.groupPanel3.Controls.Add(this.MaskDate2);
            this.groupPanel3.Controls.Add(this.label1);
            this.groupPanel3.Controls.Add(this.MaskDate1);
            this.groupPanel3.Controls.Add(this.BtnPrint);
            this.groupPanel3.Controls.Add(this.BtnDelete);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(3, 351);
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
            this.groupPanel3.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSearch.Checked = true;
            this.BtnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSearch.Location = new System.Drawing.Point(14, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(28, 18);
            this.BtnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSearch.TabIndex = 17;
            this.BtnSearch.Text = "+";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(205, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "تاریخ تا :";
            // 
            // MaskDate2
            // 
            // 
            // 
            // 
            this.MaskDate2.BackgroundStyle.Class = "TextBoxBorder";
            this.MaskDate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MaskDate2.ButtonClear.Visible = true;
            this.MaskDate2.Location = new System.Drawing.Point(59, 12);
            this.MaskDate2.Mask = "####/##/##";
            this.MaskDate2.Name = "MaskDate2";
            this.MaskDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaskDate2.Size = new System.Drawing.Size(140, 21);
            this.MaskDate2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MaskDate2.TabIndex = 15;
            this.MaskDate2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(488, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "تاریخ از :";
            // 
            // MaskDate1
            // 
            // 
            // 
            // 
            this.MaskDate1.BackgroundStyle.Class = "TextBoxBorder";
            this.MaskDate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MaskDate1.ButtonClear.Visible = true;
            this.MaskDate1.Location = new System.Drawing.Point(342, 9);
            this.MaskDate1.Mask = "####/##/##";
            this.MaskDate1.Name = "MaskDate1";
            this.MaskDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaskDate1.Size = new System.Drawing.Size(140, 21);
            this.MaskDate1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MaskDate1.TabIndex = 13;
            this.MaskDate1.Text = "";
            // 
            // BtnPrint
            // 
            this.BtnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.Checked = true;
            this.BtnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnPrint.Location = new System.Drawing.Point(603, 4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.BtnPrint.Size = new System.Drawing.Size(122, 33);
            this.BtnPrint.TabIndex = 12;
            this.BtnPrint.Text = "چاپ";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDelete.Checked = true;
            this.BtnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnDelete.ImageTextSpacing = 20;
            this.BtnDelete.Location = new System.Drawing.Point(740, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.BtnDelete.Size = new System.Drawing.Size(131, 33);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // StiReportPay
            // 
            this.StiReportPay.CacheAllData = true;
            this.StiReportPay.CookieContainer = null;
            this.StiReportPay.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.StiReportPay.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.StiReportPay.ReportAlias = "Report";
            this.StiReportPay.ReportGuid = "8dbfdbb9a89647998982ee70c9bdc196";
            this.StiReportPay.ReportImage = null;
            this.StiReportPay.ReportName = "Report";
            this.StiReportPay.ReportSource = resources.GetString("StiReportPay.ReportSource");
            this.StiReportPay.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.StiReportPay.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.StiReportPay.UseProgressInThread = false;
            // 
            // FrmPaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 414);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPaylist";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست پرداخت ها";
            this.Load += new System.EventHandler(this.FrmPaylist_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGPay)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX BtnPrint;
        private DevComponents.DotNetBar.ButtonX BtnDelete;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmonshi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namek;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tozih;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodeMonshi;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MaskSalary;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameK;
        private Stimulsoft.Report.StiReport StiReportPay;
        private DevComponents.DotNetBar.ButtonX BtnSearch;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MaskDate2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MaskDate1;

    }
}