using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MusicRoomRentProject
{
    public partial class FrmMusicRoomRent : Form
    {
        public FrmMusicRoomRent()
        {
            InitializeComponent();
            CloseInputTextbox();
        }

        // ปิด textbox ไว้ก่อน ติ๊กเลือกอุปกรณ์ไหนค่อยให้พิมพ์
        private void CloseInputTextbox()
        {
            // กีตาร์
            tbGuitar.Enabled = cbGuitar.Checked;
            if (!cbGuitar.Checked)
            {
                tbGuitar.Text = "0";
            }

            // เบส
            tbBass.Enabled = cbBass.Checked;
            if (!cbBass.Checked)
            {
                tbBass.Text = "0";
            }

            // คีย์บอร์ด
            tbKeyboard.Enabled = cbKeyboard.Checked;
            if (!cbKeyboard.Checked)
            {
                tbKeyboard.Text = "0";
            }

            // กลอง
            tbDrum.Enabled = cbDrum.Checked;
            if (!cbDrum.Checked)
            {
                tbDrum.Text = "0";
            }
        }

        private void ClearFormFields()
        {
            // เคลียร์ TextBox 
            tbName.Clear();
            tbPhone.Clear();
            tbHour.Clear();

            // รีเซ็ต CheckBox 
            // การใช้ Clear() จะทำให้เป็นค่าว่าง ("")
            // และปิดการใช้งาน TextBox ถ้า CheckBox ไม่ได้ถูกติ๊ก
            cbGuitar.Checked = false; // ยกเลิกการเลือก CheckBox 
            tbGuitar.Clear();         // ล้าง TextBox 

            cbBass.Checked = false;   // ยกเลิกการเลือก CheckBox 
            tbBass.Clear();           // ล้าง TextBox 

            cbKeyboard.Checked = false; // ยกเลิกการเลือก CheckBox 
            tbKeyboard.Clear();        // ล้าง TextBox 

            cbDrum.Checked = false;   // ยกเลิกการเลือก CheckBox
            tbDrum.Clear();          // ล้าง TextBox 

            // รีเซ็ต Label
            lbTotal.Text = "0.00";

            // รีเซ็ต RadioButton 
            rdoUnpaid.Checked = true; // ตั้งค่าเริ่มต้นให้ "ยังไม่ชำระ" ถูกเลือก


            // เรียกใช้เมธอดนี้เพื่อรีเซ็ตสถานะ Enabled ทำให้ค่า tb เป็น 0
            CloseInputTextbox();
        }

        //สร้างเมธอดแสดงข้อความเตือน
        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // validate ข้อมูล เตรียมความพร้อมข้อมูล ถ้าตัวเลือกไหนไม่ได้ติ๊กก็ให้เติม 0
        // ควรอยู่นอก Event Handler อื่นๆ
        private bool ValidateAndPrepareData()
        {
            // --- 1. ตรวจสอบชื่อผู้เช่าและเบอร์โทรศัพท์ ---
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                showWarningMSG("กรุณาป้อนชื่อด้วย"); // หรือ MessageBox.Show(...)
                tbName.Focus();
                return false; // ส่งค่า false กลับ
            }
            else if (tbPhone.Text.Length != 10)
            {
                showWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ให้ครบ 10 หลัก");// ถ้าความยาวไม่เท่ากับ 10
                tbPhone.Focus();
                return false; // ส่งค่า false กลับ
            }

            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                showWarningMSG("กรุณาป้อนเบอร์โทรศัพท์ด้วย"); // หรือ MessageBox.Show(...)
                tbPhone.Focus();
                return false; // ส่งค่า false กลับ
            }

            // --- 2. ตรวจสอบจำนวนชั่วโมง ---
            if (string.IsNullOrWhiteSpace(tbHour.Text))
            {
                showWarningMSG("กรุณาป้อนจำนวนชั่วโมงด้วย");
                tbHour.Focus();
                return false;
            }

            // --- 3. ตรวจสอบและเตรียมข้อมูลสำหรับอุปกรณ์ (กีตาร์, เบส, คีย์บอร์ด, กลอง) ---
            // (โค้ดส่วนนี้คือส่วนที่คุณมีอยู่แล้วในเมธอด ValidateAndPrepareData() ก่อนหน้านี้)

            // กีตาร์
            if (cbGuitar.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbGuitar.Text)) { showWarningMSG("กรุณาใส่จำนวนกีตาร์ด้วย"); tbGuitar.Focus(); return false; }
                if (!int.TryParse(tbGuitar.Text, out int guitarQuantity) || guitarQuantity < 0) { showWarningMSG("จำนวนกีตาร์ต้องเป็นตัวเลขและไม่ติดลบ"); tbGuitar.Focus(); return false; }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbGuitar.Text) || !int.TryParse(tbGuitar.Text, out _)) { tbGuitar.Text = "0"; }
            }

            // เบส
            if (cbBass.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbBass.Text)) { showWarningMSG("กรุณาป้อนจำนวนเบสด้วย"); tbBass.Focus(); return false; }
                if (!int.TryParse(tbBass.Text, out int bassQuantity) || bassQuantity < 0) { showWarningMSG("จำนวนเบสต้องเป็นตัวเลขและไม่ติดลบ"); tbBass.Focus(); return false; }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbBass.Text) || !int.TryParse(tbBass.Text, out _)) { tbBass.Text = "0"; }
            }

            // คีย์บอร์ด
            if (cbKeyboard.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbKeyboard.Text)) { showWarningMSG("กรุณาป้อนจำนวนคีย์บอร์ดด้วย"); tbKeyboard.Focus(); return false; }
                if (!int.TryParse(tbKeyboard.Text, out int keyboardQuantity) || keyboardQuantity < 0) { showWarningMSG("จำนวนคีย์บอร์ดต้องเป็นตัวเลขและไม่ติดลบ"); tbKeyboard.Focus(); return false; }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbKeyboard.Text) || !int.TryParse(tbKeyboard.Text, out _)) { tbKeyboard.Text = "0"; }
            }

            // กลอง
            if (cbDrum.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbDrum.Text)) { showWarningMSG("กรุณาป้อนจำนวนกลองด้วย"); tbDrum.Focus(); return false; }
                if (!int.TryParse(tbDrum.Text, out int drumQuantity) || drumQuantity < 0) { showWarningMSG("จำนวนกลองต้องเป็นตัวเลขและไม่ติดลบ"); tbDrum.Focus(); return false; }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbDrum.Text) || !int.TryParse(tbDrum.Text, out _)) { tbDrum.Text = "0"; }
            }


            // ถ้าผ่านการตรวจสอบทั้งหมด
            return true;
        }



        // เมธอดนี้ใช้ดึงข้อมูลจากฐานข้อมูล musicrent_db และแสดงผลใน ListView
        private void getAllDataToLV()
        {
            // กำหนด connection string สำหรับเชื่อมต่อกับฐานข้อมูล SQL Server
            string connectionstring = @"server=DESKTOP-HMDSMC8\SQLEXPRESS;Database=musicrent_db;Trusted_Connection=True;";

            // สร้างอ็อบเจกต์ SqlConnection และใช้คำสั่ง using เพื่อให้ปิดการเชื่อมต่ออัตโนมัติเมื่อใช้เสร็จ
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                try
                {
                    sqlConnection.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                    // เขียนคำสั่ง SQL เพื่อดึงข้อมูลทั้งหมดจากตาราง musicroom_tb
                    string strSQL = "SELECT rentId,rentName,rentPhone,rentHour,guitar,base,keyboard,drum,rentPay,payStatus FROM musicroom_tb";

                    // ใช้ SqlDataAdapter เพื่อดึงข้อมูลมาใส่ใน DataTable
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        // สร้าง DataTable เพื่อเก็บข้อมูลที่ดึงมาจากฐานข้อมูล
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // ดึงข้อมูลมาใส่ใน dataTable

                        // ตั้งค่า ListView ก่อนแสดงผล
                        lvAllData.Items.Clear();        // ล้างข้อมูลเดิมใน ListView
                        lvAllData.Columns.Clear();      // ลบ column เดิม (ถ้ามี)
                        lvAllData.FullRowSelect = true; // ให้เลือกทั้งแถว
                        lvAllData.View = View.Details;  // แสดงแบบตาราง (รายละเอียดหลาย column)

                        // สร้าง column ให้ ListView ตรงกับข้อมูลในฐานข้อมูล
                        lvAllData.Columns.Add("รหัสการเช่า", 50, HorizontalAlignment.Left);
                        lvAllData.Columns.Add("ชื่อผู้เช่า", 100, HorizontalAlignment.Left);
                        lvAllData.Columns.Add("เบอร์โทรศัพท์", 80, HorizontalAlignment.Left);
                        lvAllData.Columns.Add("ชั่วโมง", 50, HorizontalAlignment.Center);
                        lvAllData.Columns.Add("กีตาร์", 50, HorizontalAlignment.Center);
                        lvAllData.Columns.Add("เบส", 50, HorizontalAlignment.Center);
                        lvAllData.Columns.Add("คีย์บอร์ด", 50, HorizontalAlignment.Center);
                        lvAllData.Columns.Add("กลอง", 50, HorizontalAlignment.Center);
                        lvAllData.Columns.Add("ค่าเช่า", 50, HorizontalAlignment.Center);
                        lvAllData.Columns.Add("สถานะ", 50, HorizontalAlignment.Center);

                        // วนลูปแถวจาก DataTable เพื่อแสดงใน ListView ทีละรายการ
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            // สร้างรายการใหม่ใน ListView โดยใช้ rentId เป็น column แรก
                            ListViewItem item = new ListViewItem(dataRow["rentId"].ToString());

                            // เพิ่มข้อมูลอื่นๆ ลงในคอลัมน์ต่อๆ ไป
                            item.SubItems.Add(dataRow["rentName"].ToString());
                            item.SubItems.Add(dataRow["rentPhone"].ToString());
                            item.SubItems.Add(dataRow["rentHour"].ToString());
                            item.SubItems.Add(dataRow["guitar"].ToString());
                            item.SubItems.Add(dataRow["base"].ToString());
                            item.SubItems.Add(dataRow["keyboard"].ToString());
                            item.SubItems.Add(dataRow["drum"].ToString());
                            item.SubItems.Add(dataRow["rentPay"].ToString());
                            item.SubItems.Add(dataRow["payStatus"].ToString());

                            // นำข้อมูลแต่ละรายการมาเพิ่มใน ListView
                            lvAllData.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // หากเกิดข้อผิดพลาด ให้แสดงข้อความแจ้งเตือน
                    MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        // เมธอดนี้จะถูกเรียกเมื่อฟอร์มเปิดขึ้น โดยเรียก getAllDataToLV() เพื่อโหลดข้อมูลทันที
        private void FrmMusicRoomRent_Load(object sender, EventArgs e)
        {
            getAllDataToLV(); // ดึงข้อมูลจากฐานข้อมูลมาแสดง
        }

        private void lvAllData_ItemActivate(object sender, EventArgs e)
        {
            if (lvAllData.SelectedItems.Count > 0)
            {
                // รับรายการที่ถูกเลือกรายการแรก
                ListViewItem selectedItem = lvAllData.SelectedItems[0];

                // ดึงข้อมูลจาก SubItems และกำหนดให้กับ TextBox ที่เกี่ยวข้อง
                // Index ของ SubItems จะตรงกับลำดับคอลัมน์ใน ListView

                // ชื่อ (คอลัมน์ที่ 2, Index 1)
                if (selectedItem.SubItems.Count > 1)
                {
                    tbName.Text = selectedItem.SubItems[1].Text;
                }
                else
                {
                    tbName.Text = string.Empty; // เคลียร์ค่าถ้าไม่มีข้อมูล
                }

                // เบอร์โทรศัพท์ (คอลัมน์ที่ 3, Index 2)
                if (selectedItem.SubItems.Count > 2)
                {
                    tbPhone.Text = selectedItem.SubItems[2].Text;
                }
                else
                {
                    tbPhone.Text = string.Empty;
                }

                // จำนวนชั่วโมง (คอลัมน์ที่ 4, Index 3)
                if (selectedItem.SubItems.Count > 3)
                {
                    tbHour.Text = selectedItem.SubItems[3].Text;
                }
                else
                {
                    tbHour.Text = string.Empty;
                }

                // จำนวนกีตาร์ (คอลัมน์ที่ 5, Index 4)
                if (selectedItem.SubItems.Count > 4)
                {
                    string guitarValue = selectedItem.SubItems[4].Text;
                    tbGuitar.Text = guitarValue;
                    // แปลงเป็นตัวเลข ถ้าแปลงได้และค่า > 0 ให้ติ๊ก CheckBox
                    int guitarQuantity;
                    if (int.TryParse(guitarValue, out guitarQuantity) && guitarQuantity > 0)
                    {
                        cbGuitar.Checked = true;
                    }
                    else
                    {
                        cbGuitar.Checked = false; // เคลียร์ CheckBox ถ้าไม่มีข้อมูล
                    }
                }
                else
                {
                    tbGuitar.Text = string.Empty;
                }

                // จำนวนเบส (คอลัมน์ที่ 6, Index 5)
                if (selectedItem.SubItems.Count > 5)
                {
                    string bassValue = selectedItem.SubItems[5].Text;
                    tbBass.Text = bassValue;
                    // CheckBox สำหรับเบส
                    // แปลงเป็นตัวเลข ถ้าแปลงได้และค่า > 0 ให้ติ๊ก CheckBox
                    int bassQuantity;
                    if (int.TryParse(bassValue, out bassQuantity) && bassQuantity > 0)
                    {
                        cbBass.Checked = true;
                    }
                    else
                    {
                        cbBass.Checked = false;  // เคลียร์ CheckBox ถ้าไม่มีข้อมูล
                    }
                }
                else
                {
                    tbBass.Text = string.Empty;
                }

                // จำนวนคีย์บอร์ด (คอลัมน์ที่ 7, Index 6 - ถ้ามีใน ListView)
                if (selectedItem.SubItems.Count > 6)
                {
                    string keyboardValue = selectedItem.SubItems[6].Text; // Corrected Index to 6
                    tbKeyboard.Text = keyboardValue;
                    // CheckBox สำหรับคีย์บอร์ด
                    // แปลงเป็นตัวเลข ถ้าแปลงได้และค่า > 0 ให้ติ๊ก CheckBox
                    int keyboardQuantity;
                    if (int.TryParse(keyboardValue, out keyboardQuantity) && keyboardQuantity > 0)
                    {
                        cbKeyboard.Checked = true;
                    }
                    else
                    {
                        cbKeyboard.Checked = false;  // เคลียร์ CheckBox ถ้าไม่มีข้อมูล
                    }
                }
                else
                {
                    tbKeyboard.Text = string.Empty;
                }

                // จำนวนกลอง (คอลัมน์ที่ 8, Index 7 - ถ้ามีใน ListView)
                if (selectedItem.SubItems.Count > 7)
                {
                    string drumValue = selectedItem.SubItems[7].Text; // Corrected Index to 7
                    tbDrum.Text = drumValue;
                    // CheckBox สำหรับกลอง
                    int drumQuantity;
                    if (int.TryParse(drumValue, out drumQuantity) && drumQuantity > 0)
                    {
                        cbDrum.Checked = true;
                    }
                    else
                    {
                        cbDrum.Checked = false;  // เคลียร์ CheckBox ถ้าไม่มีข้อมูล
                    }
                }
                else
                {
                    tbDrum.Text = string.Empty;
                }

            }
            else // ไม่มีรายการใดถูกเลือก
            {
                // เคลียร์ TextBox และ CheckBox ทั้งหมด
                ClearFormFields();
            }

        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (char.IsDigit(e.KeyChar))
            {
                // ตรวจสอบความยาวของข้อความใน TextBox
                if (((TextBox)sender).Text.Length < 10 || e.KeyChar == (char)Keys.Back || ((TextBox)sender).SelectedText.Length > 0)
                {
                    e.Handled = false; // ยอมให้พิมพ์ตัวเลขได้
                }
                else
                {
                    e.Handled = true; // ป้องกันการป้อน ถ้าเกิน 10 ตัวแล้ว
                }
            }
            // อนุญาตให้ใช้ backspace ได้เสมอ
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            // ถ้าไม่ใช่ตัวเลข หรือ backspace ป้องกันการป้อน
            else
            {
                e.Handled = true;
            }
        }

        private void tbHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // อนุญาตให้กด backspace ได้เสมอ
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            // ถ้าเป็นตัวเลข
            if (char.IsDigit(e.KeyChar))
            {
                // ถ้ามีจุดทศนิยมแล้ว ต้องเช็คว่าพิมพ์ไปกี่หลักแล้ว
                if (textBox.Text.Contains("."))
                {
                    int index = textBox.Text.IndexOf(".");
                    string decimalPart = textBox.Text.Substring(index + 1);

                    // ถ้าพิมพ์ตำแหน่งหลังจุดเกิน 2 ตัว = ไม่ให้พิมพ์เพิ่ม
                    if (textBox.SelectionStart > index && decimalPart.Length >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                e.Handled = false; // อนุญาตให้พิมพ์ตัวเลข
            }

            // ถ้าเป็นจุดทศนิยม
            else if (e.KeyChar == '.')
            {
                // ถ้ามีจุดอยู่แล้ว ไม่ให้พิมพ์ซ้ำ
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false; // อนุญาตให้พิมพ์จุดได้ 1 จุด
                }
            }

            // ถ้าไม่ใช่ตัวเลข จุด หรือ backspace = ป้องกันการพิมพ์
            else
            {
                e.Handled = true;
            }
        }

        private void tbGuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false; // ยอมให้พิมพ์ตัวเลขได้
            }
            // อนุญาตให้ใช้ backspace ได้เสมอ
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            // ถ้าไม่ใช่ตัวเลข หรือ backspace ป้องกันการป้อน
            else
            {
                e.Handled = true;
            }
        }


        private void tbBass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false; // ยอมให้พิมพ์ตัวเลขได้
            }
            // อนุญาตให้ใช้ backspace ได้เสมอ
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            // ถ้าไม่ใช่ตัวเลข หรือ backspace ป้องกันการป้อน
            else
            {
                e.Handled = true;
            }
        }

        private void tbKeyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false; // ยอมให้พิมพ์ตัวเลขได้
            }
            // อนุญาตให้ใช้ backspace ได้เสมอ
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            // ถ้าไม่ใช่ตัวเลข หรือ backspace ป้องกันการป้อน
            else
            {
                e.Handled = true;
            }
        }

        private void tbDrum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false; // ยอมให้พิมพ์ตัวเลขได้
            }
            // อนุญาตให้ใช้ backspace ได้เสมอ
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            // ถ้าไม่ใช่ตัวเลข หรือ backspace ป้องกันการป้อน
            else
            {
                e.Handled = true;
            }
        }


        //เมื่อติ๊ก แล้ว ถึงจะพิมพ์ได้
        //กีตาร์
        private void cbGuitar_CheckedChanged(object sender, EventArgs e)
        {
            tbGuitar.Enabled = cbGuitar.Checked;
            if (!cbGuitar.Checked)
            {
                tbGuitar.Text = "0";
            }
            else
            {
                tbGuitar.Focus();
            }
        }

        //เบส
        private void cbBass_CheckedChanged(object sender, EventArgs e)
        {
            tbBass.Enabled = cbBass.Checked;
            if (!cbBass.Checked)
            {
                tbBass.Text = "0";
            }
            else
            {
                tbBass.Focus();
            }
        }

        // คีย์บอร์ด
        private void cbKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            tbKeyboard.Enabled = cbKeyboard.Checked;
            if (!cbKeyboard.Checked)
            {
                tbKeyboard.Text = "0";
            }
            else
            {
                tbKeyboard.Focus();
            }
        }

        // กลอง
        private void cbDrum_CheckedChanged(object sender, EventArgs e)
        {
            tbDrum.Enabled = cbDrum.Checked;
            if (!cbDrum.Checked)
            {
                tbDrum.Text = "0";
            }
            else
            {
                tbDrum.Focus();
            }
        }


        private void btCalcutor_Click(object sender, EventArgs e)
        {

            // เรียกใช้ฟังก์ชัน ValidateAndPrepareData()
            if (ValidateAndPrepareData())
            {
                // ถ้า ValidateAndPrepareData() คืนค่า true (ข้อมูลถูกต้องทั้งหมด)
                // คุณสามารถดำเนินการคำนวณหรือบันทึกลงฐานข้อมูลได้ที่นี่
                MessageBox.Show("คำนวณเสร็จสิ้น กรุณากดปุ่มบันทึก!");


                double total = 0;
                //คำนวณค่าเช่า
                //ชั่วโมง
                if (double.TryParse(tbHour.Text, out double hours))
                {
                    total = total + (hours * 80);
                }
                // กีตาร์
                if (cbGuitar.Checked && int.TryParse(tbGuitar.Text, out int guitarQty))
                {
                    total = total + (guitarQty * 20);
                }

                // เบส
                if (cbBass.Checked && int.TryParse(tbBass.Text, out int bassQty))
                {
                    total = total + (bassQty * 15);
                }

                // คีย์บอร์ด
                if (cbKeyboard.Checked && int.TryParse(tbKeyboard.Text, out int keyboardQty))
                {
                    total = total + (keyboardQty * 10);
                }

                // กลอง
                if (cbDrum.Checked && int.TryParse(tbDrum.Text, out int DrumQty))
                {
                    total = total + (DrumQty * 30);
                }

                // แสดงผลที่ lbTotal
                lbTotal.Text = total.ToString("N2");


            }
            else
            {

                // ข้อความเตือนได้ถูกแสดงไปแล้วภายในฟังก์ชัน ValidateAndPrepareData()
                // ไม่ต้องทำอะไรเพิ่มเติมในนี้
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {

            // เคลียร์ หน้าจอ
            ClearFormFields();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // บันทึกลง DB -> แสดง MSG -> ปิดหน้าจอ -> กลับไปยังหน้า FrmProductShow
            //กำหนด connect String เพื่อติดต่อไปยังฐานข้อมูล
            string connectionstring = @"server=DESKTOP-HMDSMC8\SQLEXPRESS;Database=musicrent_db;Trusted_Connection=True;";

            // สร้าง connection ไปยังฐานข้อมูล
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                try
                {
                    sqlConnection.Open();

                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(); // ใช้กับ Insert/update/delete

                    //คำสั่ง SQL
                    string strSQL = @"INSERT INTO musicroom_tb
                            (rentName, rentPhone,rentHour,guitar,base,keyboard,drum,rentPay,payStatus)
                            VALUES
                            (@rentName, @rentPhone,@rentHour,@guitar,@base,@keyboard,@drum,@rentPay,@payStatus)";

                    // กำหนดค่าให้กับ SQL Parameter  และสั่งให้คำสั่ง SQL ทำงาน  แล้วมีข้อความแจ้งเมื่อทำงานเสร็จแล้ว
                    using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                    {
                        sqlCommand.Parameters.Add("@rentName", SqlDbType.NVarChar, 150).Value = tbName.Text;
                        sqlCommand.Parameters.Add("@rentPhone", SqlDbType.NVarChar, 50).Value = tbPhone.Text;
                        sqlCommand.Parameters.Add("@rentHour", SqlDbType.Int).Value = int.Parse(tbHour.Text);
                        sqlCommand.Parameters.Add("@guitar", SqlDbType.Int).Value = int.Parse(tbGuitar.Text);
                        sqlCommand.Parameters.Add("@base", SqlDbType.Int).Value = int.Parse(tbBass.Text);
                        sqlCommand.Parameters.Add("@keyboard", SqlDbType.Int).Value = int.Parse(tbKeyboard.Text);
                        sqlCommand.Parameters.Add("@drum", SqlDbType.Int).Value = int.Parse(tbDrum.Text);
                        sqlCommand.Parameters.Add("@rentPay", SqlDbType.Float).Value = double.Parse(lbTotal.Text);
                        if (rdoUnpaid.Checked == true)
                        {
                            sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = "ยังไม่ชำระ";
                        }
                        else
                        {
                            sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = "ชำระแล้ว";
                        }

                        //สั่งให้คำสั่ง sql ทำงาน
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        //ข้อความแจ้ง
                        MessageBox.Show("บันทึกเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        getAllDataToLV();   // โหลดข้อมูลใหม่
                        ClearFormFields();  // เคลียร์ หน้าจอ



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด  กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // 1. ตรวจสอบว่ามีรายการใน ListView ที่ถูกเลือกอยู่หรือไม่
            if (lvAllData.SelectedItems.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไขก่อน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. ดึง rentId
            ListViewItem selectedItem = lvAllData.SelectedItems[0];
            if (!int.TryParse(selectedItem.SubItems[0].Text, out int rentIdToUpdate))
            {
                MessageBox.Show("ไม่สามารถดึงรหัสรายการ (Rent ID) ได้", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. ตรวจสอบและแปลงข้อมูลจากฟอร์ม
            string rentName = tbName.Text.Trim();
            string rentPhone = tbPhone.Text.Trim();

            if (!int.TryParse(tbHour.Text.Trim(), out int rentHour))
            {
                MessageBox.Show("กรุณากรอกจำนวนชั่วโมงให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int guitar = int.TryParse(tbGuitar.Text.Trim(), out int g) ? g : 0;
            int bass = int.TryParse(tbBass.Text.Trim(), out int b) ? b : 0;
            int keyboard = int.TryParse(tbKeyboard.Text.Trim(), out int k) ? k : 0;
            int drum = int.TryParse(tbDrum.Text.Trim(), out int d) ? d : 0;

            double rentPay = double.TryParse(lbTotal.Text.Trim(), out double totalPay) ? totalPay : 0.0;

            string payStatus = rdoUnpaid.Checked ? "ยังไม่ชำระ" : "ชำระแล้ว";

            // 4. เชื่อมต่อและอัปเดตฐานข้อมูล
            string connectionstring = @"server=DESKTOP-HMDSMC8\SQLEXPRESS;Database=musicrent_db;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                SqlTransaction sqlTransaction = null;
                try
                {
                    sqlConnection.Open();
                    sqlTransaction = sqlConnection.BeginTransaction();

                    string strSQL = @"UPDATE musicroom_tb
                            SET rentName = @rentName,
                                rentPhone = @rentPhone,
                                rentHour = @rentHour,
                                guitar = @guitar,
                                base = @base,
                                keyboard = @keyboard,
                                drum = @drum,
                                rentPay = @rentPay,
                                payStatus = @payStatus
                            WHERE rentId = @rentId";

                    using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                    {
                        sqlCommand.Parameters.Add("@rentName", SqlDbType.NVarChar, 150).Value = rentName;
                        sqlCommand.Parameters.Add("@rentPhone", SqlDbType.NVarChar, 50).Value = rentPhone;
                        sqlCommand.Parameters.Add("@rentHour", SqlDbType.Int).Value = rentHour;
                        sqlCommand.Parameters.Add("@guitar", SqlDbType.Int).Value = guitar;
                        sqlCommand.Parameters.Add("@base", SqlDbType.Int).Value = bass;
                        sqlCommand.Parameters.Add("@keyboard", SqlDbType.Int).Value = keyboard;
                        sqlCommand.Parameters.Add("@drum", SqlDbType.Int).Value = drum;
                        sqlCommand.Parameters.Add("@rentPay", SqlDbType.Float).Value = rentPay;
                        sqlCommand.Parameters.Add("@payStatus", SqlDbType.NVarChar, 50).Value = payStatus;
                        sqlCommand.Parameters.Add("@rentId", SqlDbType.Int).Value = rentIdToUpdate;

                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        MessageBox.Show("บันทึกแก้ไขเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields();
                        getAllDataToLV();
                    }
                }
                catch (Exception ex)
                {
                    try { sqlTransaction?.Rollback(); } catch { }
                    MessageBox.Show("พบข้อผิดพลาด:\n" + ex.ToString(), "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btDelete_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีรายการใน ListView (หรือ DataGridView) ที่ถูกเลือกหรือไม่
            if (lvAllData.SelectedItems.Count > 0) // ตรวจสอบว่ามีรายการถูกเลือกใน lvAllData หรือไม่
            {
                // ยืนยันการลบข้อมูล
                DialogResult confirmResult = MessageBox.Show(
                    "คุณต้องการลบข้อมูลนี้หรือไม่?",
                    "ยืนยันการลบ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmResult == DialogResult.Yes)
                {
                    // รับรายการที่ถูกเลือกรายการแรก
                    ListViewItem selectedItem = lvAllData.SelectedItems[0];

                    //  ดึง rentId จาก SubItems[0] (คอลัมน์แรกของ ListView)
                    //    ตรวจสอบให้แน่ใจว่า rentId อยู่ใน SubItems[0] หรือ SubItems ที่ถูกต้องตาม ListView ของคุณ
                    int rentIdToDelete;
                    // ตรวจสอบว่ามี SubItems เพียงพอและสามารถแปลงเป็น int ได้
                    if (selectedItem.SubItems.Count > 0 && int.TryParse(selectedItem.SubItems[0].Text, out rentIdToDelete))
                    {
                        // กำหนด connect String เพื่อติดต่อไปยังฐานข้อมูล
                        string connectionstring = @"server=DESKTOP-HMDSMC8\SQLEXPRESS;Database=musicrent_db;Trusted_Connection=True;";

                        // สร้าง connection ไปยังฐานข้อมูล
                        using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                        {
                            SqlTransaction sqlTransaction = null; // ประกาศ Transaction นอก try เพื่อให้ Rollback ได้ใน catch
                            try
                            {
                                sqlConnection.Open();

                                sqlTransaction = sqlConnection.BeginTransaction(); // ใช้กับ Insert/update/delete

                                //คำสั่ง SQL
                                string strSQL = "DELETE FROM musicroom_tb WHERE rentId=@rentId";

                                // กำหนดค่าให้กับ SQL Parameter และสั่งให้คำสั่ง SQL ทำงาน
                                using (SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                                {
                                    // กำหนดค่าให้กับ SQL Parameter @rentId ด้วยค่าที่ดึงมาจาก ListView
                                    sqlCommand.Parameters.Add("@rentId", SqlDbType.Int).Value = rentIdToDelete;

                                    //สั่งให้คำสั่ง sql ทำงาน
                                    sqlCommand.ExecuteNonQuery();
                                    sqlTransaction.Commit();

                                    //ข้อความแจ้ง
                                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // หลังจากลบข้อมูลสำเร็จ:
                                    ClearFormFields();          // ล้างข้อมูลในฟอร์ม
                                    getAllDataToLV();   // โหลดข้อมูลใหม่เข้า DataGridView (หรือ ListView)
                                }
                            }
                            catch (Exception ex)
                            {
                                // ถ้าเกิดข้อผิดพลาด ให้ Rollback transaction
                                if (sqlTransaction != null)
                                {
                                    try
                                    {
                                        sqlTransaction.Rollback();
                                    }
                                    catch (Exception rbEx)
                                    {
                                        MessageBox.Show("เกิดข้อผิดพลาดขณะ Rollback transaction: " + rbEx.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                MessageBox.Show("พบข้อผิดพลาด กรุณาลองใหม่หรือติดต่อ IT : " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        // กรณีที่ดึง rentId ไม่ได้ (เช่น SubItems[0] ไม่มีค่า หรือแปลงไม่ได้)
                        MessageBox.Show("ไม่สามารถดึงรหัสรายการที่ต้องการลบได้ กรุณาลองใหม่อีกครั้ง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // ไม่มีรายการใดถูกเลือก
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบก่อน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}




