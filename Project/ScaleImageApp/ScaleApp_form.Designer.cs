
namespace WindowsFormsApp1
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.button_scale = new System.Windows.Forms.Button();
            this.label_scale = new System.Windows.Forms.Label();
            this.radioButton_bilinear = new System.Windows.Forms.RadioButton();
            this.groupBox_choice_of_algorithm = new System.Windows.Forms.GroupBox();
            this.radioButton_bicubic = new System.Windows.Forms.RadioButton();
            this.groupBox_actions = new System.Windows.Forms.GroupBox();
            this.button_save_image = new System.Windows.Forms.Button();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.pictureBox_original_image = new System.Windows.Forms.PictureBox();
            this.pictureBox_scale_image = new System.Windows.Forms.PictureBox();
            this.groupBox_original_image = new System.Windows.Forms.GroupBox();
            this.label_resolution_original = new System.Windows.Forms.Label();
            this.groupBox_scale_image = new System.Windows.Forms.GroupBox();
            this.label_resolution_scale = new System.Windows.Forms.Label();
            this.groupBox_choice_of_algorithm.SuspendLayout();
            this.groupBox_actions.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scale_image)).BeginInit();
            this.groupBox_original_image.SuspendLayout();
            this.groupBox_scale_image.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_load
            // 
            this.button_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_load.Location = new System.Drawing.Point(7, 22);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(129, 86);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Загрузить изображение";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox_scale
            // 
            this.textBox_scale.Location = new System.Drawing.Point(223, 40);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(205, 21);
            this.textBox_scale.TabIndex = 7;
            this.textBox_scale.Text = "1";
            // 
            // button_scale
            // 
            this.button_scale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_scale.Enabled = false;
            this.button_scale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_scale.Location = new System.Drawing.Point(143, 22);
            this.button_scale.Name = "button_scale";
            this.button_scale.Size = new System.Drawing.Size(129, 40);
            this.button_scale.TabIndex = 3;
            this.button_scale.Text = "Масштабировать изображение";
            this.button_scale.UseVisualStyleBackColor = true;
            this.button_scale.Click += new System.EventHandler(this.button_scale_Click);
            // 
            // label_scale
            // 
            this.label_scale.AutoSize = true;
            this.label_scale.Location = new System.Drawing.Point(223, 22);
            this.label_scale.Name = "label_scale";
            this.label_scale.Size = new System.Drawing.Size(246, 15);
            this.label_scale.TabIndex = 5;
            this.label_scale.Text = "Коэффициент масштабирования (>= 1 и <= 50):";
            // 
            // radioButton_bilinear
            // 
            this.radioButton_bilinear.AutoSize = true;
            this.radioButton_bilinear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_bilinear.Location = new System.Drawing.Point(7, 22);
            this.radioButton_bilinear.Name = "radioButton_bilinear";
            this.radioButton_bilinear.Size = new System.Drawing.Size(158, 19);
            this.radioButton_bilinear.TabIndex = 5;
            this.radioButton_bilinear.TabStop = true;
            this.radioButton_bilinear.Text = "Билинейная интерполяция";
            this.radioButton_bilinear.UseVisualStyleBackColor = true;
            // 
            // groupBox_choice_of_algorithm
            // 
            this.groupBox_choice_of_algorithm.Controls.Add(this.radioButton_bicubic);
            this.groupBox_choice_of_algorithm.Controls.Add(this.radioButton_bilinear);
            this.groupBox_choice_of_algorithm.Location = new System.Drawing.Point(7, 22);
            this.groupBox_choice_of_algorithm.Name = "groupBox_choice_of_algorithm";
            this.groupBox_choice_of_algorithm.Size = new System.Drawing.Size(209, 87);
            this.groupBox_choice_of_algorithm.TabIndex = 7;
            this.groupBox_choice_of_algorithm.TabStop = false;
            this.groupBox_choice_of_algorithm.Text = "Агоритм интерполяции";
            // 
            // radioButton_bicubic
            // 
            this.radioButton_bicubic.AutoSize = true;
            this.radioButton_bicubic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_bicubic.Location = new System.Drawing.Point(7, 48);
            this.radioButton_bicubic.Name = "radioButton_bicubic";
            this.radioButton_bicubic.Size = new System.Drawing.Size(170, 19);
            this.radioButton_bicubic.TabIndex = 6;
            this.radioButton_bicubic.TabStop = true;
            this.radioButton_bicubic.Text = "Бикубическая интерполяция";
            this.radioButton_bicubic.UseVisualStyleBackColor = true;
            // 
            // groupBox_actions
            // 
            this.groupBox_actions.Controls.Add(this.button_save_image);
            this.groupBox_actions.Controls.Add(this.button_load);
            this.groupBox_actions.Controls.Add(this.button_scale);
            this.groupBox_actions.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_actions.Location = new System.Drawing.Point(12, 380);
            this.groupBox_actions.Name = "groupBox_actions";
            this.groupBox_actions.Size = new System.Drawing.Size(284, 115);
            this.groupBox_actions.TabIndex = 8;
            this.groupBox_actions.TabStop = false;
            this.groupBox_actions.Text = "Действия";
            // 
            // button_save_image
            // 
            this.button_save_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save_image.Enabled = false;
            this.button_save_image.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_save_image.Location = new System.Drawing.Point(142, 68);
            this.button_save_image.Name = "button_save_image";
            this.button_save_image.Size = new System.Drawing.Size(129, 40);
            this.button_save_image.TabIndex = 2;
            this.button_save_image.Text = "Сохранить изображение";
            this.button_save_image.UseVisualStyleBackColor = true;
            this.button_save_image.Click += new System.EventHandler(this.button_save_image_Click);
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.groupBox_choice_of_algorithm);
            this.groupBox_settings.Controls.Add(this.label_scale);
            this.groupBox_settings.Controls.Add(this.textBox_scale);
            this.groupBox_settings.Enabled = false;
            this.groupBox_settings.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_settings.Location = new System.Drawing.Point(303, 380);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(470, 115);
            this.groupBox_settings.TabIndex = 9;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Настройка параметров";
            // 
            // pictureBox_original_image
            // 
            this.pictureBox_original_image.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox_original_image.Location = new System.Drawing.Point(6, 41);
            this.pictureBox_original_image.Name = "pictureBox_original_image";
            this.pictureBox_original_image.Size = new System.Drawing.Size(370, 315);
            this.pictureBox_original_image.TabIndex = 0;
            this.pictureBox_original_image.TabStop = false;
            // 
            // pictureBox_scale_image
            // 
            this.pictureBox_scale_image.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox_scale_image.Location = new System.Drawing.Point(6, 41);
            this.pictureBox_scale_image.Name = "pictureBox_scale_image";
            this.pictureBox_scale_image.Size = new System.Drawing.Size(359, 315);
            this.pictureBox_scale_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_scale_image.TabIndex = 0;
            this.pictureBox_scale_image.TabStop = false;
            // 
            // groupBox_original_image
            // 
            this.groupBox_original_image.Controls.Add(this.label_resolution_original);
            this.groupBox_original_image.Controls.Add(this.pictureBox_original_image);
            this.groupBox_original_image.Location = new System.Drawing.Point(19, 12);
            this.groupBox_original_image.Name = "groupBox_original_image";
            this.groupBox_original_image.Size = new System.Drawing.Size(376, 362);
            this.groupBox_original_image.TabIndex = 11;
            this.groupBox_original_image.TabStop = false;
            this.groupBox_original_image.Text = "Оригинальное изображение";
            // 
            // label_resolution_original
            // 
            this.label_resolution_original.AutoSize = true;
            this.label_resolution_original.Location = new System.Drawing.Point(7, 21);
            this.label_resolution_original.Name = "label_resolution_original";
            this.label_resolution_original.Size = new System.Drawing.Size(70, 15);
            this.label_resolution_original.TabIndex = 1;
            this.label_resolution_original.Text = "Разрешение:";
            this.label_resolution_original.Visible = false;
            // 
            // groupBox_scale_image
            // 
            this.groupBox_scale_image.Controls.Add(this.label_resolution_scale);
            this.groupBox_scale_image.Controls.Add(this.pictureBox_scale_image);
            this.groupBox_scale_image.Location = new System.Drawing.Point(402, 12);
            this.groupBox_scale_image.Name = "groupBox_scale_image";
            this.groupBox_scale_image.Size = new System.Drawing.Size(372, 362);
            this.groupBox_scale_image.TabIndex = 12;
            this.groupBox_scale_image.TabStop = false;
            this.groupBox_scale_image.Text = "Отмасштабированное изображение";
            // 
            // label_resolution_scale
            // 
            this.label_resolution_scale.AutoSize = true;
            this.label_resolution_scale.Location = new System.Drawing.Point(6, 21);
            this.label_resolution_scale.Name = "label_resolution_scale";
            this.label_resolution_scale.Size = new System.Drawing.Size(70, 15);
            this.label_resolution_scale.TabIndex = 2;
            this.label_resolution_scale.Text = "Разрешение:";
            this.label_resolution_scale.Visible = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 501);
            this.Controls.Add(this.groupBox_scale_image);
            this.Controls.Add(this.groupBox_original_image);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.groupBox_actions);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1. Масштабирование изображения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.groupBox_choice_of_algorithm.ResumeLayout(false);
            this.groupBox_choice_of_algorithm.PerformLayout();
            this.groupBox_actions.ResumeLayout(false);
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scale_image)).EndInit();
            this.groupBox_original_image.ResumeLayout(false);
            this.groupBox_original_image.PerformLayout();
            this.groupBox_scale_image.ResumeLayout(false);
            this.groupBox_scale_image.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TextBox textBox_scale;
        private System.Windows.Forms.Button button_scale;
        private System.Windows.Forms.Label label_scale;
        private System.Windows.Forms.RadioButton radioButton_bilinear;
        private System.Windows.Forms.GroupBox groupBox_choice_of_algorithm;
        private System.Windows.Forms.RadioButton radioButton_bicubic;
        private System.Windows.Forms.GroupBox groupBox_actions;
        private System.Windows.Forms.Button button_save_image;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.PictureBox pictureBox_original_image;
        private System.Windows.Forms.PictureBox pictureBox_scale_image;
        private System.Windows.Forms.GroupBox groupBox_original_image;
        private System.Windows.Forms.GroupBox groupBox_scale_image;
        private System.Windows.Forms.Label label_resolution_original;
        private System.Windows.Forms.Label label_resolution_scale;
    }
}

