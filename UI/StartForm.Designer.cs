
namespace AppWinFormCRUD.UI
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataDriverCarCrew = new System.Windows.Forms.DataGridView();
            this.tblPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonExpAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCarIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCarMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCrewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCrewTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPerson = new System.Windows.Forms.Label();
            this.txtDriverAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDriverExpAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarMileage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.txtCarIdNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCrew = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCrewDriver = new System.Windows.Forms.ComboBox();
            this.txtCrewCar = new System.Windows.Forms.ComboBox();
            this.txtCrewTransef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDriverCarCrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО :";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPersonName.Location = new System.Drawing.Point(299, 122);
            this.txtPersonName.MaxLength = 50;
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(276, 36);
            this.txtPersonName.TabIndex = 1;
            this.txtPersonName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDriverName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(60, 780);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 54);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataDriverCarCrew
            // 
            this.dataDriverCarCrew.AllowUserToDeleteRows = false;
            this.dataDriverCarCrew.BackgroundColor = System.Drawing.Color.White;
            this.dataDriverCarCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDriverCarCrew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblPersonId,
            this.tblPersonName,
            this.tblPersonAge,
            this.tblPersonExpAge,
            this.tblCarId,
            this.tblCarIdNumber,
            this.tblCarModel,
            this.tblCarMileage,
            this.tblCrewId,
            this.tblCrewTransfer});
            this.dataDriverCarCrew.Location = new System.Drawing.Point(637, 12);
            this.dataDriverCarCrew.Name = "dataDriverCarCrew";
            this.dataDriverCarCrew.ReadOnly = true;
            this.dataDriverCarCrew.RowHeadersWidth = 51;
            this.dataDriverCarCrew.RowTemplate.Height = 20;
            this.dataDriverCarCrew.Size = new System.Drawing.Size(510, 718);
            this.dataDriverCarCrew.TabIndex = 3;
            this.dataDriverCarCrew.DoubleClick += new System.EventHandler(this.dataDriverCarCrew_DoubleClick);
            // 
            // tblPersonId
            // 
            this.tblPersonId.DataPropertyName = "Id";
            this.tblPersonId.HeaderText = "id";
            this.tblPersonId.MinimumWidth = 6;
            this.tblPersonId.Name = "tblPersonId";
            this.tblPersonId.ReadOnly = true;
            this.tblPersonId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPersonId.Visible = false;
            this.tblPersonId.Width = 125;
            // 
            // tblPersonName
            // 
            this.tblPersonName.DataPropertyName = "Name";
            this.tblPersonName.HeaderText = "ФИО";
            this.tblPersonName.MinimumWidth = 6;
            this.tblPersonName.Name = "tblPersonName";
            this.tblPersonName.ReadOnly = true;
            this.tblPersonName.Width = 125;
            // 
            // tblPersonAge
            // 
            this.tblPersonAge.DataPropertyName = "Age";
            this.tblPersonAge.HeaderText = "Возраст";
            this.tblPersonAge.MinimumWidth = 6;
            this.tblPersonAge.Name = "tblPersonAge";
            this.tblPersonAge.ReadOnly = true;
            this.tblPersonAge.Width = 125;
            // 
            // tblPersonExpAge
            // 
            this.tblPersonExpAge.DataPropertyName = "ExperienceAge";
            this.tblPersonExpAge.HeaderText = "Стаж";
            this.tblPersonExpAge.MinimumWidth = 6;
            this.tblPersonExpAge.Name = "tblPersonExpAge";
            this.tblPersonExpAge.ReadOnly = true;
            this.tblPersonExpAge.Width = 125;
            // 
            // tblCarId
            // 
            this.tblCarId.DataPropertyName = "Id";
            this.tblCarId.HeaderText = "id";
            this.tblCarId.MinimumWidth = 6;
            this.tblCarId.Name = "tblCarId";
            this.tblCarId.ReadOnly = true;
            this.tblCarId.Visible = false;
            this.tblCarId.Width = 125;
            // 
            // tblCarIdNumber
            // 
            this.tblCarIdNumber.DataPropertyName = "IdNumber";
            this.tblCarIdNumber.HeaderText = "Госномер";
            this.tblCarIdNumber.MinimumWidth = 6;
            this.tblCarIdNumber.Name = "tblCarIdNumber";
            this.tblCarIdNumber.ReadOnly = true;
            this.tblCarIdNumber.Width = 125;
            // 
            // tblCarModel
            // 
            this.tblCarModel.DataPropertyName = "Model";
            this.tblCarModel.HeaderText = "Модель";
            this.tblCarModel.MinimumWidth = 6;
            this.tblCarModel.Name = "tblCarModel";
            this.tblCarModel.ReadOnly = true;
            this.tblCarModel.Width = 125;
            // 
            // tblCarMileage
            // 
            this.tblCarMileage.DataPropertyName = "Mileage";
            this.tblCarMileage.HeaderText = "Пробег";
            this.tblCarMileage.MinimumWidth = 6;
            this.tblCarMileage.Name = "tblCarMileage";
            this.tblCarMileage.ReadOnly = true;
            this.tblCarMileage.Width = 125;
            // 
            // tblCrewId
            // 
            this.tblCrewId.DataPropertyName = "Id";
            this.tblCrewId.HeaderText = "id";
            this.tblCrewId.MinimumWidth = 6;
            this.tblCrewId.Name = "tblCrewId";
            this.tblCrewId.ReadOnly = true;
            this.tblCrewId.Visible = false;
            this.tblCrewId.Width = 125;
            // 
            // tblCrewTransfer
            // 
            this.tblCrewTransfer.DataPropertyName = "Transfer";
            this.tblCrewTransfer.HeaderText = "Трансфер";
            this.tblCrewTransfer.MinimumWidth = 6;
            this.tblCrewTransfer.Name = "tblCrewTransfer";
            this.tblCrewTransfer.ReadOnly = true;
            this.tblCrewTransfer.Width = 125;
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPerson.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerson.Location = new System.Drawing.Point(146, 54);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(138, 40);
            this.labelPerson.TabIndex = 5;
            this.labelPerson.Text = "Водитель";
            this.labelPerson.Click += new System.EventHandler(this.labelPerson_Click);
            // 
            // txtDriverAge
            // 
            this.txtDriverAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDriverAge.Location = new System.Drawing.Point(299, 164);
            this.txtDriverAge.MaxLength = 2;
            this.txtDriverAge.Name = "txtDriverAge";
            this.txtDriverAge.Size = new System.Drawing.Size(276, 36);
            this.txtDriverAge.TabIndex = 7;
            this.txtDriverAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDriverAge_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(148, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Возраст :";
            // 
            // txtDriverExpAge
            // 
            this.txtDriverExpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDriverExpAge.Location = new System.Drawing.Point(299, 206);
            this.txtDriverExpAge.MaxLength = 2;
            this.txtDriverExpAge.Name = "txtDriverExpAge";
            this.txtDriverExpAge.Size = new System.Drawing.Size(276, 36);
            this.txtDriverExpAge.TabIndex = 9;
            this.txtDriverExpAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDriverExpAge_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(148, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стаж :";
            // 
            // txtCarMileage
            // 
            this.txtCarMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCarMileage.Location = new System.Drawing.Point(299, 451);
            this.txtCarMileage.MaxLength = 6;
            this.txtCarMileage.Name = "txtCarMileage";
            this.txtCarMileage.Size = new System.Drawing.Size(276, 36);
            this.txtCarMileage.TabIndex = 17;
            this.txtCarMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarMileage_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(148, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Пробег :";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCarModel.Location = new System.Drawing.Point(299, 409);
            this.txtCarModel.MaxLength = 50;
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(276, 36);
            this.txtCarModel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(148, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Модель :";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCar.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCar.Location = new System.Drawing.Point(146, 298);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(171, 40);
            this.labelCar.TabIndex = 13;
            this.labelCar.Text = "Автомобиль";
            this.labelCar.Click += new System.EventHandler(this.labelCar_Click);
            // 
            // txtCarIdNumber
            // 
            this.txtCarIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCarIdNumber.Location = new System.Drawing.Point(299, 367);
            this.txtCarIdNumber.MaxLength = 9;
            this.txtCarIdNumber.Name = "txtCarIdNumber";
            this.txtCarIdNumber.Size = new System.Drawing.Size(276, 36);
            this.txtCarIdNumber.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(148, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Госномер :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(148, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "Госномер :";
            // 
            // labelCrew
            // 
            this.labelCrew.AutoSize = true;
            this.labelCrew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCrew.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrew.Location = new System.Drawing.Point(146, 541);
            this.labelCrew.Name = "labelCrew";
            this.labelCrew.Size = new System.Drawing.Size(111, 40);
            this.labelCrew.TabIndex = 21;
            this.labelCrew.Text = "Экипаж";
            this.labelCrew.Click += new System.EventHandler(this.labelCrew_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(148, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "Водитель :";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(199, 780);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 54);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(337, 780);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 54);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::AppWinFormCRUD.Properties.Resources.crew;
            this.pictureBox3.Location = new System.Drawing.Point(60, 526);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AppWinFormCRUD.Properties.Resources.car;
            this.pictureBox2.Location = new System.Drawing.Point(60, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AppWinFormCRUD.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(60, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(148, 697);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 30);
            this.label12.TabIndex = 26;
            this.label12.Text = "Маршрут :";
            // 
            // txtCrewDriver
            // 
            this.txtCrewDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCrewDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCrewDriver.FormattingEnabled = true;
            this.txtCrewDriver.Location = new System.Drawing.Point(299, 606);
            this.txtCrewDriver.Name = "txtCrewDriver";
            this.txtCrewDriver.Size = new System.Drawing.Size(276, 37);
            this.txtCrewDriver.Sorted = true;
            this.txtCrewDriver.TabIndex = 28;
            // 
            // txtCrewCar
            // 
            this.txtCrewCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCrewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCrewCar.FormattingEnabled = true;
            this.txtCrewCar.Location = new System.Drawing.Point(299, 650);
            this.txtCrewCar.Name = "txtCrewCar";
            this.txtCrewCar.Size = new System.Drawing.Size(276, 37);
            this.txtCrewCar.Sorted = true;
            this.txtCrewCar.TabIndex = 29;
            // 
            // txtCrewTransef
            // 
            this.txtCrewTransef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCrewTransef.Location = new System.Drawing.Point(299, 696);
            this.txtCrewTransef.MaxLength = 200;
            this.txtCrewTransef.Name = "txtCrewTransef";
            this.txtCrewTransef.Size = new System.Drawing.Size(276, 36);
            this.txtCrewTransef.TabIndex = 30;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 850);
            this.Controls.Add(this.txtCrewTransef);
            this.Controls.Add(this.txtCrewCar);
            this.Controls.Add(this.txtCrewDriver);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelCrew);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCarMileage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCarIdNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDriverExpAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDriverAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDriverCarCrew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDriverCarCrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataDriverCarCrew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.TextBox txtDriverAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDriverExpAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarMileage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCarIdNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCrew;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtCrewDriver;
        private System.Windows.Forms.ComboBox txtCrewCar;
        private System.Windows.Forms.TextBox txtCrewTransef;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPersonAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPersonExpAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCarIdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCarMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCrewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCrewTransfer;
    }
}