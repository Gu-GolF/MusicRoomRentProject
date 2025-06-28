namespace MusicRoomRentProject
{
    partial class FrmMusicRoomRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusicRoomRent));
            this.lvAllData = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDrum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.tbKeyboard = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBass = new System.Windows.Forms.TextBox();
            this.cbKeyboard = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBass = new System.Windows.Forms.CheckBox();
            this.tbGuitar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGuitar = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rdoUnpaid = new System.Windows.Forms.RadioButton();
            this.rdoPaid = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btCalcutor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAllData
            // 
            this.lvAllData.BackColor = System.Drawing.Color.SkyBlue;
            this.lvAllData.Font = new System.Drawing.Font("Itim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lvAllData.ForeColor = System.Drawing.Color.OrangeRed;
            this.lvAllData.HideSelection = false;
            this.lvAllData.Location = new System.Drawing.Point(546, 169);
            this.lvAllData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAllData.Name = "lvAllData";
            this.lvAllData.Size = new System.Drawing.Size(559, 665);
            this.lvAllData.TabIndex = 1;
            this.lvAllData.UseCompatibleStateImageBehavior = false;
            this.lvAllData.ItemActivate += new System.EventHandler(this.lvAllData_ItemActivate);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Itim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อผู้เช่า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Itim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(49, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "เบอร์ติดต่อ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDrum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbDrum);
            this.groupBox1.Controls.Add(this.tbKeyboard);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbBass);
            this.groupBox1.Controls.Add(this.cbKeyboard);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbBass);
            this.groupBox1.Controls.Add(this.tbGuitar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbHour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbGuitar);
            this.groupBox1.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(45, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลการเช่า";
            // 
            // tbDrum
            // 
            this.tbDrum.Location = new System.Drawing.Point(177, 218);
            this.tbDrum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDrum.Name = "tbDrum";
            this.tbDrum.Size = new System.Drawing.Size(117, 23);
            this.tbDrum.TabIndex = 21;
            this.tbDrum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDrum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDrum_KeyPress);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(309, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "ตัว (30 บาท/ชุด)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbDrum.Location = new System.Drawing.Point(19, 218);
            this.cbDrum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(102, 19);
            this.cbDrum.TabIndex = 19;
            this.cbDrum.Text = "กลอง จำนวน";
            this.cbDrum.UseVisualStyleBackColor = true;
            this.cbDrum.CheckedChanged += new System.EventHandler(this.cbDrum_CheckedChanged);
            // 
            // tbKeyboard
            // 
            this.tbKeyboard.Location = new System.Drawing.Point(177, 178);
            this.tbKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKeyboard.Name = "tbKeyboard";
            this.tbKeyboard.Size = new System.Drawing.Size(117, 23);
            this.tbKeyboard.TabIndex = 18;
            this.tbKeyboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKeyboard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyboard_KeyPress);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(309, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "ตัว (10 บาท/ตัว)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBass
            // 
            this.tbBass.Location = new System.Drawing.Point(177, 142);
            this.tbBass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBass.Name = "tbBass";
            this.tbBass.Size = new System.Drawing.Size(117, 23);
            this.tbBass.TabIndex = 18;
            this.tbBass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBass_KeyPress);
            // 
            // cbKeyboard
            // 
            this.cbKeyboard.AutoSize = true;
            this.cbKeyboard.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbKeyboard.Location = new System.Drawing.Point(19, 178);
            this.cbKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKeyboard.Name = "cbKeyboard";
            this.cbKeyboard.Size = new System.Drawing.Size(121, 19);
            this.cbKeyboard.TabIndex = 16;
            this.cbKeyboard.Text = "คีย์บอร์ด จำนวน";
            this.cbKeyboard.UseVisualStyleBackColor = true;
            this.cbKeyboard.CheckedChanged += new System.EventHandler(this.cbKeyboard_CheckedChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(309, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "ตัว (15 บาท/ตัว)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBass
            // 
            this.cbBass.AutoSize = true;
            this.cbBass.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbBass.Location = new System.Drawing.Point(19, 142);
            this.cbBass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBass.Name = "cbBass";
            this.cbBass.Size = new System.Drawing.Size(93, 19);
            this.cbBass.TabIndex = 16;
            this.cbBass.Text = "เบส จำนวน";
            this.cbBass.UseVisualStyleBackColor = true;
            this.cbBass.CheckedChanged += new System.EventHandler(this.cbBass_CheckedChanged);
            // 
            // tbGuitar
            // 
            this.tbGuitar.Location = new System.Drawing.Point(177, 110);
            this.tbGuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGuitar.Name = "tbGuitar";
            this.tbGuitar.Size = new System.Drawing.Size(117, 23);
            this.tbGuitar.TabIndex = 15;
            this.tbGuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGuitar_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(309, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "ตัว (20 บาท/ตัว)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(309, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "ชั่วโมง";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(194, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "80";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(177, 66);
            this.tbHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(117, 23);
            this.tbHour.TabIndex = 11;
            this.tbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHour_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(11, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "จำนวนชั่วโมงที่เช่า";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(286, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "บาท/ชั่วโมง";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(57, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "ค่าเช่าห้อง";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGuitar
            // 
            this.cbGuitar.AutoSize = true;
            this.cbGuitar.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbGuitar.Location = new System.Drawing.Point(19, 110);
            this.cbGuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGuitar.Name = "cbGuitar";
            this.cbGuitar.Size = new System.Drawing.Size(102, 19);
            this.cbGuitar.TabIndex = 7;
            this.cbGuitar.Text = "กีตาร์ จำนวน";
            this.cbGuitar.UseVisualStyleBackColor = true;
            this.cbGuitar.CheckedChanged += new System.EventHandler(this.cbGuitar_CheckedChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(161, 126);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(330, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(161, 169);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(330, 22);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label13.Location = new System.Drawing.Point(683, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 41);
            this.label13.TabIndex = 7;
            this.label13.Text = "ข้อมูลการเช่าห้องซ้อมดนตรี";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(52, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 23);
            this.label14.TabIndex = 22;
            this.label14.Text = "จำนวนเงินที่ต้องชำระ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.Cyan;
            this.lbTotal.Font = new System.Drawing.Font("Itim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTotal.Location = new System.Drawing.Point(203, 505);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(151, 48);
            this.lbTotal.TabIndex = 22;
            this.lbTotal.Text = "00.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(381, 517);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 22;
            this.label16.Text = "บาท";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoUnpaid
            // 
            this.rdoUnpaid.AutoSize = true;
            this.rdoUnpaid.Checked = true;
            this.rdoUnpaid.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdoUnpaid.Location = new System.Drawing.Point(161, 567);
            this.rdoUnpaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoUnpaid.Name = "rdoUnpaid";
            this.rdoUnpaid.Size = new System.Drawing.Size(86, 19);
            this.rdoUnpaid.TabIndex = 23;
            this.rdoUnpaid.TabStop = true;
            this.rdoUnpaid.Text = "ยังไม่ชำระ";
            this.rdoUnpaid.UseVisualStyleBackColor = true;
            // 
            // rdoPaid
            // 
            this.rdoPaid.AutoSize = true;
            this.rdoPaid.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdoPaid.Location = new System.Drawing.Point(297, 567);
            this.rdoPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoPaid.Name = "rdoPaid";
            this.rdoPaid.Size = new System.Drawing.Size(80, 19);
            this.rdoPaid.TabIndex = 24;
            this.rdoPaid.Text = "ชำระแล้ว";
            this.rdoPaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Itim", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1139, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรมเช่าห้องซ้อมดนตรี";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::MusicRoomRentProject.Properties.Resources.icon_ยกเลิก;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.Location = new System.Drawing.Point(45, 763);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(445, 71);
            this.btCancel.TabIndex = 30;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSave.Image = global::MusicRoomRentProject.Properties.Resources.icon_add1;
            this.btSave.Location = new System.Drawing.Point(47, 682);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(132, 73);
            this.btSave.TabIndex = 29;
            this.btSave.Text = "บันทึกเพิ่มข้อมูล";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDelete.Image = global::MusicRoomRentProject.Properties.Resources.icon_ลบข้อมูล;
            this.btDelete.Location = new System.Drawing.Point(359, 682);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(132, 73);
            this.btDelete.TabIndex = 28;
            this.btDelete.Text = "ลบข้อมูล";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btEdit.Image = global::MusicRoomRentProject.Properties.Resources.icon_แก้ไข;
            this.btEdit.Location = new System.Drawing.Point(203, 682);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(132, 73);
            this.btEdit.TabIndex = 27;
            this.btEdit.Text = "บันทึกแก้ไขข้อมูล";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btCalcutor
            // 
            this.btCalcutor.Font = new System.Drawing.Font("Itim", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCalcutor.Image = global::MusicRoomRentProject.Properties.Resources.icon_คำนวณ;
            this.btCalcutor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalcutor.Location = new System.Drawing.Point(45, 601);
            this.btCalcutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalcutor.Name = "btCalcutor";
            this.btCalcutor.Size = new System.Drawing.Size(445, 71);
            this.btCalcutor.TabIndex = 25;
            this.btCalcutor.Text = "คำนวณค่าเช่า";
            this.btCalcutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCalcutor.UseVisualStyleBackColor = true;
            this.btCalcutor.Click += new System.EventHandler(this.btCalcutor_Click);
            // 
            // FrmMusicRoomRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1133, 846);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btCalcutor);
            this.Controls.Add(this.rdoPaid);
            this.Controls.Add(this.rdoUnpaid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvAllData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMusicRoomRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมเช่าห้องซ้อมดนตรี";
            this.Load += new System.EventHandler(this.FrmMusicRoomRent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAllData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbGuitar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDrum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.TextBox tbKeyboard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBass;
        private System.Windows.Forms.CheckBox cbKeyboard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbBass;
        private System.Windows.Forms.TextBox tbGuitar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdoUnpaid;
        private System.Windows.Forms.RadioButton rdoPaid;
        private System.Windows.Forms.Button btCalcutor;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}

