namespace Tamojka
{
    partial class Form1
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
            this.progName = new System.Windows.Forms.Label();
            this.typeName = new System.Windows.Forms.Label();
            this.carType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progName
            // 
            this.progName.AutoSize = true;
            this.progName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progName.Location = new System.Drawing.Point(97, 42);
            this.progName.Name = "progName";
            this.progName.Size = new System.Drawing.Size(516, 25);
            this.progName.TabIndex = 0;
            this.progName.Text = "КАЛЬКУЛЯТОР РАСТАМОЖКИ АВТОМОБИЛЯ";
            // 
            // typeName
            // 
            this.typeName.AutoSize = true;
            this.typeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeName.Location = new System.Drawing.Point(118, 100);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(198, 18);
            this.typeName.TabIndex = 1;
            this.typeName.Text = "Выберите тип автомобиля:";
            // 
            // carType
            // 
            this.carType.FormattingEnabled = true;
            this.carType.Location = new System.Drawing.Point(357, 97);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(233, 21);
            this.carType.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(289, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.progName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progName;
        private System.Windows.Forms.Label typeName;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.Button button1;
    }
}

