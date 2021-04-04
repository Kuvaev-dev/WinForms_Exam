namespace Tamojka
{
    partial class FirstCalc
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
            this.cost1 = new System.Windows.Forms.Label();
            this.cost_1 = new System.Windows.Forms.TextBox();
            this.benzin1 = new System.Windows.Forms.Label();
            this.dvigatel1 = new System.Windows.Forms.TextBox();
            this.dvigType = new System.Windows.Forms.Label();
            this.dvigatelType_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.calcType1 = new System.Windows.Forms.Button();
            this.endCost1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cost1
            // 
            this.cost1.AutoSize = true;
            this.cost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost1.Location = new System.Drawing.Point(169, 47);
            this.cost1.Name = "cost1";
            this.cost1.Size = new System.Drawing.Size(194, 20);
            this.cost1.TabIndex = 0;
            this.cost1.Text = "Стоимость автомобиля:";
            // 
            // cost_1
            // 
            this.cost_1.Location = new System.Drawing.Point(402, 49);
            this.cost_1.Name = "cost_1";
            this.cost_1.Size = new System.Drawing.Size(197, 20);
            this.cost_1.TabIndex = 1;
            // 
            // benzin1
            // 
            this.benzin1.AutoSize = true;
            this.benzin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.benzin1.Location = new System.Drawing.Point(142, 89);
            this.benzin1.Name = "benzin1";
            this.benzin1.Size = new System.Drawing.Size(221, 20);
            this.benzin1.TabIndex = 2;
            this.benzin1.Text = "Объём двигателя, кубю дм:";
            // 
            // dvigatel1
            // 
            this.dvigatel1.Location = new System.Drawing.Point(402, 89);
            this.dvigatel1.Name = "dvigatel1";
            this.dvigatel1.Size = new System.Drawing.Size(197, 20);
            this.dvigatel1.TabIndex = 3;
            // 
            // dvigType
            // 
            this.dvigType.AutoSize = true;
            this.dvigType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dvigType.Location = new System.Drawing.Point(237, 128);
            this.dvigType.Name = "dvigType";
            this.dvigType.Size = new System.Drawing.Size(126, 20);
            this.dvigType.TabIndex = 4;
            this.dvigType.Text = "Тип двигателя:";
            // 
            // dvigatelType_1
            // 
            this.dvigatelType_1.FormattingEnabled = true;
            this.dvigatelType_1.Location = new System.Drawing.Point(402, 130);
            this.dvigatelType_1.Name = "dvigatelType_1";
            this.dvigatelType_1.Size = new System.Drawing.Size(197, 21);
            this.dvigatelType_1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Год выпуска:";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(402, 169);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(197, 20);
            this.year.TabIndex = 7;
            // 
            // calcType1
            // 
            this.calcType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcType1.Location = new System.Drawing.Point(332, 212);
            this.calcType1.Name = "calcType1";
            this.calcType1.Size = new System.Drawing.Size(126, 49);
            this.calcType1.TabIndex = 8;
            this.calcType1.Text = "Рассчитать";
            this.calcType1.UseVisualStyleBackColor = true;
            this.calcType1.Click += new System.EventHandler(this.calcType1_Click);
            // 
            // endCost1
            // 
            this.endCost1.AutoSize = true;
            this.endCost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endCost1.Location = new System.Drawing.Point(407, 285);
            this.endCost1.Name = "endCost1";
            this.endCost1.Size = new System.Drawing.Size(51, 20);
            this.endCost1.TabIndex = 21;
            this.endCost1.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Стоимость растаможки:";
            // 
            // FirstCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endCost1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcType1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvigatelType_1);
            this.Controls.Add(this.dvigType);
            this.Controls.Add(this.dvigatel1);
            this.Controls.Add(this.benzin1);
            this.Controls.Add(this.cost_1);
            this.Controls.Add(this.cost1);
            this.Name = "FirstCalc";
            this.Text = "FirstCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cost1;
        private System.Windows.Forms.TextBox cost_1;
        private System.Windows.Forms.Label benzin1;
        private System.Windows.Forms.TextBox dvigatel1;
        private System.Windows.Forms.Label dvigType;
        private System.Windows.Forms.ComboBox dvigatelType_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button calcType1;
        private System.Windows.Forms.Label endCost1;
        private System.Windows.Forms.Label label2;
    }
}