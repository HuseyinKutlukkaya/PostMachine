using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms;

namespace PostMakinası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index=0;
        int emirno=1;
        ArrayList Dizi = new ArrayList();
        ArrayList Emirler = new ArrayList();
        ArrayList Aciklama = new ArrayList();
        List<ArrayList> Cozum = new List<ArrayList>();
        List<int> imlec  = new List<int>();
        int sira = 0;
        ArrayList liste = new ArrayList();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             x2
             2->3
             ?4;2
             v5
             ->6
             ?8;7
             !
             <-9
             ?10;8
             ->1
             
             */
            tb2.Font = rbKodYeri.Font;
            rbKodYeri.Select();
            SatirNumarasiEkle();

            liste.Add("!");
            liste.Add("?");
            liste.Add("v");
            liste.Add("x");
            index = 0;

            BaslangicTablo();

        }
        void Coz()
        {
            dataGridView2.Columns.Clear();

            emirno = 1;

            Emirler.Clear();
            Aciklama.Clear();
            imlec.Clear();
            Cozum.Clear();
            sira = 0;
            if (EmirleriCikar() == false)
            {
                return;
            }


            EmirUygula();
        }
        private void btn_Coz_Click(object sender, EventArgs e)
        {
            btnIleri.Enabled = true;
            btnGeri.Enabled = true;
            Coz();
         
        }
        void BaslangicTablo()
        {
            Dizi.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Columns[i].Width = 40;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            dataGridView1.Rows.Add("");
            dataGridView1.Rows.Add("");
            dataGridView1.Rows[1].Cells[index].Style.BackColor = Color.Green;
            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = "0";
                Dizi.Add("0");
            }
            dataGridView1.Rows[0].DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);

        }
     
         bool Sayimi(string value)
        {
                
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsPunctuation(value[i]))
                    return false;
            }
          
            
            double oReturn = 0;
            return double.TryParse(value, out oReturn);
        }
        bool EmirleriCikar()
        {
            Emirler.Clear();
            Emirler.AddRange(rbKodYeri.Text.Replace(" ","").Split('\n'));
         

            for (int i = 0; i < Emirler.Count; i++)
            {
                if (Emirler[i].ToString() == "")
                {
                    MessageBox.Show("Emirlerde boş satır olamaz!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                                 
            }
            for (int i = 0; i < Emirler.Count; i++)
            { string a = Emirler[i].ToString();
                if(liste.Contains( Emirler[i].ToString().Substring(0,1).ToLower()))
                {
                    a = a.Substring(1);

                   if (Emirler[i].ToString().Substring(0, 1).ToLower() == "!")
                    {
                        if(a!="")
                        {
                            MessageBox.Show("! Emirinden sonra bir ifade gelemez!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else if (Sayimi(a))
                    {
                        if (Convert.ToInt32(a)>Emirler.Count)
                        {
                            MessageBox.Show("Emirlerde bir sonraki emir kodu index dışı!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }


                    }  
                    else if (Emirler[i].ToString().Substring(0, 1).ToLower()=="?")
                    {
                        int sayi = 0;
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j].ToString()==";")
                            {
                                sayi++;
                                if(sayi==2)
                                {
                                    MessageBox.Show("? birden fazla ';' içeremez!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                        if (sayi==0)
                        {
                            MessageBox.Show("? bir adet ';' içermelidir!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (Sayimi(a.Replace(";","")))//sayisal ise
                        {
                            int b, c;
                            b =Convert.ToInt32( a.Substring(0, a.IndexOf(';') )  );
                            c = Convert.ToInt32(a.Substring( a.IndexOf(';') + 1  ));
                            if (b > Emirler.Count||c>Emirler.Count)
                            {
                                MessageBox.Show("Emirlerde bir sonraki emir kodu index dışı!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                        }
                        else//değil ise
                        {
                            MessageBox.Show("Emirlerde bir sonraki emir kodu sayı olmalıdır!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Emirlerde bir sonraki emir kodu sayı olmalıdır!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    if(a.Length>=2)
                    a = a.Substring(2);
                    else
                    {
                        MessageBox.Show("Sadece post makinası emirlerini kullanınız!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (Emirler[i].ToString().Substring(0, 1)=="<")
                    {
                        if (Emirler[i].ToString().Substring(1, 1) == "-")
                        {
                            if (Sayimi(a)==true)
                            {
                                if( Convert.ToInt32(a) <= Emirler.Count)
                                Emirler[i] = Emirler[i].ToString().Replace("-", "");
                                else
                                {
                                    MessageBox.Show("Emirlerde bir sonraki emir kodu sayı ve var olmalıdır!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            } 
                            else
                            {
                                MessageBox.Show("Emirlerde bir sonraki emir kodu sayı ve var olmalıdır!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sadece post makinası emirlerini kullanınız!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else if(Emirler[i].ToString().Substring(0, 1) == "-")
                    {
                        if (Emirler[i].ToString().Substring(1, 1) == ">")
                        {
                            if (Sayimi(a) )
                            {
                                if( Convert.ToInt32(a) <= Emirler.Count)
                                Emirler[i] = Emirler[i].ToString().Replace("-", "");
                                else
                                {
                                    MessageBox.Show("Emirlerde bir sonraki emir kodu sayı ve var olmalıdır!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Emirlerde bir sonraki emir kodu sayı ve var olmalıdır!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sadece post makinası emirlerini kullanınız!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sadece post makinası emirlerini kullanınız!!!", "Satır No=" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                    //kontrol+- silme

                }

            }
            return true;
        }
        void EmirUygula()
        {
            char[] dizi;
            dizi = Emirler[emirno - 1].ToString().ToCharArray();
            if(imlec.Count>150)
            {
                MessageBox.Show("Sonsuz Döngüye Girildi","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                CozumEkle("SONSUZ DÖNGÜ");
                Dur();
                return;
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].ToString()=="<")
                {
                    CozumEkle(Emirler[emirno - 1].ToString());
                    Sol(Convert.ToInt32(Emirler[emirno-1].ToString().Substring(i+1)  ));
                }
                else if (dizi[i].ToString() == ">")
                {
                    CozumEkle(Emirler[emirno - 1].ToString());

                    Sag(Convert.ToInt32(Emirler[emirno - 1].ToString().Substring(i + 1)));

                }
                else if (dizi[i].ToString().ToLower() == "v")
                {
                    CozumEkle(Emirler[emirno - 1].ToString());

                    V(Convert.ToInt32(Emirler[emirno - 1].ToString().Substring(i + 1)));

                }
                else if (dizi[i].ToString().ToLower() == "x")
                {
                    CozumEkle(Emirler[emirno - 1].ToString());

                    X(Convert.ToInt32(Emirler[emirno - 1].ToString().Substring(i + 1)));

                }
                else if (dizi[i].ToString() == "?")
                {
                    CozumEkle(Emirler[emirno - 1].ToString());

                    If(Convert.ToInt32(Emirler[emirno - 1].ToString().Substring(i + 1, Emirler[emirno - 1].ToString().IndexOf(";") - i-1)), Convert.ToInt32(Emirler[emirno - 1].ToString().Substring(Emirler[emirno - 1].ToString().IndexOf(";") + 1)));
                }
                else if (dizi[i].ToString() == "!")
                {
                    CozumEkle(Emirler[emirno - 1].ToString());
                    Dur();
                }
                
            }
        }
        void HaraketEt(int yon)
        {
            if (yon==0)
            {
                if(index-1>=0)
                {
                    ImlecYerDegisgir(-1);

                }
                else
                {
                    SolaEkle();
                    ImlecYerDegisgir(-1);

                }
            }
            else if( yon==1)
            {
                if (index + 1 <Dizi.Count)
                {
                    ImlecYerDegisgir(1);

                }
                else
                {
                    SagaEkle();
                    ImlecYerDegisgir(1);

                }
            }
        }
        void Sag(int no)
        {
            HaraketEt(1);
            emirno = no;
            EmirUygula();
        }
        void Sol(int no)
        {
            HaraketEt(0);
            emirno = no;
            EmirUygula();
        }
        void If(int yanlis,int dogru)
        {
            if (Dizi[index].ToString()=="0")
            {
                emirno = yanlis;
                EmirUygula();
            }
            else
            {
                emirno = dogru;
                EmirUygula();
            }
        }
        void Dur()
        { 
            Goster();
           
        }
        void V(int no)
        {
            if (Dizi[index].ToString() == "0")
            {
                DegerDegistir();
                emirno = no;
                EmirUygula();
            }
            else
            {
                MessageBox.Show("Dolu Hücrenin Üstüne  Yazılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CozumEkle("Dolu Hücrenin Üstüne  Yazılamaz");
                Dur();
            }

        }
        void X(int no)
        {
            if (Dizi[index].ToString()=="1")
            {
                DegerDegistir();
                emirno = no;
                EmirUygula();
            }
            else
            {
                MessageBox.Show("Boş Hücre Silinemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CozumEkle("Boş Hücre Silinemez ");
                Dur();
            }
         
        }
        void SagaEkle()
        {
            try
            {
              
                    Dizi.Add("0");

                    dataGridView1.Columns.Add("", (Dizi.Count - 1).ToString());
                    dataGridView1.Columns[Dizi.Count - 1].Width = 40;

                
            }
            catch (Exception)
            {

            }
          
        }
        void SolaEkle()
        {
            try
            {
             
                            Dizi.Insert(0, "0");
                            dataGridView1.Columns.Add("", (Dizi.Count-1).ToString());
                            dataGridView1.Columns[Dizi.Count - 1].Width = 40;

                        
                        Kaydir();
            }
            catch (Exception)
            {

            }
          
        }
        void Kaydir()
        {
            ImlecYerDegisgir(1);

            for (int i = 0; i < Dizi.Count; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = Dizi[i].ToString();
            }
        }
         void CozumEkle(string e)
        {
            Cozum.Add(new ArrayList());
            imlec.Add(index);
            Cozum[Cozum.Count - 1].AddRange(Dizi);
            if (e.Contains("<"))
                e = e.Replace("<", "<-");
            else if (e.Contains(">"))
                e = e.Replace(">", "->");

            Aciklama.Add(e);
        }
        void ImlecYerDegisgir(int no)
        {
            try
            {
             dataGridView1.Rows[1].Cells[index].Style.BackColor = dataGridView1.Rows[1].Cells[index + 1].Style.BackColor;
            index += no;
            dataGridView1.Rows[1].Cells[index].Style.BackColor = Color.Green;
            }
            catch (Exception)
            {

            }
         
        }
            void DegerDegistir()
        {
            if (dataGridView1.Rows[0].Cells[index].Value.ToString() == "0")
            {
                dataGridView1.Rows[0].Cells[index].Value = "1";
                Dizi[index] = dataGridView1.Rows[0].Cells[index].Value.ToString();
            }
            else
            {
                dataGridView1.Rows[0].Cells[index].Value = "0";
                Dizi[index] = dataGridView1.Rows[0].Cells[index].Value.ToString();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex<0||e.RowIndex<0)
            {

                return;
            }
            if (e.RowIndex==0)
            {
                if (dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString()=="0")
                {
                    dataGridView1.Rows[0].Cells[e.ColumnIndex].Value = "1";
                    Dizi[e.ColumnIndex] = dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                }
                else 
                {
                    dataGridView1.Rows[0].Cells[e.ColumnIndex].Value = "0";
                    Dizi[e.ColumnIndex] = dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            else if(e.RowIndex==1)
            {
                
                dataGridView1.Rows[1].Cells[index].Style.BackColor = dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor;
                dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                index = e.ColumnIndex;


            }

        }
        void Goster()
        {   int h = dataGridView2.HorizontalScrollingOffset;
            lblAktifKural.Text = Aciklama[sira].ToString();
            dataGridView2.Columns.Clear();
            for (int i = 0; i < Dizi.Count; i++)
            {
                dataGridView2.Columns.Add("",i.ToString());
                dataGridView2.Columns[i].Width = 40;


            }
            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();

            dataGridView2.Rows[1].Cells[imlec[sira]].Style.BackColor = Color.Green;
            for (int i = 0; i < Cozum[sira].Count; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = Cozum[sira][i].ToString();

            }
            dataGridView2.HorizontalScrollingOffset = h;


        }
        void ileri()
        {
            if(sira+1<Cozum.Count)
            {
                if (btnGeri.Enabled == false)
                    btnGeri.Enabled = true;
                sira++;

                Goster();

            }
            else
            {
                btnIleri.Enabled = false;
            }

           
        }
        void geri()
        {
            if (sira - 1 >= 0)
            {
                if(btnIleri.Enabled==false)
                    btnIleri.Enabled = true;

                sira--;


                  Goster();
            }
            else
            {
                btnGeri.Enabled = false;
            }
             

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ileri();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            geri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolaEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SagaEkle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnIleri.Enabled = true;
            btnGeri.Enabled = true;
            dataGridView2.Columns.Clear();

            BaslangicTablo();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
      
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                int rowHeaderWidth = dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0;
                Rectangle rowBounds = new Rectangle(rowHeaderWidth, e.RowBounds.Top, dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) - dataGridView1.HorizontalScrollingOffset + 1, e.RowBounds.Height);

             
                Pen blackPen = new Pen(Color.Black, 2);



                e.Graphics.DrawRectangle(blackPen, rowBounds);
                // Paint the background color 
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                Color.LightGray;
            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                int rowHeaderWidth = dataGridView2.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0;
                Rectangle rowBounds = new Rectangle(rowHeaderWidth, e.RowBounds.Top, dataGridView2.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) - dataGridView2.HorizontalScrollingOffset + 1, e.RowBounds.Height);

            
                Pen blackPen = new Pen(Color.Black, 2);



                e.Graphics.DrawRectangle(blackPen, rowBounds);
                // Paint the background color 
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                Color.LightGray;
            }
        }



        public int getWidth()
        {
            int w = 25;
            int line = rbKodYeri.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)rbKodYeri.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)rbKodYeri.Font.Size;
            }
            else
            {
                w = 50 + (int)rbKodYeri.Font.Size;
            }

            return w;
        }
        public void SatirNumarasiEkle()
        {
            Point pt = new Point(0, 0);
            int ilkIndex = rbKodYeri.GetCharIndexFromPosition(pt);
            int ilkSatir = rbKodYeri.GetLineFromCharIndex(ilkIndex);

            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int sonIndex = rbKodYeri.GetCharIndexFromPosition(pt);
            int sonSatir = rbKodYeri.GetLineFromCharIndex(sonIndex);
            tb2.SelectionAlignment = HorizontalAlignment.Center;
            tb2.Text = "";
            tb2.Width = getWidth();
            for (int i = ilkSatir; i <= sonSatir + 2; i++)
            {
                tb2.Text += i + 1 + "\n";
            }
        }
        private void rbKodYeri_TextChanged(object sender, EventArgs e)
        {
            if (rbKodYeri.Text != "")
            {
                SatirNumarasiEkle();
            }
        }

        private void rbKodYeri_VScroll(object sender, EventArgs e)
        {
            tb2.Text = "";
            SatirNumarasiEkle();
            tb2.Invalidate();
        }

        private void rbKodYeri_FontChanged(object sender, EventArgs e)
        {
            tb2.Font = rbKodYeri.Font;
            rbKodYeri.Select();
            SatirNumarasiEkle();
        }

        private void rbKodYeri_SelectionChanged(object sender, EventArgs e)
        {
            tb2.Font = rbKodYeri.Font;
            rbKodYeri.Select();
            SatirNumarasiEkle();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();

            rbKodYeri.Text = "X 2\n->3\n? 4; 2\nV 5\n->6\n? 8; 7\n!\n<-9\n? 10; 8\n->1";
            Coz();
        }

        private void btnFark_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();

            rbKodYeri.Text = "->2\n?3;1\n<-4\nX  5\n<-6 \n?7;11\n->8\n?7;9\nX 10\n!\n-> 12\n?11;13\nX 14\n-> 15\n?10;16\n<-17\n?16;4";
            Coz();
        }
    }
}
