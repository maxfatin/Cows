namespace WindowsFormsApp1CowCounter
{
    partial class CowCounterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CowCounterForm));
            this.lblCowNumberInput = new System.Windows.Forms.Label();
            this.txtCowNum = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCowNumberInput
            // 
            this.lblCowNumberInput.AutoSize = true;
            this.lblCowNumberInput.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCowNumberInput.Location = new System.Drawing.Point(13, 44);
            this.lblCowNumberInput.Name = "lblCowNumberInput";
            this.lblCowNumberInput.Size = new System.Drawing.Size(204, 18);
            this.lblCowNumberInput.TabIndex = 0;
            this.lblCowNumberInput.Text = "Введите количество коров: ";
            // 
            // txtCowNum
            // 
            this.txtCowNum.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCowNum.HideSelection = false;
            this.txtCowNum.Location = new System.Drawing.Point(223, 41);
            this.txtCowNum.Name = "txtCowNum";
            this.txtCowNum.Size = new System.Drawing.Size(197, 29);
            this.txtCowNum.TabIndex = 1;
            this.txtCowNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(126, 96);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(183, 23);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Просклонять";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(121, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // CowCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtCowNum);
            this.Controls.Add(this.lblCowNumberInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CowCounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cow Counter";
            this.Load += new System.EventHandler(this.CowCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCowNumberInput;
        private System.Windows.Forms.TextBox txtCowNum;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
    }
}

