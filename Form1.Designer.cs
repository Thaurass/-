namespace Теория_информации_метод_Хоффмана
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            Hmax = new Label();
            label3 = new Label();
            Hx = new Label();
            label5 = new Label();
            Lmid = new Label();
            label7 = new Label();
            label8 = new Label();
            pk = new Label();
            R = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            EncodedMessage = new TextBox();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            DecodedMessage = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultGrid).BeginInit();
            SuspendLayout();
            // 
            // resultGrid
            // 
            resultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5 });
            resultGrid.Location = new Point(11, 11);
            resultGrid.Margin = new Padding(2);
            resultGrid.Name = "resultGrid";
            resultGrid.RowHeadersWidth = 72;
            resultGrid.RowTemplate.Height = 37;
            resultGrid.Size = new Size(678, 500);
            resultGrid.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Буква xi";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // Column3
            // 
            Column3.HeaderText = "Вероятность Pi";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 175;
            // 
            // Column2
            // 
            Column2.HeaderText = "Код wi";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column4
            // 
            Column4.HeaderText = "Длина кода li";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 175;
            // 
            // Column5
            // 
            Column5.HeaderText = "li*Pi";
            Column5.MinimumWidth = 9;
            Column5.Name = "Column5";
            Column5.Width = 175;
            // 
            // button1
            // 
            button1.Location = new Point(693, 55);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(263, 25);
            button1.TabIndex = 1;
            button1.Text = "Составить таблицу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Fill_table;
            // 
            // button2
            // 
            button2.Location = new Point(693, 84);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(263, 25);
            button2.TabIndex = 2;
            button2.Text = "Характеристики";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Specifications;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(766, 123);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "H(max) = ";
            // 
            // Hmax
            // 
            Hmax.AutoSize = true;
            Hmax.Location = new Point(829, 123);
            Hmax.Margin = new Padding(2, 0, 2, 0);
            Hmax.Name = "Hmax";
            Hmax.Size = new Size(52, 15);
            Hmax.TabIndex = 4;
            Hmax.Text = "_________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(783, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "H(x) = ";
            // 
            // Hx
            // 
            Hx.AutoSize = true;
            Hx.Location = new Point(829, 152);
            Hx.Margin = new Padding(2, 0, 2, 0);
            Hx.Name = "Hx";
            Hx.Size = new Size(52, 15);
            Hx.TabIndex = 6;
            Hx.Text = "_________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(786, 180);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 7;
            label5.Text = "Lср = ";
            // 
            // Lmid
            // 
            Lmid.AutoSize = true;
            Lmid.Location = new Point(829, 180);
            Lmid.Margin = new Padding(2, 0, 2, 0);
            Lmid.Name = "Lmid";
            Lmid.Size = new Size(52, 15);
            Lmid.TabIndex = 8;
            Lmid.Text = "_________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(792, 210);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 9;
            label7.Text = "pk = ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(797, 245);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 10;
            label8.Text = "R = ";
            // 
            // pk
            // 
            pk.AutoSize = true;
            pk.Location = new Point(829, 210);
            pk.Margin = new Padding(2, 0, 2, 0);
            pk.Name = "pk";
            pk.Size = new Size(52, 15);
            pk.TabIndex = 11;
            pk.Text = "_________";
            // 
            // R
            // 
            R.AutoSize = true;
            R.Location = new Point(829, 245);
            R.Margin = new Padding(2, 0, 2, 0);
            R.Name = "R";
            R.Size = new Size(52, 15);
            R.TabIndex = 12;
            R.Text = "_________";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(693, 28);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(743, 413);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 14;
            label2.Text = "Закодированное сообщение";
            // 
            // EncodedMessage
            // 
            EncodedMessage.Location = new Point(693, 430);
            EncodedMessage.Margin = new Padding(2);
            EncodedMessage.Name = "EncodedMessage";
            EncodedMessage.Size = new Size(263, 23);
            EncodedMessage.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(764, 11);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 16;
            label4.Text = "Исходное сообщение";
            // 
            // button3
            // 
            button3.Location = new Point(693, 486);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(263, 25);
            button3.TabIndex = 17;
            button3.Text = "Закодировать Сообщение";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Encrypt_the_message;
            // 
            // button4
            // 
            button4.Location = new Point(693, 457);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(263, 25);
            button4.TabIndex = 20;
            button4.Text = "Декодировать Сообщение";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Decode_the_message;
            // 
            // DecodedMessage
            // 
            DecodedMessage.Location = new Point(693, 388);
            DecodedMessage.Margin = new Padding(2);
            DecodedMessage.Name = "DecodedMessage";
            DecodedMessage.Size = new Size(263, 23);
            DecodedMessage.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(743, 371);
            label6.Name = "label6";
            label6.Size = new Size(167, 15);
            label6.TabIndex = 18;
            label6.Text = "Декодированное сообщение";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 522);
            Controls.Add(button4);
            Controls.Add(DecodedMessage);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(EncodedMessage);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(R);
            Controls.Add(pk);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Lmid);
            Controls.Add(label5);
            Controls.Add(Hx);
            Controls.Add(label3);
            Controls.Add(Hmax);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultGrid);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resultGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label Hmax;
        private Label label3;
        private Label Hx;
        private Label label5;
        private Label Lmid;
        private Label label7;
        private Label label8;
        private Label pk;
        private Label R;
        private TextBox textBox1;
        private Label label2;
        private TextBox EncodedMessage;
        private Label label4;
        private Button button3;
        private Button button4;
        private TextBox DecodedMessage;
        private Label label6;
    }
}