
namespace Dudnik_2_v_10
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.strt_end = new System.Windows.Forms.Timer(this.components);
            this.convert_btn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tentotwo = new System.Windows.Forms.RadioButton();
            this.twototen = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 35);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dudnik_2_v_10.Properties.Resources.фыакрфварыварывар;
            this.pictureBox1.Location = new System.Drawing.Point(360, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(9, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(83, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Перевод чисел";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // strt_end
            // 
            this.strt_end.Interval = 1;
            this.strt_end.Tick += new System.EventHandler(this.strt_end_Tick);
            // 
            // convert_btn
            // 
            this.convert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.convert_btn.FlatAppearance.BorderSize = 0;
            this.convert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.convert_btn.ForeColor = System.Drawing.Color.White;
            this.convert_btn.Location = new System.Drawing.Point(12, 114);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(374, 60);
            this.convert_btn.TabIndex = 2;
            this.convert_btn.Text = "Конвертировать";
            this.convert_btn.UseVisualStyleBackColor = false;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(12, 50);
            this.textBox.MaxLength = 9;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(374, 35);
            this.textBox.TabIndex = 3;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tentotwo
            // 
            this.tentotwo.AutoSize = true;
            this.tentotwo.Checked = true;
            this.tentotwo.FlatAppearance.BorderSize = 0;
            this.tentotwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.tentotwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.tentotwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tentotwo.ForeColor = System.Drawing.Color.White;
            this.tentotwo.Location = new System.Drawing.Point(12, 91);
            this.tentotwo.Name = "tentotwo";
            this.tentotwo.Size = new System.Drawing.Size(54, 17);
            this.tentotwo.TabIndex = 4;
            this.tentotwo.TabStop = true;
            this.tentotwo.Text = "10 в 2";
            this.tentotwo.UseVisualStyleBackColor = true;
            // 
            // twototen
            // 
            this.twototen.AutoSize = true;
            this.twototen.FlatAppearance.BorderSize = 0;
            this.twototen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.twototen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.twototen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twototen.ForeColor = System.Drawing.Color.White;
            this.twototen.Location = new System.Drawing.Point(331, 91);
            this.twototen.Name = "twototen";
            this.twototen.Size = new System.Drawing.Size(54, 17);
            this.twototen.TabIndex = 5;
            this.twototen.Text = "2 в 10";
            this.twototen.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 195);
            this.textBox1.MaxLength = 32;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 18);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(15)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(395, 190);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.twototen);
            this.Controls.Add(this.tentotwo);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(395, 227);
            this.MinimumSize = new System.Drawing.Size(395, 190);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer strt_end;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton tentotwo;
        private System.Windows.Forms.RadioButton twototen;
        private System.Windows.Forms.TextBox textBox1;
    }
}

