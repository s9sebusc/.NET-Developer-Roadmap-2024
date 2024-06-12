namespace MSSQLForCSProgs
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
         System.Windows.Forms.TabPage TabPage;
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.button2 = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.TabControl = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.button1 = new System.Windows.Forms.Button();
         this.textBox6 = new System.Windows.Forms.TextBox();
         this.textBox5 = new System.Windows.Forms.TextBox();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.tabControl2 = new System.Windows.Forms.TabControl();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.tabPage4 = new System.Windows.Forms.TabPage();
         this.textBox7 = new System.Windows.Forms.TextBox();
         TabPage = new System.Windows.Forms.TabPage();
         TabPage.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.TabControl.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabControl2.SuspendLayout();
         this.SuspendLayout();
         // 
         // TabPage
         // 
         TabPage.Controls.Add(this.tableLayoutPanel1);
         TabPage.Location = new System.Drawing.Point(4, 25);
         TabPage.Name = "TabPage";
         TabPage.Padding = new System.Windows.Forms.Padding(3);
         TabPage.Size = new System.Drawing.Size(906, 421);
         TabPage.TabIndex = 1;
         TabPage.Text = "SELECT";
         TabPage.UseVisualStyleBackColor = true;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 2);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 415);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(3, 335);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(187, 34);
         this.button2.TabIndex = 0;
         this.button2.Text = "SELECT";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView1.Location = new System.Drawing.Point(3, 3);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 24;
         this.dataGridView1.Size = new System.Drawing.Size(894, 326);
         this.dataGridView1.TabIndex = 1;
         this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // TabControl
         // 
         this.TabControl.AllowDrop = true;
         this.TabControl.Controls.Add(this.tabPage1);
         this.TabControl.Controls.Add(TabPage);
         this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TabControl.Location = new System.Drawing.Point(0, 0);
         this.TabControl.Name = "TabControl";
         this.TabControl.SelectedIndex = 0;
         this.TabControl.Size = new System.Drawing.Size(914, 450);
         this.TabControl.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
         this.tabPage1.Controls.Add(this.button1);
         this.tabPage1.Controls.Add(this.textBox6);
         this.tabPage1.Controls.Add(this.textBox5);
         this.tabPage1.Controls.Add(this.textBox4);
         this.tabPage1.Controls.Add(this.textBox3);
         this.tabPage1.Controls.Add(this.textBox2);
         this.tabPage1.Controls.Add(this.textBox1);
         this.tabPage1.Location = new System.Drawing.Point(4, 25);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(906, 421);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "INSERT";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(761, 6);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(122, 41);
         this.button1.TabIndex = 6;
         this.button1.Text = "INSERT";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox6
         // 
         this.textBox6.Location = new System.Drawing.Point(613, 6);
         this.textBox6.Name = "textBox6";
         this.textBox6.Size = new System.Drawing.Size(115, 22);
         this.textBox6.TabIndex = 5;
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(492, 6);
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(115, 22);
         this.textBox5.TabIndex = 4;
         // 
         // textBox4
         // 
         this.textBox4.Location = new System.Drawing.Point(371, 6);
         this.textBox4.Name = "textBox4";
         this.textBox4.Size = new System.Drawing.Size(115, 22);
         this.textBox4.TabIndex = 3;
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(250, 6);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(115, 22);
         this.textBox3.TabIndex = 2;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(129, 6);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(115, 22);
         this.textBox2.TabIndex = 1;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(8, 6);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(115, 22);
         this.textBox1.TabIndex = 0;
         // 
         // tabControl2
         // 
         this.tabControl2.Controls.Add(this.tabPage3);
         this.tabControl2.Controls.Add(this.tabPage4);
         this.tabControl2.Location = new System.Drawing.Point(239, 167);
         this.tabControl2.Name = "tabControl2";
         this.tabControl2.SelectedIndex = 0;
         this.tabControl2.Size = new System.Drawing.Size(8, 8);
         this.tabControl2.TabIndex = 1;
         // 
         // tabPage3
         // 
         this.tabPage3.Location = new System.Drawing.Point(4, 25);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage3.Size = new System.Drawing.Size(0, 0);
         this.tabPage3.TabIndex = 0;
         this.tabPage3.Text = "tabPage3";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // tabPage4
         // 
         this.tabPage4.Location = new System.Drawing.Point(4, 25);
         this.tabPage4.Name = "tabPage4";
         this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage4.Size = new System.Drawing.Size(0, 0);
         this.tabPage4.TabIndex = 1;
         this.tabPage4.Text = "tabPage4";
         this.tabPage4.UseVisualStyleBackColor = true;
         // 
         // textBox7
         // 
         this.textBox7.Location = new System.Drawing.Point(3, 376);
         this.textBox7.Name = "textBox7";
         this.textBox7.Size = new System.Drawing.Size(892, 22);
         this.textBox7.TabIndex = 2;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(914, 450);
         this.Controls.Add(this.tabControl2);
         this.Controls.Add(this.TabControl);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         TabPage.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.TabControl.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabControl2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl TabControl;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabControl tabControl2;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.TabPage tabPage4;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox6;
      private System.Windows.Forms.TextBox textBox5;
      private System.Windows.Forms.TextBox textBox4;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.TextBox textBox7;
   }
}

