
namespace CompanyOfCarInsurance
{
    partial class contracts
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
            this.ContractsDGV = new System.Windows.Forms.DataGridView();
            this.cont = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ContractsDGV
            // 
            this.ContractsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractsDGV.Location = new System.Drawing.Point(102, 97);
            this.ContractsDGV.Name = "ContractsDGV";
            this.ContractsDGV.RowHeadersWidth = 51;
            this.ContractsDGV.RowTemplate.Height = 24;
            this.ContractsDGV.Size = new System.Drawing.Size(1275, 547);
            this.ContractsDGV.TabIndex = 4;
            this.ContractsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContractsDGV_CellContentClick);
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cont.Location = new System.Drawing.Point(646, 24);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(155, 37);
            this.cont.TabIndex = 46;
            this.cont.Text = "Договора";
            // 
            // backBtn
            // 
            this.backBtn.Image = global::CompanyOfCarInsurance.Properties.Resources.img_447535__1_;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(70, 70);
            this.backBtn.TabIndex = 45;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1398, 656);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ContractsDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "contracts";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContractsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ContractsDGV;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label cont;
    }
}