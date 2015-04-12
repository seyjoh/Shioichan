using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Shioichan
{
    public partial class frmMain : Form
    {
        private string strDialogDirPath;

        private bool flagCheckTextbox;
        private bool flagCheckFilelist;

        private int readFileWidth;
        private int readFileHeight;

        public frmMain()
        {
            InitializeComponent();
            strDialogDirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            initConfig();

            readFileWidth = -1;
            readFileHeight = -1;
            lblImageSize.Visible = false;
            lblImageSizeXY.Text = String.Empty;
            
            flagCheckFilelist = false;
            btnProcessing.Enabled = false;

            checkStatus_textbox();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "画像ファイルを選択";
            ofd.Filter = "PNG (*.png)|*.png";
            ofd.FilterIndex = 1;
            ofd.Multiselect = true;
            ofd.InitialDirectory = strDialogDirPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string strFilePath in ofd.FileNames)
                {
                    lstFiles.Items.Add(strFilePath);
                }
                strDialogDirPath = Path.GetDirectoryName(ofd.FileName);
                lblFileCount.Text = lstFiles.Items.Count.ToString() + " Files";
            }

            if (checkStatus_Filelist())
            {
                btnProcessing.Enabled = true;
            }
            else
            {
                btnProcessing.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            lblFileCount.Text = lstFiles.Items.Count.ToString() + " Files";
            flagCheckFilelist = false;
            btnProcessing.Enabled = false;

            readFileWidth = -1;
            readFileHeight = -1;
            lblImageSize.Visible = false;
            lblImageSizeXY.Text = String.Empty;
            checkStatus_textbox();

        }

        private void picColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = picColor.BackColor;
            cd.FullOpen = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                picColor.BackColor = cd.Color;
            }
        }

        private void textBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (checkStatus_textbox()) 
            {
                btnProcessing.Enabled = true;
            }
            else 
            {
                btnProcessing.Enabled = false;
            }
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            if (checkStatus_Filelist() && checkStatus_textbox())
            {
                createImageFIle();
            }
        }

        private bool checkStatus_Filelist()
        {
            bool Result = true;
            flagCheckFilelist = false;
            lblMessage.Text = String.Empty;

            try
            {
                if (lstFiles.Items.Count == 0)
                {
                    //lblMessage.Text = "ファイルが選択されていません。";
                    readFileWidth = -1;
                    readFileHeight = -1;
                    lblImageSize.Visible = false;
                    lblImageSizeXY.Text = String.Empty;
                    Result = false;
                }
                else
                {
                    FileStream fs;
                    foreach (String strFilePath in lstFiles.Items)
                    {
                        fs = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
                        int CurrentImageWidth = Image.FromStream(fs).Width;
                        int CurrentImageHeight = Image.FromStream(fs).Height;
                        fs.Close();

                        if (readFileWidth == -1 || readFileHeight == -1)
                        {
                            readFileWidth = CurrentImageWidth;
                            readFileHeight = CurrentImageHeight;
                        }
                        else if (readFileWidth != CurrentImageWidth && readFileHeight != CurrentImageHeight)
                        {
                            lblMessage.Text = "ピクセルサイズの異なる画像が追加されています。";
                            lblImageSize.Visible = false;
                            lblImageSizeXY.Text = String.Empty;
                            return false;
                        }
                    }

                    if (txtLocationX.Text == String.Empty
                        || txtLocationY.Text == String.Empty
                        || txtSizeWidth.Text == String.Empty
                        || txtSizeHeight.Text == String.Empty
                        || txtRowNum.Text == String.Empty
                        || txtPaddingX.Text == String.Empty
                        || txtPaddingY.Text == String.Empty
                        )
                    {
                        Result = false;
                    }
                    else if (int.Parse(txtLocationX.Text) + int.Parse(txtSizeWidth.Text) > readFileWidth
                        || int.Parse(txtLocationY.Text) + int.Parse(txtSizeHeight.Text) > readFileHeight
                        )
                    {
                        lblMessage.Text = "切り取り範囲は画像のピクセルサイズよりも小さくしてください。";
                        return Result;
                    }

                    lblImageSize.Visible = true;
                    lblImageSizeXY.Text = readFileWidth + " * " + readFileHeight;
                    flagCheckFilelist = true;
                }

                if (!flagCheckTextbox || !flagCheckFilelist)
                {
                    Result = false;
                }
            }
            catch(Exception e)
            {
                Result = false;
                lblMessage.Text = e.Message;
            }

            return Result;
        }

        private bool checkStatus_textbox()
        {
            bool Result = false;
            flagCheckTextbox = false;
            lblMessage.Text = String.Empty;

            if (txtLocationX.Text == String.Empty
                || txtLocationY.Text == String.Empty
                || txtSizeWidth.Text == String.Empty
                || txtSizeHeight.Text == String.Empty
                || txtRowNum.Text == String.Empty
                || txtPaddingX.Text == String.Empty
                || txtPaddingY.Text == String.Empty
                )
            {
                lblMessage.Text = "未入力項目があります。";
                return Result;
            }

            if (txtSizeWidth.Text == "0")
            {
                lblMessage.Text = "切り取りサイズ(Width)は最低1以上必要です。";
                return Result;
            }
            if (txtSizeHeight.Text == "0")
            {
                lblMessage.Text = "切り取りサイズ(Height)は最低1以上必要です。";
                return Result;
            }
            if (txtRowNum.Text == "0")
            {
                lblMessage.Text = "1行あたりの配置数は最低1以上必要です。";
                return Result;
            }

            if (readFileWidth == -1 || readFileHeight == -1) 
            {
            }
            else if (int.Parse(txtLocationX.Text) + int.Parse(txtSizeWidth.Text) > readFileWidth
                || int.Parse(txtLocationY.Text) + int.Parse(txtSizeHeight.Text) > readFileHeight
                )
            {
                lblMessage.Text = "切り取り範囲は画像のピクセルサイズよりも小さくしてください。";
                return Result;
            }

            flagCheckTextbox = true;
            if (flagCheckFilelist)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }
            return Result;
        }

        private void initConfig()
        {
            txtLocationX.Text = Properties.Settings.Default.LocationX.ToString();
            txtLocationY.Text = Properties.Settings.Default.LocationY.ToString();
            txtSizeWidth.Text = Properties.Settings.Default.SizeWidth.ToString();
            txtSizeHeight.Text = Properties.Settings.Default.SizeHeight.ToString();
            txtRowNum.Text = Properties.Settings.Default.ImageRowNum.ToString();
            txtPaddingX.Text = Properties.Settings.Default.PaddingX.ToString();
            txtPaddingY.Text = Properties.Settings.Default.PaddingY.ToString();
            picColor.BackColor = Properties.Settings.Default.PaddingColor;

        }

        private void createImageFIle() 
        {
            try
            {
                int ImageWidth;
                int ImageHeight;
                int SizeWidth = int.Parse(txtSizeWidth.Text);
                int SizeHeight = int.Parse(txtSizeHeight.Text);
                int PaddingX = int.Parse(txtPaddingX.Text);
                int PaddingY = int.Parse(txtPaddingY.Text);
                
                int createRowNum = int.Parse(txtRowNum.Text);

                if (lstFiles.Items.Count < createRowNum)
                {
                    createRowNum = lstFiles.Items.Count;
                }
                int createColNum = lstFiles.Items.Count / createRowNum + (lstFiles.Items.Count % createRowNum == 0 ? 0 : 1);

                ImageWidth = (SizeWidth + PaddingX) * createRowNum + PaddingX;
                ImageHeight = (SizeHeight + PaddingY) * createColNum + PaddingY;


                Bitmap canvas = new Bitmap(ImageWidth, ImageHeight);
                Graphics gImage = Graphics.FromImage(canvas);
                SolidBrush b = new SolidBrush(picColor.BackColor);
                gImage.FillRectangle(b , 0, 0, ImageWidth , ImageHeight );
                b.Dispose();

                int i = 0;
                int Row;
                int Col;
                int XPixel;
                int YPixel;
                foreach (String strFilePath in lstFiles.Items)
                {
                    Row = i / createRowNum;
                    Col = i % createRowNum;
                    XPixel = (SizeWidth + PaddingX) * Col + PaddingX;
                    YPixel = (SizeHeight + PaddingY) * Row + PaddingY;

                    Image img = Image.FromFile(strFilePath);
                    Rectangle srcRect = new Rectangle(int.Parse(txtLocationX.Text), int.Parse(txtLocationY.Text), SizeWidth, SizeHeight);
                    gImage.DrawImage(img, XPixel, YPixel, srcRect, GraphicsUnit.Pixel);
                    img.Dispose();
                    i++;
                }

                while (i % createRowNum != 0)
                {
                    Row = i / createRowNum;
                    Col = i % createRowNum;
                    XPixel = (SizeWidth + PaddingX) * Col + PaddingX;
                    YPixel = (SizeHeight + PaddingY) * Row + PaddingY;
                    gImage.FillRectangle(Brushes.White, XPixel, YPixel, SizeWidth, SizeHeight);
                    i++;
                }
                gImage.Dispose();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "名前をつけて保存";
                sfd.FileName = "無題.png";
                sfd.InitialDirectory = strDialogDirPath;
                sfd.Filter = "PNG (*.png)|*.png";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    Console.WriteLine(sfd.FileName);
                }
                canvas.Dispose();

            }
            catch(Exception e)
            {
                lblMessage.Text = e.Message;
            }

        }

    }
}
