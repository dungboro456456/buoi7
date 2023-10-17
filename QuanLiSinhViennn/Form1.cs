using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiSinhViennn
{
    public partial class Form1 : Form
    {
        private string MyConnection = "SERVER=localhost;" +
            "DATABASE=qlisinhvien;" +
            "UID=sa;" +
            "PASSWORD=Dungboro1;";

        private int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string mssv = textboxMasv.Text;
            string name = textBoxName.Text;
            string tuoiText = textBoxTuoi.Text;
            bool gioiTinh = radiobtnam.Checked;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(mssv) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(tuoiText))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return; // Abort the insertion if any field is empty.
            }

            // Check for duplicate mssv
            if (IsMssvExists(mssv))
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại. Vui lòng chọn một mã số khác.");
                return; // Abort the insertion if mssv is a duplicate.
            }

            // Proceed with the insertion
            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                connection.Open();

                string query = "INSERT INTO sinhvien  VALUES (@mssv, @name, @ngaysinh, @gioitinh)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(tuoiText));
                    command.Parameters.AddWithValue("@gioitinh", gioiTinh);
                    command.Parameters.AddWithValue("@mssv", mssv);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm sinh viên " + mssv + " thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sinh viên thất bại.");
                    }
                }
            }

            lammoi();
        }

        // Function to check for duplicate mssv
        private bool IsMssvExists(string mssv)
        {
            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM sinhvien WHERE mssv = @mssv";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mssv", mssv);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lammoi()
        {
            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                connection.Open();

                string query = "SELECT Mssv, Name, NgaySinh, GioiTinh, HinhAnh FROM SinhVien";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                        imageColumn.HeaderText = "Hình ảnh";
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        dataGridView1.Columns.Add(imageColumn);

                        foreach (DataRow drow in dataTable.Rows)
                        {
                            byte[] imageBytes = (byte[])drow["HinhAnh"];
                            Image image = Image.FromStream(new MemoryStream(imageBytes));
                            dataGridView1.Rows.Add(drow["Mssv"], drow["Name"], drow["NgaySinh"], drow["GioiTinh"], image);
                        }
                    }
                }
            }
        }


        private void btLamMoi_Click(object sender, EventArgs e)
        {
            lammoi();
            textboxMasv.Text = String.Empty;
            textBoxName.Text = String.Empty;
            textBoxTuoi.Text = String.Empty;
            tbTimkiem.Text = String.Empty;
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textboxMasv.Text = row.Cells[0].Value.ToString();
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxTuoi.Text = row.Cells[2].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                connection.Open();

                string query = "UPDATE sinhvien SET name = @name, ngaysinh = @ngaysinh, gioitinh = @gioitinh WHERE mssv = @mssv";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(textBoxTuoi.Text));
                    command.Parameters.AddWithValue("@gioitinh", radiobtnam.Checked);
                    command.Parameters.AddWithValue("@mssv", textboxMasv.Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin sinh viên " + textboxMasv.Text + " thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin sinh viên thất bại.");
                    }
                }
            }
            lammoi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                connection.Open();

                string query = "DELETE  from sinhvien  WHERE mssv = @mssv ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(textBoxTuoi.Text));
                    command.Parameters.AddWithValue("@gioitinh", radiobtnam.Checked);
                    command.Parameters.AddWithValue("@mssv", textboxMasv.Text);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thông tin sinh viên " + textboxMasv.Text + " thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin sinh viên" + textboxMasv.Text + " thất bại.");
                    }
                }
            }
            lammoi();
        }

        private void button1_TimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                connection.Open();

                string query = "select *  from sinhvien  WHERE mssv like @input or ngaysinh like @input or gioitinh like @input or name like @input";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@input", "%" + tbTimkiem.Text + "%");
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên tương ứng với thông tin " + tbTimkiem.Text);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
