namespace PoolCarManager.Desktop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolbarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.vehicleDetailsButton = new System.Windows.Forms.Button();
            this.addJourneyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehicleListView = new System.Windows.Forms.ListView();
            this.registrationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolbarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.AutoSize = true;
            this.toolbarPanel.Controls.Add(this.refreshButton);
            this.toolbarPanel.Controls.Add(this.addVehicleButton);
            this.toolbarPanel.Controls.Add(this.vehicleDetailsButton);
            this.toolbarPanel.Controls.Add(this.addJourneyButton);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(467, 29);
            this.toolbarPanel.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "&Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(84, 3);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(75, 23);
            this.addVehicleButton.TabIndex = 1;
            this.addVehicleButton.Text = "Add &Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // vehicleDetailsButton
            // 
            this.vehicleDetailsButton.Location = new System.Drawing.Point(165, 3);
            this.vehicleDetailsButton.Name = "vehicleDetailsButton";
            this.vehicleDetailsButton.Size = new System.Drawing.Size(125, 23);
            this.vehicleDetailsButton.TabIndex = 3;
            this.vehicleDetailsButton.Text = "View Vehicle &Details";
            this.vehicleDetailsButton.UseVisualStyleBackColor = true;
            this.vehicleDetailsButton.Click += new System.EventHandler(this.vehicleDetailsButton_Click);
            // 
            // addJourneyButton
            // 
            this.addJourneyButton.Location = new System.Drawing.Point(296, 3);
            this.addJourneyButton.Name = "addJourneyButton";
            this.addJourneyButton.Size = new System.Drawing.Size(75, 23);
            this.addJourneyButton.TabIndex = 2;
            this.addJourneyButton.Text = "Add &Journey";
            this.addJourneyButton.UseVisualStyleBackColor = true;
            this.addJourneyButton.Click += new System.EventHandler(this.addJourneyButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vehicleListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 322);
            this.panel1.TabIndex = 1;
            // 
            // vehicleListView
            // 
            this.vehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registrationColumnHeader,
            this.descriptionColumnHeader});
            this.vehicleListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleListView.FullRowSelect = true;
            this.vehicleListView.HideSelection = false;
            this.vehicleListView.Location = new System.Drawing.Point(0, 0);
            this.vehicleListView.Name = "vehicleListView";
            this.vehicleListView.Size = new System.Drawing.Size(467, 322);
            this.vehicleListView.SmallImageList = this.imageList1;
            this.vehicleListView.TabIndex = 0;
            this.vehicleListView.UseCompatibleStateImageBehavior = false;
            this.vehicleListView.View = System.Windows.Forms.View.Details;
            // 
            // registrationColumnHeader
            // 
            this.registrationColumnHeader.Text = "Reg No";
            this.registrationColumnHeader.Width = 136;
            // 
            // descriptionColumnHeader
            // 
            this.descriptionColumnHeader.Text = "Description";
            this.descriptionColumnHeader.Width = 164;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "car.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolbarPanel);
            this.Name = "MainForm";
            this.Text = "Pool Car Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.toolbarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel toolbarPanel;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button addJourneyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView vehicleListView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader registrationColumnHeader;
        private System.Windows.Forms.Button vehicleDetailsButton;
        private System.Windows.Forms.ColumnHeader descriptionColumnHeader;
        private System.Windows.Forms.Button refreshButton;
    }
}

