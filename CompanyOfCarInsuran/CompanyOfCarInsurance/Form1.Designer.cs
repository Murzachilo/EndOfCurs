
namespace CompanyOfCarInsurance
{
    partial class Menu
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
            this.First = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.compStrahOfAutoDataSet = new CompanyOfCarInsurance.CompStrahOfAutoDataSet();
            this.договораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter = new CompanyOfCarInsurance.CompStrahOfAutoDataSetTableAdapters.ДоговораTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ins_CAR_surence";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(127, 182);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(140, 75);
            this.First.TabIndex = 1;
            this.First.Text = "Застраховать";
            this.First.UseVisualStyleBackColor = true;
            this.First.Click += new System.EventHandler(this.Застраховать_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Договора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(706, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 334);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.First);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compStrahOfAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private CompStrahOfAutoDataSet compStrahOfAutoDataSet;
        private System.Windows.Forms.BindingSource договораBindingSource;
        private CompStrahOfAutoDataSetTableAdapters.ДоговораTableAdapter договораTableAdapter;
    }
}

