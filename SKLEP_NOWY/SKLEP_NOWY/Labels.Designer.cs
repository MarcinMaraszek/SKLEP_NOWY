namespace SKLEP_NOWY
{
    partial class Laptop_Detail
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
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.save_detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesor";
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(67, 6);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(100, 20);
            this.txtProcesor.TabIndex = 1;
            // 
            // save_detail
            // 
            this.save_detail.Location = new System.Drawing.Point(79, 32);
            this.save_detail.Name = "save_detail";
            this.save_detail.Size = new System.Drawing.Size(75, 23);
            this.save_detail.TabIndex = 2;
            this.save_detail.Text = "save";
            this.save_detail.UseVisualStyleBackColor = true;
            this.save_detail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.save_detail_MouseClick);
            // 
            // Laptop_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.save_detail);
            this.Controls.Add(this.txtProcesor);
            this.Controls.Add(this.label1);
            this.Name = "Laptop_Detail";
            this.Text = "Laptop Szczegóły";
            this.Load += new System.EventHandler(this.Laptop_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.Button save_detail;
    }
}