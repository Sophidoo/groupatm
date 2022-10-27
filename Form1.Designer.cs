namespace AtmMachineDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accNo = new System.Windows.Forms.TextBox();
            this.accPin = new System.Windows.Forms.TextBox();
            this.submitCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("News701 BT", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(535, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Shine ATM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("News701 BT", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(740, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Insert your card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("News701 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(740, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("News701 BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(740, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Pin:";
            // 
            // accNo
            // 
            this.accNo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accNo.Location = new System.Drawing.Point(740, 491);
            this.accNo.Name = "accNo";
            this.accNo.Size = new System.Drawing.Size(428, 43);
            this.accNo.TabIndex = 4;
            // 
            // accPin
            // 
            this.accPin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accPin.Location = new System.Drawing.Point(740, 608);
            this.accPin.Name = "accPin";
            this.accPin.PasswordChar = '*';
            this.accPin.Size = new System.Drawing.Size(428, 43);
            this.accPin.TabIndex = 5;
            // 
            // submitCard
            // 
            this.submitCard.BackColor = System.Drawing.Color.SteelBlue;
            this.submitCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitCard.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.submitCard.FlatAppearance.BorderSize = 0;
            this.submitCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submitCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.submitCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitCard.Font = new System.Drawing.Font("News701 BT", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitCard.ForeColor = System.Drawing.Color.White;
            this.submitCard.Location = new System.Drawing.Point(883, 686);
            this.submitCard.Name = "submitCard";
            this.submitCard.Size = new System.Drawing.Size(150, 52);
            this.submitCard.TabIndex = 7;
            this.submitCard.Text = "Submit";
            this.submitCard.UseVisualStyleBackColor = false;
            this.submitCard.Click += new System.EventHandler(this.submitCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.submitCard);
            this.Controls.Add(this.accPin);
            this.Controls.Add(this.accNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox accNo;
        private TextBox accPin;
        private Button submitCard;
    }
}