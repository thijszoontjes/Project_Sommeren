﻿namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            IdHeader = new System.Windows.Forms.ColumnHeader();
            NameStudentHeader = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pnlRooms = new System.Windows.Forms.Panel();
            SomerenRoomsPicture = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            KamerNummer = new System.Windows.Forms.ColumnHeader();
            Aantalbedden = new System.Windows.Forms.ColumnHeader();
            DocentORStudent = new System.Windows.Forms.ColumnHeader();
            RoomLabel = new System.Windows.Forms.Label();
            pnlLecturer = new System.Windows.Forms.Panel();
            listViewLecturers = new System.Windows.Forms.ListView();
            DocentIDHeader = new System.Windows.Forms.ColumnHeader();
            DocentNameHeader = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            pnlActivities = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ActivityListView = new System.Windows.Forms.ListView();
            IdColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            OmschrijvingcolumnHeader4 = new System.Windows.Forms.ColumnHeader();
            StartTijdcolumnHeader3 = new System.Windows.Forms.ColumnHeader();
            EindTijdcolumnHeader4 = new System.Windows.Forms.ColumnHeader();
            ActivityLabel = new System.Windows.Forms.Label();
            pnlCashRegister = new System.Windows.Forms.Panel();
            cashRegisterSubmitOrderButton = new System.Windows.Forms.Button();
            cashRegisterDrinksComboBox = new System.Windows.Forms.ComboBox();
            cashRegisterStudentComboBox = new System.Windows.Forms.ComboBox();
            listViewDrankCashRegister = new System.Windows.Forms.ListView();
            cashRegisterDrankColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            cashRegisterDrankColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            cashRegisterDrankColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            cashRegisterDrankColumnHeader4 = new System.Windows.Forms.ColumnHeader();
            cashRegisterDrankColumnHeader5 = new System.Windows.Forms.ColumnHeader();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            listViewStudentsCashRegister = new System.Windows.Forms.ListView();
            cashRegisterStudentColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            cashRegisterStudentColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            cashRegisterLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(SomerenRoomsPicture)).BeginInit();
            pnlLecturer.SuspendLayout();
            pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            pnlCashRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            dashboardToolStripMenuItem,
            studentsToolStripMenuItem,
            lecturersToolStripMenuItem,
            activitiesToolStripMenuItem,
            roomsToolStripMenuItem,
            cashRegisterToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1099, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            dashboardToolStripMenuItem1,
            exitToolStripMenuItem});
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            dashboardToolStripMenuItem.Click += new System.EventHandler(dashboardToolStripMenuItem1_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += new System.EventHandler(studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += new System.EventHandler(lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += new System.EventHandler(activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += new System.EventHandler(roomsToolStripMenuItem_Click);
            // 
            // cashRegisterToolStripMenuItem
            // 
            cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            cashRegisterToolStripMenuItem.Text = "Cash Register";
            cashRegisterToolStripMenuItem.Click += new System.EventHandler(cashRegisterToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(9, 29);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1078, 628);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(0, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1089, 621);
            pnlStudents.TabIndex = 2;
            pnlStudents.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(944, 48);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(145, 157);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            IdHeader,
            NameStudentHeader});
            listViewStudents.Location = new System.Drawing.Point(15, 51);
            listViewStudents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(924, 565);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            IdHeader.Text = "StudentId";
            // 
            // NameStudentHeader
            // 
            NameStudentHeader.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(911, 56);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(144, 161);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(SomerenRoomsPicture);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(RoomLabel);
            pnlRooms.Location = new System.Drawing.Point(9, 29);
            pnlRooms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1078, 629);
            pnlRooms.TabIndex = 3;
            // 
            // SomerenRoomsPicture
            // 
            SomerenRoomsPicture.Image = ((System.Drawing.Image)(resources.GetObject("SomerenRoomsPicture.Image")));
            SomerenRoomsPicture.Location = new System.Drawing.Point(915, 47);
            SomerenRoomsPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SomerenRoomsPicture.Name = "SomerenRoomsPicture";
            SomerenRoomsPicture.Size = new System.Drawing.Size(145, 157);
            SomerenRoomsPicture.TabIndex = 2;
            SomerenRoomsPicture.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            KamerNummer,
            Aantalbedden,
            DocentORStudent});
            listViewRooms.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            listViewRooms.Location = new System.Drawing.Point(18, 48);
            listViewRooms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(892, 564);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // KamerNummer
            // 
            KamerNummer.Tag = "";
            KamerNummer.Text = "KamerNummer";
            KamerNummer.Width = 100;
            // 
            // Aantalbedden
            // 
            Aantalbedden.Tag = "";
            Aantalbedden.Text = "Aantal Bedden";
            Aantalbedden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Aantalbedden.Width = 120;
            // 
            // DocentORStudent
            // 
            DocentORStudent.Tag = "";
            DocentORStudent.Text = "Docent?";
            // 
            // RoomLabel
            // 
            RoomLabel.AutoSize = true;
            RoomLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RoomLabel.Location = new System.Drawing.Point(15, 5);
            RoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new System.Drawing.Size(110, 41);
            RoomLabel.TabIndex = 0;
            RoomLabel.Text = "Rooms";
            // 
            // pnlLecturer
            // 
            pnlLecturer.Controls.Add(pictureBox2);
            pnlLecturer.Controls.Add(listViewLecturers);
            pnlLecturer.Controls.Add(label2);
            pnlLecturer.Location = new System.Drawing.Point(9, 32);
            pnlLecturer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new System.Drawing.Size(1077, 621);
            pnlLecturer.TabIndex = 3;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            DocentIDHeader,
            DocentNameHeader});
            listViewLecturers.Location = new System.Drawing.Point(17, 56);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 408);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // DocentIDHeader
            // 
            DocentIDHeader.Text = "DocentID";
            DocentIDHeader.Width = 150;
            // 
            // DocentNameHeader
            // 
            DocentNameHeader.Text = "DocentName";
            DocentNameHeader.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 41);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(pictureBox3);
            pnlActivities.Controls.Add(ActivityListView);
            pnlActivities.Controls.Add(ActivityLabel);
            pnlActivities.Location = new System.Drawing.Point(11, 25);
            pnlActivities.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1078, 621);
            pnlActivities.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(921, 52);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(144, 161);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // ActivityListView
            // 
            ActivityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            IdColumnHeader3,
            OmschrijvingcolumnHeader4,
            StartTijdcolumnHeader3,
            EindTijdcolumnHeader4});
            ActivityListView.Location = new System.Drawing.Point(15, 52);
            ActivityListView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ActivityListView.Name = "ActivityListView";
            ActivityListView.Size = new System.Drawing.Size(866, 565);
            ActivityListView.TabIndex = 1;
            ActivityListView.UseCompatibleStateImageBehavior = false;
            ActivityListView.View = System.Windows.Forms.View.Details;
            // 
            // IdColumnHeader3
            // 
            IdColumnHeader3.Text = "ActiviteitId";
            IdColumnHeader3.Width = 80;
            // 
            // OmschrijvingcolumnHeader4
            // 
            OmschrijvingcolumnHeader4.Text = "Omschrijving";
            OmschrijvingcolumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            OmschrijvingcolumnHeader4.Width = 150;
            // 
            // StartTijdcolumnHeader3
            // 
            StartTijdcolumnHeader3.Text = "StartTijd";
            StartTijdcolumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StartTijdcolumnHeader3.Width = 100;
            // 
            // EindTijdcolumnHeader4
            // 
            EindTijdcolumnHeader4.Text = "EindTijd";
            EindTijdcolumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            EindTijdcolumnHeader4.Width = 100;
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ActivityLabel.Location = new System.Drawing.Point(15, 5);
            ActivityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new System.Drawing.Size(165, 41);
            ActivityLabel.TabIndex = 0;
            ActivityLabel.Text = "Activiteiten";
            // 
            // pnlCashRegister
            // 
            pnlCashRegister.Controls.Add(cashRegisterSubmitOrderButton);
            pnlCashRegister.Controls.Add(cashRegisterDrinksComboBox);
            pnlCashRegister.Controls.Add(cashRegisterStudentComboBox);
            pnlCashRegister.Controls.Add(listViewDrankCashRegister);
            pnlCashRegister.Controls.Add(pictureBox4);
            pnlCashRegister.Controls.Add(listViewStudentsCashRegister);
            pnlCashRegister.Controls.Add(cashRegisterLabel);
            pnlCashRegister.Location = new System.Drawing.Point(0, 36);
            pnlCashRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlCashRegister.Name = "pnlCashRegister";
            pnlCashRegister.Size = new System.Drawing.Size(1089, 622);
            pnlCashRegister.TabIndex = 5;
            pnlCashRegister.Visible = false;
            // 
            // cashRegisterSubmitOrderButton
            // 
            cashRegisterSubmitOrderButton.Location = new System.Drawing.Point(15, 426);
            cashRegisterSubmitOrderButton.Name = "cashRegisterSubmitOrderButton";
            cashRegisterSubmitOrderButton.Size = new System.Drawing.Size(132, 58);
            cashRegisterSubmitOrderButton.TabIndex = 6;
            cashRegisterSubmitOrderButton.Text = "Submit Order";
            cashRegisterSubmitOrderButton.UseVisualStyleBackColor = true;
            // 
            // cashRegisterDrinksComboBox
            // 
            cashRegisterDrinksComboBox.FormattingEnabled = true;
            cashRegisterDrinksComboBox.Location = new System.Drawing.Point(411, 370);
            cashRegisterDrinksComboBox.Name = "cashRegisterDrinksComboBox";
            cashRegisterDrinksComboBox.Size = new System.Drawing.Size(444, 28);
            cashRegisterDrinksComboBox.TabIndex = 5;
            cashRegisterDrinksComboBox.Text = "Choose Drink";
            // 
            // cashRegisterStudentComboBox
            // 
            cashRegisterStudentComboBox.FormattingEnabled = true;
            cashRegisterStudentComboBox.Location = new System.Drawing.Point(15, 370);
            cashRegisterStudentComboBox.Name = "cashRegisterStudentComboBox";
            cashRegisterStudentComboBox.Size = new System.Drawing.Size(350, 28);
            cashRegisterStudentComboBox.TabIndex = 4;
            cashRegisterStudentComboBox.Text = "Choose Student";
            // 
            // listViewDrankCashRegister
            // 
            listViewDrankCashRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cashRegisterDrankColumnHeader1,
            cashRegisterDrankColumnHeader2,
            cashRegisterDrankColumnHeader3,
            cashRegisterDrankColumnHeader4,
            cashRegisterDrankColumnHeader5});
            listViewDrankCashRegister.Location = new System.Drawing.Point(411, 51);
            listViewDrankCashRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            listViewDrankCashRegister.Name = "listViewDrankCashRegister";
            listViewDrankCashRegister.Size = new System.Drawing.Size(444, 272);
            listViewDrankCashRegister.TabIndex = 3;
            listViewDrankCashRegister.UseCompatibleStateImageBehavior = false;
            listViewDrankCashRegister.View = System.Windows.Forms.View.Details;
            // 
            // cashRegisterDrankColumnHeader1
            // 
            cashRegisterDrankColumnHeader1.Text = "Dranknr";
            cashRegisterDrankColumnHeader1.Width = 80;
            // 
            // cashRegisterDrankColumnHeader2
            // 
            cashRegisterDrankColumnHeader2.Text = "Naam";
            cashRegisterDrankColumnHeader2.Width = 100;
            // 
            // cashRegisterDrankColumnHeader3
            // 
            cashRegisterDrankColumnHeader3.Text = "Prijs";
            // 
            // cashRegisterDrankColumnHeader4
            // 
            cashRegisterDrankColumnHeader4.Text = "Voorraad";
            cashRegisterDrankColumnHeader4.Width = 80;
            // 
            // cashRegisterDrankColumnHeader5
            // 
            cashRegisterDrankColumnHeader5.Text = "Aantal_Verkocht";
            cashRegisterDrankColumnHeader5.Width = 120;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            pictureBox4.Location = new System.Drawing.Point(944, 48);
            pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(145, 157);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewStudentsCashRegister
            // 
            listViewStudentsCashRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cashRegisterStudentColumnHeader1,
            cashRegisterStudentColumnHeader2});
            listViewStudentsCashRegister.Location = new System.Drawing.Point(15, 51);
            listViewStudentsCashRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            listViewStudentsCashRegister.Name = "listViewStudentsCashRegister";
            listViewStudentsCashRegister.Size = new System.Drawing.Size(350, 272);
            listViewStudentsCashRegister.TabIndex = 1;
            listViewStudentsCashRegister.UseCompatibleStateImageBehavior = false;
            listViewStudentsCashRegister.View = System.Windows.Forms.View.Details;
            // 
            // cashRegisterStudentColumnHeader1
            // 
            cashRegisterStudentColumnHeader1.Text = "StudentId";
            cashRegisterStudentColumnHeader1.Width = 80;
            // 
            // cashRegisterStudentColumnHeader2
            // 
            cashRegisterStudentColumnHeader2.Text = "Name";
            cashRegisterStudentColumnHeader2.Width = 100;
            // 
            // cashRegisterLabel
            // 
            cashRegisterLabel.AutoSize = true;
            cashRegisterLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cashRegisterLabel.Location = new System.Drawing.Point(13, 5);
            cashRegisterLabel.Name = "cashRegisterLabel";
            cashRegisterLabel.Size = new System.Drawing.Size(197, 41);
            cashRegisterLabel.TabIndex = 0;
            cashRegisterLabel.Text = "Cash Register";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlCashRegister);
            Controls.Add(pnlStudents);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlLecturer);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(SomerenRoomsPicture)).EndInit();
            pnlLecturer.ResumeLayout(false);
            pnlLecturer.PerformLayout();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            pnlCashRegister.ResumeLayout(false);
            pnlCashRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox SomerenRoomsPicture;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ColumnHeader KamerNummer;
        private System.Windows.Forms.ColumnHeader Aantalbedden;
        private System.Windows.Forms.ColumnHeader DocentORStudent;
        private System.Windows.Forms.ListView listViewActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewDrankCashRegister;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader NameStudentHeader;
        private System.Windows.Forms.Panel pnlLecturer;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.ColumnHeader DocentIDHeader;
        private System.Windows.Forms.ColumnHeader DocentNameHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.ListView ActivityListView;
        private System.Windows.Forms.ColumnHeader IdColumnHeader3;
        private System.Windows.Forms.ColumnHeader OmschrijvingcolumnHeader4;
        private System.Windows.Forms.ColumnHeader StartTijdcolumnHeader3;
        private System.Windows.Forms.ColumnHeader EindTijdcolumnHeader4;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCashRegister;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewStudentsCashRegister;
        private System.Windows.Forms.ColumnHeader cashRegisterStudentColumnHeader1;
        private System.Windows.Forms.ColumnHeader cashRegisterStudentColumnHeader2;
        private System.Windows.Forms.Label cashRegisterLabel;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader1;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader2;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader3;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader4;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader5;
        private System.Windows.Forms.Button cashRegisterSubmitOrderButton;
        private System.Windows.Forms.ComboBox cashRegisterDrinksComboBox;
        private System.Windows.Forms.ComboBox cashRegisterStudentComboBox;
    }
}