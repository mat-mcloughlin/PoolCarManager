namespace PoolCarManager.Desktop
{
    partial class EditVehicleDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.journeyListView = new System.Windows.Forms.ListView();
            this.driverColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addJourneyButton = new System.Windows.Forms.Button();
            this.endMileageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startMileageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Registration:";
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Location = new System.Drawing.Point(119, 12);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(245, 20);
            this.registrationTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(119, 38);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(245, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Description:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(289, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(208, 341);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // journeyListView
            // 
            this.journeyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.driverColumnHeader,
            this.startMileageColumnHeader,
            this.endMileageColumnHeader,
            this.distanceColumnHeader});
            this.journeyListView.Location = new System.Drawing.Point(12, 64);
            this.journeyListView.Name = "journeyListView";
            this.journeyListView.Size = new System.Drawing.Size(352, 271);
            this.journeyListView.TabIndex = 6;
            this.journeyListView.UseCompatibleStateImageBehavior = false;
            this.journeyListView.View = System.Windows.Forms.View.Details;
            // 
            // driverColumnHeader
            // 
            this.driverColumnHeader.Text = "Driver";
            this.driverColumnHeader.Width = 147;
            // 
            // distanceColumnHeader
            // 
            this.distanceColumnHeader.Text = "Distance";
            this.distanceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.distanceColumnHeader.Width = 75;
            // 
            // addJourneyButton
            // 
            this.addJourneyButton.Location = new System.Drawing.Point(12, 341);
            this.addJourneyButton.Name = "addJourneyButton";
            this.addJourneyButton.Size = new System.Drawing.Size(91, 23);
            this.addJourneyButton.TabIndex = 7;
            this.addJourneyButton.Text = "&Add Journey...";
            this.addJourneyButton.UseVisualStyleBackColor = true;
            this.addJourneyButton.Click += new System.EventHandler(this.addJourneyButton_Click);
            // 
            // endMileageColumnHeader
            // 
            this.endMileageColumnHeader.Text = "End Mileage";
            this.endMileageColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.endMileageColumnHeader.Width = 75;
            // 
            // startMileageColumnHeader
            // 
            this.startMileageColumnHeader.Text = "Start Mileage";
            this.startMileageColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startMileageColumnHeader.Width = 75;
            // 
            // EditVehicleDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(376, 376);
            this.Controls.Add(this.addJourneyButton);
            this.Controls.Add(this.journeyListView);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditVehicleDialog";
            this.Text = "Edit Vehicle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditVehicleDialog_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListView journeyListView;
        private System.Windows.Forms.ColumnHeader driverColumnHeader;
        private System.Windows.Forms.ColumnHeader distanceColumnHeader;
        private System.Windows.Forms.Button addJourneyButton;
        private System.Windows.Forms.ColumnHeader startMileageColumnHeader;
        private System.Windows.Forms.ColumnHeader endMileageColumnHeader;
    }
}