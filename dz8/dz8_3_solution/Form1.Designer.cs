
namespace dz8_3_solution
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drop_down_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menubtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footer = new System.Windows.Forms.GroupBox();
            this.checkbox_true = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbVoprosy = new System.Windows.Forms.TextBox();
            this.labelHI = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drop_down_menu,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // drop_down_menu
            // 
            this.drop_down_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.drop_down_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnNew,
            this.menubtnOpen,
            this.menubtnSave,
            this.menubtnSaveAs,
            this.toolStripSeparator1,
            this.menubtnExit});
            this.drop_down_menu.Name = "drop_down_menu";
            this.drop_down_menu.Size = new System.Drawing.Size(37, 20);
            this.drop_down_menu.Text = "File";
            // 
            // menubtnNew
            // 
            this.menubtnNew.Name = "menubtnNew";
            this.menubtnNew.Size = new System.Drawing.Size(180, 22);
            this.menubtnNew.Text = "New";
            this.menubtnNew.Click += new System.EventHandler(this.menubtnNew_Click);
            this.menubtnNew.MouseHover += new System.EventHandler(this.menubtnNew_MouseHover);
            // 
            // menubtnOpen
            // 
            this.menubtnOpen.Name = "menubtnOpen";
            this.menubtnOpen.Size = new System.Drawing.Size(126, 22);
            this.menubtnOpen.Text = "Open";
            this.menubtnOpen.Click += new System.EventHandler(this.menubtnOpen_Click);
            // 
            // menubtnSave
            // 
            this.menubtnSave.Name = "menubtnSave";
            this.menubtnSave.Size = new System.Drawing.Size(126, 22);
            this.menubtnSave.Text = "Save";
            this.menubtnSave.Click += new System.EventHandler(this.menubtnSave_Click);
            // 
            // menubtnSaveAs
            // 
            this.menubtnSaveAs.Name = "menubtnSaveAs";
            this.menubtnSaveAs.Size = new System.Drawing.Size(126, 22);
            this.menubtnSaveAs.Text = "Save As... ";
            this.menubtnSaveAs.Click += new System.EventHandler(this.menubtnSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // menubtnExit
            // 
            this.menubtnExit.Name = "menubtnExit";
            this.menubtnExit.Size = new System.Drawing.Size(126, 22);
            this.menubtnExit.Text = "Exit";
            this.menubtnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // footer
            // 
            this.footer.Controls.Add(this.checkbox_true);
            this.footer.Controls.Add(this.numericUpDown1);
            this.footer.Controls.Add(this.button3);
            this.footer.Controls.Add(this.btnAdd);
            this.footer.Controls.Add(this.btnDel);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 461);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(801, 100);
            this.footer.TabIndex = 1;
            this.footer.TabStop = false;
            // 
            // checkbox_true
            // 
            this.checkbox_true.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkbox_true.AutoSize = true;
            this.checkbox_true.Location = new System.Drawing.Point(381, 23);
            this.checkbox_true.Name = "checkbox_true";
            this.checkbox_true.Size = new System.Drawing.Size(63, 17);
            this.checkbox_true.TabIndex = 6;
            this.checkbox_true.Text = "Истина";
            this.checkbox_true.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(255, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(174, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(93, 19);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbVoprosy
            // 
            this.tbVoprosy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVoprosy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVoprosy.Location = new System.Drawing.Point(0, 24);
            this.tbVoprosy.Multiline = true;
            this.tbVoprosy.Name = "tbVoprosy";
            this.tbVoprosy.Size = new System.Drawing.Size(801, 437);
            this.tbVoprosy.TabIndex = 2;
            // 
            // labelHI
            // 
            this.labelHI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHI.BackColor = System.Drawing.Color.Cyan;
            this.labelHI.Font = new System.Drawing.Font("Arial Narrow", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHI.Location = new System.Drawing.Point(0, 24);
            this.labelHI.Name = "labelHI";
            this.labelHI.Padding = new System.Windows.Forms.Padding(0, 0, 50, 50);
            this.labelHI.Size = new System.Drawing.Size(801, 437);
            this.labelHI.TabIndex = 3;
            this.labelHI.Text = "^\r\n||\r\n||\r\nПривет, для продолжения работы воспользуйся меню.\r\nВы видите это окно " +
    "только для демонстрации цвета, мне лень делать темную тему.\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 561);
            this.Controls.Add(this.labelHI);
            this.Controls.Add(this.tbVoprosy);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор вопросов для: верю/не верю";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drop_down_menu;
        private System.Windows.Forms.ToolStripMenuItem menubtnNew;
        private System.Windows.Forms.ToolStripMenuItem menubtnOpen;
        private System.Windows.Forms.ToolStripMenuItem menubtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menubtnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menubtnExit;
        private System.Windows.Forms.GroupBox footer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbVoprosy;
        private System.Windows.Forms.CheckBox checkbox_true;
        private System.Windows.Forms.Label labelHI;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

