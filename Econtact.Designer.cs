namespace DApp1
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ContactID = new Label();
            ContactNo = new Label();
            textBox2 = new TextBox();
            LastName = new Label();
            textBox3 = new TextBox();
            FirstName = new Label();
            textBox4 = new TextBox();
            Address = new Label();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            Gender = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            textBox6 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, -163);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(990, 535);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(144, 138);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(207, 30);
            textBox1.TabIndex = 1;
            textBox1.Tag = "contactIdBox";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ContactID
            // 
            ContactID.AutoSize = true;
            ContactID.BackColor = Color.Transparent;
            ContactID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactID.Location = new Point(25, 142);
            ContactID.Margin = new Padding(4, 0, 4, 0);
            ContactID.Name = "ContactID";
            ContactID.Size = new Size(104, 25);
            ContactID.TabIndex = 2;
            ContactID.Tag = "contactId";
            ContactID.Text = "Contact ID";
            ContactID.Click += label1_Click;
            // 
            // ContactNo
            // 
            ContactNo.AutoSize = true;
            ContactNo.BackColor = Color.Transparent;
            ContactNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactNo.Location = new Point(17, 281);
            ContactNo.Margin = new Padding(4, 0, 4, 0);
            ContactNo.Name = "ContactNo";
            ContactNo.Size = new Size(115, 25);
            ContactNo.TabIndex = 4;
            ContactNo.Tag = "contactNo";
            ContactNo.Text = " Contact No";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 255);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(144, 274);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 30);
            textBox2.TabIndex = 3;
            textBox2.Tag = "contactNoBox";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.Location = new Point(25, 226);
            LastName.Margin = new Padding(4, 0, 4, 0);
            LastName.Name = "LastName";
            LastName.Size = new Size(106, 25);
            LastName.TabIndex = 6;
            LastName.Tag = "lastName";
            LastName.Text = "Last Name";
            LastName.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 192, 128);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(144, 223);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 30);
            textBox3.TabIndex = 5;
            textBox3.Tag = "lastNameBox";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.Location = new Point(25, 182);
            FirstName.Margin = new Padding(4, 0, 4, 0);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(106, 25);
            FirstName.TabIndex = 8;
            FirstName.Tag = "firstName";
            FirstName.Text = "First Name";
            FirstName.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 192, 255);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(144, 178);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 30);
            textBox4.TabIndex = 7;
            textBox4.Tag = "firstNameBox";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Address.Location = new Point(25, 326);
            Address.Margin = new Padding(4, 0, 4, 0);
            Address.Name = "Address";
            Address.Size = new Size(85, 25);
            Address.TabIndex = 10;
            Address.Tag = "address";
            Address.Text = "Address";
            Address.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(255, 255, 128);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(144, 319);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(207, 86);
            textBox5.TabIndex = 9;
            textBox5.Tag = "addressBox";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 128, 255);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(144, 438);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Tag = "genderBox";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.BackColor = Color.Transparent;
            Gender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Gender.Location = new Point(25, 442);
            Gender.Margin = new Padding(4, 0, 4, 0);
            Gender.Name = "Gender";
            Gender.Size = new Size(77, 25);
            Gender.TabIndex = 12;
            Gender.Tag = "gender";
            Gender.Text = "Gender";
            Gender.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(378, 492);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 13;
            button1.Tag = "addButton";
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.MistyRose;
            button2.Location = new Point(773, 492);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(104, 45);
            button2.TabIndex = 14;
            button2.Tag = "clearButton";
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(644, 492);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(96, 45);
            button3.TabIndex = 15;
            button3.Tag = "updateButton";
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(515, 492);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(101, 45);
            button4.TabIndex = 16;
            button4.Tag = "deleteButton";
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.GridColor = SystemColors.ControlDarkDark;
            dataGridView1.Location = new Point(377, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 239);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(377, 178);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 18;
            label7.Tag = "search";
            label7.Text = "Search";
            label7.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(255, 224, 192);
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(460, 173);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(368, 30);
            textBox6.TabIndex = 19;
            textBox6.Tag = "searchBox";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1310, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1422, 617);
            Controls.Add(pictureBox2);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Gender);
            Controls.Add(comboBox1);
            Controls.Add(Address);
            Controls.Add(textBox5);
            Controls.Add(FirstName);
            Controls.Add(textBox4);
            Controls.Add(LastName);
            Controls.Add(textBox3);
            Controls.Add(ContactNo);
            Controls.Add(textBox2);
            Controls.Add(ContactID);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Yellow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Econtact";
            Text = "Form1";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label ContactID;
        private Label ContactNo;
        private TextBox textBox2;
        private Label LastName;
        private TextBox textBox3;
        private Label FirstName;
        private TextBox textBox4;
        private Label Address;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Label Gender;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox textBox6;
        private PictureBox pictureBox2;
    }
}