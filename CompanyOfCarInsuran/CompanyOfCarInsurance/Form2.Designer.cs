
namespace CompanyOfCarInsurance
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договораBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.compStrahOfAutoDataSet1 = new CompanyOfCarInsurance.CompStrahOfAutoDataSet1();
            this.compStrahOfAutoDataSet = new CompanyOfCarInsurance.CompStrahOfAutoDataSet();
            this.договораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter = new CompanyOfCarInsurance.CompStrahOfAutoDataSetTableAdapters.ДоговораTableAdapter();
            this.AddB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.compStrahOfAutoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter1 = new CompanyOfCarInsurance.CompStrahOfAutoDataSet1TableAdapters.ДоговораTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.number,
            this.dates,
            this.sum,
            this.agent,
            this.car,
            this.client,
            this.datef,
            this.writen,
            this.client2});
            this.dataGridView1.DataSource = this.договораBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-24, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Код договора";
            this.Id.HeaderText = "Код договора";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // number
            // 
            this.number.DataPropertyName = "№ договора";
            this.number.HeaderText = "№ договора";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 75;
            // 
            // dates
            // 
            this.dates.DataPropertyName = "Дата заключения";
            this.dates.HeaderText = "Дата заключения";
            this.dates.MinimumWidth = 6;
            this.dates.Name = "dates";
            this.dates.Width = 75;
            // 
            // sum
            // 
            this.sum.DataPropertyName = "Страховая сумма";
            this.sum.HeaderText = "Страховая сумма";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.Width = 75;
            // 
            // agent
            // 
            this.agent.DataPropertyName = "Страховой агент";
            this.agent.HeaderText = "Страховой агент";
            this.agent.MinimumWidth = 6;
            this.agent.Name = "agent";
            this.agent.Width = 75;
            // 
            // car
            // 
            this.car.DataPropertyName = "Транспортное средство";
            this.car.HeaderText = "Транспортное средство";
            this.car.MinimumWidth = 6;
            this.car.Name = "car";
            this.car.Width = 75;
            // 
            // client
            // 
            this.client.DataPropertyName = "Клиент";
            this.client.HeaderText = "Клиент";
            this.client.MinimumWidth = 6;
            this.client.Name = "client";
            this.client.Width = 75;
            // 
            // datef
            // 
            this.datef.DataPropertyName = "ДатаОкончания";
            this.datef.HeaderText = "ДатаОкончания";
            this.datef.MinimumWidth = 6;
            this.datef.Name = "datef";
            this.datef.Width = 75;
            // 
            // writen
            // 
            this.writen.DataPropertyName = "Вписанные";
            this.writen.HeaderText = "Вписанные";
            this.writen.MinimumWidth = 6;
            this.writen.Name = "writen";
            this.writen.Width = 75;
            // 
            // client2
            // 
            this.client2.DataPropertyName = "КлиентЮрЛицо";
            this.client2.HeaderText = "КлиентЮрЛицо";
            this.client2.MinimumWidth = 6;
            this.client2.Name = "client2";
            this.client2.Width = 90;
            // 
            // договораBindingSource2
            // 
            this.договораBindingSource2.DataMember = "Договора";
            this.договораBindingSource2.DataSource = this.compStrahOfAutoDataSet1;
            // 
            // compStrahOfAutoDataSet1
            // 
            this.compStrahOfAutoDataSet1.DataSetName = "CompStrahOfAutoDataSet1";
            this.compStrahOfAutoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compStrahOfAutoDataSet
            // 
            this.compStrahOfAutoDataSet.DataSetName = "CompStrahOfAutoDataSet";
            this.compStrahOfAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договораBindingSource
            // 
            this.договораBindingSource.DataMember = "Договора";
            this.договораBindingSource.DataSource = this.compStrahOfAutoDataSet;
            // 
            // договораTableAdapter
            // 
            this.договораTableAdapter.ClearBeforeFill = true;
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(883, 38);
            this.AddB.Margin = new System.Windows.Forms.Padding(2);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(74, 28);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Add";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(883, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(883, 143);
            this.SaveB.Margin = new System.Windows.Forms.Padding(2);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(74, 28);
            this.SaveB.TabIndex = 3;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // compStrahOfAutoDataSet1BindingSource
            // 
            this.compStrahOfAutoDataSet1BindingSource.DataSource = this.compStrahOfAutoDataSet1;
            this.compStrahOfAutoDataSet1BindingSource.Position = 0;
            // 
            // договораBindingSource1
            // 
            this.договораBindingSource1.DataMember = "Договора";
            this.договораBindingSource1.DataSource = this.compStrahOfAutoDataSet;
            // 
            // договораTableAdapter1
            // 
            this.договораTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 557);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CompStrahOfAutoDataSet compStrahOfAutoDataSet;
        private System.Windows.Forms.BindingSource договораBindingSource;
        private CompStrahOfAutoDataSetTableAdapters.ДоговораTableAdapter договораTableAdapter;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.BindingSource договораBindingSource1;
        private CompStrahOfAutoDataSet1 compStrahOfAutoDataSet1;
        private System.Windows.Forms.BindingSource compStrahOfAutoDataSet1BindingSource;
        private System.Windows.Forms.BindingSource договораBindingSource2;
        private CompStrahOfAutoDataSet1TableAdapters.ДоговораTableAdapter договораTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn datef;
        private System.Windows.Forms.DataGridViewTextBoxColumn writen;
        private System.Windows.Forms.DataGridViewTextBoxColumn client2;
    }
}