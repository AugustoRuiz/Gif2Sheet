namespace Gif2Sheet
{
    partial class frmCambioTamaño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioTamaño));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.altoOriginal = new System.Windows.Forms.TextBox();
            this.anchoOriginal = new System.Windows.Forms.TextBox();
            this.nuevoAncho = new System.Windows.Forms.NumericUpDown();
            this.nuevoAlto = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdBottomRight = new System.Windows.Forms.RadioButton();
            this.cmdBottom = new System.Windows.Forms.RadioButton();
            this.cmdBottomLeft = new System.Windows.Forms.RadioButton();
            this.cmdRight = new System.Windows.Forms.RadioButton();
            this.cmdMiddle = new System.Windows.Forms.RadioButton();
            this.cmdLeft = new System.Windows.Forms.RadioButton();
            this.cmdTopRight = new System.Windows.Forms.RadioButton();
            this.cmdTop = new System.Windows.Forms.RadioButton();
            this.cmdTopLeft = new System.Windows.Forms.RadioButton();
            this.arrowsImgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nuevoAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoAlto)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamaño Original:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nuevo Tamaño:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ancho:";
            // 
            // altoOriginal
            // 
            this.altoOriginal.Location = new System.Drawing.Point(59, 62);
            this.altoOriginal.Name = "altoOriginal";
            this.altoOriginal.ReadOnly = true;
            this.altoOriginal.Size = new System.Drawing.Size(67, 20);
            this.altoOriginal.TabIndex = 3;
            // 
            // anchoOriginal
            // 
            this.anchoOriginal.Location = new System.Drawing.Point(59, 33);
            this.anchoOriginal.Name = "anchoOriginal";
            this.anchoOriginal.ReadOnly = true;
            this.anchoOriginal.Size = new System.Drawing.Size(67, 20);
            this.anchoOriginal.TabIndex = 2;
            // 
            // nuevoAncho
            // 
            this.nuevoAncho.Location = new System.Drawing.Point(59, 123);
            this.nuevoAncho.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuevoAncho.Name = "nuevoAncho";
            this.nuevoAncho.Size = new System.Drawing.Size(67, 20);
            this.nuevoAncho.TabIndex = 10;
            // 
            // nuevoAlto
            // 
            this.nuevoAlto.Location = new System.Drawing.Point(59, 152);
            this.nuevoAlto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuevoAlto.Name = "nuevoAlto";
            this.nuevoAlto.Size = new System.Drawing.Size(67, 20);
            this.nuevoAlto.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmdCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdOk, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 178);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 34);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancel.Location = new System.Drawing.Point(246, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdOk.Location = new System.Drawing.Point(57, 5);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Aceptar";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.cmdBottomRight, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmdBottom, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmdBottomLeft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmdRight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdMiddle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdLeft, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdTopRight, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdTop, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdTopLeft, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(290, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(100, 100);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // cmdBottomRight
            // 
            this.cmdBottomRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdBottomRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdBottomRight.Location = new System.Drawing.Point(69, 69);
            this.cmdBottomRight.Name = "cmdBottomRight";
            this.cmdBottomRight.Size = new System.Drawing.Size(27, 27);
            this.cmdBottomRight.TabIndex = 8;
            this.cmdBottomRight.UseVisualStyleBackColor = true;
            this.cmdBottomRight.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdBottom
            // 
            this.cmdBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdBottom.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdBottom.Location = new System.Drawing.Point(36, 69);
            this.cmdBottom.Name = "cmdBottom";
            this.cmdBottom.Size = new System.Drawing.Size(27, 27);
            this.cmdBottom.TabIndex = 7;
            this.cmdBottom.UseVisualStyleBackColor = true;
            this.cmdBottom.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdBottomLeft
            // 
            this.cmdBottomLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdBottomLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdBottomLeft.Location = new System.Drawing.Point(3, 69);
            this.cmdBottomLeft.Name = "cmdBottomLeft";
            this.cmdBottomLeft.Size = new System.Drawing.Size(27, 27);
            this.cmdBottomLeft.TabIndex = 6;
            this.cmdBottomLeft.UseVisualStyleBackColor = true;
            this.cmdBottomLeft.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdRight
            // 
            this.cmdRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdRight.Location = new System.Drawing.Point(69, 36);
            this.cmdRight.Name = "cmdRight";
            this.cmdRight.Size = new System.Drawing.Size(27, 27);
            this.cmdRight.TabIndex = 5;
            this.cmdRight.UseVisualStyleBackColor = true;
            this.cmdRight.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdMiddle
            // 
            this.cmdMiddle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdMiddle.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdMiddle.Location = new System.Drawing.Point(36, 36);
            this.cmdMiddle.Name = "cmdMiddle";
            this.cmdMiddle.Size = new System.Drawing.Size(27, 27);
            this.cmdMiddle.TabIndex = 4;
            this.cmdMiddle.UseVisualStyleBackColor = true;
            this.cmdMiddle.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdLeft
            // 
            this.cmdLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdLeft.Location = new System.Drawing.Point(3, 36);
            this.cmdLeft.Name = "cmdLeft";
            this.cmdLeft.Size = new System.Drawing.Size(27, 27);
            this.cmdLeft.TabIndex = 3;
            this.cmdLeft.UseVisualStyleBackColor = true;
            this.cmdLeft.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdTopRight
            // 
            this.cmdTopRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdTopRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdTopRight.Location = new System.Drawing.Point(69, 3);
            this.cmdTopRight.Name = "cmdTopRight";
            this.cmdTopRight.Size = new System.Drawing.Size(27, 27);
            this.cmdTopRight.TabIndex = 2;
            this.cmdTopRight.UseVisualStyleBackColor = true;
            this.cmdTopRight.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdTop
            // 
            this.cmdTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdTop.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdTop.Location = new System.Drawing.Point(36, 3);
            this.cmdTop.Name = "cmdTop";
            this.cmdTop.Size = new System.Drawing.Size(27, 27);
            this.cmdTop.TabIndex = 1;
            this.cmdTop.UseVisualStyleBackColor = true;
            this.cmdTop.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // cmdTopLeft
            // 
            this.cmdTopLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdTopLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.cmdTopLeft.Location = new System.Drawing.Point(3, 3);
            this.cmdTopLeft.Name = "cmdTopLeft";
            this.cmdTopLeft.Size = new System.Drawing.Size(27, 27);
            this.cmdTopLeft.TabIndex = 0;
            this.cmdTopLeft.UseVisualStyleBackColor = true;
            this.cmdTopLeft.CheckedChanged += new System.EventHandler(this.cmdGrowSize_CheckedChanged);
            // 
            // arrowsImgList
            // 
            this.arrowsImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("arrowsImgList.ImageStream")));
            this.arrowsImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.arrowsImgList.Images.SetKeyName(0, "ArrowUpRight");
            this.arrowsImgList.Images.SetKeyName(1, "ArrowDown");
            this.arrowsImgList.Images.SetKeyName(2, "ArrowDownLeft");
            this.arrowsImgList.Images.SetKeyName(3, "ArrowDownRight");
            this.arrowsImgList.Images.SetKeyName(4, "ArrowLeft");
            this.arrowsImgList.Images.SetKeyName(5, "ArrowRight");
            this.arrowsImgList.Images.SetKeyName(6, "ArrowUp");
            this.arrowsImgList.Images.SetKeyName(7, "ArrowUpLeft");
            this.arrowsImgList.Images.SetKeyName(8, "Image");
            // 
            // frmCambioTamaño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 220);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nuevoAlto);
            this.Controls.Add(this.nuevoAncho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.altoOriginal);
            this.Controls.Add(this.anchoOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCambioTamaño";
            this.Text = "Cambiar Tamaño de Frame";
            ((System.ComponentModel.ISupportInitialize)(this.nuevoAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoAlto)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox altoOriginal;
        private System.Windows.Forms.TextBox anchoOriginal;
        private System.Windows.Forms.NumericUpDown nuevoAncho;
        private System.Windows.Forms.NumericUpDown nuevoAlto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton cmdBottomRight;
        private System.Windows.Forms.RadioButton cmdBottom;
        private System.Windows.Forms.RadioButton cmdBottomLeft;
        private System.Windows.Forms.RadioButton cmdRight;
        private System.Windows.Forms.RadioButton cmdMiddle;
        private System.Windows.Forms.RadioButton cmdLeft;
        private System.Windows.Forms.RadioButton cmdTopRight;
        private System.Windows.Forms.RadioButton cmdTop;
        private System.Windows.Forms.RadioButton cmdTopLeft;
        private System.Windows.Forms.ImageList arrowsImgList;

    }
}