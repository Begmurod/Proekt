namespace SensorSet
{
    partial class RegForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpbUser = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.gpbSourse = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.numTimedOut = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameDB = new System.Windows.Forms.TextBox();
            this.txtNameServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpbUser.SuspendLayout();
            this.gpbSourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimedOut)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(333, 26);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(333, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gpbUser
            // 
            this.gpbUser.Controls.Add(this.label2);
            this.gpbUser.Controls.Add(this.label1);
            this.gpbUser.Controls.Add(this.txtPassword);
            this.gpbUser.Controls.Add(this.txtNameUser);
            this.gpbUser.Location = new System.Drawing.Point(12, 12);
            this.gpbUser.Name = "gpbUser";
            this.gpbUser.Size = new System.Drawing.Size(308, 94);
            this.gpbUser.TabIndex = 0;
            this.gpbUser.TabStop = false;
            this.gpbUser.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пользователя:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(132, 26);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(157, 20);
            this.txtNameUser.TabIndex = 0;
            // 
            // gpbSourse
            // 
            this.gpbSourse.Controls.Add(this.btnTest);
            this.gpbSourse.Controls.Add(this.numTimedOut);
            this.gpbSourse.Controls.Add(this.label5);
            this.gpbSourse.Controls.Add(this.txtNameDB);
            this.gpbSourse.Controls.Add(this.txtNameServer);
            this.gpbSourse.Controls.Add(this.label4);
            this.gpbSourse.Controls.Add(this.label3);
            this.gpbSourse.Location = new System.Drawing.Point(12, 112);
            this.gpbSourse.Name = "gpbSourse";
            this.gpbSourse.Size = new System.Drawing.Size(412, 118);
            this.gpbSourse.TabIndex = 1;
            this.gpbSourse.TabStop = false;
            this.gpbSourse.Text = "Источник данных";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(318, 20);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 28);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // numTimedOut
            // 
            this.numTimedOut.Location = new System.Drawing.Point(132, 89);
            this.numTimedOut.Margin = new System.Windows.Forms.Padding(2);
            this.numTimedOut.Name = "numTimedOut";
            this.numTimedOut.Size = new System.Drawing.Size(156, 20);
            this.numTimedOut.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Тайм-аут, секунд:";
            // 
            // txtNameDB
            // 
            this.txtNameDB.Location = new System.Drawing.Point(132, 55);
            this.txtNameDB.Name = "txtNameDB";
            this.txtNameDB.Size = new System.Drawing.Size(157, 20);
            this.txtNameDB.TabIndex = 1;
            // 
            // txtNameServer
            // 
            this.txtNameServer.Location = new System.Drawing.Point(132, 25);
            this.txtNameServer.Name = "txtNameServer";
            this.txtNameServer.Size = new System.Drawing.Size(157, 20);
            this.txtNameServer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Имя базы данных:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя сервера:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(433, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(22, 17);
            this.tsStatusLabel.Text = "___";
            this.tsStatusLabel.Visible = false;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(433, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpbSourse);
            this.Controls.Add(this.gpbUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.gpbUser.ResumeLayout(false);
            this.gpbUser.PerformLayout();
            this.gpbSourse.ResumeLayout(false);
            this.gpbSourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimedOut)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gpbUser;
        private System.Windows.Forms.GroupBox gpbSourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameDB;
        private System.Windows.Forms.TextBox txtNameServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.NumericUpDown numTimedOut;
    }
}