namespace Array_
{
    partial class Form2
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
            this.btnElemanlariListboxaEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRastgeleEleman = new System.Windows.Forms.Button();
            this.btnSonElemaniGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElemanlariListboxaEkle
            // 
            this.btnElemanlariListboxaEkle.Location = new System.Drawing.Point(12, 104);
            this.btnElemanlariListboxaEkle.Name = "btnElemanlariListboxaEkle";
            this.btnElemanlariListboxaEkle.Size = new System.Drawing.Size(304, 40);
            this.btnElemanlariListboxaEkle.TabIndex = 11;
            this.btnElemanlariListboxaEkle.Text = "ELEMANLARI LİSTBOX\'A EKLE";
            this.btnElemanlariListboxaEkle.UseVisualStyleBackColor = true;
            this.btnElemanlariListboxaEkle.Click += new System.EventHandler(this.btnElemanlariListboxaEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 95);
            this.listBox1.TabIndex = 10;
            // 
            // btnRastgeleEleman
            // 
            this.btnRastgeleEleman.Location = new System.Drawing.Point(12, 58);
            this.btnRastgeleEleman.Name = "btnRastgeleEleman";
            this.btnRastgeleEleman.Size = new System.Drawing.Size(304, 40);
            this.btnRastgeleEleman.TabIndex = 9;
            this.btnRastgeleEleman.Text = "RASTGELE ELEMAN GÖSTER";
            this.btnRastgeleEleman.UseVisualStyleBackColor = true;
            this.btnRastgeleEleman.Click += new System.EventHandler(this.btnRastgeleEleman_Click);
            // 
            // btnSonElemaniGoster
            // 
            this.btnSonElemaniGoster.Location = new System.Drawing.Point(12, 12);
            this.btnSonElemaniGoster.Name = "btnSonElemaniGoster";
            this.btnSonElemaniGoster.Size = new System.Drawing.Size(304, 40);
            this.btnSonElemaniGoster.TabIndex = 8;
            this.btnSonElemaniGoster.Text = "SON ELEMANI GÖSTER";
            this.btnSonElemaniGoster.UseVisualStyleBackColor = true;
            this.btnSonElemaniGoster.Click += new System.EventHandler(this.btnSonElemaniGoster_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 260);
            this.Controls.Add(this.btnElemanlariListboxaEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRastgeleEleman);
            this.Controls.Add(this.btnSonElemaniGoster);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElemanlariListboxaEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRastgeleEleman;
        private System.Windows.Forms.Button btnSonElemaniGoster;
    }
}