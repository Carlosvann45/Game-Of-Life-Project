
namespace GameOfLifeProject
{
    partial class OptionsDialog
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
            this.timerIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.optionsDialogOkButton = new System.Windows.Forms.Button();
            this.optionsDialogCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.universeWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.universeHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeHeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timerIntervalNumericUpDown
            // 
            this.timerIntervalNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timerIntervalNumericUpDown.Location = new System.Drawing.Point(196, 34);
            this.timerIntervalNumericUpDown.Name = "timerIntervalNumericUpDown";
            this.timerIntervalNumericUpDown.Size = new System.Drawing.Size(126, 20);
            this.timerIntervalNumericUpDown.TabIndex = 0;
            // 
            // optionsDialogOkButton
            // 
            this.optionsDialogOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.optionsDialogOkButton.Location = new System.Drawing.Point(103, 137);
            this.optionsDialogOkButton.Name = "optionsDialogOkButton";
            this.optionsDialogOkButton.Size = new System.Drawing.Size(75, 23);
            this.optionsDialogOkButton.TabIndex = 1;
            this.optionsDialogOkButton.Text = "OK";
            this.optionsDialogOkButton.UseVisualStyleBackColor = true;
            // 
            // optionsDialogCancelButton
            // 
            this.optionsDialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.optionsDialogCancelButton.Location = new System.Drawing.Point(196, 137);
            this.optionsDialogCancelButton.Name = "optionsDialogCancelButton";
            this.optionsDialogCancelButton.Size = new System.Drawing.Size(75, 23);
            this.optionsDialogCancelButton.TabIndex = 2;
            this.optionsDialogCancelButton.Text = "Cancel";
            this.optionsDialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer Interval in Milliseconds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width of Universe in Cells";
            // 
            // universeWidthNumericUpDown
            // 
            this.universeWidthNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.universeWidthNumericUpDown.Location = new System.Drawing.Point(196, 60);
            this.universeWidthNumericUpDown.Name = "universeWidthNumericUpDown";
            this.universeWidthNumericUpDown.Size = new System.Drawing.Size(126, 20);
            this.universeWidthNumericUpDown.TabIndex = 5;
            // 
            // universeHeightNumericUpDown
            // 
            this.universeHeightNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.universeHeightNumericUpDown.Location = new System.Drawing.Point(196, 86);
            this.universeHeightNumericUpDown.Name = "universeHeightNumericUpDown";
            this.universeHeightNumericUpDown.Size = new System.Drawing.Size(126, 20);
            this.universeHeightNumericUpDown.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height of Universe in Cells";
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.optionsDialogOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.optionsDialogCancelButton;
            this.ClientSize = new System.Drawing.Size(367, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.universeHeightNumericUpDown);
            this.Controls.Add(this.universeWidthNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionsDialogCancelButton);
            this.Controls.Add(this.optionsDialogOkButton);
            this.Controls.Add(this.timerIntervalNumericUpDown);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeHeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timerIntervalNumericUpDown;
        private System.Windows.Forms.Button optionsDialogOkButton;
        private System.Windows.Forms.Button optionsDialogCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown universeWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown universeHeightNumericUpDown;
        private System.Windows.Forms.Label label3;
    }
}