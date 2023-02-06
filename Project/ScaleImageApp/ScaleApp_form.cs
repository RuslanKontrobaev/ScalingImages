using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_main : Form
    {
        public Bitmap Image;      // исходное изображение
        public Bitmap ScaleImage; // итоговое изображение

        public Form_main() => InitializeComponent();

        private void button_load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Открытие изображения";
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg; *.jpeg; *.png; *.bmp; *.gif; *.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image = new Bitmap(openFileDialog.FileName);
                        if (Image.Width <= 1 && Image.Height <= 1)
                        {
                            MessageBox.Show("Изображение должно быть больше 1x1!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (Image.Width > 720 && Image.Height > 480)
                        {
                            MessageBox.Show("Изображение должно быть не больше 720x480!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        pictureBox_original_image.Image = Image;
                        if (pictureBox_scale_image.Image != null)
                        {
                            pictureBox_scale_image.Image.Dispose();
                            pictureBox_scale_image.Image = null;
                        }
                        if (label_resolution_scale.Visible) label_resolution_scale.Visible = false;
                        label_resolution_original.Visible = true;
                        label_resolution_original.Text = "Разрешение: " + Image.Width + " x " + Image.Height;
                        button_scale.Enabled = true;
                        button_save_image.Enabled = false;
                        groupBox_settings.Enabled = true;
                    }
                    catch
                    {
                        DialogResult rezult = MessageBox.Show("Невозможно открыть выбранное изображение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_scale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_scale.Text, out int number))
            {
                MessageBox.Show("В поле 'Коэффициент масштабирования' должно быть число >= 1!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_scale.Focus();
                textBox_scale.Clear();
                return;
            }
            if (!(int.Parse(textBox_scale.Text) >= 1) || !(int.Parse(textBox_scale.Text) <= 50))
            {
                MessageBox.Show("В поле 'Коэффициент масштабирования' должно быть число >= 1 и <= 50!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_scale.Focus();
                textBox_scale.Clear();
                return;
            }
            if (!radioButton_bilinear.Checked && !radioButton_bicubic.Checked)
            {
                MessageBox.Show("Не выбран алгоритм интерполяции!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int k = int.Parse(textBox_scale.Text); // коэффициент масштабирования
            if (k == 1)
            {
                ScaleImage = new Bitmap(Image.Width * k, Image.Height * k);
                ScaleImage = Image;
                pictureBox_scale_image.Image = Image;
                button_save_image.Enabled = true;
                label_resolution_scale.Visible = true;
                label_resolution_scale.Text = "Разрешение: " + ScaleImage.Width + " x " + ScaleImage.Height;
                return;
            }

            ScaleImage = new Bitmap(Image.Width * k, Image.Height * k);
            double[] X = new double[Image.Width];  // координаты X опорных точек в новом изображнии
            double[] Y = new double[Image.Height]; // координаты Y опорных точек в новом изображнии
            int D = 3;                             // размерность вектора    
            double[] F = new double[Image.Width * Image.Height * D]; // массив с цветами каждой точки исходного изображения  

            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++)
                {
                    X[i] = i * k + (k - 1.0) / 2.0;
                    Y[j] = j * k + (k - 1.0) / 2.0;
                    Color color = Image.GetPixel(i, j);
                    F[D * (Image.Width * j + i)] =     color.R;
                    F[D * (Image.Width * j + i) + 1] = color.G;
                    F[D * (Image.Width * j + i) + 2] = color.B;
                }

            alglib.spline2dinterpolant spline;
            if (radioButton_bilinear.Checked) alglib.spline2dbuildbilinearv(X, X.Length, Y, Y.Length, F, D, out spline);
            else                              alglib.spline2dbuildbicubicv (X, X.Length, Y, Y.Length, F, D, out spline);

            for (var i = 0; i < ScaleImage.Width; i++)
                for (var j = 0; j < ScaleImage.Height; j++)
                {
                    // массив с цветами точки итогового изображения, хранит только 3 составляющие (R,G,B) текущей рассчитанной точки
                    alglib.spline2dcalcv(spline, i, j, out double[] rgb);
                    for (int l = 0; l < rgb.Length; l++)
                    {
                        if (rgb[l] < 0) rgb[l] = 0; if (rgb[l] > 255) rgb[l] = 255;
                    }
                    ScaleImage.SetPixel(i, j, Color.FromArgb((int)rgb[0], (int)rgb[1], (int)rgb[2]));
                    pictureBox_scale_image.Image = ScaleImage;
                }
            button_save_image.Enabled = true;
            label_resolution_scale.Visible = true;
            label_resolution_scale.Text = "Разрешение: " + ScaleImage.Width + " x " + ScaleImage.Height;
        }

        private void button_save_image_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Сохранение изображения";
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = "Jpg Image|*.jpg|Jpeg Image|*.jpeg|BitmapImage|*.bmp|Gif Image|*.gif|Portable Network Graphics Image|*.png|Icon Image|*.ico";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Bmp;
                        string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                        switch (ext)
                        {
                            case ".jpg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".jpeg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                            case ".gif":
                                format = ImageFormat.Gif;
                                break;
                            case ".png":
                                format = ImageFormat.Png;
                                break;
                            case ".ico":
                                format = ImageFormat.Icon;
                                break;
                        }
                        ScaleImage.Save(saveFileDialog.FileName, format);
                        DialogResult rezult = MessageBox.Show("Изображение успешно сохранено!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        DialogResult rezult = MessageBox.Show("Невозможно сохранить изображение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
    }
}