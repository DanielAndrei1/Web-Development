namespace Elevator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Log;
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.GoingUp = new System.Windows.Forms.Timer(this.components);
            this.GoingDown = new System.Windows.Forms.Timer(this.components);
            this.CloseDoorsLv1 = new System.Windows.Forms.Timer(this.components);
            this.CloseDoorsLv0 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.LeftDoorlv0 = new System.Windows.Forms.PictureBox();
            this.RightDoorlv0 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.leftdoor = new System.Windows.Forms.PictureBox();
            this.rightdoor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.blanklv1 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.blankpanelcontrol = new System.Windows.Forms.PictureBox();
            this.ElectricalPanelLv0F1 = new System.Windows.Forms.PictureBox();
            this.ElectricPanelLv0G = new System.Windows.Forms.PictureBox();
            this.ElectricalPanelLv1F0 = new System.Windows.Forms.PictureBox();
            this.ElectricalPanelLv1F1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OpenDoorLv0 = new System.Windows.Forms.Timer(this.components);
            this.OpenDoorLv1 = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.OpenDoors = new System.Windows.Forms.PictureBox();
            this.CloseDoors = new System.Windows.Forms.PictureBox();
            this.arrowupcp = new System.Windows.Forms.PictureBox();
            this.arrowdowncp = new System.Windows.Forms.PictureBox();
            this.blanksigncp = new System.Windows.Forms.PictureBox();
            this.lv1sign = new System.Windows.Forms.PictureBox();
            this.lv0sign = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.DataSet = new System.Windows.Forms.DataGridView();
            this.elevatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new Elevator.DatabaseDataSet1();
            this.elevatorTableAdapter2 = new Elevator.DatabaseDataSet1TableAdapters.ElevatorTableAdapter();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Log = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoorlv0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoorlv0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanklv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankpanelcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricalPanelLv0F1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricPanelLv0G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricalPanelLv1F0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricalPanelLv1F1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenDoors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseDoors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupcp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdowncp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksigncp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lv1sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lv0sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // GoingUp
            // 
            this.GoingUp.Interval = 30;
            this.GoingUp.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GoingDown
            // 
            this.GoingDown.Interval = 30;
            this.GoingDown.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CloseDoorsLv1
            // 
            this.CloseDoorsLv1.Interval = 30;
            this.CloseDoorsLv1.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // CloseDoorsLv0
            // 
            this.CloseDoorsLv0.Interval = 30;
            this.CloseDoorsLv0.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(163, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.LeftDoorlv0);
            this.groupBox1.Controls.Add(this.RightDoorlv0);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.leftdoor);
            this.groupBox1.Controls.Add(this.rightdoor);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.blanklv1);
            this.groupBox1.Controls.Add(this.pictureBox14);
            this.groupBox1.Controls.Add(this.pictureBox13);
            this.groupBox1.Controls.Add(this.blankpanelcontrol);
            this.groupBox1.Controls.Add(this.ElectricalPanelLv0F1);
            this.groupBox1.Controls.Add(this.ElectricPanelLv0G);
            this.groupBox1.Controls.Add(this.ElectricalPanelLv1F0);
            this.groupBox1.Controls.Add(this.ElectricalPanelLv1F1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 664);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox11.Image = global::Elevator.Properties.Resources.liftupgif;
            this.pictureBox11.Location = new System.Drawing.Point(306, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(11, 14);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Visible = false;
            // 
            // LeftDoorlv0
            // 
            this.LeftDoorlv0.Image = global::Elevator.Properties.Resources.ElevatorLeft;
            this.LeftDoorlv0.Location = new System.Drawing.Point(209, 382);
            this.LeftDoorlv0.Name = "LeftDoorlv0";
            this.LeftDoorlv0.Size = new System.Drawing.Size(108, 259);
            this.LeftDoorlv0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftDoorlv0.TabIndex = 5;
            this.LeftDoorlv0.TabStop = false;
            // 
            // RightDoorlv0
            // 
            this.RightDoorlv0.Image = global::Elevator.Properties.Resources.ElevatorRight;
            this.RightDoorlv0.Location = new System.Drawing.Point(312, 382);
            this.RightDoorlv0.Name = "RightDoorlv0";
            this.RightDoorlv0.Size = new System.Drawing.Size(108, 259);
            this.RightDoorlv0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightDoorlv0.TabIndex = 6;
            this.RightDoorlv0.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Elevator.Properties.Resources.ElevatorLeft;
            this.pictureBox3.Location = new System.Drawing.Point(209, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 259);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Elevator.Properties.Resources.ElevatorRight;
            this.pictureBox4.Location = new System.Drawing.Point(312, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 259);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // leftdoor
            // 
            this.leftdoor.Image = global::Elevator.Properties.Resources.elevatordoor;
            this.leftdoor.Location = new System.Drawing.Point(223, 395);
            this.leftdoor.Name = "leftdoor";
            this.leftdoor.Size = new System.Drawing.Size(94, 245);
            this.leftdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftdoor.TabIndex = 5;
            this.leftdoor.TabStop = false;
            // 
            // rightdoor
            // 
            this.rightdoor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightdoor.Image = global::Elevator.Properties.Resources.elevatordoor;
            this.rightdoor.Location = new System.Drawing.Point(312, 395);
            this.rightdoor.Name = "rightdoor";
            this.rightdoor.Size = new System.Drawing.Size(86, 245);
            this.rightdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightdoor.TabIndex = 26;
            this.rightdoor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elevator.Properties.Resources.Elevator_open;
            this.pictureBox1.Location = new System.Drawing.Point(209, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox8.Image = global::Elevator.Properties.Resources._200w;
            this.pictureBox8.Location = new System.Drawing.Point(306, 324);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(11, 14);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // blanklv1
            // 
            this.blanklv1.Image = global::Elevator.Properties.Resources.BlackPanellv1;
            this.blanklv1.Location = new System.Drawing.Point(274, 12);
            this.blanklv1.Name = "blanklv1";
            this.blanklv1.Size = new System.Drawing.Size(78, 19);
            this.blanklv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blanklv1.TabIndex = 23;
            this.blanklv1.TabStop = false;
            this.blanklv1.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox14.Image = global::Elevator.Properties.Resources.liftupgif;
            this.pictureBox14.Location = new System.Drawing.Point(306, 324);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(11, 14);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Visible = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox13.Image = global::Elevator.Properties.Resources._200w;
            this.pictureBox13.Location = new System.Drawing.Point(306, 12);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(11, 13);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 18;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            // 
            // blankpanelcontrol
            // 
            this.blankpanelcontrol.Image = global::Elevator.Properties.Resources.BlackPanel;
            this.blankpanelcontrol.Location = new System.Drawing.Point(274, 324);
            this.blankpanelcontrol.Name = "blankpanelcontrol";
            this.blankpanelcontrol.Size = new System.Drawing.Size(78, 19);
            this.blankpanelcontrol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blankpanelcontrol.TabIndex = 22;
            this.blankpanelcontrol.TabStop = false;
            this.blankpanelcontrol.Visible = false;
            // 
            // ElectricalPanelLv0F1
            // 
            this.ElectricalPanelLv0F1.Image = global::Elevator.Properties.Resources.level0ISign;
            this.ElectricalPanelLv0F1.Location = new System.Drawing.Point(274, 12);
            this.ElectricalPanelLv0F1.Name = "ElectricalPanelLv0F1";
            this.ElectricalPanelLv0F1.Size = new System.Drawing.Size(78, 19);
            this.ElectricalPanelLv0F1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElectricalPanelLv0F1.TabIndex = 21;
            this.ElectricalPanelLv0F1.TabStop = false;
            this.ElectricalPanelLv0F1.Visible = false;
            // 
            // ElectricPanelLv0G
            // 
            this.ElectricPanelLv0G.Image = global::Elevator.Properties.Resources.level0ISign;
            this.ElectricPanelLv0G.Location = new System.Drawing.Point(274, 324);
            this.ElectricPanelLv0G.Name = "ElectricPanelLv0G";
            this.ElectricPanelLv0G.Size = new System.Drawing.Size(78, 19);
            this.ElectricPanelLv0G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElectricPanelLv0G.TabIndex = 17;
            this.ElectricPanelLv0G.TabStop = false;
            this.ElectricPanelLv0G.Visible = false;
            // 
            // ElectricalPanelLv1F0
            // 
            this.ElectricalPanelLv1F0.Image = global::Elevator.Properties.Resources.Level1_sign1;
            this.ElectricalPanelLv1F0.Location = new System.Drawing.Point(274, 324);
            this.ElectricalPanelLv1F0.Name = "ElectricalPanelLv1F0";
            this.ElectricalPanelLv1F0.Size = new System.Drawing.Size(78, 19);
            this.ElectricalPanelLv1F0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElectricalPanelLv1F0.TabIndex = 20;
            this.ElectricalPanelLv1F0.TabStop = false;
            this.ElectricalPanelLv1F0.Visible = false;
            // 
            // ElectricalPanelLv1F1
            // 
            this.ElectricalPanelLv1F1.Image = global::Elevator.Properties.Resources.Level1_sign1;
            this.ElectricalPanelLv1F1.Location = new System.Drawing.Point(274, 12);
            this.ElectricalPanelLv1F1.Name = "ElectricalPanelLv1F1";
            this.ElectricalPanelLv1F1.Size = new System.Drawing.Size(78, 19);
            this.ElectricalPanelLv1F1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElectricalPanelLv1F1.TabIndex = 16;
            this.ElectricalPanelLv1F1.TabStop = false;
            this.ElectricalPanelLv1F1.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Elevator.Properties.Resources.schindler_73;
            this.pictureBox10.Location = new System.Drawing.Point(-85, -172);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(674, 479);
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Elevator.Properties.Resources.schindler_70;
            this.pictureBox9.Location = new System.Drawing.Point(-85, 148);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(680, 562);
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // OpenDoorLv0
            // 
            this.OpenDoorLv0.Interval = 30;
            this.OpenDoorLv0.Tick += new System.EventHandler(this.OpenDoorLv0_Tick);
            // 
            // OpenDoorLv1
            // 
            this.OpenDoorLv1.Interval = 30;
            this.OpenDoorLv1.Tick += new System.EventHandler(this.OpenDoorLv1_Tick);
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Request";
            this.dataGridViewTextBoxColumn2.HeaderText = "Request";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            this.Floor.HeaderText = "Floor";
            this.Floor.Name = "Floor";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Request
            // 
            this.Request.DataPropertyName = "Request";
            this.Request.HeaderText = "Request";
            this.Request.Name = "Request";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Floor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Floor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlPanel.BackgroundImage = global::Elevator.Properties.Resources.BackgroundControl;
            this.ControlPanel.Controls.Add(this.OpenDoors);
            this.ControlPanel.Controls.Add(this.CloseDoors);
            this.ControlPanel.Controls.Add(Log);
            this.ControlPanel.Controls.Add(this.arrowupcp);
            this.ControlPanel.Controls.Add(this.arrowdowncp);
            this.ControlPanel.Controls.Add(this.blanksigncp);
            this.ControlPanel.Controls.Add(this.lv1sign);
            this.ControlPanel.Controls.Add(this.lv0sign);
            this.ControlPanel.Controls.Add(this.pictureBox7);
            this.ControlPanel.Controls.Add(this.pictureBox6);
            this.ControlPanel.Location = new System.Drawing.Point(595, 37);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(242, 604);
            this.ControlPanel.TabIndex = 4;
            // 
            // OpenDoors
            // 
            this.OpenDoors.Image = global::Elevator.Properties.Resources.ButtonControlPanelOpen;
            this.OpenDoors.Location = new System.Drawing.Point(126, 329);
            this.OpenDoors.Name = "OpenDoors";
            this.OpenDoors.Size = new System.Drawing.Size(38, 43);
            this.OpenDoors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OpenDoors.TabIndex = 28;
            this.OpenDoors.TabStop = false;
            this.OpenDoors.Click += new System.EventHandler(this.OpenDoors_Click);
            // 
            // CloseDoors
            // 
            this.CloseDoors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseDoors.Image = global::Elevator.Properties.Resources.ButtonControlPanelClose;
            this.CloseDoors.Location = new System.Drawing.Point(82, 329);
            this.CloseDoors.Name = "CloseDoors";
            this.CloseDoors.Size = new System.Drawing.Size(38, 43);
            this.CloseDoors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseDoors.TabIndex = 5;
            this.CloseDoors.TabStop = false;
            this.CloseDoors.Click += new System.EventHandler(this.CloseDoors_Click);
            // 
            // Log
            // 
            Log.BackColor = System.Drawing.SystemColors.ButtonFace;
            Log.Location = new System.Drawing.Point(151, 501);
            Log.Name = "Log";
            Log.Size = new System.Drawing.Size(75, 23);
            Log.TabIndex = 27;
            Log.Text = "Log";
            Log.UseVisualStyleBackColor = false;
            Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // arrowupcp
            // 
            this.arrowupcp.BackColor = System.Drawing.SystemColors.InfoText;
            this.arrowupcp.Image = global::Elevator.Properties.Resources.liftupgif;
            this.arrowupcp.Location = new System.Drawing.Point(116, 186);
            this.arrowupcp.Name = "arrowupcp";
            this.arrowupcp.Size = new System.Drawing.Size(27, 23);
            this.arrowupcp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowupcp.TabIndex = 26;
            this.arrowupcp.TabStop = false;
            this.arrowupcp.Visible = false;
            // 
            // arrowdowncp
            // 
            this.arrowdowncp.BackColor = System.Drawing.SystemColors.MenuText;
            this.arrowdowncp.Image = global::Elevator.Properties.Resources._200w;
            this.arrowdowncp.Location = new System.Drawing.Point(116, 186);
            this.arrowdowncp.Name = "arrowdowncp";
            this.arrowdowncp.Size = new System.Drawing.Size(27, 23);
            this.arrowdowncp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowdowncp.TabIndex = 25;
            this.arrowdowncp.TabStop = false;
            this.arrowdowncp.Visible = false;
            // 
            // blanksigncp
            // 
            this.blanksigncp.Image = global::Elevator.Properties.Resources.blanksign;
            this.blanksigncp.Location = new System.Drawing.Point(90, 173);
            this.blanksigncp.Name = "blanksigncp";
            this.blanksigncp.Size = new System.Drawing.Size(69, 46);
            this.blanksigncp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blanksigncp.TabIndex = 5;
            this.blanksigncp.TabStop = false;
            this.blanksigncp.Visible = false;
            // 
            // lv1sign
            // 
            this.lv1sign.Image = global::Elevator.Properties.Resources.Floor1screen;
            this.lv1sign.Location = new System.Drawing.Point(92, 173);
            this.lv1sign.Name = "lv1sign";
            this.lv1sign.Size = new System.Drawing.Size(67, 46);
            this.lv1sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lv1sign.TabIndex = 29;
            this.lv1sign.TabStop = false;
            // 
            // lv0sign
            // 
            this.lv0sign.Image = global::Elevator.Properties.Resources.Groundfloorscreen;
            this.lv0sign.Location = new System.Drawing.Point(90, 173);
            this.lv0sign.Name = "lv0sign";
            this.lv0sign.Size = new System.Drawing.Size(69, 46);
            this.lv0sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lv0sign.TabIndex = 9;
            this.lv0sign.TabStop = false;
            this.lv0sign.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.Image = global::Elevator.Properties.Resources.Level1;
            this.pictureBox7.Location = new System.Drawing.Point(98, 225);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 46);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox7_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Elevator.Properties.Resources.Downlevel0;
            this.pictureBox6.Location = new System.Drawing.Point(98, 277);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            this.pictureBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox6_Paint);
            // 
            // DataSet
            // 
            this.DataSet.AutoGenerateColumns = false;
            this.DataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.DataSet.DataSource = this.elevatorBindingSource;
            this.DataSet.Location = new System.Drawing.Point(843, 48);
            this.DataSet.Name = "DataSet";
            this.DataSet.Size = new System.Drawing.Size(494, 547);
            this.DataSet.TabIndex = 4;
            this.DataSet.Visible = false;
            // 
            // elevatorBindingSource
            // 
            this.elevatorBindingSource.DataMember = "Elevator";
            this.elevatorBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elevatorTableAdapter2
            // 
            this.elevatorTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Request";
            this.dataGridViewTextBoxColumn5.HeaderText = "Request";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Floor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Floor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date and time";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date and time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 750);
            this.Controls.Add(this.DataSet);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoorlv0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoorlv0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanklv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blankpanelcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricalPanelLv0F1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricPanelLv0G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricalPanelLv1F0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricalPanelLv1F1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenDoors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseDoors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowupcp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdowncp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksigncp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lv1sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lv0sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

            }
    

            #endregion
            private System.ComponentModel.BackgroundWorker bgw;
            private System.Windows.Forms.Timer GoingUp;
            private System.Windows.Forms.Timer GoingDown;
            private System.Windows.Forms.Timer CloseDoorsLv1;
            private System.Windows.Forms.Timer CloseDoorsLv0;
            private System.Windows.Forms.PictureBox pictureBox1;
            private System.Windows.Forms.PictureBox LeftDoorlv0;
            private System.Windows.Forms.PictureBox RightDoorlv0;
            private System.Windows.Forms.PictureBox pictureBox3;
            private System.Windows.Forms.PictureBox pictureBox4;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.PictureBox pictureBox9;
            private System.Windows.Forms.PictureBox pictureBox10;
            private System.Windows.Forms.Timer timer1;
            private System.Windows.Forms.Timer OpenDoorLv0;
            private System.Windows.Forms.Timer OpenDoorLv1;
            private System.Windows.Forms.Timer Timer;
            private System.Windows.Forms.PictureBox ElectricalPanelLv1F1;
            private System.Windows.Forms.PictureBox ElectricPanelLv0G;
            public System.Windows.Forms.PictureBox pictureBox14;
            private System.Windows.Forms.PictureBox ElectricalPanelLv1F0;
            private System.Windows.Forms.PictureBox ElectricalPanelLv0F1;
            public System.Windows.Forms.PictureBox pictureBox13;
            private System.Windows.Forms.PictureBox blankpanelcontrol;
            private System.Windows.Forms.PictureBox blanklv1;
            private System.Windows.Forms.PictureBox pictureBox8;
            private System.Windows.Forms.PictureBox pictureBox11;
            private System.Windows.Forms.PictureBox pictureBox6;
            private System.Windows.Forms.PictureBox pictureBox7;
            private System.Windows.Forms.PictureBox lv0sign;
            private System.Windows.Forms.PictureBox lv1sign;
            private System.Windows.Forms.Panel ControlPanel;
            private System.Windows.Forms.PictureBox arrowdowncp;
            private System.Windows.Forms.PictureBox blanksigncp;
            private System.Windows.Forms.PictureBox arrowupcp;
            private System.Windows.Forms.PictureBox leftdoor;
            private System.Windows.Forms.PictureBox rightdoor;
            private System.Windows.Forms.BindingSource elevatorBindingSource;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
            private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
            private System.Windows.Forms.DataGridViewTextBoxColumn ID;
            private System.Windows.Forms.DataGridViewTextBoxColumn Request;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
            private System.Windows.Forms.PictureBox CloseDoors;
            private System.Windows.Forms.PictureBox OpenDoors;
        private System.Windows.Forms.DataGridView DataSet;
        private DatabaseDataSet1 databaseDataSet1;
        private DatabaseDataSet1TableAdapters.ElevatorTableAdapter elevatorTableAdapter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }

}




