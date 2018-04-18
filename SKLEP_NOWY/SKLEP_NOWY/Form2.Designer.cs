namespace SKLEP_NOWY
{
    partial class Lista_Laptopow
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
            this.Grid_Laptopy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Laptopy)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Laptopy
            // 
            this.Grid_Laptopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Laptopy.Location = new System.Drawing.Point(12, 12);
            this.Grid_Laptopy.Name = "Grid_Laptopy";
            this.Grid_Laptopy.Size = new System.Drawing.Size(853, 306);
            this.Grid_Laptopy.TabIndex = 0;
            this.Grid_Laptopy.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Laptopy_RowHeaderMouseDoubleClick);
            // 
            // Lista_Laptopow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 330);
            this.Controls.Add(this.Grid_Laptopy);
            this.Name = "Lista_Laptopow";
            this.Text = "Lista Laptopow";
            this.Load += new System.EventHandler(this.Lista_Laptopow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Laptopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Laptopy;
    }
}