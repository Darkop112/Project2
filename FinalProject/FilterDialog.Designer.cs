using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    partial class FilterDialog
    {
        private IContainer components = null;
        private DateTimePicker dateTimePicker;
        private Button okButton;
        private Button cancelButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dateTimePicker = new DateTimePicker();
            this.okButton = new Button();
            this.cancelButton = new Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MMMM yyyy";
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new Size(200, 27);
            this.dateTimePicker.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.DialogResult = DialogResult.OK;
            this.okButton.Location = new Point(56, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(75, 29);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = DialogResult.Cancel;
            this.cancelButton.Location = new Point(137, 56);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new Size(75, 29);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new EventHandler(this.cancelButton_Click);
            // 
            // FilterDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(224, 97);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "FilterDialog";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Select Date";
            this.ResumeLayout(false);
        }
    }
}

