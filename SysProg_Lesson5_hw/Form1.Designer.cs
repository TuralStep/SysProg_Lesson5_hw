namespace SysProg_Lesson5_hw
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_working = new System.Windows.Forms.ListBox();
            this.lb_waiting = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_created = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upDown_places = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_places)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working threads";
            // 
            // lb_working
            // 
            this.lb_working.FormattingEnabled = true;
            this.lb_working.ItemHeight = 15;
            this.lb_working.Location = new System.Drawing.Point(12, 27);
            this.lb_working.Name = "lb_working";
            this.lb_working.Size = new System.Drawing.Size(153, 199);
            this.lb_working.TabIndex = 1;
            // 
            // lb_waiting
            // 
            this.lb_waiting.FormattingEnabled = true;
            this.lb_waiting.ItemHeight = 15;
            this.lb_waiting.Location = new System.Drawing.Point(182, 27);
            this.lb_waiting.Name = "lb_waiting";
            this.lb_waiting.Size = new System.Drawing.Size(153, 199);
            this.lb_waiting.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Waiting threads";
            // 
            // lb_created
            // 
            this.lb_created.FormattingEnabled = true;
            this.lb_created.ItemHeight = 15;
            this.lb_created.Location = new System.Drawing.Point(353, 27);
            this.lb_created.Name = "lb_created";
            this.lb_created.Size = new System.Drawing.Size(153, 199);
            this.lb_created.TabIndex = 5;
            this.lb_created.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_created_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Created threads";
            // 
            // upDown_places
            // 
            this.upDown_places.Location = new System.Drawing.Point(133, 232);
            this.upDown_places.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDown_places.Name = "upDown_places";
            this.upDown_places.Size = new System.Drawing.Size(47, 23);
            this.upDown_places.TabIndex = 6;
            this.upDown_places.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.upDown_places.ValueChanged += new System.EventHandler(this.upDown_places_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Places in semaphore";
            // 
            // btn_createThread
            // 
            this.btn_createThread.Location = new System.Drawing.Point(391, 235);
            this.btn_createThread.Name = "btn_createThread";
            this.btn_createThread.Size = new System.Drawing.Size(115, 23);
            this.btn_createThread.TabIndex = 8;
            this.btn_createThread.Text = "Create thread";
            this.btn_createThread.UseVisualStyleBackColor = true;
            this.btn_createThread.Click += new System.EventHandler(this.btn_createThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 271);
            this.Controls.Add(this.btn_createThread);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDown_places);
            this.Controls.Add(this.lb_created);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_waiting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_working);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.upDown_places)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lb_working;
        private ListBox lb_waiting;
        private Label label2;
        private ListBox lb_created;
        private Label label3;
        private NumericUpDown upDown_places;
        private Label label4;
        private Button btn_createThread;
    }
}