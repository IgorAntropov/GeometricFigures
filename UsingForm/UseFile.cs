using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UsingForm
{
    class UseFile
    {
        public void SaveAs(DataGridView dataGridView1)
        {
            System.IO.Stream myStream;
            var saveTags = new SaveFileDialog();
            saveTags.Filter = @"All file (*.*) | *.*| Text file |*.txt";
            saveTags.FilterIndex = 2;
            if (saveTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveTags.OpenFile()) != null)
                {
                    System.Text.Encoding.GetEncoding(1251);
                    StreamWriter myWriter = new StreamWriter(myStream);
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            if ((dataGridView1.ColumnCount - j) != 1) myWriter.Write(":");
                        }

                        if ((dataGridView1.RowCount) != 0) myWriter.WriteLine();
                    }
                    myWriter.Close();
                }
                myStream.Close();
            }
        }

        public void Save(DataGridView dataGridView1, string path)
        {
            using (var myStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                System.Text.Encoding.GetEncoding(1251);
                StreamWriter myWriter = new StreamWriter(myStream);
                for (var i = 0; i<dataGridView1.RowCount; i++)
                {
                    for (var j = 0; j<dataGridView1.ColumnCount; j++)
                    {
                        myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        if ((dataGridView1.ColumnCount - j) != 1) myWriter.Write(":");
                    }

                    if ((dataGridView1.RowCount) != 0) myWriter.WriteLine();
                }
                myWriter.Close();
            }
        }

        public void Load(DataGridView dataGridView1, string path)
        {
            Stream myStr = null;
            var OpenTags = new OpenFileDialog();
            OpenTags.Filter = @"All file (*.*) | *.*| Text file |*.txt";
            OpenTags.FilterIndex = 2;
            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStr = OpenTags.OpenFile()) != null)
                {

                    var myRead = new StreamReader(myStr, System.Text.Encoding.UTF8);
                    string[] str;

                    var num = 1;
                    var str1 = myRead.ReadToEnd().Split('\n');
                    num = str1.Count();
                    dataGridView1.RowCount = num - 1;
                    for (var i = 0; i < num - 1; i++)
                    {
                        str = str1[i].Split(':');
                        for (var j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = str[j];
                        }
                    }
                    myRead.Close();
                }
            }
        }
    }
}
