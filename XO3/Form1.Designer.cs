namespace XO3
{
    partial class XO
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
            this.stg = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.PictureBox();
            this.res = new System.Windows.Forms.Label();
            this.crestic = new System.Windows.Forms.Label();
            this.nolic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.SuspendLayout();
            // 
            // stg
            // 
            this.stg.Location = new System.Drawing.Point(12, 12);
            this.stg.Name = "stg";
            this.stg.Size = new System.Drawing.Size(75, 23);
            this.stg.TabIndex = 0;
            this.stg.Text = "Начать";
            this.stg.UseVisualStyleBackColor = true;
            this.stg.Click += new System.EventHandler(this.stg_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(12, 41);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(420, 420);
            this.container.TabIndex = 1;
            this.container.TabStop = false;
            this.container.Click += new System.EventHandler(this.container_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(370, 17);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 13);
            this.res.TabIndex = 2;
            // 
            // crestic
            // 
            this.crestic.AutoSize = true;
            this.crestic.Location = new System.Drawing.Point(153, 22);
            this.crestic.Name = "crestic";
            this.crestic.Size = new System.Drawing.Size(17, 13);
            this.crestic.TabIndex = 3;
            this.crestic.Text = "X-";
            // 
            // nolic
            // 
            this.nolic.AutoSize = true;
            this.nolic.Location = new System.Drawing.Point(207, 22);
            this.nolic.Name = "nolic";
            this.nolic.Size = new System.Drawing.Size(18, 13);
            this.nolic.TabIndex = 4;
            this.nolic.Text = "O-";
            // 
            // XO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 482);
            this.Controls.Add(this.nolic);
            this.Controls.Add(this.crestic);
            this.Controls.Add(this.res);
            this.Controls.Add(this.container);
            this.Controls.Add(this.stg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO";
            this.Load += new System.EventHandler(this.XO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stg;
        private System.Windows.Forms.PictureBox container;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label crestic;
        private System.Windows.Forms.Label nolic;
    }
}

