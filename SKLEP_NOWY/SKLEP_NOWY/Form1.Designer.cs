namespace SKLEP_NOWY
{
    partial class FormStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_Laptop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_Laptop
            // 
            this.Open_Laptop.Location = new System.Drawing.Point(12, 12);
            this.Open_Laptop.Name = "Open_Laptop";
            this.Open_Laptop.Size = new System.Drawing.Size(117, 23);
            this.Open_Laptop.TabIndex = 0;
            this.Open_Laptop.Text = "Open Laptopy";
            this.Open_Laptop.UseVisualStyleBackColor = true;
            this.Open_Laptop.Click += new System.EventHandler(this.Open_Laptop_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 45);
            this.Controls.Add(this.Open_Laptop);
            this.Name = "FormStart";
            this.Text = "Formularz Startowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_Laptop;
    }
}

