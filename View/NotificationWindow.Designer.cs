namespace FreeCell_Project
{
    partial class NotificationWindow
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
            this.cbx80 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx100 = new System.Windows.Forms.CheckBox();
            this.cbx40 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.spnMinutes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx80
            // 
            this.cbx80.AutoSize = true;
            this.cbx80.Checked = true;
            this.cbx80.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx80.Location = new System.Drawing.Point(12, 75);
            this.cbx80.Name = "cbx80";
            this.cbx80.Size = new System.Drawing.Size(246, 17);
            this.cbx80.TabIndex = 0;
            this.cbx80.Text = "Aviso al alcanzar el 80% de carga de la bateria";
            this.cbx80.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajustes de notificaciones";
            // 
            // cbx100
            // 
            this.cbx100.AutoSize = true;
            this.cbx100.Checked = true;
            this.cbx100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx100.Location = new System.Drawing.Point(12, 52);
            this.cbx100.Name = "cbx100";
            this.cbx100.Size = new System.Drawing.Size(252, 17);
            this.cbx100.TabIndex = 2;
            this.cbx100.Text = "Aviso al alcanzar el 100% de carga de la bateria";
            this.cbx100.UseVisualStyleBackColor = true;
            // 
            // cbx40
            // 
            this.cbx40.AutoSize = true;
            this.cbx40.Checked = true;
            this.cbx40.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx40.Location = new System.Drawing.Point(12, 98);
            this.cbx40.Name = "cbx40";
            this.cbx40.Size = new System.Drawing.Size(246, 17);
            this.cbx40.TabIndex = 3;
            this.cbx40.Text = "Aviso al alcanzar el 40% de carga de la bateria";
            this.cbx40.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mostrar una notificacion cada ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "minutos al llegar al 100% de la carga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " de la bateria.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spnMinutes
            // 
            this.spnMinutes.Location = new System.Drawing.Point(162, 118);
            this.spnMinutes.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spnMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMinutes.Name = "spnMinutes";
            this.spnMinutes.Size = new System.Drawing.Size(42, 20);
            this.spnMinutes.TabIndex = 10;
            this.spnMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NotificationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(397, 216);
            this.Controls.Add(this.spnMinutes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx40);
            this.Controls.Add(this.cbx100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx80);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationWindow";
            this.Text = "Ajustes de notificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.spnMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx80;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx100;
        private System.Windows.Forms.CheckBox cbx40;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown spnMinutes;
    }
}