namespace Gif2Sheet
{
    partial class frmProcessImage
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
            this.preferencesEditor = new System.Windows.Forms.PropertyGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.srcImagePanel = new System.Windows.Forms.Panel();
            this.sourceImage = new Gif2Sheet.ZoomingPicture();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.destImagePanel = new System.Windows.Forms.Panel();
            this.destImage = new Gif2Sheet.ZoomingPicture();
            this.tmrFrameChange = new System.Windows.Forms.Timer(this.components);
            this.srcImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            this.destImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destImage)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesEditor
            // 
            this.preferencesEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.preferencesEditor.Location = new System.Drawing.Point(482, 0);
            this.preferencesEditor.Name = "preferencesEditor";
            this.preferencesEditor.Size = new System.Drawing.Size(293, 429);
            this.preferencesEditor.TabIndex = 0;
            this.preferencesEditor.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.preferencesEditor_PropertyValueChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(479, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 429);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 216);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(479, 3);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // srcImagePanel
            // 
            this.srcImagePanel.AutoScroll = true;
            this.srcImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcImagePanel.Controls.Add(this.sourceImage);
            this.srcImagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.srcImagePanel.Location = new System.Drawing.Point(0, 0);
            this.srcImagePanel.Name = "srcImagePanel";
            this.srcImagePanel.Size = new System.Drawing.Size(479, 216);
            this.srcImagePanel.TabIndex = 5;
            // 
            // sourceImage
            // 
            this.sourceImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.sourceImage.Location = new System.Drawing.Point(0, 0);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(10, 10);
            this.sourceImage.TabIndex = 2;
            this.sourceImage.TabStop = false;
            this.sourceImage.ZoomFactor = 1F;
            this.sourceImage.MouseLeave += new System.EventHandler(this.sourceImage_MouseLeave);
            this.sourceImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sourceImage_MouseMove);
            this.sourceImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sourceImage_MouseUp);
            // 
            // pnlColor
            // 
            this.pnlColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColor.BackColor = System.Drawing.Color.Black;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(447, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(32, 32);
            this.pnlColor.TabIndex = 3;
            this.pnlColor.Visible = false;
            // 
            // destImagePanel
            // 
            this.destImagePanel.AutoScroll = true;
            this.destImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destImagePanel.Controls.Add(this.destImage);
            this.destImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destImagePanel.Location = new System.Drawing.Point(0, 219);
            this.destImagePanel.Name = "destImagePanel";
            this.destImagePanel.Size = new System.Drawing.Size(479, 210);
            this.destImagePanel.TabIndex = 6;
            // 
            // destImage
            // 
            this.destImage.Location = new System.Drawing.Point(0, 0);
            this.destImage.Name = "destImage";
            this.destImage.Size = new System.Drawing.Size(10, 10);
            this.destImage.TabIndex = 4;
            this.destImage.TabStop = false;
            this.destImage.ZoomFactor = 1F;
            // 
            // tmrFrameChange
            // 
            this.tmrFrameChange.Interval = 40;
            this.tmrFrameChange.Tick += new System.EventHandler(this.tmrFrameChange_Tick);
            // 
            // frmProcessImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 429);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.destImagePanel);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.srcImagePanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.preferencesEditor);
            this.Name = "frmProcessImage";
            this.Text = "Procesamiento de Imagen";
            this.srcImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            this.destImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid preferencesEditor;
        private System.Windows.Forms.Splitter splitter1;
        private ZoomingPicture sourceImage;
        private System.Windows.Forms.Splitter splitter2;
        private ZoomingPicture destImage;
        private System.Windows.Forms.Panel srcImagePanel;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Panel destImagePanel;
        private System.Windows.Forms.Timer tmrFrameChange;
    }
}