namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.область = new System.Windows.Forms.ComboBox();
            this.областьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.областьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.район = new System.Windows.Forms.ComboBox();
            this.районBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.город = new System.Windows.Forms.ComboBox();
            this.городBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.улица = new System.Windows.Forms.ComboBox();
            this.улицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.номер = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.доп = new System.Windows.Forms.CheckBox();
            this.дата = new System.Windows.Forms.DateTimePicker();
            this.площадь = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.жилая = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.кухни = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.этажность = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.этаж = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.санузел = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.телефон = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.болкон = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.материалы = new System.Windows.Forms.ComboBox();
            this.материалыпостройкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.ремон = new System.Windows.Forms.ComboBox();
            this.ремонтотделкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.колво = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.цена = new System.Windows.Forms.TextBox();
            this.поиск = new System.Windows.Forms.Button();
            this.бД1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бД1DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.общаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.областьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.областьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.районBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыпостройкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтотделкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общаяBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расположение объекта ";
            // 
            // область
            // 
            this.область.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.областьBindingSource, "Наименование области", true));
            this.область.DataSource = this.областьBindingSource1;
            this.область.DisplayMember = "Наименование области";
            this.область.FormattingEnabled = true;
            this.область.Location = new System.Drawing.Point(13, 31);
            this.область.Name = "область";
            this.область.Size = new System.Drawing.Size(121, 24);
            this.область.TabIndex = 1;
            this.область.ValueMember = "Наименование области";
            // 
            // областьBindingSource
            // 
            this.областьBindingSource.DataMember = "Область";
            // 
            // областьBindingSource1
            // 
            this.областьBindingSource1.DataMember = "Область";
            // 
            // район
            // 
            this.район.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.районBindingSource, "Наименованиерайона", true));
            this.район.DataSource = this.районBindingSource;
            this.район.DisplayMember = "Наименованиерайона";
            this.район.FormattingEnabled = true;
            this.район.Location = new System.Drawing.Point(13, 61);
            this.район.Name = "район";
            this.район.Size = new System.Drawing.Size(121, 24);
            this.район.TabIndex = 2;
            this.район.ValueMember = "Наименованиерайона";
            // 
            // районBindingSource
            // 
            this.районBindingSource.DataMember = "Район";
            // 
            // город
            // 
            this.город.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.городBindingSource, "Наименование_города", true));
            this.город.DataSource = this.городBindingSource;
            this.город.DisplayMember = "Наименование_города";
            this.город.FormattingEnabled = true;
            this.город.Location = new System.Drawing.Point(12, 91);
            this.город.Name = "город";
            this.город.Size = new System.Drawing.Size(121, 24);
            this.город.TabIndex = 3;
            this.город.ValueMember = "Наименование_города";
            // 
            // городBindingSource
            // 
            this.городBindingSource.DataMember = "Город";
            // 
            // улица
            // 
            this.улица.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.улицаBindingSource, "Наименование улицы", true));
            this.улица.FormattingEnabled = true;
            this.улица.Items.AddRange(new object[] {
            "Советская",
            "Ленина",
            "Пушкинская"});
            this.улица.Location = new System.Drawing.Point(12, 121);
            this.улица.Name = "улица";
            this.улица.Size = new System.Drawing.Size(121, 24);
            this.улица.TabIndex = 4;
            // 
            // улицаBindingSource
            // 
            this.улицаBindingSource.DataMember = "Улица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер дома";
            // 
            // номер
            // 
            this.номер.Location = new System.Drawing.Point(107, 152);
            this.номер.Name = "номер";
            this.номер.Size = new System.Drawing.Size(100, 22);
            this.номер.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Расширенные параметры ";
            // 
            // доп
            // 
            this.доп.AutoSize = true;
            this.доп.Location = new System.Drawing.Point(443, 9);
            this.доп.Name = "доп";
            this.доп.Size = new System.Drawing.Size(18, 17);
            this.доп.TabIndex = 8;
            this.доп.UseVisualStyleBackColor = true;
            // 
            // дата
            // 
            this.дата.Location = new System.Drawing.Point(266, 33);
            this.дата.Name = "дата";
            this.дата.Size = new System.Drawing.Size(150, 22);
            this.дата.TabIndex = 9;
            // 
            // площадь
            // 
            this.площадь.Location = new System.Drawing.Point(340, 60);
            this.площадь.Name = "площадь";
            this.площадь.Size = new System.Drawing.Size(100, 22);
            this.площадь.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Площадь жилая";
            // 
            // жилая
            // 
            this.жилая.Location = new System.Drawing.Point(381, 88);
            this.жилая.Name = "жилая";
            this.жилая.Size = new System.Drawing.Size(80, 22);
            this.жилая.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Площадь кухни";
            // 
            // кухни
            // 
            this.кухни.Location = new System.Drawing.Point(381, 117);
            this.кухни.Name = "кухни";
            this.кухни.Size = new System.Drawing.Size(80, 22);
            this.кухни.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Этажность";
            // 
            // этажность
            // 
            this.этажность.Location = new System.Drawing.Point(340, 147);
            this.этажность.Name = "этажность";
            this.этажность.Size = new System.Drawing.Size(100, 22);
            this.этажность.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "этаж";
            // 
            // этаж
            // 
            this.этаж.Location = new System.Drawing.Point(581, 35);
            this.этаж.Name = "этаж";
            this.этаж.Size = new System.Drawing.Size(100, 22);
            this.этаж.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Разделеный сан/узел";
            // 
            // санузел
            // 
            this.санузел.AutoSize = true;
            this.санузел.Location = new System.Drawing.Point(697, 67);
            this.санузел.Name = "санузел";
            this.санузел.Size = new System.Drawing.Size(18, 17);
            this.санузел.TabIndex = 21;
            this.санузел.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Телефон";
            // 
            // телефон
            // 
            this.телефон.AutoSize = true;
            this.телефон.Location = new System.Drawing.Point(614, 91);
            this.телефон.Name = "телефон";
            this.телефон.Size = new System.Drawing.Size(18, 17);
            this.телефон.TabIndex = 23;
            this.телефон.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "болкон/лоджи";
            // 
            // болкон
            // 
            this.болкон.AutoSize = true;
            this.болкон.Location = new System.Drawing.Point(646, 120);
            this.болкон.Name = "болкон";
            this.болкон.Size = new System.Drawing.Size(18, 17);
            this.болкон.TabIndex = 25;
            this.болкон.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "материалы стен";
            // 
            // материалы
            // 
            this.материалы.DataSource = this.материалыпостройкиBindingSource;
            this.материалы.DisplayMember = "Наименование материала";
            this.материалы.FormattingEnabled = true;
            this.материалы.Location = new System.Drawing.Point(658, 151);
            this.материалы.Name = "материалы";
            this.материалы.Size = new System.Drawing.Size(121, 24);
            this.материалы.TabIndex = 27;
            this.материалы.ValueMember = "Наименование материала";
            // 
            // материалыпостройкиBindingSource
            // 
            this.материалыпостройкиBindingSource.DataMember = "Материалы_постройки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(804, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ремонт (отделка)";
            // 
            // ремон
            // 
            this.ремон.DataSource = this.ремонтотделкаBindingSource;
            this.ремон.DisplayMember = "Наименование";
            this.ремон.FormattingEnabled = true;
            this.ремон.Location = new System.Drawing.Point(926, 38);
            this.ремон.Name = "ремон";
            this.ремон.Size = new System.Drawing.Size(121, 24);
            this.ремон.TabIndex = 29;
            this.ремон.ValueMember = "Наименование";
            // 
            // ремонтотделкаBindingSource
            // 
            this.ремонтотделкаBindingSource.DataMember = "Ремонт/отделка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(804, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "количество комнат";
            // 
            // колво
            // 
            this.колво.Location = new System.Drawing.Point(946, 69);
            this.колво.Name = "колво";
            this.колво.Size = new System.Drawing.Size(100, 22);
            this.колво.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(807, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "цена";
            // 
            // цена
            // 
            this.цена.Location = new System.Drawing.Point(853, 97);
            this.цена.Name = "цена";
            this.цена.Size = new System.Drawing.Size(100, 22);
            this.цена.TabIndex = 33;
            // 
            // поиск
            // 
            this.поиск.Location = new System.Drawing.Point(810, 145);
            this.поиск.Name = "поиск";
            this.поиск.Size = new System.Drawing.Size(310, 23);
            this.поиск.TabIndex = 34;
            this.поиск.Text = "поиск";
            this.поиск.UseVisualStyleBackColor = true;
            // 
            // бД1DataSet
            // 
            this.бД1DataSet.DataSetName = "БД1DataSet";
            this.бД1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бД1DataSetBindingSource1
            // 
            this.бД1DataSetBindingSource1.DataSource = this.бД1DataSet;
            this.бД1DataSetBindingSource1.Position = 0;
            // 
            // бД1DataSetBindingSource2
            // 
            this.бД1DataSetBindingSource2.DataSource = this.бД1DataSet;
            this.бД1DataSetBindingSource2.Position = 0;
            // 
            // общаяBindingSource
            // 
            this.общаяBindingSource.DataMember = "Общая";
            this.общаяBindingSource.DataSource = this.бД1DataSet;
            // 
            // общаяTableAdapter
            // 
            this.общаяTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 579);
            this.Controls.Add(this.поиск);
            this.Controls.Add(this.цена);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.колво);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ремон);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.материалы);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.болкон);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.телефон);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.санузел);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.этаж);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.этажность);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.кухни);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.жилая);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.площадь);
            this.Controls.Add(this.дата);
            this.Controls.Add(this.доп);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.номер);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.улица);
            this.Controls.Add(this.город);
            this.Controls.Add(this.район);
            this.Controls.Add(this.область);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Продажа недвижемости";
            ((System.ComponentModel.ISupportInitialize)(this.областьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.областьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.районBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыпостройкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтотделкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД1DataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общаяBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox область;
        private System.Windows.Forms.BindingSource областьBindingSource;
        private System.Windows.Forms.ComboBox район;
        private System.Windows.Forms.BindingSource районBindingSource;
        private System.Windows.Forms.BindingSource областьBindingSource1;
        private System.Windows.Forms.ComboBox город;
        private System.Windows.Forms.BindingSource городBindingSource;
        private System.Windows.Forms.ComboBox улица;
        private System.Windows.Forms.BindingSource улицаBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox номер;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox доп;
        private System.Windows.Forms.DateTimePicker дата;
        private System.Windows.Forms.TextBox площадь;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox жилая;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox кухни;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox этажность;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox этаж;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox санузел;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox телефон;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox болкон;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox материалы;
        private System.Windows.Forms.BindingSource материалыпостройкиBindingSource;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ремон;
        private System.Windows.Forms.BindingSource ремонтотделкаBindingSource;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox колво;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox цена;
        private System.Windows.Forms.Button поиск;
        private System.Windows.Forms.BindingSource бД1DataSetBindingSource;
        private System.Windows.Forms.BindingSource бД1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource бД1DataSetBindingSource2;
        private System.Windows.Forms.BindingSource общаяBindingSource;
    }
}

