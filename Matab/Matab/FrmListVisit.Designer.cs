namespace Matab
{
    partial class FrmListVisit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListVisit));
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtNameK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDVisit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskDateV2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.MaskDateV1 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DataGVisit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idvisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPayV = new System.Windows.Forms.Label();
            this.BtnCalculate = new DevComponents.DotNetBar.ButtonX();
            this.BtnPrint = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.StiVisit = new Stimulsoft.Report.StiReport();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVisit)).BeginInit();
            this.groupPanel4.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.BtnSearch);
            this.groupPanel2.Controls.Add(this.txtNameK);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.txtIDVisit);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.MaskDateV2);
            this.groupPanel2.Controls.Add(this.MaskDateV1);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(3, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(844, 52);
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
            // BtnSearch
            // 
            this.BtnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSearch.Checked = true;
            this.BtnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSearch.Location = new System.Drawing.Point(2, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(28, 21);
            this.BtnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "+";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtNameK
            // 
            // 
            // 
            // 
            this.txtNameK.Border.Class = "TextBoxBorder";
            this.txtNameK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameK.Location = new System.Drawing.Point(606, 12);
            this.txtNameK.Name = "txtNameK";
            this.txtNameK.PreventEnterBeep = true;
            this.txtNameK.Size = new System.Drawing.Size(229, 22);
            this.txtNameK.TabIndex = 16;
            this.txtNameK.WatermarkText = "نام خانوادگی بیمار را وارد نمایید";
            this.txtNameK.TextChanged += new System.EventHandler(this.txtNameK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(380, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "از تاریخ :";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIDVisit
            // 
            // 
            // 
            // 
            this.txtIDVisit.Border.Class = "TextBoxBorder";
            this.txtIDVisit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIDVisit.Location = new System.Drawing.Point(434, 12);
            this.txtIDVisit.Name = "txtIDVisit";
            this.txtIDVisit.PreventEnterBeep = true;
            this.txtIDVisit.Size = new System.Drawing.Size(166, 22);
            this.txtIDVisit.TabIndex = 15;
            this.txtIDVisit.WatermarkText = "شماره ویزیت را وارد نمایید";
            this.txtIDVisit.TextChanged += new System.EventHandler(this.txtIDVisit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(181, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا تاریخ :";
            // 
            // MaskDateV2
            // 
            // 
            // 
            // 
            this.MaskDateV2.BackgroundStyle.Class = "TextBoxBorder";
            this.MaskDateV2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MaskDateV2.ButtonClear.Visible = true;
            this.MaskDateV2.Location = new System.Drawing.Point(36, 13);
            this.MaskDateV2.Mask = "####/##/##";
            this.MaskDateV2.Name = "MaskDateV2";
            this.MaskDateV2.Size = new System.Drawing.Size(139, 21);
            this.MaskDateV2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MaskDateV2.TabIndex = 14;
            this.MaskDateV2.Text = "";
            // 
            // MaskDateV1
            // 
            // 
            // 
            // 
            this.MaskDateV1.BackgroundStyle.Class = "TextBoxBorder";
            this.MaskDateV1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MaskDateV1.ButtonClear.Visible = true;
            this.MaskDateV1.Location = new System.Drawing.Point(235, 13);
            this.MaskDateV1.Mask = "####/##/##";
            this.MaskDateV1.Name = "MaskDateV1";
            this.MaskDateV1.Size = new System.Drawing.Size(139, 21);
            this.MaskDateV1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MaskDateV1.TabIndex = 13;
            this.MaskDateV1.Text = "";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.DataGVisit);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(3, 59);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(844, 263);
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
            // DataGVisit
            // 
            this.DataGVisit.AllowUserToAddRows = false;
            this.DataGVisit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvisit,
            this.datev,
            this.name,
            this.namek,
            this.namein,
            this.pricein,
            this.names,
            this.prices,
            this.payv,
            this.recipe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVisit.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGVisit.EnableHeadersVisualStyles = false;
            this.DataGVisit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGVisit.Location = new System.Drawing.Point(0, 0);
            this.DataGVisit.Name = "DataGVisit";
            this.DataGVisit.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGVisit.Size = new System.Drawing.Size(838, 257);
            this.DataGVisit.TabIndex = 0;
            // 
            // idvisit
            // 
            this.idvisit.DataPropertyName = "IDVisit";
            this.idvisit.HeaderText = "شماره ویزیت";
            this.idvisit.Name = "idvisit";
            this.idvisit.ReadOnly = true;
            // 
            // datev
            // 
            this.datev.DataPropertyName = "DateV";
            this.datev.HeaderText = "تاریخ ویزیت";
            this.datev.Name = "datev";
            this.datev.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام بیمار";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // namek
            // 
            this.namek.DataPropertyName = "NameK";
            this.namek.HeaderText = "نام خانوادگی";
            this.namek.Name = "namek";
            this.namek.ReadOnly = true;
            // 
            // namein
            // 
            this.namein.DataPropertyName = "NameIn";
            this.namein.HeaderText = "نام بیمه";
            this.namein.Name = "namein";
            this.namein.ReadOnly = true;
            // 
            // pricein
            // 
            this.pricein.DataPropertyName = "PriceIn";
            this.pricein.HeaderText = "تعرفه بیمه";
            this.pricein.Name = "pricein";
            this.pricein.ReadOnly = true;
            // 
            // names
            // 
            this.names.DataPropertyName = "NameS";
            this.names.HeaderText = "نام خدمات";
            this.names.Name = "names";
            this.names.ReadOnly = true;
            // 
            // prices
            // 
            this.prices.DataPropertyName = "PriceS";
            this.prices.HeaderText = "تعرفه خدمات";
            this.prices.Name = "prices";
            this.prices.ReadOnly = true;
            // 
            // payv
            // 
            this.payv.DataPropertyName = "PayV";
            this.payv.HeaderText = "هزینه قابل پرداخت";
            this.payv.Name = "payv";
            this.payv.ReadOnly = true;
            // 
            // recipe
            // 
            this.recipe.DataPropertyName = "Recipe";
            this.recipe.HeaderText = "دستور پزشک";
            this.recipe.Name = "recipe";
            this.recipe.ReadOnly = true;
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.label3);
            this.groupPanel4.Controls.Add(this.LblPayV);
            this.groupPanel4.Controls.Add(this.BtnCalculate);
            this.groupPanel4.Controls.Add(this.BtnPrint);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(3, 326);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(844, 52);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(203, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "محاسبه درآمد در بازه تاریخ های انتخاب شده :";
            // 
            // LblPayV
            // 
            this.LblPayV.AutoSize = true;
            this.LblPayV.BackColor = System.Drawing.Color.Transparent;
            this.LblPayV.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPayV.Location = new System.Drawing.Point(107, 15);
            this.LblPayV.Name = "LblPayV";
            this.LblPayV.Size = new System.Drawing.Size(63, 14);
            this.LblPayV.TabIndex = 1;
            this.LblPayV.Text = "00000000";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCalculate.Checked = true;
            this.BtnCalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.BtnCalculate.Location = new System.Drawing.Point(460, 5);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(111, 33);
            this.BtnCalculate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCalculate.TabIndex = 16;
            this.BtnCalculate.Text = "محاسبه درآمد";
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.Checked = true;
            this.BtnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnPrint.Location = new System.Drawing.Point(577, 5);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.BtnPrint.Size = new System.Drawing.Size(241, 33);
            this.BtnPrint.TabIndex = 15;
            this.BtnPrint.Text = "چاپ";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
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
            this.groupPanel1.Size = new System.Drawing.Size(856, 387);
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
            // StiVisit
            // 
            this.StiVisit.CookieContainer = null;
            this.StiVisit.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.StiVisit.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.StiVisit.ReportAlias = "Report";
            this.StiVisit.ReportGuid = "e22b37022cd44920908ab4835e79bd47";
            this.StiVisit.ReportImage = null;
            this.StiVisit.ReportName = "Report";
            this.StiVisit.ReportSource = resources.GetString("StiVisit.ReportSource");
            this.StiVisit.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.StiVisit.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.StiVisit.UseProgressInThread = false;
            // 
            // FrmListVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 387);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListVisit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست ویزیت ها";
            this.Load += new System.EventHandler(this.FrmListVisit_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVisit)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel4.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIDVisit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MaskDateV1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MaskDateV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX BtnPrint;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGVisit;
        private DevComponents.DotNetBar.ButtonX BtnCalculate;
        private System.Windows.Forms.Label LblPayV;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX BtnSearch;
        private Stimulsoft.Report.StiReport StiVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn datev;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namek;
        private System.Windows.Forms.DataGridViewTextBoxColumn namein;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricein;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn payv;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipe;

    }
}