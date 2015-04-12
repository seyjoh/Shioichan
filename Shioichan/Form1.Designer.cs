namespace Shioichan
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpFileSelect = new System.Windows.Forms.GroupBox();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpTrimming = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSizeWidth = new System.Windows.Forms.TextBox();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.txtLocationX = new System.Windows.Forms.TextBox();
            this.txtSizeHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaddingY = new System.Windows.Forms.TextBox();
            this.txtPaddingX = new System.Windows.Forms.TextBox();
            this.txtRowNum = new System.Windows.Forms.TextBox();
            this.grpPadding = new System.Windows.Forms.GroupBox();
            this.grpRowNum = new System.Windows.Forms.GroupBox();
            this.btnProcessing = new System.Windows.Forms.Button();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.lblImageSizeXY = new System.Windows.Forms.Label();
            this.grpFileSelect.SuspendLayout();
            this.grpTrimming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.grpPadding.SuspendLayout();
            this.grpRowNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(6, 42);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 1;
            this.btnAddImage.Text = "画像を追加";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.SystemColors.Menu;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 12;
            this.lstFiles.Location = new System.Drawing.Point(87, 18);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(507, 76);
            this.lstFiles.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpFileSelect
            // 
            this.grpFileSelect.Controls.Add(this.lblFileCount);
            this.grpFileSelect.Controls.Add(this.btnAddImage);
            this.grpFileSelect.Controls.Add(this.lstFiles);
            this.grpFileSelect.Controls.Add(this.btnClear);
            this.grpFileSelect.Location = new System.Drawing.Point(12, 12);
            this.grpFileSelect.Name = "grpFileSelect";
            this.grpFileSelect.Size = new System.Drawing.Size(600, 100);
            this.grpFileSelect.TabIndex = 0;
            this.grpFileSelect.TabStop = false;
            this.grpFileSelect.Text = "画像選択(pngのみ)";
            // 
            // lblFileCount
            // 
            this.lblFileCount.Location = new System.Drawing.Point(6, 18);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(75, 23);
            this.lblFileCount.TabIndex = 4;
            this.lblFileCount.Text = "0 Files";
            this.lblFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(10, 191);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(602, 23);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "lblMessage";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpTrimming
            // 
            this.grpTrimming.Controls.Add(this.label5);
            this.grpTrimming.Controls.Add(this.label4);
            this.grpTrimming.Controls.Add(this.txtSizeWidth);
            this.grpTrimming.Controls.Add(this.txtLocationY);
            this.grpTrimming.Controls.Add(this.txtLocationX);
            this.grpTrimming.Controls.Add(this.txtSizeHeight);
            this.grpTrimming.Controls.Add(this.label3);
            this.grpTrimming.Controls.Add(this.label2);
            this.grpTrimming.Location = new System.Drawing.Point(12, 118);
            this.grpTrimming.Name = "grpTrimming";
            this.grpTrimming.Size = new System.Drawing.Size(202, 70);
            this.grpTrimming.TabIndex = 4;
            this.grpTrimming.TabStop = false;
            this.grpTrimming.Text = "切り取り範囲";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Width";
            // 
            // txtSizeWidth
            // 
            this.txtSizeWidth.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSizeWidth.Location = new System.Drawing.Point(134, 16);
            this.txtSizeWidth.MaxLength = 3;
            this.txtSizeWidth.Name = "txtSizeWidth";
            this.txtSizeWidth.Size = new System.Drawing.Size(60, 19);
            this.txtSizeWidth.TabIndex = 7;
            this.txtSizeWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtSizeWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txtLocationY
            // 
            this.txtLocationY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtLocationY.Location = new System.Drawing.Point(24, 41);
            this.txtLocationY.MaxLength = 3;
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Size = new System.Drawing.Size(60, 19);
            this.txtLocationY.TabIndex = 6;
            this.txtLocationY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtLocationY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txtLocationX
            // 
            this.txtLocationX.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtLocationX.Location = new System.Drawing.Point(24, 16);
            this.txtLocationX.MaxLength = 3;
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.Size = new System.Drawing.Size(60, 19);
            this.txtLocationX.TabIndex = 5;
            this.txtLocationX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtLocationX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txtSizeHeight
            // 
            this.txtSizeHeight.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSizeHeight.Location = new System.Drawing.Point(134, 41);
            this.txtSizeHeight.MaxLength = 3;
            this.txtSizeHeight.Name = "txtSizeHeight";
            this.txtSizeHeight.Size = new System.Drawing.Size(60, 19);
            this.txtSizeHeight.TabIndex = 8;
            this.txtSizeHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtSizeHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Color";
            // 
            // picColor
            // 
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picColor.Location = new System.Drawing.Point(128, 16);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(60, 19);
            this.picColor.TabIndex = 15;
            this.picColor.TabStop = false;
            this.picColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "X";
            // 
            // txtPaddingY
            // 
            this.txtPaddingY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPaddingY.Location = new System.Drawing.Point(24, 41);
            this.txtPaddingY.MaxLength = 2;
            this.txtPaddingY.Name = "txtPaddingY";
            this.txtPaddingY.Size = new System.Drawing.Size(60, 19);
            this.txtPaddingY.TabIndex = 13;
            this.txtPaddingY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtPaddingY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txtPaddingX
            // 
            this.txtPaddingX.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPaddingX.Location = new System.Drawing.Point(24, 16);
            this.txtPaddingX.MaxLength = 2;
            this.txtPaddingX.Name = "txtPaddingX";
            this.txtPaddingX.Size = new System.Drawing.Size(60, 19);
            this.txtPaddingX.TabIndex = 12;
            this.txtPaddingX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtPaddingX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // txtRowNum
            // 
            this.txtRowNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtRowNum.Location = new System.Drawing.Point(18, 16);
            this.txtRowNum.MaxLength = 2;
            this.txtRowNum.Name = "txtRowNum";
            this.txtRowNum.Size = new System.Drawing.Size(60, 19);
            this.txtRowNum.TabIndex = 10;
            this.txtRowNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtRowNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // grpPadding
            // 
            this.grpPadding.Controls.Add(this.label10);
            this.grpPadding.Controls.Add(this.picColor);
            this.grpPadding.Controls.Add(this.label9);
            this.grpPadding.Controls.Add(this.txtPaddingX);
            this.grpPadding.Controls.Add(this.label8);
            this.grpPadding.Controls.Add(this.txtPaddingY);
            this.grpPadding.Location = new System.Drawing.Point(310, 118);
            this.grpPadding.Name = "grpPadding";
            this.grpPadding.Size = new System.Drawing.Size(195, 70);
            this.grpPadding.TabIndex = 11;
            this.grpPadding.TabStop = false;
            this.grpPadding.Text = "余白設定";
            // 
            // grpRowNum
            // 
            this.grpRowNum.Controls.Add(this.txtRowNum);
            this.grpRowNum.Location = new System.Drawing.Point(220, 118);
            this.grpRowNum.Name = "grpRowNum";
            this.grpRowNum.Size = new System.Drawing.Size(84, 70);
            this.grpRowNum.TabIndex = 9;
            this.grpRowNum.TabStop = false;
            this.grpRowNum.Text = "1行の配置数";
            // 
            // btnProcessing
            // 
            this.btnProcessing.Location = new System.Drawing.Point(512, 164);
            this.btnProcessing.Name = "btnProcessing";
            this.btnProcessing.Size = new System.Drawing.Size(100, 23);
            this.btnProcessing.TabIndex = 15;
            this.btnProcessing.Text = "画像出力";
            this.btnProcessing.UseVisualStyleBackColor = true;
            this.btnProcessing.Click += new System.EventHandler(this.btnProcessing_Click);
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(512, 118);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(58, 12);
            this.lblImageSize.TabIndex = 12;
            this.lblImageSize.Text = "画像サイズ";
            this.lblImageSize.Visible = false;
            // 
            // lblImageSizeXY
            // 
            this.lblImageSizeXY.AutoSize = true;
            this.lblImageSizeXY.Location = new System.Drawing.Point(514, 136);
            this.lblImageSizeXY.Name = "lblImageSizeXY";
            this.lblImageSizeXY.Size = new System.Drawing.Size(55, 12);
            this.lblImageSizeXY.TabIndex = 13;
            this.lblImageSizeXY.Text = "000 * 000";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 222);
            this.Controls.Add(this.lblImageSizeXY);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.btnProcessing);
            this.Controls.Add(this.grpRowNum);
            this.Controls.Add(this.grpPadding);
            this.Controls.Add(this.grpTrimming);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpFileSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "画像を切って並べるやつ";
            this.grpFileSelect.ResumeLayout(false);
            this.grpTrimming.ResumeLayout(false);
            this.grpTrimming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.grpPadding.ResumeLayout(false);
            this.grpPadding.PerformLayout();
            this.grpRowNum.ResumeLayout(false);
            this.grpRowNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFileSelect;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpTrimming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSizeWidth;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.TextBox txtLocationX;
        private System.Windows.Forms.TextBox txtSizeHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaddingY;
        private System.Windows.Forms.TextBox txtPaddingX;
        private System.Windows.Forms.TextBox txtRowNum;
        private System.Windows.Forms.GroupBox grpPadding;
        private System.Windows.Forms.GroupBox grpRowNum;
        private System.Windows.Forms.Button btnProcessing;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label lblImageSizeXY;
    }
}

