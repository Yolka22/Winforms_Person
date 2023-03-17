namespace Winforms_Person
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
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.fillbutton = new System.Windows.Forms.Button();
            this.WorkersListBoks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(212, 53);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(100, 22);
            this.txtSurName.TabIndex = 0;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(212, 82);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 1;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(212, 111);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 22);
            this.txtPlace.TabIndex = 2;
            // 
            // fillbutton
            // 
            this.fillbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fillbutton.Location = new System.Drawing.Point(212, 139);
            this.fillbutton.Name = "fillbutton";
            this.fillbutton.Size = new System.Drawing.Size(100, 23);
            this.fillbutton.TabIndex = 3;
            this.fillbutton.Text = "Accept";
            this.fillbutton.UseVisualStyleBackColor = true;
            this.fillbutton.Click += new System.EventHandler(this.fillbutton_Click);
            // 
            // WorkersListBoks
            // 
            this.WorkersListBoks.FormattingEnabled = true;
            this.WorkersListBoks.ItemHeight = 16;
            this.WorkersListBoks.Location = new System.Drawing.Point(413, 53);
            this.WorkersListBoks.Name = "WorkersListBoks";
            this.WorkersListBoks.Size = new System.Drawing.Size(294, 116);
            this.WorkersListBoks.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkersListBoks);
            this.Controls.Add(this.fillbutton);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtSurName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Button fillbutton;
        private System.Windows.Forms.ListBox WorkersListBoks;
    }
}

