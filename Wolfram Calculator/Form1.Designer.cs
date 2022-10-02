namespace Wolfram_Calculator
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
            this.eqinput = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_eval = new System.Windows.Forms.Button();
            this.eqresult_eval = new System.Windows.Forms.MaskedTextBox();
            this.graphbox = new System.Windows.Forms.PictureBox();
            this.rbtngraph3d = new System.Windows.Forms.RadioButton();
            this.rbtnderive = new System.Windows.Forms.RadioButton();
            this.rbtnintegrate = new System.Windows.Forms.RadioButton();
            this.rbtngraph = new System.Windows.Forms.RadioButton();
            this.rbtnsolve = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.graphbox)).BeginInit();
            this.SuspendLayout();
            // 
            // eqinput
            // 
            this.eqinput.Location = new System.Drawing.Point(12, 57);
            this.eqinput.Name = "eqinput";
            this.eqinput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eqinput.Size = new System.Drawing.Size(776, 20);
            this.eqinput.TabIndex = 0;
            this.eqinput.Text = "Input equation here..";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(49, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Equation";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_eval
            // 
            this.btn_eval.Location = new System.Drawing.Point(15, 84);
            this.btn_eval.Name = "btn_eval";
            this.btn_eval.Size = new System.Drawing.Size(75, 23);
            this.btn_eval.TabIndex = 2;
            this.btn_eval.Text = "Evaluate";
            this.btn_eval.UseVisualStyleBackColor = true;
            this.btn_eval.Click += new System.EventHandler(this.btn_eval_Click);
            // 
            // eqresult_eval
            // 
            this.eqresult_eval.Location = new System.Drawing.Point(15, 114);
            this.eqresult_eval.Name = "eqresult_eval";
            this.eqresult_eval.Size = new System.Drawing.Size(773, 20);
            this.eqresult_eval.TabIndex = 3;
            this.eqresult_eval.Text = "Evaluation will be here.";
            // 
            // graphbox
            // 
            this.graphbox.Location = new System.Drawing.Point(15, 171);
            this.graphbox.Name = "graphbox";
            this.graphbox.Size = new System.Drawing.Size(100, 50);
            this.graphbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.graphbox.TabIndex = 5;
            this.graphbox.TabStop = false;
            // 
            // rbtngraph3d
            // 
            this.rbtngraph3d.AutoSize = true;
            this.rbtngraph3d.Location = new System.Drawing.Point(278, 87);
            this.rbtngraph3d.Name = "rbtngraph3d";
            this.rbtngraph3d.Size = new System.Drawing.Size(71, 17);
            this.rbtngraph3d.TabIndex = 8;
            this.rbtngraph3d.TabStop = true;
            this.rbtngraph3d.Text = "Graph 3D";
            this.rbtngraph3d.UseVisualStyleBackColor = true;
            // 
            // rbtnderive
            // 
            this.rbtnderive.AutoSize = true;
            this.rbtnderive.Location = new System.Drawing.Point(369, 87);
            this.rbtnderive.Name = "rbtnderive";
            this.rbtnderive.Size = new System.Drawing.Size(56, 17);
            this.rbtnderive.TabIndex = 9;
            this.rbtnderive.TabStop = true;
            this.rbtnderive.Text = "Derive";
            this.rbtnderive.UseVisualStyleBackColor = true;
            // 
            // rbtnintegrate
            // 
            this.rbtnintegrate.AutoSize = true;
            this.rbtnintegrate.Location = new System.Drawing.Point(460, 87);
            this.rbtnintegrate.Name = "rbtnintegrate";
            this.rbtnintegrate.Size = new System.Drawing.Size(67, 17);
            this.rbtnintegrate.TabIndex = 10;
            this.rbtnintegrate.TabStop = true;
            this.rbtnintegrate.Text = "Integrate";
            this.rbtnintegrate.UseVisualStyleBackColor = true;
            // 
            // rbtngraph
            // 
            this.rbtngraph.AutoSize = true;
            this.rbtngraph.Location = new System.Drawing.Point(187, 87);
            this.rbtngraph.Name = "rbtngraph";
            this.rbtngraph.Size = new System.Drawing.Size(54, 17);
            this.rbtngraph.TabIndex = 7;
            this.rbtngraph.TabStop = true;
            this.rbtngraph.Text = "Graph";
            this.rbtngraph.UseVisualStyleBackColor = true;
            // 
            // rbtnsolve
            // 
            this.rbtnsolve.AutoSize = true;
            this.rbtnsolve.Location = new System.Drawing.Point(96, 88);
            this.rbtnsolve.Name = "rbtnsolve";
            this.rbtnsolve.Size = new System.Drawing.Size(67, 17);
            this.rbtnsolve.TabIndex = 12;
            this.rbtnsolve.TabStop = true;
            this.rbtnsolve.Text = "Solve for";
            this.rbtnsolve.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnsolve);
            this.Controls.Add(this.rbtnintegrate);
            this.Controls.Add(this.rbtnderive);
            this.Controls.Add(this.rbtngraph3d);
            this.Controls.Add(this.rbtngraph);
            this.Controls.Add(this.graphbox);
            this.Controls.Add(this.eqresult_eval);
            this.Controls.Add(this.btn_eval);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.eqinput);
            this.Name = "Form1";
            this.Text = "Simple Wolfram Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.graphbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eqinput;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_eval;
        private System.Windows.Forms.MaskedTextBox eqresult_eval;
        private System.Windows.Forms.PictureBox graphbox;
        private System.Windows.Forms.RadioButton rbtngraph3d;
        private System.Windows.Forms.RadioButton rbtnderive;
        private System.Windows.Forms.RadioButton rbtnintegrate;
        private System.Windows.Forms.RadioButton rbtngraph;
        private System.Windows.Forms.RadioButton rbtnsolve;
    }
}

