namespace Tamojka
{
    partial class LastCalc
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
            this.calcType4 = new System.Windows.Forms.Button();
            this.cost4 = new System.Windows.Forms.TextBox();
            this.cost2 = new System.Windows.Forms.Label();
            this.autoOld = new System.Windows.Forms.TextBox();
            this.old = new System.Windows.Forms.Label();
            this.dvigatel4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcType4
            // 
            this.calcType4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcType4.Location = new System.Drawing.Point(326, 193);
            this.calcType4.Name = "calcType4";
            this.calcType4.Size = new System.Drawing.Size(126, 49);
            this.calcType4.TabIndex = 13;
            this.calcType4.Text = "Рассчитать";
            this.calcType4.UseVisualStyleBackColor = true;
            // 
            // cost4
            // 
            this.cost4.Location = new System.Drawing.Point(407, 61);
            this.cost4.Name = "cost4";
            this.cost4.Size = new System.Drawing.Size(197, 20);
            this.cost4.TabIndex = 12;
            // 
            // cost2
            // 
            this.cost2.AutoSize = true;
            this.cost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost2.Location = new System.Drawing.Point(167, 59);
            this.cost2.Name = "cost2";
            this.cost2.Size = new System.Drawing.Size(194, 20);
            this.cost2.TabIndex = 11;
            this.cost2.Text = "Стоимость автомобиля:";
            // 
            // autoOld
            // 
            this.autoOld.Location = new System.Drawing.Point(407, 150);
            this.autoOld.Name = "autoOld";
            this.autoOld.Size = new System.Drawing.Size(197, 20);
            this.autoOld.TabIndex = 15;
            // 
            // old
            // 
            this.old.AutoSize = true;
            this.old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.old.Location = new System.Drawing.Point(188, 148);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(173, 20);
            this.old.TabIndex = 14;
            this.old.Text = "Возраст автомобиля:";
            // 
            // dvigatel4
            // 
            this.dvigatel4.Location = new System.Drawing.Point(407, 104);
            this.dvigatel4.Name = "dvigatel4";
            this.dvigatel4.Size = new System.Drawing.Size(197, 20);
            this.dvigatel4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(148, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Объём двигателя, куб. дм:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Стоимость растаможки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(403, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // LastCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvigatel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoOld);
            this.Controls.Add(this.old);
            this.Controls.Add(this.calcType4);
            this.Controls.Add(this.cost4);
            this.Controls.Add(this.cost2);
            this.Name = "LastCalc";
            this.Text = "LastCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcType4;
        private System.Windows.Forms.TextBox cost4;
        private System.Windows.Forms.Label cost2;
        private System.Windows.Forms.TextBox autoOld;
        private System.Windows.Forms.Label old;
        private System.Windows.Forms.TextBox dvigatel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}